using BUS;
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
    public partial class RDLC_GUI : Form
    {
        RDLC_BUS rdlcBus = new RDLC_BUS();
        public RDLC_GUI()
        {
            InitializeComponent();
        }

        private void RDLC_GUI_Load(object sender, EventArgs e)
        {
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.CTHDN_RP.rdlc";

        }
        private void txtSoHDN_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSoHDN.Text))
            {
                DataSet ds = rdlcBus.GetDanhSachChiTietNhap(txtSoHDN.Text);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "CTHDN1";
                    rds.Value = ds.Tables[0];
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);
                }
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
