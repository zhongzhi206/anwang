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
            this.tb_Ting = new System.Windows.Forms.ComboBox();
            this.tb_PlayTime = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_Price = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_jia = new System.Windows.Forms.Button();
            this.pb_FilmImage = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YingTing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Film)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FilmImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Film
            // 
            this.dgv_Film.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Film.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FileName,
            this.Duration,
            this.Price,
            this.YingTing,
            this.ReleaseDate,
            this.ReleaseTime});
            this.dgv_Film.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_Film.Location = new System.Drawing.Point(0, 0);
            this.dgv_Film.Name = "dgv_Film";
            this.dgv_Film.RowTemplate.Height = 27;
            this.dgv_Film.Size = new System.Drawing.Size(947, 365);
            this.dgv_Film.TabIndex = 0;
            // 
            // tb_Ting
            // 
            this.tb_Ting.DisplayMember = "YT_Name";
            this.tb_Ting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_Ting.FormattingEnabled = true;
            this.tb_Ting.Location = new System.Drawing.Point(154, 528);
            this.tb_Ting.Name = "tb_Ting";
            this.tb_Ting.Size = new System.Drawing.Size(109, 23);
            this.tb_Ting.TabIndex = 30;
            this.tb_Ting.ValueMember = "YT_Name";
            // 
            // tb_PlayTime
            // 
            this.tb_PlayTime.Location = new System.Drawing.Point(154, 617);
            this.tb_PlayTime.Name = "tb_PlayTime";
            this.tb_PlayTime.Size = new System.Drawing.Size(109, 25);
            this.tb_PlayTime.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(51, 617);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "播放时间：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(77, 531);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "影厅：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(77, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "价格：";
            // 
            // dtp_time
            // 
            this.dtp_time.CustomFormat = "yyyy-MM-dd";
            this.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_time.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtp_time.Location = new System.Drawing.Point(154, 573);
            this.dtp_time.Name = "dtp_time";
            this.dtp_time.Size = new System.Drawing.Size(109, 25);
            this.dtp_time.TabIndex = 32;
            this.dtp_time.TabStop = false;
            this.dtp_time.Value = new System.DateTime(2019, 6, 6, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(51, 579);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "上映时间：";
            // 
            // tb_name
            // 
            this.tb_name.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_name.Location = new System.Drawing.Point(154, 403);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(109, 25);
            this.tb_name.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(61, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "影片名：";
            // 
            // nud_Price
            // 
            this.nud_Price.Location = new System.Drawing.Point(154, 484);
            this.nud_Price.Name = "nud_Price";
            this.nud_Price.Size = new System.Drawing.Size(109, 25);
            this.nud_Price.TabIndex = 35;
            this.nud_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nud_Price_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 38);
            this.button2.TabIndex = 36;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 38);
            this.button1.TabIndex = 37;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_jia
            // 
            this.btn_jia.Location = new System.Drawing.Point(596, 410);
            this.btn_jia.Name = "btn_jia";
            this.btn_jia.Size = new System.Drawing.Size(99, 38);
            this.btn_jia.TabIndex = 38;
            this.btn_jia.Text = "添加";
            this.btn_jia.UseVisualStyleBackColor = true;
            // 
            // pb_FilmImage
            // 
            this.pb_FilmImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_FilmImage.Location = new System.Drawing.Point(345, 440);
            this.pb_FilmImage.Name = "pb_FilmImage";
            this.pb_FilmImage.Size = new System.Drawing.Size(155, 167);
            this.pb_FilmImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_FilmImage.TabIndex = 40;
            this.pb_FilmImage.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(342, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "影片海报：";
            // 
            // tb_time
            // 
            this.tb_time.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_time.Location = new System.Drawing.Point(154, 440);
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(109, 25);
            this.tb_time.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(77, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "时长：";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "电影名";
            this.FileName.Name = "FileName";
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "时长";
            this.Duration.Name = "Duration";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "价格";
            this.Price.Name = "Price";
            // 
            // YingTing
            // 
            this.YingTing.DataPropertyName = "YingTing";
            this.YingTing.HeaderText = "影厅";
            this.YingTing.Name = "YingTing";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.DataPropertyName = "ReleaseDate";
            this.ReleaseDate.HeaderText = "上映日期";
            this.ReleaseDate.Name = "ReleaseDate";
            // 
            // ReleaseTime
            // 
            this.ReleaseTime.DataPropertyName = "ReleaseTime";
            this.ReleaseTime.HeaderText = "播放时间";
            this.ReleaseTime.Name = "ReleaseTime";
            // 
            // FilmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 690);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pb_FilmImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_jia);
            this.Controls.Add(this.nud_Price);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_time);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_Ting);
            this.Controls.Add(this.tb_PlayTime);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_Film);
            this.Name = "FilmSchedule";
            this.Text = "排片管理";
            this.Load += new System.EventHandler(this.FilmSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Film)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FilmImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Film;
        private System.Windows.Forms.ComboBox tb_Ting;
        private System.Windows.Forms.DateTimePicker tb_PlayTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_time;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_Price;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_jia;
        private System.Windows.Forms.PictureBox pb_FilmImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn YingTing;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseTime;
    }
}