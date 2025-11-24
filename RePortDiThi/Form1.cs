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

namespace RePortDiThi
{
    public partial class Formrpdithi : Form
    {
        public Formrpdithi()
        {
            InitializeComponent();
        }
        string mahocsinh;
        string tenhocsinh;
        string heso;
        public Formrpdithi(string mahs, string tenhs, string hs)
        {
            InitializeComponent();
            mahocsinh = mahs;
            tenhocsinh = tenhs;
            heso = hs;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = GetInBaoCao(mahocsinh, tenhocsinh,heso);
            ReportDocument rp = new ReportDocument();
            rp.Load(@"D:\LTHSK\Bài Tập Lớn\RePortDiThi\CrystalReport1.rpt");
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();

        }
        private DataTable GetInBaoCao(string mahocsinh, string tenhocsinh, string heso)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("inbaocao", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.SelectCommand.Parameters.AddWithValue("@MaHS", mahocsinh);
                    da.SelectCommand.Parameters.AddWithValue("@HoTen", tenhocsinh);
                    da.SelectCommand.Parameters.AddWithValue("@HESO", heso);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

    }
}
