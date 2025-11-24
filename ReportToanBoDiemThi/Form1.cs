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

namespace ReportToanBoDiemThi
{
    public partial class FormReportToanBoDiemThi : System.Windows.Forms.Form
    {
        public FormReportToanBoDiemThi()
        {
            InitializeComponent();
        }
        private string mahocsinh; 
        public FormReportToanBoDiemThi(string mahs)
        {
            InitializeComponent();
            mahocsinh = mahs;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
        private DataTable GetToanBoDiemThi(string mahocsinh)
        {
            DataTable dt = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_GetToanBoDiemThi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaHS", mahocsinh);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu điểm thi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = GetToanBoDiemThi(mahocsinh);
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"D:\LTHSK\Bài Tập Lớn\ReportToanBoDiemThi\CrystalReport2.rpt"); 
            cryRpt.SetDataSource(dt);

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
