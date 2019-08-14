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
    public partial class SeatMain : Form
    {
        public SeatMain()
        {
            InitializeComponent();
        }

        private void SeatMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_geng_Click(object sender, EventArgs e)
        {
            SeatMain_Load(sender, e);
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from    dbo.YingTing where YT_Name like '%{0}%' or YT_date like'%{1}%'",tb_cha.Text,tb_cha.Text);
            DataTable dt = DBHelper.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                dgv_one.DataSource = DBHelper.GetDataTable(sql);
            }
            else
            {
                MessageBox.Show("查询不到该影厅！");
            }
        }

        private void btn_jia_Click(object sender, EventArgs e)
        {
             if (tb_one.Text == "" || tb_two.Text == "" || tb_three.Text == "")
             {
                MessageBox.Show("添加的影厅数据不能为空！");
             }

             string sql = string.Format("insert YingTing values('{0}','{1}','{2}','{3}')", tb_one.Text, tb_two.Text, tb_three.Text, tb_Describe.Text);
             if (DBHelper.ExecuteNoneQuery(sql))
             {
                MessageBox.Show("添加成功！");
                tb_one.Text = "";
                tb_two.Text = "";
                tb_three.Text = "";
                tb_Describe.Text = "";
                SeatMain_Load(sender, e);
             }
             else
             {
                 MessageBox.Show("添加失败!");
             }
        }

        private void dgv_one_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_one.Text = dgv_one.SelectedRows[0].Cells[1].Value.ToString();
            tb_two.Text = dgv_one.SelectedRows[0].Cells[2].Value.ToString();
            tb_three.Text = dgv_one.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_one.Text == "" || tb_two.Text == "" || tb_three.Text == "")
            {
                MessageBox.Show("修改的影厅数据不能为空！");
            }
            string sql = string.Format("update YingTing set YT_Name='{0}',YT_Row='{1}',YT_Col='{2}',YT_Describe='{3}' where YT_ID='{4}'", tb_one.Text, tb_two.Text, tb_three.Text, tb_Describe.Text, dgv_one.SelectedRows[0].Cells["ID"].Value.ToString());
            if (DBHelper.ExecuteNoneQuery(sql))
            {
                MessageBox.Show("修改成功");
                tb_one.Text = "";
                tb_Describe.Text = "";
                tb_two.Text = "";
                tb_three.Text = "";
                SeatMain_Load(sender, e);
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete YingTing where YT_ID='{0}'", dgv_one.SelectedRows[0].Cells["ID"].Value.ToString());
            if (DBHelper.ExecuteNoneQuery(sql))
            {
                MessageBox.Show("删除成功");
                tb_one.Text = "";
                tb_two.Text = "";
                tb_three.Text = "";
                SeatMain_Load(sender, e);
            }
            else
            {
                MessageBox.Show("删除成功");
            }
        }

        private void tb_two_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.'|| e.KeyChar == '-'|| e.KeyChar == ',')
                e.Handled = true;
        }

        private void tb_three_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == ',')
                e.Handled = true;
        }
    }
}
