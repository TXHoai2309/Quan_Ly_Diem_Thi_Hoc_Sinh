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

namespace ReportThongTinHocSinhTheoLop
{
    public partial class FormReportThongTinHocSinhMotLopHoc : Form
    {
        string malophoc; 
        public FormReportThongTinHocSinhMotLopHoc()
        {
            InitializeComponent();
        }
        public FormReportThongTinHocSinhMotLopHoc(string malh)
        {
            InitializeComponent();
            malophoc = malh;    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = GetThongTinHocSinh1LopHoc(malophoc);
            ReportDocument rp = new ReportDocument();
            rp.Load(@"D:\LTHSK\Bài Tập Lớn\ReportThongTinHocSinhTheoLop\CrystalReport1.rpt");
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();
        }
        private DataTable GetThongTinHocSinh1LopHoc(string malophoc)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetThongTinHocSinh1LopHoc", conn))
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
    }
}
