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

namespace XemThongTinGiaoVien
{
    public partial class FormXemThongTinGiaoVien : Form
    {

        private string magiaovien;
        string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;

        public FormXemThongTinGiaoVien()
        {
            InitializeComponent();
        }
        public FormXemThongTinGiaoVien(string magv)
        {
            InitializeComponent();
            magiaovien = magv;
            LoadThongTinHocSinh();
        }

        private void FormXemThongTinGiaoVien_Load(object sender, EventArgs e)
        {

        }
        private void LoadThongTinHocSinh()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_XemThongTinGiangVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("MaGV", magiaovien);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtMaGiaovien.Text = reader["MaGV"].ToString();
                        txtTenGiaoVien.Text = reader["HoTen"].ToString();
                        txtGioiTinh.Text = reader["GioiTinh"].ToString() ;
                        txtQueQuan.Text = reader["QueQuan"].ToString().Trim();
                        txtSoDienThoai.Text = reader["SoDienThoai"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        dtpNgaySinh.Value = Convert.ToDateTime(reader["NgaySinh"]);

                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Không tìm thấy thông tin học sinh!";
                        Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Lỗi khi tải thông tin giáo viên";
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan = MessageBox.Show("bạn có chắc chắc muốn thoát? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacnhan == DialogResult.Yes)
            {
                this.Close(); // Đóng form hiện tại
               
            }
        }
    }
}

