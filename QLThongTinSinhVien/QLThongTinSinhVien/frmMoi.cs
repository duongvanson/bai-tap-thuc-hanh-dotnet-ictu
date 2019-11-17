using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLThongTinSinhVien
{
    public partial class frmMoi : Form
    {
        public frmMoi()
        {
            InitializeComponent();
        }
        SqlConnection connect = null;
        String strConnect = "Data Source=DESKTOP-TJUO3UD;Initial Catalog=db_sach;Integrated Security=True";
        private void frmMoi_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(strConnect);
            connect.Open();
            loadData();
        }

        private void loadData()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from sach", connect);
            adapter.Fill(dataTable);
            dataViewMoi.DataSource = dataTable;
        }
    }
}
