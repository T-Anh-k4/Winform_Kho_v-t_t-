using BUS;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class RDLC_1 : KryptonForm
    {
        RDLC_BUS rdlcBus = new RDLC_BUS();
        private string maHDX;
        TEST_GUI testGui = new TEST_GUI();
        public RDLC_1(string _maHDX, TEST_GUI testGui)
        {
            InitializeComponent();
            maHDX = _maHDX;
            this.testGui = testGui;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.CTHDX_RP.rdlc";
            DataSet ds = rdlcBus.GetDanhSachChiTietXuat(maHDX);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "CTHDX1";
                rds.Value = ds.Tables[0];
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
