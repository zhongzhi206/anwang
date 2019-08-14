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
    public partial class NewMain : Form
    {
        public NewMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void NewMain_Load(object sender, EventArgs e)
        {
            string sql = "select * from NewInfo";
            dgv_one.DataSource = DBHelper.GetDataTable(sql);
        }
        private void btn_geng_Click(object sender, EventArgs e)
        {
            NewMain_Load(sender, e);
        }

        private void btn_jia_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_wen.Text == "" || tb_name.Text == "")
                {
                    MessageBox.Show("请填写完整信息！");
                }
                string sql = string.Format("insert NewInfo(XW_name,XW_title) values('{0}','{1}')  ", tb_name.Text, tb_wen.Text);

                if (DBHelper.ExecuteNoneQuery(sql))
                {
                    MessageBox.Show("添加成功");
                    NewMain_Load(sender, e);
                    tb_wen.Text = "";
                    tb_name.Text = "";
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
                if (tb_wen.Text == "" || tb_name.Text == "")
                {
                    MessageBox.Show("请填写完整信息！");
                }
                string sql = string.Format("update NewInfo set XW_name='{0}',XW_title='{1}' where XW_ID='{2}'", tb_name.Text, tb_wen.Text, dgv_one.SelectedRows[0].Cells["ID"].Value.ToString());
                if (DBHelper.ExecuteNoneQuery(sql))
                {
                    MessageBox.Show("修改成功");
                    NewMain_Load(sender, e);
                    tb_wen.Text = "";
                    tb_name.Text = "";
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

        private void dgv_one_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_name.Text = dgv_one.SelectedRows[0].Cells[1].Value.ToString();
            tb_wen.Text = dgv_one.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void tsmi_shan_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("delete NewInfo where XW_ID='{0}'", dgv_one.SelectedRows[0].Cells["ID"].Value.ToString());
                if (DBHelper.ExecuteNoneQuery(sql))
                {
                    MessageBox.Show("删除成功");
                    NewMain_Load(sender, e);

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
    }
}
