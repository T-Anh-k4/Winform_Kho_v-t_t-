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

namespace GUI
{
    public partial class BAOCAOHANGNHAPKHO_GUI : Form
    {
        BAOCAONHAPKHO_BUS hanghoa_bus;
        public BAOCAOHANGNHAPKHO_GUI()
        {
            hanghoa_bus = new BAOCAONHAPKHO_BUS();
            InitializeComponent();
            HangHoaGui_Load();
        }

        public void HangHoaGui_Load()
        {
            DataTable dt = new DataTable();
            dt = hanghoa_bus.GetDanhSachHangHoa();
            k_datagrview_hang_hoa.DataSource = dt;
        }

        private void cbx_timkiem_DropDown(object sender, EventArgs e)
        {
            cbx_timkiem.Items.Clear(); // Xóa các mục cũ

            if (Check_TenNcc.Checked) // Nếu tìm theo nhà cung cấp
            {
                DataTable dtNCC = hanghoa_bus.GetNhaCC();
                foreach (DataRow row in dtNCC.Rows)
                {
                    cbx_timkiem.Items.Add(row["TENNCC"].ToString());
                }
            }
            else if (check_Hang_hoa.Checked) // Nếu tìm theo hàng hóa
            {
                DataTable dtHangHoa = hanghoa_bus.GetHangHoa();
                foreach (DataRow row in dtHangHoa.Rows)
                {
                    cbx_timkiem.Items.Add(row["TENHH"].ToString());
                }
            }
        }

        private void check_Hang_hoa_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Hang_hoa.Checked)
            {
                Check_TenNcc.Checked = false; // Bỏ chọn checkbox nhà cung cấp
            }
        }

        private void Check_TenNcc_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_TenNcc.Checked)
            {
                check_Hang_hoa.Checked = false; 
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            HangHoaGui_Load();
        }

        private void kbtn_timkiem_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ ComboBox thay vì TextBox
            string keyword = cbx_timkiem.SelectedItem?.ToString() ?? string.Empty;

            DataTable result;

            // Kiểm tra xem có chọn tìm kiếm theo nhà cung cấp hay không
            if (Check_TenNcc.Checked)
            {
                result = hanghoa_bus.SearchNhaCC(keyword); // Tìm kiếm theo nhà cung cấp
            }
            else if (check_Hang_hoa.Checked)
            {
                result = hanghoa_bus.SearchHangHoa(keyword); // Tìm kiếm theo hàng hóa
            }
            else
            {
                // Nếu không có checkbox nào được chọn, có thể thông báo cho người dùng
                MessageBox.Show("Vui lòng chọn một loại tìm kiếm (Nhà cung cấp hoặc Hàng hóa).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(keyword))
            {
                HangHoaGui_Load(); // Nếu không có từ khóa, làm mới dữ liệu
                return;
            }
            else
            {
                k_datagrview_hang_hoa.DataSource = result; // Cập nhật DataGridView với kết quả tìm kiếm
            }
        }


    }
}
