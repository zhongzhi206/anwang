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
    public partial class AdmInfozheng : Form
    {
        public AdmInfozheng()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (tb_name.Text==""||tb_pwd.Text=="")
            {
                MessageBox.Show("用户名密码不能为空！！");
                tb_name.Text = "";
                tb_pwd.Text = "";
                return;
            }
            if (tb_name.Text=="anwang"&&tb_pwd.Text=="anwang")
            {
                AdmInfo info = new AdmInfo();
                info.Show();
            }
            else
            {
                MessageBox.Show("你没有资格进入管理员维护！");
                tb_name.Text="";
                tb_pwd.Text = "";
            }
        }
    }
}
