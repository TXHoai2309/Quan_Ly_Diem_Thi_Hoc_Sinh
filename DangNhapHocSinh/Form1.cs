using DoiMatKhau;
using LamBaiThi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XacNhanThi;
using XemDiemHocSinh;
using XemThongTinHocSinh;

namespace DangNhapHocSinh
{
    public partial class FormHocSinhDashboard : Form

    {
        private Form currentChildForm = null;
        public FormHocSinhDashboard()
        {
            InitializeComponent();
        }
        private string maHocSinh;
        public string tendangnhap; 
        public FormHocSinhDashboard(string maHS, string tenDN)
        {
            InitializeComponent();
            maHocSinh = maHS;
            lblMaHocSinh.Text = tendangnhap;
            tendangnhap = tenDN; 
        }
        private void ShowChildFormInGroupBox(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide(); // Ẩn Form cũ nhưng không đóng
            }

            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new Form(); // Khởi tạo lại nếu Form đã bị đóng
            }

            childForm.TopLevel = false; // Không phải cửa sổ độc lập
            childForm.FormBorderStyle = FormBorderStyle.None; // Ẩn viền
            childForm.Dock = DockStyle.Fill; // Tự động lấp đầy GroupBox
            groupBox3.Controls.Clear(); // Xóa Form con cũ
            groupBox3.Controls.Add(childForm); // Thêm Form con mới vào GroupBox
            childForm.BringToFront(); // Đưa Form lên trên cùng
            childForm.Show();

            currentChildForm = childForm; // Lưu Form con hiện tại
        }
        private void FormHocSinhDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnLamBaiThi_Click(object sender, EventArgs e)
        {
            FormXacNhanThi xacNhan = new FormXacNhanThi();
            xacNhan.ShowDialog();

            // Nếu học sinh đồng ý làm bài thi
            if (xacNhan.DongY)
            {
                ShowChildFormInGroupBox(Application.OpenForms["FormLamBaiThi"] as FormLamBaiThi ?? new FormLamBaiThi(maHocSinh));
            }
            else
            {
                MessageBox.Show("Bạn đã hủy bài thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan = MessageBox.Show("bạn có chắc chắc muốn đăng xuất không? ", "Thông Báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (xacnhan == DialogResult.Yes) {
                this.Close(); // Đóng form hiện tại
                Application.Restart(); // Khởi động lại ứng dụng để quay về màn hình đăng nhập
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnXemDiemThi_Click(object sender, EventArgs e)
        {
            ShowChildFormInGroupBox(Application.OpenForms["FormXemDiemThiHocSinh"] as FormXemDiemThiHocSinh ?? new FormXemDiemThiHocSinh(maHocSinh));
            
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            ShowChildFormInGroupBox(Application.OpenForms["FormXemThongTinHocSinh"] as FormXemThongTinHocSinh ?? new FormXemThongTinHocSinh(maHocSinh));
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            ShowChildFormInGroupBox(Application.OpenForms["FormDoiMatKhau"] as FormDoiMatKhau ?? new FormDoiMatKhau(tendangnhap));
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
