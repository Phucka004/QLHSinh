﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuchanh1_1
{
    internal class GiaoVienDAO
    {
        DBConnection dbc = new DBConnection();
        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT * FROM GiaoVien");
            DataTable dtGiaoVien = dbc.Load(sqlStr);
            return dtGiaoVien;
        }
        public void Them(string Id, string Ten, string GioiTinh, string Diachi, string Cmnd, string email, string sdt, DateTime NgaySinh)
        {
            HocSinh hs = new HocSinh(Id, Ten, GioiTinh, Diachi, Cmnd, email, sdt, NgaySinh);
            string sqlStr = string.Format("INSERT INTO GiaoVien(ID, Ten, GioiTinh, DiaChi, CMND, Email, SDT, NgaySinh) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", hs.ID, hs.Hoten, hs.GioiTinh, hs.Diachi, hs.CMND, hs.Email, hs.SDT, hs.NgaySinh.ToString("MM-dd-yyyy"));
            dbc.KiemTra(Id, Ten, GioiTinh, Diachi, Cmnd, email, sdt, NgaySinh, sqlStr);
        }

        public void Xoa(string Id)
        {
            string sqlStr = string.Format("DELETE FROM GiaoVien WHERE ID ='{0}'", Id);
            dbc.ThucThi(sqlStr);
        }

        public void Sua(string Id, string Ten, string GioiTinh, string Diachi, string Cmnd, string email, string sdt, DateTime NgaySinh)
        {
            HocSinh hs = new HocSinh(Id, Ten, GioiTinh, Diachi, Cmnd, email, sdt, NgaySinh);
            string sqlStr = string.Format("UPDATE GiaoVien SET Ten = '{0}',  GioiTinh = '{1}', DiaChi = '{2}', CMND = '{3}', Email = '{4}', SDT = '{5}', NgaySinh = '{6}' WHERE ID = {7}", hs.Hoten, hs.GioiTinh, hs.Diachi, hs.CMND, hs.Email, hs.SDT, hs.NgaySinh.ToString("MM-dd-yyyy"), hs.ID);
            dbc.ThucThi(sqlStr);

        }
    }
}
