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

namespace DoiMatKhau
{
    public partial class FormDoiMatKhau : Form
    {
        private string tendangnhap; 
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        public FormDoiMatKhau(string TDN)
        {
            InitializeComponent();
            tendangnhap = TDN;
            lblTenDangNhap.Text = tendangnhap;
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matKhauCu = txtMatKhauCu.Text.Trim();
            string matKhauMoi = txtMatKhauMoi.Text.Trim();
            string xacNhanMatKhau = txtXacNhanMatKhau.Text.Trim();

            if (string.IsNullOrWhiteSpace(matKhauCu) || string.IsNullOrWhiteSpace(matKhauMoi) || string.IsNullOrWhiteSpace(xacNhanMatKhau))
            {
                toolStripStatusLabel1.Text = "Vui lòng nhập đầy đủ thông tin!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây 
                return;
            }

            if (matKhauMoi != xacNhanMatKhau)
            {
                toolStripStatusLabel1.Text = "Mật khẩu xác nhận không khớp!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                return;
            }

            if (!KiemTraMatKhau(matKhauMoi))
            {
                toolStripStatusLabel1.Text = "Mật khẩu phải có ít nhất 8 ký tự, gồm chữ hoa, chữ thường, số và ký tự đặc biệt!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                return;
            }

            if (DoiMatKhau(tendangnhap, matKhauCu, matKhauMoi))
            {
                toolStripStatusLabel1.Text = "Đổi mật khẩu thành công!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
            }
            else
            {
                toolStripStatusLabel1.Text = "Mật khẩu cũ không đúng!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 gi
            }
        }
        private bool KiemTraMatKhau(string matKhau)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[\W_]).{8,}$";
            return Regex.IsMatch(matKhau, pattern);
        }
        private bool DoiMatKhau(string tenDangNhap, string matKhauCu, string matKhauMoi)
        {

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_DoiMatKhau", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                        cmd.Parameters.AddWithValue("@MatKhauCu", matKhauCu);
                        cmd.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Lỗi" + ex.Message;
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 gi
            }
            return false;
        }

        private void lblTenDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
