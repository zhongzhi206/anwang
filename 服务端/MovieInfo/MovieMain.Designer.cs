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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieMain));
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.tsmi_yonghu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_yingpian = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_weihu = new System.Windows.Forms.ToolStripMenuItem();
            this.排片管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.影厅维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.票房查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_guanli = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_wwei = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Fan = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_main
            // 
            this.ms_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_yonghu,
            this.tsmi_yingpian,
            this.tsmi_guanli,
            this.tsm_Fan});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(700, 28);
            this.ms_main.TabIndex = 0;
            this.ms_main.Text = "menuStrip1";
            // 
            // tsmi_yonghu
            // 
            this.tsmi_yonghu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.订单ToolStripMenuItem});
            this.tsmi_yonghu.Name = "tsmi_yonghu";
            this.tsmi_yonghu.Size = new System.Drawing.Size(81, 24);
            this.tsmi_yonghu.Text = "用户管理";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.toolStripMenuItem1.Text = "用户维护";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 订单ToolStripMenuItem
            // 
            this.订单ToolStripMenuItem.Name = "订单ToolStripMenuItem";
            this.订单ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.订单ToolStripMenuItem.Text = "订单管理";
            this.订单ToolStripMenuItem.Click += new System.EventHandler(this.订单ToolStripMenuItem_Click);
            // 
            // tsmi_yingpian
            // 
            this.tsmi_yingpian.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_weihu,
            this.排片管理ToolStripMenuItem,
            this.影厅维护ToolStripMenuItem,
            this.票房查询ToolStripMenuItem});
            this.tsmi_yingpian.Name = "tsmi_yingpian";
            this.tsmi_yingpian.Size = new System.Drawing.Size(81, 24);
            this.tsmi_yingpian.Text = "影片管理";
            // 
            // tsmi_weihu
            // 
            this.tsmi_weihu.Name = "tsmi_weihu";
            this.tsmi_weihu.Size = new System.Drawing.Size(144, 26);
            this.tsmi_weihu.Text = "影片维护";
            this.tsmi_weihu.Click += new System.EventHandler(this.tsmi_weihu_Click);
            // 
            // 排片管理ToolStripMenuItem
            // 
            this.排片管理ToolStripMenuItem.Name = "排片管理ToolStripMenuItem";
            this.排片管理ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.排片管理ToolStripMenuItem.Text = "排片管理";
            this.排片管理ToolStripMenuItem.Click += new System.EventHandler(this.排片管理ToolStripMenuItem_Click);
            // 
            // 影厅维护ToolStripMenuItem
            // 
            this.影厅维护ToolStripMenuItem.Name = "影厅维护ToolStripMenuItem";
            this.影厅维护ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.影厅维护ToolStripMenuItem.Text = "影厅维护";
            this.影厅维护ToolStripMenuItem.Click += new System.EventHandler(this.影厅维护ToolStripMenuItem_Click);
            // 
            // 票房查询ToolStripMenuItem
            // 
            this.票房查询ToolStripMenuItem.Name = "票房查询ToolStripMenuItem";
            this.票房查询ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.票房查询ToolStripMenuItem.Text = "票房查询";
            this.票房查询ToolStripMenuItem.Click += new System.EventHandler(this.票房查询ToolStripMenuItem_Click);
            // 
            // tsmi_guanli
            // 
            this.tsmi_guanli.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_wwei});
            this.tsmi_guanli.Name = "tsmi_guanli";
            this.tsmi_guanli.Size = new System.Drawing.Size(96, 24);
            this.tsmi_guanli.Text = "管理员管理";
            // 
            // tsmi_wwei
            // 
            this.tsmi_wwei.Name = "tsmi_wwei";
            this.tsmi_wwei.Size = new System.Drawing.Size(159, 26);
            this.tsmi_wwei.Text = "管理员维护";
            this.tsmi_wwei.Click += new System.EventHandler(this.tsmi_wwei_Click);
            // 
            // tsm_Fan
            // 
            this.tsm_Fan.Name = "tsm_Fan";
            this.tsm_Fan.Size = new System.Drawing.Size(81, 24);
            this.tsm_Fan.Text = "用户反馈";
            this.tsm_Fan.Click += new System.EventHandler(this.tsm_Fan_Click);
            // 
            // MovieMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 402);
            this.Controls.Add(this.ms_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_main;
            this.Name = "MovieMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电影销售系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MovieMain_FormClosed);
            this.Load += new System.EventHandler(this.MovieMain_Load);
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem tsmi_yonghu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_yingpian;
        private System.Windows.Forms.ToolStripMenuItem tsmi_weihu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_guanli;
        private System.Windows.Forms.ToolStripMenuItem tsmi_wwei;
        private System.Windows.Forms.ToolStripMenuItem tsm_Fan;
        private System.Windows.Forms.ToolStripMenuItem 排片管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 影厅维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 票房查询ToolStripMenuItem;
    }
}