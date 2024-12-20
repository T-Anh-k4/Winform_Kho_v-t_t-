﻿using BUS;
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
			PopulateComboBox();
			initUser();
			panel2_nv.Height = 0;
			fillHDNLabel();
			dataViewNv.CellFormatting += dataViewNv_CellFormatting;
		}

		public void initUser()
		{
			loadDt_ChiTietNhap();


            txb_tim_kiem_nv.Enter += kryTbSearch_Enter;
            txb_tim_kiem_nv.Leave += kryTbSearch_Leave;
			kryTb_SLNhap.Enter += kryTbSearch_Enter;
			kryTb_SLNhap.Leave += kryTbSearch_Leave;
			kryTb_DGNhap.Enter += kryTbSearch_Enter;
			kryTb_DGNhap.Leave += kryTbSearch_Leave;
			SetPlaceholder(txb_tim_kiem_nv, "Tìm kiếm");
			SetPlaceholder(kryTb_SLNhap, "Nhập số lượng nhập");
			SetPlaceholder(kryTb_DGNhap, "Nhập đơn giá nhập");
		}

		public void IsPressAdd()
		{
			clear();
			kryBt_Add.Visible = true;
			kryTb_DGNhap.Enabled = true;
			// return kryBt_Add.Visible;
		}

		public void IsPressEdit()
		{
			kryBt_Edit.Visible = true;
			kryTb_DGNhap.Enabled = true;

			// return kryBt_Edit.Visible;
		}

		public void loadDt_ChiTietNhap()
		{
			DataTable dt = new DataTable();
			dt = chiTietNhapBUS.GetDanhSachChiTietNhapPage(maHDN, limit, curentPage);
			dataViewNv.DataSource = dt;
			dataViewNv.Columns["Mã chi tiết nhập"].Visible = false;
			dataViewNv.Columns["Mã hàng hóa"].Visible = false;
			totalPage = chiTietNhapBUS.GetSLChiTietNhap(maHDN) / limit;
			if (totalPage * limit < chiTietNhapBUS.GetSLChiTietNhap(maHDN)) totalPage++;
			EnsureButtonColumnsVisible();
			label11.Text = chiTietNhapBUS.getTotalCost(maHDN).ToString();
		}

		public void clear()
		{
			kryTb_DGNhap.Text = "";
			kryTb_SLNhap.Text = "";
			kryCb_HangHoa.SelectedIndex = -1;
		}

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

		private void dataViewNv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataViewNv.Rows[e.RowIndex];
				if (e.ColumnIndex == dataViewNv.Columns["imgEdit"].Index)
				{
                    kryTb_DGNhap.ReadOnly = true;
                    kryCb_HangHoa.SelectedValue = row.Cells["Mã hàng hóa"].Value.ToString();
					kryTb_SLNhap.Text = row.Cells["Số lượng nhập"].Value.ToString();
					kryTb_DGNhap.Text = row.Cells["Đơn giá nhập"].Value.ToString();
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
						try
						{
							bool result = chiTietNhapBUS.DeleteChiTietNhap(Convert.ToInt32(row.Cells["Mã chi tiết nhập"].Value));
							if (result)
							{
								loadDt_ChiTietNhap();
                                MessageBox.Show("Xóa chi tiết nhập thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                ResetForeText();
                            }
                            else
							{
								MessageBox.Show("Xóa chi tiết nhập không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
						catch
						{
							MessageBox.Show("Xóa chi tiết nhập không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}

					clear();
					//soluong.Text = "Chi tiết nhập (" + Convert.ToString(chiTietNhapBUS.GetSLChiTietNhap(maHDN)) + ")";
				}
			}
		}

		private void kryBt_Add_Click(object sender, EventArgs e)
		{

			// Kiểm tra các trường bắt buộc
			//if (string.IsNullOrWhiteSpace(kryTb_MaHH.Text))
			//{
			//	MessageBox.Show("Vui lòng nhập tên hàng hóa.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//	return;
			// //}
			if (string.IsNullOrWhiteSpace(kryTb_SLNhap.Text))
			{
				MessageBox.Show("Vui lòng nhập số lượng nhập.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (string.IsNullOrWhiteSpace(kryTb_DGNhap.Text))
			{
				MessageBox.Show("Vui lòng nhập đơn giá nhập.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{

				bool result = chiTietNhapBUS.InsertChiTietNhap(kryCb_HangHoa.SelectedValue.ToString(), maHDN, Convert.ToInt32(kryTb_SLNhap.Text), Convert.ToInt32(kryTb_DGNhap.Text));
				if (result)
				{
					loadDt_ChiTietNhap(); // Gọi lại để tải lại danh sách
                    MessageBox.Show("Thêm chi tiết nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //createTransition_Tick(sender, e);
                }
                else
				{
					MessageBox.Show("Thêm chi tiết nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
                //soluong.Text = "Chi tiết nhập (" + Convert.ToString(chiTietNhapBUS.GetSLChiTietNhap(maHDN)) + ")";
                ResetForeText();

            }
            catch
			{
				Console.WriteLine("Error");
				Console.WriteLine(kryCb_HangHoa.SelectedValue.ToString());
				Console.WriteLine(maHDN);
				Console.WriteLine(kryTb_SLNhap.Text);
				Console.WriteLine(kryTb_DGNhap.Text);
				MessageBox.Show("Thêm chi tiết nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			IsPressAdd();
		}

		private void kryBt_Edit_Click(object sender, EventArgs e)
		{
			try
			{
                bool result = chiTietNhapBUS.UpdateChiTietNhap(Convert.ToInt32(dataViewNv.CurrentRow.Cells["Mã chi tiết nhập"].Value), kryCb_HangHoa.SelectedValue.ToString(), maHDN, Convert.ToInt32(kryTb_SLNhap.Text), Convert.ToInt32(kryTb_DGNhap.Text));

				if (result)
				{
                    MessageBox.Show("Sửa chi tiết nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForeText();
                    loadDt_ChiTietNhap(); // Gọi lại để tải lại danh sách
				}
				else
				{
					MessageBox.Show("Sửa chi tiết nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch
			{
				MessageBox.Show("Sửa chi tiết nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void kry_Clear_Click(object sender, EventArgs e)
		{
			ResetForeText();
			createTransition.Start();
            kryTb_DGNhap.ReadOnly = false;
        }

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
				case "txb_tim_kiem_nv":
					return "Tìm kiếm";
				case "kryTb_SLNhap":
					return "Nhập số lượng nhập";
				case "kryTb_DGNhap":
					return "Nhập đơn giá nhập";
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

		private void ResetForeText()
		{
            SetPlaceholder(txb_tim_kiem_nv, GetPlaceholder(txb_tim_kiem_nv));
            SetPlaceholder(kryTb_SLNhap, GetPlaceholder(kryTb_SLNhap));
			SetPlaceholder(kryTb_DGNhap, GetPlaceholder(kryTb_DGNhap));
		}

		private void kryBtPrevious_Click(object sender, EventArgs e)
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
			ResetForeText();
            kryTb_DGNhap.ReadOnly = false;
            kryBt_Add.Visible = true;
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

		private void PopulateComboBox()
		{
			DataTable hangHoaTable = chiTietNhapBUS.getMaVaTenHH();
			List<ComboItem> comboItems = new List<ComboItem>();

			foreach (DataRow row in hangHoaTable.Rows)
			{
				comboItems.Add(new ComboItem
				{
					ID = row["Mã hàng hóa"].ToString(),
					Text = row["Tên hàng hóa"].ToString()
				});
			}
			kryCb_HangHoa.DataSource = comboItems;
			kryCb_HangHoa.DisplayMember = "Text";
			kryCb_HangHoa.ValueMember = "ID";
		}

		private void fillHDNLabel()
		{
			DataTable dt = chiTietNhapBUS.getHoaDonNhapDetail(maHDN);
			if (dt.Rows.Count > 0)
			{
				lbSoHDN.Text = dt.Rows[0]["Số hóa đơn nhập"].ToString();
				lbNcc.Text = dt.Rows[0]["Tên nhà cung cấp"].ToString();
				lbNhanVien.Text = dt.Rows[0]["Tên nhân viên"].ToString();
				lbNgayLap.Text = dt.Rows[0]["Ngày lập hóa đơn"].ToString();
			}
		}
		private void kryInBaoCao_Click(object sender, EventArgs e)
		{
			testGui.btInBaoCao_Click(maHDN);
		}
	}

	public class ComboItem
	{
		public string ID { get; set; }
		public string Text { get; set; }
	}
}