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

        private void tsmi_chaxun_Click(object sender, EventArgs e)
        {
            MovieQuery query = new MovieQuery();
            query.MdiParent = this;
            query.Show();
        }

        private void tsmi_weihu_Click(object sender, EventArgs e)
        {
            MovieWeihu weihu = new MovieWeihu();
            weihu.MdiParent = this;
            weihu.Show();
        }




        private void tsmi_wei_Click(object sender, EventArgs e)
        {
            Movietype type = new Movietype();
            type.MdiParent = this;
            type.Show();
        }

        private void tsmi_wwei_Click(object sender, EventArgs e)
        {
            AdmInfozheng zheng = new AdmInfozheng();
            zheng.MdiParent = this;
            zheng.Show();



        }

        private void tsmi_ccha_Click(object sender, EventArgs e)
        {
            MovieGuanLi Gaunli = new MovieGuanLi();
            Gaunli.MdiParent = this;
            Gaunli.Show();

        }

        private void tsmi_Xintwo_Click(object sender, EventArgs e)
        {
            NewMain nnew = new NewMain();
            nnew.MdiParent = this;
            nnew.Show();
        }

    }
}
