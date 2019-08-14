namespace MovieInfo
{
    partial class Usermain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usermain));
            this.dgv_cha = new System.Windows.Forms.DataGridView();
            this.YH_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YH_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YH_Pwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YH_NiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YH_Registration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cms_one = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_shan = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xin = new System.Windows.Forms.Button();
            this.btn_jia = new System.Windows.Forms.Button();
            this.btn_gai = new System.Windows.Forms.Button();
            this.btn_cha = new System.Windows.Forms.Button();
            this.tb_wen = new System.Windows.Forms.TextBox();
            this.tb_zhang = new System.Windows.Forms.TextBox();
            this.tb_mi = new System.Windows.Forms.TextBox();
            this.tb_cheng = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cha)).BeginInit();
            this.cms_one.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_cha
            // 
            this.dgv_cha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.YH_ID,
            this.YH_Name,
            this.YH_Pwd,
            this.YH_NiceName,
            this.YH_Registration});
            this.dgv_cha.ContextMenuStrip = this.cms_one;
            this.dgv_cha.Location = new System.Drawing.Point(2, 99);
            this.dgv_cha.Name = "dgv_cha";
            this.dgv_cha.RowTemplate.Height = 27;
            this.dgv_cha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cha.Size = new System.Drawing.Size(751, 150);
            this.dgv_cha.TabIndex = 0;
            this.dgv_cha.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cha_CellClick);
            this.dgv_cha.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cha_CellContentClick);
            // 
            // YH_ID
            // 
            this.YH_ID.DataPropertyName = "YH_ID";
            this.YH_ID.HeaderText = "用户编号";
            this.YH_ID.Name = "YH_ID";
            // 
            // YH_Name
            // 
            this.YH_Name.DataPropertyName = "YH_Name";
            this.YH_Name.HeaderText = "用户账号";
            this.YH_Name.Name = "YH_Name";
            // 
            // YH_Pwd
            // 
            this.YH_Pwd.DataPropertyName = "YH_Pwd";
            this.YH_Pwd.HeaderText = "用户密码";
            this.YH_Pwd.Name = "YH_Pwd";
            // 
            // YH_NiceName
            // 
            this.YH_NiceName.DataPropertyName = "YH_NiceName";
            this.YH_NiceName.HeaderText = "用户名称";
            this.YH_NiceName.Name = "YH_NiceName";
            // 
            // YH_Registration
            // 
            this.YH_Registration.DataPropertyName = "YH_Registration";
            this.YH_Registration.HeaderText = "注册时间";
            this.YH_Registration.Name = "YH_Registration";
            // 
            // cms_one
            // 
            this.cms_one.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_one.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_shan});
            this.cms_one.Name = "cms_one";
            this.cms_one.Size = new System.Drawing.Size(109, 28);
            // 
            // tsmi_shan
            // 
            this.tsmi_shan.Name = "tsmi_shan";
            this.tsmi_shan.Size = new System.Drawing.Size(108, 24);
            this.tsmi_shan.Text = "删除";
            this.tsmi_shan.Click += new System.EventHandler(this.tsmi_shan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1007, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = " ________________________________________________________________________________" +
    "____________________________________________";
            // 
            // btn_xin
            // 
            this.btn_xin.Location = new System.Drawing.Point(46, 36);
            this.btn_xin.Name = "btn_xin";
            this.btn_xin.Size = new System.Drawing.Size(107, 32);
            this.btn_xin.TabIndex = 2;
            this.btn_xin.Text = "更新";
            this.btn_xin.UseVisualStyleBackColor = true;
            this.btn_xin.Click += new System.EventHandler(this.btn_xin_Click);
            // 
            // btn_jia
            // 
            this.btn_jia.Location = new System.Drawing.Point(185, 455);
            this.btn_jia.Name = "btn_jia";
            this.btn_jia.Size = new System.Drawing.Size(107, 32);
            this.btn_jia.TabIndex = 2;
            this.btn_jia.Text = "+ 添加";
            this.btn_jia.UseVisualStyleBackColor = true;
            this.btn_jia.Click += new System.EventHandler(this.btn_jia_Click);
            // 
            // btn_gai
            // 
            this.btn_gai.Location = new System.Drawing.Point(431, 455);
            this.btn_gai.Name = "btn_gai";
            this.btn_gai.Size = new System.Drawing.Size(107, 32);
            this.btn_gai.TabIndex = 2;
            this.btn_gai.Text = "@ 修改";
            this.btn_gai.UseVisualStyleBackColor = true;
            this.btn_gai.Click += new System.EventHandler(this.btn_gai_Click);
            // 
            // btn_cha
            // 
            this.btn_cha.Location = new System.Drawing.Point(639, 27);
            this.btn_cha.Name = "btn_cha";
            this.btn_cha.Size = new System.Drawing.Size(107, 32);
            this.btn_cha.TabIndex = 2;
            this.btn_cha.Text = "搜索";
            this.btn_cha.UseVisualStyleBackColor = true;
            this.btn_cha.Click += new System.EventHandler(this.btn_cha_Click);
            // 
            // tb_wen
            // 
            this.tb_wen.Location = new System.Drawing.Point(448, 33);
            this.tb_wen.Name = "tb_wen";
            this.tb_wen.Size = new System.Drawing.Size(163, 25);
            this.tb_wen.TabIndex = 3;
            this.tb_wen.TextChanged += new System.EventHandler(this.tb_wen_TextChanged);
            // 
            // tb_zhang
            // 
            this.tb_zhang.Location = new System.Drawing.Point(133, 304);
            this.tb_zhang.Name = "tb_zhang";
            this.tb_zhang.Size = new System.Drawing.Size(163, 25);
            this.tb_zhang.TabIndex = 3;
            this.tb_zhang.TextChanged += new System.EventHandler(this.tb_wen_TextChanged);
            // 
            // tb_mi
            // 
            this.tb_mi.Location = new System.Drawing.Point(460, 304);
            this.tb_mi.Name = "tb_mi";
            this.tb_mi.Size = new System.Drawing.Size(163, 25);
            this.tb_mi.TabIndex = 3;
            this.tb_mi.TextChanged += new System.EventHandler(this.tb_wen_TextChanged);
            // 
            // tb_cheng
            // 
            this.tb_cheng.Location = new System.Drawing.Point(133, 377);
            this.tb_cheng.Name = "tb_cheng";
            this.tb_cheng.Size = new System.Drawing.Size(163, 25);
            this.tb_cheng.TabIndex = 3;
            this.tb_cheng.TextChanged += new System.EventHandler(this.tb_wen_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "用户账号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "用户密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "用户名称：";
            // 
            // Usermain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 517);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cheng);
            this.Controls.Add(this.tb_mi);
            this.Controls.Add(this.tb_zhang);
            this.Controls.Add(this.tb_wen);
            this.Controls.Add(this.btn_gai);
            this.Controls.Add(this.btn_cha);
            this.Controls.Add(this.btn_jia);
            this.Controls.Add(this.btn_xin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_cha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usermain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户维护";
            this.Load += new System.EventHandler(this.Usermain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cha)).EndInit();
            this.cms_one.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cha;
        private System.Windows.Forms.DataGridViewTextBoxColumn YH_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn YH_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn YH_Pwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn YH_NiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn YH_Registration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xin;
        private System.Windows.Forms.Button btn_jia;
        private System.Windows.Forms.Button btn_gai;
        private System.Windows.Forms.Button btn_cha;
        private System.Windows.Forms.TextBox tb_wen;
        private System.Windows.Forms.TextBox tb_zhang;
        private System.Windows.Forms.TextBox tb_mi;
        private System.Windows.Forms.TextBox tb_cheng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip cms_one;
        private System.Windows.Forms.ToolStripMenuItem tsmi_shan;
    }
}