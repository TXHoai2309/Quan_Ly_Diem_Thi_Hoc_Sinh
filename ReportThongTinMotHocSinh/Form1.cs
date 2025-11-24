using CrystalDecisions.CrystalReports.Engine;
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

namespace ReportThongTinMotHocSinh
{
    public partial class FormReportThongTinMotHocSinh : Form
    {
        private string mahocsinh; 
        public FormReportThongTinMotHocSinh()
        {
            InitializeComponent();
        }
        
         public FormReportThongTinMotHocSinh(string mahs)
        {
            InitializeComponent();
            mahocsinh = mahs;
        }
        private void FormReportThongTinMotHocSinh_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = GetThongTinHocSinh(mahocsinh);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin học sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ReportDocument cryRpt = new ReportDocument();
                string reportPath = @"D:\LTHSK\Bài Tập Lớn\ReportThongTinMotHocSinh\CrystalReport1.rpt";
                cryRpt.Load(reportPath);
                cryRpt.SetDataSource(dt); // Gán dữ liệu từ DataTable vào báo cáo

                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable GetThongTinHocSinh(string mahocsinh)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_GetThongTinHocSinh", conn))
                {
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaHS", mahocsinh);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
