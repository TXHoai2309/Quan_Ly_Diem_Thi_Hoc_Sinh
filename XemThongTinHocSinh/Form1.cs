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

namespace XemThongTinHocSinh
{
    public partial class FormXemThongTinHocSinh : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
        private string mahocsinh; 
        public FormXemThongTinHocSinh()
        {
            InitializeComponent();
        }
        public FormXemThongTinHocSinh(string mahs)
        {
            InitializeComponent();
            mahocsinh = mahs;
            LoadThongTinHocSinh();
        }

        private void LoadThongTinHocSinh()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("sp_XemThongTinHocSinh", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("MaHS", mahocsinh);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtMaHocSinh.Text = reader["MaHS"].ToString();
                        txtTenHocSinh.Text = reader["HoTen"].ToString();
                        txtGioiTinh.Text = reader["GioiTinh"].ToString();
                        dtpNgaySinh.Value = Convert.ToDateTime(reader["NgaySinh"]);
                        txtQueQuan.Text = reader["QueQuan"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txtMaLop.Text = reader["MaLop"].ToString();
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
                    toolStripStatusLabel1.Text = "Lỗi khi tải thông tin học sinh!";
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây

                }
            }
        }


        private void FormXemThongTinHocSinh_Load(object sender, EventArgs e)
        {

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
