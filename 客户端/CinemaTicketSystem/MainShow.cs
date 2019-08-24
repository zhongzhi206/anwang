using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTicketSystem
{
    public partial class MainForm : winFormEX
    {
        private void FanKui()
        {
            try
            {
                string sql = "select top 10 NeRong,UserNiCheng from Feedback order by ID desc";
                DataTable dt = DBHelper.GetDataTable(sql);
                dgv_FamKui.DataSource = dt;
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// 热门影片显示
        /// </summary>
        public void HotFile()
        {
            lv_HotFilm.Clear();
            try
            {
                string sql = "select  top 6 PP_Name  from FilmArrange group by DY_Name";
                DataTable dt = DBHelper.GetDataTable(sql);
                ImageList imageList = new ImageList();
                imageList.ImageSize = new Size(1, 35);
                lv_HotFilm.SmallImageList = imageList;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = string.Format("{0}  " + dt.Rows[i]["PP_Name"].ToString(), (i + 1).ToString());
                    item.ImageIndex = i;
                    lv_HotFilm.Items.Add(item);
                }
            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// 影片展示方法
        /// </summary>
        /// 
        ImageList list = new ImageList();
        ListViewItem lvi = new ListViewItem();
        private void FlimeShow()
        {
            list.ImageSize = new Size(120, 160);
            DirectoryInfo info = new DirectoryInfo(@"..\..\..\..\项目图片/电影海报");
            string path;
            FileInfo fileInfo = new FileInfo(@"..\..\..\..\项目图片/电影海报");
            foreach (FileInfo f in info.GetFiles("*.jpg"))
            {
                string str = f.Name;
                path = string.Concat(@"..\..\..\..\项目图片/电影海报/", str);
                str = str.Replace(".jpg", "");
                list.Images.Add(str, Image.FromFile(path));
            }
            string sql = "select distinct PP_Name from FilmArrange";
            //绑定视图imagelist
            lv_FlimShow.LargeImageList = list;
            Seach(sql);
        }
        #region 鼠标移动操作
        //该函数从当前线程中窗口释放鼠标捕获
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //发送消息移动窗体
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;    //向窗口发送消息
        public const int SC_MOVE = 0xF010;          //向窗口发送移动的消息
        public const int HTCAPTION = 0x0002;
        
        #endregion
        public MainForm()
        {
            InitializeComponent();
            button30.BackColor = SystemColors.Highlight;
            button30.ForeColor = Color.White;
        }

        /// <summary>
        /// 导航栏
        /// </summary>
        public void Men(Color color)
        {
            foreach (Control item in pl_Type.Controls)
            {
                if (item is Button)
                {
                    btn_Query.BackColor = color;
                    Button TyBtn = item as Button;
                    if (TyBtn.BackColor != Color.Transparent)
                    {
                        TyBtn.BackColor = color;
                        TyBtn.ForeColor = Color.White;
                    }
                    TyBtn.Click += Typ_BtnClick;
                }
            }
        }

        private void TypClickColor(object sender, EventArgs e,Color color)
        {
            foreach (Control control in pl_Type.Controls)
            {
                if (control is Button)
                {
                    Button typBtn = control as Button;
                    typBtn.BackColor = Color.Transparent;
                    typBtn.ForeColor = Color.Black;
                }
            }
            typClickBtn = sender as Button;
            typClickBtn.BackColor = color;
            typClickBtn.ForeColor = Color.White;
            string sql = string.Format("SELECT  PP_Name FROM FilmArrange JOIN dbo.MovieInfo ON dbo.FilmArrange.PP_Name = dbo.MovieInfo.DY_Name where DY_Type='{0}' or DY_Area='{1}' group by PP_Name", typClickBtn.Text, typClickBtn.Text);
            if (typClickBtn.Text == "全部")
            {
                sql = string.Format("select distinct PP_Name from FilmArrange");
            }
            Seach(sql);
        }

        /// <summary>
        /// 影片查询公共方法
        /// </summary>
        /// <param name="sql"></param>
        public void Seach(string sql)
        {
            try
            {
                DataTable dt = DBHelper.GetDataTable(sql);
                lv_FlimShow.Clear();
                if (dt.Rows.Count == 0)
                {
                    pictureBox2.Image = Image.FromFile(@"..\..\..\..\项目图片/icon/什么都没有.png");
                    pictureBox2.Visible = true;
                    label8.Visible = false;
                    return;
                }
                label8.Visible = true;
                pictureBox2.Visible = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lvi = new ListViewItem();
                    lvi.Text = Convert.ToString(dt.Rows[i]["PP_Name"]);
                    for (int j = 0; j < list.Images.Count; j++)
                    {
                        if (lvi.Text == list.Images.Keys[j])
                        {
                            lvi.ImageKey = list.Images.Keys[j];
                            break;
                        }
                    }
                    lv_FlimShow.Items.Add(lvi);
                }
            }
            catch (Exception)
            {
                
            }
            
        }
        Button typClickBtn = new Button();
        
        /// <summary>
        /// 标签类型按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Typ_BtnClick(object sender, EventArgs e)
        {
            TypClickColor(sender,e, pl_Top.BackColor);
        }
        UserLogin login = null;
        public static string UserName = null; 
        public MainForm(string str)
        {
            InitializeComponent();
            UserName = str;
        }

        /// <summary>
        /// 刷新窗体的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ShuaXin(object sender, EventArgs e)
        {
            if (UserName != null)
            {
                try
                {
                    string sql2 = string.Format("select sum(SumPrice) from OrderInfo where UserName='{0}'", UserName);
                    if (Convert.ToDouble(DBHelper.ExecuteScalar(sql2)) >= 200)
                    {
                        label36.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                }

                tb_UserOrder.Parent = tabControl1;
                tp_UserInfor.Parent = tabControl1;
                try
                {
                    string sql = string.Format("select * from UserInfo where YH_Name='{0}'", UserName);
                    DataTable dt = DBHelper.GetDataTable(sql);
                    if (dt.Rows[0]["YH_VIP"].ToString()=="1")
                    {
                        label36.Visible = true;
                    }
                    tb_NiceName.Text = dt.Rows[0]["YH_NiceName"].ToString();
                    tb_Registration.Text = dt.Rows[0]["YH_Registration"].ToString();
                    tb_name.Text = UserName;
                    if (dt.Rows.Count > 0)
                    {
                        cb_Sex.Text= dt.Rows[0]["YH_Sex"].ToString();
                        DirectoryInfo info = new DirectoryInfo(@"..\..\..\..\项目图片/用户头像");
                        string path;
                        FileInfo fileInfo = new FileInfo(@"..\..\..\..\项目图片/用户头像");
                        foreach (FileInfo f in info.GetFiles("*.jpg"))
                        {
                            string str = f.Name;
                            path = string.Concat(@"..\..\..\..\项目图片/用户头像/", str);
                            str = str.Replace(".jpg", "");
                            if (UserName == str)
                            {
                                 Images(path, pictureBox4);
                                break;
                            }
                            else
                            {
                                pictureBox4.Image = Image.FromFile(@"D:\桌面\百亿项目\项目图片\icon\登录.png");
                            }
                        }
                        if (dt.Rows[0]["YH_NiceName"].ToString() == "")
                        {
                            lb_Login.Text = "用户：" + UserName;
                            return;
                        }
                        lb_Login.Text = "用户：" + dt.Rows[0]["YH_NiceName"].ToString();
                    }
                }
                catch (Exception)
                {
                }
            }
        }
        /// <summary>
        /// 用户订单信息与账户信息模块模块
        /// </summary>
        private void UserInfor()
        {

            try
            {
                string sql = string.Format("select * from OrderInfo where UserName='{0}' order by D_ID desc", UserName);
                DataTable dt= DBHelper.GetDataTable(sql);
                if (dt.Rows.Count>0)
                {
                    dgv_dingdan.DataSource = DBHelper.GetDataTable(sql);
                    pictureBox10.Visible = false;
                    return;
                }
                else
                {
                    
                }
                

            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox8.Image = Image.FromFile(@"..\..\..\..\项目图片/icon/0.png");
                pictureBox9.Image = Image.FromFile(@"..\..\..\..\项目图片/icon/3.png");
            }
            catch (Exception)
            {
                pictureBox8.Image = null;
                pictureBox9.Image = null;
            }
            UserInfor();
            HotFile();
            tm_Hot.Start();
            Men(pl_Top.BackColor);
            //设置当窗体启动时，搜索框自动获取焦点
            btn_Query.Focus();
            FlimeShow();
            //设置tabcontrol控件的订单信息与账户资料以及票务选择选项卡不可见
            tb_UserOrder.Parent = null;
            tp_UserInfor.Parent = null;
            tb_Seats.Parent = null;
            TreeFilemShow();
            FanKui();
        }
        

        private void lb_Login_Click_1(object sender, EventArgs e)
        {
            if (UserName==null)
            {
                login = new UserLogin();
                login.Owner = this;
                login.ShowDialog();
                UserInfor();
                return;
            }
            else
            {
                DialogResult rel= MessageBox.Show("是否退出登录？","系统提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                if (rel==DialogResult.OK)
                {
                    //退出登录后，重置所有关于用户信息的控件
                    UserName = null;
                    pictureBox4.Image= Image.FromFile(@"..\..\..\..\项目图片/icon/登录.png");
                    lb_Login.Text = "未登录";
                    //设置tabcontrol控件的订单信息与账户资料选项卡不可见
                    tb_UserOrder.Parent = null;
                    tp_UserInfor.Parent = null;
                    label36.Visible = false;
                    SeatShua();
                    tb_Seats.Controls.Clear();
                    Seat();
                }
            }
            
        }
        

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pl_Top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tb_UsrFeedback_Leave(object sender, EventArgs e)
        {
            if (tb_UsrFeedback.Text == "")
            {
                tb_UsrFeedback.ForeColor = SystemColors.ControlDark;
                tb_UsrFeedback.Text = "10—400个字符";
            }
            tm_ZiFu.Enabled = false;
        }

        private void tb_UsrFeedback_MouseClick(object sender, MouseEventArgs e)
        {
            if (tb_UsrFeedback.Text == "10—400个字符")
            {
                tb_UsrFeedback.ForeColor = Color.Black;
                tb_UsrFeedback.Text = "";
            }
        }

        /// <summary>
        /// 用户反馈模块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_UsrFeedback_Click(object sender, EventArgs e)
        {
            if (tb_UsrFeedback.Text.Trim().Length<10)
            {
                MessageBox.Show("内容不能少于10个字符");
                return;
            }
            try
            {
                string sql = string.Format("insert Feedback values('{0}','匿名用户')", tb_UsrFeedback.Text);
                if(UserName!=null)
                    sql = string.Format("insert Feedback values('{0}','{1}')", tb_UsrFeedback.Text, lb_Login.Text.Replace("用户：",""));
                if (DBHelper.ExecuteNoneQuery(sql))
                {
                    MessageBox.Show("提交成功，谢谢您的反馈");
                    btn_UsrFeedback.Click -= new EventHandler(this.btn_UsrFeedback_Click);
                    tm_Dao.Start();
                    if (tm_Dao.Enabled == true)
                    {
                        btn_UsrFeedback.BackColor = Color.Silver;
                        btn_UsrFeedback.Text = "30s";
                    }
                    FanKui();
                    return;
                }
                MessageBox.Show("提交失败");
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("提交失败，原因{0}", ex.Message));
                return;
            }
            
        }

        private void tb_UsrFeedback_TextChanged(object sender, EventArgs e)
        {
            if (tb_UsrFeedback.Text.Length > 400)
            {
                tb_UsrFeedback.Text = tb_UsrFeedback.Text.Substring(0,400);
                MessageBox.Show("内容不能超过400个字符","系统提醒您:",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            tm_ZiFu.Start();
            return;
        }
        
        private void btn_Query_Click(object sender, EventArgs e)
        {
            if (cb_Query.Text=="")
            {
                lv_FlimShow.Clear();
                FlimeShow();
                Men(pl_Top.BackColor);
                return;
            }
            string sql = string.Format("select PP_Name from FilmArrange fa, MovieInfo mi where fa.PP_Name like'%{0}%' or mi.DY_Director like'%{0}%' or mi.DY_Type like'%{0}%' or mi.DY_Area like'%{0}%'   group by PP_Name", cb_Query.Text);
            Seach(sql);
        }

        private void cb_Query_KeyDown(object sender, KeyEventArgs e)
        {
            //在keyDown事件下，按下回车键触发按钮单击事件
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.btn_Query_Click(sender, e);//触发button事件  
            }
        }
        
        public static int dao = 0;
        private void tm_Dao_Tick(object sender, EventArgs e)
        {
            dao=int.Parse(btn_UsrFeedback.Text.Replace("s",""));
            dao = dao - 1;
            btn_UsrFeedback.Text = dao.ToString()+"s";
            if (dao<0)
            {
                tm_Dao.Stop();
                btn_UsrFeedback.BackColor = SystemColors.HotTrack;
                btn_UsrFeedback.Text = "提交";
                btn_UsrFeedback.Click += new EventHandler(this.btn_UsrFeedback_Click);
            }
        }
        
        private void tsm_ShuaXin_Click(object sender, EventArgs e)
        {
            lv_FlimShow.Clear();
            TreeFilemShow();
            FlimeShow();
            Men(pl_Top.BackColor);
        }

        public static int num=0;
        private void tm_ZiFu_Tick(object sender, EventArgs e)
        {
            num = tb_UsrFeedback.Text.Trim().Replace("\n","").Length;
            label5.Text = num.ToString();
            tb_UsrFeedback_TextChanged(sender,e);
        }
        
        public void Skin(Color color)
        {
            btn_queding.BackColor = color;
            btn_xiugai.BackColor = color;
            btn_TouXiang.BackColor = color;
            pl_Top.BackColor = color;
            bt_one.BackColor = color;
            Men(pl_Top.BackColor);
            btn_Pay.BackColor = color;
            btn_UsrFeedback.BackColor = color;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            SkinForm skin = new SkinForm();
            skin.Owner = this;
            skin.ShowDialog();
        }

        private void tm_Hot_Tick(object sender, EventArgs e)
        {
            HotFile();
        }
        

        /// <summary>
        /// 显示电影场次信息
        /// </summary>
        /// <param name="filmName"></param>
        TreeNode treeRoot = null;
        TreeNode dyTime = null;
        TreeNode dyDate = null;
        TreeNode dyTing = null;
        private void TreeFilemShow()
        {
            tv_FilmInfo.Nodes.Clear();
            //查询所有电影名
            string filName = string.Format("select PP_Name from FilmArrange group by PP_Name");
            DataTable dtName = DBHelper.GetDataTable(filName);
            for (int i = 0; i < dtName.Rows.Count; i++)
            {
                string tvName = dtName.Rows[i]["PP_Name"].ToString();
                treeRoot = new TreeNode(tvName);
                treeRoot.Tag = "影片名";
                tv_FilmInfo.Nodes.Add(treeRoot);

                //查询所有电影的上映日期
                string filDate = string.Format("select PP_StartTime from FilmArrange group by PP_StartTime", tvName);
                DataTable dtdate = DBHelper.GetDataTable(filDate);
                for (int j = 0; j < dtdate.Rows.Count; j++)
                {
                    string tvdate = dtdate.Rows[j]["PP_StartTime"].ToString();
                    tvdate = Convert.ToDateTime(tvdate).ToString("MM月dd日 HH:mm:ss");
                    if (DateTime.Compare(Convert.ToDateTime(DateTime.Now.ToString("MM月dd日 HH:mm:ss")), Convert.ToDateTime(tvdate)) > 0)
                    {
                        continue;
                    }
                    dyDate = new TreeNode(Convert.ToDateTime(tvdate).ToString("MM月dd日"));
                    dyDate.Tag = "日期";
                    treeRoot.Nodes.Add(dyDate);

                    tvdate = Convert.ToDateTime(tvdate).ToString("HH:mm");
                    dyTime = new TreeNode(tvdate);
                    dyTime.Tag = "播放时间";
                    dyDate.Nodes.Add(dyTime);

                    string filTing = string.Format("select PP_Ting from FilmArrange where PP_Name='{0}' and PP_StartTime='{1}' group by PP_Ting", tvName, dtdate.Rows[j]["PP_StartTime"]);
                    DataTable dtTing = DBHelper.GetDataTable(filTing);
                    for (int f = 0; f < dtTing.Rows.Count; f++)
                    {
                        string tvTing = dtTing.Rows[f]["PP_Ting"].ToString();
                        dyTing = new TreeNode(tvTing);
                        dyTing.Tag = "厅";
                        dyTime.Nodes.Add(dyTing);
                    }

                }
            }
        }
        private void ExpanNodeByText(string str)
        {
            TreeNode node = null;
            foreach (TreeNode n in tv_FilmInfo.Nodes)
            {
                node = GetNodeByText(n, str);
                if (node!=null)
                {
                    break;
                }
            }
            if (node != null)
            {
                node.ExpandAll();
            }
        }

        private TreeNode GetNodeByText(TreeNode root , string str)
        {
            TreeNode tree = null;
            if (root.Text.Equals(str))
            {
                tree = root;
            }
            else
            {
                foreach (TreeNode n in root.Nodes)
                {
                    tree = GetNodeByText(n,str);
                    if (tree != null)
                    {
                        break;
                    }
                }
            }
            return tree;
        }
        private void lv_HotFilm_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lv_HotFilm.SelectedItems.Count == 0)
            {
                return;
            }
            tb_Seat.Parent = tabControl1;
            string str = lv_HotFilm.SelectedItems[0].Text.Replace(lv_HotFilm.SelectedItems[0].Text.Substring(0, 3), "");
            tabControl1.SelectTab("tb_Seat");
            ExpanNodeByText(str);
            TvFilm(str);
        }

        private int index = 0;
        Button clickBtn = new Button();
        private void SeatClick(object sender, EventArgs e)
        {
            clickBtn = sender as Button;
            if (UserName == null)
            {
                MessageBox.Show("请登录后再选票");
                return;
            }
            if (DateTime.Compare(Convert.ToDateTime(DateTime.Now.ToString("MM月dd日 HH:mm:ss")), Convert.ToDateTime(dateb+ playTime)) > 0)
            {
                MessageBox.Show("电影已开场，不能购票");
                return;
            }
            if (clickBtn.BackColor == Color.Green)
            {
                clickBtn.BackColor = Color.Transparent;
                clickBtn.ForeColor = Color.Black;
                --index;
                label16.Text = index.ToString();
                label13.Text = (Convert.ToDouble(lbljiage.Text.Replace("元", "")) * index).ToString() + " 元";
                return;
            }
            if (clickBtn.BackColor == Color.Red)
            {
                MessageBox.Show("该座位已被售出");
                return;
            }
            if (index > 5)
            {
                MessageBox.Show("一次只能选择6个座位");
                return;
            }
            clickBtn.BackColor = Color.Green;
            clickBtn.ForeColor = Color.White;
            ++index;
            label16.Text = index.ToString();
            if (label36.Visible==true)
            {
                label13.Text = (Convert.ToDouble(lbljiage.Text.Replace("元", "")) * index*0.85).ToString("F2") + " 元";
                return;
            }
            label13.Text = (Convert.ToDouble(lbljiage.Text.Replace("元", "")) * index).ToString() + " 元";
        }
        //统计待售座位数
        private static int DaiShou = 0;
        //统计已售座位数
        private static int YiShou = 0;
        Button seat = new Button();
        /// <summary>
        /// 动态生成座位
        /// </summary>
        private void Seat()
        {
            try
            {
                tb_Seats.Controls.Clear();
                int inde = 0;
                int row = 0;
                int col = 0;
                string str = string.Format("select PP_Seat from FilmArrange where PP_Name='{0}'  and PP_StartTime='{1}' and  PP_TIng='{2}'", filname, Convert.ToDateTime(dateb + playTime).ToString(), ting);
                DataTable dt = DBHelper.GetDataTable(str);
                string[] seat = null;
                string sql2 = string.Format("select YT_Row,YT_Col from YingTing where YT_Name='{0}'", ting);
                DataTable dy_Ting = DBHelper.GetDataTable(sql2);
                int seatSum = Convert.ToInt32(dy_Ting.Rows[0]["YT_Row"].ToString()) * Convert.ToInt32(dy_Ting.Rows[0]["YT_Col"].ToString());
                Label label = new Label();
                for (int i = 0; i < seatSum; i++)
                {
                    Button seatBtn = new Button();
                    seatBtn.BackColor = Color.Transparent;
                    seatBtn.AutoSize = false;
                    seatBtn.Font = new Font("Arial", 16, FontStyle.Regular);
                    seatBtn.Size = new Size(70, 40);
                    seatBtn.Name = "btn_" + inde;
                    seatBtn.Text = (row + 1).ToString() + "-" + (col + 1).ToString();
                    seatBtn.TextAlign = ContentAlignment.MiddleCenter;
                    seatBtn.Location = new Point(40 + (col * 100), 30 + (row * 80));
                    seatBtn.Tag = (inde + 1).ToString();
                    if (dt.Rows.Count > 0)
                    {
                        seat = dt.Rows[0]["PP_Seat"].ToString().Split(' ');
                        for (int j = 0; j < seat.Length; j++)
                        {
                            if (seatBtn.Text == seat[j])
                            {
                                seatBtn.BackColor = Color.Red;
                                seatBtn.ForeColor = Color.White;
                                break;
                            }
                        }
                    }
                    //点击事件由买票方法处理
                    seatBtn.Click += new EventHandler(SeatClick);

                    tb_Seats.Controls.Add(seatBtn);

                    col++;

                    if (col > Convert.ToInt32(dy_Ting.Rows[0]["YT_Col"].ToString()) - 1)
                    {
                        row++;
                        col = 0;
                    }
                    if (seatBtn.BackColor == Color.Transparent)
                    {
                        DaiShou++;
                        label28.Text = DaiShou.ToString();
                    }
                    if (seatBtn.BackColor == Color.Red)
                    {
                        YiShou++;
                        label30.Text = YiShou.ToString();
                    }
                    label.Location = new Point(30 + (col * 100), 10 + (row * 100));
                    this.tb_Seats.Controls.Add(label);
                    inde++;
                }
            }
            catch (Exception)
            {
            }
        }
        
        /// <summary>
        /// 修改用户昵称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_queding_Click(object sender, EventArgs e)
        {
            if (tb_NiceName.Text == "")
            {
                MessageBox.Show("昵称不能为空");
                return;
            }
            if (tb_NiceName.Text.Length>10)
            {
                MessageBox.Show("昵称不能超过10位");
                return;
            }
            string sql = string.Format("update UserInfo set YH_NiceName='{0}', YH_Sex='{1}' where YH_Name='{2}'", tb_NiceName.Text, cb_Sex.Text, tb_name.Text);
            try
            {
                if (DBHelper.ExecuteNoneQuery(sql))
                {
                    lb_Login.Text = "用户：" + tb_NiceName.Text;
                    MessageBox.Show("修改成功");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("修改失败，不能含有非法字符");
            }
        }
        
        private void btn_xiugai_Click(object sender, EventArgs e)
        {
            F_xiugai xiu = new F_xiugai(UserName);
            xiu.ShowDialog();
        }
        /// <summary>
        /// 重置座位相关数据信息
        /// </summary>
        private void SeatShua()
        {
            Seat();
            DaiShou = 0;
            YiShou = 0;
            index = 0;
            label16.Text = "0";
            label13.Text = "0元";
            tb_Seats.Parent = tabControl2;
        }

        
        private void TvFilm(string name)
        {
            DaiShou = 0;
            YiShou = 0;
            tb_Seats.Parent = null;
            DirectoryInfo info = new DirectoryInfo(@"..\..\..\..\项目图片/电影海报");
            string path;
            FileInfo fileInfo = new FileInfo(@"..\..\..\..\项目图片/电影海报");
            foreach (FileInfo f in info.GetFiles("*.jpg"))
            {
                string str = f.Name;
                path = string.Concat(@"..\..\..\..\项目图片/电影海报/", str);
                str = str.Replace(".jpg", "");
                if (name == str)
                {
                    pb_FilmName.Image = Image.FromFile(path);
                    break;
                }
            }
            try
            {
                string sql = string.Format("SELECT * FROM  FilmArrange ,MovieInfo where PP_Name='{0}'", name,Convert.ToDateTime(dateb + playTime).ToString());
                MessageBox.Show(Convert.ToDateTime(dateb + playTime).ToString());
                DataTable dt = DBHelper.GetDataTable(sql);
                label12.Text = dt.Rows[0]["DY_Time"].ToString() + "分钟";
                filname = dt.Rows[0]["PP_Name"].ToString();
                lbldaoyan.Text = dt.Rows[0]["DY_Director"].ToString();
                lblzhuyan.Text = dt.Rows[0]["DY_Start"].ToString();
                lbllei.Text = dt.Rows[0]["DY_Type"].ToString();
                lb_Area.Text = dt.Rows[0]["DY_Area"].ToString();
                lbltime.Text = dt.Rows[0]["PP_EndTime"].ToString();
                lbltime.Text = Convert.ToDateTime(lbltime.Text).ToString("HH:mm");
                label10.Text = lbltime.Text;
                lbljiage.Text = dt.Rows[0]["PP_Price"].ToString();
                //保留两位小数
                lbljiage.Text = lbljiage.Text.Substring(0, lbljiage.Text.IndexOf(".") + 3) + " 元";
                textBox1.Text = dt.Rows[0]["DY_Description"].ToString();
            }
            catch (Exception)
            {
            }
        }
        private string filname = "";
        private static string dateb = "";
        private static string ting = "";
        private static string playTime = "";
        private void tv_FilmInfo_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tv_FilmInfo.SelectedNode.Tag.ToString() == "厅")
            {
                TvFilm(tv_FilmInfo.SelectedNode.Parent.Parent.Parent.Text);
                playTime = tv_FilmInfo.SelectedNode.Parent.Text;
                dateb = tv_FilmInfo.SelectedNode.Parent.Parent.Text;
                filname= tv_FilmInfo.SelectedNode.Parent.Parent.Parent.Text;
                ting = tv_FilmInfo.SelectedNode.Text;
                SeatShua();
            }
            if (tv_FilmInfo.SelectedNode.Tag.ToString()=="影片名"|| tv_FilmInfo.SelectedNode.Tag.ToString() == "日期" || tv_FilmInfo.SelectedNode.Tag.ToString() == "播放时间")
            {
                TvFilm(tv_FilmInfo.SelectedNode.Text);
                DaiShou = 0;
                label28.Text = "0";
                label30.Text = "0";
                YiShou = 0;
                tb_Seats.Parent = null;
            }
        }

        /// <summary>
        /// 支付模块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if (UserName == null)
            {
                MessageBox.Show("请登录后再购票");
                return;
            }
            if (tb_Seats.Parent == null)
            {
                MessageBox.Show("请选择影片");
                return;
            }
            
            if (index==0)
            {
                MessageBox.Show("请选择座位");
                return;
            }
            string str = null;
            string order = null;
            string sql = null;
            string yi = string.Format("select PP_Seat from FilmArrange where PP_Name='{0}'and PP_StartTime='{1}' and PP_Ting='{2}'", filname, Convert.ToDateTime(dateb+playTime).ToString("yyyy-MM-dd HH:mm:ss"),ting);
            DataTable dt = DBHelper.GetDataTable(yi);
            MessageBox.Show(dt.Rows.Count.ToString());
            if (dt.Rows.Count > 0)
            {
                str = dt.Rows[0]["PP_Seat"].ToString();
            }
            Button btn = new Button();
            string btnText = "";
            foreach (Control item in tb_Seats.Controls)
            {
                if (item is Button)
                {
                    btn = item as Button;
                    if (btn.BackColor == Color.Green)
                    {
                        str += btn.Text + " ";
                        btnText += btn.Text + " ";
                        MessageBox.Show(str);
                        sql = string.Format("update FilmArrange set PP_Seat='{0}' where PP_Name='{1}' and PP_StartTime='{2}' and PP_Ting='{3}'", str, filname, Convert.ToDateTime(dateb+playTime).ToString(), ting);
                    }
                }
            }
            
           order = string.Format("insert OrderInfo values('{0}','{1}','{2}',getdate(),'{3}','{4}','{5}','已支付','{6}')", UserName, btnText, filname, label13.Text.Replace("元", ""), label16.Text,ting, Convert.ToDateTime(dateb + playTime).ToString());
            
            try
            {
                if (DBHelper.ExecuteNoneQuery(sql)&&DBHelper.ExecuteNoneQuery(order))
                {
                    MessageBox.Show("支付成功");
                    SeatShua();
                    UserInfor();
                    return;
                }
                MessageBox.Show("支付失败");
            }
            catch (Exception)
            {
                MessageBox.Show("购买失败");
            }
        }

        private void lv_FlimShow_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lv_FlimShow.SelectedItems.Count == 0)
            {
                return;
            }
            tb_Seat.Parent = tabControl1;
            string str = lv_FlimShow.SelectedItems[0].Text;
            tabControl1.SelectTab("tb_Seat");
            ExpanNodeByText(str);
            TvFilm(str);
        }
        

        OpenFileDialog fileDialogo = null;
        string fileName = null;
        string fileLuJing = null;
        private void btn_TouXiang_Click(object sender, EventArgs e)
        {
            fileDialogo = new OpenFileDialog();
            if (fileDialogo.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(fileDialogo.FileName);
                string[] str = new string[] { ".jpg", ".png", ".jpeg" };
                if (!((IList)str).Contains(extension))
                {
                    MessageBox.Show("仅能上传png,jpge,jpg格式的图片！");
                    return;
                }
            }
            else
            {
                return;
            }
            //获取文件名字
            fileName = fileDialogo.SafeFileName;
            pictureBox4.ImageLocation = fileDialogo.FileName;
            //获取文件路径完整路径
            fileLuJing = Path.GetFullPath(fileDialogo.FileName);
            //获取文件所在文件夹路劲
            fileLuJing = fileLuJing.Replace(fileName, "");
            string path = null;
            string path2 = null;
            FileInfo fi1 = null;
            FileInfo fi2 = null;

            if (fileDialogo != null)
            {
                //图片完整路径
                FileInfo file = new FileInfo(fileLuJing + fileName);
                path = fileLuJing + fileName;
                //移动文件夹到特定位置
                path2 = @"..\..\..\..\项目图片/用户头像/" + UserName + ".jpg";
                fi1 = new FileInfo(fileLuJing + fileName);
                fi2 = new FileInfo(path2);
                if (!File.Exists(path2))
                {
                    fi1.CopyTo(path2);
                }
                Images(path, pictureBox4);
                try
                {
                    
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        
        /// <summary>
        /// 传图片方法
        /// </summary>
        /// <param name="path"></param>
        /// <param name="pictureBox"></param>
        /// 
        private void Images(string path, PictureBox pictureBox)
        {
            Image image = Image.FromFile(path);
            int imagewidth = image.Width;//宽
            int imageheight = image.Height;//
            Image newImage = CutEllipse(image, new Rectangle(0, 0, imagewidth, imageheight), new Size(50, 50));
            Image bmp = new Bitmap(newImage);
            pictureBox.Image = bmp;
            //pictureBox.Image = newImage;
        }

        /// <summary>
        /// 将图片框改成圆角的方法
        /// </summary>
        /// <param name="img"></param>
        /// <param name="rec"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        private Image CutEllipse(Image img, Rectangle rec, Size size)
        {
            Bitmap bitmap = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                TextureBrush br = new TextureBrush(img, System.Drawing.Drawing2D.WrapMode.Clamp, rec);
                br.ScaleTransform(bitmap.Width / (float)rec.Width, bitmap.Height / (float)rec.Height);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.FillEllipse(br, new Rectangle(Point.Empty, size));
            }
            return bitmap;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pikaqiu pika = new pikaqiu();
            pika.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Fantan fantan = new Fantan();
            fantan.ShowDialog();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            yingyuejia yingyue = new yingyuejia();
            yingyue.ShowDialog();
        }
        

        private void btn_Tui_Click(object sender, EventArgs e)
        {
            if (dgv_dingdan.SelectedRows[0].Cells["TicketingState"].Value.ToString()=="退款成功")
            {
                MessageBox.Show("该订单已退款成功,无需重复操作");
                return;
            }
            if (dgv_dingdan.SelectedRows[0].Cells["TicketingState"].Value.ToString() == "待退款")
            {
                 MessageBox.Show("该订单正在退款审核中");
                return;
            }
            DialogResult result = MessageBox.Show("是否退款", "订单提醒:", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                string tui = string.Format("update OrderInfo set TicketingState='待退款' where D_ID='{0}'", dgv_dingdan.SelectedRows[0].Cells["D_ID"].Value.ToString());
                if (DBHelper.ExecuteNoneQuery(tui))
                {
                    MessageBox.Show("申请成功，等待退款");
                    Seat();
                    UserInfor();
                }
                else
                {
                    MessageBox.Show("申请失败，请稍后重试");
                }
            }
            else
            {
                MessageBox.Show("取消成功");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否删除该订单", "订单提醒:", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                string sql = string.Format("delete  from OrderInfo where D_ID='{0}'", dgv_dingdan.SelectedRows[0].Cells["D_ID"].Value.ToString());
                DBHelper.ExecuteNoneQuery(sql);
                UserInfor();
            }
            else
            {
                MessageBox.Show("取消成功");
            }
        }

        private void btn_VIP_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select sum(SumPrice) from OrderInfo where UserName='{0}'",UserName);
            if (Convert.ToDouble(DBHelper.ExecuteScalar(sql)) > 300)
            {
                string up = string.Format("update UserInfo set YH_VIP='1' where YH_Name='{0}'", UserName);
                if (DBHelper.ExecuteNoneQuery(up))
                {
                    MessageBox.Show("您已升级为尊贵的VIP，会员享受票价85折优惠");
                    return;
                }
                else
                {
                    MessageBox.Show("升级失败，请联系客服");
                    return;
                }
            }

            double cha = 300 - Convert.ToDouble(DBHelper.ExecuteScalar(sql));
            MessageBox.Show(string.Format("继续消费{0}元可升级为会员", cha));
        }

        private void button30_Click(object sender, EventArgs e)
        {

        }
    }
}