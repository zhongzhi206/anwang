namespace CinemaTicketSystem
{
    partial class UserLogin
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
            this.components = new System.ComponentModel.Container();
            this.tm_AuthCode = new System.Windows.Forms.Timer(this.components);
            this.tm_LoginForbidden = new System.Windows.Forms.Timer(this.components);
            this.pl_Login = new System.Windows.Forms.Panel();
            this.pl_Register = new System.Windows.Forms.Panel();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_AuthCode = new System.Windows.Forms.TextBox();
            this.btn_AuthCode = new System.Windows.Forms.Button();
            this.lb_GoLogin = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.tb_ConfirmPwd = new System.Windows.Forms.TextBox();
            this.tb_RegisterPwd = new System.Windows.Forms.TextBox();
            this.tb_RegisterName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_RegisterName = new System.Windows.Forms.Label();
            this.tb_UserPwd = new System.Windows.Forms.TextBox();
            this.cb_UserName = new System.Windows.Forms.ComboBox();
            this.lb_UserRegister = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lb_UserPwd = new System.Windows.Forms.Label();
            this.lb_UserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pl_Login.SuspendLayout();
            this.pl_Register.SuspendLayout();
            this.SuspendLayout();
            // 
            // tm_AuthCode
            // 
            this.tm_AuthCode.Interval = 1000;
            this.tm_AuthCode.Tick += new System.EventHandler(this.tm_AuthCode_Tick);
            // 
            // tm_LoginForbidden
            // 
            this.tm_LoginForbidden.Interval = 1000;
            this.tm_LoginForbidden.Tick += new System.EventHandler(this.tm_LoginForbidden_Tick);
            // 
            // pl_Login
            // 
            this.pl_Login.BackgroundImage = global::CinemaTicketSystem.Properties.Resources.暗网;
            this.pl_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_Login.Controls.Add(this.pl_Register);
            this.pl_Login.Controls.Add(this.tb_UserPwd);
            this.pl_Login.Controls.Add(this.cb_UserName);
            this.pl_Login.Controls.Add(this.lb_UserRegister);
            this.pl_Login.Controls.Add(this.btn_Login);
            this.pl_Login.Controls.Add(this.lb_UserPwd);
            this.pl_Login.Controls.Add(this.lb_UserName);
            this.pl_Login.Controls.Add(this.label4);
            this.pl_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Login.Location = new System.Drawing.Point(0, 0);
            this.pl_Login.Name = "pl_Login";
            this.pl_Login.Size = new System.Drawing.Size(1508, 681);
            this.pl_Login.TabIndex = 0;
            this.pl_Login.Paint += new System.Windows.Forms.PaintEventHandler(this.pl_Login_Paint);
            // 
            // pl_Register
            // 
            this.pl_Register.BackgroundImage = global::CinemaTicketSystem.Properties.Resources._10656_8d229223968df99962c1b1d01dab6f281;
            this.pl_Register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_Register.Controls.Add(this.tb_Phone);
            this.pl_Register.Controls.Add(this.label3);
            this.pl_Register.Controls.Add(this.tb_AuthCode);
            this.pl_Register.Controls.Add(this.btn_AuthCode);
            this.pl_Register.Controls.Add(this.lb_GoLogin);
            this.pl_Register.Controls.Add(this.btn_Register);
            this.pl_Register.Controls.Add(this.tb_ConfirmPwd);
            this.pl_Register.Controls.Add(this.tb_RegisterPwd);
            this.pl_Register.Controls.Add(this.tb_RegisterName);
            this.pl_Register.Controls.Add(this.label2);
            this.pl_Register.Controls.Add(this.label1);
            this.pl_Register.Controls.Add(this.lb_RegisterName);
            this.pl_Register.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Register.Location = new System.Drawing.Point(0, 0);
            this.pl_Register.Name = "pl_Register";
            this.pl_Register.Size = new System.Drawing.Size(1508, 681);
            this.pl_Register.TabIndex = 7;
            this.pl_Register.Paint += new System.Windows.Forms.PaintEventHandler(this.pl_Register_Paint);
            // 
            // tb_Phone
            // 
            this.tb_Phone.Font = new System.Drawing.Font("宋体", 18F);
            this.tb_Phone.Location = new System.Drawing.Point(723, 351);
            this.tb_Phone.Multiline = true;
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(339, 42);
            this.tb_Phone.TabIndex = 11;
            this.tb_Phone.TextChanged += new System.EventHandler(this.tb_Phone_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 22.2F);
            this.label3.Location = new System.Drawing.Point(500, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "手机号码:";
            // 
            // tb_AuthCode
            // 
            this.tb_AuthCode.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_AuthCode.Location = new System.Drawing.Point(723, 421);
            this.tb_AuthCode.Name = "tb_AuthCode";
            this.tb_AuthCode.Size = new System.Drawing.Size(343, 28);
            this.tb_AuthCode.TabIndex = 9;
            this.tb_AuthCode.TextChanged += new System.EventHandler(this.tb_AuthCode_TextChanged);
            this.tb_AuthCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_AuthCode_KeyDown);
            // 
            // btn_AuthCode
            // 
            this.btn_AuthCode.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_AuthCode.FlatAppearance.BorderSize = 0;
            this.btn_AuthCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AuthCode.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_AuthCode.ForeColor = System.Drawing.Color.White;
            this.btn_AuthCode.Location = new System.Drawing.Point(548, 419);
            this.btn_AuthCode.Name = "btn_AuthCode";
            this.btn_AuthCode.Size = new System.Drawing.Size(140, 32);
            this.btn_AuthCode.TabIndex = 8;
            this.btn_AuthCode.Text = "获取验证码";
            this.btn_AuthCode.UseVisualStyleBackColor = false;
            this.btn_AuthCode.Click += new System.EventHandler(this.btn_AuthCode_Click);
            // 
            // lb_GoLogin
            // 
            this.lb_GoLogin.AutoSize = true;
            this.lb_GoLogin.BackColor = System.Drawing.Color.Transparent;
            this.lb_GoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_GoLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_GoLogin.Location = new System.Drawing.Point(725, 557);
            this.lb_GoLogin.Name = "lb_GoLogin";
            this.lb_GoLogin.Size = new System.Drawing.Size(127, 15);
            this.lb_GoLogin.TabIndex = 7;
            this.lb_GoLogin.Text = "已有账户？去登录";
            this.lb_GoLogin.Click += new System.EventHandler(this.lb_GoLogin_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.Location = new System.Drawing.Point(655, 489);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(299, 46);
            this.btn_Register.TabIndex = 6;
            this.btn_Register.Text = "注册";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // tb_ConfirmPwd
            // 
            this.tb_ConfirmPwd.Font = new System.Drawing.Font("宋体", 18F);
            this.tb_ConfirmPwd.ForeColor = System.Drawing.Color.Silver;
            this.tb_ConfirmPwd.Location = new System.Drawing.Point(723, 269);
            this.tb_ConfirmPwd.Name = "tb_ConfirmPwd";
            this.tb_ConfirmPwd.Size = new System.Drawing.Size(339, 42);
            this.tb_ConfirmPwd.TabIndex = 3;
            this.tb_ConfirmPwd.Text = "8--18个字符";
            this.tb_ConfirmPwd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_ConfirmPwd_MouseClick);
            this.tb_ConfirmPwd.TextChanged += new System.EventHandler(this.tb_ConfirmPwd_TextChanged);
            this.tb_ConfirmPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ConfirmPwd_KeyPress);
            this.tb_ConfirmPwd.Leave += new System.EventHandler(this.tb_ConfirmPwd_Leave);
            // 
            // tb_RegisterPwd
            // 
            this.tb_RegisterPwd.Font = new System.Drawing.Font("宋体", 18F);
            this.tb_RegisterPwd.ForeColor = System.Drawing.Color.Silver;
            this.tb_RegisterPwd.Location = new System.Drawing.Point(723, 193);
            this.tb_RegisterPwd.Name = "tb_RegisterPwd";
            this.tb_RegisterPwd.Size = new System.Drawing.Size(339, 42);
            this.tb_RegisterPwd.TabIndex = 2;
            this.tb_RegisterPwd.Text = "8--18个字符";
            this.tb_RegisterPwd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_RegisterPwd_MouseClick);
            this.tb_RegisterPwd.TextChanged += new System.EventHandler(this.tb_RegisterPwd_TextChanged);
            this.tb_RegisterPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_RegisterPwd_KeyPress);
            this.tb_RegisterPwd.Leave += new System.EventHandler(this.tb_RegisterPwd_Leave);
            // 
            // tb_RegisterName
            // 
            this.tb_RegisterName.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_RegisterName.ForeColor = System.Drawing.Color.Silver;
            this.tb_RegisterName.Location = new System.Drawing.Point(723, 95);
            this.tb_RegisterName.Name = "tb_RegisterName";
            this.tb_RegisterName.Size = new System.Drawing.Size(337, 42);
            this.tb_RegisterName.TabIndex = 1;
            this.tb_RegisterName.Text = "6--18位数字或字母";
            this.tb_RegisterName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_RegisterName_MouseClick);
            this.tb_RegisterName.TextChanged += new System.EventHandler(this.tb_RegisterName_TextChanged);
            this.tb_RegisterName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_RegisterName_KeyPress);
            this.tb_RegisterName.Leave += new System.EventHandler(this.tb_RegisterName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 22.2F);
            this.label2.Location = new System.Drawing.Point(500, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "确认密码:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 22.2F);
            this.label1.Location = new System.Drawing.Point(576, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "密码:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_RegisterName
            // 
            this.lb_RegisterName.AutoSize = true;
            this.lb_RegisterName.BackColor = System.Drawing.Color.Transparent;
            this.lb_RegisterName.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_RegisterName.Location = new System.Drawing.Point(576, 95);
            this.lb_RegisterName.Name = "lb_RegisterName";
            this.lb_RegisterName.Size = new System.Drawing.Size(112, 38);
            this.lb_RegisterName.TabIndex = 0;
            this.lb_RegisterName.Text = "账户:";
            // 
            // tb_UserPwd
            // 
            this.tb_UserPwd.BackColor = System.Drawing.Color.White;
            this.tb_UserPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_UserPwd.Font = new System.Drawing.Font("宋体", 22.2F);
            this.tb_UserPwd.Location = new System.Drawing.Point(728, 449);
            this.tb_UserPwd.Name = "tb_UserPwd";
            this.tb_UserPwd.PasswordChar = '*';
            this.tb_UserPwd.Size = new System.Drawing.Size(291, 43);
            this.tb_UserPwd.TabIndex = 2;
            this.tb_UserPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_UserPwd_KeyDown);
            // 
            // cb_UserName
            // 
            this.cb_UserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_UserName.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_UserName.FormattingEnabled = true;
            this.cb_UserName.Location = new System.Drawing.Point(728, 351);
            this.cb_UserName.Name = "cb_UserName";
            this.cb_UserName.Size = new System.Drawing.Size(291, 45);
            this.cb_UserName.TabIndex = 1;
            this.cb_UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_UserName_KeyPress);
            // 
            // lb_UserRegister
            // 
            this.lb_UserRegister.AutoSize = true;
            this.lb_UserRegister.BackColor = System.Drawing.Color.Transparent;
            this.lb_UserRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_UserRegister.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_UserRegister.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_UserRegister.Location = new System.Drawing.Point(735, 536);
            this.lb_UserRegister.Name = "lb_UserRegister";
            this.lb_UserRegister.Size = new System.Drawing.Size(166, 24);
            this.lb_UserRegister.TabIndex = 5;
            this.lb_UserRegister.Text = "新用户注册  |";
            this.lb_UserRegister.Click += new System.EventHandler(this.lb_UserRegister_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Aqua;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Login.ForeColor = System.Drawing.Color.Red;
            this.btn_Login.Location = new System.Drawing.Point(922, 519);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(97, 52);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lb_UserPwd
            // 
            this.lb_UserPwd.AutoSize = true;
            this.lb_UserPwd.BackColor = System.Drawing.Color.Transparent;
            this.lb_UserPwd.Font = new System.Drawing.Font("宋体", 22.2F);
            this.lb_UserPwd.ForeColor = System.Drawing.Color.Red;
            this.lb_UserPwd.Location = new System.Drawing.Point(570, 454);
            this.lb_UserPwd.Name = "lb_UserPwd";
            this.lb_UserPwd.Size = new System.Drawing.Size(112, 38);
            this.lb_UserPwd.TabIndex = 1;
            this.lb_UserPwd.Text = "密码:";
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.BackColor = System.Drawing.Color.Transparent;
            this.lb_UserName.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_UserName.ForeColor = System.Drawing.Color.Red;
            this.lb_UserName.Location = new System.Drawing.Point(570, 351);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(112, 38);
            this.lb_UserName.TabIndex = 0;
            this.lb_UserName.Text = "账户:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(599, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "忘记密码？";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 681);
            this.Controls.Add(this.pl_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserLogin_FormClosing);
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.pl_Login.ResumeLayout(false);
            this.pl_Login.PerformLayout();
            this.pl_Register.ResumeLayout(false);
            this.pl_Register.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_Login;
        private System.Windows.Forms.Label lb_UserRegister;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox tb_UserPwd;
        private System.Windows.Forms.ComboBox cb_UserName;
        private System.Windows.Forms.Label lb_UserPwd;
        private System.Windows.Forms.Label lb_UserName;
        private System.Windows.Forms.Panel pl_Register;
        private System.Windows.Forms.Label lb_GoLogin;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.TextBox tb_ConfirmPwd;
        private System.Windows.Forms.TextBox tb_RegisterPwd;
        private System.Windows.Forms.TextBox tb_RegisterName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_RegisterName;
        private System.Windows.Forms.TextBox tb_AuthCode;
        private System.Windows.Forms.Button btn_AuthCode;
        private System.Windows.Forms.Timer tm_AuthCode;
        private System.Windows.Forms.Timer tm_LoginForbidden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Phone;
    }
}