namespace MovieInfo
{
    partial class AdmInfo
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
            this.darkNetDataSet = new MovieInfo.DarkNetDataSet();
            this.movieTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieTypeTableAdapter = new MovieInfo.DarkNetDataSetTableAdapters.MovieTypeTableAdapter();
            this.dvg_one = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zhiwu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_zhiwu = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.darkNetDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkNetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_one)).BeginInit();
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
            // darkNetDataSet
            // 
            this.darkNetDataSet.DataSetName = "DarkNetDataSet";
            this.darkNetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieTypeBindingSource
            // 
            this.movieTypeBindingSource.DataMember = "MovieType";
            this.movieTypeBindingSource.DataSource = this.darkNetDataSet;
            // 
            // movieTypeTableAdapter
            // 
            this.movieTypeTableAdapter.ClearBeforeFill = true;
            // 
            // dvg_one
            // 
            this.dvg_one.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_one.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Zhiwu,
            this.MName,
            this.Pwd});
            this.dvg_one.Location = new System.Drawing.Point(0, 0);
            this.dvg_one.Name = "dvg_one";
            this.dvg_one.RowTemplate.Height = 27;
            this.dvg_one.Size = new System.Drawing.Size(349, 452);
            this.dvg_one.TabIndex = 0;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(377, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "职务：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(361, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(377, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "密码：";
            // 
            // tb_zhiwu
            // 
            this.tb_zhiwu.Location = new System.Drawing.Point(438, 22);
            this.tb_zhiwu.Name = "tb_zhiwu";
            this.tb_zhiwu.Size = new System.Drawing.Size(146, 25);
            this.tb_zhiwu.TabIndex = 2;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(438, 108);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(146, 25);
            this.tb_name.TabIndex = 2;
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(438, 182);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(146, 25);
            this.tb_pwd.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(407, 244);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(155, 33);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(407, 294);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(155, 33);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(407, 346);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(155, 33);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "修改";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 451);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_zhiwu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvg_one);
            this.Name = "AdmInfo";
            this.Text = "管理员维护";
            this.Load += new System.EventHandler(this.AdmInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.darkNetDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkNetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_one)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkNetDataSet1 darkNetDataSet1;
        private System.Windows.Forms.BindingSource admInfoBindingSource;
        private DarkNetDataSet1TableAdapters.AdmInfoTableAdapter admInfoTableAdapter;
        private DarkNetDataSet darkNetDataSet;
        private System.Windows.Forms.BindingSource movieTypeBindingSource;
        private DarkNetDataSetTableAdapters.MovieTypeTableAdapter movieTypeTableAdapter;
        private System.Windows.Forms.DataGridView dvg_one;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zhiwu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_zhiwu;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
    }
}