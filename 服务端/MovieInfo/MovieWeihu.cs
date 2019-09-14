using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace MovieInfo
{
    public partial class MovieWeihu : Form
    {
        public MovieWeihu()
        {
            InitializeComponent();
        }

        private void MovieWeihu_Load(object sender, EventArgs e)
        {
            string sq = "select YT_Name from YingTing";
            DataTable dt = DBHelper.GetDataTable(sq);
            string sql = "SELECT  dbo.MovieInfo.* FROM   dbo.MovieInfo";
            dgv_cha.DataSource = DBHelper.GetDataTable(sql);
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string na = tb_name.Text;
            string di = tb_director.Text;
            string st = tb_start.Text;
            string ty = cb_type.Text;
            string ti = tb_time.Text;
            string de = tb_description.Text;
            string ar = cb_area.Text;

            if (na == "" || di == "" || st == "" || ty == ""  || ti == "" || de == "" || ar == "")
            {
                MessageBox.Show("请把信息填写完整！");
                return;
            }

            string path = null;
            string path2 = null;
            FileInfo fi1 = null;
            FileInfo fi2 = null;

            if (fileDialog != null)
            {
                path = fileLuJing + fileName;
                FileInfo file = new FileInfo(path);
                path2 = @"..\..\..\..\项目图片/电影海报/" + tb_name.Text + ".jpg";
                fi1 = new FileInfo(path);
                fi2 = new FileInfo(path2);
                FileInfo fi3 = new FileInfo(path2);
                try
                {
                    if (File.Exists(path2))
                    {
                        DialogResult rel = MessageBox.Show("图片已存在，是否覆盖", "提示", MessageBoxButtons.OKCancel);
                        if (rel == DialogResult.Yes)
                        {
                            File.Delete(path2);
                            fi1.CopyTo(path2);
                        }
                    }
                    fi1.CopyTo(path2);
                }
                catch (IOException )
                {

                }
            }

            string sql = string.Format("insert MovieInfo values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", na, di, st, ty, ti, de, ar);
            try
            {
                if (DBHelper.ExecuteNoneQuery(sql))
                {
                    na = "" ; 
                    di = "" ;
                    st="";
                    ty= "";
                    ti = "";
                    de = "" ;
                    ar ="" ;
                    MessageBox.Show("添加成功");
                    MovieWeihu_Load(null,null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败",ex.Message);
            }

        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsmi_one_Click(object sender, EventArgs e)
        {
            try
            {
  string sql = string.Format("delete MovieInfo where DY_ID='{0}'", dgv_cha.SelectedRows[0].Cells["ID"].Value.ToString());
            if (DBHelper.ExecuteNoneQuery(sql))
            {
                MessageBox.Show("删除成功");
                MovieWeihu_Load(null, null);
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

        private void bt_update_Click(object sender, EventArgs e)
        {
            string na = tb_name.Text;
            string di = tb_director.Text;
            string st = tb_start.Text;
            string ty = cb_type.Text;
            string ti = tb_time.Text;
            string de = tb_description.Text;
            string ar = cb_area.Text;
            pb_FilmImage.Image.Dispose();
            string path = null;
            string path2 = null;
            FileInfo fi1 = null;
            FileInfo fi2 = null;
            if (fileDialog!=null)
            {
                FileInfo file = new FileInfo(fileLuJing + fileName);
                path = fileLuJing + fileName;
                path2 = @"..\..\..\..\项目图片/电影海报/" + tb_name.Text + ".jpg";
                fi1 = new FileInfo(fileLuJing + fileName); 
                fi2 = new FileInfo(path2);
                try
                {
                    if (File.Exists(path2))
                    {
                        DialogResult rel = MessageBox.Show("图片已存在，是否覆盖", "提示", MessageBoxButtons.OKCancel);
                        if (rel == DialogResult.OK)
                        {
                            pb_FilmImage.Image.Dispose();
                            File.Delete(path2);
                            return;
                        }
                    }
                    fi1.CopyTo(path2);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            
            if (na == "" || di == "" || st == "" || ty == ""  || ti == "" || de == "" || ar == "")
            {
                MessageBox.Show("请把信息填写完整！");
                return;
            }

            string sql = string.Format(@"update MovieInfo set DY_Name='{0}',DY_Director='{1}',DY_Start='{2}',DY_Type='{3}',DY_Time='{4}',DY_Description='{5}',DY_Area='{6}' where DY_ID='{7}'", na, di, st, ty, ti, de, ar, dgv_cha.SelectedRows[0].Cells["ID"].Value.ToString());
            try
            {
                if (DBHelper.ExecuteNoneQuery(sql))
                {
                    MessageBox.Show("修改成功！");
                    MovieWeihu_Load(sender, e);
                    tb_name.Text = "";
                    tb_director.Text = "";
                    tb_start.Text = "";
                    cb_type.Text = "";
                    tb_time.Text = "";
                    tb_description.Text = "";
                    cb_area.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失败！",ex.Message);
            }

        }

        private void dgv_one_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_cha.SelectedRows.Count == 1)
            {
                tb_name.Text = dgv_cha.SelectedRows[0].Cells["MName"].Value.ToString();
                tb_start.Text = dgv_cha.SelectedRows[0].Cells["Start"].Value.ToString();
                cb_type.Text = dgv_cha.SelectedRows[0].Cells["Type"].Value.ToString();
                tb_time.Text = dgv_cha.SelectedRows[0].Cells["Time"].Value.ToString();
                cb_area.Text = dgv_cha.SelectedRows[0].Cells["Area"].Value.ToString();
                tb_director.Text = dgv_cha.SelectedRows[0].Cells["Director"].Value.ToString();
                tb_description.Text= dgv_cha.SelectedRows[0].Cells["Description"].Value.ToString();
                DirectoryInfo info = new DirectoryInfo(@"..\..\..\..\项目图片/电影海报");
                string path;
                FileInfo fileInfo = new FileInfo(@"..\..\..\..\项目图片/电影海报");
                foreach (FileInfo f in info.GetFiles("*.jpg"))
                {
                    string str = f.Name;
                    path = string.Concat(@"..\..\..\..\项目图片/电影海报/", str);
                    str = str.Replace(".jpg", "");
                    if (tb_name.Text == str)
                    {
                        pb_FilmImage.Image = Image.FromFile(path);
                        break;
                    }
                    else
                    {
                        pb_FilmImage.Image = null;
                    }
                }
            }
        }
        OpenFileDialog fileDialog = null;
        string fileName = null;
        string fileLuJing = null;
        private void btn_chuan_Click(object sender, EventArgs e)
        {
            fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(fileDialog.FileName);
                string[] str = new string[] { ".jpg", ".png", ".jpeg" };
                if (!((IList)str).Contains(extension))
                {
                    MessageBox.Show("仅能上传png,jpge,jpg格式的图片！");
                }
            }
            else
            {
                return;
            }
            //获取文件名字
            fileName = fileDialog.SafeFileName;
            pb_FilmImage.ImageLocation = fileDialog.FileName;
            //获取文件路径完整路径
            fileLuJing = Path.GetFullPath(fileDialog.FileName);
            //获取文件所在文件夹路劲
            fileLuJing = fileLuJing.Replace(fileName, "");
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("select * from MovieInfo where DY_Name like '%{0}%' or DY_Type like'%{1}%' or DY_Area like'%{1}%'", tb_one.Text, tb_one.Text, tb_one.Text);
            DataTable dt = DBHelper.GetDataTable(sql);
            if (dt.Rows.Count == 0)
            {
               MessageBox.Show("查询不到该影片！");
            }
            else
            {
               dgv_cha.DataSource = DBHelper.GetDataTable(sql);
            }
            }
            catch (Exception)
            {
            }
          
        }
        

        private void dgv_cha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tsm_ShuaXin_Click(object sender, EventArgs e)
        {
            MovieWeihu_Load(null,null);
        }

        private void pb_FilmImage_Click(object sender, EventArgs e)
        {

        }
    }
    }

