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
            // TODO: 这行代码将数据加载到表“darkNetDataSet.MovieType”中。您可以根据需要移动或删除它。
            this.movieTypeTableAdapter.Fill(this.darkNetDataSet.MovieType);
            // TODO: 这行代码将数据加载到表“darkNetDataSet1.AdmInfo”中。您可以根据需要移动或删除它。
            this.admInfoTableAdapter.Fill(this.darkNetDataSet1.AdmInfo);
            string sql = string.Format("SELECT * FROM dbo.AdmInfo");
            dvg_one.DataSource = DBHelper.GetDataTable(sql);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_zhiwu.Text==""||tb_pwd.Text==""||tb_name.Text=="")
            {
                MessageBox.Show("添加的管理员数据不能为空！");
            }
            string sql = string.Format("insert AdmInfo(Name,Pwd,Zhiwu) values('{0}','{1}','{2}')",tb_name.Text,tb_pwd.Text,tb_zhiwu.Text);
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
                MessageBox.Show("添加失败                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     ！");
            }
        }
    }
}
