using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSanPham
{
    public partial class frmMain : Form
    {
        ManagerPhoneDataContext dataContext;
        string trademark;
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            dataContext = new ManagerPhoneDataContext();
            loadTradeMark();
            //setTitleData();
            //loadPhone();
            //setDataText();
        }

        private void setDataText()
        {
            txtCode.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtDescription.DataBindings.Clear();
            picImage.DataBindings.Clear();
            txtCode.DataBindings.Add("Text", dgvPhone.DataSource, "code");
            txtName.DataBindings.Add("Text", dgvPhone.DataSource, "name");
            txtDescription.DataBindings.Add("Text", dgvPhone.DataSource, "description");
            Binding binImg = new Binding("Image", dgvPhone.DataSource, "image");
            binImg.Format += BinImg_Format;
            var row = dgvPhone.Rows[dgvPhone.CurrentCell.RowIndex];
            var products = dataContext.products;
            var phone = products.FirstOrDefault(p => p.id == int.Parse(row.Cells[0].Value.ToString()));
            if (phone.image != null) picImage.DataBindings.Add(binImg);
            else picImage.Image = QLSanPham.Properties.Resources.open;
        }

        private void BinImg_Format(object sender, ConvertEventArgs e)
        {
            if (e.Value == null)
            {
                e.Value = null;
                return;
            }
            byte[] b = ((Binary)e.Value).ToArray();
            MemoryStream stream = new MemoryStream(b);
            Bitmap bitmap = new Bitmap(stream);
            stream.Close();
            e.Value = bitmap;
        }

        private void setTitleData()
        {
            dgvPhone.Columns[0].DataPropertyName = "id";
            dgvPhone.Columns[1].DataPropertyName = "code";
            dgvPhone.Columns[2].DataPropertyName = "name";
            dgvPhone.Columns[3].DataPropertyName = "description";
            dgvPhone.Columns[4].DataPropertyName = "image";
        }

        private void loadPhone()
        {
            this.trademark = ((trademark)lbTrademark.SelectedItem).code;
            var products = dataContext.products;
            var phones = from phone in products
                         where phone.code_trademark == $"{trademark}"
                         select new { phone.id, phone.code, phone.name, phone.description, phone.image };
            dgvPhone.DataSource = phones;
        }

        private void loadTradeMark()
        {
            lbTrademark.DataSource = dataContext.trademarks;
            lbTrademark.DisplayMember = "name";
            lbTrademark.ValueMember = "code";
        }

        private void lbTrademark_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTrademark.SelectedIndex == -1) return;
            setTitleData();
            loadPhone();
            setDataText();
        }

        private void dgvPhone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvPhone.CurrentCell.RowIndex == -1) return;
            //try
            //{
            //    var row = dgvPhone.Rows[dgvPhone.CurrentCell.RowIndex];
            //    var products = dataContext.products;
            //    var phone = products.FirstOrDefault(p => p.id == int.Parse(row.Cells[0].Value.ToString()));
            //    if (phone.image == null)
            //    {
            //        picImage.Image = Image.FromFile(@"F:\images\open.png");
            //        return;
            //    }
            //    var buff = phone.image.ToArray();
            //    MemoryStream stream = new MemoryStream(buff);
            //    Image img = Image.FromStream(stream);
            //    picImage.Image = img;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Có lỗi xảy ra." + ex.Message);
            //    return;
            //}
        }

        private void picImage_DoubleClick(object sender, EventArgs e)
        {
            //var row = dgvPhone.Rows[dgvPhone.CurrentCell.RowIndex];
            //var products = dataContext.products;
            //var phone = products.FirstOrDefault(p => p.id == int.Parse(row.Cells[0].Value.ToString()));

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image file (*.png)|*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(open.FileName);
                Image img = Image.FromFile(open.FileName);
                picImage.Image = img;
                //MemoryStream stream = new MemoryStream();
                //img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                //phone.image = stream.ToArray();
                //dataContext.SubmitChanges();
            }
        }
        private void edit(bool b)
        {
            txtCode.Enabled = b;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            txtDescription.Enabled = true;
            txtName.Enabled = true;
            picImage.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtCode.Enabled = true;
            txtCode.ResetText();
            txtDescription.ResetText();
            txtName.ResetText();
            picImage.Image = QLSanPham.Properties.Resources.open;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Text = "Hủy thêm";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataContext = new ManagerPhoneDataContext();
            if (String.IsNullOrWhiteSpace(txtCode.Text)
                || String.IsNullOrWhiteSpace(txtDescription.Text)
                || String.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Field is not null.");
                return;
            }
            if (btnUpdate.Enabled == false)
            {
                var row = dgvPhone.Rows[dgvPhone.CurrentCell.RowIndex];
                var products = dataContext.products;
                var phone = products.FirstOrDefault(p => p.id == int.Parse(row.Cells[0].Value.ToString()));
                phone.name = String.IsNullOrWhiteSpace(txtName.Text) ? "Chưa có tên" : txtName.Text;
                phone.description = String.IsNullOrWhiteSpace(txtDescription.Text) ? "Chưa có mô tả" : txtDescription.Text;
                if (picImage.Image == null)
                {
                    var img = QLSanPham.Properties.Resources.open;
                    MemoryStream stream = new MemoryStream();
                    img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    phone.image = stream.ToArray();
                }
                else
                {
                    MemoryStream stream = new MemoryStream();
                    picImage.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    phone.image = stream.ToArray();
                }
                dataContext.SubmitChanges();
                MessageBox.Show("Cập nhật thành công!");
                btnAdd.Enabled = true;
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Text = "Xóa";
                btnDelete.Enabled = true;
                frmMain_Load(sender, e);
            }
            else
            {
                var phone = new product();
                phone.code = txtCode.Text;
                phone.description = txtDescription.Text;
                phone.name = txtName.Text;
                MemoryStream stream = new MemoryStream();
                picImage.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                phone.image = stream.ToArray();
                phone.id = 0;
                phone.code_trademark = trademark;
                var products = dataContext.products;
                try
                {
                    products.InsertOnSubmit(phone);
                    dataContext.SubmitChanges();
                    MessageBox.Show("Thêm thành công!");
                    btnAdd.Enabled = true;
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Text = "Xóa";
                    frmMain_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại." + ex.Message);
                    return;
                }
            }
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Enabled == false)
            {
                btnAdd.Enabled = true;
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Text = "Xóa";
            }
            else
            {
                var ques = MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ques == DialogResult.Yes)
                {
                    var row = dgvPhone.Rows[dgvPhone.CurrentCell.RowIndex];
                    var products = dataContext.products;
                    var phone = products.FirstOrDefault(p => p.id == int.Parse(row.Cells[0].Value.ToString()));
                    products.DeleteOnSubmit(phone);
                    dataContext.SubmitChanges();
                    MessageBox.Show("Xóa thành công!" + phone.name);
                }
            }
            frmMain_Load(sender, e);
        }

        private void picImage_Click(object sender, EventArgs e)
        {

        }
    }
}
