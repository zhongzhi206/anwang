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
    }
}
