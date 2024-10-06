using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace GUI
{
	public partial class THEMSUANV_GUI : KryptonForm
	{
		public THEMSUANV_GUI()
		{
			InitializeComponent();
		}
		private NHANVIEN_GUI objectform1;
		NHANVIEN_BUS nhanVienBUS = new NHANVIEN_BUS();

		public THEMSUANV_GUI(NHANVIEN_GUI objectform1)
		{
			InitializeComponent();
			this.objectform1 = objectform1;
			initCreate();
		}

		public void initCreate()
		{
			loadCb_Gioitinh();
			loaddt_nvcreaten(); // Load danh sách nhân viên khi khởi tạo
			AddButtonColumn_Edit();

		}

		public void loadCb_Gioitinh()
		{
			// Tạo bảng DataTable cho giới tính
			DataTable dt = nhanVienBUS.GetGioiTinh();

			// Gán nguồn dữ liệu cho ComboBox
			kryCb_Gender.DisplayMember = "GIOITINH";
			kryCb_Gender.ValueMember = "GIOITINH";
			kryCb_Gender.DataSource = dt;

		}

		public void loaddt_nvcreaten()
		{
			DataTable dt = nhanVienBUS.GetNhanVien(objectform1.Manv);
			kry_DataView_Tsnv.DataSource = dt;
		}
		private void AddButtonColumn_Edit()
		{
			// Tạo một cột nút mới
			DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
			btnColumn.HeaderText = "Chinh sửa";
			btnColumn.Name = "btnEdit";
			btnColumn.Text = "Sửa";
			btnColumn.UseColumnTextForButtonValue = true; // Hiển thị text "Xóa" trên nút
			kry_DataView_Tsnv.Columns.Add(btnColumn);
		}
		public void HideBtAdd()
		{
			kryBt_Add.Visible = false;
		}
		public void HideBtDataView()
		{
			kry_DataView_Tsnv.Visible = false;
		}
		private void kryBt_Add_Click(object sender, EventArgs e)
		{
			// Kiểm tra các trường bắt buộc
			if (string.IsNullOrWhiteSpace(kryTx_Id.Text))
			{
				MessageBox.Show("Vui lòng nhập mã nhân viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (string.IsNullOrWhiteSpace(kryTb_Name.Text))
			{
				MessageBox.Show("Vui lòng nhập tên nhân viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (kryCb_Gender.SelectedIndex == -1)
			{
				MessageBox.Show("Vui lòng chọn giới tính.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (string.IsNullOrWhiteSpace(kryTb_Pos.Text))
			{
				MessageBox.Show("Vui lòng nhập địa chỉ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (string.IsNullOrWhiteSpace(kryTb_Number.Text))
			{
				MessageBox.Show("Vui lòng nhập số điện thoại.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			bool result = nhanVienBUS.InsertNhanVien(kryTx_Id.Text, kryTb_Name.Text, kryCb_Gender.SelectedValue.ToString(), kry_Datetime.Value.ToString("yyyy-MM-dd"), kryTx_Address.Text, kryTb_Number.Text, kryTb_Pos.Text, kryCheckBox_Status.Checked ? 1 : 0);

			if (result)
			{
				objectform1.loadDt_NhanVien();
				loaddt_nvcreaten(); // Gọi lại để tải lại danh sách

				MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Thêm nhân viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void kryBt_Edit_Click(object sender, EventArgs e)
		{
			bool result = nhanVienBUS.UpdateNhanVien(kryTx_Id.Text, kryTb_Name.Text, kryCb_Gender.SelectedValue.ToString(), kry_Datetime.Value.ToString("yyyy-MM-dd"), kryTx_Address.Text, kryTb_Number.Text, kryTb_Pos.Text, kryCheckBox_Status.Checked ? 1 : 0);

			if (result)
			{
				MessageBox.Show("Sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				loaddt_nvcreaten(); // Gọi lại để tải lại danh sách
			}
			else
			{
				MessageBox.Show("Sửa nhân viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void kry_DataView_Tsnv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				if (e.ColumnIndex == kry_DataView_Tsnv.Columns["btnEdit"].Index)
				{
					DataGridViewRow row = kry_DataView_Tsnv.Rows[e.RowIndex];
					kryTx_Id.Text = row.Cells[1].Value.ToString();
					kryTb_Name.Text = row.Cells[2].Value.ToString();
					kryCb_Gender.Text = row.Cells[3].Value.ToString();
					kry_Datetime.Value = Convert.ToDateTime(row.Cells[4].Value); // Đảm bảo kiểu dữ liệu là DateTime
					kryTx_Address.Text = row.Cells[5].Value.ToString();
					kryTb_Number.Text = row.Cells[6].Value.ToString();
					kryTb_Pos.Text = row.Cells[7].Value.ToString();
					if (Convert.ToInt32(row.Cells[8].Value) == 1)
					{
						kryCheckBox_Status.Checked = true;  // Đánh dấu checkbox
					}
					else
					{
						kryCheckBox_Status.Checked = false; // Bỏ đánh dấu checkbox
					}
				}
			}
		}
	}
}
