
using DangNhapGiaoVien;
using DangNhapHocSinh;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaoTaiKhoan;

namespace DangNhap
{
    public partial class FormDangNhap : Form
    {
        private string connectionString;

        public FormDangNhap()
        {
            InitializeComponent();
            LoadConnectionString();
            this.AcceptButton = btnLogin; // btnDangNhap là tên nút đăng nhập

        }

        // Lấy chuỗi kết nối từ app.config và kiểm tra lỗi
        private void LoadConnectionString()
        {
            if (ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"] != null)
            {
                connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
            }
            else
            {
                toolStripStatusLabel1.Text = "Lỗi: Không tìm thấy ConnectionString trong app.config!\", \"Lỗi";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
            }
        }

        // Thiết lập Placeholder cho TextBox
        private void SetPlaceholder(TextBox txt, string placeholder)
        {
            txt.Text = placeholder;
            txt.ForeColor = Color.Gray;

            txt.Enter += (s, e) =>
            {
                if (txt.Text == placeholder)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                }
            };

            txt.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholder;
                    txt.ForeColor = Color.Gray;
                }
            };
        }

        // Khi Form Load, thiết lập Placeholder
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            SetPlaceholder(txtUsername, "Username");
            SetPlaceholder(txtPassword, "Password");

            btnLogin.Enabled = false; // Mặc định vô hiệu hóa nút đăng nhập


        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!btnLogin.Enabled)
            {
                toolStripStatusLabel1.Text = "Không tìm thấy học sinh nào phù hợp";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string loaiTaiKhoan = null;
                    using (SqlCommand cmd = new SqlCommand("sp_DangNhap", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TenDangNhap", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@MatKhau", txtPassword.Text);
                        SqlParameter outParam = new SqlParameter("@LoaiTaiKhoan", SqlDbType.NVarChar, 50)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outParam);

                        cmd.ExecuteNonQuery();
                        loaiTaiKhoan = outParam.Value?.ToString();
                    }

                    if (!string.IsNullOrEmpty(loaiTaiKhoan))
                    {
                        if (loaiTaiKhoan == "Giáo viên")
                        {
                            string magiaovien = LayMaGiaoVien(txtUsername.Text);
                            FormGiaoVienDashboard formGV = new FormGiaoVienDashboard(txtUsername.Text, magiaovien);
                            this.Hide();
                            formGV.ShowDialog();
                            this.Show();
                        }
                        else if (loaiTaiKhoan == "Học sinh")
                        {
                            string maHocSinh = LayMaHocSinh(txtUsername.Text);

                            if (!string.IsNullOrEmpty(maHocSinh))
                            {
                                this.Hide();
                                FormHocSinhDashboard formHS = new FormHocSinhDashboard(maHocSinh, txtUsername.Text);
                                formHS.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                toolStripStatusLabel1.Text = "Không tìm thấy mã học sinh!";
                                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                            }
                        }
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
                        Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                    }
                }
            }
            catch (SqlException ex)
            {
                toolStripStatusLabel1.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Lỗi không xác định: ";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
            }
        }

        // Xử lý hiển thị/ẩn mật khẩu
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
        private string LayMaHocSinh(string tenDangNhap)
        {
            string maHocSinh = "";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_LayMaHocSinh", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    SqlParameter outParam = new SqlParameter("@MaHS", SqlDbType.NVarChar, 10)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outParam);

                    cmd.ExecuteNonQuery();
                    maHocSinh = outParam.Value?.ToString();
                }
            }
            return maHocSinh;
        }

        private string LayMaGiaoVien(string tenDangNhap)
        {
            string maGiaoVien = "";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_LayMaGiaoVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    SqlParameter outParam = new SqlParameter("@MaGV", SqlDbType.NVarChar, 10)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outParam);

                    cmd.ExecuteNonQuery();
                    maGiaoVien = outParam.Value?.ToString();
                }
            }
            return maGiaoVien;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTaoTaiKhoan taotaikhoan = new FormTaoTaiKhoan();
            this.Hide();
            taotaikhoan.ShowDialog();
            this.Show();
        }
        private void KiemTraNhapLieu()
        {
            // Kiểm tra nếu cả Username và Password đều có dữ liệu hợp lệ thì bật nút Đăng nhập
            if (!string.IsNullOrWhiteSpace(txtUsername.Text) && txtUsername.Text != "Username" &&
                !string.IsNullOrWhiteSpace(txtPassword.Text) && txtPassword.Text != "Password")
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            KiemTraNhapLieu();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            KiemTraNhapLieu();
        }
    }
}
