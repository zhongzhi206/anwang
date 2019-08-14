using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieInfo
{
    public partial class TicketToAccept : Form
    {
        public TicketToAccept()
        {
            InitializeComponent();
        }

        private void TicketToAccept_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select * from OrderInfo where TicketingState ='待退款' order by D_ID desc");
            dgv_dingdan.DataSource = DBHelper.GetDataTable(sql);

        }
        string playTime = "";
        private void cms_ShouLi_Click(object sender, EventArgs e)
        {
            playTime = dgv_dingdan.SelectedRows[0].Cells["PlayTimeo"].Value.ToString();
            string filName = dgv_dingdan.SelectedRows[0].Cells["DY_ID"].Value.ToString();
            string fangYing = Convert.ToDateTime(playTime).ToString("yyyy-MM-dd");
            string playTimes = Convert.ToDateTime(playTime).ToString("HH:mm:ss");
            string tings = dgv_dingdan.SelectedRows[0].Cells["Tings"].Value.ToString();
            tings = tings.Replace("号厅","");
            string sql = string.Format("update OrderInfo set TicketingState='退款成功' where D_ID='{0}'", dgv_dingdan.SelectedRows[0].Cells["D_ID"].Value.ToString()); 
            string cha = string.Format("select DY_Seat from MovieInfo where DY_Name='{0}' and DY_Releasetime='{1}'and DY_PlayTime ='{2}' and DY_Ting='{3}'", filName, fangYing, playTimes, tings);
            DataTable dt = DBHelper.GetDataTable(cha);
            string zuo = dt.Rows[0]["DY_Seat"].ToString();
            zuo = zuo.Replace(dgv_dingdan.SelectedRows[0].Cells["D_SeatInfo"].Value.ToString(), "");
            string set = string.Format("update MovieInfo set DY_Seat='{0}' where DY_Name='{1}' and DY_Releasetime='{2}'and DY_PlayTime ='{3}' and DY_Ting='{4}'", zuo, filName, fangYing, playTimes, tings);
            
            if (DBHelper.ExecuteNoneQuery(sql)&& DBHelper.ExecuteNoneQuery(set))
            {
                MessageBox.Show("受理成功");
                TicketToAccept_Load(null, null);
                return;
            }
            MessageBox.Show("受理失败");
        }

        private void dgv_dingdan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("select * from  OrderInfo where UserName like '%{0}%' or Ting like '%{0}%' or FileName like '%{0}%'", tb_dingd.Text);
                DataTable dt = DBHelper.GetDataTable(sql);
                if (tb_dingd.Text == "")
                {
                    MessageBox.Show("该订单信息不存在");
                    return;
                }
                if (dt.Rows.Count > 0)
                {
                    dgv_dingdan.DataSource = dt;
                    MessageBox.Show("查询成功");
                }
            }
            catch (Exception)
            {
                
            }
            
        }

        private void cms_JuJue_Click(object sender, EventArgs e)
        {
            string sql = string.Format("update OrderInfo set TicketingState = '退款失败' where D_ID = '{0}'", dgv_dingdan.SelectedRows[0].Cells["D_ID"].Value.ToString());
            try
            {
                if (DBHelper.ExecuteNoneQuery(sql))
                {
                    MessageBox.Show("执行成功");
                    return;
                }
                MessageBox.Show("执行失败");
            }
            catch (Exception)
            {
                MessageBox.Show("执行失败");
            }
        }
    }
}
