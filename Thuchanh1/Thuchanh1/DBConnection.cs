using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Thuchanh1_1
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public DataTable Load(string sqlStr)
        {
            DataTable dtSinhVien = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dtSinhVien);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtSinhVien;
        }
        public void ThucThi(string sqlStr)
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thực hiện thao tác THÀNH CÔNG!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực hiện thao tác THẤT BẠI!" + ex);
            }
            finally
            {
                conn.Close();
            }

        }
        private bool KiemTraRong(string Id, string HoTen, string GioiTinh, string Diachi, string Cmnd, string email, string sdt, DateTime NgaySinh)
        {
            if (string.IsNullOrEmpty(Id) || string.IsNullOrEmpty(HoTen) || string.IsNullOrEmpty(GioiTinh) ||
            string.IsNullOrEmpty(Diachi) || string.IsNullOrEmpty(Cmnd) ||
            string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sdt) || NgaySinh == DateTime.MinValue)
            {
                return false;
            }
            return true;
        }
        private bool DieuKienTuoi(DateTime ngaySinh)
        {
            DateTime ngayHienTai = DateTime.Today;

            // Tính tuổi bằng cách so sánh ngày sinh và ngày hiện tại
            int tuoi = ngayHienTai.Year - ngaySinh.Year;
            if (ngaySinh > ngayHienTai.AddYears(-tuoi))
                tuoi--;

            // Kiểm tra nếu tuổi lớn hơn hoặc bằng 17
            return tuoi >= 17;
        }
        private bool DinhDangEmail(string email)
        {
            Regex emailKtra = new Regex(@"@gmail.com");
            return emailKtra.IsMatch(email);
        }
        private bool DinhDangSDT(string sdt)
        {

            Regex regex = new Regex(@"^\d{3}-\d{4}-\d{3}$");
            return regex.IsMatch(sdt);
        }
        public void KiemTra(string Id, string HoTen, string GioiTinh, string Diachi, string Cmnd, string email, string sdt, DateTime NgaySinh, string sqlStr)
        {
            if (KiemTraRong(Id, HoTen,GioiTinh,Diachi,Cmnd,email,sdt,NgaySinh) == false)
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin!!!");
            if (DinhDangSDT(sdt) == false)
                MessageBox.Show("Số điện thoại không đúng định dạng 'xxx-xxxx-xxx'");
            if (DinhDangEmail(email) == false)
                MessageBox.Show("Email không đúng định dạng ");
            if (DieuKienTuoi(NgaySinh) == false)
                MessageBox.Show("Học sinh chưa đủ 17 tuổi");
            else
                ThucThi(sqlStr);

        }
    }
}
