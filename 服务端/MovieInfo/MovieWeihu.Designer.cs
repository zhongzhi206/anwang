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
            this.dgv_cha = new System.Windows.Forms.DataGridView();
            this.cmp_delete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_one = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ShuaXin = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_start = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_director = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.movieTypeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.darkNetDataSet = new MovieInfo.DarkNetDataSet();
            this.movieTypeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.darkNetDataSet2 = new MovieInfo.DarkNetDataSet2();
            this.cb_area = new System.Windows.Forms.ComboBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.movieTypeTableAdapter = new MovieInfo.DarkNetDataSetTableAdapters.MovieTypeTableAdapter();
            this.movieTypeTableAdapter1 = new MovieInfo.DarkNetDataSet2TableAdapters.MovieTypeTableAdapter();
            this.pb_FilmImage = new System.Windows.Forms.PictureBox();
            this.btn_chuan = new System.Windows.Forms.Button();
            this.btn_one = new System.Windows.Forms.Button();
            this.tb_one = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.movieTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yingTingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.darkNetDataSet4 = new MovieInfo.DarkNetDataSet4();
            this.yingTingTableAdapter = new MovieInfo.DarkNetDataSet4TableAdapters.YingTingTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DY_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LX_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cha)).BeginInit();
            this.cmp_delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieTypeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkNetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTypeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkNetDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FilmImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yingTingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkNetDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cha
            // 
            this.dgv_cha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DY_Type,
            this.LX_ID,
            this.MName,
            this.Director,
            this.Start,
            this.Type,
            this.Time,
            this.Description,
            this.Area});
            this.dgv_cha.ContextMenuStrip = this.cmp_delete;
            this.dgv_cha.Location = new System.Drawing.Point(1, 95);
            this.dgv_cha.Name = "dgv_cha";
            this.dgv_cha.ReadOnly = true;
            this.dgv_cha.RowTemplate.Height = 27;
            this.dgv_cha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cha.Size = new System.Drawing.Size(1129, 331);
            this.dgv_cha.TabIndex = 4;
            this.dgv_cha.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_one_CellContentClick);
            this.dgv_cha.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cha_CellContentClick);
            // 
            // cmp_delete
            // 
            this.cmp_delete.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmp_delete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_one,
            this.tsm_ShuaXin});
            this.cmp_delete.Name = "contextMenuStrip1";
            this.cmp_delete.Size = new System.Drawing.Size(109, 52);
            // 
            // tsmi_one
            // 
            this.tsmi_one.Name = "tsmi_one";
            this.tsmi_one.Size = new System.Drawing.Size(108, 24);
            this.tsmi_one.Text = "删除";
            this.tsmi_one.Click += new System.EventHandler(this.tsmi_one_Click);
            // 
            // tsm_ShuaXin
            // 
            this.tsm_ShuaXin.Name = "tsm_ShuaXin";
            this.tsm_ShuaXin.Size = new System.Drawing.Size(108, 24);
            this.tsm_ShuaXin.Text = "刷新";
            this.tsm_ShuaXin.Click += new System.EventHandler(this.tsm_ShuaXin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(65, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "影片名：";
            // 
            // tb_name
            // 
            this.tb_name.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_name.Location = new System.Drawing.Point(158, 448);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(109, 25);
            this.tb_name.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(81, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "主演：";
            // 
            // tb_start
            // 
            this.tb_start.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_start.Location = new System.Drawing.Point(158, 552);
            this.tb_start.Name = "tb_start";
            this.tb_start.Size = new System.Drawing.Size(109, 25);
            this.tb_start.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(81, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "导演：";
            // 
            // tb_director
            // 
            this.tb_director.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_director.Location = new System.Drawing.Point(158, 504);
            this.tb_director.Name = "tb_director";
            this.tb_director.Size = new System.Drawing.Size(109, 25);
            this.tb_director.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(81, 611);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "类型：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(356, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "时长：";
            // 
            // tb_time
            // 
            this.tb_time.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_time.Location = new System.Drawing.Point(427, 452);
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(109, 25);
            this.tb_time.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(624, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "上传海报：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(356, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "描述：";
            // 
            // tb_description
            // 
            this.tb_description.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_description.Location = new System.Drawing.Point(427, 505);
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(109, 25);
            this.tb_description.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(356, 562);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "区域：";
            // 
            // cb_type
            // 
            this.cb_type.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.movieTypeBindingSource2, "LX_Type", true));
            this.cb_type.FormattingEnabled = true;
            this.cb_type.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cb_type.Items.AddRange(new object[] {
            "动漫",
            "喜剧",
            "动作",
            "剧情",
            "恐怖",
            "悬疑",
            "战争",
            "武侠",
            "科幻"});
            this.cb_type.Location = new System.Drawing.Point(158, 608);
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
            // cb_area
            // 
            this.cb_area.FormattingEnabled = true;
            this.cb_area.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cb_area.Items.AddRange(new object[] {
            "中国大陆",
            "中国台湾",
            "中国香港",
            "日本",
            "韩国",
            "印度",
            "泰国",
            "美国",
            "英国"});
            this.cb_area.Location = new System.Drawing.Point(427, 556);
            this.cb_area.Name = "cb_area";
            this.cb_area.Size = new System.Drawing.Size(109, 23);
            this.cb_area.TabIndex = 9;
            // 
            // bt_add
            // 
            this.bt_add.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_add.Location = new System.Drawing.Point(887, 507);
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
            this.bt_update.Location = new System.Drawing.Point(887, 590);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(114, 35);
            this.bt_update.TabIndex = 10;
            this.bt_update.Text = "修改";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
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
            this.pb_FilmImage.Location = new System.Drawing.Point(643, 489);
            this.pb_FilmImage.Name = "pb_FilmImage";
            this.pb_FilmImage.Size = new System.Drawing.Size(155, 175);
            this.pb_FilmImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_FilmImage.TabIndex = 11;
            this.pb_FilmImage.TabStop = false;
            this.pb_FilmImage.Click += new System.EventHandler(this.pb_FilmImage_Click);
            // 
            // btn_chuan
            // 
            this.btn_chuan.AutoSize = true;
            this.btn_chuan.Location = new System.Drawing.Point(683, 681);
            this.btn_chuan.Name = "btn_chuan";
            this.btn_chuan.Size = new System.Drawing.Size(77, 25);
            this.btn_chuan.TabIndex = 13;
            this.btn_chuan.Text = "上传图片";
            this.btn_chuan.UseVisualStyleBackColor = true;
            this.btn_chuan.Click += new System.EventHandler(this.btn_chuan_Click);
            // 
            // btn_one
            // 
            this.btn_one.Location = new System.Drawing.Point(897, 36);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(51, 27);
            this.btn_one.TabIndex = 16;
            this.btn_one.Text = "搜索";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.btn_one_Click);
            // 
            // tb_one
            // 
            this.tb_one.Location = new System.Drawing.Point(721, 36);
            this.tb_one.Name = "tb_one";
            this.tb_one.Size = new System.Drawing.Size(142, 25);
            this.tb_one.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-2, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1143, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "_________________________________________________________________________________" +
    "_____________________________________________________________";
            // 
            // movieTypeBindingSource
            // 
            this.movieTypeBindingSource.DataMember = "MovieType";
            // 
            // movieTypeBindingSource1
            // 
            this.movieTypeBindingSource1.DataMember = "MovieType";
            // 
            // yingTingBindingSource
            // 
            this.yingTingBindingSource.DataMember = "YingTing";
            this.yingTingBindingSource.DataSource = this.darkNetDataSet4;
            // 
            // darkNetDataSet4
            // 
            this.darkNetDataSet4.DataSetName = "DarkNetDataSet4";
            this.darkNetDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yingTingTableAdapter
            // 
            this.yingTingTableAdapter.ClearBeforeFill = true;
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
            this.DY_Type.ReadOnly = true;
            this.DY_Type.Visible = false;
            // 
            // LX_ID
            // 
            this.LX_ID.DataPropertyName = "LX_ID";
            this.LX_ID.HeaderText = "类型ID";
            this.LX_ID.Name = "LX_ID";
            this.LX_ID.ReadOnly = true;
            this.LX_ID.Visible = false;
            // 
            // MName
            // 
            this.MName.DataPropertyName = "DY_Name";
            this.MName.HeaderText = "影片名";
            this.MName.Name = "MName";
            this.MName.ReadOnly = true;
            // 
            // Director
            // 
            this.Director.DataPropertyName = "DY_Director";
            this.Director.HeaderText = "导演";
            this.Director.Name = "Director";
            this.Director.ReadOnly = true;
            // 
            // Start
            // 
            this.Start.DataPropertyName = "DY_Start";
            this.Start.HeaderText = "主演";
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "DY_Type";
            this.Type.HeaderText = "类型";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "DY_Time";
            this.Time.HeaderText = "时长";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "DY_Description";
            this.Description.HeaderText = "描叙";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.DataPropertyName = "DY_Area";
            this.Area.HeaderText = "区域";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // MovieWeihu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 770);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.tb_one);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_chuan);
            this.Controls.Add(this.pb_FilmImage);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.cb_area);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_director);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_cha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovieWeihu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.MovieWeihu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cha)).EndInit();
            this.cmp_delete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movieTypeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkNetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTypeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkNetDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FilmImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yingTingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkNetDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_director;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.TextBox tb_one;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem tsm_ShuaXin;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private DarkNetDataSet4 darkNetDataSet4;
        private System.Windows.Forms.BindingSource yingTingBindingSource;
        private DarkNetDataSet4TableAdapters.YingTingTableAdapter yingTingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DY_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn LX_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
    }
}