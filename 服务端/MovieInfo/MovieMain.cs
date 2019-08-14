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
    public partial class MovieMain : Form
    {
        public MovieMain()
        {
            InitializeComponent();
        }

      
        private void tsmi_weihu_Click(object sender, EventArgs e)
        {
            MovieWeihu weihu = new MovieWeihu();
            weihu.MdiParent = this;
            weihu.Show();
        }

      
        private void tsmi_wwei_Click(object sender, EventArgs e)
        {
            AdmInfozheng zheng = new AdmInfozheng();
            zheng.MdiParent = this;
            zheng.Show();
        }
        private void tsmi_Xintwo_Click(object sender, EventArgs e)
        {
            NewMain nnew = new NewMain();
            nnew.MdiParent = this;
            nnew.Show();
        }
        private void tsm_Fan_Click(object sender, EventArgs e)
        {
            FanKui fanKui = new FanKui();
            fanKui.MdiParent = this;
            fanKui.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Usermain user = new Usermain();
            user.MdiParent = this;
            user.Show();
        }

        private void MovieMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MovieMain_Load(object sender, EventArgs e)
        {

        }
    }
}
