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
using ComponentFactory.Krypton.Toolkit;
namespace GUI
{
	public partial class NHANVIEN_GUI : KryptonForm
	{
		NHANVIEN_BUS nhanVienBUS = new NHANVIEN_BUS();
		bool createExplore = true;
		int loadedRecord = 0;
		int pageNumber = 1;
		int numberRecord = 5;


		public NHANVIEN_GUI()
		{
			InitializeComponent();
			init();
		}
		public void init()
		{
			initUser();
			panel2_nv.Height = 0;
		}
		public void initUser()
		{
			loadDt_NhanVien();
			loadCb_Gioitinh();
			DelButtonColumn();
			AddButtonColumn_Edit();
			kryTbSearch.Enter += kryTbSearch_Enter;
			kryTbSearch.Leave += kryTbSearch_Leave;
			SetPlaceholder(kryTbSearch, "Tìm kiếm");


		}
		public bool IsPressAdd()
		{
			kryBt_Add.Visible = true;
			return kryBt_Add.Visible;
		}
		public bool IsPressEdit()
		{
			kryBt_Edit.Visible = true;
			return kryBt_Edit.Visible;
		}
//load data và combobox
		public void loadDt_NhanVien()
		{
			DataTable dt = new DataTable();
			dt = nhanVienBUS.GetDanhSachNhanVien();
			//3dt_nhanvien.ColumnHeadersVisible = false;//ẩn header datagridview
			dataViewNv.DataSource = dt;
		}
		public void loadCb_Gioitinh()
		{

			DataTable dtDefault = new DataTable();
			dtDefault.Columns.Add("GIOITINH");
			dtDefault.Rows.Add("Nam");
			dtDefault.Rows.Add("Nữ");

			kryCb_Gender.DisplayMember = "GIOITINH";
			kryCb_Gender.ValueMember = "GIOITINH";
			kryCb_Gender.DataSource = dtDefault;
			
		}
//Xóa các ô khi thoát chỉnh sửa
		public void clear()
		{
			kryTx_Id.Text = "";
			kryTb_Name.Text = "";
			kryCb_Gender.Text = "";
			kryTx_Address.Text = "";
			kryTb_Number.Text = "";
			kryTb_Pos.Text = "";
		}

// Thêm cột chứa nút vào DataGridView
		private void DelButtonColumn()
		{
			// Tạo một cột hình ảnh mới
			DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
			imgColumn.HeaderText = "Xóa";
			imgColumn.Name = "imgDelete";
			//imgColumn.Image = Image.FromFile(@"E:\\CODE\\LapTrinhTrucQuan\\Winform_Kho_v-t_t-\\Images\\icon-delete.png"); // Đường dẫn đến hình ảnh
			//imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
			imgColumn.Width = 20;
			// Thêm cột hình ảnh vào DataGridView
			dataViewNv.Columns.Add(imgColumn);
			// Căn giữa header của cột hình ảnh
			dataViewNv.Columns["imgDelete"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}
		private void AddButtonColumn_Edit()
		{
			// Tạo một cột hình ảnh mới
			DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
			imgColumn.HeaderText = "Edit";
			imgColumn.Name = "imgEdit";
			//imgColumn.Image = Image.FromFile(@"E:\\CODE\\LapTrinhTrucQuan\\Winform_Kho_v-t_t-\\Images\\icon-edit.png"); // Đường dẫn đến hình ảnh
			//imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
																	  // Thêm cột hình ảnh vào DataGridView
			dataViewNv.Columns.Add(imgColumn);
			// Căn giữa header của cột hình ảnh
			dataViewNv.Columns["imgEdit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}
//end

//Chỉnh phần trượt giao diện tạo
		private void createTransition_Tick(object sender, EventArgs e)
		{
			if (createExplore)
			{
				panel2_nv.Height -= 10;
				if (panel2_nv.Height <= 0)
				{
					createTransition.Stop();
					createExplore = false;
				}
			}
			else
			{
				panel2_nv.Height += 10;
				if (panel2_nv.Height >= 170)
				{
					createTransition.Stop();
					createExplore = true;
				}
			}

		}
//Sự kiên database
		private void dataViewNv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = dataViewNv.Rows[e.RowIndex];
			if (e.RowIndex >= 0)
			{
				if (e.ColumnIndex == dataViewNv.Columns["imgEdit"].Index)
				{
					kryTx_Id.Text = row.Cells[2].Value.ToString();
					kryTb_Name.Text = row.Cells[3].Value.ToString();
					kryCb_Gender.Text = row.Cells[4].Value.ToString();
					kry_Datetime.Value = Convert.ToDateTime(row.Cells[5].Value); // Đảm bảo kiểu dữ liệu là DateTime
					kryTx_Address.Text = row.Cells[6].Value.ToString();
					kryTb_Number.Text = row.Cells[7].Value.ToString();
					kryTb_Pos.Text = row.Cells[8].Value.ToString();
					if (Convert.ToInt32(row.Cells[9].Value) == 1)
					{
						kryCheckBox_Status.Checked = true;  // Đánh dấu checkbox
					}
					else
					{
						kryCheckBox_Status.Checked = false; // Bỏ đánh dấu checkbox
					}
					IsPressEdit();
					createTransition.Start();
					if (panel2_nv.Height >= 170)
					{
						createTransition.Stop();
					}
					if (kryBt_Add.Visible)
					{
						kryBt_Add.Visible = false;
					}

				}
			}
			if (e.ColumnIndex == dataViewNv.Columns["imgDelete"].Index)
			{
				DialogResult check = MessageBox.Show("Bạn có muốn xóa nhân viên nay không ?" + "Tài khoản đăng nhập của nhân viên này sẽ bị xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
				if (check == DialogResult.Yes)
				{
					bool result = nhanVienBUS.DeleteNhanVien(row.Cells[2].Value.ToString());
					if (result)
					{
						loadDt_NhanVien();
						MessageBox.Show("Xóa thông tin nhân viên thành công", "Thanhcong", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					else
					{
						MessageBox.Show("Xóa thông tin nhân viên không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

					}
				}
			}
		}

//Sự kiện click
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
				loadDt_NhanVien(); // Gọi lại để tải lại danh sách

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
				loadDt_NhanVien(); // Gọi lại để tải lại danh sách
			}
			else
			{
				MessageBox.Show("Sửa nhân viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void kryBtShowCreate_Click(object sender, EventArgs e)
		{
			kryBt_Add.Visible = true;
			createTransition.Start();
			if (kryBt_Edit.Visible)
			{
				kryBt_Edit.Visible = false;
			}
			if(panel2_nv.Height >= 170)
			{
				createTransition.Stop();

			}
		}

		private void kry_Clear_Click(object sender, EventArgs e)
		{
			clear();
			createTransition.Start();

		}

//End
//Làm mất chữ khi di chuột vào ô
		private void kryTbSearch_Enter(object sender, EventArgs e)
		{
			KryptonTextBox textBox = sender as KryptonTextBox;
			if (textBox != null)
			{
				if (textBox.Text == GetPlaceholder(textBox))
				{
					textBox.Text = "";
					textBox.StateCommon.Content.Color1 = System.Drawing.Color.Black;
				}
			}
		}
		private string GetPlaceholder(KryptonTextBox textBox)
		{
			switch (textBox.Name)
			{
				case "kryTbSearch":
					return "Tìm kiếm...";
				default:
					return string.Empty;
			}
		}

		private void kryTbSearch_Leave(object sender, EventArgs e)
		{
			KryptonTextBox textBox = sender as KryptonTextBox;
			if (textBox != null)
			{
				// Kiểm tra nếu TextBox trống hoặc chứa placeholder
				if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == GetPlaceholder(textBox))
				{
					// Gọi hàm để đặt lại placeholder
					SetPlaceholder(textBox, GetPlaceholder(textBox));
				}
				else
				{
					// Đặt màu chữ về màu đen nếu có nội dung
					textBox.StateCommon.Content.Color1 = System.Drawing.Color.Black;
				}
			}
		}
		private void SetPlaceholder(KryptonTextBox textBox, string placeholder)
		{
			textBox.Text = placeholder;
			textBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
		}
//end
		private void kryBtPredious_Click(object sender, EventArgs e)
		{

		}
	}
}
