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
    public partial class Movielogin : Form
    {
        public Movielogin()
        {
            InitializeComponent();
        }

        private void pl_Register_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_name.Text == "" || tb_pwd.Text == "")
                {
                    tb_name.Text = "";
                    tb_pwd.Text = "";
                    MessageBox.Show("请输入用户名及密码！");
                    return;
                }
                string name = tb_name.Text;
                string pwd = tb_pwd.Text;
                string sql = string.Format("select * from AdmInfo where name='{0}' and pwd='{1}' ", name.Trim(), pwd.Trim());
                DataTable dt = DBHelper.GetDataTable(sql);

                if (dt.Rows.Count > 0)
                {
                    MovieMain main = new MovieMain();
                    main.Show();
                    Hide();

                }
                else
                {
                    tb_name.Text = "";
                    tb_pwd.Text = "";
                    MessageBox.Show("用户名密码不正确");
                }
            }
            catch (Exception)
            {

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
