namespace MovieInfo
{
    partial class FilmSchedule
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
            this.dgv_Film = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DY_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DY_Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DY_Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DY_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DY_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DY_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DY_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_jia = new System.Windows.Forms.Button();
            this.pb_FilmImage = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Ting = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Film)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FilmImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Film
            // 
            this.dgv_Film.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Film.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DY_Name,
            this.DY_Director,
            this.DY_Start,
            this.DY_Type,
            this.DY_Time,
            this.DY_Description,
            this.DY_Area});
            this.dgv_Film.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_Film.Location = new System.Drawing.Point(0, 0);
            this.dgv_Film.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Film.Name = "dgv_Film";
            this.dgv_Film.RowTemplate.Height = 27;
            this.dgv_Film.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Film.Size = new System.Drawing.Size(1111, 365);
            this.dgv_Film.TabIndex = 0;
            this.dgv_Film.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Film_CellClick);
            this.dgv_Film.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Film_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "DY_ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // DY_Name
            // 
            this.DY_Name.DataPropertyName = "DY_Name";
            this.DY_Name.HeaderText = "电影名";
            this.DY_Name.Name = "DY_Name";
            // 
            // DY_Director
            // 
            this.DY_Director.DataPropertyName = "DY_Director";
            this.DY_Director.HeaderText = "导演";
            this.DY_Director.Name = "DY_Director";
            // 
            // DY_Start
            // 
            this.DY_Start.DataPropertyName = "DY_Start";
            this.DY_Start.HeaderText = "主演";
            this.DY_Start.Name = "DY_Start";
            // 
            // DY_Type
            // 
            this.DY_Type.DataPropertyName = "DY_Type";
            this.DY_Type.HeaderText = "类型";
            this.DY_Type.Name = "DY_Type";
            // 
            // DY_Time
            // 
            this.DY_Time.DataPropertyName = "DY_Time";
            this.DY_Time.HeaderText = "时长";
            this.DY_Time.Name = "DY_Time";
            // 
            // DY_Description
            // 
            this.DY_Description.DataPropertyName = "DY_Description";
            this.DY_Description.HeaderText = "描述";
            this.DY_Description.Name = "DY_Description";
            // 
            // DY_Area
            // 
            this.DY_Area.DataPropertyName = "DY_Area";
            this.DY_Area.HeaderText = "地区";
            this.DY_Area.Name = "DY_Area";
            // 
            // tb_name
            // 
            this.tb_name.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_name.Location = new System.Drawing.Point(155, 402);
            this.tb_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(109, 25);
            this.tb_name.TabIndex = 34;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(61, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "影片名：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(957, 525);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 38);
            this.button2.TabIndex = 36;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(957, 592);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 38);
            this.button1.TabIndex = 37;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_jia
            // 
            this.btn_jia.Location = new System.Drawing.Point(957, 456);
            this.btn_jia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_jia.Name = "btn_jia";
            this.btn_jia.Size = new System.Drawing.Size(99, 38);
            this.btn_jia.TabIndex = 38;
            this.btn_jia.Text = "添加";
            this.btn_jia.UseVisualStyleBackColor = true;
            this.btn_jia.Click += new System.EventHandler(this.btn_jia_Click);
            // 
            // pb_FilmImage
            // 
            this.pb_FilmImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_FilmImage.Location = new System.Drawing.Point(668, 456);
            this.pb_FilmImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_FilmImage.Name = "pb_FilmImage";
            this.pb_FilmImage.Size = new System.Drawing.Size(155, 167);
            this.pb_FilmImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_FilmImage.TabIndex = 40;
            this.pb_FilmImage.TabStop = false;
            this.pb_FilmImage.Click += new System.EventHandler(this.pb_FilmImage_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(665, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "影片海报（点击图片框上传海报）";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tb_time
            // 
            this.tb_time.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_time.Location = new System.Drawing.Point(155, 456);
            this.tb_time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(109, 25);
            this.tb_time.TabIndex = 42;
            this.tb_time.TextChanged += new System.EventHandler(this.tb_time_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(77, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "导演：";
            // 
            // textBox1
            // 
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox1.Location = new System.Drawing.Point(348, 456);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 167);
            this.textBox1.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(345, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "描述：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(77, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "主演：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(79, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 46;
            this.label4.Text = "类型：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(75, 642);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 47;
            this.label7.Text = "时长：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(69, 705);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 48;
            this.label8.Text = "地区：";
            // 
            // tb_Ting
            // 
            this.tb_Ting.DisplayMember = "YT_Name";
            this.tb_Ting.FormattingEnabled = true;
            this.tb_Ting.Items.AddRange(new object[] {
            "动漫",
            "武侠",
            "喜剧",
            "剧情",
            "恐怖",
            "科幻",
            "战争",
            "动作",
            "悬疑"});
            this.tb_Ting.Location = new System.Drawing.Point(156, 579);
            this.tb_Ting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Ting.Name = "tb_Ting";
            this.tb_Ting.Size = new System.Drawing.Size(109, 23);
            this.tb_Ting.TabIndex = 50;
            this.tb_Ting.ValueMember = "YT_Name";
            // 
            // textBox2
            // 
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox2.Location = new System.Drawing.Point(155, 515);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 25);
            this.textBox2.TabIndex = 53;
            // 
            // textBox3
            // 
            this.textBox3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox3.Location = new System.Drawing.Point(156, 631);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(69, 25);
            this.textBox3.TabIndex = 53;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "YT_Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "大陆",
            "中国台湾",
            "中国香港",
            "日本",
            "韩国",
            "印度",
            "泰国",
            "美国",
            "英国"});
            this.comboBox1.Location = new System.Drawing.Point(156, 695);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 23);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.ValueMember = "YT_Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(231, 635);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 54;
            this.label9.Text = "分钟";
            // 
            // FilmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 749);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tb_Ting);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pb_FilmImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_jia);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Film);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FilmSchedule";
            this.Text = "排片管理";
            this.Load += new System.EventHandler(this.FilmSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Film)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FilmImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Film;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_jia;
        private System.Windows.Forms.PictureBox pb_FilmImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox tb_Ting;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DY_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DY_Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn DY_Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn DY_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn DY_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn DY_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DY_Area;
        private System.Windows.Forms.Label label9;
    }
}