namespace DangNhapHocSinh
{
    partial class FormHocSinhDashboard
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
            this.lblMaHocSinh = new System.Windows.Forms.Label();
            this.btnLamBaiThi = new System.Windows.Forms.Button();
            this.btnXemDiemThi = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaHocSinh
            // 
            this.lblMaHocSinh.AutoSize = true;
            this.lblMaHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaHocSinh.Location = new System.Drawing.Point(282, 110);
            this.lblMaHocSinh.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMaHocSinh.Name = "lblMaHocSinh";
            this.lblMaHocSinh.Size = new System.Drawing.Size(0, 44);
            this.lblMaHocSinh.TabIndex = 0;
            // 
            // btnLamBaiThi
            // 
            this.btnLamBaiThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLamBaiThi.Location = new System.Drawing.Point(60, 273);
            this.btnLamBaiThi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLamBaiThi.Name = "btnLamBaiThi";
            this.btnLamBaiThi.Size = new System.Drawing.Size(366, 90);
            this.btnLamBaiThi.TabIndex = 1;
            this.btnLamBaiThi.Text = "Làm Bài Thi";
            this.btnLamBaiThi.UseVisualStyleBackColor = true;
            this.btnLamBaiThi.Click += new System.EventHandler(this.btnLamBaiThi_Click);
            // 
            // btnXemDiemThi
            // 
            this.btnXemDiemThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXemDiemThi.Location = new System.Drawing.Point(60, 450);
            this.btnXemDiemThi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnXemDiemThi.Name = "btnXemDiemThi";
            this.btnXemDiemThi.Size = new System.Drawing.Size(366, 90);
            this.btnXemDiemThi.TabIndex = 2;
            this.btnXemDiemThi.Text = "Xem Điểm Thi";
            this.btnXemDiemThi.UseVisualStyleBackColor = true;
            this.btnXemDiemThi.Click += new System.EventHandler(this.btnXemDiemThi_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.Location = new System.Drawing.Point(60, 812);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(366, 90);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnDoiMatKhau);
            this.groupBox1.Controls.Add(this.btnXemThongTin);
            this.groupBox1.Controls.Add(this.btnLamBaiThi);
            this.groupBox1.Controls.Add(this.btnXemDiemThi);
            this.groupBox1.Controls.Add(this.btnDangXuat);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(508, 1204);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Học Sinh";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(788, 217);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDoiMatKhau.Location = new System.Drawing.Point(60, 635);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(366, 90);
            this.btnDoiMatKhau.TabIndex = 5;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXemThongTin.Location = new System.Drawing.Point(60, 112);
            this.btnXemThongTin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(366, 90);
            this.btnXemThongTin.TabIndex = 4;
            this.btnXemThongTin.Text = "Xem Thông Tin";
            this.btnXemThongTin.UseVisualStyleBackColor = true;
            this.btnXemThongTin.Click += new System.EventHandler(this.btnXemThongTin_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(514, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1770, 1204);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // FormHocSinhDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2286, 1217);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblMaHocSinh);
            this.Controls.Add(this.groupBox1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormHocSinhDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập Học Sinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHocSinhDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaHocSinh;
        private System.Windows.Forms.Button btnLamBaiThi;
        private System.Windows.Forms.Button btnXemDiemThi;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

