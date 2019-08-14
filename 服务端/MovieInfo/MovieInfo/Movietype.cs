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
    public partial class Movietype : Form
    {
        public Movietype()
        {
            InitializeComponent();
        }

        private void Movietype_Load(object sender, EventArgs e)
        {
            string sql = "select * from MovieType";
            dgv_one.DataSource = DBHelper.GetDataTable(sql);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void but_one_Click(object sender, EventArgs e)
        {
            string sql =string.Format( "select * from MovieType where LX_Type='{0}' ",tb_one.Text);
            DataTable dt = new DataTable(sql);
           
            if (dt.Rows.Count<0)
            {
               
                dgv_one.DataSource = "";
            }
            else
            {
                dgv_one.DataSource=DBHelper.GetDataTable(sql);
                    
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_one.Text=="")
            {
                MessageBox.Show("请输入需添加的类型名！");
                return;
            }
            string sql = string.Format("insert MovieType(LX_Type) values('{0}')",tb_one.Text);
            if (DBHelper.ExecuteNoneQuery(sql))
            {
                MessageBox.Show("添加成功！");
                tb_one.Text = "";
                Movietype_Load( sender,e);
            }else
	{
               MessageBox.Show("添加失败！");
	}
        }

        private void btn_gai_Click(object sender, EventArgs e){

            if (tb_one.Text == "")
            {
                MessageBox.Show("修改的类型名不能为空！");
                return;
            }

            string sql = string.Format("update MovieType set LX_Type='{0}' where LX_ID='{1}'", tb_one.Text, dgv_one.SelectedRows[0].Cells["ID"].Value.ToString());
            if (DBHelper.ExecuteNoneQuery(sql))
            {
                MessageBox.Show("修改成功！");
                tb_one.Text = "";
                Movietype_Load( sender, e);
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsmi_one_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete MovieType where DY_ID='{0}'", dgv_one.SelectedRows[0].Cells["ID"].Value.ToString());
            if (DBHelper.ExecuteNoneQuery(sql))
            {
                MessageBox.Show("删除成功");
                Movietype_Load( sender,e);
            }
            else
            {
                MessageBox.Show("删除成功");
            }
        }

        private void btn_chong_Click(object sender, EventArgs e)
        {
            Movietype_Load(sender, e);
            tb_one.Text = "";
        }
    }
}
