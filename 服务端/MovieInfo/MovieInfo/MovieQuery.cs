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
    public partial class MovieQuery : Form
    {
        public MovieQuery()
        {
            InitializeComponent();
        }

      

        private void Main_Load(object sender, EventArgs e)
        {
            string sql = "SELECT  dbo.MovieInfo.*, dbo.MovieType.* FROM dbo.MovieInfo INNER JOIN dbo.MovieType ON dbo.MovieInfo.DY_Type = dbo.MovieType.LX_ID";
            dgv_one.DataSource = DBHelper.GetDataTable(sql);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_Query_TextChanged(object sender, EventArgs e)
        {

        }

 

       
        private void dgv_one_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT i.*,t.* FROM dbo.MovieInfo i INNER JOIN dbo.MovieType t ON i.DY_Type = t.LX_ID where i.DY_Name like '%{0}%'", bt_Query.Text);
            DataTable dt = DBHelper.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                dgv_one.DataSource = dt;
                
            }
            else
            {
                    dgv_one.DataSource = "";
                    bt_Query.Text = "";
                    tb_three.Text = "";
                    tb_two.Text = "";
                MessageBox.Show(string.Format("没有该影片！"));
                
            }
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT i.*,t.* FROM dbo.MovieInfo i INNER JOIN dbo.MovieType t ON i.DY_Type = t.LX_ID where i.DY_Area like '%{0}%'", tb_two.Text);
            DataTable dt = DBHelper.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                dgv_one.DataSource = dt;
            }
            else
            {
                dgv_one.DataSource = "";
                bt_Query.Text = "";
                tb_three.Text = "";
                tb_two.Text = "";
                MessageBox.Show(string.Format("没有该区域影片！"));
               
            }
        }

        private void btn_tnree_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT i.*,t.* FROM dbo.MovieInfo i INNER JOIN dbo.MovieType t ON i.DY_Type = t.LX_ID  where t.LX_Type like '%{0}%'", tb_three.Text);
            DataTable dt = DBHelper.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                dgv_one.DataSource = dt;
            }
            else
            {    dgv_one.DataSource = "";
            bt_Query.Text = "";
            tb_three.Text = "";
            tb_two.Text = "";
                MessageBox.Show(string.Format("没有该类型影片！"));
                
            }
        }

        private void btn_chong_Click(object sender, EventArgs e)
        {
            bt_Query.Text = "";
            tb_three.Text = "";
            tb_two.Text = "";
            Main_Load(sender, e);
        }
    }
}
