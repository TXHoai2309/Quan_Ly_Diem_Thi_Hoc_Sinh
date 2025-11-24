using RePortDiThi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDiThi
{
    public partial class FormDiThi : Form
    {
        public FormDiThi()
        {
            InitializeComponent();
            LoadDanhSach();
        }

        private void FormDiThi_Load(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = false;
            btnIn.Enabled = false;
        }
        private void KiemTraNhapLieu()
        {
            // Kiểm tra nếu cả Username và Password đều có dữ liệu hợp lệ thì bật nút Đăng nhập
            if (!string.IsNullOrWhiteSpace(txtMaHocSinh.Text) ||
                !string.IsNullOrWhiteSpace(txtHeSo.Text) ||
                !string.IsNullOrWhiteSpace(txtTenHocSinh.Text))

            {
                btnTimKiem.Enabled = true;
                btnIn.Enabled=true;
                

            }
            else
            {
                btnTimKiem.Enabled = false;
                btinHienThi.Enabled = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_TimKiemHocSinhDiThi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaHS", string.IsNullOrWhiteSpace(txtMaHocSinh.Text) ? (object)DBNull.Value : txtMaHocSinh.Text);
                        cmd.Parameters.AddWithValue("@HoTen", string.IsNullOrWhiteSpace(txtTenHocSinh.Text) ? (object)DBNull.Value : txtTenHocSinh.Text);
                        cmd.Parameters.AddWithValue("@HESO", string.IsNullOrWhiteSpace(txtHeSo.Text) ? (object)DBNull.Value : txtHeSo.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvDanhSach.DataSource = dt;
                        if (dt.Rows.Count == 0)
                        {
                            toolStripStatusLabel1.Text = "Không tìm thấy học sinh nào phù hợp";
                            Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                        }
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Lỗi tìm kiếm: " + ex.Message;
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                }
            }
        }
        private void LoadDanhSach()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("HienDanhSachDiThi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvDanhSach.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Lỗi tải danh sách học sinh: " + ex.Message;
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                }
            }
        }

        private void LoadDanhSachHienThi()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("HienThiDanhSachDiThi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvDanhSach.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Lỗi tải danh sách học sinh: " + ex.Message;
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                }
            }
        }

        private void btinHienThi_Click(object sender, EventArgs e)
        {
            LoadDanhSachHienThi();
        }

        private void txtMaHocSinh_TextChanged(object sender, EventArgs e)
        {
            KiemTraNhapLieu();
        }

        private void txtTenHocSinh_TextChanged(object sender, EventArgs e)
        {
            KiemTraNhapLieu();
        }

        private void txtHeSo_TextChanged(object sender, EventArgs e)
        {
            KiemTraNhapLieu();
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("GiamHeSo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số vào Stored Procedure
                        cmd.Parameters.AddWithValue("@MaHS", txtMaHocSinh.Text.Trim());

                        // Thực thi Stored Procedure
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            toolStripStatusLabel1.Text = "Giảm hệ số thành công";
                            Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                        }
                        else
                        {
                            toolStripStatusLabel1.Text = "Không tìm thấy học sinh nào phù hợp";
                            Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                toolStripStatusLabel1.Text = "Lỗi SQL";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
            }
            LoadDanhSach();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Formrpdithi formrpdithi = new Formrpdithi(txtMaHocSinh.Text.Trim(), txtTenHocSinh.Text.Trim(), txtHeSo.Text.Trim() );
            formrpdithi.ShowDialog();
        }
    }
}
