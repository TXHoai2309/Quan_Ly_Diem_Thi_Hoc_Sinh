using ReportThongTinHocSinhTheoLop;
using ReportThongTinMotHocSinh;
using ReportToanBoThongTinHocSinh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class FormQuanLyHocVien : Form
    {
        public FormQuanLyHocVien()
        {
            InitializeComponent();
            LoadDanhSachMaHocSinh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadDanhSachHocSinh()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_LayDanhSachHocSinh", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvHocSinh.DataSource = dt;
                        DinhDangDataGrid();
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Lỗi tải danh sách học sinh: " + ex.Message;
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                }
            }
        }

        private void FormQuanLyHocSinh_Load(object sender, EventArgs e)
        {
            LoadDanhSachHocSinh();  // Hiển thị danh sách học sinh

        }

        private void btnThemHocSinh_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;

            if (string.IsNullOrWhiteSpace(cbMaHocSinh.Text) ||
                string.IsNullOrWhiteSpace(txtHoTenHocSinh.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtLopHoc.Text) ||
                string.IsNullOrWhiteSpace(txtQueQuan.Text) ||
                string.IsNullOrWhiteSpace(txtGioiTinh.Text))
            {
                toolStripStatusLabel1.Text = "Vui lòng nhập đầy đủ thông tin học sinh!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_ThemHocSinh", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        string mahs = cbMaHocSinh.Text;
                        // Thêm tham số vào Stored Procedure
                        cmd.Parameters.AddWithValue("@MaHS", mahs);
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTenHocSinh.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value.Date);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaLop", txtLopHoc.Text.Trim());
                        cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text.Trim());
                        cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text.Trim());

                        // Thực thi Stored Procedure
                        cmd.ExecuteNonQuery();
                        toolStripStatusLabel1.Text = "Thêm học sinh thành công";
                        Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                        LoadDanhSachHocSinh(); // Cập nhật lại danh sách học sinh
                        LamMoiForm(); // Xóa các ô nhập sau khi thêm thành công
                    }
                }
                catch (SqlException ex)
                {
                    toolStripStatusLabel1.Text = "Lỗi SQL: " + ex.Message;
                    HideStatusLabelAfterDelay();
                }
            }

        }
        // Hàm cập nhật status label một cách an toàn trên UI thread
        private void HideStatusLabelAfterDelay()
        {
            Task.Delay(3000).ContinueWith(_ =>
            {
                if (toolStripStatusLabel1.Owner.InvokeRequired)
                {
                    toolStripStatusLabel1.Owner.Invoke(new Action(() =>
                    {
                        toolStripStatusLabel1.Text = "";
                    }));
                }
                else
                {
                    toolStripStatusLabel1.Text = "";
                }
            });
        }

        private void btnXoaHocSinh_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;

                if (cbMaHocSinh.SelectedIndex == -1)
                {
                    toolStripStatusLabel1.Text = "Vui lòng chọn học sinh cần xóa!";
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                    return;
                }

                // Lấy thông tin học sinh được chọn
                string maHS = cbMaHocSinh.SelectedValue.ToString();
                string hoTen = dgvHocSinh.SelectedRows[0].Cells["HoTen"].Value.ToString();

                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa học sinh \"{hoTen}\" (Mã: {maHS}) không?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("sp_XoaHocSinh", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaHS", maHS);
                            cmd.ExecuteNonQuery();
                            toolStripStatusLabel1.Text = "Xóa học sinh thành công!";
                            Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                            LoadDanhSachHocSinh();
                            LamMoiForm();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "lỗi: " + ex.Message;
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
            }
        }


        private void btnSuaThongTinHocSinh_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;

            if (cbMaHocSinh.SelectedIndex == -1)
            {
                toolStripStatusLabel1.Text = "Vui lòng chọn học sinh cần sửa!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                return;
            }

            string maHS = dgvHocSinh.SelectedRows[0].Cells["MaHS"].Value.ToString().Trim();

            if (string.IsNullOrWhiteSpace(txtHoTenHocSinh.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtLopHoc.Text) ||
                string.IsNullOrWhiteSpace(txtQueQuan.Text) ||
                string.IsNullOrWhiteSpace(txtGioiTinh.Text))
            {
                toolStripStatusLabel1.Text = "Vui lòng nhập đẩy đủ thông tin!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_SuaThongTinHocSinh", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Gán tham số
                        cmd.Parameters.AddWithValue("@MaHS", maHS);
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTenHocSinh.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value.Date);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaLop", txtLopHoc.Text.Trim());
                        cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text.Trim());
                        cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text.Trim());

                        // Thực thi Stored Procedure
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            toolStripStatusLabel1.Text = "Cập nhật thông tin học sinh thành công!";
                            Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                            LoadDanhSachHocSinh(); // Cập nhật lại danh sách học sinh
                            LamMoiForm(); // Xóa các ô nhập sau khi cập nhật thành công
                        }
                        else
                        {
                            toolStripStatusLabel1.Text = "Không có dữ liệu nào được cập nhật!";
                            Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                        }
                    }
                }
                catch (SqlException ex)
                {
                    toolStripStatusLabel1.Text = "Lỗi SQL: " + ex.Message;
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                }
            }
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {

            LamMoiForm();
        }

        private void LamMoiForm()
        {
            cbMaHocSinh.SelectedIndex = -1; 
            txtHoTenHocSinh.Clear();
            txtEmail.Clear();
            txtLopHoc.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            txtQueQuan.Clear();
            txtGioiTinh.Clear();
            LoadDanhSachHocSinh();
        }

        private void btnTimKiemHS_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_TimKiemHocSinh", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Truyền tham số, nếu trống thì truyền NULL
                        cmd.Parameters.AddWithValue("@MaHS", string.IsNullOrWhiteSpace(cbMaHocSinh.Text) ? (object)DBNull.Value : cbMaHocSinh.Text);
                        cmd.Parameters.AddWithValue("@HoTen", string.IsNullOrWhiteSpace(txtHoTenHocSinh.Text) ? (object)DBNull.Value : txtHoTenHocSinh.Text);
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text);
                        cmd.Parameters.AddWithValue("@MaLop", string.IsNullOrWhiteSpace(txtLopHoc.Text) ? (object)DBNull.Value : txtLopHoc.Text);
                        cmd.Parameters.AddWithValue("@QueQuan", string.IsNullOrWhiteSpace(txtQueQuan.Text) ? (object)DBNull.Value : txtQueQuan.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", string.IsNullOrWhiteSpace(txtGioiTinh.Text) ? (object)DBNull.Value : txtGioiTinh.Text);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvHocSinh.DataSource = dt;

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



        private void FormQuanLyHocVien_Load(object sender, EventArgs e)
        {
            cbMaHocSinh.DropDownStyle = ComboBoxStyle.DropDown; // Cho phép nhập thủ công
            cbMaHocSinh.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // Gợi ý khi nhập
            cbMaHocSinh.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void cbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvHocSinh_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHocSinh.Rows[e.RowIndex];

                // Gán giá trị vào ComboBox
                cbMaHocSinh.SelectedValue = row.Cells["MaHS"].Value.ToString();
                txtHoTenHocSinh.Text = row.Cells["HoTen"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtLopHoc.Text = row.Cells["MaLop"].Value.ToString();
                txtQueQuan.Text = row.Cells["QueQuan"].Value.ToString();
                txtGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan = MessageBox.Show("Bạn có chắc chắn muốn thoát không? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacnhan == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInToanBo_Click(object sender, EventArgs e)
        {
            FormReportToanBoHocSinh rp = new FormReportToanBoHocSinh();
            this.Hide();
            rp.ShowDialog();
            this.Show();
        }

        private void btnInThongTinHocSinh_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dữ liệu trong DataGridView không
            if (dgvHocSinh.Rows.Count == 0)
            {
                toolStripStatusLabel1.Text = "Không có dữ liệu học sinh để in!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                return;
            }

            // Kiểm tra xem người dùng đã chọn hàng hay chưa
            if (dgvHocSinh.SelectedRows.Count == 0)
            {
                toolStripStatusLabel1.Text = "Vui lòng chọn 1 học sinh để in thông tin!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                return;
            }

            // Lấy mã học sinh từ hàng được chọn
            string mahs = Convert.ToString(dgvHocSinh.SelectedRows[0].Cells["MaHS"].Value);

            // Kiểm tra mã học sinh có hợp lệ không
            if (string.IsNullOrWhiteSpace(mahs))
            {
                toolStripStatusLabel1.Text = "Mã học sinh không hợp lệ!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                return;
            }

            // Mở form báo cáo
            try
            {
                FormReportThongTinMotHocSinh rp1hocsinh = new FormReportThongTinMotHocSinh(mahs);
                rp1hocsinh.ShowDialog();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Lỗi khi mở báo cáo: " + ex.Message;
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
            }
        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            LoadDanhSachHocSinh();
        }

        private void DinhDangDataGrid()
        {
            dgvHocSinh.Columns["MaHS"].HeaderText = "Mã Học Sinh";
            dgvHocSinh.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvHocSinh.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvHocSinh.Columns["Email"].HeaderText = "Email";
            dgvHocSinh.Columns["MaLop"].HeaderText = "Mã Lớp";
            dgvHocSinh.Columns["QueQuan"].HeaderText = "Quê Quán";
            dgvHocSinh.Columns["GioiTinh"].HeaderText = "Giới Tính";
        }

        private void btnInThongTinHSTheoLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLopHoc.Text))
            {
                MessageBox.Show("Vui lòng nhập mã lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLop = txtLopHoc.Text.Trim(); // Lấy giá trị mã lớp từ TextBox
            FormReportThongTinHocSinhMotLopHoc rp1lophoc = new FormReportThongTinHocSinhMotLopHoc(maLop);
            this.Hide();
            rp1lophoc.ShowDialog();
            this.Show();
        }
        private void LoadDanhSachMaHocSinh()
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
                        cbMaHocSinh.DisplayMember = "MaHS";  // Hiển thị mã học sinh
                        cbMaHocSinh.ValueMember = "MaHS";    // Lấy giá trị là MaHS
                        cbMaHocSinh.SelectedIndex = -1;      // Không chọn mặc định
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách mã học sinh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

