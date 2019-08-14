namespace MovieInfo
{
    partial class MovieQuery
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Query = new System.Windows.Forms.TextBox();
            this.btn_Query = new System.Windows.Forms.Button();
            this.dgv_one = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_two = new System.Windows.Forms.Button();
            this.tb_two = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_three = new System.Windows.Forms.TextBox();
            this.btn_tnree = new System.Windows.Forms.Button();
            this.btn_chong = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DY_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LX_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Releasetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_one)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(254, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "影片名：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_Query
            // 
            this.bt_Query.Location = new System.Drawing.Point(366, 34);
            this.bt_Query.Name = "bt_Query";
            this.bt_Query.Size = new System.Drawing.Size(275, 25);
            this.bt_Query.TabIndex = 1;
            this.bt_Query.TextChanged += new System.EventHandler(this.bt_Query_TextChanged);
            // 
            // btn_Query
            // 
            this.btn_Query.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Query.Location = new System.Drawing.Point(682, 29);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 32);
            this.btn_Query.TabIndex = 2;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // dgv_one
            // 
            this.dgv_one.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_one.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DY_Type,
            this.LX_ID,
            this.Name,
            this.Director,
            this.Start,
            this.Type,
            this.Price,
            this.Time,
            this.Description,
            this.Area,
            this.Releasetime});
            this.dgv_one.Location = new System.Drawing.Point(-8, 140);
            this.dgv_one.Name = "dgv_one";
            this.dgv_one.RowTemplate.Height = 27;
            this.dgv_one.Size = new System.Drawing.Size(1047, 408);
            this.dgv_one.TabIndex = 3;
            this.dgv_one.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_one_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(140, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "区域：";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_two
            // 
            this.btn_two.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_two.Location = new System.Drawing.Point(357, 85);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(75, 25);
            this.btn_two.TabIndex = 4;
            this.btn_two.Text = "查询";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.btn_two_Click);
            // 
            // tb_two
            // 
            this.tb_two.Location = new System.Drawing.Point(218, 83);
            this.tb_two.Name = "tb_two";
            this.tb_two.Size = new System.Drawing.Size(112, 25);
            this.tb_two.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(627, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "类型：";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_three
            // 
            this.tb_three.Location = new System.Drawing.Point(718, 85);
            this.tb_three.Name = "tb_three";
            this.tb_three.Size = new System.Drawing.Size(112, 25);
            this.tb_three.TabIndex = 5;
            // 
            // btn_tnree
            // 
            this.btn_tnree.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_tnree.Location = new System.Drawing.Point(860, 85);
            this.btn_tnree.Name = "btn_tnree";
            this.btn_tnree.Size = new System.Drawing.Size(75, 25);
            this.btn_tnree.TabIndex = 4;
            this.btn_tnree.Text = "查询";
            this.btn_tnree.UseVisualStyleBackColor = true;
            this.btn_tnree.Click += new System.EventHandler(this.btn_tnree_Click);
            // 
            // btn_chong
            // 
            this.btn_chong.Location = new System.Drawing.Point(780, 30);
            this.btn_chong.Name = "btn_chong";
            this.btn_chong.Size = new System.Drawing.Size(75, 30);
            this.btn_chong.TabIndex = 6;
            this.btn_chong.Text = "重置";
            this.btn_chong.UseVisualStyleBackColor = true;
            this.btn_chong.Click += new System.EventHandler(this.btn_chong_Click);
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
            // Name
            // 
            this.Name.DataPropertyName = "DY_Name";
            this.Name.HeaderText = "影片名";
            this.Name.Name = "Name";
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
            // MovieQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 560);
            this.Controls.Add(this.btn_chong);
            this.Controls.Add(this.tb_three);
            this.Controls.Add(this.tb_two);
            this.Controls.Add(this.btn_tnree);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.dgv_one);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.bt_Query);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询影片";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_one)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bt_Query;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.DataGridView dgv_one;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.TextBox tb_two;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_three;
        private System.Windows.Forms.Button btn_tnree;
        private System.Windows.Forms.Button btn_chong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DY_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn LX_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
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