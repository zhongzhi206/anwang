namespace MovieInfo
{
    partial class Movielogin
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
            this.pl_Register = new System.Windows.Forms.Panel();
            this.btn_register = new System.Windows.Forms.Button();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_RegisterName = new System.Windows.Forms.Label();
            this.pl_Register.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_Register
            // 
            this.pl_Register.Controls.Add(this.btn_register);
            this.pl_Register.Controls.Add(this.tb_pwd);
            this.pl_Register.Controls.Add(this.tb_name);
            this.pl_Register.Controls.Add(this.label1);
            this.pl_Register.Controls.Add(this.lb_RegisterName);
            this.pl_Register.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Register.Location = new System.Drawing.Point(0, 0);
            this.pl_Register.Name = "pl_Register";
            this.pl_Register.Size = new System.Drawing.Size(410, 467);
            this.pl_Register.TabIndex = 8;
            this.pl_Register.Paint += new System.Windows.Forms.PaintEventHandler(this.pl_Register_Paint);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_register.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(99, 263);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(212, 39);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "登录";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.UseWaitCursor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(164, 167);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '*';
            this.tb_pwd.Size = new System.Drawing.Size(137, 25);
            this.tb_pwd.TabIndex = 2;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(164, 80);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(137, 25);
            this.tb_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(105, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "密码";
            // 
            // lb_RegisterName
            // 
            this.lb_RegisterName.AutoSize = true;
            this.lb_RegisterName.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_RegisterName.Location = new System.Drawing.Point(105, 85);
            this.lb_RegisterName.Name = "lb_RegisterName";
            this.lb_RegisterName.Size = new System.Drawing.Size(49, 20);
            this.lb_RegisterName.TabIndex = 0;
            this.lb_RegisterName.Text = "账户";
            // 
            // Movielogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 467);
            this.Controls.Add(this.pl_Register);
            this.Name = "Movielogin";
            this.Text = "管理员身份登录";
            this.pl_Register.ResumeLayout(false);
            this.pl_Register.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_Register;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_RegisterName;
        internal System.Windows.Forms.Button btn_register;
    }
}