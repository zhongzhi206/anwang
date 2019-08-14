namespace CinemaTicketSystem
{
    partial class F_xiugai
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
            this.la_jiu = new System.Windows.Forms.Label();
            this.la_mi = new System.Windows.Forms.Label();
            this.la_ma = new System.Windows.Forms.Label();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.tb_mi = new System.Windows.Forms.TextBox();
            this.tb_jiu = new System.Windows.Forms.TextBox();
            this.btn_xiugai = new System.Windows.Forms.Button();
            this.btn_tuichu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // la_jiu
            // 
            this.la_jiu.AutoSize = true;
            this.la_jiu.Location = new System.Drawing.Point(51, 51);
            this.la_jiu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.la_jiu.Name = "la_jiu";
            this.la_jiu.Size = new System.Drawing.Size(67, 15);
            this.la_jiu.TabIndex = 0;
            this.la_jiu.Text = "旧密码：";
            this.la_jiu.Click += new System.EventHandler(this.la_jiu_Click);
            // 
            // la_mi
            // 
            this.la_mi.AutoSize = true;
            this.la_mi.Location = new System.Drawing.Point(51, 106);
            this.la_mi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.la_mi.Name = "la_mi";
            this.la_mi.Size = new System.Drawing.Size(67, 15);
            this.la_mi.TabIndex = 0;
            this.la_mi.Text = "新密码：";
            this.la_mi.Click += new System.EventHandler(this.la_jiu_Click);
            // 
            // la_ma
            // 
            this.la_ma.AutoSize = true;
            this.la_ma.Location = new System.Drawing.Point(35, 159);
            this.la_ma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.la_ma.Name = "la_ma";
            this.la_ma.Size = new System.Drawing.Size(82, 15);
            this.la_ma.TabIndex = 0;
            this.la_ma.Text = "确认密码：";
            this.la_ma.Click += new System.EventHandler(this.la_jiu_Click);
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(141, 155);
            this.tb_ma.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.PasswordChar = '*';
            this.tb_ma.Size = new System.Drawing.Size(143, 25);
            this.tb_ma.TabIndex = 1;
            this.tb_ma.TextChanged += new System.EventHandler(this.tb_jiu_TextChanged);
            // 
            // tb_mi
            // 
            this.tb_mi.Location = new System.Drawing.Point(141, 102);
            this.tb_mi.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mi.Name = "tb_mi";
            this.tb_mi.PasswordChar = '*';
            this.tb_mi.Size = new System.Drawing.Size(143, 25);
            this.tb_mi.TabIndex = 1;
            this.tb_mi.TextChanged += new System.EventHandler(this.tb_jiu_TextChanged);
            // 
            // tb_jiu
            // 
            this.tb_jiu.Location = new System.Drawing.Point(141, 48);
            this.tb_jiu.Margin = new System.Windows.Forms.Padding(4);
            this.tb_jiu.Name = "tb_jiu";
            this.tb_jiu.PasswordChar = '*';
            this.tb_jiu.Size = new System.Drawing.Size(143, 25);
            this.tb_jiu.TabIndex = 1;
            this.tb_jiu.TextChanged += new System.EventHandler(this.tb_jiu_TextChanged);
            // 
            // btn_xiugai
            // 
            this.btn_xiugai.Location = new System.Drawing.Point(53, 230);
            this.btn_xiugai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xiugai.Name = "btn_xiugai";
            this.btn_xiugai.Size = new System.Drawing.Size(100, 29);
            this.btn_xiugai.TabIndex = 2;
            this.btn_xiugai.Text = "修改";
            this.btn_xiugai.UseVisualStyleBackColor = true;
            this.btn_xiugai.Click += new System.EventHandler(this.btn_xiugai_Click);
            // 
            // btn_tuichu
            // 
            this.btn_tuichu.Location = new System.Drawing.Point(237, 230);
            this.btn_tuichu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tuichu.Name = "btn_tuichu";
            this.btn_tuichu.Size = new System.Drawing.Size(100, 29);
            this.btn_tuichu.TabIndex = 2;
            this.btn_tuichu.Text = "退出";
            this.btn_tuichu.UseVisualStyleBackColor = true;
            this.btn_tuichu.Click += new System.EventHandler(this.btn_tuichu_Click);
            // 
            // F_xiugai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 316);
            this.Controls.Add(this.btn_tuichu);
            this.Controls.Add(this.btn_xiugai);
            this.Controls.Add(this.tb_jiu);
            this.Controls.Add(this.tb_mi);
            this.Controls.Add(this.tb_ma);
            this.Controls.Add(this.la_ma);
            this.Controls.Add(this.la_mi);
            this.Controls.Add(this.la_jiu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_xiugai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.F_xiugai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label la_jiu;
        private System.Windows.Forms.Label la_mi;
        private System.Windows.Forms.Label la_ma;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.TextBox tb_mi;
        private System.Windows.Forms.TextBox tb_jiu;
        private System.Windows.Forms.Button btn_xiugai;
        private System.Windows.Forms.Button btn_tuichu;
    }
}