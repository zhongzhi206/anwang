using System;
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
    public partial class FilmArrange : Form
    {
        public FilmArrange()
        {
            InitializeComponent();
        }

        private void FilmArrange_Load(object sender, EventArgs e)
        {
            //查询所有电影名字加载到电影名称的下拉框中
            string sqlName = "SELECT DY_Name  FROM  MovieInfo";
            DataTable dtName = DBHelper.GetDataTable(sqlName);
            for (int i = 0; i < dtName.Rows.Count; i++)
            {
                cb_FilmName.Items.Add(dtName.Rows[i]["DY_Name"].ToString());
            }
            //让下拉框的模式改成用户不可编辑模式
            cb_FilmName.DropDownStyle = ComboBoxStyle.DropDownList;
            //查询所有影厅加载到影厅下拉框中
            string sq = "select YT_Name from YingTing";
            DataTable dtTing = DBHelper.GetDataTable(sq);
            for (int i = 0; i < dtTing.Rows.Count; i++)
            {
                cb_Ting.Items.Add(dtTing.Rows[i]["YT_Name"].ToString());
                comboBox1.Items.Add(dtTing.Rows[i]["YT_Name"].ToString());
            }
            cb_Ting.DropDownStyle = ComboBoxStyle.DropDownList;
            //加载排片信息加载到dataGridView中
            string sql = "SELECT PP_ID , PP_Name  ,PP_StartTime ,PP_EndTime ,PP_Price ,PP_Ting FROM  FilmArrange";
            dgv_Film.DataSource = DBHelper.GetDataTable(sql);
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_FilmName.Text == "" || tb_price.Text == "" || cb_Ting.Text == "" || dtp_PlayTime.Text == "")
                {
                    MessageBox.Show("添加的影片数据不能为空！");
                }

            }
            catch (Exception)
            {

            }


            //查询当前添加的电影时长
            string duration = string.Format("select DY_Time from MovieInfo where DY_Name='{0}'", cb_FilmName.Text);
            DataTable durations = DBHelper.GetDataTable(duration);
            //计算出当前排片电影的结束时间
            string endTime = Convert.ToDateTime(dtp_PlayTime.Text).AddMinutes(Convert.ToDouble(durations.Rows[0]["DY_Time"].ToString())).ToString();
            //比较当前时间与添加时间，
            DateTime date2 = Convert.ToDateTime(dtp_PlayTime.Text);
            if (DateTime.Compare(date2, DateTime.Now) < 0)
            {
                MessageBox.Show("请选择正确的时间");
                return;
            }
            //筛选出当前添加时间段是否安排过影片
            string startTimeFanWei = string.Format("select PP_ID from FilmArrange where PP_Ting='{0}' and PP_StartTime BETWEEN '{1}' and '{2}' or PP_EndTime between '{1}' and '{2}'", cb_Ting.Text, dtp_PlayTime.Text, endTime);
            DataTable dt = DBHelper.GetDataTable(startTimeFanWei);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("该影厅该时间段已有安排影片");
                return;
            }

            string add = string.Format("insert FilmArrange values('{0}','{1}','{2}','{3}','','{4}')", cb_FilmName.Text, dtp_PlayTime.Text, endTime, cb_Ting.Text, tb_price.Text);
            if (!DBHelper.ExecuteNoneQuery(add))
            {
                MessageBox.Show("添加失败");
                return;
            }
            MessageBox.Show("添加成功");
            Shua();

        }

        private void dgv_Film_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Film.SelectedRows.Count == 1)
            {
                DirectoryInfo info = new DirectoryInfo(@"..\..\..\..\项目图片/电影海报");
                string path;
                FileInfo fileInfo = new FileInfo(@"..\..\..\..\项目图片/电影海报");
                foreach (FileInfo f in info.GetFiles("*.jpg"))
                {
                    string str = f.Name;
                    path = string.Concat(@"..\..\..\..\项目图片/电影海报/", str);
                    str = str.Replace(".jpg", "");
                    if (dgv_Film.SelectedRows[0].Cells["PP_Name"].Value.ToString() == str)
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
        private void cb_FilmName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = string.Format("select DY_Time from MovieInfo where DY_Name='{0}'", cb_FilmName.Text);
            DataTable dt = DBHelper.GetDataTable(sql);
            label5.Text = dt.Rows[0]["DY_Time"].ToString() + "分钟";
            dtp_PlayTime_ValueChanged(null, null);
            DirectoryInfo info = new DirectoryInfo(@"..\..\..\..\项目图片/电影海报");
            string path;
            FileInfo fileInfo = new FileInfo(@"..\..\..\..\项目图片/电影海报");
            foreach (FileInfo f in info.GetFiles("*.jpg"))
            {
                string str = f.Name;
                path = string.Concat(@"..\..\..\..\项目图片/电影海报/", str);
                str = str.Replace(".jpg", "");
                if (cb_FilmName.Text == str)
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

        private void dtp_PlayTime_ValueChanged(object sender, EventArgs e)
        {
            string sql = string.Format("select DY_Time from MovieInfo where DY_Name='{0}'", cb_FilmName.Text);
            DataTable dt = DBHelper.GetDataTable(sql);
            label3.Text = Convert.ToDateTime(dtp_PlayTime.Text).AddMinutes(Convert.ToDouble(dt.Rows[0]["DY_Time"].ToString())).ToString();
        }

        private void dgv_Film_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                cb_FilmName.Text = dgv_Film.SelectedRows[0].Cells["PP_Name"].Value.ToString();
                cb_Ting.Text = dgv_Film.SelectedRows[0].Cells["PP_Ting"].Value.ToString();
                tb_price.Text= dgv_Film.SelectedRows[0].Cells["PP_Price"].Value.ToString();
                dtp_PlayTime.Text= dgv_Film.SelectedRows[0].Cells["PP_StartTime"].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            //查询当前添加的电影时长
            string duration = string.Format("select DY_Time from MovieInfo where DY_Name='{0}'", cb_FilmName.Text);
            DataTable durations = DBHelper.GetDataTable(duration);
            //计算出当前排片电影的结束时间
            string endTime = Convert.ToDateTime(dtp_PlayTime.Text).AddMinutes(Convert.ToDouble(durations.Rows[0]["DY_Time"].ToString())).ToString();
            //比较当前时间与添加时间，
            DateTime date2 = Convert.ToDateTime(dtp_PlayTime.Text);
            if (DateTime.Compare(date2, DateTime.Now) < 0)
            {
                MessageBox.Show("请选择正确的时间");
                return;
            }
            //筛选出当前添加时间段是否安排过影片
            string startTimeFanWei = string.Format("select PP_ID from FilmArrange where PP_Ting='{0}' and PP_StartTime BETWEEN '{1}' and '{2}' or PP_EndTime between '{1}' and '{2}'", cb_Ting.Text, dtp_PlayTime.Text, endTime);
            DataTable dt = DBHelper.GetDataTable(startTimeFanWei);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("该影厅该时间段已有安排影片");
                return;
            }
            string sql = string.Format("update FilmArrange set PP_Name='{0}',PP_StartTime='{1},PP_Ting='{2}',PP_Price='{3}' where PP_ID='{4}'", cb_FilmName.Text, dtp_PlayTime.Text, cb_Ting.Text, tb_price.Text, dgv_Film.SelectedRows[0].Cells["PP_ID"].Value.ToString());
            if (DBHelper.ExecuteNoneQuery(sql))
            {
                MessageBox.Show("修改成功");
                Shua();
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete FilmArrange where PP_ID='{0}'", dgv_Film.SelectedRows[0].Cells["PP_ID"].Value.ToString());
            if (DBHelper.ExecuteNoneQuery(sql))
            {
                MessageBox.Show("删除成功");
                Shua();
            }
        }
        private void Shua()
        {
            string sql = "SELECT PP_ID , PP_Name  ,PP_StartTime ,PP_EndTime ,PP_Price ,PP_Ting FROM  FilmArrange";
            dgv_Film.DataSource = DBHelper.GetDataTable(sql);
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT PP_ID , PP_Name  ,PP_StartTime ,PP_EndTime ,PP_Price ,PP_Ting FROM  FilmArrange where PP_Name like '%{0}%'", tb_one.Text);
            dgv_Film.DataSource = DBHelper.GetDataTable(sql);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT PP_ID , PP_Name  ,PP_StartTime ,PP_EndTime ,PP_Price ,PP_Ting FROM  FilmArrange where PP_Ting like '%{0}%'", comboBox1.Text);
            dgv_Film.DataSource = DBHelper.GetDataTable(sql);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT PP_ID , PP_Name  ,PP_StartTime ,PP_EndTime ,PP_Price ,PP_Ting FROM  FilmArrange where PP_StartTime between '{0}' and '{1}'", dateTimePicker2.Text, dateTimePicker1.Text);
            dgv_Film.DataSource = DBHelper.GetDataTable(sql);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT PP_ID , PP_Name  ,PP_StartTime ,PP_EndTime ,PP_Price ,PP_Ting FROM  FilmArrange where PP_StartTime between '{0}' and '{1}'", dateTimePicker2.Text, dateTimePicker1.Text);
            dgv_Film.DataSource = DBHelper.GetDataTable(sql);
        }
    }
}
