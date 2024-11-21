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
	public partial class LOAIHANG_GUI : KryptonForm
	{
		private LOAIHANG_BUS LoaiHang_BUS;
		public bool createExplore = true;
        int limit = 5;
        int curentPage = 1;
        int totalPage = 1;//so trang can tao
        public LOAIHANG_GUI()
		{
			LoaiHang_BUS = new LOAIHANG_BUS();
			InitializeComponent();
			init();		
		}
		public void init()
		{
			initUser();
            soluong.Text = "Loại hàng (" + Convert.ToString(LoaiHang_BUS.GetSLLoaiHang()) + ")";
            LoaiHangGui_Load();
	
		}
		//thiết lập ban đầu của form
		public void initUser()
		{
			pn_nhap.Height = 0;
			pn_data.Height = 620;


			txb_Ten_loai_hang.Enter += TextBox_Enter;
			txb_Ten_loai_hang.Leave += TextBox_Leave;

			txb_Malh.Enter += TextBox_Enter;
			txb_Malh.Leave += TextBox_Leave;

			txb_Dien_giai.Enter += TextBox_Enter;
			txb_Dien_giai.Leave += TextBox_Leave;

			txb_tim_kiem_LH.Enter += TextBox_Enter;
			txb_tim_kiem_LH.Leave += TextBox_Leave;

			SetPlaceholder(txb_Ten_loai_hang, "Nhập tên loại hàng");
			SetPlaceholder(txb_Malh, "Nhập mã loại hàng");
			SetPlaceholder(txb_Dien_giai, "Nhập diễn giải");
			SetPlaceholder(txb_tim_kiem_LH, "Tìm kiếm");

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
		public void LoaiHangGui_Load()
		{
            DataTable dt = new DataTable();
            dt = LoaiHang_BUS.getDanhSachLoaiHangPage(limit, curentPage);
            //3dt_nhanvien.ColumnHeadersVisible = false;//ẩn header datagridview
            k_datagrview_Loai_hang.DataSource = dt;
            totalPage = LoaiHang_BUS.GetSLLoaiHang() / limit;
            if (totalPage * limit < LoaiHang_BUS.GetSLLoaiHang()) totalPage++;
            EnsureButtonColumnsVisible();
		}
		// Thêm cột sửa xóa vào datagridview
		private void AddButtonColumn()
		{
			if (!k_datagrview_Loai_hang.Columns.Contains("btnDelete"))
			{
				DataGridViewImageColumn btnColumn = new DataGridViewImageColumn();

				btnColumn.HeaderText = "Xóa";
				btnColumn.Name = "btnDelete";
                btnColumn.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\icon-delete.png"));
                btnColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
                btnColumn.Width = 20;

				k_datagrview_Loai_hang.Columns.Add(btnColumn);
			}
			k_datagrview_Loai_hang.Columns["btnDelete"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			k_datagrview_Loai_hang.Columns["btnDelete"].DisplayIndex = k_datagrview_Loai_hang.Columns.Count - 1;

		}
		private void AddButtonColumn_Edit()
		{
			if (!k_datagrview_Loai_hang.Columns.Contains("btnEdit"))
			{
				DataGridViewImageColumn btnColumn = new DataGridViewImageColumn();
				btnColumn.HeaderText = "Chinh sửa";
				btnColumn.Name = "btnEdit";
                btnColumn.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\icon-edit.png"));
                btnColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
                btnColumn.Width = 20;
                k_datagrview_Loai_hang.Columns.Add(btnColumn);
			}
			k_datagrview_Loai_hang.Columns["btnEdit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			k_datagrview_Loai_hang.Columns["btnEdit"].DisplayIndex = k_datagrview_Loai_hang.Columns.Count - 2;


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

		private string GetPlaceholder(KryptonTextBox textBox)
		{
			switch (textBox.Name)
			{
				case "txb_Ten_loai_hang":
					return "Nhập tên loại hàng";
				case "txb_Malh":
					return "Nhập mã loại hàng";
				case "txb_Dien_giai":
					return "Nhập diễn giải";
				case "txb_tim_kiem_LH":
					return "Tìm kiếm";
				default:
					return string.Empty;
			}
		}

		// nút mở pn_nhap
		private void kbtn_themSua_Click(object sender, EventArgs e)
		{
            txb_Malh.ReadOnly = false;
            kbtn_Them_sua.Visible = true;
			createTransition.Start();
			if (kbtn_sua.Visible)
			{
				kbtn_sua.Visible = false;
			}
			if (pn_nhap.Height >= 150)
				createTransition.Stop();
		}
		// nút quay lại
		private void kbtn_Cancle_Click(object sender, EventArgs e)
		{
			if (pn_nhap.Height >= 150)
			{
				createTransition.Start();

			}
			txb_Malh.Clear();
			txb_Ten_loai_hang.Clear();
			txb_Dien_giai.Clear();
            txb_Malh.ReadOnly = false;
			ResetForeText();
		}
		// nút sửa 
		private void kbtn_sua_Click(object sender, EventArgs e)
		{
			string malh = txb_Malh.Text;
			string tenloaiHang = txb_Ten_loai_hang.Text;
			string diengiai = txb_Dien_giai.Text;
			int flag = check_trang_thai.Checked ? 1 : 0;

			bool result = LoaiHang_BUS.UpdateLoaiHanh(malh, tenloaiHang, diengiai, flag);
			if (result)
			{
				LoaiHangGui_Load();
				MessageBox.Show("Sửa thông tin loại hàng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txb_Ten_loai_hang.Clear();
				txb_Malh.Clear();
				txb_Dien_giai.Clear();
				ResetForeText();

			}
			else
			{
				MessageBox.Show("Sửa thông tin hàng hóa không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// nút sự kiện thêm loại hàng
		private void kbtn_Them_sua_Click(object sender, EventArgs e)
		{
			bool isValid = true;

            string maloai = txb_Malh.Text;
			string tenloaihang = txb_Ten_loai_hang.Text;
			string diengiai = txb_Dien_giai.Text;
			int flag = check_trang_thai.Checked ? 1 : 0;

			if (string.IsNullOrWhiteSpace(txb_Malh.Text) || txb_Malh.Text == "Nhập mã loại hàng")
			{
				MessageBox.Show("Vui lòng nhập mã loại hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				isValid = false;
			}
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txb_Malh.Text, @"^ML\d+$"))
            {
                MessageBox.Show("Mã hàng hóa không hợp lệ. Vui lòng nhập mã theo định dạng ML+Số nguyên.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (LoaiHang_BUS.IsMaLoaiExist(maloai))
            {
                MessageBox.Show("Mã hàng hóa đã tồn tại. Vui lòng nhập mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(txb_Ten_loai_hang.Text) || txb_Ten_loai_hang.Text == "Nhập tên loại hàng")
			{
				MessageBox.Show("Vui lòng nhập tên hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				isValid = false;
			}
			else if (string.IsNullOrWhiteSpace(txb_Dien_giai.Text) || txb_Dien_giai.Text == "Nhập diễn giải")
			{
				MessageBox.Show("Vui lòng nhập diễn giải!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				isValid = false;
			}
			else
			{
				bool them = LoaiHang_BUS.InsertLoaiHang(maloai, tenloaihang, diengiai, flag);
				if (them)
				{
					LoaiHangGui_Load();
					MessageBox.Show("Thêm loại hàng thành công!");

                    txb_Malh.Clear();
					txb_Ten_loai_hang.Clear();
					txb_Dien_giai.Clear();

					ResetForeText();
					check_trang_thai.Checked = false;
				}
				else
				{
					MessageBox.Show("Có lỗi xảy ra khi thêm hàng hóa.");
				}
                soluong.Text = "Loại hàng (" + Convert.ToString(LoaiHang_BUS.GetSLLoaiHang()) + ")";
            }
        }

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

				}
			}
			else
			{
				pn_nhap.Height += 10;
				if (pn_nhap.Height >= 150)
				{
					createTransition.Stop();
					createExplore = true;


				}
			}
		}

		// reset chữ mặc định
		private void ResetForeText()
		{
			SetPlaceholder(txb_Malh, GetPlaceholder(txb_Malh));
			SetPlaceholder(txb_Ten_loai_hang, GetPlaceholder(txb_Ten_loai_hang));
			SetPlaceholder(txb_Dien_giai, GetPlaceholder(txb_Dien_giai));
		}
		// sự kiện show lỗi
		private void ShowError(string message)
		{
			MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		//sự kiện xóa hàng hóa và tương tác nút sửa hiện pn_nhap
		private void k_datagrview_Loai_hang_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			// Kiểm tra xem hàng có hợp lệ không
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = k_datagrview_Loai_hang.Rows[e.RowIndex];

				// Kiểm tra cột được nhấn có phải là btnDelete không
				if (e.ColumnIndex == k_datagrview_Loai_hang.Columns["btnDelete"].Index)
				{
					// Hiển thị MessageBox để xác nhận xóa
					DialogResult dialogResult = MessageBox.Show(
						"Bạn có chắc chắn muốn xóa thông tin này không?",
						"Xác nhận xóa",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question
					);

					if (dialogResult == DialogResult.Yes)
					{
						bool result = LoaiHang_BUS.DeleteLoaiHang(row.Cells["Mã loại hàng"].Value.ToString());
						if (result)
						{
							LoaiHangGui_Load();
							txb_Malh.Clear();
							txb_Ten_loai_hang.Clear();
							txb_Dien_giai.Clear();
							ResetForeText();
							MessageBox.Show("Xóa thông tin loại hàng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						else
						{
							MessageBox.Show("Xóa thông tin loại hàng không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
                        soluong.Text = "Loại hàng (" + Convert.ToString(LoaiHang_BUS.GetSLLoaiHang()) + ")";
                    }
                }

				// Kiểm tra cột được nhấn có phải là btnEdit không
				if (e.ColumnIndex == k_datagrview_Loai_hang.Columns["btnEdit"].Index)
				{

					txb_Malh.Text = row.Cells[2].Value?.ToString();
					txb_Ten_loai_hang.Text = row.Cells[3].Value?.ToString();
					txb_Dien_giai.Text = row.Cells[4].Value?.ToString();
                    // Kiểm tra nếu giá trị của ô không phải là DBNull và không null
                    if (row.Cells[5].Value != DBNull.Value)
                    {
                        string cellValue = row.Cells[5].Value.ToString(); 
                        if (cellValue == "Còn kinh doanh")
                        {
                            check_trang_thai.Checked = true;
							
                        }
                    }
                    else
					{
						// Nếu là DBNull hoặc null, checkbox sẽ không được tích (unchecked)
						check_trang_thai.Checked = false;
					}

					IsPressEdit();
					createTransition.Start();
                    txb_Malh.ReadOnly = true;
                    if (pn_nhap.Height >= 150)
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

		// phương thức tìm kiếm hàng hóa
		private void txb_tim_kiem_LH_TextChanged(object sender, EventArgs e)
		{
			string keyword = txb_tim_kiem_LH.Text.Trim();
			DataTable result = LoaiHang_BUS.SearchLoaiHang(keyword);
			if (string.IsNullOrEmpty(keyword))
			{
				LoaiHangGui_Load();
				return;
			}

			else if (keyword == "Tìm kiếm")
			{
				return;
			}
			else
			{
				k_datagrview_Loai_hang.DataSource = result;
				EnsureButtonColumnsVisible();
			}


		}
		private void EnsureButtonColumnsVisible()
		{
			// Kiểm tra và thêm cột nếu cần
			AddButtonColumn();
			AddButtonColumn_Edit();

			// Đặt DisplayIndex cho cột "Chỉnh sửa" và "Xóa"
			k_datagrview_Loai_hang.Columns["btnEdit"].DisplayIndex = k_datagrview_Loai_hang.Columns.Count - 2; // Đặt "Chỉnh sửa" ở vị trí thứ hai từ cuối
			k_datagrview_Loai_hang.Columns["btnDelete"].DisplayIndex = k_datagrview_Loai_hang.Columns.Count - 1; // Đặt "Xóa" ở vị trí cuối cùng

			// Đặt lại DisplayIndex cho các cột còn lại nếu cần
			int index = 0;
			foreach (DataGridViewColumn column in k_datagrview_Loai_hang.Columns)
			{
				if (column.Name != "btnEdit" && column.Name != "btnDelete") // Bỏ qua các cột nút
				{
					column.DisplayIndex = index++;
				}
			}
		}
        // Ngăn chặn hành động ấn enter
		private void txb_tim_kiem_LH_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true; 
			}
		}

        private void kryBt_Next_Click(object sender, EventArgs e)
        {
            curentPage++;
			LoaiHangGui_Load();
            kryBtPre.Enabled = true;
            if (curentPage == totalPage)
            {
                kryBt_Next.Enabled = false;
            }
            labelSoTrang.Text = Convert.ToString(curentPage);
        }

        private void kryBtPre_Click(object sender, EventArgs e)
        {
            curentPage--;
            LoaiHangGui_Load();
            kryBt_Next.Enabled = true;
            if (curentPage == 1)
            {
                kryBtPre.Enabled = false;

            }
            labelSoTrang.Text = Convert.ToString(curentPage);
        }

        private void check_trang_thai_CheckedChanged(object sender, EventArgs e)
        {
            if (check_trang_thai.Checked == true)
            {
                check_trang_thai.Text = "Còn kinh doanh";
            }
            else
            {
                check_trang_thai.Text = "Không còn kinh doanh";

            }
        }
    }
}



