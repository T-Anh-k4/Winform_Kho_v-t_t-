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

namespace GUI
{
    public partial class BAOCAOHANGXUATKHO_GUI : KryptonForm
    {
        BAOCAOXUATKHO_BUS hanghoa_bus;

        public BAOCAOHANGXUATKHO_GUI()
        {
            hanghoa_bus = new BAOCAOXUATKHO_BUS();
            InitializeComponent();
            HangHoaGui_Load();
            cbx_timkiem.Enabled = false;
            date_tu_ngay.Enabled = false;
            date_den_ngay.Enabled = false;
            txb_Malh.Enabled = false;
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
                DataTable dtHangHoa = hanghoa_bus.GetHangHoa();
                foreach (DataRow row in dtHangHoa.Rows)
                {
                    cbx_timkiem.Items.Add(row["TENHH"].ToString());
                }
        }

        private void check_Hang_hoa_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Hang_hoa.Checked)
            {
                Check_TenKH.Checked = false; 
                Check_ngay.Checked = false;
                cbx_timkiem.Enabled = true;
            }
            UpdateDateControls();
        }

        private void Check_TenKH_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_TenKH.Checked)
            {
                check_Hang_hoa.Checked = false;
                Check_ngay.Checked = false;
                txb_Malh.Enabled = true;
            }
            UpdateDateControls();
        }
        private void UpdateDateControls()
        {
            bool disableDateControls = Check_TenKH.Checked || check_Hang_hoa.Checked;
            date_tu_ngay.Enabled = !disableDateControls;
            date_den_ngay.Enabled = !disableDateControls;          
        }
        private void Check_ngay_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_ngay.Checked)
            {
                Check_TenKH.Checked = false;
                check_Hang_hoa.Checked = false;
                date_tu_ngay.Enabled = true;
                date_den_ngay.Enabled = true;
            }
            bool disableComboBox = date_tu_ngay.Checked || date_den_ngay.Checked;
            cbx_timkiem.Enabled = !disableComboBox;
            txb_Malh.Enabled = !disableComboBox;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            HangHoaGui_Load();
        }

        private void kbtn_timkiem_Click(object sender, EventArgs e)
        {
            string keyword = cbx_timkiem.SelectedItem?.ToString() ?? string.Empty;
            DateTime? fromDate = date_tu_ngay.Checked ? (DateTime?)date_tu_ngay.Value : null;
            DateTime? toDate = date_den_ngay.Checked ? (DateTime?)date_den_ngay.Value : null;
            string keywordKH = txb_Malh.Text.Trim();

            DataTable result;

            if (string.IsNullOrEmpty(keyword) && !fromDate.HasValue && !toDate.HasValue)
            {
                HangHoaGui_Load();
                return;
            }

            if (Check_TenKH.Checked)
            {
                result = hanghoa_bus.SearchKH(keywordKH);

                if (result == null || result.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (check_Hang_hoa.Checked)
            {
                result = hanghoa_bus.SearchHangHoa(keyword);
            }
            else if (Check_ngay.Checked || fromDate.HasValue || toDate.HasValue)
            {
                if (fromDate.HasValue && toDate.HasValue && fromDate.Value >= toDate.Value)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                result = hanghoa_bus.SearchNgay(fromDate, toDate);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một loại tìm kiếm (Nhà cung cấp hoặc Hàng hóa).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            k_datagrview_hang_hoa.DataSource = result;

            cbx_timkiem.SelectedIndex = -1;
            txb_Malh.Clear();
        }


    }
}
