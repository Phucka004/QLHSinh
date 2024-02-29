using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Thuchanh1_1
{
    public partial class UCThongTin : UserControl
    {

        public UCThongTin()
        {
            InitializeComponent();
        }
        public UCThongTin(TextBox txtID, DataGridView XuatDanhSach, Button btnThem, Button btnXoa, Button btnSua, TextBox txtCMND, TextBox txtDiaChi, TextBox txtHoVaTen, DateTimePicker dateTimePicker, TextBox txtGioitinh, TextBox txtSDT, TextBox txtEmail)
        {
            this.txtId = txtID;
            this.XuatDanhSach = XuatDanhSach;
            this.btnThem = btnThem;
            this.btnXoa = btnXoa;
            this.btnSua = btnSua;
            this.txtCmnd = txtCMND;
            this.txtDiaChi = txtDiaChi;
            this.txtHoTen = txtHoVaTen;
            this.dateTimePicker1.Value = dateTimePicker.Value;
            this.txtGioiTinh = txtGioitinh;
            this.txtsdt = txtSDT;
            this.txtEmail = txtEmail;
        }
        public TextBox TxtID
        {
            get { return txtId; }
            set { txtId = value; }
        }
        public TextBox TxtHoVaTen
        {
            get { return txtHoTen; }
            set { txtHoTen = value; }
        }
        public TextBox Txtgioitinh
        {
            get { return txtGioiTinh; }
            set { txtGioiTinh = value; }
        }
        public TextBox TxtDiaChi
        {
            get { return txtDiaChi; }
            set { txtDiaChi = value; }
        }
        public TextBox TxtCMND
        {
            get { return txtCmnd; }
            set { txtCmnd = value; }
        }
        public DateTime dateTimePicker
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }
        public TextBox TxtEmail
        {
            get { return txtEmail; }
            set { txtEmail = value; }
        }
        public TextBox TxtSDT
        {
            get { return txtsdt; }
            set { txtsdt = value; }
        }

        public Button BtnThem
        {
            get { return btnThem; }
            set { btnThem = value; }
        }
        public Button BtnXoa
        {
            get { return btnXoa; }
            set { btnXoa = value; }
        }
        public Button BtnSua
        {
            get { return btnSua; }
            set { btnSua = value; }
        }
        public DataGridView XuatKetQua
        {
            get { return XuatDanhSach; }
            set { XuatDanhSach = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UCThongTin_Load(object sender, EventArgs e)
        {

        }

        private void XuatDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
