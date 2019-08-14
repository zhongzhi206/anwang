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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lianjie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nname,
            this.type,
            this.title,
            this.lianjie});
            this.dataGridView1.Location = new System.Drawing.Point(2, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(592, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "XW_ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // nname
            // 
            this.nname.DataPropertyName = "XW_name";
            this.nname.HeaderText = "新闻名称";
            this.nname.Name = "nname";
            // 
            // type
            // 
            this.type.DataPropertyName = "XW_type";
            this.type.HeaderText = "新闻类型";
            this.type.Name = "type";
            // 
            // title
            // 
            this.title.DataPropertyName = "XW_title";
            this.title.HeaderText = "新闻正文";
            this.title.Name = "title";
            // 
            // lianjie
            // 
            this.lianjie.DataPropertyName = "XW_lianjie";
            this.lianjie.HeaderText = "新闻链接";
            this.lianjie.Name = "lianjie";
            // 
            // NewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 603);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NewMain";
            this.Text = "新闻维护";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nname;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn lianjie;


    }
}