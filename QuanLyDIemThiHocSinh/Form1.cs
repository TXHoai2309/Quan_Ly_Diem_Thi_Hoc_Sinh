
using ReportBangDiemCuaMotLopHoc;
using ReportDiemThiHocSinhCaTruong;
using ReportToanBoDiemThi;
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

namespace QuanLyDIemThiHocSinh
{
    public partial class FormQuanLyDIemThi : Form
    {
        public FormQuanLyDIemThi()
        {
            InitializeComponent();
        }

        private void LoadDiemThi()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_LoadDiemThi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvDiemThi.DataSource = dt;
                        DinhDangDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Lỗi tải danh sách điểm thi";
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDanhSachHocSinh();  // Nạp danh sách học sinh vào ComboBox
            LoadDanhSachLop();      // Nạp danh sách lớp vào ComboBox
            LoadDanhSachBaiThi();   // Nạp danh sách bài thi vào ComboBox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDiemThi();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có chắc chắc muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cbMaHocSinh.SelectedValue == null || cbMaBaiThi.SelectedValue == null)
            {
                toolStripStatusLabel1.Text = "Vui lòng chọn Mã Học Sinh và Mã Bài Thi!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                return;
            }

            string maHS = cbMaHocSinh.SelectedValue.ToString();
            string maBaiThi = cbMaBaiThi.SelectedValue.ToString();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_XoaDiemThi", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHS", maHS);
                    cmd.Parameters.AddWithValue("@MaBaiThi", maBaiThi);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        toolStripStatusLabel1.Text = "Xóa điểm thi thành công!";
                        Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                        LoadDiemThi();
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Không tìm thấy điểm thi để xóa! ";
                        Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvDiemThi.SelectedRows.Count == 0)
            {
                toolStripStatusLabel1.Text = "Vui lòng chọn điểm thi cần cập nhật!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                return;
            }

            // Lấy thông tin từ hàng được chọn trong DataGridView
            string maHS = dgvDiemThi.SelectedRows[0].Cells["MaHS"].Value.ToString();
            string maBaiThi = dgvDiemThi.SelectedRows[0].Cells["MaBaiThi"].Value.ToString();

            // Kiểm tra xem điểm mới có hợp lệ không
            if (!double.TryParse(txtDiemThi.Text, out double diemMoi) || diemMoi < 0 || diemMoi > 10)
            {
                toolStripStatusLabel1.Text = "Điểm phải nằm trong khoảng từ 0 đến 10!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                return;
            }

            // Chuỗi kết nối đến SQL Server
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_CapNhatDiemThi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaHS", maHS);
                        cmd.Parameters.AddWithValue("@MaBaiThi", maBaiThi);
                        cmd.Parameters.AddWithValue("@DiemMoi", diemMoi);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            toolStripStatusLabel1.Text = "Cập nhật điểm thi thành công!";
                            Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                            LoadDiemThi(); // Cập nhật lại danh sách điểm thi
                        }
                        else
                        {
                            toolStripStatusLabel1.Text = "Không tìm thấy điểm thi để cập nhật!";
                            Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                        }
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Lỗi khi cập nhật điểm thi!";
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_TimKiemDiemThi", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số, nếu giá trị trống thì gửi NULL
                    cmd.Parameters.AddWithValue("@MaHS", cbMaHocSinh.SelectedValue ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@MaLop", cbMaLop.SelectedValue ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@MaBaiThi", cbMaBaiThi.SelectedValue ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Diem", string.IsNullOrWhiteSpace(txtDiemThi.Text) ? (object)DBNull.Value : float.Parse(txtDiemThi.Text));
                    cmd.Parameters.AddWithValue("@NgayCham", dtpNgayCham.Checked ? dtpNgayCham.Value.Date : (object)DBNull.Value);


                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDiemThi.DataSource = dt; // Hiển thị dữ liệu lên DataGridView
                }
            }
        }

        private void dgvDiemThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không click vào tiêu đề cột
            {
                DataGridViewRow row = dgvDiemThi.Rows[e.RowIndex];

                // Hiển thị dữ liệu lên các TextBox
                cbMaHocSinh.Text = row.Cells["MaHS"].Value?.ToString();
                txtHoTenHocSinh.Text = row.Cells["HoTen"].Value?.ToString();
                cbMaLop.Text = row.Cells["MaLop"].Value?.ToString();
                cbMaBaiThi.Text = row.Cells["MaBaiThi"].Value?.ToString();
                txtDiemThi.Text = row.Cells["Diem"].Value?.ToString();
                dtpNgayThi.Value = Convert.ToDateTime(row.Cells["NgayThi"].Value);


                // Kiểm tra nếu có Ngày Chấm thì hiển thị, ngược lại bỏ chọn
                if (row.Cells["NgayCham"].Value != DBNull.Value && row.Cells["NgayCham"].Value != null)
                {
                    dtpNgayCham.Value = Convert.ToDateTime(row.Cells["NgayCham"].Value);
                    dtpNgayCham.Checked = true; // Đánh dấu đã chọn
                }
                else
                {
                    dtpNgayCham.Checked = false; // Bỏ chọn nếu không có ngày chấm
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RpDiemThiHocSinhCaTruong rpdiemthicatruong = new RpDiemThiHocSinhCaTruong();
            this.Hide();
            rpdiemthicatruong.ShowDialog();
            this.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbMaLop.Text))
            {
                toolStripStatusLabel1.Text = "Vui lòng nhập mã lớp!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                return;
            }

            string maLop = cbMaLop.Text.Trim(); // Lấy giá trị mã lớp từ TextBox

            FormReportBangDiem1LopHoc rpbangdiem1lophoc = new FormReportBangDiem1LopHoc(maLop);
            this.Hide();
            rpbangdiem1lophoc.ShowDialog();
            this.Show();
        }
        private void DinhDangDataGridView()
        {
            dgvDiemThi.Columns["MaBaiThi"].HeaderText = "Mã Bài Thi";
            dgvDiemThi.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvDiemThi.Columns["MaHS"].HeaderText = "Mã Hoc Sinh";
            dgvDiemThi.Columns["Diem"].HeaderText = "Điểm Thi";
            dgvDiemThi.Columns["NgayCham"].HeaderText = "Ngày Chấm";
            dgvDiemThi.Columns["NgayThi"].HeaderText = "Ngày Thi";
            dgvDiemThi.Columns["MaLop"].HeaderText = "Mã Lớp";

            dgvDiemThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiemThi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDiemThi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnInBangDiemHocSinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbMaHocSinh.Text))
            {
                toolStripStatusLabel1.Text = "Vui lòng nhập mã học sinh!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                return;
            }
            string mahs = cbMaHocSinh.Text.Trim();
            FormReportToanBoDiemThi tptoanbodiemthi = new FormReportToanBoDiemThi(mahs);
            this.Hide();
            tptoanbodiemthi.ShowDialog();
            this.Show();
        }
        private void LoadDanhSachHocSinh()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_getMaHSCB", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cbMaHocSinh.DataSource = dt;
                        cbMaHocSinh.DisplayMember = "MaHS";
                        cbMaHocSinh.ValueMember = "MaHS";     // Giá trị thực tế là mã học sinh

                        if (dt.Rows.Count > 0)
                            cbMaHocSinh.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Lỗi tải danh sách học sinh!";
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                }
            }
        }
        private void LoadDanhSachLop()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_getMaLopCB", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cbMaLop.DataSource = dt;
                        cbMaLop.DisplayMember = "MaLop";
                        cbMaLop.ValueMember = "MaLop";

                        if (dt.Rows.Count > 0)
                            cbMaLop.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Lỗi tải danh sách lớp học";
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                }
            }
        }
        private void LoadDanhSachBaiThi()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_GetMaBaiThiCB", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cbMaBaiThi.DataSource = dt;
                        cbMaBaiThi.DisplayMember = "MaBaiThi";
                        cbMaBaiThi.ValueMember = "MaBaiThi";

                        if (dt.Rows.Count > 0)
                            cbMaBaiThi.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Không tìm thấy học sinh nào phù hợp";
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây

                    MessageBox.Show("Lỗi tải danh sách bài thi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }

}
