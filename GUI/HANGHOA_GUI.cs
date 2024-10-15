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
using BUS;

namespace GUI
{
	public partial class HANGHOA_GUI : KryptonForm
	{
		private HANGHOA_BUS hanghoa_bus;

		public bool createExplore = true;

		int pageNumber = 1;
		int numberrecord = 13;
		public HANGHOA_GUI()
		{
			InitializeComponent();
			hanghoa_bus = new HANGHOA_BUS();
			init();
		}

		public void init()
		{
			initUser();
			HangHoaGui_Load();
			AddButtonColumn();
			AddButtonColumn_Edit();
		}

		//thiết lập ban đầu của form
		public void initUser()
		{
			pn_nhap.Height = 0;
			pn_data.Height = 620;

			txb_Mahh.Enter += TextBox_Enter;
			txb_Mahh.Leave += TextBox_Leave;

			txb_Ten_hang.Enter += TextBox_Enter;
			txb_Ten_hang.Leave += TextBox_Leave;

			txb_xuat_xu.Enter += TextBox_Enter;
			txb_xuat_xu.Leave += TextBox_Leave;

			txb_tim_kiem_HH.Enter += TextBox_Enter;
			txb_tim_kiem_HH.Leave += TextBox_Leave;

			SetPlaceholder(txb_Mahh, "Nhập mã hàng hóa");
			SetPlaceholder(txb_Ten_hang, "Nhập tên hàng");
			SetPlaceholder(txb_xuat_xu, "Nhập xuất xứ");
			SetPlaceholder(txb_tim_kiem_HH, "Tìm kiếm");

		}
		public bool IsPressAdd()
		{
			kbtn_Them_sua.Visible = true;
			return kbtn_Them_sua.Visible;
		}
		public bool IsPressEdit()
		{
			kbtn_sua.Visible = true;
			return kbtn_sua.Visible;
		}

		// thêm giá trị vào combox
		private void cbx_don_vi_tinh_DropDown(object sender, EventArgs e)
		{
			cbx_don_vi_tinh.Items.Clear();
			cbx_don_vi_tinh.Items.Add("Kg");
			cbx_don_vi_tinh.Items.Add("Thùng");
			cbx_don_vi_tinh.Items.Add("Cái");
		}

		// thêm nút sửa và xóa vào Datagrview
		private void AddButtonColumn()
		{
			if (!k_datagrview_hang_hoa.Columns.Contains("btnDelete"))
			{
				DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();

				btnColumn.HeaderText = "Xóa";
				btnColumn.Name = "btnDelete";
				btnColumn.Text = "Xóa";
				btnColumn.UseColumnTextForButtonValue = true;

				k_datagrview_hang_hoa.Columns.Add(btnColumn);
			}
			k_datagrview_hang_hoa.Columns["btnDelete"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}
		private void AddButtonColumn_Edit()
		{
			if (!k_datagrview_hang_hoa.Columns.Contains("btnEdit"))
			{
				DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
				btnColumn.HeaderText = "Chinh sửa";
				btnColumn.Name = "btnEdit";
				btnColumn.Text = "Sửa";
				btnColumn.UseColumnTextForButtonValue = true;
				k_datagrview_hang_hoa.Columns.Add(btnColumn);
			}
			k_datagrview_hang_hoa.Columns["btnEdit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}

		// Sự kiện cho chữ ở textbox
		private void TextBox_Enter(object sender, EventArgs e)
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

		private void TextBox_Leave(object sender, EventArgs e)
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

		private string GetPlaceholder(KryptonTextBox textBox)
		{
			switch (textBox.Name)
			{
				case "txb_Mahh":
					return "Nhập mã hàng hóa";
				case "txb_Ten_hang":
					return "Nhập tên hàng";
				case "txb_xuat_xu":
					return "Nhập xuất xứ";
				case "txb_tim_kiem_HH":
					return "Tìm kiếm";
				default:
					return string.Empty;
			}
		}

		// reset chữ mặc định
		private void ResetForeText()
		{
			SetPlaceholder(txb_Mahh, GetPlaceholder(txb_Mahh));
			SetPlaceholder(txb_Ten_hang, GetPlaceholder(txb_Ten_hang));
			SetPlaceholder(txb_xuat_xu, GetPlaceholder(txb_xuat_xu));
		}
		// load datagrview
		public void HangHoaGui_Load()
		{
			DataTable dt = new DataTable();
			dt = hanghoa_bus.GetDanhSachHangHoa();
			k_datagrview_hang_hoa.DataSource = dt;
			//if (dt.Rows.Count > 0)
			//{
			//	k_datagrview_hang_hoa.DataSource = LoadRecord(pageNumber, numberrecord, dt);
			//}
			//else
			//{
			//	MessageBox.Show("Không có dữ liệu để hiển thị.");
			//}
		}
		//private List<HANGHOA> LoadRecord(int page, int recordNum, DataTable dt)
		//{
		//	List<HANGHOA> result = new List<HANGHOA>();

		//	int startIndex = (page - 1) * recordNum;
		//	int endIndex = startIndex + recordNum;

		//	for (int i = startIndex; i < endIndex && i < dt.Rows.Count; i++)
		//	{
		//		HANGHOA hanghoa = new HANGHOA
		//		{

		//			MAHH = dt.Rows[i]["MAHH"].ToString(),
		//			TENHH = dt.Rows[i]["TenHang"].ToString(),
		//			XUATXU = dt.Rows[i]["XuatXu"].ToString(),
		//			MALOAI = dt.Rows[i]["MaLoai"].ToString(),
		//			DONVI_TINH = cbx_don_vi_tinh.SelectedItem?.ToString() 
		//		};
		//		result.Add(hanghoa);
		//	}

		//	return result;
		//}

		// Nút sang trang
		//private void bt_next_page_Click(object sender, EventArgs e)
		//{
		//	int totalrecord = 0;
		//	using (ThongTinHangHoaDataContext db = new ThongTinHangHoaDataContext())
		//	{
		//		totalrecord = db.HANGHOAs.Count();
		//	}
		//	int totalPages = (int)Math.Ceiling((double)totalrecord / numberrecord);
		//	if (pageNumber < totalPages)
		//	{
		//		pageNumber++;
		//		k_datagrview_hang_hoa.DataSource = LoadRecord(pageNumber, numberrecord, hanghoa_bus.GetDanhSachHangHoa());
		//		lb_so_trang.Text = pageNumber.ToString();
		//	}
		//}

		//private void bt_back_page_Click(object sender, EventArgs e)
		//{
		//	if (pageNumber - 1 > 0)
		//	{
		//		pageNumber--;
		//		k_datagrview_hang_hoa.DataSource = LoadRecord(pageNumber, numberrecord, hanghoa_bus.GetDanhSachHangHoa());
		//		lb_so_trang.Text = pageNumber.ToString();
		//	}
		//}

		/*animation*/
		private void createTransition_Tick_1(object sender, EventArgs e)
		{
			if (createExplore)
			{
				pn_nhap.Height -= 10;
				if (pn_nhap.Height <= 0)
				{
					createTransition.Stop();
					createExplore = false;

					//pn_data.Size = new Size(1069, 620);
					//k_datagrview_hang_hoa.RowTemplate.Height = 44; 
					//foreach (DataGridViewRow row in k_datagrview_hang_hoa.Rows)
					//{
					//	row.Height = k_datagrview_hang_hoa.RowTemplate.Height;
					//}
				}
			}
			else
			{
				pn_nhap.Height += 10;
				if (pn_nhap.Height >= 232)
				{
					createTransition.Stop();
					createExplore = true;

					//pn_data.Size = new Size(1069, 408); 
					//k_datagrview_hang_hoa.RowTemplate.Height = 29;  
					//foreach (DataGridViewRow row in k_datagrview_hang_hoa.Rows)
					//{
					//	row.Height = k_datagrview_hang_hoa.RowTemplate.Height;
					//}
				}
			}
		}

		// nút tạo panel nhập
		private void kbtn_themSua_Click(object sender, EventArgs e)
		{
			kbtn_Them_sua.Visible = true;
			createTransition.Start();
			if (kbtn_sua.Visible)
			{
				kbtn_sua.Visible = false;
			}
			if (pn_nhap.Height >= 232)
				createTransition.Stop();

		}
		// nút sự kiện thêm hàng hóa
		private void kbtn_Them_sua_Click(object sender, EventArgs e)
		{
			bool isValid = true;

			string mahh = txb_Mahh.Text;
			string maloai = cbx_ma_loai.SelectedItem?.ToString();
			string tenhang = txb_Ten_hang.Text;
			string xuatxu = txb_xuat_xu.Text;
			string dvt = cbx_don_vi_tinh.SelectedItem?.ToString();

			if (string.IsNullOrWhiteSpace(txb_Mahh.Text) || txb_Mahh.Text == "Nhập mã hàng hóa")
			{
				MessageBox.Show("Vui lòng nhập mã hàng hóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				isValid = false;
			}
			else if (string.IsNullOrWhiteSpace(txb_Ten_hang.Text) || txb_Ten_hang.Text == "Nhập tên hàng")
			{
				MessageBox.Show("Vui lòng nhập tên hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				isValid = false;
			}
			else if (cbx_ma_loai.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn mã loại hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				isValid = false;
			}
			else if (cbx_don_vi_tinh.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn đơn vị tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				isValid = false;
			}
			else if (string.IsNullOrWhiteSpace(txb_xuat_xu.Text) || txb_xuat_xu.Text == "Nhập xuất xứ")
			{
				MessageBox.Show("Vui lòng nhập xuất xứ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				isValid = false;
			}
			else
			{
				bool them = hanghoa_bus.InsertHangHoa(mahh, maloai, tenhang, dvt, xuatxu);
				if (them)
				{
					HangHoaGui_Load();
					MessageBox.Show("Thêm hàng hóa thành công!");
					txb_Mahh.Clear();
					txb_Ten_hang.Clear();
					cbx_ma_loai.SelectedIndex = -1;
					txb_xuat_xu.Clear();
					cbx_don_vi_tinh.SelectedIndex = -1;
					ResetForeText();
				}
				else
				{
					MessageBox.Show("Có lỗi xảy ra khi thêm hàng hóa.");
				}
			}
		}


		//sự kiện xóa hàng hóa và tương tác nút sửa hiện pn_nhap
		private void dtgrview_hang_hoa_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			// Kiểm tra xem hàng có hợp lệ không
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = k_datagrview_hang_hoa.Rows[e.RowIndex];

				// Kiểm tra cột được nhấn có phải là btnDelete không
				if (e.ColumnIndex == k_datagrview_hang_hoa.Columns["btnDelete"].Index)
				{
					// Hiển thị MessageBox để xác nhận xóa
					DialogResult dialogResult = MessageBox.Show(
						"Bạn có chắc chắn muốn xóa thông tin hàng hóa này không?",
						"Xác nhận xóa",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question
					);

					if (dialogResult == DialogResult.Yes)
					{
						bool result = hanghoa_bus.DeleteHangHoa(row.Cells["Mã hàng hóa"].Value.ToString());
						if (result)
						{
							HangHoaGui_Load();
							MessageBox.Show("Xóa thông tin hàng hóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						else
						{
							MessageBox.Show("Xóa thông tin hàng hóa không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}

				// Kiểm tra cột được nhấn có phải là btnEdit không
				if (e.ColumnIndex == k_datagrview_hang_hoa.Columns["btnEdit"].Index)
				{

					txb_Mahh.Text = row.Cells[2].Value?.ToString();
					string maloai = row.Cells["Mã loại"]?.Value?.ToString();
					txb_Ten_hang.Text = row.Cells[4].Value?.ToString();
					txb_xuat_xu.Text = row.Cells[6].Value?.ToString();
					string dvt = row.Cells["Đơn vị"]?.Value?.ToString();

					if (!string.IsNullOrEmpty(dvt))
					{
						if (!cbx_don_vi_tinh.Items.Contains(dvt))
						{
							cbx_don_vi_tinh.Items.Add(dvt);
						}
						cbx_don_vi_tinh.SelectedItem = dvt;
					}
					else
					{
						MessageBox.Show("Giá trị đơn vị không hợp lệ!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}

					IsPressEdit();
					createTransition.Start();
					txb_Mahh.Enabled = false;
					if (pn_nhap.Height > 232)
					{
						createTransition.Stop();

					}
					if (kbtn_Them_sua.Visible)
					{
						kbtn_Them_sua.Visible = false;
					}
				}
			}
		}

		// nút sự kiện sửa hàng hóa
		private void kbtn_sua_Click(object sender, EventArgs e)
		{
			string mahh = txb_Mahh.Text;
			string malh = cbx_ma_loai.SelectedItem?.ToString();
			string tenHang = txb_Ten_hang.Text;
			string dvt = cbx_don_vi_tinh.SelectedItem?.ToString();
			string xuatXu = txb_xuat_xu.Text;

			bool result = hanghoa_bus.UpdateHanhHoa(mahh, malh, tenHang, dvt, xuatXu);
			if (result)
			{
				HangHoaGui_Load();
				MessageBox.Show("Sửa thông tin hàng hóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txb_Mahh.Clear();
				cbx_ma_loai.SelectedIndex = -1;
				txb_Ten_hang.Clear();
				txb_xuat_xu.Clear();
				cbx_don_vi_tinh.SelectedIndex = -1;
				ResetForeText();

			}
			else
			{
				MessageBox.Show("Sửa thông tin hàng hóa không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// phương thức tìm kiếm hàng hóa
		private void txb_tim_kiem_HH_TextChanged_1(object sender, EventArgs e)
		{
			string keyword = txb_tim_kiem_HH.Text.Trim();
			DataTable result = hanghoa_bus.SearchHangHoa(keyword);

			if (string.IsNullOrEmpty(keyword))
			{
				HangHoaGui_Load();
				return;
			}

			if (keyword == "Tìm kiếm")
			{
				return;
			}
			else if (result != null && result.Rows.Count > 0)
			{
				k_datagrview_hang_hoa.DataSource = result;

				// Kiểm tra sự tồn tại của các cột trước khi thao tác
				if (k_datagrview_hang_hoa.Columns.Contains("btnDelete"))
				{
					k_datagrview_hang_hoa.Columns["btnDelete"].Visible = true;
					k_datagrview_hang_hoa.Columns["btnDelete"].DisplayIndex = k_datagrview_hang_hoa.Columns.Count - 1;
				}

				if (k_datagrview_hang_hoa.Columns.Contains("btnEdit"))
				{
					k_datagrview_hang_hoa.Columns["btnEdit"].Visible = true;
					k_datagrview_hang_hoa.Columns["btnEdit"].DisplayIndex = k_datagrview_hang_hoa.Columns.Count - 2;
				}
			}
			else
			{
				k_datagrview_hang_hoa.DataSource = null;
				if (k_datagrview_hang_hoa.Columns.Contains("btnDelete"))
				{
					k_datagrview_hang_hoa.Columns["btnDelete"].Visible = false;
				}
				if (k_datagrview_hang_hoa.Columns.Contains("btnEdit"))
				{
					k_datagrview_hang_hoa.Columns["btnEdit"].Visible = false;
				}
			}
		}

		// sự kiện show lỗi
		private void ShowError(string message)
		{
			MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		// nút quay lại
		private void kbtn_Cancle_Click(object sender, EventArgs e)
		{
			if (pn_nhap.Height > 232)
			{
				createTransition.Start();

			}
			txb_Mahh.Clear();
			cbx_ma_loai.SelectedIndex = -1;
			txb_Ten_hang.Clear();
			txb_xuat_xu.Clear();
			cbx_don_vi_tinh.SelectedIndex = -1;
			ResetForeText();
		}
		//cbx loại hàng
		private void cbx_ma_loai_DropDown(object sender, EventArgs e)
		{
			cbx_ma_loai.Items.Clear();
			DataTable dtLoaiHang = hanghoa_bus.GetLoaiHang();
			foreach (DataRow row in dtLoaiHang.Rows)
			{
				cbx_ma_loai.Items.Add(row["MALOAI"].ToString());
			}
		}
	}
}
