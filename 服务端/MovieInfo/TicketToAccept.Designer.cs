namespace MovieInfo
{
    partial class TicketToAccept
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
            this.cms_Tui = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_ShouLi = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_JuJue = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_dingdan = new System.Windows.Forms.DataGridView();
            this.lb_tuishou = new System.Windows.Forms.Label();
            this.tb_dingd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.D_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YH_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DY_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_SeatInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayTimeo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Sheet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneratedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketingState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_Tui.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dingdan)).BeginInit();
            this.SuspendLayout();
            // 
            // cms_Tui
            // 
            this.cms_Tui.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_Tui.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_ShouLi,
            this.cms_JuJue,
            this.刷新ToolStripMenuItem});
            this.cms_Tui.Name = "cms_Tui";
            this.cms_Tui.Size = new System.Drawing.Size(211, 104);
            // 
            // cms_ShouLi
            // 
            this.cms_ShouLi.Name = "cms_ShouLi";
            this.cms_ShouLi.Size = new System.Drawing.Size(108, 24);
            this.cms_ShouLi.Text = "受理";
            this.cms_ShouLi.Click += new System.EventHandler(this.cms_ShouLi_Click);
            // 
            // cms_JuJue
            // 
            this.cms_JuJue.Name = "cms_JuJue";
            this.cms_JuJue.Size = new System.Drawing.Size(108, 24);
            this.cms_JuJue.Text = "拒绝";
            this.cms_JuJue.Click += new System.EventHandler(this.cms_JuJue_Click);
            // 
            // dgv_dingdan
            // 
            this.dgv_dingdan.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dingdan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dingdan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.D_ID,
            this.YH_ID,
            this.DY_ID,
            this.D_SeatInfo,
            this.PlayTimeo,
            this.SumPrice,
            this.Tings,
            this.D_Sheet,
            this.GeneratedTime,
            this.TicketingState});
            this.dgv_dingdan.ContextMenuStrip = this.cms_Tui;
            this.dgv_dingdan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_dingdan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgv_dingdan.Location = new System.Drawing.Point(0, 109);
            this.dgv_dingdan.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_dingdan.Name = "dgv_dingdan";
            this.dgv_dingdan.RowTemplate.Height = 23;
            this.dgv_dingdan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dingdan.Size = new System.Drawing.Size(1359, 569);
            this.dgv_dingdan.TabIndex = 3;
            this.dgv_dingdan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dingdan_CellContentClick);
            // 
            // lb_tuishou
            // 
            this.lb_tuishou.AutoSize = true;
            this.lb_tuishou.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_tuishou.Location = new System.Drawing.Point(11, 51);
            this.lb_tuishou.Name = "lb_tuishou";
            this.lb_tuishou.Size = new System.Drawing.Size(49, 20);
            this.lb_tuishou.TabIndex = 4;
            this.lb_tuishou.Text = "订单";
            // 
            // tb_dingd
            // 
            this.tb_dingd.Location = new System.Drawing.Point(87, 45);
            this.tb_dingd.Name = "tb_dingd";
            this.tb_dingd.Size = new System.Drawing.Size(189, 25);
            this.tb_dingd.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(338, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // D_ID
            // 
            this.D_ID.DataPropertyName = "D_ID";
            this.D_ID.HeaderText = "订单编号";
            this.D_ID.Name = "D_ID";
            this.D_ID.ReadOnly = true;
            this.D_ID.Width = 120;
            // 
            // YH_ID
            // 
            this.YH_ID.DataPropertyName = "UserName";
            this.YH_ID.HeaderText = "用户账号";
            this.YH_ID.Name = "YH_ID";
            this.YH_ID.ReadOnly = true;
            this.YH_ID.Width = 120;
            // 
            // DY_ID
            // 
            this.DY_ID.DataPropertyName = "FileName";
            this.DY_ID.HeaderText = "电影信息";
            this.DY_ID.Name = "DY_ID";
            this.DY_ID.ReadOnly = true;
            this.DY_ID.Width = 150;
            // 
            // D_SeatInfo
            // 
            this.D_SeatInfo.DataPropertyName = "SeatInfo";
            this.D_SeatInfo.HeaderText = "座位信息";
            this.D_SeatInfo.Name = "D_SeatInfo";
            this.D_SeatInfo.ReadOnly = true;
            this.D_SeatInfo.Width = 190;
            // 
            // PlayTimeo
            // 
            this.PlayTimeo.DataPropertyName = "PlayTime";
            this.PlayTimeo.HeaderText = "放映时间";
            this.PlayTimeo.Name = "PlayTimeo";
            this.PlayTimeo.Width = 130;
            // 
            // SumPrice
            // 
            this.SumPrice.DataPropertyName = "SumPrice";
            this.SumPrice.HeaderText = "总价";
            this.SumPrice.Name = "SumPrice";
            this.SumPrice.Width = 80;
            // 
            // Tings
            // 
            this.Tings.DataPropertyName = "Ting";
            this.Tings.HeaderText = "影厅";
            this.Tings.Name = "Tings";
            this.Tings.Width = 80;
            // 
            // D_Sheet
            // 
            this.D_Sheet.DataPropertyName = "Count";
            this.D_Sheet.HeaderText = "订票数量";
            this.D_Sheet.Name = "D_Sheet";
            this.D_Sheet.ReadOnly = true;
            this.D_Sheet.Width = 130;
            // 
            // GeneratedTime
            // 
            this.GeneratedTime.DataPropertyName = "GeneratedTime";
            this.GeneratedTime.HeaderText = "生成时间";
            this.GeneratedTime.Name = "GeneratedTime";
            this.GeneratedTime.Width = 200;
            // 
            // TicketingState
            // 
            this.TicketingState.DataPropertyName = "TicketingState";
            this.TicketingState.HeaderText = "支付状态";
            this.TicketingState.Name = "TicketingState";
            this.TicketingState.Width = 130;
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // TicketToAccept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 678);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_dingd);
            this.Controls.Add(this.lb_tuishou);
            this.Controls.Add(this.dgv_dingdan);
            this.Name = "TicketToAccept";
            this.Text = "退票受理";
            this.Load += new System.EventHandler(this.TicketToAccept_Load);
            this.cms_Tui.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dingdan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cms_Tui;
        private System.Windows.Forms.ToolStripMenuItem cms_ShouLi;
        private System.Windows.Forms.ToolStripMenuItem cms_JuJue;
        private System.Windows.Forms.DataGridView dgv_dingdan;
        private System.Windows.Forms.Label lb_tuishou;
        private System.Windows.Forms.TextBox tb_dingd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn YH_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DY_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_SeatInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayTimeo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tings;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Sheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneratedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketingState;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
    }
}