namespace QuanLyDIemThiHocSinh
{
    partial class FormQuanLyDIemThi
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
            this.dgvDiemThi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayCham = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoTenHocSinh = new System.Windows.Forms.TextBox();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.btnHienThiDiem = new System.Windows.Forms.Button();
            this.btnTimKiemDIemThi = new System.Windows.Forms.Button();
            this.btnCapNhapDiemThi = new System.Windows.Forms.Button();
            this.btnXoaDiemThi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMaBaiThi = new System.Windows.Forms.ComboBox();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.cbMaHocSinh = new System.Windows.Forms.ComboBox();
            this.btnInBangDiemHocSinh = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpNgayThi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemThi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiemThi
            // 
            this.dgvDiemThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemThi.Location = new System.Drawing.Point(40, 258);
            this.dgvDiemThi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDiemThi.Name = "dgvDiemThi";
            this.dgvDiemThi.RowHeadersWidth = 82;
            this.dgvDiemThi.RowTemplate.Height = 33;
            this.dgvDiemThi.Size = new System.Drawing.Size(754, 262);
            this.dgvDiemThi.TabIndex = 0;
            this.dgvDiemThi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiemThi_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Học Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên Học Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Bài Thi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Điểm Thi";
            // 
            // dtpNgayCham
            // 
            this.dtpNgayCham.Location = new System.Drawing.Point(202, 202);
            this.dtpNgayCham.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayCham.Name = "dtpNgayCham";
            this.dtpNgayCham.Size = new System.Drawing.Size(148, 20);
            this.dtpNgayCham.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày Chấm";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtHoTenHocSinh
            // 
            this.txtHoTenHocSinh.Location = new System.Drawing.Point(202, 68);
            this.txtHoTenHocSinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTenHocSinh.Name = "txtHoTenHocSinh";
            this.txtHoTenHocSinh.Size = new System.Drawing.Size(148, 20);
            this.txtHoTenHocSinh.TabIndex = 9;
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Location = new System.Drawing.Point(202, 149);
            this.txtDiemThi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(148, 20);
            this.txtDiemThi.TabIndex = 12;
            // 
            // btnHienThiDiem
            // 
            this.btnHienThiDiem.Location = new System.Drawing.Point(513, 45);
            this.btnHienThiDiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnHienThiDiem.Name = "btnHienThiDiem";
            this.btnHienThiDiem.Size = new System.Drawing.Size(156, 21);
            this.btnHienThiDiem.TabIndex = 13;
            this.btnHienThiDiem.Text = "Hiện Thị Điểm Thi";
            this.btnHienThiDiem.UseVisualStyleBackColor = true;
            this.btnHienThiDiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTimKiemDIemThi
            // 
            this.btnTimKiemDIemThi.Location = new System.Drawing.Point(513, 66);
            this.btnTimKiemDIemThi.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemDIemThi.Name = "btnTimKiemDIemThi";
            this.btnTimKiemDIemThi.Size = new System.Drawing.Size(156, 21);
            this.btnTimKiemDIemThi.TabIndex = 14;
            this.btnTimKiemDIemThi.Text = "Tìm Kiếm Điểm Thi";
            this.btnTimKiemDIemThi.UseVisualStyleBackColor = true;
            this.btnTimKiemDIemThi.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCapNhapDiemThi
            // 
            this.btnCapNhapDiemThi.Location = new System.Drawing.Point(513, 86);
            this.btnCapNhapDiemThi.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhapDiemThi.Name = "btnCapNhapDiemThi";
            this.btnCapNhapDiemThi.Size = new System.Drawing.Size(156, 21);
            this.btnCapNhapDiemThi.TabIndex = 15;
            this.btnCapNhapDiemThi.Text = "Cập Nhập Điểm Thi";
            this.btnCapNhapDiemThi.UseVisualStyleBackColor = true;
            this.btnCapNhapDiemThi.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnXoaDiemThi
            // 
            this.btnXoaDiemThi.Location = new System.Drawing.Point(513, 106);
            this.btnXoaDiemThi.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaDiemThi.Name = "btnXoaDiemThi";
            this.btnXoaDiemThi.Size = new System.Drawing.Size(156, 21);
            this.btnXoaDiemThi.TabIndex = 16;
            this.btnXoaDiemThi.Text = "Xóa Điểm Thi";
            this.btnXoaDiemThi.UseVisualStyleBackColor = true;
            this.btnXoaDiemThi.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(798, 487);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(65, 33);
            this.btnDong.TabIndex = 17;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMaBaiThi);
            this.groupBox1.Controls.Add(this.cbMaLop);
            this.groupBox1.Controls.Add(this.cbMaHocSinh);
            this.groupBox1.Controls.Add(this.btnInBangDiemHocSinh);
            this.groupBox1.Controls.Add(this.txtHoTenHocSinh);
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.dtpNgayThi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpNgayCham);
            this.groupBox1.Controls.Add(this.dgvDiemThi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDiemThi);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 546);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Điểm Thi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbMaBaiThi
            // 
            this.cbMaBaiThi.FormattingEnabled = true;
            this.cbMaBaiThi.Location = new System.Drawing.Point(202, 121);
            this.cbMaBaiThi.Name = "cbMaBaiThi";
            this.cbMaBaiThi.Size = new System.Drawing.Size(148, 21);
            this.cbMaBaiThi.TabIndex = 24;
            // 
            // cbMaLop
            // 
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(202, 95);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(148, 21);
            this.cbMaLop.TabIndex = 23;
            // 
            // cbMaHocSinh
            // 
            this.cbMaHocSinh.FormattingEnabled = true;
            this.cbMaHocSinh.Location = new System.Drawing.Point(202, 41);
            this.cbMaHocSinh.Name = "cbMaHocSinh";
            this.cbMaHocSinh.Size = new System.Drawing.Size(148, 21);
            this.cbMaHocSinh.TabIndex = 22;
            // 
            // btnInBangDiemHocSinh
            // 
            this.btnInBangDiemHocSinh.Location = new System.Drawing.Point(509, 122);
            this.btnInBangDiemHocSinh.Margin = new System.Windows.Forms.Padding(2);
            this.btnInBangDiemHocSinh.Name = "btnInBangDiemHocSinh";
            this.btnInBangDiemHocSinh.Size = new System.Drawing.Size(156, 21);
            this.btnInBangDiemHocSinh.TabIndex = 21;
            this.btnInBangDiemHocSinh.Text = "In bảng điểm học sinh";
            this.btnInBangDiemHocSinh.UseVisualStyleBackColor = true;
            this.btnInBangDiemHocSinh.Click += new System.EventHandler(this.btnInBangDiemHocSinh_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 521);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(862, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 38);
            this.button2.TabIndex = 19;
            this.button2.Text = "In bảng điểm của học sinh theo lớp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 38);
            this.button1.TabIndex = 18;
            this.button1.Text = "In bảng điểm của học sinh cả trường\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dtpNgayThi
            // 
            this.dtpNgayThi.Location = new System.Drawing.Point(202, 175);
            this.dtpNgayThi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayThi.Name = "dtpNgayThi";
            this.dtpNgayThi.Size = new System.Drawing.Size(148, 20);
            this.dtpNgayThi.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ngày Thi";
            // 
            // FormQuanLyDIemThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 552);
            this.Controls.Add(this.btnXoaDiemThi);
            this.Controls.Add(this.btnCapNhapDiemThi);
            this.Controls.Add(this.btnTimKiemDIemThi);
            this.Controls.Add(this.btnHienThiDiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormQuanLyDIemThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Ly Điểm Thi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemThi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiemThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayCham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoTenHocSinh;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.Button btnHienThiDiem;
        private System.Windows.Forms.Button btnTimKiemDIemThi;
        private System.Windows.Forms.Button btnCapNhapDiemThi;
        private System.Windows.Forms.Button btnXoaDiemThi;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgayThi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnInBangDiemHocSinh;
        private System.Windows.Forms.ComboBox cbMaBaiThi;
        private System.Windows.Forms.ComboBox cbMaLop;
        private System.Windows.Forms.ComboBox cbMaHocSinh;
    }
}

