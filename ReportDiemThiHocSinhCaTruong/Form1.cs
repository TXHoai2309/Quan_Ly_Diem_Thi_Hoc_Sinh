using CrystalDecisions.CrystalReports.Engine;
using ReportDiemThiHocSinhCaTruong.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportDiemThiHocSinhCaTruong
{
    public partial class RpDiemThiHocSinhCaTruong : Form
    {
        public RpDiemThiHocSinhCaTruong()
        {
            InitializeComponent();
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void ReportDiemThiHocSinhCaTruong_Load(object sender, EventArgs e)
        {
           

        }

        private void ReportDiemThiHocSinhCaTruong_Load_1(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            tblDiemThi1TableAdapter diemThiTableAdapter = new tblDiemThi1TableAdapter();
            DataTable dt = diemThiTableAdapter.GetData();
            ReportDocument baocaodiemthi = new ReportDocument();
            baocaodiemthi.Load(@"D:\LTHSK\Bài Tập Lớn\ReportDiemThiHocSinhCaTruong\CrystalReport1.rpt");
            baocaodiemthi.SetDataSource(dt);
            crystalReportViewer1.ReportSource = baocaodiemthi;
        }
    }
}
