using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Thuchanh1_1;

namespace Thuchanh1
{
    public partial class FHocSinh : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QLHocSinh;Integrated Security=True;Encrypt=True");
        HocSinhDAO hsD = new HocSinhDAO();
        public FHocSinh()
        {
            InitializeComponent();
            ucThongTin1.XuatDanhSach.CellClick += XuatDanhSach_CellClick;
            ucThongTin1.BtnThem.Click += btnThem_Click;
            ucThongTin1.BtnSua.Click += btnSua_Click;
            ucThongTin1.BtnXoa.Click += btnXoa_Click;

        }
        //SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QLHocSinh;Integrated Security=True;Encrypt=True");
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from HocSinh";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            ucThongTin1.XuatDanhSach.DataSource = hsD.Load(); //đổ dữ liệu vào datagridview
        }
        private void FHocSinh_Load(object sender, EventArgs e)
        {
            ucThongTin1.XuatDanhSach.DataSource = hsD.Load();
            //ketnoicsdl();

        }
        private void ucThongTin1_Load(object sender, EventArgs e)
        {
        }
        private void XuatDanhSach_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (ucThongTin1.XuatDanhSach.CurrentRow.Cells[0].Value == null || ucThongTin1.XuatDanhSach.CurrentRow.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(ucThongTin1.XuatDanhSach.CurrentRow.Cells[0].Value.ToString()))
            {
                ucThongTin1.TxtID.Clear();
                ucThongTin1.TxtHoVaTen.Clear();
                ucThongTin1.Txtgioitinh.Clear();
                ucThongTin1.TxtDiaChi.Clear();
                ucThongTin1.TxtCMND.Clear();
                ucThongTin1.TxtEmail.Clear();
                ucThongTin1.TxtSDT.Clear();
                ucThongTin1.dateTimePicker = DateTime.Now;

            }
            else
            {
                ucThongTin1.TxtID.Text = ucThongTin1.XuatDanhSach.CurrentRow.Cells["Id"].Value.ToString();
                ucThongTin1.TxtHoVaTen.Text = ucThongTin1.XuatDanhSach.CurrentRow.Cells["Ten"].Value.ToString();
                ucThongTin1.Txtgioitinh.Text = ucThongTin1.XuatDanhSach.CurrentRow.Cells["Gioitinh"].Value.ToString();
                ucThongTin1.TxtDiaChi.Text = ucThongTin1.XuatDanhSach.CurrentRow.Cells["Diachi"].Value.ToString();
                ucThongTin1.TxtCMND.Text = ucThongTin1.XuatDanhSach.CurrentRow.Cells["Cmnd"].Value.ToString();
                ucThongTin1.TxtEmail.Text = ucThongTin1.XuatDanhSach.CurrentRow.Cells["Email"].Value.ToString();
                ucThongTin1.TxtSDT.Text = ucThongTin1.XuatDanhSach.CurrentRow.Cells["SDT"].Value.ToString();
                ucThongTin1.dateTimePicker = Convert.ToDateTime(ucThongTin1.XuatDanhSach.CurrentRow.Cells["Ngaysinh"].Value);


            }
        }
        private void btnThem_Click(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                hsD.Them(ucThongTin1.TxtID.Text, ucThongTin1.TxtHoVaTen.Text, ucThongTin1.Txtgioitinh.Text, ucThongTin1.TxtDiaChi.Text, ucThongTin1.TxtCMND.Text, ucThongTin1.TxtEmail.Text, ucThongTin1.TxtSDT.Text, ucThongTin1.dateTimePicker);
                FHocSinh_Load(sender, e);
            }
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                hsD.Xoa(ucThongTin1.TxtID.Text);
                FHocSinh_Load(sender, e);
            }
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                hsD.Sua(ucThongTin1.TxtID.Text, ucThongTin1.TxtHoVaTen.Text, ucThongTin1.Txtgioitinh.Text, ucThongTin1.TxtDiaChi.Text, ucThongTin1.TxtCMND.Text, ucThongTin1.TxtEmail.Text, ucThongTin1.TxtSDT.Text, ucThongTin1.dateTimePicker);
                FHocSinh_Load(sender, e);
            }
        }

        private void FHocSinh_Load_1(object sender, EventArgs e)
        {

        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            FGiaoVien gv = new FGiaoVien();
            gv.Show();
        }
    }
}
