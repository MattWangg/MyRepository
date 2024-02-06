using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            barModel.OnNewBarcode += barModel_OnNewBarcode;
            DbModel.OnShowZl += DbModel_OnShowZl;
            DbModel.OnReDate += DbModel_OnReDate;
            TpModel.OnShowZl += TpModel_OnShowZl;
            TpModel.OnReDate += TpModel_OnReDate;
        }

        







        #region 条码扫描器
        BarcodeScanner barModel = new BarcodeScanner();
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "连接")
            {

                if (barModel.OpenCom(txt_bar_dkh.Text.Trim(), int.Parse(txt_bar_btl.Text.Trim())))
                {
                    SetLbBarText("连接成功");
                    button4.Text = "断开";
                }
                else
                {
                    SetLbBarText("连接失败");

                }


            }
            else
            {
                if (barModel.CloseCom())
                {
                    SetLbBarText("断开连接成功");
                    button4.Text = "连接";
                }
                else
                {
                    SetLbBarText("断开连接失败");
                }
            }
        }
        void barModel_OnNewBarcode(string arg1, string arg2)
        {
            SetLbBarText("识别条码："+arg1+"   端口："+arg2);
        }

        void SetLbBarText(string msg)
        {
            if (this.InvokeRequired)
            {
                Action<string> slbth = new Action<string>(SetLbBarText);
                this.Invoke(slbth, msg);
            }
            else
            {
                if (lb_bar.Items.Count > 100)
                {
                    lb_bar.Items.Clear();
                }
                lb_bar.Items.Insert(0, msg);
            }
        }
        #endregion


        #region 地磅
        DzcOp DbModel = new DzcOp();
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "连接")
            {
                string res=DbModel.OpenCom(txt_db_dkh.Text.Trim(), int.Parse(txt_db_btl.Text.Trim()));
                if (res=="OK")
                {
                    SetLbDbText("连接成功");
                    button1.Text = "断开";
                }
                else
                {
                    SetLbDbText("连接失败：" + res);

                }


            }
            else
            {
                string res=DbModel.CloseCom();
                if (res=="OK")
                {
                    SetLbDbText("断开连接成功");
                    button1.Text = "连接";
                }
                else
                {
                    SetLbDbText("断开连接失败：" + res);
                }
            }
        }

        void DbModel_OnShowZl(float? obj, string unitStr, bool sfwdz)
        {
            if (this.InvokeRequired)
            {
                Action<float?,string,bool> newzlh = new Action<float?,string,bool>(DbModel_OnShowZl);
                this.Invoke(newzlh, new object[]{obj,unitStr,sfwdz});
            }
            else
            {
                if (obj == null)
                {
                    lb_db_num.Text = "----";
                }
                else
                {

                    lb_db_num.Text = (sfwdz ? "稳定  " : "动态  ") + obj.Value.ToString() + unitStr;
                }
            }
        }

        void SetLbDbText(string msg)
        {
            if (this.InvokeRequired)
            {
                Action<string> slbth = new Action<string>(SetLbDbText);
                this.Invoke(slbth, msg);
            }
            else
            {
                if (lb_db.Items.Count > 100)
                {
                    lb_db.Items.Clear();
                }
                lb_db.Items.Insert(0, msg);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DbModel .AddCmd("清零");
        }
        void DbModel_OnReDate(string obj)
        {
           SetLbDbText(obj);
        }
        #endregion 


        #region 天平
        DzcOp TpModel = new DzcOp();
        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "连接")
            {
                string res = TpModel.OpenCom(txt_tp_dkh.Text.Trim(), int.Parse(txt_tp_btl.Text.Trim()));
                if (res == "OK")
                {
                    SetLbTpText("连接成功");
                    button6.Text = "断开";
                }
                else
                {
                    SetLbTpText("连接失败：" + res);

                }


            }
            else
            {
                string res = TpModel.CloseCom();
                if (res == "OK")
                {
                    SetLbTpText("断开连接成功");
                    button6.Text = "连接";
                }
                else
                {
                    SetLbTpText("断开连接失败：" + res);
                }
            }
        }

        void TpModel_OnShowZl(float? obj, string unitStr,bool sfwdz)
        {
            if (this.InvokeRequired)
            {
                Action<float?,string,bool> newzlh = new Action<float?,string,bool>(TpModel_OnShowZl);
                this.Invoke(newzlh,new object[]{ obj,unitStr,sfwdz});
            }
            else
            {
                if (obj == null)
                {
                    lb_tp_num.Text = "----";
                }
                else
                {
                    
                    lb_tp_num.Text =(sfwdz?"稳定  ":"动态  ")+ obj.Value.ToString()+unitStr;
                }
            }
        }
        void TpModel_OnReDate(string obj)
        {
            SetLbTpText(obj);
        }
        /// <summary>
        /// 天平清零
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            TpModel.AddCmd("清零");
        }
        void SetLbTpText(string msg)
        {
            if (this.InvokeRequired)
            {
                Action<string> slbth = new Action<string>(SetLbTpText);
                this.Invoke(slbth, msg);
            }
            else
            {
                if (lb_tp.Items.Count > 100)
                {
                    lb_tp.Items.Clear();
                }
                lb_tp.Items.Insert(0, msg);
            }
        }
        #endregion

        


    }
}
