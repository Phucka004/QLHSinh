using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuchanh1_1
{
    public class HocSinh : Nguoi
    { 
        public HocSinh(string _Id, string _hoten, string _gioiTinh, string _diachi, string _cmnd, string _email, string _sdt, DateTime NgaySinh) : base(_Id, _hoten, _gioiTinh, _diachi,_cmnd ,_email, _sdt, NgaySinh)
        {

        }
    }
}
