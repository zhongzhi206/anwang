using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTicketSystem
{
    public partial class F_xiugai : Form
    {
        public F_xiugai()
        {
            InitializeComponent();
        }
        private static string userName=null;
        public F_xiugai(string str)
        {
            InitializeComponent();
            userName = str;
        }

        private void la_jiu_Click(object sender, EventArgs e)
        {

        }

        private void tb_jiu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_tuichu_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void btn_xiugai_Click(object sender, EventArgs e)
        {
            if (tb_mi.Text=="")
            {
                MessageBox.Show("密码不能为空");
                return;
            }
            if (tb_mi.Text.Length>18)
            {
                MessageBox.Show("密码不能超过18位");
                return;
            }
            if (tb_mi.Text.Length < 8)
            {
                MessageBox.Show("密码少于8位");
                return;
            }
            if (tb_mi.Text != tb_ma.Text)
            {
                MessageBox.Show("两次密码不一致。请重新输入");
                tb_ma.Text = "";
            }
            string mi = string.Format("select * from UserInfo where YH_Name='{0}'", userName);
            
            try
            {
                DataTable dt = DBHelper.GetDataTable(mi);
                if (tb_jiu.Text != dt.Rows[0]["YH_pwd"].ToString())
                {
                    MessageBox.Show("旧密码错误");
                    return;
                }
                string sql = string.Format("update UserInfo set YH_pwd='{0}' where YH_Name='{1}'", tb_ma.Text, userName);
                if (DBHelper.ExecuteNoneQuery(sql))
                {
                    MessageBox.Show("修改成功,下次登录生效");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("修改失败，密码含有非法字符");
            }
        }

        private void F_xiugai_Load(object sender, EventArgs e)
        {

        }
    }
}
