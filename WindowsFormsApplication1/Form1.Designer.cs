namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_db_dkh = new System.Windows.Forms.TextBox();
            this.gb_db = new System.Windows.Forms.GroupBox();
            this.lb_db_num = new System.Windows.Forms.Label();
            this.lb_db = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_db_btl = new System.Windows.Forms.TextBox();
            this.gb_bar = new System.Windows.Forms.GroupBox();
            this.lb_bar = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_bar_btl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bar_dkh = new System.Windows.Forms.TextBox();
            this.gb_tp = new System.Windows.Forms.GroupBox();
            this.lb_tp_num = new System.Windows.Forms.Label();
            this.lb_tp = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tp_btl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tp_dkh = new System.Windows.Forms.TextBox();
            this.gb_db.SuspendLayout();
            this.gb_bar.SuspendLayout();
            this.gb_tp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口号";
            // 
            // txt_db_dkh
            // 
            this.txt_db_dkh.Location = new System.Drawing.Point(76, 20);
            this.txt_db_dkh.Name = "txt_db_dkh";
            this.txt_db_dkh.Size = new System.Drawing.Size(175, 21);
            this.txt_db_dkh.TabIndex = 1;
            this.txt_db_dkh.Text = "COM13";
            // 
            // gb_db
            // 
            this.gb_db.Controls.Add(this.lb_db_num);
            this.gb_db.Controls.Add(this.lb_db);
            this.gb_db.Controls.Add(this.button2);
            this.gb_db.Controls.Add(this.button1);
            this.gb_db.Controls.Add(this.label2);
            this.gb_db.Controls.Add(this.txt_db_btl);
            this.gb_db.Controls.Add(this.label1);
            this.gb_db.Controls.Add(this.txt_db_dkh);
            this.gb_db.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_db.Location = new System.Drawing.Point(0, 0);
            this.gb_db.Name = "gb_db";
            this.gb_db.Size = new System.Drawing.Size(338, 463);
            this.gb_db.TabIndex = 2;
            this.gb_db.TabStop = false;
            this.gb_db.Text = "地磅";
            // 
            // lb_db_num
            // 
            this.lb_db_num.BackColor = System.Drawing.Color.Snow;
            this.lb_db_num.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_db_num.Font = new System.Drawing.Font("微软雅黑", 29F, System.Drawing.FontStyle.Bold);
            this.lb_db_num.ForeColor = System.Drawing.Color.Red;
            this.lb_db_num.Location = new System.Drawing.Point(6, 86);
            this.lb_db_num.Name = "lb_db_num";
            this.lb_db_num.Size = new System.Drawing.Size(326, 81);
            this.lb_db_num.TabIndex = 7;
            this.lb_db_num.Text = "12d3.009";
            this.lb_db_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_db
            // 
            this.lb_db.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_db.FormattingEnabled = true;
            this.lb_db.ItemHeight = 12;
            this.lb_db.Location = new System.Drawing.Point(3, 216);
            this.lb_db.Name = "lb_db";
            this.lb_db.Size = new System.Drawing.Size(332, 244);
            this.lb_db.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "清零";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            // 
            // txt_db_btl
            // 
            this.txt_db_btl.Location = new System.Drawing.Point(76, 47);
            this.txt_db_btl.Name = "txt_db_btl";
            this.txt_db_btl.Size = new System.Drawing.Size(175, 21);
            this.txt_db_btl.TabIndex = 3;
            this.txt_db_btl.Text = "9600";
            // 
            // gb_bar
            // 
            this.gb_bar.Controls.Add(this.lb_bar);
            this.gb_bar.Controls.Add(this.button4);
            this.gb_bar.Controls.Add(this.label3);
            this.gb_bar.Controls.Add(this.txt_bar_btl);
            this.gb_bar.Controls.Add(this.label4);
            this.gb_bar.Controls.Add(this.txt_bar_dkh);
            this.gb_bar.Dock = System.Windows.Forms.DockStyle.Right;
            this.gb_bar.Location = new System.Drawing.Point(659, 0);
            this.gb_bar.Name = "gb_bar";
            this.gb_bar.Size = new System.Drawing.Size(304, 463);
            this.gb_bar.TabIndex = 3;
            this.gb_bar.TabStop = false;
            this.gb_bar.Text = "扫描扫描平台";
            // 
            // lb_bar
            // 
            this.lb_bar.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lb_bar.FormattingEnabled = true;
            this.lb_bar.HorizontalScrollbar = true;
            this.lb_bar.ItemHeight = 21;
            this.lb_bar.Location = new System.Drawing.Point(6, 78);
            this.lb_bar.Name = "lb_bar";
            this.lb_bar.Size = new System.Drawing.Size(292, 361);
            this.lb_bar.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(223, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 48);
            this.button4.TabIndex = 11;
            this.button4.Text = "连接";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "波特率";
            // 
            // txt_bar_btl
            // 
            this.txt_bar_btl.Location = new System.Drawing.Point(76, 47);
            this.txt_bar_btl.Name = "txt_bar_btl";
            this.txt_bar_btl.Size = new System.Drawing.Size(141, 21);
            this.txt_bar_btl.TabIndex = 10;
            this.txt_bar_btl.Text = "9600";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "端口号";
            // 
            // txt_bar_dkh
            // 
            this.txt_bar_dkh.Location = new System.Drawing.Point(76, 20);
            this.txt_bar_dkh.Name = "txt_bar_dkh";
            this.txt_bar_dkh.Size = new System.Drawing.Size(141, 21);
            this.txt_bar_dkh.TabIndex = 8;
            this.txt_bar_dkh.Text = "COM11";
            // 
            // gb_tp
            // 
            this.gb_tp.Controls.Add(this.lb_tp_num);
            this.gb_tp.Controls.Add(this.lb_tp);
            this.gb_tp.Controls.Add(this.button5);
            this.gb_tp.Controls.Add(this.button6);
            this.gb_tp.Controls.Add(this.label5);
            this.gb_tp.Controls.Add(this.txt_tp_btl);
            this.gb_tp.Controls.Add(this.label6);
            this.gb_tp.Controls.Add(this.txt_tp_dkh);
            this.gb_tp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_tp.Location = new System.Drawing.Point(338, 0);
            this.gb_tp.Name = "gb_tp";
            this.gb_tp.Size = new System.Drawing.Size(321, 463);
            this.gb_tp.TabIndex = 4;
            this.gb_tp.TabStop = false;
            this.gb_tp.Text = "天平";
            // 
            // lb_tp_num
            // 
            this.lb_tp_num.BackColor = System.Drawing.Color.Snow;
            this.lb_tp_num.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_tp_num.Font = new System.Drawing.Font("微软雅黑", 29F, System.Drawing.FontStyle.Bold);
            this.lb_tp_num.ForeColor = System.Drawing.Color.Navy;
            this.lb_tp_num.Location = new System.Drawing.Point(6, 86);
            this.lb_tp_num.Name = "lb_tp_num";
            this.lb_tp_num.Size = new System.Drawing.Size(326, 81);
            this.lb_tp_num.TabIndex = 14;
            this.lb_tp_num.Text = "12d3.009";
            this.lb_tp_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_tp
            // 
            this.lb_tp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_tp.FormattingEnabled = true;
            this.lb_tp.ItemHeight = 12;
            this.lb_tp.Location = new System.Drawing.Point(3, 216);
            this.lb_tp.Name = "lb_tp";
            this.lb_tp.Size = new System.Drawing.Size(315, 244);
            this.lb_tp.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(248, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "清零";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(248, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "连接";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "波特率";
            // 
            // txt_tp_btl
            // 
            this.txt_tp_btl.Location = new System.Drawing.Point(67, 47);
            this.txt_tp_btl.Name = "txt_tp_btl";
            this.txt_tp_btl.Size = new System.Drawing.Size(175, 21);
            this.txt_tp_btl.TabIndex = 10;
            this.txt_tp_btl.Text = "9600";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "端口号";
            // 
            // txt_tp_dkh
            // 
            this.txt_tp_dkh.Location = new System.Drawing.Point(67, 20);
            this.txt_tp_dkh.Name = "txt_tp_dkh";
            this.txt_tp_dkh.Size = new System.Drawing.Size(175, 21);
            this.txt_tp_dkh.TabIndex = 8;
            this.txt_tp_dkh.Text = "COM12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 463);
            this.Controls.Add(this.gb_tp);
            this.Controls.Add(this.gb_bar);
            this.Controls.Add(this.gb_db);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_db.ResumeLayout(false);
            this.gb_db.PerformLayout();
            this.gb_bar.ResumeLayout(false);
            this.gb_bar.PerformLayout();
            this.gb_tp.ResumeLayout(false);
            this.gb_tp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_db_dkh;
        private System.Windows.Forms.GroupBox gb_db;
        private System.Windows.Forms.GroupBox gb_bar;
        private System.Windows.Forms.GroupBox gb_tp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_db_btl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lb_db;
        private System.Windows.Forms.ListBox lb_bar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_bar_btl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bar_dkh;
        private System.Windows.Forms.ListBox lb_tp;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tp_btl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tp_dkh;
        private System.Windows.Forms.Label lb_db_num;
        private System.Windows.Forms.Label lb_tp_num;
    }
}

