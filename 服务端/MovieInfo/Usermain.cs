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
    public partial class Usermain : Form
    {
        public Usermain()
        {
            InitializeComponent();
        }

        private void tb_wen_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usermain_Load(object sender, EventArgs e)
        {

            string sql = "SELECT  dbo.UserInfo.* FROM    dbo.UserInfo";
            dgv_cha.DataSource = DBHelper.GetDataTable(sql);
        }

        private void btn_xin_Click(object sender, EventArgs e)
        {
            Usermain_Load(sender, e);
        }

        private void btn_cha_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("select * from UserInfo where YH_Name like '%{0}%' or YH_NiceName like'%{1}%' ", tb_wen.Text, tb_wen.Text);
                DataTable dt = DBHelper.GetDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    dgv_cha.DataSource = DBHelper.GetDataTable(sql);
                }
                else
                {
                    MessageBox.Show("查询不到该用户！");
                }
            }
            catch (Exception)
            {

            }

        }

        private void btn_jia_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_zhang.Text == "" || tb_mi.Text == "" || tb_cheng.Text == "")
                {
                    MessageBox.Show("请添加完整信息！！");
                }
                string sql = string.Format("insert UserInfo(YH_Name,YH_Pwd,YH_NiceName) values('{0}','{1}','{2}' )", tb_zhang.Text, tb_mi.Text, tb_cheng.Text);

                if (DBHelper.ExecuteNoneQuery(sql))
                {
                    Usermain_Load(sender, e);
                    MessageBox.Show("添加成功");
                }

                else
                {
                    MessageBox.Show("添加失败");
                }

            }
            catch (Exception)
            {

            }

        }

        private void btn_gai_Click(object sender, EventArgs e)
        {

            try
            {
                if (tb_zhang.Text == "" || tb_mi.Text == "" || tb_cheng.Text == "")
                {
                    MessageBox.Show("请添加完整信息！！");
                }

                string sql = string.Format("update UserInfo set YH_Name='{0}',YH_Pwd='{1}',YH_NiceName='{2}' where YH_ID='{3}'", tb_zhang.Text, tb_mi.Text, tb_cheng.Text, dgv_cha.SelectedRows[0].Cells["YH_ID"].Value.ToString());
                if (DBHelper.ExecuteNoneQuery(sql))
                {
                    MessageBox.Show("修改成功");
                    tb_zhang.Text = "";
                    tb_mi.Text = "";
                    tb_cheng.Text = "";
                    Usermain_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            catch (Exception)
            {

            }



        }

        private void tsmi_shan_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("delete UserInfo where YH_ID='{0}'", dgv_cha.SelectedRows[0].Cells["YH_ID"].Value.ToString());
                if (DBHelper.ExecuteNoneQuery(sql))
                {
                    MessageBox.Show("删除成功");
                    Usermain_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("删除成功");
                }
            }
            catch (Exception)
            {

            }

        }

        private void dgv_cha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_zhang.Text = dgv_cha.SelectedRows[0].Cells[1].Value.ToString();
            tb_mi.Text = dgv_cha.SelectedRows[0].Cells[2].Value.ToString();
            tb_cheng.Text = dgv_cha.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void dgv_cha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
