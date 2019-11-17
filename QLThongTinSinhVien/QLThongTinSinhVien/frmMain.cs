using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLThongTinSinhVien
{
    public partial class frmMain : Form
    {
        private Boolean exe = false;
        public SqlConnection conn = null;
        String strConn = @"Data Source=DESKTOP-TJUO3UD;Initial Catalog=db_sinhvien;Integrated Security=True";
        public frmMain()
        {
            InitializeComponent();
        }
        ConnectDatabase cdata = null;
        private void frmMain_Load(object sender, EventArgs e)
        {
            //addTitleView();
            conn = new SqlConnection(strConn);
            loadData();
            //cdata = new ConnectDatabase();
            //dgvView.DataSource = cdata.getData("sinh_vien");
            //load_data();
            //dgvView.Rows[0].Selected = false;
        }

        private void loadData()
        {
            conn.Open();
            DataTable data = new DataTable();
            string sql = "select * from sinh_vien";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, this.conn);
            adapter.Fill(data);
            dgvView.DataSource = data;
        }

        private void load_data()
        {
            txtHo.DataBindings.Clear();
            txtKhoa.DataBindings.Clear();
            txtMa.DataBindings.Clear();
            txtTen.DataBindings.Clear();
            dtNgaySinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Clear();

            txtHo.DataBindings.Add("Text", dgvView.DataSource, "ho_sv");
            txtKhoa.DataBindings.Add("Text", dgvView.DataSource, "ma_khoa");
            txtMa.DataBindings.Add("Text", dgvView.DataSource, "ma_sv");
            txtTen.DataBindings.Add("Text", dgvView.DataSource, "ten_sv");
            dtNgaySinh.DataBindings.Add("Value", dgvView.DataSource, "ngay_sinh");
            cbGioiTinh.DataBindings.Add("SelectedItem", dgvView.DataSource,"gioi_tinh");
        }

        private void addTitleView()
        {
            dgvView.Columns[0].DataPropertyName = "ma_sv";
            dgvView.Columns[1].DataPropertyName = "ho_sv";
            dgvView.Columns[2].DataPropertyName = "ten_sv";
            dgvView.Columns[3].DataPropertyName = "ngay_sinh";
            dgvView.Columns[4].DataPropertyName = "gioi_tinh";
            dgvView.Columns[5].DataPropertyName = "ma_khoa";
            dgvView.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dgvView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvView.CurrentCell.RowIndex == -1) return;
            //try
            //{
            //    var row = dgvView.SelectedRows[0];
            //    txtMa.Text = row.Cells[0].Value + "";
            //    txtHo.Text = row.Cells[1].Value + "";
            //    txtTen.Text = row.Cells[2].Value + "";
            //    cbGioiTinh.SelectedIndex = row.Cells[4].Value.ToString() == "Nam" ? 0 : 1;
            //    dtNgaySinh.Value = DateTime.Parse(row.Cells[3].Value.ToString());
            //    txtKhoa.Text = row.Cells[5].Value + "";
            //}
            //catch (Exception)
            //{
            //    return;
            //}

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            exe = true;
            isClick(true);
            isClear(true);
            isEnble(true);
        }
        void isClick(bool b)
        {
            btnLuu.Enabled = b;
            btnHuy.Enabled = b;
        }
        void isClear(bool b)
        {
            txtMa.ResetText();
            txtHo.ResetText();
            txtTen.ResetText();
            txtKhoa.ResetText();
            cbGioiTinh.SelectedIndex = -1;
        }
        void isEnble(bool b)
        {
            dgvView.Enabled = !b;
            btnSua.Enabled = !b;
            btnXoa.Enabled = !b;
            btnThem.Enabled = !b;
            txtMa.Enabled = exe ? b : !b;
            txtHo.Enabled = b;
            txtTen.Enabled = b;
            txtKhoa.Enabled = b;
            cbGioiTinh.Enabled = b;
            dtNgaySinh.Enabled = b;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMa.Text)
                || String.IsNullOrWhiteSpace(txtHo.Text)
                || String.IsNullOrWhiteSpace(txtTen.Text)
                || String.IsNullOrWhiteSpace(txtKhoa.Text)
                || String.IsNullOrWhiteSpace(cbGioiTinh.SelectedItem.ToString())
                )
            {
                MessageBox.Show("Thông tin không hợp lệ.");
                return;
            }
            var sinhVien = new SinhVien(txtMa.Text,
                    txtHo.Text, txtTen.Text, dtNgaySinh.Value,
                    cbGioiTinh.SelectedItem.ToString(), txtKhoa.Text);
            if (exe) //Khi them
            {
                if (this.cdata.insertSV(sinhVien))
                {
                    MessageBox.Show("Thêm thành công.");
                    isClick(false);
                    isEnble(false);
                    this.frmMain_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại.");
                    txtMa.Enabled = true;
                }
            }
            else // Khi sua
            {
                if (this.cdata.updateSV(sinhVien))
                {
                    MessageBox.Show("Sửa thành công.");
                    isClick(false);
                    isEnble(false);
                    this.frmMain_Load(sender, e);
                    txtMa.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sửa thất bại.");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvView.SelectedRows.Count <= 0) return;
            exe = false;
            isEnble(true);
            isClick(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isEnble(false);
            isClick(false);
            txtMa.Enabled = false;
            frmMain_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvView.SelectedRows.Count > 0)
            {
                var res = MessageBox.Show("Xóa à?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    if (this.cdata.deleteSV(txtMa.Text))
                    {
                        MessageBox.Show("Xóa thành công.");
                        isClick(false);
                        isClear(false);
                        this.frmMain_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại.");
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtKhoa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
