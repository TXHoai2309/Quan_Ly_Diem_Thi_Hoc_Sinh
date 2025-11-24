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

namespace QuanLyCauHoi
{
    public partial class FormQuanLyCauHoi : Form
    {
        public FormQuanLyCauHoi()
        {
            InitializeComponent();
            cbDoKho.Items.Add("1");
            cbDoKho.Items.Add("2");
            cbDoKho.Items.Add("3");
            cbDoKho.SelectedIndex = 0;
        }

        private void btnThemCauHoi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString))
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_ThemCauHoi", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaCauHoi", txtMaCauHoi.Text);
                    cmd.Parameters.AddWithValue("@NoiDung", txtNoiDung.Text);
                    cmd.Parameters.AddWithValue("@DoKho", cbDoKho.Text);
                    cmd.Parameters.AddWithValue("@DapAnDung", txtDapAnDung.Text);

                    cmd.ExecuteNonQuery();
                    toolStripStatusLabel1.Text = "Thêm câu hỏi thành công!";
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                    HienThiDanhSach();

                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Lỗi khi thêm câu hỏi";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
            }
        }
        private void HienThiDanhSach()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_HienThiDanhSach", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDanhSach.DataSource = dt;
                }
            }

            // Giữ nguyên Mã Bài Thi nếu đã có dữ liệu trước đó
            if (!string.IsNullOrEmpty(maBaiThiHienTai))
            {
                cbMaBaithi.Text = maBaiThiHienTai;
            }
        }


        private void btnSuaCauHoi_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaCauHoi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaCauHoi", txtMaCauHoi.Text);
                cmd.Parameters.AddWithValue("@NoiDung", txtNoiDung.Text);
                cmd.Parameters.AddWithValue("@DoKho", cbDoKho.Text);
                cmd.Parameters.AddWithValue("@DapAnDung", txtDapAnDung.Text);

                cmd.ExecuteNonQuery();
                toolStripStatusLabel1.Text = "Cập nhật điểm thi thành công!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                HienThiDanhSach();

            }
        }

        private void btnXoaCauHoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSach.SelectedRows.Count == 0)
                {
                    toolStripStatusLabel1.Text = "Vui lòng chọn câu hỏi cần xóa!";
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                    return;
                }

                string maCauHoi = dgvDanhSach.SelectedRows[0].Cells["MaCauHoi"].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa câu hỏi \"{maCauHoi}\" không?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_XoaCauHoi", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaCauHoi", maCauHoi);

                        cmd.ExecuteNonQuery();
                        toolStripStatusLabel1.Text = "Xóa câu hỏi thành công!";
                        Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                        HienThiDanhSach();

                    }
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Không thể xóa câu hỏi";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
            }
        }

        private void btnHienThiChiTietBaiThi_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_HienCauHoi", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDanhSach.DataSource = dt;
                    DinhDangDataGridView();
                }

            }
        }

        private void btnHienThiCauHoi_Click(object sender, EventArgs e)
        {

        }

        private void FormQuanLyCauHoi_Load(object sender, EventArgs e)
        {
            LoadDanhSachBaiThi(); // Nạp danh sách bài thi vào ComboBox khi mở Form
        }

        private void btnTimKiemCauHoi_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_TimKiemCauHoi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Truyền tham số, nếu trống thì truyền NULL
                        cmd.Parameters.AddWithValue("@MaCauHoi", string.IsNullOrWhiteSpace(txtMaCauHoi.Text) ? (object)DBNull.Value : txtMaCauHoi.Text);
                        cmd.Parameters.AddWithValue("@NoiDung", string.IsNullOrWhiteSpace(txtNoiDung.Text) ? (object)DBNull.Value : txtNoiDung.Text);
                        cmd.Parameters.AddWithValue("@DoKho", string.IsNullOrWhiteSpace(cbDoKho.Text) ? (object)DBNull.Value : int.Parse(cbDoKho.Text));
                        cmd.Parameters.AddWithValue("@DapAnDung", string.IsNullOrWhiteSpace(txtDapAnDung.Text) ? (object)DBNull.Value : txtDapAnDung.Text);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvDanhSach.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            toolStripStatusLabel1.Text = "Không tìm thấy câu hỏi nào phù hợp!";
                            Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                        }
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Lỗi tìm kiếm câu hỏi!";
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                }
            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];

                // Kiểm tra xem đang hiển thị danh sách câu hỏi hay bài thi
                if (dgvDanhSach.Columns.Contains("MaCauHoi"))
                {
                    // Đang hiển thị câu hỏi -> Điền thông tin câu hỏi
                    txtMaCauHoi.Text = row.Cells["MaCauHoi"].Value.ToString();
                    txtNoiDung.Text = row.Cells["NoiDung"].Value.ToString();
                    cbDoKho.Text = row.Cells["DoKho"].Value.ToString();
                    txtDapAnDung.Text = row.Cells["DapAnDung"].Value.ToString();

                    // Xóa dữ liệu bài thi nếu đang có
          
                }
                else if (dgvDanhSach.Columns.Contains("MaBaiThi"))
                {
                    // Đang hiển thị bài thi -> Điền thông tin bài thi
                    cbMaBaithi.Text = row.Cells["MaBaiThi"].Value.ToString();

                    // Xóa dữ liệu câu hỏi nếu đang có
                    txtMaCauHoi.Clear();
                    txtNoiDung.Clear();
                    cbDoKho.SelectedIndex = 0;  
                    txtDapAnDung.Clear();
                }
            }
        }
        private void DinhDangDataGridView()
        {

            dgvDanhSach.Columns["MaCauHoi"].HeaderText = "Mã Câu Hỏi";
            dgvDanhSach.Columns["NoiDung"].HeaderText = "Nội Dung Câu Hỏi";
            dgvDanhSach.Columns["DoKho"].HeaderText = "Độ Khó";
            dgvDanhSach.Columns["DapAnDung"].HeaderText = "Đáp Án Đúng";
            if (dgvDanhSach.Columns.Contains("MaBaiThi"))
            {
                dgvDanhSach.Columns["MaBaiThi"].HeaderText = "Mã Bài Thi";
            }

            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSach.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDanhSach.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        private void btnHienThiChiTiet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbMaBaithi.SelectedValue.ToString()))
            {
                toolStripStatusLabel1.Text = "Vui lòng nhập Mã Bài Thi!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_HienThiChiTietBaiThi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaBaiThi", cbMaBaithi.SelectedValue.ToString());

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDanhSach.DataSource = dt;
                DinhDangDataGridView();

                if (dt.Rows.Count == 0)
                {
                    toolStripStatusLabel1.Text = "Không tìm thấy bài thi hoặc bài thi chưa có câu hỏi!";
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                }

            }
        }
        private string maBaiThiHienTai = "";
        private void btnThemVaoBaiThi_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbMaBaithi.SelectedValue == null || string.IsNullOrWhiteSpace(txtMaCauHoi.Text))
                {
                    toolStripStatusLabel1.Text = "Vui lòng chọn Mã Bài Thi và nhập Mã Câu Hỏi";
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                    return;
                }

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_ThemCauHoiVaoBaiThi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaBaiThi", cbMaBaithi.SelectedValue.ToString()); // Lấy giá trị từ ComboBox
                        cmd.Parameters.AddWithValue("@MaCauHoi", txtMaCauHoi.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                toolStripStatusLabel1.Text = "Thêm câu hỏi vào bài thi thành công";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                HienThiDanhSach();
            }
            catch
            {
                toolStripStatusLabel1.Text = "Lõi khi thêm câu hỏi vào bài thi";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
            }
        }

        private void btnXoaKhoiBaiThi_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbMaBaithi.SelectedValue == null || string.IsNullOrWhiteSpace(txtMaCauHoi.Text))
                {
                    toolStripStatusLabel1.Text = "Vui lòng chọn Mã Bài Thi và nhập Mã Câu Hỏi!";
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                    return;
                }

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_XoaCauHoiKhoiBaiThi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaBaiThi", cbMaBaithi.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@MaCauHoi", txtMaCauHoi.Text);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            toolStripStatusLabel1.Text = "Xóa câu hỏi khỏi bài thi thành công!";
                            Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Number == 50000) // Mã lỗi do RAISERROR trả về
                            {
                                toolStripStatusLabel1.Text = "Câu hỏi không tồn tại trong bài thi!";
                                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                            }
                            else
                            {
                                toolStripStatusLabel1.Text = "Lỗi SQL: " + ex.Message;
                                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Lỗi khi xóa câu hỏi: " + ex.Message;
                toolStripStatusLabel1.Text = "";
            }
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan = MessageBox.Show("Bạn có chắc chắn muốn thoát không? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacnhan == DialogResult.Yes)
            {
                Close();
            }
        }

        private void cbDoKho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMaBaiThi_TextChanged(object sender, EventArgs e)
        {

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

                        // Gán dữ liệu vào ComboBox
                        cbMaBaithi.DataSource = dt;
                        cbMaBaithi.DisplayMember = "MaBaiThi";  // Hiển thị mã bài thi
                        cbMaBaithi.ValueMember = "MaBaiThi";    // Giá trị thực tế là mã bài thi

                        // Đặt giá trị mặc định nếu có dữ liệu
                        if (dt.Rows.Count > 0)
                            cbMaBaithi.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Lỗi tải danh sách bài thi";
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDapAnDung.Clear();
            txtMaCauHoi.Clear();
            txtNoiDung.Clear();
            cbDoKho.SelectedIndex = -1;
            cbMaBaithi.SelectedIndex = -1;
        }
    }
}

