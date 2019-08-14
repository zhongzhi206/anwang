namespace MovieInfo
{
    partial class SeatMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeatMain));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_one = new System.Windows.Forms.DataGridView();
            this.btn_one = new System.Windows.Forms.Button();
            this.tb_cha = new System.Windows.Forms.TextBox();
            this.btn_geng = new System.Windows.Forms.Button();
            this.tb_one = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_jia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_two = new System.Windows.Forms.NumericUpDown();
            this.tb_three = new System.Windows.Forms.NumericUpDown();
            this.tb_Describe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yingting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangshu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lianshu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_one)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_two)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_three)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1031, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "_________________________________________________________________________________" +
    "_______________________________________________";
            // 
            // dgv_one
            // 
            this.dgv_one.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_one.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.yingting,
            this.hangshu,
            this.lianshu});
            this.dgv_one.Location = new System.Drawing.Point(2, 106);
            this.dgv_one.Name = "dgv_one";
            this.dgv_one.RowTemplate.Height = 27;
            this.dgv_one.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_one.Size = new System.Drawing.Size(994, 246);
            this.dgv_one.TabIndex = 1;
            this.dgv_one.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_one_CellClick);
            // 
            // btn_one
            // 
            this.btn_one.Location = new System.Drawing.Point(861, 50);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(85, 36);
            this.btn_one.TabIndex = 2;
            this.btn_one.Text = "查询";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.btn_one_Click);
            // 
            // tb_cha
            // 
            this.tb_cha.Location = new System.Drawing.Point(702, 50);
            this.tb_cha.Multiline = true;
            this.tb_cha.Name = "tb_cha";
            this.tb_cha.Size = new System.Drawing.Size(126, 36);
            this.tb_cha.TabIndex = 3;
            // 
            // btn_geng
            // 
            this.btn_geng.Location = new System.Drawing.Point(65, 50);
            this.btn_geng.Name = "btn_geng";
            this.btn_geng.Size = new System.Drawing.Size(85, 36);
            this.btn_geng.TabIndex = 4;
            this.btn_geng.Text = "更新";
            this.btn_geng.UseVisualStyleBackColor = true;
            this.btn_geng.Click += new System.EventHandler(this.btn_geng_Click);
            // 
            // tb_one
            // 
            this.tb_one.Location = new System.Drawing.Point(113, 395);
            this.tb_one.Name = "tb_one";
            this.tb_one.Size = new System.Drawing.Size(155, 25);
            this.tb_one.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "影厅名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "影厅行数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "影厅列数";
            // 
            // btn_jia
            // 
            this.btn_jia.Location = new System.Drawing.Point(723, 484);
            this.btn_jia.Name = "btn_jia";
            this.btn_jia.Size = new System.Drawing.Size(99, 38);
            this.btn_jia.TabIndex = 7;
            this.btn_jia.Text = "添加";
            this.btn_jia.UseVisualStyleBackColor = true;
            this.btn_jia.Click += new System.EventHandler(this.btn_jia_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(723, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_two
            // 
            this.tb_two.Location = new System.Drawing.Point(408, 395);
            this.tb_two.Name = "tb_two";
            this.tb_two.Size = new System.Drawing.Size(134, 25);
            this.tb_two.TabIndex = 8;
            this.tb_two.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_two_KeyPress);
            // 
            // tb_three
            // 
            this.tb_three.Location = new System.Drawing.Point(702, 395);
            this.tb_three.Name = "tb_three";
            this.tb_three.Size = new System.Drawing.Size(120, 25);
            this.tb_three.TabIndex = 9;
            this.tb_three.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_three_KeyPress);
            // 
            // tb_Describe
            // 
            this.tb_Describe.Location = new System.Drawing.Point(113, 484);
            this.tb_Describe.Multiline = true;
            this.tb_Describe.Name = "tb_Describe";
            this.tb_Describe.Size = new System.Drawing.Size(203, 162);
            this.tb_Describe.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "影厅名";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "YT_ID";
            this.ID.HeaderText = "影厅编号";
            this.ID.Name = "ID";
            // 
            // yingting
            // 
            this.yingting.DataPropertyName = "YT_Name";
            this.yingting.HeaderText = "影厅名";
            this.yingting.Name = "yingting";
            // 
            // hangshu
            // 
            this.hangshu.DataPropertyName = "YT_Row";
            this.hangshu.HeaderText = "影厅行数";
            this.hangshu.Name = "hangshu";
            // 
            // lianshu
            // 
            this.lianshu.DataPropertyName = "YT_Col";
            this.lianshu.HeaderText = "影厅列数";
            this.lianshu.Name = "lianshu";
            // 
            // SeatMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 693);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Describe);
            this.Controls.Add(this.tb_three);
            this.Controls.Add(this.tb_two);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_jia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_one);
            this.Controls.Add(this.btn_geng);
            this.Controls.Add(this.tb_cha);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.dgv_one);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeatMain";
            this.Text = "影厅维护";
            this.Load += new System.EventHandler(this.SeatMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_one)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_two)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_three)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_one;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.TextBox tb_cha;
        private System.Windows.Forms.Button btn_geng;
        private System.Windows.Forms.TextBox tb_one;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_jia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown tb_two;
        private System.Windows.Forms.NumericUpDown tb_three;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn yingting;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangshu;
        private System.Windows.Forms.DataGridViewTextBoxColumn lianshu;
        private System.Windows.Forms.TextBox tb_Describe;
        private System.Windows.Forms.Label label3;
    }
}