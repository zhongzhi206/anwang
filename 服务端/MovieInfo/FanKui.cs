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
    public partial class FanKui : Form
    {
        public FanKui()
        {
            InitializeComponent();
        }

        private void FanKui_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBHelper.GetDataTable("select * from Feedback");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string index = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                FanNeiRong rong = new FanNeiRong(index);
                rong.ShowDialog();
            }
            catch (Exception)
            {


            }

        }
    }
}
