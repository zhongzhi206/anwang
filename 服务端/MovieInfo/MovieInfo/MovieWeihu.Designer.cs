namespace MovieInfo
{
    partial class MovieWeihu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieWeihu));
            this.dgv_one = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DY_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LX_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Releasetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_delete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_one = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_start = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_director = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.movieTypeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.darkNetDataSet = new MovieInfo.DarkNetDataSet();
            this.movieTypeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.darkNetDataSet2 = new MovieInfo.DarkNetDataSet2();
            this.movieTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_area = new System.Windows.Forms.ComboBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.movieTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.movieTypeTableAdapter = new MovieInfo.DarkNetDataSetTableAdapters.MovieTypeTableAdapter();
            this.movieTypeTableAdapter1 = new MovieInfo.DarkNetDataSet2TableAdapters.MovieTypeTableAdapter();
            this.pb_FilmImage = new System.Windows.Forms.PictureBox();
            this.btn_chuan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_one)).BeginInit();
            this.cmp_delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieTypeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkNetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTypeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkNetDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FilmImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_one
            // 
            this.dgv_one.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_one.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DY_Type,
            this.LX_ID,
            this.MName,
            this.Director,
            this.Start,
            this.Type,
            this.Price,
            this.Time,
            this.Description,
            this.Area,
            this.Releasetime});
            this.dgv_one.ContextMenuStrip = this.cmp_delete;
            this.dgv_one.Location = new System.Drawing.Point(0, 2);
            this.dgv_one.Name = "dgv_one";
            this.dgv_one.RowTemplate.Height = 27;
            this.dgv_one.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_one.Size = new System.Drawing.Size(1047, 331);
            this.dgv_one.TabIndex = 4;
            this.dgv_one.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_one_CellContentClick);
            this.dgv_one.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_one_CellContentClick_1);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "DY_ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Visible = false;
            // 
            // DY_Type
            // 
            this.DY_Type.DataPropertyName = "DY_Type";
            this.DY_Type.HeaderText = "影片类型ID";
            this.DY_Type.Name = "DY_Type";
            this.DY_Type.Visible = false;
            // 
            // LX_ID
            // 
            this.LX_ID.DataPropertyName = "LX_ID";
            this.LX_ID.HeaderText = "类型ID";
            this.LX_ID.Name = "LX_ID";
            this.LX_ID.Visible = false;
            // 
            // MName
            // 
            this.MName.DataPropertyName = "DY_Name";
            this.MName.HeaderText = "影片名";
            this.MName.Name = "MName";
            // 
            // Director
            // 
            this.Director.DataPropertyName = "DY_Director";
            this.Director.HeaderText = "导演";
            this.Director.Name = "Director";
            // 
            // Start
            // 
            this.Start.DataPropertyName = "DY_Start";
            this.Start.HeaderText = "主演";
            this.Start.Name = "Start";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "LX_Type";
            this.Type.HeaderText = "类型";
            this.Type.Name = "Type";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "DY_Price";
            this.Price.HeaderText = "价格";
            this.Price.Name = "Price";
            // 
            // Time
            // 
            this.Time.DataPropertyName = "DY_Time";
            this.Time.HeaderText = "时长";
            this.Time.Name = "Time";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "DY_Description";
            this.Description.HeaderText = "描叙";
            this.Description.Name = "Description";
            // 
            // Area
            // 
            this.Area.DataPropertyName = "DY_Area";
            this.Area.HeaderText = "区域";
            this.Area.Name = "Area";
            // 
            // Releasetime
            // 
            this.Releasetime.DataPropertyName = "DY_Releasetime";
            this.Releasetime.HeaderText = "上映时间";
            this.Releasetime.Name = "Releasetime";
            // 
            // cmp_delete
            // 
            this.cmp_delete.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmp_delete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_one});
            this.cmp_delete.Name = "contextMenuStrip1";
            this.cmp_delete.Size = new System.Drawing.Size(109, 28);
            // 
            // tsmi_one
            // 
            this.tsmi_one.Name = "tsmi_one";
            this.tsmi_one.Size = new System.Drawing.Size(108, 24);
            this.tsmi_one.Text = "删除";
            this.tsmi_one.Click += new System.EventHandler(this.tsmi_one_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(63, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "影片名：";
            // 
            // tb_name
            // 
            this.tb_name.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_name.Location = new System.Drawing.Point(156, 353);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(109, 25);
            this.tb_name.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(79, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "主演：";
            // 
            // tb_start
            // 
            this.tb_start.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_start.Location = new System.Drawing.Point(156, 457);
            this.tb_start.Name = "tb_start";
            this.tb_start.Size = new System.Drawing.Size(109, 25);
            this.tb_start.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(79, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "导演：";
            // 
            // tb_director
            // 
            this.tb_director.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_director.Location = new System.Drawing.Point(156, 409);
            this.tb_director.Name = "tb_director";
            this.tb_director.Size = new System.Drawing.Size(109, 25);
            this.tb_director.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(79, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "类型：";
            // 
            // tb_price
            // 
            this.tb_price.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_price.Location = new System.Drawing.Point(156, 544);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(109, 25);
            this.tb_price.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(354, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "时长：";
            // 
            // tb_time
            // 
            this.tb_time.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_time.Location = new System.Drawing.Point(425, 352);
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(109, 25);
            this.tb_time.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(622, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "图片上传：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(354, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "描述：";
            // 
            // tb_description
            // 
            this.tb_description.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_description.Location = new System.Drawing.Point(425, 410);
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(109, 25);
            this.tb_description.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(79, 557);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "价格：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(354, 467);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "区域：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(322, 505);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "上映时间：";
            // 
            // dtp_time
            // 
            this.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_time.Location = new System.Drawing.Point(425, 503);
            this.dtp_time.Name = "dtp_time";
            this.dtp_time.Size = new System.Drawing.Size(109, 25);
            this.dtp_time.TabIndex = 7;
            this.dtp_time.TabStop = false;
            // 
            // cb_type
            // 
            this.cb_type.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.movieTypeBindingSource2, "LX_Type", true));
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "动漫",
            "灾难",
            "剧情",
            "恐怖",
            "科幻",
            "动作",
            "犯罪",
            "喜剧"});
            this.cb_type.Location = new System.Drawing.Point(156, 505);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(109, 23);
            this.cb_type.TabIndex = 8;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cb_type_SelectedIndexChanged);
            // 
            // movieTypeBindingSource2
            // 
            this.movieTypeBindingSource2.DataMember = "MovieType";
            this.movieTypeBindingSource2.DataSource = this.darkNetDataSet;
            // 
            // darkNetDataSet
            // 
            this.darkNetDataSet.DataSetName = "DarkNetDataSet";
            this.darkNetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieTypeBindingSource3
            // 
            this.movieTypeBindingSource3.DataMember = "MovieType";
            this.movieTypeBindingSource3.DataSource = this.darkNetDataSet2;
            // 
            // darkNetDataSet2
            // 
            this.darkNetDataSet2.DataSetName = "DarkNetDataSet2";
            this.darkNetDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieTypeBindingSource
            // 
            this.movieTypeBindingSource.DataMember = "MovieType";
            // 
            // cb_area
            // 
            this.cb_area.FormattingEnabled = true;
            this.cb_area.Items.AddRange(new object[] {
            "中国大陆",
            "美国",
            "日本",
            "印度",
            "中国台湾",
            "中国香港",
            "韩国",
            "英国"});
            this.cb_area.Location = new System.Drawing.Point(425, 461);
            this.cb_area.Name = "cb_area";
            this.cb_area.Size = new System.Drawing.Size(109, 23);
            this.cb_area.TabIndex = 9;
            // 
            // bt_add
            // 
            this.bt_add.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_add.Location = new System.Drawing.Point(885, 412);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(114, 35);
            this.bt_add.TabIndex = 10;
            this.bt_add.Text = "新添";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_update
            // 
            this.bt_update.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_update.Location = new System.Drawing.Point(885, 516);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(114, 35);
            this.bt_update.TabIndex = 10;
            this.bt_update.Text = "修改";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // movieTypeBindingSource1
            // 
            this.movieTypeBindingSource1.DataMember = "MovieType";
            // 
            // movieTypeTableAdapter
            // 
            this.movieTypeTableAdapter.ClearBeforeFill = true;
            // 
            // movieTypeTableAdapter1
            // 
            this.movieTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // pb_FilmImage
            // 
            this.pb_FilmImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_FilmImage.Location = new System.Drawing.Point(641, 394);
            this.pb_FilmImage.Name = "pb_FilmImage";
            this.pb_FilmImage.Size = new System.Drawing.Size(155, 175);
            this.pb_FilmImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_FilmImage.TabIndex = 11;
            this.pb_FilmImage.TabStop = false;
            // 
            // btn_chuan
            // 
            this.btn_chuan.AutoSize = true;
            this.btn_chuan.Location = new System.Drawing.Point(682, 575);
            this.btn_chuan.Name = "btn_chuan";
            this.btn_chuan.Size = new System.Drawing.Size(77, 25);
            this.btn_chuan.TabIndex = 13;
            this.btn_chuan.Text = "上传图片";
            this.btn_chuan.UseVisualStyleBackColor = true;
            this.btn_chuan.Click += new System.EventHandler(this.btn_chuan_Click);
            // 
            // MovieWeihu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 690);
            this.Controls.Add(this.btn_chuan);
            this.Controls.Add(this.pb_FilmImage);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.cb_area);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.dtp_time);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_director);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_one);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "MovieWeihu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.MovieWeihu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_one)).EndInit();
            this.cmp_delete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movieTypeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkNetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTypeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkNetDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FilmImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_one;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_director;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_time;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.ComboBox cb_area;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.ContextMenuStrip cmp_delete;
        private System.Windows.Forms.BindingSource movieTypeBindingSource;
        private System.Windows.Forms.BindingSource movieTypeBindingSource1;
        private DarkNetDataSetTableAdapters.MovieTypeTableAdapter movieTypeTableAdapter;
        private DarkNetDataSet darkNetDataSet;
        private System.Windows.Forms.ToolStripMenuItem tsmi_one;
        private System.Windows.Forms.BindingSource movieTypeBindingSource2;
        private DarkNetDataSet2 darkNetDataSet2;
        private System.Windows.Forms.BindingSource movieTypeBindingSource3;
        private DarkNetDataSet2TableAdapters.MovieTypeTableAdapter movieTypeTableAdapter1;
        private System.Windows.Forms.PictureBox pb_FilmImage;
        private System.Windows.Forms.Button btn_chuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DY_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn LX_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Releasetime;
    }
}