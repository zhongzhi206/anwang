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
    public partial class FanNeiRong : Form
    {
        public FanNeiRong()
        {
            InitializeComponent();
        }
        private static string ID;
        public FanNeiRong(string index)
        {
            InitializeComponent();
            ID = index;
        }

        private void FanNeiRong_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select * from Feedback where id='{0}'",ID);
            DataTable dt = DBHelper.GetDataTable(sql);
            textBox1.Text = dt.Rows[0]["NeRong"].ToString();
        }
    }
}
