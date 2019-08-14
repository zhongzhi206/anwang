namespace MovieInfo
{
    partial class MovieGuanLi
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
            this.darkNetDataSet1 = new MovieInfo.DarkNetDataSet1();
            this.admInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admInfoTableAdapter = new MovieInfo.DarkNetDataSet1TableAdapters.AdmInfoTableAdapter();
            this.admInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_one = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zhiwu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.darkNetDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_one)).BeginInit();
            this.SuspendLayout();
            // 
            // darkNetDataSet1
            // 
            this.darkNetDataSet1.DataSetName = "DarkNetDataSet1";
            this.darkNetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admInfoBindingSource
            // 
            this.admInfoBindingSource.DataMember = "AdmInfo";
            this.admInfoBindingSource.DataSource = this.darkNetDataSet1;
            // 
            // admInfoTableAdapter
            // 
            this.admInfoTableAdapter.ClearBeforeFill = true;
            // 
            // admInfoBindingSource1
            // 
            this.admInfoBindingSource1.DataMember = "AdmInfo";
            this.admInfoBindingSource1.DataSource = this.darkNetDataSet1;
            // 
            // dgv_one
            // 
            this.dgv_one.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_one.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Zhiwu,
            this.MName,
            this.Pwd});
            this.dgv_one.Location = new System.Drawing.Point(-1, 1);
            this.dgv_one.Name = "dgv_one";
            this.dgv_one.RowTemplate.Height = 27;
            this.dgv_one.Size = new System.Drawing.Size(247, 433);
            this.dgv_one.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Zhiwu
            // 
            this.Zhiwu.DataPropertyName = "Zhiwu";
            this.Zhiwu.HeaderText = "职务";
            this.Zhiwu.Name = "Zhiwu";
            // 
            // MName
            // 
            this.MName.DataPropertyName = "Name";
            this.MName.HeaderText = "用户名";
            this.MName.Name = "MName";
            // 
            // Pwd
            // 
            this.Pwd.DataPropertyName = "Pwd";
            this.Pwd.HeaderText = "密码";
            this.Pwd.Name = "Pwd";
            this.Pwd.Visible = false;
            // 
            // MovieGuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 432);
            this.Controls.Add(this.dgv_one);
            this.Name = "MovieGuanLi";
            this.Text = "管理员查询";
            this.Load += new System.EventHandler(this.MovieGuanLi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.darkNetDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_one)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkNetDataSet1 darkNetDataSet1;
        private System.Windows.Forms.BindingSource admInfoBindingSource;
        private DarkNetDataSet1TableAdapters.AdmInfoTableAdapter admInfoTableAdapter;
        private System.Windows.Forms.BindingSource admInfoBindingSource1;
        private System.Windows.Forms.DataGridView dgv_one;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zhiwu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwd;
    }
}