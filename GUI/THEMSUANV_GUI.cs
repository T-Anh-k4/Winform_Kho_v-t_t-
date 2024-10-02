using BUS;
using Guna.UI2.AnimatorNS;
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

namespace GUI
{
	public partial class THEMSUANV_GUI : Form
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
		}

		public void loadCb_Gioitinh()
		{
			DataTable dt = nhanVienBUS.GetGioiTinh();
			if (dt != null && dt.Rows.Count > 0)
			{
				guna2CbGender.DisplayMember = "GIOITINH";
				guna2CbGender.ValueMember = "GIOITINH";
				guna2CbGender.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Không có dữ liệu giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public void loaddt_nvcreaten()
		{
			DataTable dt = nhanVienBUS.GetDanhSachNhanVien();
			guna2DTNhanVien.DataSource = dt;
		}
		private void THEMSUANV_GUI_Load(object sender, EventArgs e)
		{
			guna2ShadowForm1.SetShadowForm(this);

		}

		private void guna2DTNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = guna2DTNhanVien.Rows[e.RowIndex];
				guna2tbID.Text = row.Cells[0].Value.ToString();
				guna2tbName.Text = row.Cells[1].Value.ToString();
				guna2CbGender.Text = row.Cells[2].Value.ToString();
				guna2DateTime.Value = Convert.ToDateTime(row.Cells[3].Value); // Đảm bảo kiểu dữ liệu là DateTime
				guna2tbAddress.Text = row.Cells[4].Value.ToString();
				guna2tbNumber.Text = row.Cells[5].Value.ToString();
				guna2tbPosition.Text = row.Cells[6].Value.ToString();
				if (Convert.ToInt32(row.Cells[7].Value) == 1)
				{
					guna2CheckBox1.Checked = true;  // Đánh dấu checkbox
				}
				else
				{
					guna2CheckBox1.Checked = false; // Bỏ đánh dấu checkbox
				}
			}
		}

		private void update_Click(object sender, EventArgs e)
		{
			bool result = nhanVienBUS.UpdateNhanVien(guna2tbID.Text, guna2tbName.Text, guna2CbGender.SelectedValue.ToString(), guna2DateTime.Value.ToString("yyyy-MM-dd"), guna2tbAddress.Text, guna2tbNumber.Text, guna2tbPosition.Text, guna2CheckBox1.Checked ? 1 : 0);

			if (result)
			{
				MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				loaddt_nvcreaten(); // Gọi lại để tải lại danh sách
			}
			else
			{
				MessageBox.Show("Thêm nhân viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void add_Click(object sender, EventArgs e)
		{
			// Kiểm tra các trường bắt buộc
			if (string.IsNullOrWhiteSpace(guna2tbID.Text))
			{
				MessageBox.Show("Vui lòng nhập mã nhân viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (string.IsNullOrWhiteSpace(guna2tbName.Text))
			{
				MessageBox.Show("Vui lòng nhập tên nhân viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (guna2CbGender.SelectedIndex == -1)
			{
				MessageBox.Show("Vui lòng chọn giới tính.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (string.IsNullOrWhiteSpace(guna2tbAddress.Text))
			{
				MessageBox.Show("Vui lòng nhập địa chỉ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (string.IsNullOrWhiteSpace(guna2tbNumber.Text))
			{
				MessageBox.Show("Vui lòng nhập số điện thoại.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			bool result = nhanVienBUS.InsertNhanVien(guna2tbID.Text, guna2tbName.Text, guna2CbGender.SelectedValue.ToString(),guna2DateTime.Value.ToString("yyyy-MM-dd"), guna2tbAddress.Text, guna2tbNumber.Text, guna2tbPosition.Text, guna2CheckBox1.Checked ? 1 : 0);

			if (result)
			{
				objectform1.loadDt_NhanVien();
				loaddt_nvcreaten(); // Gọi lại để tải lại danh sách

				MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);			}
			else
			{
				MessageBox.Show("Thêm nhân viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
