using BUS;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace GUI
{
    public partial class TRANGCHU_GUI : KryptonForm
    {
        TRANGCHU_BUS homeBUS = new TRANGCHU_BUS();
        bool dangbieudo = false;
        public TRANGCHU_GUI()
        {
            InitializeComponent();
            DataTable dt1 = homeBUS.GetMonthCTHD();
            DataTable dt2 = homeBUS.GetTenNhaCungCap();
            DataTable dt3 = homeBUS.GetMonthCTHDXUAT();
            CartesianChart(dt1,dt3);
            PieChart(dt2);
            loadCb_Month(dt1, dt3);
        }
        public void loadData(int month)
        {
            lbtongtiennhap.Text = Convert.ToString(homeBUS.TongTienNhap(month))+" VNĐ";
            lbtonghangnhap.Text = Convert.ToString(homeBUS.TongHangNhap(month)) + " SP";
            lbtongtienxuat.Text = Convert.ToString(homeBUS.TongTienXuat(month)) + " VNĐ";
            lbtonghangxuat.Text = Convert.ToString(homeBUS.TongHangXuat(month)) + " SP";
            lbtonghangton.Text = Convert.ToString(homeBUS.TongHangTon()) + " SP";
            lbhangton.Text = Convert.ToString(homeBUS.TongHangTonThang(month)) + " SP";

        }
        public void CartesianChart(DataTable dt1, DataTable dt2)
        {
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Tháng",
                Labels = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" },
                Separator = new LiveCharts.Wpf.Separator
                {
                    Step = 1, 
                },
                LabelsRotation = 0 
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Tiền hàng",
                LabelFormatter = value => value.ToString() + " ₫"
            });

            var values = new List<double>();
            for (int i = 0; i < 12; i++) 
            {
                var row1 = dt1.Rows.Cast<DataRow>().FirstOrDefault(r => Convert.ToInt32(r["Thang"]) == i + 1);

                if (row1 != null)
                {
                    values.Add(Convert.ToDouble(row1["TienChi"]));

                }
                else
                {
                    values.Add(0); 
                }
            }
            var values1 = new List<double>();
            for (int i = 0; i < 12; i++)
            {
                var row2 = dt2.Rows.Cast<DataRow>().FirstOrDefault(r => Convert.ToInt32(r["Thang"]) == i + 1);

                if ( row2 != null)
                {
                    values1.Add(Convert.ToDouble(row2["TienChi"]));

                }
                else
                {
                    values1.Add(0);
                }
            }
            if (dangbieudo)
            {
                cartesianChart1.Series.Add(new LiveCharts.Wpf.LineSeries
                {
                    Title = "Tiền nhập",
                    Values = new LiveCharts.ChartValues<double>(values),
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(128, 221, 160, 221)) // Alpha 128 cho độ trong suốt 50%
                });
                cartesianChart1.Series.Add(new LiveCharts.Wpf.LineSeries
                {
                    Title = "Tiền xuất",
                    Values = new LiveCharts.ChartValues<double>(values1),
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(128, 100, 149, 237)) // Màu tùy chỉnh khác
                });
            }
            else
            {
                //Biểu đồ cột  thay LineSeries bằng ColumnSeries 
                cartesianChart1.Series.Add(new LiveCharts.Wpf.ColumnSeries
                {
                    Title = "Tiền nhập",
                    Values = new LiveCharts.ChartValues<double>(values),
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(221, 160, 221)) // Màu tùy chỉnh
                });
                cartesianChart1.Series.Add(new LiveCharts.Wpf.ColumnSeries
                {
                    Title = "Tiền xuất",
                    Values = new LiveCharts.ChartValues<double>(values1),
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(100, 149, 237)) // Màu tùy chỉnh khác
                });
            }
        }
        public void PieChart(DataTable dt)
        {
            var colors = new List<System.Windows.Media.Color>
            {
                System.Windows.Media.Color.FromRgb(0, 123, 255),    // Màu xanh dương
                System.Windows.Media.Color.FromRgb(255, 99, 71),    // Màu đỏ
                System.Windows.Media.Color.FromRgb(40, 167, 69),    // Màu xanh lá
                System.Windows.Media.Color.FromRgb(255, 193, 7),    // Màu vàng
                System.Windows.Media.Color.FromRgb(255, 165, 0),    // Màu cam
                System.Windows.Media.Color.FromRgb(128, 0, 128) // Màu tím


            };
            int colorIndex = 0;
            pieChart1.Series.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string supplierName = row[0].ToString();  
                double amount = Convert.ToDouble(row[1]); 
                pieChart1.Series.Add(new LiveCharts.Wpf.PieSeries
                {
                    Title = supplierName,
                    Values = new LiveCharts.ChartValues<double> { amount },
                    DataLabels = true,
                    LabelPoint = point => $"{point.Y}",
                    Fill = new System.Windows.Media.SolidColorBrush(colors[colorIndex % colors.Count]) // Lấy màu từ danh sách
                });
                colorIndex++;
            }
            pieChart1.LegendLocation = LiveCharts.LegendLocation.Right;
        }



        public void loadCb_Month(DataTable dtDefault, DataTable dtDefault1)
        {
             //dtDefault = homeBUS.GetMonthCTHD();
             //dtDefault1 = homeBUS.GetMonthCTHDXUAT();

            HashSet<string> uniqueMonths = new HashSet<string>();
            foreach (DataRow row in dtDefault.Rows)
            {
                if (row["Thang"] != DBNull.Value)
                {
                    string monthYear = $"{row["Thang"]}";
                    uniqueMonths.Add(monthYear);
                }
            }

            // Lấy tháng từ dtDefault1
            foreach (DataRow row in dtDefault1.Rows)
            {
                if (row["Thang"] != DBNull.Value)
                {
                    string monthYear = $"{row["Thang"]}";
                    uniqueMonths.Add(monthYear);
                }
            }

            // Tạo DataTable để hiển thị trong ComboBox
            DataTable dtMonths = new DataTable();
            dtMonths.Columns.Add("MonthYear", typeof(string));
            foreach (var month in uniqueMonths)
            {
                DataRow newRow = dtMonths.NewRow();
                newRow["MonthYear"] = month;
                dtMonths.Rows.Add(newRow);
            }

            // Gán dữ liệu vào ComboBox
            kryCb_Month.DisplayMember = "MonthYear";
            kryCb_Month.ValueMember = "MonthYear";
            kryCb_Month.DataSource = dtMonths;
            kryCb_Month.Refresh();
        }

        private void kryCb_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kryCb_Month.SelectedValue != null && int.TryParse(kryCb_Month.SelectedValue.ToString(), out int month))
            {
                loadData(month);
                label7.Text = "Tháng "+month.ToString();
            }
        }
        private void btPieNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = homeBUS.GetTenNhaCungCap();
            PieChart(dt);
        }

        private void btpieXuat_Click(object sender, EventArgs e)
        {
            DataTable dt = homeBUS.GetTenKhachHang();
            PieChart(dt);
        }

        private void TRANGCHU_GUI_Load(object sender, EventArgs e)
        {
            loadData(DateTime.Now.Month);
            label7.Text = "Tháng " + (DateTime.Now.Month);
            dangbieudo = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1 = homeBUS.GetMonthCTHD();
            DataTable dt3 = homeBUS.GetMonthCTHDXUAT();
            if (tabControl1.SelectedIndex == 0)
            {
                dangbieudo = false;
                CartesianChart(dt1, dt3);

            }
            else if (tabControl1.SelectedIndex == 1)
            {
                dangbieudo = true;
                CartesianChart(dt1, dt3);


            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedIndex == 0)
            {
                DataTable dt = homeBUS.GetTenNhaCungCap();
                PieChart(dt);
            }
            else if (tabControl2.SelectedIndex == 1)
            {
                DataTable dt = homeBUS.GetTenKhachHang();
                PieChart(dt);

            }
        }
    }
}
