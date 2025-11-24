namespace QuanLyHocSinh
{
    partial class FormQuanLyHocVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTenHocSinh = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnThemHocSinh = new System.Windows.Forms.Button();
            this.btnXoaHocSinh = new System.Windows.Forms.Button();
            this.btnSuaThongTinHocSinh = new System.Windows.Forms.Button();
            this.btnTimKiemHS = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtLopHoc = new System.Windows.Forms.TextBox();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMaHocSinh = new System.Windows.Forms.ComboBox();
            this.btnInThongTinHSTheoLop = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnHien = new System.Windows.Forms.Button();
            this.btnInThongTinHocSinh = new System.Windows.Forms.Button();
            this.btnInToanBo = new System.Windows.Forms.Button();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(171, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Học Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(171, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Học Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(171, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(171, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lớp Học";
            // 
            // txtHoTenHocSinh
            // 
            this.txtHoTenHocSinh.Location = new System.Drawing.Point(378, 73);
            this.txtHoTenHocSinh.Name = "txtHoTenHocSinh";
            this.txtHoTenHocSinh.Size = new System.Drawing.Size(200, 20);
            this.txtHoTenHocSinh.TabIndex = 6;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(378, 105);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // btnThemHocSinh
            // 
            this.btnThemHocSinh.Location = new System.Drawing.Point(610, 64);
            this.btnThemHocSinh.Name = "btnThemHocSinh";
            this.btnThemHocSinh.Size = new System.Drawing.Size(140, 23);
            this.btnThemHocSinh.TabIndex = 9;
            this.btnThemHocSinh.Text = "Thêm học sinh mới";
            this.btnThemHocSinh.UseVisualStyleBackColor = true;
            this.btnThemHocSinh.Click += new System.EventHandler(this.btnThemHocSinh_Click);
            // 
            // btnXoaHocSinh
            // 
            this.btnXoaHocSinh.Location = new System.Drawing.Point(610, 87);
            this.btnXoaHocSinh.Name = "btnXoaHocSinh";
            this.btnXoaHocSinh.Size = new System.Drawing.Size(140, 23);
            this.btnXoaHocSinh.TabIndex = 10;
            this.btnXoaHocSinh.Text = "Xóa Học Sinh";
            this.btnXoaHocSinh.UseVisualStyleBackColor = true;
            this.btnXoaHocSinh.Click += new System.EventHandler(this.btnXoaHocSinh_Click);
            // 
            // btnSuaThongTinHocSinh
            // 
            this.btnSuaThongTinHocSinh.Location = new System.Drawing.Point(610, 109);
            this.btnSuaThongTinHocSinh.Name = "btnSuaThongTinHocSinh";
            this.btnSuaThongTinHocSinh.Size = new System.Drawing.Size(140, 23);
            this.btnSuaThongTinHocSinh.TabIndex = 11;
            this.btnSuaThongTinHocSinh.Text = "Sửa Thông Tin Học Sinh";
            this.btnSuaThongTinHocSinh.UseVisualStyleBackColor = true;
            this.btnSuaThongTinHocSinh.Click += new System.EventHandler(this.btnSuaThongTinHocSinh_Click);
            // 
            // btnTimKiemHS
            // 
            this.btnTimKiemHS.Location = new System.Drawing.Point(610, 132);
            this.btnTimKiemHS.Name = "btnTimKiemHS";
            this.btnTimKiemHS.Size = new System.Drawing.Size(140, 23);
            this.btnTimKiemHS.TabIndex = 12;
            this.btnTimKiemHS.Text = "Tìm Kiếm Học Sinh";
            this.btnTimKiemHS.UseVisualStyleBackColor = true;
            this.btnTimKiemHS.Click += new System.EventHandler(this.btnTimKiemHS_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(165, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nhập Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(372, 214);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(609, 463);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(140, 23);
            this.btnLamMoi.TabIndex = 15;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtLopHoc
            // 
            this.txtLopHoc.Location = new System.Drawing.Point(378, 137);
            this.txtLopHoc.Name = "txtLopHoc";
            this.txtLopHoc.Size = new System.Drawing.Size(200, 20);
            this.txtLopHoc.TabIndex = 16;
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Location = new System.Drawing.Point(174, 262);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.RowHeadersWidth = 82;
            this.dgvHocSinh.Size = new System.Drawing.Size(582, 192);
            this.dgvHocSinh.TabIndex = 17;
            this.dgvHocSinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellContentClick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMaHocSinh);
            this.groupBox1.Controls.Add(this.btnInThongTinHSTheoLop);
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.btnHien);
            this.groupBox1.Controls.Add(this.btnInThongTinHocSinh);
            this.groupBox1.Controls.Add(this.btnThemHocSinh);
            this.groupBox1.Controls.Add(this.btnInToanBo);
            this.groupBox1.Controls.Add(this.txtGioiTinh);
            this.groupBox1.Controls.Add(this.txtQueQuan);
            this.groupBox1.Controls.Add(this.btnXoaHocSinh);
            this.groupBox1.Controls.Add(this.btnSuaThongTinHocSinh);
            this.groupBox1.Controls.Add(this.btnTimKiemHS);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(872, 505);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Học Viên";
            // 
            // cbMaHocSinh
            // 
            this.cbMaHocSinh.FormattingEnabled = true;
            this.cbMaHocSinh.Location = new System.Drawing.Point(372, 35);
            this.cbMaHocSinh.Name = "cbMaHocSinh";
            this.cbMaHocSinh.Size = new System.Drawing.Size(200, 21);
            this.cbMaHocSinh.TabIndex = 26;
            // 
            // btnInThongTinHSTheoLop
            // 
            this.btnInThongTinHSTheoLop.Location = new System.Drawing.Point(610, 176);
            this.btnInThongTinHSTheoLop.Margin = new System.Windows.Forms.Padding(2);
            this.btnInThongTinHSTheoLop.Name = "btnInThongTinHSTheoLop";
            this.btnInThongTinHSTheoLop.Size = new System.Drawing.Size(140, 23);
            this.btnInThongTinHSTheoLop.TabIndex = 25;
            this.btnInThongTinHSTheoLop.Text = "In thông tin HS theo lớp";
            this.btnInThongTinHSTheoLop.UseVisualStyleBackColor = true;
            this.btnInThongTinHSTheoLop.Click += new System.EventHandler(this.btnInThongTinHSTheoLop_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(2, 481);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(868, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btnHien
            // 
            this.btnHien.Location = new System.Drawing.Point(610, 42);
            this.btnHien.Name = "btnHien";
            this.btnHien.Size = new System.Drawing.Size(140, 23);
            this.btnHien.TabIndex = 23;
            this.btnHien.Text = "Hiện Thông Tin Học Sinh";
            this.btnHien.UseVisualStyleBackColor = true;
            this.btnHien.Click += new System.EventHandler(this.btnHien_Click);
            // 
            // btnInThongTinHocSinh
            // 
            this.btnInThongTinHocSinh.Location = new System.Drawing.Point(610, 154);
            this.btnInThongTinHocSinh.Name = "btnInThongTinHocSinh";
            this.btnInThongTinHocSinh.Size = new System.Drawing.Size(140, 23);
            this.btnInThongTinHocSinh.TabIndex = 22;
            this.btnInThongTinHocSinh.Text = "In Thông Tin Học SInh";
            this.btnInThongTinHocSinh.UseVisualStyleBackColor = true;
            this.btnInThongTinHocSinh.Click += new System.EventHandler(this.btnInThongTinHocSinh_Click);
            // 
            // btnInToanBo
            // 
            this.btnInToanBo.Location = new System.Drawing.Point(610, 199);
            this.btnInToanBo.Name = "btnInToanBo";
            this.btnInToanBo.Size = new System.Drawing.Size(140, 23);
            this.btnInToanBo.TabIndex = 21;
            this.btnInToanBo.Text = "In Toàn Bộ Thông Tin Học Sinh";
            this.btnInToanBo.UseVisualStyleBackColor = true;
            this.btnInToanBo.Click += new System.EventHandler(this.btnInToanBo_Click);
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(372, 157);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(200, 20);
            this.txtGioiTinh.TabIndex = 20;
            this.txtGioiTinh.TextChanged += new System.EventHandler(this.txtGioiTinh_TextChanged);
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(372, 185);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(200, 20);
            this.txtQueQuan.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(165, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Quê Quán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(165, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Giới Tính";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(168, 467);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(140, 23);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FormQuanLyHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(895, 520);
            this.Controls.Add(this.dgvHocSinh);
            this.Controls.Add(this.txtLopHoc);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtHoTenHocSinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQuanLyHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Học Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormQuanLyHocVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTenHocSinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnThemHocSinh;
        private System.Windows.Forms.Button btnXoaHocSinh;
        private System.Windows.Forms.Button btnSuaThongTinHocSinh;
        private System.Windows.Forms.Button btnTimKiemHS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtLopHoc;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInToanBo;
        private System.Windows.Forms.Button btnInThongTinHocSinh;
        private System.Windows.Forms.Button btnHien;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnInThongTinHSTheoLop;
        private System.Windows.Forms.ComboBox cbMaHocSinh;
    }
}

