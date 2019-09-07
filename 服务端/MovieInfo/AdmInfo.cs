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
    public partial class AdmInfo : Form
    {
        public AdmInfo()
        {
            InitializeComponent();
        }

        private void AdmInfo_Load(object sender, EventArgs e)
        {

            string sql = string.Format("SELECT * FROM dbo.AdmInfo");
            dvg_one.DataSource = DBHelper.GetDataTable(sql);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_zhiwu.Text == "" || tb_pwd.Text == "" || tb_name.Text == "")
                {
                    MessageBox.Show("修改的管理员数据不能为空！");
                }

                string sql = string.Format("update  AdmInfo set Name='{0}',Pwd='{1}',Zhiwu='{2}' where ID='{3}'", tb_name.Text, tb_pwd.Text, tb_zhiwu.Text, dvg_one.SelectedRows[0].Cells["ID"].Value.ToString());
                if (DBHelper.ExecuteNoneQuery(sql))
                {
                    MessageBox.Show("修改成功！");
                    tb_zhiwu.Text = "";
                    tb_pwd.Text = "";
                    tb_name.Text = "";
                    AdmInfo_Load(sender, e);
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_zhiwu.Text == "" || tb_pwd.Text == "" || tb_name.Text == "")
                {
                    MessageBox.Show("添加的管理员数据不能为空！");
                }
                string sql = string.Format("insert AdmInfo(Name,Pwd,Zhiwu) values('{0}','{1}','{2}')", tb_name.Text, tb_pwd.Text, tb_zhiwu.Text);
                if (DBHelper.ExecuteNoneQuery(sql))
                {
                    MessageBox.Show("添加成功！");
                    tb_name.Text = "";
                    tb_pwd.Text = "";
                    tb_zhiwu.Text = "";
                    AdmInfo_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
            catch (Exception)
            {

            }

        }

        private void dvg_one_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_zhiwu.Text = dvg_one.SelectedRows[0].Cells[3].Value.ToString();
                tb_name.Text = dvg_one.SelectedRows[0].Cells[1].Value.ToString();
                tb_pwd.Text = dvg_one.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception)
            {

            }


        }

        private void but_shan_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("delete AdmInfo where ID='{0}'", dvg_one.SelectedRows[0].Cells["ID"].Value.ToString());
                if (DBHelper.ExecuteNoneQuery(sql))
                {
                    MessageBox.Show("删除成功");
                    tb_name.Text = "";
                    tb_pwd.Text = "";
                    tb_zhiwu.Text = "";
                    AdmInfo_Load(sender, e);
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
