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
using System.Windows.Input;

namespace GUI
{
	public partial class CHITIETNHAP_GUI : KryptonForm
	{
		private string maHDN;
		CHITIETNHAP_BUS chiTietNhapBUS = new CHITIETNHAP_BUS();
        TEST_GUI testGui = new TEST_GUI();
        bool createExplore = true;
		int limit = 5;
		int curentPage = 1;
		int totalPage = 1; //so trang can tao

		public CHITIETNHAP_GUI(string _maHDN, TEST_GUI testGui)
		{
			InitializeComponent();
			maHDN = _maHDN;
            this.testGui = testGui;
            init();
		}

		public void init()
		{
			initUser();
			panel2_nv.Height = 0;
			soluong.Text = "Chi tiết nhập (" + maHDN + ")";
			dataViewNv.CellFormatting += dataViewNv_CellFormatting;
		}

		public void initUser()
		{
			loadDt_ChiTietNhap();
			loadCb_Gioitinh();
			kryTbSearch.Enter += kryTbSearch_Enter;
			kryTbSearch.Leave += kryTbSearch_Leave;
			kryTx_Id.Enter += kryTbSearch_Enter;
			kryTx_Id.Leave += kryTbSearch_Leave;
			kryTb_Name.Enter += kryTbSearch_Enter;
			kryTb_Name.Leave += kryTbSearch_Leave;
			kryTb_Number.Enter += kryTbSearch_Enter;
			kryTb_Number.Leave += kryTbSearch_Leave;
			kryTx_Address.Enter += kryTbSearch_Enter;
			kryTx_Address.Leave += kryTbSearch_Leave;
			SetPlaceholder(kryTbSearch, "Tìm kiếm");
			SetPlaceholder(kryTb_Name, "Nhập tên hàng hóa");
			SetPlaceholder(kryTb_Number, "Nhập số lượng nhập");
			SetPlaceholder(kryTx_Address, "Nhập đơn giá nhập");
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
		public void loadDt_ChiTietNhap()
		{
			DataTable dt = new DataTable();
			dt = chiTietNhapBUS.GetDanhSachChiTietNhapPage(maHDN, limit, curentPage);
			dataViewNv.DataSource = dt;
			totalPage = chiTietNhapBUS.GetSLChiTietNhap(maHDN) / limit;
			if (totalPage * limit < chiTietNhapBUS.GetSLChiTietNhap(maHDN)) totalPage++;
			EnsureButtonColumnsVisible();
		}

		public void loadCb_Gioitinh()
		{
			DataTable dtDefault = new DataTable();
			dtDefault.Columns.Add("GIOITINH");
			dtDefault.Rows.Add("Nam");
			dtDefault.Rows.Add("Nữ");
		}

		//Xóa các ô khi thoát chỉnh sửa
		public void clear()
		{
			kryTx_Id.Text = "";
			kryTb_Name.Text = "";
			kryTx_Address.Text = "";
			kryTb_Number.Text = "";
		}

		// Thêm cột chứa nút vào DataGridView
		private void DelButtonColumn()
		{
			// Tạo một cột hình ảnh mới
			if (!dataViewNv.Columns.Contains("imgDelete"))
			{
				DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
				imgColumn.HeaderText = "Xóa";
				imgColumn.Name = "imgDelete";
				imgColumn.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\icon-delete.png"));
				imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
				imgColumn.Width = 20;
				// Thêm cột hình ảnh vào DataGridView
				dataViewNv.Columns.Add(imgColumn);
			}
			// Căn giữa header của cột hình ảnh
			dataViewNv.Columns["imgDelete"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataViewNv.Columns["imgDelete"].DisplayIndex = dataViewNv.Columns.Count - 1;
		}

		private void AddButtonColumn_Edit()
		{
			// Tạo một cột hình ảnh mới
			if (!dataViewNv.Columns.Contains("imgEdit"))
			{
				DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
				imgColumn.HeaderText = "Edit";
				imgColumn.Name = "imgEdit";
				imgColumn.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\icon-edit.png"));
				imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
				imgColumn.Width = 20;
				// Thêm cột hình ảnh vào DataGridView
				dataViewNv.Columns.Add(imgColumn);
			}
			// Căn giữa header của cột hình ảnh
			dataViewNv.Columns["imgEdit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataViewNv.Columns["imgEdit"].DisplayIndex = dataViewNv.Columns.Count - 2;
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
				if (panel2_nv.Height >= 125)
				{
					createTransition.Stop();
					createExplore = true;
				}
			}
		}

		//Sự kiên database
		private void dataViewNv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataViewNv.Rows[e.RowIndex];
				if (e.ColumnIndex == dataViewNv.Columns["imgEdit"].Index)
				{
					kryTx_Id.ReadOnly = true;
					kryTx_Id.Text = row.Cells[2].Value.ToString();
					kryTb_Name.Text = row.Cells[3].Value.ToString();
					kryTx_Address.Text = row.Cells[5].Value.ToString();
					kryTb_Number.Text = row.Cells[6].Value.ToString();
					IsPressEdit();
					createTransition.Start();
					if (panel2_nv.Height >= 125)
					{
						createTransition.Stop();
					}
					if (kryBt_Add.Visible)
					{
						kryBt_Add.Visible = false;
					}
				}
				if (e.ColumnIndex == dataViewNv.Columns["imgDelete"].Index)
				{
					DialogResult check = MessageBox.Show("Bạn có muốn xóa chi tiết nhập này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
					if (check == DialogResult.Yes)
					{
						bool result = chiTietNhapBUS.DeleteChiTietNhap(Convert.ToInt32(row.Cells[2].Value), maHDN);
						if (result)
						{
							loadDt_ChiTietNhap();
							MessageBox.Show("Xóa chi tiết nhập thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						else
						{
							MessageBox.Show("Xóa chi tiết nhập không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					clear();
					soluong.Text = "Chi tiết nhập (" + Convert.ToString(chiTietNhapBUS.GetSLChiTietNhap(maHDN)) + ")";
				}
			}
		}

		//Sự kiện click
		private void kryBt_Add_Click(object sender, EventArgs e)
		{

            // Kiểm tra các trường bắt buộc
			if (string.IsNullOrWhiteSpace(kryTb_Name.Text))
			{
				MessageBox.Show("Vui lòng nhập tên hàng hóa.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (string.IsNullOrWhiteSpace(kryTb_Number.Text))
			{
				MessageBox.Show("Vui lòng nhập số lượng nhập.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (string.IsNullOrWhiteSpace(kryTx_Address.Text))
			{
				MessageBox.Show("Vui lòng nhập đơn giá nhập.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			bool result = chiTietNhapBUS.InsertChiTietNhap(kryTb_Name.Text, maHDN, Convert.ToInt32(kryTb_Number.Text), Convert.ToInt32(kryTx_Address.Text));

			if (result)
			{
				loadDt_ChiTietNhap(); // Gọi lại để tải lại danh sách
				MessageBox.Show("Thêm chi tiết nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Thêm chi tiết nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			soluong.Text = "Chi tiết nhập (" + Convert.ToString(chiTietNhapBUS.GetSLChiTietNhap(maHDN)) + ")";
		}

		private void kryBt_Edit_Click(object sender, EventArgs e)
		{
			bool result = chiTietNhapBUS.UpdateChiTietNhap(Convert.ToInt32(kryTx_Id.Text), kryTb_Name.Text, maHDN, Convert.ToInt32(kryTb_Number.Text), Convert.ToInt32(kryTx_Address.Text));

			if (result)
			{
				MessageBox.Show("Sửa chi tiết nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				loadDt_ChiTietNhap(); // Gọi lại để tải lại danh sách
			}
			else
			{
				MessageBox.Show("Sửa chi tiết nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void kry_Clear_Click(object sender, EventArgs e)
		{
			ResetForeText();
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
				case "kryTb_Name":
					return "Nhập tên hàng hóa";
				case "kryTb_Number":
					return "Nhập số lượng nhập";
				case "kryTx_Address":
					return "Nhập đơn giá nhập";
				case "kryTb_Pos":
					return "Nhập số hóa đơn nhập";
				default:
					return string.Empty;
			}
		}

		private void kryTbSearch_Leave(object sender, EventArgs e)
		{
			KryptonTextBox textBox = sender as KryptonTextBox;
			if (textBox != null)
			{
				if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == GetPlaceholder(textBox))
				{
					SetPlaceholder(textBox, GetPlaceholder(textBox));
				}
				else
				{
					textBox.StateCommon.Content.Color1 = System.Drawing.Color.Black;
				}
			}
		}

		private void SetPlaceholder(KryptonTextBox textBox, string placeholder)
		{
			textBox.Text = placeholder;
			textBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
		}

		// reset chữ mặc định
		private void ResetForeText()
		{
			SetPlaceholder(kryTx_Id, GetPlaceholder(kryTx_Id));
			SetPlaceholder(kryTb_Name, GetPlaceholder(kryTb_Name));
			SetPlaceholder(kryTb_Number, GetPlaceholder(kryTb_Number));
			SetPlaceholder(kryTx_Address, GetPlaceholder(kryTx_Address));
		}

		//end
		private void kryBtPredious_Click(object sender, EventArgs e)
		{
			curentPage--;
			loadDt_ChiTietNhap();
			kryBt_Next.Enabled = true;
			if (curentPage == 1)
			{
				kryBtPre.Enabled = false;
			}
			labelSoTrang.Text = Convert.ToString(curentPage);
		}

		private void kryBtNext_Click(object sender, EventArgs e)
		{
			curentPage++;
			loadDt_ChiTietNhap();
			kryBtPre.Enabled = true;
			if (curentPage == totalPage)
			{
				kryBt_Next.Enabled = false;
			}
			labelSoTrang.Text = Convert.ToString(curentPage);
		}


		private void kryBtShowCreate_NV_Click(object sender, EventArgs e)
		{
			kryBt_Add.Visible = true;
			kryTx_Id.ReadOnly = true;
			createTransition.Start();
			if (kryBt_Edit.Visible)
			{
				kryBt_Edit.Visible = false;
			}
			if (panel2_nv.Height >= 125)
			{
				createTransition.Stop();
			}
		}

		// tìm kiếm chi tiết nhập
		private void txb_tim_kiem_LH_TextChanged(object sender, EventArgs e)
		{
			string keyword = txb_tim_kiem_nv.Text.Trim();
			DataTable result = chiTietNhapBUS.SearchChiTietNhap(maHDN, keyword);
			if (string.IsNullOrEmpty(keyword))
			{
				loadDt_ChiTietNhap();
				return;
			}
			else if (keyword == "Tìm kiếm")
			{
				return;
			}
			else
			{
				dataViewNv.DataSource = result;
				EnsureButtonColumnsVisible();
			}
		}

		private void EnsureButtonColumnsVisible()
		{
			// Kiểm tra và thêm cột nếu cần
			DelButtonColumn();
			AddButtonColumn_Edit();

			// Đặt DisplayIndex cho cột "Chỉnh sửa" và "Xóa"
			dataViewNv.Columns["imgEdit"].DisplayIndex = dataViewNv.Columns.Count - 2; // Đặt "Chỉnh sửa" ở vị trí thứ hai từ cuối
			dataViewNv.Columns["imgDelete"].DisplayIndex = dataViewNv.Columns.Count - 1; // Đặt "Xóa" ở vị trí cuối cùng

			// Đặt lại DisplayIndex cho các cột còn lại nếu cần
			int index = 0;
			foreach (DataGridViewColumn column in dataViewNv.Columns)
			{
				if (column.Name != "imgEdit" && column.Name != "imgDelete") // Bỏ qua các cột nút
				{
					column.DisplayIndex = index++;
				}
			}
		}

		private void txb_tim_kiem_LH_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
			}
		}

		//nếu Username rỗng
		private void dataViewNv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			// Kiểm tra cột USERNAME (giả sử cột này là cột thứ 8 trong DataGridView)
			//if (dataViewNv.Columns[e.ColumnIndex].Name == "Tên tài khoản" || txtTenNguoiDung.Text == "") // Thay đổi tên cột nếu cần
			//{
			//    // Kiểm tra xem giá trị có phải là DBNull hay không
			//    if (e.Value == DBNull.Value)
			//    {
			//        e.Value = "null"; // Đặt giá trị hiển thị là "null"
			//        e.FormattingApplied = true; // Đánh dấu là đã áp dụng định dạng
			//    }
			//}
		}


        private void label5_Click(object sender, EventArgs e)
        {
            testGui.eventHangNhap();
        }
    }
}