namespace MovieInfo
{
    partial class Movietype
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
            this.dgv_one = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csm_delete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_one = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_one = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_one = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_gai = new System.Windows.Forms.Button();
            this.btn_chong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_one)).BeginInit();
            this.csm_delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_one
            // 
            this.dgv_one.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_one.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.type});
            this.dgv_one.ContextMenuStrip = this.csm_delete;
            this.dgv_one.Location = new System.Drawing.Point(0, 0);
            this.dgv_one.Name = "dgv_one";
            this.dgv_one.RowTemplate.Height = 27;
            this.dgv_one.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_one.Size = new System.Drawing.Size(245, 455);
            this.dgv_one.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "LX_ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // type
            // 
            this.type.DataPropertyName = "LX_Type";
            this.type.HeaderText = "类型";
            this.type.Name = "type";
            // 
            // csm_delete
            // 
            this.csm_delete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_one});
            this.csm_delete.Name = "csm_delete";
            this.csm_delete.Size = new System.Drawing.Size(109, 28);
            // 
            // tsmi_one
            // 
            this.tsmi_one.Name = "tsmi_one";
            this.tsmi_one.Size = new System.Drawing.Size(108, 24);
            this.tsmi_one.Text = "删除";
            this.tsmi_one.Click += new System.EventHandler(this.tsmi_one_Click);
            // 
            // tb_one
            // 
            this.tb_one.Location = new System.Drawing.Point(353, 50);
            this.tb_one.Name = "tb_one";
            this.tb_one.Size = new System.Drawing.Size(154, 25);
            this.tb_one.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "类型：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // but_one
            // 
            this.but_one.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_one.Location = new System.Drawing.Point(305, 150);
            this.but_one.Name = "but_one";
            this.but_one.Size = new System.Drawing.Size(156, 35);
            this.but_one.TabIndex = 3;
            this.but_one.Text = "查询";
            this.but_one.UseVisualStyleBackColor = true;
            this.but_one.Click += new System.EventHandler(this.but_one_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.Location = new System.Drawing.Point(305, 216);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(156, 33);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_gai
            // 
            this.btn_gai.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_gai.Location = new System.Drawing.Point(305, 276);
            this.btn_gai.Name = "btn_gai";
            this.btn_gai.Size = new System.Drawing.Size(156, 33);
            this.btn_gai.TabIndex = 5;
            this.btn_gai.Text = "修改";
            this.btn_gai.UseVisualStyleBackColor = true;
            this.btn_gai.Click += new System.EventHandler(this.btn_gai_Click);
            // 
            // btn_chong
            // 
            this.btn_chong.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_chong.Location = new System.Drawing.Point(305, 329);
            this.btn_chong.Name = "btn_chong";
            this.btn_chong.Size = new System.Drawing.Size(156, 33);
            this.btn_chong.TabIndex = 6;
            this.btn_chong.Text = "重置";
            this.btn_chong.UseVisualStyleBackColor = true;
            this.btn_chong.Click += new System.EventHandler(this.btn_chong_Click);
            // 
            // Movietype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 456);
            this.Controls.Add(this.btn_chong);
            this.Controls.Add(this.btn_gai);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.but_one);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_one);
            this.Controls.Add(this.dgv_one);
            this.Name = "Movietype";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            this.Load += new System.EventHandler(this.Movietype_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_one)).EndInit();
            this.csm_delete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_one;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.TextBox tb_one;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_one;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_gai;
        private System.Windows.Forms.ContextMenuStrip csm_delete;
        private System.Windows.Forms.ToolStripMenuItem tsmi_one;
        private System.Windows.Forms.Button btn_chong;
    }
}