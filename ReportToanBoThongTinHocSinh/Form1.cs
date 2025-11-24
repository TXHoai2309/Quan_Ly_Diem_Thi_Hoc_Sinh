using CrystalDecisions.CrystalReports.Engine;
using ReportToanBoThongTinHocSinh.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportToanBoThongTinHocSinh
{
    public partial class FormReportToanBoHocSinh : Form
    {
        public FormReportToanBoHocSinh()
        {
            InitializeComponent();
        }

        private void FormReportToanBoHocSinh_Load(object sender, EventArgs e)
        {
            tblHocSinhTableAdapter toanbohocsinh = new tblHocSinhTableAdapter();
            DataTable dt = toanbohocsinh.GetData();
            ReportDocument baocaotoanbohocsinh = new ReportDocument();
            baocaotoanbohocsinh.Load(@"D:\LTHSK\Bài Tập Lớn\ReportToanBoThongTinHocSinh\CrystalReport1.rpt");
            baocaotoanbohocsinh.SetDataSource(dt);
            crystalReportViewer1.ReportSource = baocaotoanbohocsinh;

        }
    }
}
