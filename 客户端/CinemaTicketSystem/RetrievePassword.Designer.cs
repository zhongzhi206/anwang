namespace CinemaTicketSystem
{
    partial class RetrievePassword
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
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_AuthCode = new System.Windows.Forms.TextBox();
            this.btn_AuthCode = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.tb_RegisterName = new System.Windows.Forms.TextBox();
            this.lb_RegisterName = new System.Windows.Forms.Label();
            this.tm_AuthCode = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_ConfirmPwd = new System.Windows.Forms.TextBox();
            this.tb_RegisterPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Phone
            // 
            this.tb_Phone.Font = new System.Drawing.Font("宋体", 18F);
            this.tb_Phone.Location = new System.Drawing.Point(289, 200);
            this.tb_Phone.Multiline = true;
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(339, 42);
            this.tb_Phone.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 22.2F);
            this.label3.Location = new System.Drawing.Point(66, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "手机号码:";
            // 
            // tb_AuthCode
            // 
            this.tb_AuthCode.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_AuthCode.Location = new System.Drawing.Point(289, 284);
            this.tb_AuthCode.Name = "tb_AuthCode";
            this.tb_AuthCode.Size = new System.Drawing.Size(337, 28);
            this.tb_AuthCode.TabIndex = 14;
            // 
            // btn_AuthCode
            // 
            this.btn_AuthCode.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_AuthCode.FlatAppearance.BorderSize = 0;
            this.btn_AuthCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AuthCode.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_AuthCode.ForeColor = System.Drawing.Color.White;
            this.btn_AuthCode.Location = new System.Drawing.Point(108, 282);
            this.btn_AuthCode.Name = "btn_AuthCode";
            this.btn_AuthCode.Size = new System.Drawing.Size(140, 32);
            this.btn_AuthCode.TabIndex = 13;
            this.btn_AuthCode.Text = "获取验证码";
            this.btn_AuthCode.UseVisualStyleBackColor = false;
            this.btn_AuthCode.Click += new System.EventHandler(this.btn_AuthCode_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.Location = new System.Drawing.Point(215, 352);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(299, 46);
            this.btn_Register.TabIndex = 12;
            this.btn_Register.Text = "下一步";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // tb_RegisterName
            // 
            this.tb_RegisterName.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_RegisterName.ForeColor = System.Drawing.Color.Black;
            this.tb_RegisterName.Location = new System.Drawing.Point(289, 106);
            this.tb_RegisterName.Name = "tb_RegisterName";
            this.tb_RegisterName.Size = new System.Drawing.Size(337, 42);
            this.tb_RegisterName.TabIndex = 18;
            // 
            // lb_RegisterName
            // 
            this.lb_RegisterName.AutoSize = true;
            this.lb_RegisterName.BackColor = System.Drawing.Color.Transparent;
            this.lb_RegisterName.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_RegisterName.Location = new System.Drawing.Point(142, 106);
            this.lb_RegisterName.Name = "lb_RegisterName";
            this.lb_RegisterName.Size = new System.Drawing.Size(112, 38);
            this.lb_RegisterName.TabIndex = 17;
            this.lb_RegisterName.Text = "账户:";
            // 
            // tm_AuthCode
            // 
            this.tm_AuthCode.Interval = 1000;
            this.tm_AuthCode.Tick += new System.EventHandler(this.tm_AuthCode_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tb_ConfirmPwd);
            this.panel1.Controls.Add(this.tb_RegisterPwd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 531);
            this.panel1.TabIndex = 19;
            this.panel1.Visible = false;
            // 
            // tb_ConfirmPwd
            // 
            this.tb_ConfirmPwd.Font = new System.Drawing.Font("宋体", 18F);
            this.tb_ConfirmPwd.ForeColor = System.Drawing.Color.Silver;
            this.tb_ConfirmPwd.Location = new System.Drawing.Point(308, 206);
            this.tb_ConfirmPwd.Name = "tb_ConfirmPwd";
            this.tb_ConfirmPwd.Size = new System.Drawing.Size(339, 42);
            this.tb_ConfirmPwd.TabIndex = 7;
            this.tb_ConfirmPwd.Text = "8--18个字符";
            this.tb_ConfirmPwd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_ConfirmPwd_MouseClick);
            // 
            // tb_RegisterPwd
            // 
            this.tb_RegisterPwd.Font = new System.Drawing.Font("宋体", 18F);
            this.tb_RegisterPwd.ForeColor = System.Drawing.Color.Silver;
            this.tb_RegisterPwd.Location = new System.Drawing.Point(308, 130);
            this.tb_RegisterPwd.Name = "tb_RegisterPwd";
            this.tb_RegisterPwd.Size = new System.Drawing.Size(339, 42);
            this.tb_RegisterPwd.TabIndex = 5;
            this.tb_RegisterPwd.Text = "8--18个字符";
            this.tb_RegisterPwd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_RegisterPwd_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 22.2F);
            this.label2.Location = new System.Drawing.Point(85, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "确认密码:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 22.2F);
            this.label1.Location = new System.Drawing.Point(161, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "密码:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(236, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RetrievePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_RegisterName);
            this.Controls.Add(this.lb_RegisterName);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_AuthCode);
            this.Controls.Add(this.btn_AuthCode);
            this.Controls.Add(this.btn_Register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RetrievePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "忘记密码";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_AuthCode;
        private System.Windows.Forms.Button btn_AuthCode;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.TextBox tb_RegisterName;
        private System.Windows.Forms.Label lb_RegisterName;
        private System.Windows.Forms.Timer tm_AuthCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_ConfirmPwd;
        private System.Windows.Forms.TextBox tb_RegisterPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}