namespace MovieInfo
{
    partial class MovieMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.tsmi_yonghu = new System.Windows.Forms.ToolStripMenuItem();
            this.用户删除SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_yingpian = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_chaxun = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_weihu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_wei = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_guanli = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ccha = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_wwei = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_new = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Xintwo = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_main
            // 
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_yonghu,
            this.tsmi_yingpian,
            this.tsmi_guanli,
            this.tsmi_new});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(700, 28);
            this.ms_main.TabIndex = 0;
            this.ms_main.Text = "menuStrip1";
            // 
            // tsmi_yonghu
            // 
            this.tsmi_yonghu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户删除SToolStripMenuItem,
            this.toolStripMenuItem1});
            this.tsmi_yonghu.Name = "tsmi_yonghu";
            this.tsmi_yonghu.Size = new System.Drawing.Size(81, 24);
            this.tsmi_yonghu.Text = "用户管理";
            // 
            // 用户删除SToolStripMenuItem
            // 
            this.用户删除SToolStripMenuItem.Name = "用户删除SToolStripMenuItem";
            this.用户删除SToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.用户删除SToolStripMenuItem.Text = "用户查询";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuItem1.Text = "用户维护";
            // 
            // tsmi_yingpian
            // 
            this.tsmi_yingpian.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_chaxun,
            this.tsmi_weihu,
            this.toolStripSeparator1,
            this.tsmi_wei});
            this.tsmi_yingpian.Name = "tsmi_yingpian";
            this.tsmi_yingpian.Size = new System.Drawing.Size(81, 24);
            this.tsmi_yingpian.Text = "影片管理";
            // 
            // tsmi_chaxun
            // 
            this.tsmi_chaxun.Name = "tsmi_chaxun";
            this.tsmi_chaxun.Size = new System.Drawing.Size(168, 24);
            this.tsmi_chaxun.Text = "影片查询";
            this.tsmi_chaxun.Click += new System.EventHandler(this.tsmi_chaxun_Click);
            // 
            // tsmi_weihu
            // 
            this.tsmi_weihu.Name = "tsmi_weihu";
            this.tsmi_weihu.Size = new System.Drawing.Size(168, 24);
            this.tsmi_weihu.Text = "影片维护";
            this.tsmi_weihu.Click += new System.EventHandler(this.tsmi_weihu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // tsmi_wei
            // 
            this.tsmi_wei.Name = "tsmi_wei";
            this.tsmi_wei.Size = new System.Drawing.Size(168, 24);
            this.tsmi_wei.Text = "影片类型维护";
            this.tsmi_wei.Click += new System.EventHandler(this.tsmi_wei_Click);
            // 
            // tsmi_guanli
            // 
            this.tsmi_guanli.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_ccha,
            this.tsmi_wwei});
            this.tsmi_guanli.Name = "tsmi_guanli";
            this.tsmi_guanli.Size = new System.Drawing.Size(96, 24);
            this.tsmi_guanli.Text = "管理员管理";
            // 
            // tsmi_ccha
            // 
            this.tsmi_ccha.Name = "tsmi_ccha";
            this.tsmi_ccha.Size = new System.Drawing.Size(153, 24);
            this.tsmi_ccha.Text = "管理员查询";
            this.tsmi_ccha.Click += new System.EventHandler(this.tsmi_ccha_Click);
            // 
            // tsmi_wwei
            // 
            this.tsmi_wwei.Name = "tsmi_wwei";
            this.tsmi_wwei.Size = new System.Drawing.Size(153, 24);
            this.tsmi_wwei.Text = "管理员维护";
            this.tsmi_wwei.Click += new System.EventHandler(this.tsmi_wwei_Click);
            // 
            // tsmi_new
            // 
            this.tsmi_new.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Xintwo});
            this.tsmi_new.Name = "tsmi_new";
            this.tsmi_new.Size = new System.Drawing.Size(81, 24);
            this.tsmi_new.Text = "新闻管理";
            // 
            // tsmi_Xintwo
            // 
            this.tsmi_Xintwo.Name = "tsmi_Xintwo";
            this.tsmi_Xintwo.Size = new System.Drawing.Size(138, 24);
            this.tsmi_Xintwo.Text = "新闻维护";
            this.tsmi_Xintwo.Click += new System.EventHandler(this.tsmi_Xintwo_Click);
            // 
            // MovieMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 402);
            this.Controls.Add(this.ms_main);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_main;
            this.Name = "MovieMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电影销售系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem tsmi_yonghu;
        private System.Windows.Forms.ToolStripMenuItem 用户删除SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_yingpian;
        private System.Windows.Forms.ToolStripMenuItem tsmi_chaxun;
        private System.Windows.Forms.ToolStripMenuItem tsmi_weihu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_guanli;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ccha;
        private System.Windows.Forms.ToolStripMenuItem tsmi_wwei;
        private System.Windows.Forms.ToolStripMenuItem tsmi_wei;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_new;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Xintwo;
    }
}