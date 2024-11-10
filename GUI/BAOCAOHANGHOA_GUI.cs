using BUS;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
	public partial class BAOCAOHANGHOA_GUI : KryptonForm
    {
		HANGHOA_BUS hanghoa_bus = new HANGHOA_BUS();

		public BAOCAOHANGHOA_GUI()
		{
			InitializeComponent();
			// Load dữ liệu từ cơ sở dữ liệu và thực hiện thống kê
			load();
		}

		public void load()
		{
			DataTable dt = hanghoa_bus.GetDanhSachHangHoa();

			Bieudocot(dt);
			bieudoday(dt); 
		}

		public void Bieudocot(DataTable dt)
		{
			// Khai báo biến thống kê
			Dictionary<string, int> thongKeLoaiHang = new Dictionary<string, int>();

			// Duyệt qua các hàng trong DataTable lấy từ cơ sở dữ liệu
			foreach (DataRow row in dt.Rows)
			{
				// Lấy giá trị của cột "Mã loại" từ DataTable
				string loaiHang = row["Mã loại"].ToString();

				// Kiểm tra nếu "Mã loại" không rỗng
				if (!string.IsNullOrEmpty(loaiHang))
				{
					if (thongKeLoaiHang.ContainsKey(loaiHang))
					{
						thongKeLoaiHang[loaiHang]++;
					}
					else
					{
						thongKeLoaiHang[loaiHang] = 1;
					}
				}
			}

			// Hiển thị dữ liệu thống kê trên biểu đồ
			chart1.Series.Clear();
			// Tạo series mới để hiển thị thống kê
			Series series = chart1.Series.Add("Loại hàng hóa");
			series.ChartType = SeriesChartType.Column;

			// Thêm dữ liệu vào biểu đồ
			foreach (var item in thongKeLoaiHang)
			{
				series.Points.AddXY(item.Key, item.Value);
			}
			// Tùy chỉnh trục X và Y của biểu đồ
			chart1.ChartAreas[0].AxisX.Title = "Loại hàng hóa";
			chart1.ChartAreas[0].AxisY.Title = "Số lượng";
			chart1.Titles.Add("Thống kê hàng hóa theo loại");
		}

        private void bieudoday(DataTable dt)
        {
            // Khai báo biến thống kê cho xuất xứ
            Dictionary<string, int> thongKeXuatXu = new Dictionary<string, int>();

            // Duyệt qua các hàng trong DataTable lấy từ cơ sở dữ liệu
            foreach (DataRow row in dt.Rows)
            {
                // Lấy giá trị của cột "Xuất xứ" từ DataTable
                string xuatXu = row["Xuất xứ"].ToString();

                // Kiểm tra nếu "Xuất xứ" không rỗng
                if (!string.IsNullOrEmpty(xuatXu))
                {
                    if (thongKeXuatXu.ContainsKey(xuatXu))
                    {
                        thongKeXuatXu[xuatXu]++;
                    }
                    else
                    {
                        thongKeXuatXu[xuatXu] = 1;
                    }
                }
            }

            // Hiển thị dữ liệu thống kê theo xuất xứ trên biểu đồ dây
            chart2.Series.Clear(); // Giả sử bạn đã thêm chart2 vào form để hiển thị biểu đồ
            Series series = chart2.Series.Add("Xuất xứ hàng hóa");
            series.ChartType = SeriesChartType.Line;  // Thay đổi thành biểu đồ dây

            // Thêm dữ liệu vào biểu đồ dây
            foreach (var item in thongKeXuatXu)
            {
                series.Points.AddXY(item.Key, item.Value);
            }

            // Tùy chỉnh biểu đồ
            chart2.Titles.Add("Thống kê hàng hóa theo xuất xứ");
        }

    }
}
