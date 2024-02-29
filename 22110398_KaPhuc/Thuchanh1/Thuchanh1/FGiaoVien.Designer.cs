using Thuchanh1;

namespace Thuchanh1_1
{
    partial class FGiaoVien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ucThongTin1 = new UCThongTin();
            btnHocSinh = new Button();
            SuspendLayout();
            // 
            // ucThongTin1
            // 
            ucThongTin1.dateTimePicker = new DateTime(2024, 2, 28, 17, 55, 56, 830);
            ucThongTin1.Location = new Point(-4, -12);
            ucThongTin1.Name = "ucThongTin1";
            ucThongTin1.Size = new Size(974, 480);
            ucThongTin1.TabIndex = 0;
            // 
            // btnHocSinh
            // 
            btnHocSinh.Location = new Point(515, 334);
            btnHocSinh.Name = "btnHocSinh";
            btnHocSinh.Size = new Size(94, 29);
            btnHocSinh.TabIndex = 2;
            btnHocSinh.Text = "HocSinh";
            btnHocSinh.UseVisualStyleBackColor = true;
            btnHocSinh.Click += this.btnHocSinh_Click_5;
            // 
            // FGiaoVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 450);
            Controls.Add(btnHocSinh);
            Controls.Add(ucThongTin1);
            Name = "FGiaoVien";
            Text = "FGiaoVien";
            Load += FGiaoVien_Load;
            ResumeLayout(false);
        }

        #endregion

        private UCThongTin ucThongTin1;
        private Button btnHocSinh;
        private void btnHocSinh_Click_5(object sender, EventArgs e)
{
            this.Hide();
            FHocSinh gv = new FHocSinh();
            gv.Show();
        }
    }
}