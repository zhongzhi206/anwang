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
    public partial class MovieGuanLi : Form
    {
        public MovieGuanLi()
        {
            InitializeComponent();
        }

        private void MovieGuanLi_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“darkNetDataSet1.AdmInfo”中。您可以根据需要移动或删除它。
            this.admInfoTableAdapter.Fill(this.darkNetDataSet1.AdmInfo);
            string sql = string.Format("select * from AdmInfo");
            dgv_one.DataSource = DBHelper.GetDataTable(sql);
        }
    }
}
