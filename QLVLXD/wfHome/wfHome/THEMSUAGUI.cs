using GUI;
using System;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using BUS;
namespace wfHome
{
	public partial class THEMSUAGUI : KryptonForm
	{
		private HANGHOA_BUS hanghoabus;
		private HangHoaGui hanghoaGui;
		public THEMSUAGUI(HangHoaGui hangHoaGui)
		{
			this.hanghoaGui = hangHoaGui;
			hanghoabus = new HANGHOA_BUS();
			InitializeComponent();
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

			if (hanghoabus == null)
			{
				MessageBox.Show("Đối tượng hanghoabus không được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (hanghoaGui == null)
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
				bool them = hanghoabus.InsertHangHoa(mahh, maloai, tenhang, dvt, xuatxu);
				if (them)
				{
					hanghoaGui.HangHoaGui_Load();
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
		// sự kiện khi hiện, ẩn chữ trong textbox
		private void TextBox_Enter(object sender, EventArgs e)
		{
			KryptonTextBox textBox = sender as KryptonTextBox;
			if (textBox != null)
			{
				string placeholder = GetPlaceholder(textBox);
				if (textBox.Text == placeholder)
				{
					textBox.Text = "";
					textBox.ForeColor = Color.Black;
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
				}
			}
		}
		private void SetPlaceholder(KryptonTextBox textBox, string placeholder)
		{
			textBox.Text = placeholder;
			textBox.ForeColor = Color.Gray;
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

		//.........
		// đóng form
		private void kbtn_thoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}


	}
}
