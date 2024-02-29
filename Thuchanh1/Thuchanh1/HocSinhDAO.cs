using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;

namespace Thuchanh1_1
{
    public class HocSinhDAO
    {
        DBConnection dbc = new DBConnection();
        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT * FROM HocSinh");
            DataTable dtHocSinh = dbc.Load(sqlStr);
            return dtHocSinh;
        }
        public void Them(string Id, string Ten, string GioiTinh, string Diachi, string Cmnd, string email, string sdt, DateTime NgaySinh)
        {
            HocSinh hs = new HocSinh(Id, Ten, GioiTinh, Diachi, Cmnd, email, sdt,NgaySinh);
            string sqlStr = string.Format("INSERT INTO HOCSINH(ID, Ten, GioiTinh, DiaChi, CMND, Email, SDT, NgaySinh) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", hs.ID, hs.Hoten, hs.GioiTinh, hs.Diachi, hs.CMND, hs.Email, hs.SDT, hs.NgaySinh.ToString("MM-dd-yyyy"));
            dbc.KiemTra(Id, Ten, GioiTinh, Diachi, Cmnd, email, sdt, NgaySinh, sqlStr);
        }

        public void Xoa(string Id)
        {
            string sqlStr = string.Format("DELETE FROM HocSinh WHERE ID ='{0}'", Id);
            dbc.ThucThi(sqlStr);
        }

        public void Sua(string Id, string Ten, string GioiTinh, string Diachi, string Cmnd, string email, string sdt, DateTime NgaySinh)
        {
            HocSinh hs = new HocSinh(Id, Ten, GioiTinh, Diachi, Cmnd, email, sdt, NgaySinh);
            string sqlStr = string.Format("UPDATE HOCSINH SET Ten = '{0}',  GioiTinh = '{1}', DiaChi = '{2}', CMND = '{3}', Email = '{4}', SDT = '{5}', NgaySinh = '{6}' WHERE ID = {7}", hs.Hoten, hs.GioiTinh, hs.Diachi, hs.CMND, hs.Email, hs.SDT, hs.NgaySinh.ToString("MM-dd-yyyy"), hs.ID);
            dbc.ThucThi(sqlStr);

        }
    }
}
