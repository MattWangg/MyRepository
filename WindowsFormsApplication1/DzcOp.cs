using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace WindowsFormsApplication1
{
    public class DzcOp
    {
        /// <summary>
        /// 得到新产品
        /// </summary>
        //public event Action<float> OnNewCp;
        /// <summary>
        /// 显示当前重量 重量，单位，是否稳定值
        /// </summary>
        public event Action<float?,string,bool> OnShowZl;

        public event Action<string> OnReDate;

        /// <summary>
        /// 准备关闭串口=true
        /// </summary>
        private bool m_IsTryToClosePort = false;
        /// <summary>
        /// true表示正在接收数据
        /// </summary>
        private bool m_IsReceiving = false;


        System.IO.Ports.SerialPort port = new SerialPort();
        const byte BStar = 0X02;
        const byte BEnd = 0X0D;
        /// <summary>
        /// 接收命令字节长度
        /// </summary>
        const int reDateNum = 1024;
        /// <summary>
        /// 接收字节当前指针
        /// </summary>
        int reDatePoint = 0;
        byte[] reDate = new byte[reDateNum];

        /// <summary>
        /// 命令列表  清零
        /// </summary>
        List<string> CmdList = new List<string>();

        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="dkh">端口号</param>
        /// <param name="sl">速率</param>
        /// <returns>0打开成功   1串口已经打开  2打开串口失败</returns>
        public string OpenCom(string dkh, int sl)
        {
            if (port != null && port.IsOpen)
            {
                return "串口已经打开";
            }
            m_IsTryToClosePort = false;
            //port = new SerialPort();
            port.DataReceived -= new SerialDataReceivedEventHandler(port_DataReceived);
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            port.BaudRate = sl;
            port.PortName = dkh;
            port.DataBits = 8;// 8;
            port.Parity = Parity.None;
            port.StopBits = StopBits.One;
            
            port.ReceivedBytesThreshold = 1;

            CmdList = new List<string>();
            reDate = new byte[reDateNum];
            reDatePoint = 0;
            try
            {
                port.Open();

                ///发送命令
                System.Threading.Thread th = new System.Threading.Thread(new System.Threading.ThreadStart(SendCmd));
                th.Start();

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void AddCmd(string cmdstr)
        {
            CmdList.Add(cmdstr);
        }

        /// <summary>
        /// 接收到数据的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (m_IsTryToClosePort) // 关键！！！
            {
                return;
            }
            m_IsReceiving = true; // 关键!!!
            try
            {
                while (port.BytesToRead > 0)
                {
                    byte reb = (byte)port.ReadByte();

                    if (reDatePoint < reDateNum)
                    {
                        reDate[reDatePoint] = reb;
                        if (reDatePoint > 1 && reb == 10 && reDate[reDatePoint - 1] == 13)
                        {
                            System.Threading.Thread th = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(ReEnd));
                            th.Start(System.Text.Encoding.ASCII.GetString(reDate));

                            if (this.OnReDate != null)
                                this.OnReDate(System.Text.Encoding.ASCII.GetString(reDate));

                            reDate = new byte[reDateNum];
                            reDatePoint = 0;
                        }
                        else
                        {
                            reDatePoint++;
                        }
                    }
                    else
                    {
                        if (this.OnReDate != null)
                            this.OnReDate(reDate.ToString());
                        reDate = new byte[reDateNum];
                        reDatePoint = 0;
                    }
                }
            }
            catch (Exception ee)
            {
                //System.Windows.Forms.MessageBox.Show(ee.Message);
            }
            finally // 放在finally里面比较好。
            {
                m_IsReceiving = false; // 关键!!!
            }
        }

        private void ReEnd(object dateobj)
        {
            string datestr=dateobj.ToString();
            datestr = datestr.Replace("\r\n", "").Replace("\0","").Trim();
            if (string.IsNullOrWhiteSpace(datestr))
            {
                return;
            }
            try
            {
                switch (datestr.Substring(0, 1))
                {
                    ///返回稳定的重量值，格式：S_S_重量(10位)_单位\r\n
                    case "S":
                        if (datestr.Length >= 3)
                        {
                            //S稳定值  D不稳定值
                            if (datestr.Substring(2, 1) == "S" || datestr.Substring(2, 1) == "D")
                            {
                                if (datestr.Length >= 16)
                                {
                                    if (this.OnShowZl != null)
                                        this.OnShowZl(float.Parse(datestr.Substring(4, 10)), datestr.Substring(15, datestr.Length - 15), datestr.Substring(2, 1) == "S"?true:false);
                                }
                                else
                                {
                                    if (this.OnShowZl != null)
                                        this.OnShowZl(null, "",false);
                                }
                            }
                            else
                            {
                                if (this.OnShowZl != null)
                                    this.OnShowZl(null, "",false);
                            }

                        }
                        break;
                   default:
                        break;
                }
            }
            catch (Exception ee)
            { 
            
            }
 

        }

        /// <summary>
        /// 发送命令
        /// </summary>
        void SendCmd()
        {
            while (!m_IsTryToClosePort && port.IsOpen) // 关键！！！
            {
                if (CmdList.Count > 0)
                {
                    if (CmdList[0] == "清零")
                    {
                        port.Write("Z\r\n");
                        CmdList.RemoveAt(0);

                    }
                }
                else
                {
                    port.Write("SI\r\n");
                }
                System.Threading.Thread.Sleep(100);
            }
        }

        /// <summary>
        /// 关闭串口
        /// </summary>
        /// <returns></returns>
        public string CloseCom()
        {
            if (port != null && port.IsOpen)
            {
                m_IsTryToClosePort = true;
                while (m_IsReceiving)
                {
                    //System.Windows.Forms.Application.DoEvents();
                    System.Threading.Thread.Sleep(20);
                }
                port.Close();
                return "OK";
            }
            else
                return "串口未打开";

        }
    }
}
