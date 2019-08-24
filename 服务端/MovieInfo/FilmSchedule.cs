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
            if ( e.KeyChar == '-' || e.KeyChar == ',')
                e.Handled = true;
        }

        private void FilmSchedule_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select * from Shooting");
            dgv_Film.DataSource = DBHelper.GetDataTable(sql);
        }

        OpenFileDialog fileDialogo = null;
        string imagePath = null;
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
            }
            else
            {
                return;
            }


        }

        private void btn_jia_Click(object sender, EventArgs e)
        {
            
        }
    }
}
