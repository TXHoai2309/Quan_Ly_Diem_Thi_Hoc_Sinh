using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaoTaiKhoan
{
    public partial class FormTaoTaiKhoan : Form
    {
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
            this.AcceptButton = btnTaoTaiKhoan;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            cbLoaiTaiKhoan.Items.Add("Học sinh");
            cbLoaiTaiKhoan.Items.Add("Giáo viên");
            cbLoaiTaiKhoan.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtTenDangNhap.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim();
            string malienket = txtMaLienKet.Text.Trim();
            string mataikhoan = txtMaTaiKhoan.Text.Trim();
            string loaitaikhoan = cbLoaiTaiKhoan.SelectedItem.ToString(); 


            if (string.IsNullOrWhiteSpace(tendangnhap) || string.IsNullOrWhiteSpace(matkhau) || string.IsNullOrWhiteSpace(malienket))
            {
                toolStripStatusLabel1.Text = "Vui lòng nhập đầy đủ thông tin! ";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
            // Kiểm tra mật khẩu có đu điều kiện không 
            if (!KiemTraMatKhau(matkhau))
            {
                toolStripStatusLabel1.Text = "Mật khẩu phải có ít nhất 1 kí tự thường, in hoa, số và kí tự đặc biệt ";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_TaoTaiKhoan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TenDangNhap", tendangnhap);
                        cmd.Parameters.AddWithValue("@MatKhau", matkhau);
                        cmd.Parameters.AddWithValue("@LoaiTaiKhoan", loaitaikhoan); 
                        cmd.Parameters.AddWithValue("@MaLienKet", malienket);
                        cmd.Parameters.AddWithValue("@MaTaiKhoan", mataikhoan);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            toolStripStatusLabel1.Text = "Tạo tài khoản thành công! ";
                            Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                        }
                        else
                        {
                            toolStripStatusLabel1.Text = "Tạo tài khoản thất bại, vui lòng điền lại thông tin! ";
                            Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                        }
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Lỗi SQL! " + ex.Message;
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                }
            }

        }
        private bool KiemTraMatKhau(string matKhau)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[\W_]).{8,}$"; // tói thiểu có 8 kí tự bao gồm kí tự đặc biệt, có kí tự in hoa, kí tự thường, kí tự đặc biệt và số
            return Regex.IsMatch(matKhau, pattern);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
