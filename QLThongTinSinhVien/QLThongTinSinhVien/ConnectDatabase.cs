using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLThongTinSinhVien
{
    class ConnectDatabase
    {
        public SqlConnection conn = null;
        String strConn = @"Data Source=DESKTOP-TJUO3UD;Initial Catalog=db_sinhvien;Integrated Security=True";
        
        public ConnectDatabase()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }
        public DataTable getData(String table)
        {
            DataTable data = new DataTable();
            string sql = "select * from "+table;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, this.conn);
            adapter.Fill(data);
            closeData();
            return data;
        }
        public bool insertSV(SinhVien sv)
        {
            conn.Open();
            string sql = "insert into sinh_vien values('"+sv.MaSinhVien+"'"
                + ", N'"+sv.HoSinhVien+"'"
                + ", N'" + sv.TenSinhVien + "'"
                + ",'" + sv.NgaySinh.ToString("d") + "'"
                + ", N'" + sv.GioiTinh + "'"
                + ",'" + sv.MaKhoa + "'"
                + ")";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, this.conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                closeData();
            }
            return true;
        }
        public bool updateSV(SinhVien sv)
        {
            conn.Open();
            string sql = "update sinh_vien set ho_sv=N'" + sv.HoSinhVien + "'"
               + ", ten_sv=N'" + sv.TenSinhVien + "'"
               + ",ngay_sinh='" + sv.NgaySinh.ToString("d") + "'"
               + ", gioi_tinh=N'" + sv.GioiTinh + "'"
               + ",ma_khoa='" + sv.MaKhoa + "'"
               + " where ma_sv='" + sv.MaSinhVien + "'";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, this.conn);
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                closeData();
            }
            return true;
        }
        public bool deleteSV(String maSinhVien)
        {
            conn.Open();
            string sql = "delete from sinh_vien where ma_sv='"+maSinhVien+"'";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, this.conn);
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                closeData();
            }
            return true;
        }
        public void closeData()
        {
            this.conn.Close();
        }
    }
}
