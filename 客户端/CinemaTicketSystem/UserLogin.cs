using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Runtime.InteropServices;

namespace CinemaTicketSystem
{
    public partial class UserLogin : AlphaForm
    {

        public UserLogin()
        {
            InitializeComponent();
            
        }
        public static string name = null;
        private void lb_UserRegister_Click(object sender, EventArgs e)
        {
            cb_UserName.Text = "";
            tb_UserPwd.Text = "";
            pl_Register.Visible = true;
            Text = "新用户注册";
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            pl_Register.Visible = false;
            Text = "用户登录";
        }

        private void lb_GoLogin_Click(object sender, EventArgs e)
        {
            tb_RegisterName.Leave -= new EventHandler(this.tb_RegisterName_Leave);
            Text = "用户登录";
            pl_Register.Visible = false;
            cb_UserName.Focus();
        }

        private void tb_RegisterName_TextChanged(object sender, EventArgs e)
        {
            if (tb_RegisterName.Text.Length>18)
            {
                tb_RegisterName.Text = tb_RegisterName.Text.Substring(0, 18);
                MessageBox.Show("账户不能超过18位");
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tb_RegisterName.Text.Length; i++)
            {
                char cha = tb_RegisterName.Text[i];
                if (!(((cha >= 'a' && cha <= 'z') || (cha >= 'A' && cha <= 'Z') || (cha >= '0' & cha <= '9'))))
                {
                    MessageBox.Show("用户名只能是字母或数字组成");
                    tb_RegisterName.Focus();
                    return;
                }
            }
            if (tb_RegisterPwd.Text== "8--18个字符"|| tb_ConfirmPwd.Text== "8--18个字符"|| tb_RegisterPwd.Text==""|| tb_ConfirmPwd.Text=="")
            {
                MessageBox.Show("请输入密码");
                return;
            }
            //判断用户是否被注册
            try
            {
                string sql = "select YH_Name from UserInfo";
                SqlDataReader reader = DBHelper.GetDataReader(sql);
                while (reader.Read())
                {
                    if (reader["YH_Name"].ToString() == tb_RegisterName.Text)
                    {
                        MessageBox.Show("该用户已被注册");
                        reader.Close();
                        return;
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            if (tb_RegisterName.Text.Length<6)
            {
                MessageBox.Show("用户名不能少于6位");
                tb_RegisterName.Focus();
                return;
            }
            if (tb_RegisterPwd.Text.Length < 8)
            {
                MessageBox.Show("密码不能少于8位");
                tb_RegisterPwd.Focus();
                return;
            }
            if (tb_ConfirmPwd.Text!=tb_RegisterPwd.Text)
            {
                MessageBox.Show("两次密码不一致,请重新输入");
                tb_ConfirmPwd.Text = "";
                tb_ConfirmPwd.Focus();
                return;
            }
            if (tb_AuthCode.Text!=Code)
            {
                MessageBox.Show("验证码错误");
                return;
            }
            //注册新用户
            
            try
            {
                string sql2 = string.Format("insert UserInfo values('{0}','{1}','',getdate(),'','{2}','0')", tb_RegisterName.Text, tb_ConfirmPwd.Text,tb_Phone.Text);
                if (DBHelper.ExecuteNoneQuery(sql2))
                {
                    DialogResult rel = MessageBox.Show("注册成功，是否去登录？", "注册成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    if (rel == DialogResult.OK)
                    {
                        tb_RegisterName.Text = "";
                        tb_ConfirmPwd.Text = "";
                        tb_RegisterPwd.Text = "";
                        tb_AuthCode.Text = "";
                        Code = null;
                        lb_GoLogin_Click(null, null);
                    }
                    return;
                }
                MessageBox.Show("注册失败");
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("注册失败，密码含有非法字符");
            }
        }
        private void tb_RegisterName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar == (char)Keys.Enter)|| e.KeyChar == (char)Keys.Tab)
            {
                for (int i = 0; i < tb_RegisterName.Text.Length; i++)
                {
                    char cha = tb_RegisterName.Text[i];
                    if (!((((cha >= 'a' && cha <= 'z') || (cha >= 'A' && cha <= 'Z')) || (cha >= '0' && cha <= '9'))))
                    {
                        MessageBox.Show("只能是英文数字");
                        tb_RegisterName.Focus();
                        return;
                    }
                }
                if (tb_RegisterName.Text.Length < 6)
                {
                    MessageBox.Show("用户名不能少于6位");
                    tb_RegisterName.Focus();
                    return;
                }
                try
                {
                    string sql = string.Format("select YH_Name from UserInfo where YH_Name='{0}'", tb_RegisterName.Text);
                    DataTable dt = DBHelper.GetDataTable(sql);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("该用户已被注册");
                        return;
                    }
                }
                catch (Exception)
                {
                }
                if (tb_RegisterPwd.Text == "8--18个字符")
                {
                    tb_RegisterPwd.Text = "";
                    tb_RegisterPwd.ForeColor = Color.Black;
                    tb_RegisterPwd.PasswordChar = '*';
                }
                SendKeys.Send("{tab}");
            }
        }

        private void tb_RegisterPwd_TextChanged(object sender, EventArgs e)
        {
            if (tb_RegisterPwd.Text.Length>18)
            {
                MessageBox.Show("密码不能超过18位");
                tb_RegisterPwd.Text = tb_RegisterPwd.Text.Substring(0,18);
            }
        }

        private void tb_RegisterPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) || e.KeyChar == (char)Keys.Tab)
            {
                SendKeys.Send("{tab}");
                if (tb_RegisterPwd.Text.Length<8)
                {
                    MessageBox.Show("密码不能少于8位");
                    tb_RegisterPwd.Focus();
                    return;
                }
                if (tb_ConfirmPwd.Text == "8--18个字符")
                {
                    tb_ConfirmPwd.Text = "";
                    tb_ConfirmPwd.ForeColor = Color.Black;
                    tb_ConfirmPwd.PasswordChar = '*';
                }
            }
        }

        private void cb_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void tb_UserPwd_KeyDown(object sender, KeyEventArgs e)
        {
            //在keyDown事件下，按下回车键触发按钮单击事件
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键
            {
                btn_Login_Click(sender, e);//触发button事件
            }
        }
        [DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        //下面是可用的常量，根据不同的动画效果声明自己需要的
        private const int AW_HOR_POSITIVE = 0x0001;//自左向右显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志
        private const int AW_HOR_NEGATIVE = 0x0002;//自右向左显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志
        private const int AW_VER_POSITIVE = 0x0004;//自顶向下显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志
        private const int AW_VER_NEGATIVE = 0x0008;//自下向上显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志该标志
        private const int AW_CENTER = 0x0010;//若使用了AW_HIDE标志，则使窗口向内重叠；否则向外扩展
        private const int AW_HIDE = 0x10000;//隐藏窗口
        private const int AW_ACTIVE = 0x20000;//激活窗口，在使用了AW_HIDE标志后不要使用这个标志
        private const int AW_SLIDE = 0x40000;//使用滑动类型动画效果，默认为滚动动画类型，当使用AW_CENTER标志时，这个标志就被忽略
        private const int AW_BLEND = 0x80000;//使用淡入淡出效果
        private static int loginForbidden = 1;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (loginForbidden > 5)
            {
                tm_LoginForbidden.Start();
                MessageBox.Show(string.Format("账户密码输入错误次数过多，请于{0}秒后重试", forbidden.ToString()),"提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            try
            {
                string sql = string.Format("select YH_Name,YH_Pwd from UserInfo where YH_Name='{0}' and YH_Pwd='{1}'", cb_UserName.Text, tb_UserPwd.Text);
                DataTable dt = DBHelper.GetDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["YH_Name"].ToString() == cb_UserName.Text && dt.Rows[0]["YH_Pwd"].ToString() == tb_UserPwd.Text)
                    {
                        MessageBox.Show("登录成功");
                        AnimateWindow(this.Handle, 1000, AW_HOR_POSITIVE);
                        MainForm main = new MainForm(cb_UserName.Text);
                        main = (MainForm)Owner;
                        main.ShuaXin(sender, e);
                        Close();
                        return;
                    }
                    loginForbidden++;
                    MessageBox.Show("账户或密码错误");
                    tb_UserPwd.Text = "";
                }
                else
                {
                    loginForbidden++;
                    MessageBox.Show("账户或密码错误");
                    tb_UserPwd.Text = "";
                }
            }
            catch (Exception)
            {
                loginForbidden++;
                MessageBox.Show("登录失败");
            }
        }

        private void tb_RegisterName_Leave(object sender, EventArgs e)
        {
            if (tb_RegisterName.Text=="")
            {
                tb_RegisterName.Text = "6--18位数字或字母";
                tb_RegisterName.ForeColor = Color.Silver;
            }
            for (int i = 0; i < tb_RegisterName.Text.Length; i++)
            {
                char cha = tb_RegisterName.Text[i];
                if (!(((cha >= 'a' && cha <= 'z') || (cha >= 'A' && cha <= 'Z') || (cha >= '0' && cha <= '9'))))
                {
                    MessageBox.Show("用户名只能包含字母或数字");
                    tb_RegisterName.Focus();
                    return;
                }
            }
            if (tb_RegisterName.Text.Length < 6)
            {
                MessageBox.Show("用户名不能少于6位");
                tb_RegisterName.Focus();
                return;
            }
            try
            {
                string sql = string.Format("select YH_Name from UserInfo where YH_Name='{0}'", tb_RegisterName.Text);
                DataTable dt = DBHelper.GetDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("该用户已被注册");
                    tb_RegisterName.Focus();
                }
            }
            catch (Exception)
            {
                
            }
        }
        

        private void tb_RegisterPwd_Leave(object sender, EventArgs e)
        {
            if (tb_RegisterPwd.Text=="")
            {
                tb_RegisterPwd.Text = "8--18个字符";
                tb_RegisterPwd.PasswordChar = new char();
                tb_RegisterPwd.ForeColor = Color.Silver;
                return;
            }
            if (tb_RegisterPwd.Text == "8--18个字符")
            {
                tb_RegisterPwd.PasswordChar = new char();
            }
        }


        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
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

        private static string Code=null;
        private void btn_AuthCode_Click(object sender, EventArgs e)
        {
            if (tb_Phone.Text == "")
            {
                MessageBox.Show("请输入手机号码");
                return;
            }
            try
            {
                string phone = string.Format("select YH_Phone from UserInfo where YH_Phone='{0}'", tb_Phone.Text);
                DataTable dt = DBHelper.GetDataTable(phone);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("该手机号码已被注册");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("手机号码格式错误");
                return;
            }
            tb_AuthCode.Focus();
            btn_AuthCode.Click -= new EventHandler(btn_AuthCode_Click);
            int rand = new Random().Next(10000, 99999);
            Code = rand.ToString();
            string url = string.Format("http://utf8.api.smschinese.cn/?Uid=zhongzhi&Key=c8898147b3f02f4900a7&smsMob={0}&smsText=验证码:{1}",tb_Phone.Text, Code);
            string faCode = GetHtmlFromUrl(url);
            if (faCode== "-4")
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

        private void tb_AuthCode_KeyDown(object sender, KeyEventArgs e)
        {
            //在keyDown事件下，按下回车键触发按钮单击事件
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键
            {
                this.btn_Register_Click(sender, e);//触发button事件
            }
        }

        private void tb_ConfirmPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) || e.KeyChar == (char)Keys.Tab)
            {
                if (tb_ConfirmPwd.Text != tb_RegisterPwd.Text)
                {
                    MessageBox.Show("两次密码不一致,请重新输入");
                    tb_ConfirmPwd.Text = "";
                    tb_ConfirmPwd.Focus();
                    return;
                }
            }
        }

        private int forbidden = 60;
        private void tm_LoginForbidden_Tick(object sender, EventArgs e)
        {
            forbidden--;
            if (forbidden<0)
            {
                forbidden = 60;
                loginForbidden = 0;
                tm_LoginForbidden.Enabled=false;
                return;
            }
        }

        private void UserLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void tb_RegisterName_MouseClick(object sender, MouseEventArgs e)
        {
            if (tb_RegisterName.Text== "6--18位数字或字母")
            {
                tb_RegisterName.Text = "";
                tb_RegisterName.ForeColor = Color.Black;
            }
        }

        private void tb_RegisterPwd_MouseClick(object sender, MouseEventArgs e)
        {
            if (tb_RegisterPwd.Text== "8--18个字符")
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

        private void tb_ConfirmPwd_Leave(object sender, EventArgs e)
        {
            if (tb_ConfirmPwd.Text=="")
            {
                tb_ConfirmPwd.Text = "8--18个字符";
                tb_ConfirmPwd.PasswordChar = new char();
                tb_ConfirmPwd.ForeColor = Color.Silver;
            }
            if (tb_ConfirmPwd.Text == "8--18个字符")
            {
                tb_ConfirmPwd.PasswordChar = new char();
            }
        }

        private void tb_ConfirmPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_AuthCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            RetrievePassword wanji = new RetrievePassword();
            wanji.ShowDialog();
        }

        private void tb_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pl_Register_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pl_Login_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
