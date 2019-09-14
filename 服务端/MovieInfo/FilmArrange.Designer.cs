namespace MovieInfo
{
    partial class FilmArrange
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
            this.btn_one = new System.Windows.Forms.Button();
            this.tb_one = new System.Windows.Forms.TextBox();
            this.cb_Ting = new System.Windows.Forms.ComboBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_PlayTime = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.pb_FilmImage = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_Film = new System.Windows.Forms.DataGridView();
            this.PP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PP_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PP_StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PP_EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PP_Ting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PP_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_FilmName = new System.Windows.Forms.ComboBox();
            this.bt_Update = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FilmImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Film)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_one
            // 
            this.btn_one.Location = new System.Drawing.Point(1046, 21);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(51, 27);
            this.btn_one.TabIndex = 19;
            this.btn_one.Text = "搜索";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.btn_one_Click);
            // 
            // tb_one
            // 
            this.tb_one.Location = new System.Drawing.Point(870, 21);
            this.tb_one.Name = "tb_one";
            this.tb_one.Size = new System.Drawing.Size(142, 25);
            this.tb_one.TabIndex = 18;
            // 
            // cb_Ting
            // 
            this.cb_Ting.FormattingEnabled = true;
            this.cb_Ting.Location = new System.Drawing.Point(131, 593);
            this.cb_Ting.Name = "cb_Ting";
            this.cb_Ting.Size = new System.Drawing.Size(175, 23);
            this.cb_Ting.TabIndex = 30;
            // 
            // tb_price
            // 
            this.tb_price.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_price.Location = new System.Drawing.Point(131, 553);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(175, 25);
            this.tb_price.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(54, 596);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "影厅：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(54, 556);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "价格：";
            // 
            // dtp_PlayTime
            // 
            this.dtp_PlayTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtp_PlayTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_PlayTime.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtp_PlayTime.Location = new System.Drawing.Point(471, 508);
            this.dtp_PlayTime.Name = "dtp_PlayTime";
            this.dtp_PlayTime.Size = new System.Drawing.Size(182, 25);
            this.dtp_PlayTime.TabIndex = 32;
            this.dtp_PlayTime.TabStop = false;
            this.dtp_PlayTime.Value = new System.DateTime(2019, 6, 6, 0, 0, 0, 0);
            this.dtp_PlayTime.ValueChanged += new System.EventHandler(this.dtp_PlayTime_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(368, 514);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "上映时间：";
            // 
            // pb_FilmImage
            // 
            this.pb_FilmImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_FilmImage.Location = new System.Drawing.Point(708, 514);
            this.pb_FilmImage.Name = "pb_FilmImage";
            this.pb_FilmImage.Size = new System.Drawing.Size(155, 175);
            this.pb_FilmImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_FilmImage.TabIndex = 34;
            this.pb_FilmImage.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(705, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "电影海报：";
            // 
            // dgv_Film
            // 
            this.dgv_Film.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Film.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PP_ID,
            this.PP_Name,
            this.PP_StartTime,
            this.PP_EndTime,
            this.PP_Ting,
            this.PP_Price});
            this.dgv_Film.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_Film.Location = new System.Drawing.Point(12, 100);
            this.dgv_Film.Name = "dgv_Film";
            this.dgv_Film.RowTemplate.Height = 27;
            this.dgv_Film.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Film.Size = new System.Drawing.Size(1153, 331);
            this.dgv_Film.TabIndex = 35;
            this.dgv_Film.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Film_CellClick);
            this.dgv_Film.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Film_CellContentClick);
            // 
            // PP_ID
            // 
            this.PP_ID.DataPropertyName = "PP_ID";
            this.PP_ID.HeaderText = "ID";
            this.PP_ID.Name = "PP_ID";
            this.PP_ID.Visible = false;
            // 
            // PP_Name
            // 
            this.PP_Name.DataPropertyName = "PP_Name";
            this.PP_Name.HeaderText = "电影名称";
            this.PP_Name.Name = "PP_Name";
            // 
            // PP_StartTime
            // 
            this.PP_StartTime.DataPropertyName = "PP_StartTime";
            this.PP_StartTime.HeaderText = "播放时间";
            this.PP_StartTime.Name = "PP_StartTime";
            // 
            // PP_EndTime
            // 
            this.PP_EndTime.DataPropertyName = "PP_EndTime";
            this.PP_EndTime.HeaderText = "散场时间";
            this.PP_EndTime.Name = "PP_EndTime";
            // 
            // PP_Ting
            // 
            this.PP_Ting.DataPropertyName = "PP_Ting";
            this.PP_Ting.HeaderText = "影厅";
            this.PP_Ting.Name = "PP_Ting";
            // 
            // PP_Price
            // 
            this.PP_Price.DataPropertyName = "PP_Price";
            this.PP_Price.HeaderText = "价格";
            this.PP_Price.Name = "PP_Price";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(38, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "影片名：";
            // 
            // cb_FilmName
            // 
            this.cb_FilmName.FormattingEnabled = true;
            this.cb_FilmName.Location = new System.Drawing.Point(131, 514);
            this.cb_FilmName.Name = "cb_FilmName";
            this.cb_FilmName.Size = new System.Drawing.Size(175, 23);
            this.cb_FilmName.TabIndex = 37;
            this.cb_FilmName.SelectedIndexChanged += new System.EventHandler(this.cb_FilmName_SelectedIndexChanged);
            // 
            // bt_Update
            // 
            this.bt_Update.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Update.Location = new System.Drawing.Point(373, 654);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(114, 35);
            this.bt_Update.TabIndex = 38;
            this.bt_Update.Text = "修改";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Add.Location = new System.Drawing.Point(131, 654);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(114, 35);
            this.bt_Add.TabIndex = 39;
            this.bt_Add.Text = "新添";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(368, 594);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "散场时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(468, 594);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(370, 551);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "电影时长：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(470, 551);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 43;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 23);
            this.comboBox1.TabIndex = 44;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "查询";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 15);
            this.label9.TabIndex = 46;
            this.label9.Text = "厅";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePicker2.Location = new System.Drawing.Point(365, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(182, 25);
            this.dateTimePicker2.TabIndex = 48;
            this.dateTimePicker2.TabStop = false;
            this.dateTimePicker2.Value = new System.DateTime(2019, 6, 6, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePicker1.Location = new System.Drawing.Point(636, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 25);
            this.dateTimePicker1.TabIndex = 49;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.Value = new System.DateTime(2019, 6, 6, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(292, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 50;
            this.label11.Text = "起始时间";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(563, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 51;
            this.label13.Text = "结束时间";
            // 
            // FilmArrange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 754);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_Update);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.cb_FilmName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Film);
            this.Controls.Add(this.pb_FilmImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_PlayTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_Ting);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.tb_one);
            this.Name = "FilmArrange";
            this.Text = "影片安排";
            this.Load += new System.EventHandler(this.FilmArrange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_FilmImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Film)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.TextBox tb_one;
        private System.Windows.Forms.ComboBox cb_Ting;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_PlayTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pb_FilmImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_Film;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_FilmName;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PP_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PP_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn PP_StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PP_EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PP_Ting;
        private System.Windows.Forms.DataGridViewTextBoxColumn PP_Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}