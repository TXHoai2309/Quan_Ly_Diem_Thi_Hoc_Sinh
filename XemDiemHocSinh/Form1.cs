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

namespace XemDiemHocSinh
{
    public partial class FormXemDiemThiHocSinh : Form
    {
        private string mahocsinh;
        public FormXemDiemThiHocSinh()
        {
            InitializeComponent();
        }
        public FormXemDiemThiHocSinh(string mahs)
        {
            InitializeComponent();
            mahocsinh = mahs; 
            txtMaHocSinh.Text = mahocsinh;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            HienThiDiemThi();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        private void TimKiemDiemThi()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_TimKiemDiemThiHocSinh", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@MaHS", SqlDbType.NVarChar, 10).Value = txtMaHocSinh.Text;
                        cmd.Parameters.Add("@MaBaiThi", SqlDbType.NVarChar, 10).Value =
                            string.IsNullOrWhiteSpace(txtMaBaiThi.Text) ? (object)DBNull.Value : txtMaBaiThi.Text;
                        // Nếu DateTimePicker không chọn ngày, gửi NULL
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvDiemThi.DataSource = dt;
                        DinhDangDataGridview();

                        // Nếu có dữ liệu, lấy họ tên từ kết quả
                        if (dt.Rows.Count > 0)
                        {
                            txtTenHocSinh.Text = dt.Rows[0]["HoTen"].ToString();
                            txtMaLop.Text = dt.Rows[0]["MaLop"].ToString();
                        }
                        else
                        {
                            txtTenHocSinh.Text = ""; // Xóa nếu không có kết quả
                            toolStripStatusLabel1.Text = "Không tìm thấy điểm thi phù hợp!";
                            Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây 
                        }
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Lỗi khi tìm kiếm điểm thi!" + ex.Message;
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây 
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnTimKiemDiemThi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaHocSinh.Text))
            {
                TimKiemDiemThi();
            }
            else
            {
                toolStripStatusLabel1.Text = "Vui lòng nhập mã học sinh!";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
            }
        }
        private void HienThiDiemThi()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_TimKiemDiemThiHocSinh", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaHS", SqlDbType.NVarChar, 10).Value = txtMaHocSinh.Text;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvDiemThi.DataSource = dt;
                        DinhDangDataGridview();

                        // Hiển thị tên học sinh nếu có dữ liệu
                        if (dt.Rows.Count > 0)
                        {
                            txtTenHocSinh.Text = dt.Rows[0]["HoTen"].ToString();
                            txtMaLop.Text = dt.Rows[0]["MaLop"].ToString();
                        }
                        else
                        {

                            txtTenHocSinh.Text = ""; // Nếu không có kết quả, xóa nội dung
                            toolStripStatusLabel1.Text = "Không tìm thấy điểm thi!";
                            Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                        }
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Lỗi khi hiển thị điểm thi!" + ex.Message;
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây 
                }
            }
        }


        private void txtMaHocSinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult dia = MessageBox.Show("Bạn có chắc chắc muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormReportToanBoDiemThi rp = new FormReportToanBoDiemThi(mahocsinh);
            this.Hide();
            rp.ShowDialog();
            this.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
         private void DinhDangDataGridview()
        {
            dgvDiemThi.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvDiemThi.Columns["MaBaiThi"].HeaderText = "Mã Bài Thi";
            dgvDiemThi.Columns["Diem"].HeaderText = "Điểm";
            dgvDiemThi.Columns["NgayThi"].HeaderText = "Ngày Thi";
            dgvDiemThi.Columns["NgayCham"].HeaderText = "Ngày Chấm";
            dgvDiemThi.Columns["MaLop"].HeaderText = "Mã Lớp";
         
        }
    }
}
