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
using System.Windows.Markup;
using System.Windows.Media;
using ComponentFactory.Krypton.Toolkit;
using DTO;
using System.Xml.Linq;
namespace wfHome
{
	public partial class HangHoaGui : Form1
	{
		private HANGHOA_BUS hanghoa_bus;
		private Products Products;
		int pageNumber = 1;
		int numberrecord = 10;
		public HangHoaGui()
		{
			InitializeComponent();
			hanghoa_bus = new HANGHOA_BUS();
			Products = new Products();
			init();
		}

		public void init()
		{
			initUser();
			HangHoaGui_Load();
			AddButtonColumn();
			AddButtonColumn_Edit();
		}
		public void initUser()
		{
			pn_nhap.Visible = false;
			pn_data.Height = 620;

			//k_datagrview_hang_hoa.DataSource = LoadRecord(pageNumber, numberrecord);
		
			txb_Mahh.Enter += TextBox_Enter;
			txb_Mahh.Leave += TextBox_Leave;

			txb_Ten_hang.Enter += TextBox_Enter;
			txb_Ten_hang.Leave += TextBox_Leave;

			txb_Malh.Enter += TextBox_Enter;
			txb_Malh.Leave += TextBox_Leave;

			txb_xuat_xu.Enter += TextBox_Enter;
			txb_xuat_xu.Leave += TextBox_Leave;

			SetPlaceholder(txb_Mahh, "Nhập mã hàng hóa");
			SetPlaceholder(txb_Ten_hang, "Nhập tên hàng");
			SetPlaceholder(txb_Malh, "Nhập mã loại hàng");
			SetPlaceholder(txb_xuat_xu, "Nhập xuất xứ");

		}
		public void HangHoaGui_Load()
		{
			DataTable dt = hanghoa_bus.GetDanhSachHangHoa();
			k_datagrview_hang_hoa.DataSource = dt;
		}

		//List<Products> LoadRecord(int page,int recordNum)
		//{
		//	List<Products> result = new List<Products>();
  //          using ( db = )
		//	{
		//		result = db.Products.Skip(page * recordNum).Take(recordNum).ToList();
		//	}
		//	return result;
		//}



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


		private void dtgrview_hang_hoa_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = k_datagrview_hang_hoa.Rows[e.RowIndex];
			if (e.ColumnIndex == k_datagrview_hang_hoa.Columns["btnDelete"].Index)
			{
				bool result = hanghoa_bus.DeleteHangHoa(row.Cells[2].Value.ToString());
				if (result)
				{
					HangHoaGui_Load();
					MessageBox.Show("Xóa thông tin hàng hóa thành công", "Thanhcong", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					MessageBox.Show("Xóa thông tin hàng hóa không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else if (e.ColumnIndex == k_datagrview_hang_hoa.Columns["btnEdit"].Index && e.RowIndex >= 0)
			{

			}
		}

		private void cbx_don_vi_tinh_DropDown(object sender, EventArgs e)
		{
			cbx_don_vi_tinh.Items.Clear();
			cbx_don_vi_tinh.Items.Add("Kg");
			cbx_don_vi_tinh.Items.Add("Thùng");
			cbx_don_vi_tinh.Items.Add("Cái");
		}
		private void kbtn_Them_sua_Click(object sender, EventArgs e)
		{
			bool isValid = true;

			if (hanghoa_bus == null)
			{
				MessageBox.Show("Đối tượng hanghoabus không được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (hanghoa_bus == null)
			{
				MessageBox.Show("Đối tượng hanghoaGui không được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string mahh = txb_Mahh.Text;
			string maloai = txb_Malh.Text;
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
			else if (string.IsNullOrWhiteSpace(txb_Malh.Text) || txb_Malh.Text == "Nhập mã loại hàng")
			{
				MessageBox.Show("Vui lòng nhập mã loại hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
					txb_Malh.Clear();
					txb_Ten_hang.Clear();
					txb_xuat_xu.Clear();
					cbx_don_vi_tinh.SelectedIndex = -1;
				}
				else
				{
					MessageBox.Show("Có lỗi xảy ra khi thêm hàng hóa.");
				}
			}
		}
		private void ShowError(string message)
		{
			MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		private void TextBox_Enter(object sender, EventArgs e)
		{
			KryptonTextBox textBox = sender as KryptonTextBox;
			if (textBox != null)
			{
				if (textBox.Text == GetPlaceholder(textBox))
				{
					textBox.Text = "";
					textBox.ForeColor = System.Drawing.Color.Black; 
				}
			}
		}

		private void TextBox_Leave(object sender, EventArgs e)
		{
			KryptonTextBox textBox = sender as KryptonTextBox;
			if (textBox != null)
			{
				if (string.IsNullOrWhiteSpace(textBox.Text))
				{
					SetPlaceholder(textBox, GetPlaceholder(textBox));
					textBox.ForeColor = System.Drawing.Color.Gray; 
				}
			}
		}

		private void SetPlaceholder(KryptonTextBox textBox, string placeholder)
		{
			textBox.Text = placeholder;
			textBox.ForeColor = System.Drawing.Color.Gray; 
		}
		private string GetPlaceholder(KryptonTextBox textBox)
		{
			switch (textBox.Name)
			{
				case "txb_Mahh":
					return "Nhập mã hàng hóa";
				case "txb_Ten_hang":
					return "Nhập tên hàng";
				case "txb_Malh":
					return "Nhập mã loại hàng";
				case "txb_xuat_xu":
					return "Nhập xuất xứ";
				default:
					return string.Empty;
			}
		}

		private void kybtn_pn_themsua_Click(object sender, EventArgs e)
		{
			pn_nhap.Visible = !pn_nhap.Visible;

			if (pn_nhap.Visible)
			{
				pn_data.Size = new Size(1069, 408);
				k_datagrview_hang_hoa.RowTemplate.Height = 29;

			}
			else
			{
				pn_data.Size = new Size(1069, 620);
				k_datagrview_hang_hoa.RowTemplate.Height = 44;
			}
			foreach (DataGridViewRow row in k_datagrview_hang_hoa.Rows)
			{
				row.Height = k_datagrview_hang_hoa.RowTemplate.Height; 
			}
		}

	}
}
