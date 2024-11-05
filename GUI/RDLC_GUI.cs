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
        public RDLC_GUI()
        {
            InitializeComponent();
        }

        private void RDLC_GUI_Load(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout); // Đặt chế độ hiển thị xem trước khi in
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            // TODO: This line of code loads data into the 'cTHDNDataSet.CHITIET_HD_NHAP' table. You can move, or remove it, as needed.
            this.cHITIET_HD_NHAPTableAdapter.Fill(this.cTHDNDataSet.CHITIET_HD_NHAP);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.cTHDNTableAdapter.Fill(this.cTHDNDataSet.CTHDN,textBox1.Text);
            this.reportViewer1.RefreshReport();

        }
    }
}
