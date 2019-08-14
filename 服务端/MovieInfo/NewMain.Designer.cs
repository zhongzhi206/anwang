namespace MovieInfo
{
    partial class NewMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMain));
            this.dgv_one = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_data = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_shan = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_geng = new System.Windows.Forms.Button();
            this.btn_jia = new System.Windows.Forms.Button();
            this.btn_gai = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_wen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_one)).BeginInit();
            this.cmp_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_one
            // 
            this.dgv_one.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_one.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.title});
            this.dgv_one.ContextMenuStrip = this.cmp_data;
            this.dgv_one.Location = new System.Drawing.Point(2, 93);
            this.dgv_one.Name = "dgv_one";
            this.dgv_one.RowTemplate.Height = 27;
            this.dgv_one.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_one.Size = new System.Drawing.Size(460, 189);
            this.dgv_one.TabIndex = 0;
            this.dgv_one.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_one_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "XW_ID";
            this.ID.HeaderText = "新闻编号";
            this.ID.Name = "ID";
            // 
            // name
            // 
            this.name.DataPropertyName = "XW_name";
            this.name.HeaderText = "新闻名";
            this.name.Name = "name";
            // 
            // title
            // 
            this.title.DataPropertyName = "XW_title";
            this.title.HeaderText = "新文正文";
            this.title.Name = "title";
            // 
            // cmp_data
            // 
            this.cmp_data.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_shan});
            this.cmp_data.Name = "cmp_data";
            this.cmp_data.Size = new System.Drawing.Size(109, 28);
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
            this.label1.Size = new System.Drawing.Size(663, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // btn_geng
            // 
            this.btn_geng.Location = new System.Drawing.Point(509, 110);
            this.btn_geng.Name = "btn_geng";
            this.btn_geng.Size = new System.Drawing.Size(98, 35);
            this.btn_geng.TabIndex = 2;
            this.btn_geng.Text = "更新";
            this.btn_geng.UseVisualStyleBackColor = true;
            this.btn_geng.Click += new System.EventHandler(this.btn_geng_Click);
            // 
            // btn_jia
            // 
            this.btn_jia.Location = new System.Drawing.Point(509, 170);
            this.btn_jia.Name = "btn_jia";
            this.btn_jia.Size = new System.Drawing.Size(98, 35);
            this.btn_jia.TabIndex = 2;
            this.btn_jia.Text = "+ 添加";
            this.btn_jia.UseVisualStyleBackColor = true;
            this.btn_jia.Click += new System.EventHandler(this.btn_jia_Click);
            // 
            // btn_gai
            // 
            this.btn_gai.Location = new System.Drawing.Point(509, 226);
            this.btn_gai.Name = "btn_gai";
            this.btn_gai.Size = new System.Drawing.Size(98, 35);
            this.btn_gai.TabIndex = 2;
            this.btn_gai.Text = "@ 修改";
            this.btn_gai.UseVisualStyleBackColor = true;
            this.btn_gai.Click += new System.EventHandler(this.btn_gai_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(151, 368);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 25);
            this.tb_name.TabIndex = 3;
            // 
            // tb_wen
            // 
            this.tb_wen.Location = new System.Drawing.Point(137, 439);
            this.tb_wen.Multiline = true;
            this.tb_wen.Name = "tb_wen";
            this.tb_wen.Size = new System.Drawing.Size(350, 130);
            this.tb_wen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "新闻名：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "新闻正文：";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // NewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 610);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_wen);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btn_gai);
            this.Controls.Add(this.btn_jia);
            this.Controls.Add(this.btn_geng);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_one);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewMain";
            this.Text = "新闻维护";
            this.Load += new System.EventHandler(this.NewMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_one)).EndInit();
            this.cmp_data.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_one;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_geng;
        private System.Windows.Forms.Button btn_jia;
        private System.Windows.Forms.Button btn_gai;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_wen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cmp_data;
        private System.Windows.Forms.ToolStripMenuItem tsmi_shan;
    }
}