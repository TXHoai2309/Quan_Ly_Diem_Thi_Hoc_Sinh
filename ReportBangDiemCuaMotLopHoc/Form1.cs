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

namespace ReportBangDiemCuaMotLopHoc
{
    public partial class FormReportBangDiem1LopHoc : Form
    {
        public FormReportBangDiem1LopHoc()
        {
            InitializeComponent();
        }
        private string malophoc; 
        public FormReportBangDiem1LopHoc(string malh)
        {
            InitializeComponent();
            malophoc = malh;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
        private DataTable GetBangDiemMotLopHoc(string malophoc)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetBangDiemCuaMotLopHoc", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.SelectCommand.Parameters.AddWithValue("@MaLop", malophoc);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        private void FormReportBangDiem1HocSinh_Load(object sender, EventArgs e)
        {
            DataTable dt = GetBangDiemMotLopHoc(malophoc);
            ReportDocument rp = new ReportDocument();
            rp.Load(@"D:\LTHSK\Bài Tập Lớn\ReportBangDiemCuaMotLopHoc\CrystalReport2.rpt"); 
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh(); 
        }
    }
}
