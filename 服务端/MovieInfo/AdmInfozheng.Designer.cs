namespace MovieInfo
{
    partial class AdmInfozheng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmInfozheng));
            this.btn_register = new System.Windows.Forms.Button();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_register.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(169, 299);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(212, 39);
            this.btn_register.TabIndex = 11;
            this.btn_register.Text = "确认";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.UseWaitCursor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(196, 256);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '*';
            this.tb_pwd.Size = new System.Drawing.Size(173, 25);
            this.tb_pwd.TabIndex = 10;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(196, 187);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(173, 25);
            this.tb_name.TabIndex = 8;
            // 
            // AdmInfozheng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 446);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.tb_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdmInfozheng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "身份证明";
            this.Load += new System.EventHandler(this.AdmInfozheng_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.TextBox tb_name;
    }
}