using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThongTinSinhVien
{
    class SinhVien
    {
        private string maSinhVien;
        private string hoSinhVien;
        private string tenSinhVien;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string maKhoa;

        public SinhVien(string maSinhVien, string hoSinhVien, string tenSinhVien, DateTime ngaySinh, string gioiTinh, string maKhoa)
        {
            this.maSinhVien = maSinhVien;
            this.hoSinhVien = hoSinhVien;
            this.tenSinhVien = tenSinhVien;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.maKhoa = maKhoa;
        }

        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string TenSinhVien
        {
            get { return tenSinhVien; }
            set { tenSinhVien = value; }
        }

        public string HoSinhVien
        {
            get { return hoSinhVien; }
            set { hoSinhVien = value; }
        }

        public string MaSinhVien
        {
            get { return maSinhVien; }
            set { maSinhVien = value; }
        }

    }
}
