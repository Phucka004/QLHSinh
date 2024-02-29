using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuchanh1_1
{
    public class Nguoi
    {
        private string id;
        private string hoten;
        private string gioitinh;
        private string diachi;
        private string cmnd;
        private string email;
        private string sdt;
        private DateTime ngaysinh;

        public Nguoi(string id, string hoten, string gioiTinh, string diachi,string cmnd, string email, string sdt, DateTime ngaySinh)
        {
            this.id = id;
            this.hoten = hoten;
            this.gioitinh = gioiTinh;
            this.diachi = diachi;
            this.cmnd = cmnd;
            this.email = email;
            this.sdt = sdt;
            this.ngaysinh = ngaySinh;
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }

        }
        public string CMND
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
    }
}
