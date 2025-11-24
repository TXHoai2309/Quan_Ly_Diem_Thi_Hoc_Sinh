namespace QuanLyCauHoi
{
    partial class FormQuanLyCauHoi
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.txtMaCauHoi = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtDapAnDung = new System.Windows.Forms.TextBox();
            this.btnTimKiemCauHoi = new System.Windows.Forms.Button();
            this.btnSuaCauHoi = new System.Windows.Forms.Button();
            this.btnXoaCauHoi = new System.Windows.Forms.Button();
            this.btnThemVaoBaiThi = new System.Windows.Forms.Button();
            this.btnThemCauHoi = new System.Windows.Forms.Button();
            this.btnXoaKhoiBaiThi = new System.Windows.Forms.Button();
            this.btnHienThiChiTietBaiThi = new System.Windows.Forms.Button();
            this.btnHienThiChiTiet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMaBaithi = new System.Windows.Forms.ComboBox();
            this.cbDoKho = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Câu Hỏi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nội Dung Câu Hỏi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Độ Khó";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đáp Án Đúng";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(77, 234);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 82;
            this.dgvDanhSach.Size = new System.Drawing.Size(730, 239);
            this.dgvDanhSach.TabIndex = 5;
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // txtMaCauHoi
            // 
            this.txtMaCauHoi.Location = new System.Drawing.Point(262, 64);
            this.txtMaCauHoi.Name = "txtMaCauHoi";
            this.txtMaCauHoi.Size = new System.Drawing.Size(100, 20);
            this.txtMaCauHoi.TabIndex = 6;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(262, 97);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(164, 20);
            this.txtNoiDung.TabIndex = 7;
            // 
            // txtDapAnDung
            // 
            this.txtDapAnDung.Location = new System.Drawing.Point(628, 97);
            this.txtDapAnDung.Name = "txtDapAnDung";
            this.txtDapAnDung.Size = new System.Drawing.Size(131, 20);
            this.txtDapAnDung.TabIndex = 9;
            // 
            // btnTimKiemCauHoi
            // 
            this.btnTimKiemCauHoi.Location = new System.Drawing.Point(479, 186);
            this.btnTimKiemCauHoi.Name = "btnTimKiemCauHoi";
            this.btnTimKiemCauHoi.Size = new System.Drawing.Size(108, 23);
            this.btnTimKiemCauHoi.TabIndex = 13;
            this.btnTimKiemCauHoi.Text = "Tìm Kiếm Câu Hỏi";
            this.btnTimKiemCauHoi.UseVisualStyleBackColor = true;
            this.btnTimKiemCauHoi.Click += new System.EventHandler(this.btnTimKiemCauHoi_Click);
            // 
            // btnSuaCauHoi
            // 
            this.btnSuaCauHoi.Location = new System.Drawing.Point(283, 151);
            this.btnSuaCauHoi.Name = "btnSuaCauHoi";
            this.btnSuaCauHoi.Size = new System.Drawing.Size(144, 23);
            this.btnSuaCauHoi.TabIndex = 14;
            this.btnSuaCauHoi.Text = "Sửa Câu Hỏi";
            this.btnSuaCauHoi.UseVisualStyleBackColor = true;
            this.btnSuaCauHoi.Click += new System.EventHandler(this.btnSuaCauHoi_Click);
            // 
            // btnXoaCauHoi
            // 
            this.btnXoaCauHoi.Location = new System.Drawing.Point(479, 144);
            this.btnXoaCauHoi.Name = "btnXoaCauHoi";
            this.btnXoaCauHoi.Size = new System.Drawing.Size(109, 23);
            this.btnXoaCauHoi.TabIndex = 15;
            this.btnXoaCauHoi.Text = "Xóa Câu Hỏi";
            this.btnXoaCauHoi.UseVisualStyleBackColor = true;
            this.btnXoaCauHoi.Click += new System.EventHandler(this.btnXoaCauHoi_Click);
            // 
            // btnThemVaoBaiThi
            // 
            this.btnThemVaoBaiThi.Location = new System.Drawing.Point(77, 193);
            this.btnThemVaoBaiThi.Name = "btnThemVaoBaiThi";
            this.btnThemVaoBaiThi.Size = new System.Drawing.Size(142, 23);
            this.btnThemVaoBaiThi.TabIndex = 16;
            this.btnThemVaoBaiThi.Text = "Thêm Câu Hỏi Vào Bài Thi";
            this.btnThemVaoBaiThi.UseVisualStyleBackColor = true;
            this.btnThemVaoBaiThi.Click += new System.EventHandler(this.btnThemVaoBaiThi_Click);
            // 
            // btnThemCauHoi
            // 
            this.btnThemCauHoi.Location = new System.Drawing.Point(702, 151);
            this.btnThemCauHoi.Name = "btnThemCauHoi";
            this.btnThemCauHoi.Size = new System.Drawing.Size(105, 23);
            this.btnThemCauHoi.TabIndex = 17;
            this.btnThemCauHoi.Text = "Thêm Câu Hỏi";
            this.btnThemCauHoi.UseVisualStyleBackColor = true;
            this.btnThemCauHoi.Click += new System.EventHandler(this.btnThemCauHoi_Click);
            // 
            // btnXoaKhoiBaiThi
            // 
            this.btnXoaKhoiBaiThi.Location = new System.Drawing.Point(663, 193);
            this.btnXoaKhoiBaiThi.Name = "btnXoaKhoiBaiThi";
            this.btnXoaKhoiBaiThi.Size = new System.Drawing.Size(144, 23);
            this.btnXoaKhoiBaiThi.TabIndex = 18;
            this.btnXoaKhoiBaiThi.Text = "Xóa Câu Hỏi Khỏi Bài Thi";
            this.btnXoaKhoiBaiThi.UseVisualStyleBackColor = true;
            this.btnXoaKhoiBaiThi.Click += new System.EventHandler(this.btnXoaKhoiBaiThi_Click);
            // 
            // btnHienThiChiTietBaiThi
            // 
            this.btnHienThiChiTietBaiThi.Location = new System.Drawing.Point(77, 151);
            this.btnHienThiChiTietBaiThi.Name = "btnHienThiChiTietBaiThi";
            this.btnHienThiChiTietBaiThi.Size = new System.Drawing.Size(142, 23);
            this.btnHienThiChiTietBaiThi.TabIndex = 19;
            this.btnHienThiChiTietBaiThi.Text = "Hiển Thị Các Câu Hỏi";
            this.btnHienThiChiTietBaiThi.UseVisualStyleBackColor = true;
            this.btnHienThiChiTietBaiThi.Click += new System.EventHandler(this.btnHienThiChiTietBaiThi_Click);
            // 
            // btnHienThiChiTiet
            // 
            this.btnHienThiChiTiet.Location = new System.Drawing.Point(277, 186);
            this.btnHienThiChiTiet.Name = "btnHienThiChiTiet";
            this.btnHienThiChiTiet.Size = new System.Drawing.Size(143, 23);
            this.btnHienThiChiTiet.TabIndex = 20;
            this.btnHienThiChiTiet.Text = "Hiển Thị Chi Tiết Bài Thi";
            this.btnHienThiChiTiet.UseVisualStyleBackColor = true;
            this.btnHienThiChiTiet.Click += new System.EventHandler(this.btnHienThiChiTiet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã Bài Thi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.cbMaBaithi);
            this.groupBox1.Controls.Add(this.cbDoKho);
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnXoaCauHoi);
            this.groupBox1.Controls.Add(this.btnHienThiChiTiet);
            this.groupBox1.Controls.Add(this.btnTimKiemCauHoi);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(872, 555);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Câu Hỏi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbMaBaithi
            // 
            this.cbMaBaithi.FormattingEnabled = true;
            this.cbMaBaithi.Location = new System.Drawing.Point(622, 56);
            this.cbMaBaithi.Name = "cbMaBaithi";
            this.cbMaBaithi.Size = new System.Drawing.Size(121, 21);
            this.cbMaBaithi.TabIndex = 24;
            // 
            // cbDoKho
            // 
            this.cbDoKho.FormattingEnabled = true;
            this.cbDoKho.Location = new System.Drawing.Point(468, 60);
            this.cbDoKho.Margin = new System.Windows.Forms.Padding(2);
            this.cbDoKho.Name = "cbDoKho";
            this.cbDoKho.Size = new System.Drawing.Size(38, 21);
            this.cbDoKho.TabIndex = 23;
            this.cbDoKho.SelectedIndexChanged += new System.EventHandler(this.cbDoKho_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(2, 531);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(868, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(389, 488);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(606, 144);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 25;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // FormQuanLyCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 552);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHienThiChiTietBaiThi);
            this.Controls.Add(this.btnXoaKhoiBaiThi);
            this.Controls.Add(this.btnThemCauHoi);
            this.Controls.Add(this.btnThemVaoBaiThi);
            this.Controls.Add(this.btnSuaCauHoi);
            this.Controls.Add(this.txtDapAnDung);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtMaCauHoi);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQuanLyCauHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Câu Hỏi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormQuanLyCauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.TextBox txtMaCauHoi;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtDapAnDung;
        private System.Windows.Forms.Button btnTimKiemCauHoi;
        private System.Windows.Forms.Button btnSuaCauHoi;
        private System.Windows.Forms.Button btnXoaCauHoi;
        private System.Windows.Forms.Button btnThemVaoBaiThi;
        private System.Windows.Forms.Button btnThemCauHoi;
        private System.Windows.Forms.Button btnXoaKhoiBaiThi;
        private System.Windows.Forms.Button btnHienThiChiTietBaiThi;
        private System.Windows.Forms.Button btnHienThiChiTiet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox cbDoKho;
        private System.Windows.Forms.ComboBox cbMaBaithi;
        private System.Windows.Forms.Button btnLamMoi;
    }
}

