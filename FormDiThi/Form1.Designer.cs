namespace FormDiThi
{
    partial class FormDiThi
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
            this.txtMaHocSinh = new System.Windows.Forms.TextBox();
            this.txtTenHocSinh = new System.Windows.Forms.TextBox();
            this.txtHeSo = new System.Windows.Forms.TextBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btinHienThi = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên học sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hệ số";
            // 
            // txtMaHocSinh
            // 
            this.txtMaHocSinh.Location = new System.Drawing.Point(452, 68);
            this.txtMaHocSinh.Name = "txtMaHocSinh";
            this.txtMaHocSinh.Size = new System.Drawing.Size(191, 20);
            this.txtMaHocSinh.TabIndex = 3;
            this.txtMaHocSinh.TextChanged += new System.EventHandler(this.txtMaHocSinh_TextChanged);
            // 
            // txtTenHocSinh
            // 
            this.txtTenHocSinh.Location = new System.Drawing.Point(452, 102);
            this.txtTenHocSinh.Name = "txtTenHocSinh";
            this.txtTenHocSinh.Size = new System.Drawing.Size(191, 20);
            this.txtTenHocSinh.TabIndex = 4;
            this.txtTenHocSinh.TextChanged += new System.EventHandler(this.txtTenHocSinh_TextChanged);
            // 
            // txtHeSo
            // 
            this.txtHeSo.Location = new System.Drawing.Point(452, 140);
            this.txtHeSo.Name = "txtHeSo";
            this.txtHeSo.Size = new System.Drawing.Size(191, 20);
            this.txtHeSo.TabIndex = 5;
            this.txtHeSo.TextChanged += new System.EventHandler(this.txtHeSo_TextChanged);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(116, 349);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 82;
            this.dgvDanhSach.Size = new System.Drawing.Size(1168, 339);
            this.dgvDanhSach.TabIndex = 6;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(828, 68);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(117, 36);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 709);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1428, 42);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(237, 32);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btinHienThi
            // 
            this.btinHienThi.Location = new System.Drawing.Point(828, 110);
            this.btinHienThi.Name = "btinHienThi";
            this.btinHienThi.Size = new System.Drawing.Size(117, 26);
            this.btinHienThi.TabIndex = 9;
            this.btinHienThi.Text = "Hiển Thị";
            this.btinHienThi.UseVisualStyleBackColor = true;
            this.btinHienThi.Click += new System.EventHandler(this.btinHienThi_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.Location = new System.Drawing.Point(828, 147);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(117, 27);
            this.btnGiam.TabIndex = 10;
            this.btnGiam.Text = "Giảm hệ số";
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(828, 181);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(117, 34);
            this.btnIn.TabIndex = 11;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // FormDiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 751);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnGiam);
            this.Controls.Add(this.btinHienThi);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.txtHeSo);
            this.Controls.Add(this.txtTenHocSinh);
            this.Controls.Add(this.txtMaHocSinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDiThi";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDiThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHocSinh;
        private System.Windows.Forms.TextBox txtTenHocSinh;
        private System.Windows.Forms.TextBox txtHeSo;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btinHienThi;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Button btnIn;
    }
}

