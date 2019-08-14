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
        ImageList list = new ImageList();
        ListViewItem lvi = new ListViewItem();
        private void Tu()
        {
            list.ImageSize = new Size(100, 130);
            DirectoryInfo info = new DirectoryInfo(@"..\..\..\..\..\项目图片\电影海报");
            string path;
            FileInfo fileInfo = new FileInfo(@"..\..\..\..\..\项目图片\电影海报");
            foreach (FileInfo f in info.GetFiles("*.jpg"))
            {
                string str = f.Name;
                for (int i = 0; i < 1;)
                {
                    path = string.Concat(@"..\..\..\..\..\项目图片\电影海报\", str);
                    str = str.Replace(".jpg", "");
                    list.Images.Add(str, Image.FromFile(path));
                    break;
                }
            }
        }
        private void MovieWeihu_Load(object sender, EventArgs e)
        {
            Tu();
            pb_FilmImage.Image = list.Images[tb_name.Text];
            //string sql = "SELECT  dbo.MovieInfo.*, dbo.MovieType.* FROM  dbo.MovieInfo INNER JOIN dbo.MovieType ON dbo.MovieInfo.DY_Type = dbo.MovieType.LX_ID";
            //dgv_one.DataSource = DBHelper.GetDataTable(sql);
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string na = tb_name.Text;
            string di = tb_director.Text;
            string st = tb_start.Text;
            string ty =  cb_type.Text;
            string pr = tb_price.Text;
            string ti = tb_time.Text;
            string de = tb_description.Text;
            string ar = cb_area.Text;
            string dt = dtp_time.Text;
            if (na == "" || di == "" || st == "" || ty == "" || pr == "" || ti == "" ||  de == "" || ar == "" || dt == "")
            {
                MessageBox.Show("请把信息填写完整！");
                return;
            }
            FileInfo file = new FileInfo(fileLuJing + fileName);
            string path =  fileLuJing + fileName;
            string path2 = @"..\..\..\..\..\项目图片\电影海报\" + tb_name.Text + ".jpg";
            FileInfo fi1 = new FileInfo(fileLuJing + fileName);
            FileInfo fi2 = new FileInfo(path2);
            try
            {
                if (File.Exists(path2))
                {
                    DialogResult rel= MessageBox.Show("图片已存在，是否覆盖","提示",MessageBoxButtons.OKCancel);
                    if (rel==DialogResult.No)
                    {
                        return;
                    }
                    fi2.Delete();
                }
                fi1.CopyTo(path2);
            }
            catch (IOException)
            {
                
            }
            string typee = string.Format("Select LX_ID from MovieType where LX_Type='{0}'", ty);
            string dat = DBHelper.ExecuteScalar(typee).ToString();
            string sql = string.Format(@"insert MovieInfo values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                na, di, st, dat, pr, ti, de, ar, dt);
            if (DBHelper.ExecuteNoneQuery(sql))
            {
                 MessageBox.Show("添加成功！");
                MovieWeihu_Load(sender, e);
                tb_name.Text="";
                  tb_director.Text="";
                tb_start.Text="";
                 cb_type.Text="";
                 tb_price.Text="";
                  tb_time.Text="";
                  tb_description.Text="";
                 cb_area.Text="";
                 dtp_time.Text="";
                pb_FilmImage.Image = null;
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
           
        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsmi_one_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete MovieInfo where DY_ID='{0}'", dgv_one.SelectedRows[0].Cells["ID"].Value.ToString());
            if (DBHelper.ExecuteNoneQuery(sql))
            {
                MessageBox.Show("删除成功");
                MovieWeihu_Load(null,null);
            }
            else
            {
                MessageBox.Show("删除成功");
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        { 
            string na = tb_name.Text;
            string di = tb_director.Text;
            string st = tb_start.Text;
            string ty = cb_type.Text;
            string pr = tb_price.Text;
            string ti = tb_time.Text;
            string de = tb_description.Text;
            string ar = cb_area.Text;
            string dt = dtp_time.Text;
            if (na == "" || di == "" || st == "" || ty == "" || pr == "" || ti == "" || de == "" || ar == "" || dt == "")
            {
                MessageBox.Show("请把信息填写完整！");
                return;
            }
            FileInfo file = new FileInfo(fileLuJing + fileName);
            string path = fileLuJing + fileName;
            string path2 = @"..\..\..\..\..\项目图片\电影海报\" + tb_name.Text + ".jpg";
            FileInfo fi1 = new FileInfo(fileLuJing + fileName);
            FileInfo fi2 = new FileInfo(path2);

            try
            {
                if (File.Exists(path2))
                {
                    DialogResult rel = MessageBox.Show("图片已存在，是否覆盖", "提示", MessageBoxButtons.OKCancel);
                    if (rel == DialogResult.No)
                    {
                        return;
                    }
                }
                fi1.CopyTo(path2);
                MessageBox.Show("添加成功");
            }
            catch (IOException ioex)
            {
                MessageBox.Show(ioex.Message);
            }
            string typee = string.Format("Select LX_ID from MovieType where LX_Type='{0}'", ty);
            string dat = DBHelper.ExecuteScalar(typee).ToString();

            string sql = string.Format(@"update MovieInfo set DY_Name='{0}',DY_Director='{1}',DY_Start='{2}',DY_Type='{3}',DY_Price='{4}',DY_Time='{5}',
DY_Description='{6}',DY_Area='{7} ',DY_Releasetime='{8}' where DY_ID='{9}'", na, di, st, dat, pr, ti, de, ar, dt, dgv_one.SelectedRows[0].Cells["ID"].Value.ToString());
            if (DBHelper.ExecuteNoneQuery(sql))
            {

                MessageBox.Show("修改成功！");
                MovieWeihu_Load(sender, e);
                tb_name.Text = "";
                tb_director.Text = "";
                tb_start.Text = "";
                cb_type.Text = "";
                tb_price.Text = "";
                tb_time.Text = "";
                tb_description.Text = "";
                cb_area.Text = "";
                dtp_time.Text = "";
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void dgv_one_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_name.Text = dgv_one.SelectedRows[0].Cells[1].Value.ToString();
            pb_FilmImage.Image = list.Images[tb_name.Text];
            tb_director.Text = dgv_one.SelectedRows[0].Cells[2].Value.ToString();
            tb_start.Text = dgv_one.SelectedRows[0].Cells[3].Value.ToString();
            cb_type.Text = dgv_one.SelectedRows[0].Cells[4].Value.ToString();
            tb_price.Text = dgv_one.SelectedRows[0].Cells[5].Value.ToString();
            tb_time.Text = dgv_one.SelectedRows[0].Cells[6].Value.ToString();
            tb_description.Text = dgv_one.SelectedRows[0].Cells[7].Value.ToString();
            cb_area.Text = dgv_one.SelectedRows[0].Cells[8].Value.ToString();
            dtp_time.Text = dgv_one.SelectedRows[0].Cells[9].Value.ToString();
            
        }
        OpenFileDialog fileDialog = null;
        string fileName=null;
        string fileLuJing=null;
        private void btn_chuan_Click(object sender, EventArgs e)
        {
            fileDialog = new OpenFileDialog();
            if (!(fileDialog.ShowDialog()==DialogResult.OK))
            {
                return;
            }
            string extension = Path.GetExtension(fileDialog.FileName);
            string[] str = new string[] { ".jpg", ".png", ".jpeg" };
            if (!((IList)str).Contains(extension))
            {
                MessageBox.Show("仅能上传png,jpge,jpg格式的图片！");
            }
            //获取文件名字
            fileName = fileDialog.SafeFileName;
            pb_FilmImage.ImageLocation = fileDialog.FileName;
            //获取文件路径完整路径
            fileLuJing = Path.GetFullPath(fileDialog.FileName);
            //获取文件所在文件夹路劲
            fileLuJing = fileLuJing.Replace(fileName,"");
            }

        private void dgv_one_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

