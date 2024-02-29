namespace Thuchanh1
{
    partial class FHocSinh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ucThongTin1 = new Thuchanh1_1.UCThongTin();
            btnGiaoVien = new Button();
            SuspendLayout();
            // 
            // ucThongTin1
            // 
            ucThongTin1.dateTimePicker = new DateTime(2024, 2, 28, 15, 29, 20, 883);
            ucThongTin1.Location = new Point(-9, -1);
            ucThongTin1.Name = "ucThongTin1";
            ucThongTin1.Size = new Size(1007, 572);
            ucThongTin1.TabIndex = 0;
            ucThongTin1.Load += FHocSinh_Load;
            // 
            // btnGiaoVien
            // 
            btnGiaoVien.Location = new Point(504, 345);
            btnGiaoVien.Name = "btnGiaoVien";
            btnGiaoVien.Size = new Size(94, 29);
            btnGiaoVien.TabIndex = 1;
            btnGiaoVien.Text = "GiaoVien";
            btnGiaoVien.UseVisualStyleBackColor = true;
            btnGiaoVien.Click += btnGiaoVien_Click;
            // 
            // FHocSinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 427);
            Controls.Add(btnGiaoVien);
            Controls.Add(ucThongTin1);
            Name = "FHocSinh";
            Text = "FHocSinh";
            Load += FHocSinh_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private Thuchanh1_1.UCThongTin ucThongTin1;
        private Button btnGiaoVien;
    }
}
