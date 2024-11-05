using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace GUI
{
    public partial class RDLC_GUI : Form
    {
        RDLC_BUS RDLC_BUS = new RDLC_BUS();
        public RDLC_GUI()
        {
            InitializeComponent();
        }

        private void RDLC_GUI_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = RDLC_BUS.GetDanhSachChiTietNhap();

            // Khai báo chế độ xử lý báo cáo, trường hợp này lấy báo cáo từ local
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            // Chế độ xem report
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout); // Đặt chế độ hiển thị xem trước khi in
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

            // Đường dẫn báo cáo
            // reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.DETAILREPORT.rdlc";

            // Kiểm tra nếu có dữ liệu
            if (ds.Tables[0].Rows.Count > 0)
            {
                // Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "HANGHOA"; // Tên DATASET - Trùng với tên thiết kế trong DataSource
                rds.Value = ds.Tables[0];
                // Xóa dữ liệu cũ của báo cáo (nếu có) trong trường hợp người dùng thực hiện câu truy vấn khác
                reportViewer1.LocalReport.DataSources.Clear();

                // Add dữ liệu vào báo cáo
                reportViewer1.LocalReport.DataSources.Add(rds);

                // Refresh lại báo cáo
                reportViewer1.RefreshReport();
            }

            this.reportViewer1.RefreshReport();
        }
    }
}
