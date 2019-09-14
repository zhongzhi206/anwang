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
            string playTimes = Convert.ToDateTime(playTime).ToString("yyyy-MM-dd HH:mm:ss");
            string tings = dgv_dingdan.SelectedRows[0].Cells["Tings"].Value.ToString();
            string seats = dgv_dingdan.SelectedRows[0].Cells["D_SeatInfo"].Value.ToString();
            string sql = string.Format("update OrderInfo set TicketingState='退款成功' where D_ID='{0}'", dgv_dingdan.SelectedRows[0].Cells["D_ID"].Value.ToString()); 
            string cha = string.Format("select PP_Seat from FilmArrange where PP_Name='{0}' and PP_StartTime='{1}'and PP_Ting ='{2}'", filName, playTimes, tings);
            DataTable dt = DBHelper.GetDataTable(cha);
            string zuo = dt.Rows[0]["PP_Seat"].ToString();
            zuo = zuo.Replace(seats, "");
            string set = string.Format("update FilmArrange set PP_Seat='{0}' where PP_Name='{1}' and PP_StartTime='{2}'and PP_Ting ='{3}' ", zuo, filName, playTimes, tings);
            
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
                    TicketToAccept_Load(null, null);
                    return;
                }
                MessageBox.Show("执行失败");
            }
            catch (Exception)
            {
                MessageBox.Show("执行失败");
            }
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketToAccept_Load(null,null);
        }
    }
}
