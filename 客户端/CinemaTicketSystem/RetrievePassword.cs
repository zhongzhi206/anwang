using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTicketSystem
{
    public partial class RetrievePassword : Form
    {
        public RetrievePassword()
        {
            InitializeComponent();
        }

        public string GetHtmlFromUrl(string url)
        {
            string strRet = null;
            if (url == null || url.Trim().ToString() == "")
            {
                return strRet;
            }
            string targeturl = url.Trim().ToString();
            try
            {
                HttpWebRequest hr = (HttpWebRequest)WebRequest.Create(targeturl);
                hr.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)";
                hr.Method = "GET";
                hr.Timeout = 30 * 60 * 1000;
                WebResponse hs = hr.GetResponse();
                Stream sr = hs.GetResponseStream();
                StreamReader ser = new StreamReader(sr, Encoding.Default);
                strRet = ser.ReadToEnd();
            }
            catch (Exception ex)
            {
                strRet = null;
            }
            return strRet;
        }
        private static string Code = null;

        private void btn_AuthCode_Click(object sender, EventArgs e)
        {
            if (tb_RegisterName.Text == "")
            {
                MessageBox.Show("请输入账户名");
                return;
            }
            if (tb_Phone.Text == "")
            {
                MessageBox.Show("请输入手机号码");
                return;
            }
            try
            {
                string sql = string.Format("select YH_Phone from UserInfo where YH_Name='{0}'", tb_RegisterName);
                DataTable dt = DBHelper.GetDataTable(sql);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("该手机号码未与该账户绑定");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("不能输入非法字符");
            }
            tb_AuthCode.Focus();
            btn_AuthCode.Click -= new EventHandler(btn_AuthCode_Click);
            int rand = new Random().Next(10000, 99999);
            Code = rand.ToString();
            string url = string.Format("http://utf8.api.smschinese.cn/?Uid=zhongzhi&Key=c8898147b3f02f4900a7&smsMob={0}&smsText=验证码:{1}", tb_Phone.Text, Code);
            string faCode = GetHtmlFromUrl(url);
            if (faCode == "-4")
            {
                MessageBox.Show("手机号码格式不正确");
                return;
            }
            tm_AuthCode.Start();
        }
        private static int index = 60;
        private void tm_AuthCode_Tick(object sender, EventArgs e)
        {
            if (index < 0)
            {
                btn_AuthCode.Text = "获取验证码";
                tm_AuthCode.Enabled = false;
                btn_AuthCode.BackColor = SystemColors.Highlight;
                btn_AuthCode.Click += new EventHandler(this.btn_AuthCode_Click);
                Code = null;
                index = 60;
                return;
            }
            btn_AuthCode.BackColor = Color.Silver;
            btn_AuthCode.Text = index.ToString();
            index--;
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (tb_RegisterName.Text == "")
            {
                MessageBox.Show("请输入账户名");
                return;
            }
            if (tb_Phone.Text == "")
            {
                MessageBox.Show("请输入手机号码");
                return;
            }
            try
            {
                string sql = string.Format("select YH_Phone from UserInfo where YH_Name='{0}'", tb_RegisterName);
                DataTable dt = DBHelper.GetDataTable(sql);
                if (dt.Rows.Count < 0)
                {
                    MessageBox.Show("该手机号码未与该账户绑定");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("不能输入非法字符");
            }
            if (tb_AuthCode.Text != Code)
            {
                MessageBox.Show("验证码错误");
                return;
            }
            panel1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_RegisterPwd.Text == "8--18个字符" || tb_ConfirmPwd.Text == "8--18个字符" || tb_RegisterPwd.Text == "" || tb_ConfirmPwd.Text == "")
            {
                MessageBox.Show("请输入密码");
                return;
            }

            if (tb_RegisterPwd.Text.Length < 8)
            {
                MessageBox.Show("密码不能少于8位");
                tb_RegisterPwd.Focus();
                return;
            }
            if (tb_ConfirmPwd.Text != tb_RegisterPwd.Text)
            {
                MessageBox.Show("两次密码不一致,请重新输入");
                tb_ConfirmPwd.Text = "";
                tb_ConfirmPwd.Focus();
                return;
            }

            string sql = string.Format("update UserInfo set YH_Pwd='{0}' where YH_Name='{1}'", tb_RegisterName,tb_ConfirmPwd.Text);
            try
            {
                if (DBHelper.ExecuteNoneQuery(sql))
                {
                    MessageBox.Show("修改成功");
                    return;
                }
                MessageBox.Show("修改失败");
            }
            catch (Exception)
            {
                MessageBox.Show("修改失败，不能含有非法字符");
            }

        }

        private void tb_RegisterPwd_MouseClick(object sender, MouseEventArgs e)
        {
            if (tb_RegisterPwd.Text == "8--18个字符")
            {
                tb_RegisterPwd.Text = "";
                tb_RegisterPwd.ForeColor = Color.Black;
                tb_RegisterPwd.PasswordChar = '*';
            }
        }

        private void tb_ConfirmPwd_MouseClick(object sender, MouseEventArgs e)
        {
            if (tb_ConfirmPwd.Text == "8--18个字符")
            {
                tb_ConfirmPwd.Text = "";
                tb_ConfirmPwd.ForeColor = Color.Black;
                tb_ConfirmPwd.PasswordChar = '*';
            }
        }
    }
}
