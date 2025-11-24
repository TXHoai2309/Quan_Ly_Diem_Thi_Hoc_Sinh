namespace XemDiemHocSinh
{
    partial class FormXemDiemThiHocSinh
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
            this.txtTenHocSinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHocSinh = new System.Windows.Forms.TextBox();
            this.txtMaBaiThi = new System.Windows.Forms.TextBox();
            this.dtpNgayCham = new System.Windows.Forms.DateTimePicker();
            this.btnHienThiDiemThi = new System.Windows.Forms.Button();
            this.btnTimKiemDiemThi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvDiemThi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.drpNgayThi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemThi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaHocSinh
            // 
            this.lblMaHocSinh.AutoSize = true;
            this.lblMaHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaHocSinh.Location = new System.Drawing.Point(216, 96);
            this.lblMaHocSinh.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMaHocSinh.Name = "lblMaHocSinh";
            this.lblMaHocSinh.Size = new System.Drawing.Size(160, 30);
            this.lblMaHocSinh.TabIndex = 0;
            this.lblMaHocSinh.Text = "Mã Học Sinh";
            // 
            // txtTenHocSinh
            // 
            this.txtTenHocSinh.Enabled = false;
            this.txtTenHocSinh.Location = new System.Drawing.Point(474, 154);
            this.txtTenHocSinh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTenHocSinh.Name = "txtTenHocSinh";
            this.txtTenHocSinh.Size = new System.Drawing.Size(396, 31);
            this.txtTenHocSinh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(210, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Học Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(210, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Bài Thi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(210, 360);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Thi";
            // 
            // txtMaHocSinh
            // 
            this.txtMaHocSinh.Enabled = false;
            this.txtMaHocSinh.Location = new System.Drawing.Point(480, 88);
            this.txtMaHocSinh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMaHocSinh.Name = "txtMaHocSinh";
            this.txtMaHocSinh.Size = new System.Drawing.Size(396, 31);
            this.txtMaHocSinh.TabIndex = 5;
            this.txtMaHocSinh.TextChanged += new System.EventHandler(this.txtMaHocSinh_TextChanged);
            // 
            // txtMaBaiThi
            // 
            this.txtMaBaiThi.Location = new System.Drawing.Point(474, 217);
            this.txtMaBaiThi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMaBaiThi.Name = "txtMaBaiThi";
            this.txtMaBaiThi.Size = new System.Drawing.Size(396, 31);
            this.txtMaBaiThi.TabIndex = 6;
            // 
            // dtpNgayCham
            // 
            this.dtpNgayCham.Location = new System.Drawing.Point(474, 429);
            this.dtpNgayCham.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpNgayCham.Name = "dtpNgayCham";
            this.dtpNgayCham.Size = new System.Drawing.Size(396, 31);
            this.dtpNgayCham.TabIndex = 7;
            // 
            // btnHienThiDiemThi
            // 
            this.btnHienThiDiemThi.Location = new System.Drawing.Point(1164, 123);
            this.btnHienThiDiemThi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnHienThiDiemThi.Name = "btnHienThiDiemThi";
            this.btnHienThiDiemThi.Size = new System.Drawing.Size(356, 44);
            this.btnHienThiDiemThi.TabIndex = 8;
            this.btnHienThiDiemThi.Text = "Hiển Thị Toàn Bộ Điểm Thi";
            this.btnHienThiDiemThi.UseVisualStyleBackColor = true;
            this.btnHienThiDiemThi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTimKiemDiemThi
            // 
            this.btnTimKiemDiemThi.Location = new System.Drawing.Point(1164, 213);
            this.btnTimKiemDiemThi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTimKiemDiemThi.Name = "btnTimKiemDiemThi";
            this.btnTimKiemDiemThi.Size = new System.Drawing.Size(356, 44);
            this.btnTimKiemDiemThi.TabIndex = 9;
            this.btnTimKiemDiemThi.Text = "Tìm Kiếm Điểm Thi Theo Mã";
            this.btnTimKiemDiemThi.UseVisualStyleBackColor = true;
            this.btnTimKiemDiemThi.Click += new System.EventHandler(this.btnTimKiemDiemThi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1158, 377);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(356, 46);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvDiemThi
            // 
            this.dgvDiemThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemThi.Location = new System.Drawing.Point(120, 540);
            this.dgvDiemThi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvDiemThi.Name = "dgvDiemThi";
            this.dgvDiemThi.RowHeadersWidth = 82;
            this.dgvDiemThi.Size = new System.Drawing.Size(1560, 421);
            this.dgvDiemThi.TabIndex = 11;
            this.dgvDiemThi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaBaiThi);
            this.groupBox1.Controls.Add(this.dgvDiemThi);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtTenHocSinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.drpNgayThi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpNgayCham);
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1756, 1050);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xem Điểm Thi Học Sinh";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(6, 1022);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1744, 22);
            this.statusStrip1.TabIndex = 14;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 12);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Location = new System.Drawing.Point(474, 290);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(396, 31);
            this.txtMaLop.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(208, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã Lớp";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1158, 292);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(356, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "In toàn bộ điểm thi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // drpNgayThi
            // 
            this.drpNgayThi.Location = new System.Drawing.Point(474, 358);
            this.drpNgayThi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.drpNgayThi.Name = "drpNgayThi";
            this.drpNgayThi.Size = new System.Drawing.Size(396, 31);
            this.drpNgayThi.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(210, 429);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ngày Chấm";
            // 
            // FormXemDiemThiHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1768, 1062);
            this.Controls.Add(this.btnTimKiemDiemThi);
            this.Controls.Add(this.btnHienThiDiemThi);
            this.Controls.Add(this.txtMaHocSinh);
            this.Controls.Add(this.lblMaHocSinh);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormXemDiemThiHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Điểm Thi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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

        private System.Windows.Forms.Label lblMaHocSinh;
        private System.Windows.Forms.TextBox txtTenHocSinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHocSinh;
        private System.Windows.Forms.TextBox txtMaBaiThi;
        private System.Windows.Forms.DateTimePicker dtpNgayCham;
        private System.Windows.Forms.Button btnHienThiDiemThi;
        private System.Windows.Forms.Button btnTimKiemDiemThi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvDiemThi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker drpNgayThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

