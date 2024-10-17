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
using BUS;
using DTO;
using System.Management.Instrumentation;
namespace GUI
{
	public partial class USER_GUI : KryptonForm
	{
		USER_BUS userBUS = new USER_BUS();
		bool createExplore = true;
		public USER_GUI()
		{
			InitializeComponent();
			panel2_nv.Height = 0;
			loadDataUser();
			loadCb_LoaiUser();
		}
		public void loadDataUser()
		{
			DataTable dt = new DataTable();
			dt = userBUS.GetDataUserName();
			dataViewUser.DataSource = dt;
			EnsureButtonColumnsVisible();
		}
		public void loadCb_LoaiUser()
		{
			DataTable dtDefault = new DataTable();
			dtDefault.Columns.Add("LOAI");
			dtDefault.Rows.Add("Admin");
			dtDefault.Rows.Add("Người dùng");

			kryCb_Loai.DisplayMember = "LOAI";
			kryCb_Loai.ValueMember = "LOAI";
			kryCb_Loai.DataSource = dtDefault;
		}
		private void DelButtonColumn()
		{
			// Tạo một cột hình ảnh mới
			if (!dataViewUser.Columns.Contains("imgDelete"))
			{
				DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
				imgColumn.HeaderText = "Xóa";
				imgColumn.Name = "imgDelete";
				//imgColumn.Image = Image.FromFile(@"E:\\CODE\\LapTrinhTrucQuan\\Winform_Kho_v-t_t-\\Images\\icon-delete.png"); // Đường dẫn đến hình ảnh
				imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
				imgColumn.Width = 20;
				// Thêm cột hình ảnh vào DataGridView
				dataViewUser.Columns.Add(imgColumn);
			} 
			// Căn giữa header của cột hình ảnh
			dataViewUser.Columns["imgDelete"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataViewUser.Columns["imgDelete"].DisplayIndex = dataViewUser.Columns.Count - 1;

		}
		private void AddButtonColumn_Edit()
		{
			// Tạo một cột hình ảnh mới
			if (!dataViewUser.Columns.Contains("imgEdit"))
			{
				DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
				imgColumn.HeaderText = "Edit";
				imgColumn.Name = "imgEdit";
				imgColumn.Image = Image.FromFile(@"E:\\CODE\\LapTrinhTrucQuan\\Winform_Kho_v-t_t-\\Images\\icon-edit.png"); // Đường dẫn đến hình ảnh
				imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
																		  // Thêm cột hình ảnh vào DataGridView
				dataViewUser.Columns.Add(imgColumn);
			}
			// Căn giữa header của cột hình ảnh
			dataViewUser.Columns["imgEdit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataViewUser.Columns["imgEdit"].DisplayIndex = dataViewUser.Columns.Count - 2;

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

		private void createTransition_Tick(object sender, EventArgs e)
		{
			if (createExplore)
			{
				panel2_nv.Height -= 10;
				if (panel2_nv.Height <= 0)
				{
					createTransition_User.Stop();
					createExplore = false;
				}
			}
			else
			{
				panel2_nv.Height += 10;
				if (panel2_nv.Height >= 170)
				{
					createTransition_User.Stop();
					createExplore = true;
				}
			}
		}

		private void kryBtShowCreate_User_Click(object sender, EventArgs e)
		{
			kryBt_Add.Visible = true;
			createTransition_User.Start();
			if (kryBt_Edit.Visible)
			{
				kryBt_Edit.Visible = false;
			}
			if (panel2_nv.Height >= 170)
			{
				createTransition_User.Stop();

			}
		}

		private void dataViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = dataViewUser.Rows[e.RowIndex];
				if (e.ColumnIndex == dataViewUser.Columns["imgEdit"].Index)
				{
					kryTb_Name.Text = row.Cells[2].Value.ToString();
					kryTb_Pass.Text = row.Cells[3].Value.ToString();
					kryTbManv.Text = row.Cells[4].Value.ToString();
					kryCb_Loai.Text = row.Cells[5].Value.ToString();
					if (Convert.ToInt32(row.Cells[6].Value) == 1)
					{
						kryStatus.Checked = true;  // Đánh dấu checkbox
					}
					else
					{
						kryStatus.Checked = false; // Bỏ đánh dấu checkbox

					}
					IsPressEdit();
					createTransition_User.Start();
					if (panel2_nv.Height >= 170)
					{
						createTransition_User.Stop();
					}
					if (kryBt_Add.Visible)
					{
						kryBt_Add.Visible = false;
					}
				}
				if (e.ColumnIndex == dataViewUser.Columns["imgDelete"].Index)
				{
					DialogResult check = MessageBox.Show("Bạn có muốn xóa tài khoản này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
					if (check == DialogResult.Yes)
					{
						bool result = userBUS.DeleteUser(row.Cells[2].Value.ToString());
						//MessageBox.Show(Convert.ToString(row.Cells[2].Value.ToString()));
						if (result)
						{
							loadDataUser();
							MessageBox.Show("Xóa thông tin nguoi dung thành công", "Thanhcong", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						else
						{
							MessageBox.Show("Xóa thông tin nguoi dung không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

						}
					}
				}			
		}

		private void kryBt_Add_Click(object sender, EventArgs e)
		{
			// Kiểm tra các trường bắt buộc
			if (string.IsNullOrWhiteSpace(kryTb_Name.Text))
			{
				MessageBox.Show("Vui lòng nhập tên người dung.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (string.IsNullOrWhiteSpace(kryTb_Pass.Text))
			{
				MessageBox.Show("Vui lòng nhập mật khẩu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (string.IsNullOrWhiteSpace(kryTb_Pass1.Text) )
			{
				MessageBox.Show("Vui lòng nhập lại mật khẩu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if(kryTb_Pass1.Text != kryTb_Pass1.Text)
			{
				MessageBox.Show("Nhập sai mật khẩu . Vui lòng nhập lại.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
			if (kryCb_Loai.SelectedIndex == -1)
			{
				MessageBox.Show("Vui lòng chọn loại người dùng.", "Thếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			bool result = userBUS.InsertUser(kryTb_Name.Text, kryTb_Pass.Text, kryCb_Loai.SelectedValue.ToString(), kryStatus.Checked ? 1 : 0);

			if (result)
			{
				loadDataUser(); // Gọi lại để tải lại danh sách

				MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Thêm nhân viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void kryBt_Edit_Click(object sender, EventArgs e)
		{
			kryTb_Name.ReadOnly = true;
			bool result = userBUS.UplateUser(kryTb_Name.Text, kryTb_Pass.Text, kryCb_Loai.SelectedValue.ToString(), kryStatus.Checked ? 1 : 0);

			if (result)
			{
				MessageBox.Show("Sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				loadDataUser(); // Gọi lại để tải lại danh sách
			}
			else
			{
				MessageBox.Show("Sửa nhân viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void kry_Clear_Click(object sender, EventArgs e)
		{
			clear();
			createTransition_User.Start();

		}
		public void clear()
		{
			kryTb_Name.Text = "";
			kryTb_Pass.Text = "";
			kryTb_Pass1.Text = "";
			kryCb_Loai.Text = "";
			kryStatus.Text = "";

		}

		private void kryStatus_CheckedChanged(object sender, EventArgs e)
		{
			if (kryStatus.Checked == true)
			{
				kryStatus.Text = "Đang hoạt động";
			}
			else
			{
				kryStatus.Text = "Không hoạt động";

			}
		}

		private void txb_tim_kiem_LH_TextChanged(object sender, EventArgs e)
		{
			string keyword = txb_tim_kiem_LH.Text.Trim();
			DataTable result = userBUS.SearchUser(keyword);
			if (string.IsNullOrEmpty(keyword))
			{
				loadDataUser();
				return;
			}

			else if (keyword == "Tìm kiếm")
			{
				return;
			}
			else
			{
				dataViewUser.DataSource = result;
				EnsureButtonColumnsVisible();
			}
		}
		private void EnsureButtonColumnsVisible()
		{
			// Kiểm tra và thêm cột nếu cần
			DelButtonColumn();
			AddButtonColumn_Edit();

			// Đặt DisplayIndex cho cột "Chỉnh sửa" và "Xóa"
			dataViewUser.Columns["imgEdit"].DisplayIndex = dataViewUser.Columns.Count - 2; // Đặt "Chỉnh sửa" ở vị trí thứ hai từ cuối
			dataViewUser.Columns["imgDelete"].DisplayIndex = dataViewUser.Columns.Count - 1; // Đặt "Xóa" ở vị trí cuối cùng

			// Đặt lại DisplayIndex cho các cột còn lại nếu cần
			int index = 0;
			foreach (DataGridViewColumn column in dataViewUser.Columns)
			{
				if (column.Name != "imgEdit" && column.Name != "imgDelete") // Bỏ qua các cột nút
				{
					column.DisplayIndex = index++;
				}
			}
		}
		private void txb_tim_kiem_LH_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
			}
		}
	}
}
