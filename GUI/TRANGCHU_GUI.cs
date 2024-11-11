﻿using BUS;
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
            lbtonghangton.Text = Convert.ToString(homeBUS.TongHangTon(month)) + " SP";
        }
        public void CartesianChart(DataTable dt1, DataTable dt2)
        {
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
                Title = "Tiền chi",
                LabelFormatter = value => value.ToString("N0") + " ₫"
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
            cartesianChart1.Series.Add(new LiveCharts.Wpf.ColumnSeries
            {
                Title = "Tiền nhập",
                Values = new LiveCharts.ChartValues<double>(values),
                Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(221, 160, 221)) // Màu tùy chỉnh
            });

            // Thêm chuỗi 2 vào biểu đồ (dữ liệu từ dt2)
            cartesianChart1.Series.Add(new LiveCharts.Wpf.ColumnSeries
            {
                Title = "Tiền xuất",
                Values = new LiveCharts.ChartValues<double>(values1),
                Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(100, 149, 237)) // Màu tùy chỉnh khác
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
        }
        public void PieChart(DataTable dt)
        {
            var colors = new List<System.Windows.Media.Color>
            {
                System.Windows.Media.Color.FromRgb(221, 160, 221), // Màu tím nhạt 1
                System.Windows.Media.Color.FromRgb(186, 85, 211),  // Màu tím nhạt 2
                System.Windows.Media.Color.FromRgb(216, 191, 216), // Màu tím nhạt 3
                System.Windows.Media.Color.FromRgb(148, 0, 211),   // Màu tím đậm hơn
                System.Windows.Media.Color.FromRgb(153, 50, 204)   // Màu tím khác
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
        }
    }
}
