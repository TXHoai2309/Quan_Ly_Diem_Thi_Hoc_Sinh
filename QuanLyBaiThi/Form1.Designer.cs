namespace QuanLyBaiThi
{
    partial class FormQuanLyBaiThi
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
            this.txtMaBaiThi = new System.Windows.Forms.TextBox();
            this.dgvBaiThi = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHienThiBaiThi = new System.Windows.Forms.Button();
            this.btnHienThiChiTiet = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaiThi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(228, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Bài Thi";
            // 
            // txtMaBaiThi
            // 
            this.txtMaBaiThi.Location = new System.Drawing.Point(397, 68);
            this.txtMaBaiThi.Name = "txtMaBaiThi";
            this.txtMaBaiThi.Size = new System.Drawing.Size(200, 20);
            this.txtMaBaiThi.TabIndex = 3;
            // 
            // dgvBaiThi
            // 
            this.dgvBaiThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaiThi.Location = new System.Drawing.Point(44, 236);
            this.dgvBaiThi.Name = "dgvBaiThi";
            this.dgvBaiThi.RowHeadersWidth = 82;
            this.dgvBaiThi.Size = new System.Drawing.Size(788, 276);
            this.dgvBaiThi.TabIndex = 4;
            this.dgvBaiThi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaiThi_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(103, 186);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm Bài Thi";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHienThiBaiThi
            // 
            this.btnHienThiBaiThi.Location = new System.Drawing.Point(257, 174);
            this.btnHienThiBaiThi.Name = "btnHienThiBaiThi";
            this.btnHienThiBaiThi.Size = new System.Drawing.Size(130, 23);
            this.btnHienThiBaiThi.TabIndex = 6;
            this.btnHienThiBaiThi.Text = "Hiển Thị Các Bài Thi";
            this.btnHienThiBaiThi.UseVisualStyleBackColor = true;
            this.btnHienThiBaiThi.Click += new System.EventHandler(this.btnHienThiBaiThi_Click);
            // 
            // btnHienThiChiTiet
            // 
            this.btnHienThiChiTiet.Location = new System.Drawing.Point(445, 174);
            this.btnHienThiChiTiet.Name = "btnHienThiChiTiet";
            this.btnHienThiChiTiet.Size = new System.Drawing.Size(146, 23);
            this.btnHienThiChiTiet.TabIndex = 7;
            this.btnHienThiChiTiet.Text = "Hiển Thị Chi Tiết Bài Thi";
            this.btnHienThiChiTiet.UseVisualStyleBackColor = true;
            this.btnHienThiChiTiet.Click += new System.EventHandler(this.btnHienThiChiTiet_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(631, 174);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm Kiếm Bài Thi";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnHienThiChiTiet);
            this.groupBox1.Controls.Add(this.btnHienThiBaiThi);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(872, 543);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Bài Thi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(2, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.statusStrip1.Size = new System.Drawing.Size(868, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(751, 174);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FormQuanLyBaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 552);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvBaiThi);
            this.Controls.Add(this.txtMaBaiThi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQuanLyBaiThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bài thi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormQuanLyBaiThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaiThi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaBaiThi;
        private System.Windows.Forms.DataGridView dgvBaiThi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHienThiBaiThi;
        private System.Windows.Forms.Button btnHienThiChiTiet;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

