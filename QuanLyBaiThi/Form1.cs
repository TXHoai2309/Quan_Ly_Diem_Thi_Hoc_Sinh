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

namespace QuanLyBaiThi
{
    public partial class FormQuanLyBaiThi : Form
    {
        public FormQuanLyBaiThi()
        {
            InitializeComponent();
        }

        private void FormQuanLyBaiThi_Load(object sender, EventArgs e)
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
                    using (SqlCommand cmd = new SqlCommand("sp_LoadDanhSachBaiThi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvBaiThi.DataSource = dt;
                        DinhDangDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Lỗi khi tải bài thi " + ex.Message;
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                }
            }
        }
        private void DinhDangDataGridView()
        {
            if (dgvBaiThi.Columns.Count > 0)
            {
                dgvBaiThi.Columns["MaBaiThi"].HeaderText = "Mã Bài Thi";
             

                if (dgvBaiThi.Columns.Contains("MaCauHoi"))
                {
                    dgvBaiThi.Columns["MaCauHoi"].HeaderText = "Mã Câu Hỏi";
                    dgvBaiThi.Columns["NoiDung"].HeaderText = "Nội Dung";
                    dgvBaiThi.Columns["DoKho"].HeaderText = "Độ Khó";
                    dgvBaiThi.Columns["DapAnDung"].HeaderText = "Đáp Án Đúng";
                }

                dgvBaiThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvBaiThi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvBaiThi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBaiThi.Text))
            {
                toolStripStatusLabel1.Text = "Vui lòng nhập mã bài thi!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
            }

            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_ThemBaiThi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaBaiThi", txtMaBaiThi.Text);
                        cmd.ExecuteNonQuery();
                        toolStripStatusLabel1.Text = "Thêm bài thi thành công!";
                        Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                        LoadDanhSachBaiThi();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 50001) // Lỗi do mã bài thi đã tồn tại (từ THROW trong SQL)
                    { 
                        toolStripStatusLabel1.Text = "Mã bài thi đã tồn tại! Hãy nhập mã khác.";
                        Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Lỗi khi thêm bài thi";
                        Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                    }
                }
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
                    using (SqlCommand cmd = new SqlCommand("sp_TimKiemBaiThi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaBaiThi", string.IsNullOrWhiteSpace(txtMaBaiThi.Text) ? (object)DBNull.Value : txtMaBaiThi.Text);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvBaiThi.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            toolStripStatusLabel1.Text = "Không tìm thấy bài thi nào phù hợp!";
                            Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                            toolStripStatusLabel1.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Lỗi tìm kiếm bài thi" + ex.Message;
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                }
            }
        }


        private void btnHienThiChiTiet_Click(object sender, EventArgs e)
        {
  
            if (dgvBaiThi.SelectedRows.Count == 0)
            {
                toolStripStatusLabel1.Text = "Vui lòng chọn bài thi cần xem chi tiết";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                return;
            }

            string maBaiThi = dgvBaiThi.SelectedRows[0].Cells["MaBaiThi"].Value.ToString();
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_HienThiChiTietBaiThi_CauHoi", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaBaiThi", maBaiThi);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvBaiThi.DataSource = dt;
                    DinhDangDataGridView();
                }
                catch (Exception ex)
                {
                   toolStripStatusLabel1.Text = "Lỗi khi hiển thị bài thi "+ ex.Message;
                   Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                }
            }
        }

        

        private void btnHienThiBaiThi_Click(object sender, EventArgs e)
        {
            LoadDanhSachBaiThi();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan = MessageBox.Show("Bạn có chắc chắn muốn thoát không ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(xacnhan == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void dgvBaiThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpNgayThi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

