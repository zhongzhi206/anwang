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
    public partial class BoxOffice : Form
    {
        public BoxOffice()
        {
            InitializeComponent();
        }

        private void BoxOffice_Load(object sender, EventArgs e)
        {
            string sql = "select FileName,DY_Director,DY_Start,DY_Type,DY_Time,DY_Area, sum(SumPrice) BoxOffices from OrderInfo, MovieInfo where OrderInfo.FileName = MovieInfo.DY_Name and TicketingState <> '待退款' group by FileName,DY_Director,DY_Type,DY_Time,DY_Area,DY_Start";
            dataGridView1.DataSource = DBHelper.GetDataTable(sql);
        }

        private void btn_Seach_Click(object sender, EventArgs e)
        {
        }
        
        
    }
}
