using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieInfo
{
    public partial class FilmSchedule : Form
    {
        public FilmSchedule()
        {
            InitializeComponent();
        }

        private void nud_Price_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FilmSchedule_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select * from MovieInfo");
            dgv_Film.DataSource = DBHelper.GetDataTable(sql);
        }
        
        OpenFileDialog fileDialogo = null;
        
        private void pb_FilmImage_Click(object sender, EventArgs e)
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

                pb_FilmImage.Image = Image.FromFile(Path.GetFullPath(fileDialogo.FileName));
            }
            else
            {
                return;
            }
        }
        private void btn_jia_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "" || tb_time.Text == "" || textBox2.Text == "" || tb_Ting.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("添加的电影信息不能为空！");
                return;
            }


            string imagePath = null;
            string imagePath2 = @"..\..\..\..\项目图片/电影海报/" + tb_name.Text + ".jpg";
            if (fileDialogo.FileName == null)
            {
                MessageBox.Show("请上传图片");
                return;
            }
            imagePath = Path.GetFullPath(fileDialogo.FileName);
            FileInfo fil = new FileInfo(Path.GetFullPath(fileDialogo.FileName));
            FileInfo fil2 = new FileInfo(imagePath2);
            if (!File.Exists(imagePath2))
            {
                fil.CopyTo(imagePath2);
            }
            else
            {
                fil2.Delete();
                fil.CopyTo(imagePath2);
            }
            string sql = string.Format("insert MovieInfo(DY_Name,DY_Director,DY_Start,DY_Type,DY_Time,DY_Description,DY_Area) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}' )", tb_name.Text, tb_time.Text, textBox2.Text, tb_Ting.Text, textBox3.Text, textBox1.Text, comboBox1.Text);
            if (DBHelper.ExecuteNoneQuery(sql))
            {
                FilmSchedule_Load(sender, e);
                MessageBox.Show("添加成功");
            }

            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void tb_time_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Film_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = string.Format("update MovieInfo set DY_Name='{0}',DY_Director='{1}',DY_Start='{2}',DY_Type='{3}',DY_Time='{4}',DY_Description='{5}',DY_Area='{6}' where DY_ID='{7}'", tb_name.Text, tb_time.Text, textBox2.Text, tb_Ting.Text, textBox3.Text, textBox1.Text, comboBox1.Text, dgv_Film.SelectedRows[0].Cells["ID"].Value.ToString());
            if (DBHelper.ExecuteNoneQuery(sql))
            {
                FilmSchedule_Load(sender, e);
                MessageBox.Show("更改成功");
            }

            else
            {
                MessageBox.Show("更改失败");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete MovieInfo where DY_ID='{0}'", dgv_Film.SelectedRows[0].Cells["ID"].Value.ToString());
            if (DBHelper.ExecuteNoneQuery(sql))
            {
                MessageBox.Show("删除成功");
                FilmSchedule_Load(sender, e);
            }
            else
            {
                MessageBox.Show("删除成功");
            }
        }

        private void dgv_Film_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_name.Text = dgv_Film.SelectedRows[0].Cells[1].Value.ToString();
                tb_time.Text = dgv_Film.SelectedRows[0].Cells[2].Value.ToString();
                textBox2.Text = dgv_Film.SelectedRows[0].Cells[3].Value.ToString();
                tb_Ting.Text = dgv_Film.SelectedRows[0].Cells[4].Value.ToString();
                textBox3.Text = dgv_Film.SelectedRows[0].Cells[5].Value.ToString();
                textBox1.Text = dgv_Film.SelectedRows[0].Cells[6].Value.ToString();
                comboBox1.Text = dgv_Film.SelectedRows[0].Cells[7].Value.ToString();
                DirectoryInfo info = new DirectoryInfo(@"..\..\..\..\项目图片/电影海报");
                string path;
                FileInfo fileInfo = new FileInfo(@"..\..\..\..\项目图片/电影海报");
                foreach (FileInfo f in info.GetFiles("*.jpg"))
                {
                    string str = f.Name;
                    path = string.Concat(@"..\..\..\..\项目图片/电影海报/", str);
                    str = str.Replace(".jpg", "");
                    if (tb_name.Text==str)
                    {
                        pb_FilmImage.Image= Image.FromFile(path);
                        return;
                    }
                    pb_FilmImage.Image = null;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
