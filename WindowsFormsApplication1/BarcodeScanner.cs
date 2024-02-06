using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;


namespace WindowsFormsApplication1
{
    public class BarcodeScanner
    {
        /// <summary>
        /// 得到新条码  barcode,comNo
        /// </summary>
        public event Action<string,string> OnNewBarcode;


        /// <summary>
        /// 准备关闭串口=true
        /// </summary>
        private bool m_IsTryToClosePort = false;
        /// <summary>
        /// true表示正在接收数据
        /// </summary>
        private bool m_IsReceiving = false;

        System.IO.Ports.SerialPort port = null;

        /// <summary>
        /// 接收字节当前指针
        /// </summary>
        int reDatePoint = 0;
        static int reDateNum = 1024;
        byte[] reDate = new byte[reDateNum];

        /// <summary>
        /// 串口号
        /// </summary>
        public string PORTNAME
        {
            get
            {
                if (port.IsOpen)
                    return port.PortName;
                else
                    return "";

            }
        }


        public BarcodeScanner()
        {
        }
        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="dkh">端口号</param>
        /// <param name="sl">速率</param>
        /// <returns></returns>
        public bool OpenCom(string dkh, int sl)
        {
            //port.Dispose();
            port = new SerialPort();
            port.DataReceived -= new SerialDataReceivedEventHandler(port_DataReceived);
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            port.BaudRate = sl;
            port.PortName = dkh;
            port.DataBits = 8;
            port.Parity = Parity.None;
            port.StopBits = StopBits.One;
            port.ReceivedBytesThreshold = 1;


            reDate = new byte[reDateNum];
            reDatePoint = 0;

            try
            {
                m_IsTryToClosePort = false;
                if (!port.IsOpen)
                {
                    port.Open();
                    //MessageBox.Show(string.Format("{0} 串口打开成功", Portnum));
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
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
                    if (reb == (char)10)
                        continue;
                    if (reb == (char)13)
                    {
                        if (this.OnNewBarcode != null)
                        {
                            try
                            {
                                this.OnNewBarcode(System.Text.ASCIIEncoding.GetEncoding("GB2312").GetString(reDate, 0, reDatePoint), port.PortName);
                            }
                            catch (Exception ee)
                            {
                                System.Windows.Forms.MessageBox.Show(ee.Message);
                            }
                            ////测试时添加的程序，正式系统删除掉//////
                            port.DiscardInBuffer();
                            /////////////////////////////////////////
                        }
                        reDate = new byte[reDateNum];
                        reDatePoint = 0;
                        continue;
                    }
                    if (reDatePoint < reDateNum)
                    {
                        reDate[reDatePoint] = reb;
                        if (reDatePoint == reDateNum - 1)
                        {
                            reDate = new byte[reDateNum];
                            reDatePoint = 0;
                        }
                        else
                        {
                            reDatePoint++;
                        }
                    }

                }
            }
            catch (Exception ee)
            {
                reDate = new byte[reDateNum];
                reDatePoint = 0;
                System.Windows.Forms.MessageBox.Show(ee.Message);
            }
            finally // 放在finally里面比较好。
            {
                m_IsReceiving = false; // 关键!!!
            }

        }

        /// <summary>
        /// 关闭串口
        /// </summary>
        /// <returns></returns>
        public bool CloseCom()
        {
            if (port != null && port.IsOpen)
            {
                m_IsTryToClosePort = true;
                while (m_IsReceiving)
                {
                    System.Windows.Forms.Application.DoEvents();
                }
                port.Close();
                return true;
            }
            else
                return false;

        }
    }
}
