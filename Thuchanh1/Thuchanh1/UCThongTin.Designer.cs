namespace Thuchanh1_1
{
    partial class UCThongTin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblid = new Label();
            lblHoTen = new Label();
            lblGioiTinh = new Label();
            lblDiachi = new Label();
            lblemail = new Label();
            lblsdt = new Label();
            lblNgaySinh = new Label();
            txtId = new TextBox();
            txtHoTen = new TextBox();
            txtGioiTinh = new TextBox();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtsdt = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            IbICmnd = new Label();
            txtCmnd = new TextBox();
            XuatDanhSach = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)XuatDanhSach).BeginInit();
            SuspendLayout();
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(72, 41);
            lblid.Name = "lblid";
            lblid.Size = new Size(24, 20);
            lblid.TabIndex = 0;
            lblid.Text = "ID";
            lblid.Click += label1_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(72, 70);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(73, 20);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ và tên";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(72, 102);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(65, 20);
            lblGioiTinh.TabIndex = 2;
            lblGioiTinh.Text = "Giới tính";
            // 
            // lblDiachi
            // 
            lblDiachi.AutoSize = true;
            lblDiachi.Location = new Point(72, 135);
            lblDiachi.Name = "lblDiachi";
            lblDiachi.Size = new Size(55, 20);
            lblDiachi.TabIndex = 3;
            lblDiachi.Text = "Địa chỉ";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(72, 196);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(46, 20);
            lblemail.TabIndex = 4;
            lblemail.Text = "Email";
            // 
            // lblsdt
            // 
            lblsdt.AutoSize = true;
            lblsdt.Location = new Point(72, 224);
            lblsdt.Name = "lblsdt";
            lblsdt.Size = new Size(36, 20);
            lblsdt.TabIndex = 5;
            lblsdt.Text = "SĐT";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(72, 261);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(149, 20);
            lblNgaySinh.TabIndex = 6;
            lblNgaySinh.Text = "Ngày tháng năm sinh";
            // 
            // txtId
            // 
            txtId.Location = new Point(151, 41);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 7;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(151, 70);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 8;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(151, 99);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(125, 27);
            txtGioiTinh.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(151, 132);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(125, 27);
            txtDiaChi.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(151, 193);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(151, 224);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(125, 27);
            txtsdt.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(72, 284);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(72, 346);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(217, 346);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(359, 346);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // IbICmnd
            // 
            IbICmnd.AutoSize = true;
            IbICmnd.Location = new Point(72, 165);
            IbICmnd.Name = "IbICmnd";
            IbICmnd.Size = new Size(53, 20);
            IbICmnd.TabIndex = 18;
            IbICmnd.Text = "CMND";
            // 
            // txtCmnd
            // 
            txtCmnd.Location = new Point(151, 162);
            txtCmnd.Name = "txtCmnd";
            txtCmnd.Size = new Size(125, 27);
            txtCmnd.TabIndex = 19;
            // 
            // XuatDanhSach
            // 
            XuatDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            XuatDanhSach.Location = new Point(334, 41);
            XuatDanhSach.Name = "XuatDanhSach";
            XuatDanhSach.RowHeadersWidth = 51;
            XuatDanhSach.Size = new Size(607, 270);
            XuatDanhSach.TabIndex = 14;
            XuatDanhSach.CellContentClick += XuatDanhSach_CellContentClick;
            // 
            // UCThongTin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtCmnd);
            Controls.Add(IbICmnd);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(XuatDanhSach);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtsdt);
            Controls.Add(txtEmail);
            Controls.Add(txtDiaChi);
            Controls.Add(txtGioiTinh);
            Controls.Add(txtHoTen);
            Controls.Add(txtId);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblsdt);
            Controls.Add(lblemail);
            Controls.Add(lblDiachi);
            Controls.Add(lblGioiTinh);
            Controls.Add(lblHoTen);
            Controls.Add(lblid);
            Name = "UCThongTin";
            Size = new Size(991, 450);
            Load += UCThongTin_Load;
            ((System.ComponentModel.ISupportInitialize)XuatDanhSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblid;
        private Label lblHoTen;
        private Label lblGioiTinh;
        private Label lblDiachi;
        private Label lblemail;
        private Label lblsdt;
        private Label lblNgaySinh;
        private TextBox txtId;
        private TextBox txtHoTen;
        private TextBox txtGioiTinh;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtsdt;
        private DateTimePicker dateTimePicker1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Label IbICmnd;
        private TextBox txtCmnd;
        public DataGridView XuatDanhSach;
    }
}
