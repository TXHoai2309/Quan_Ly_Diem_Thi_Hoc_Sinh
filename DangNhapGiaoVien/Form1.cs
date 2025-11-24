using DoiMatKhau;
using QuanLyBaiThi;
using QuanLyCauHoi;
using QuanLyDIemThiHocSinh;
using QuanLyHocSinh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XemThongTinGiaoVien;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DangNhapGiaoVien
{
    public partial class FormGiaoVienDashboard : System.Windows.Forms.Form
    {
        private string tenGiaoVien; // Lưu tên giáo viên để hiển thị
        private string maGiaoVien;
    
        public FormGiaoVienDashboard()
        {
            InitializeComponent();
           
        }

       
        public FormGiaoVienDashboard(string tenGV, string maGV)
        {
            InitializeComponent();
            tenGiaoVien = tenGV; // Lưu lại tên giáo viên
          
            maGiaoVien = maGV;
      
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
            groupBox1.Controls.Clear(); // Xóa Form con cũ
            groupBox1.Controls.Add(childForm); // Thêm Form con mới vào GroupBox
            childForm.BringToFront(); // Đưa Form lên trên cùng
            childForm.Show();

            currentChildForm = childForm; // Lưu Form con hiện tại
        }


        private Form currentChildForm = null;
        private void FormGiaoVienDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnQuanLyHocSinh_Click(object sender, EventArgs e)
        {
            ShowChildFormInGroupBox(Application.OpenForms["FormQuanLyHocVien"] as FormQuanLyHocVien ?? new FormQuanLyHocVien());
        }

        private void btnQuanLyBaiThi_Click(object sender, EventArgs e)
        {
            ShowChildFormInGroupBox(Application.OpenForms["FormQuanLyBaiThi"] as FormQuanLyBaiThi ?? new FormQuanLyBaiThi());
        }

        private void btnQuanLyCauHoi_Click(object sender, EventArgs e)
        {
            ShowChildFormInGroupBox(Application.OpenForms["FormQuanLyCauHoi"] as FormQuanLyCauHoi ?? new FormQuanLyCauHoi());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không? " , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacnhan == DialogResult.Yes)
            {
                this.Close(); // Đóng form hiện tại
                Application.Restart(); // Khởi động lại ứng dụng để quay về màn hình đăng nhập
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowChildFormInGroupBox(Application.OpenForms["FormQuanLyDIemThi"] as FormQuanLyDIemThi ?? new FormQuanLyDIemThi());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowChildFormInGroupBox(Application.OpenForms["FormXemThongTinGiaoVien"] as FormXemThongTinGiaoVien ?? new FormXemThongTinGiaoVien(maGiaoVien));
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            ShowChildFormInGroupBox(Application.OpenForms["FormDoiMatKhau"] as FormDoiMatKhau ?? new FormDoiMatKhau(tenGiaoVien));
            
        }

        private void btnXemThongTinGiaoVien_Enter(object sender, EventArgs e)
        {

        }
    }
}
