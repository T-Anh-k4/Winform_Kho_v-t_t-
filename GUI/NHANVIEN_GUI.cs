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
using BUS;
namespace GUI
{
	public partial class NHANVIEN_GUI : Form
	{
		THEMSUANV_GUI ct = new THEMSUANV_GUI();
		NHANVIEN_BUS nhanVienBUS = new NHANVIEN_BUS();
		string manv;
		public NHANVIEN_GUI()
		{
			InitializeComponent();
			this.manv = manv;
			StartPosition = FormStartPosition.CenterScreen;
			init();
		}

		public string Manv { get => manv; set => manv = value; }

		public void init()
		{
			initUser();
		}
		public void initUser()
		{
			loadDt_NhanVien();
			AddButtonColumn();
			AddButtonColumn_Edit();

		}
		public void loadDt_NhanVien()
		{
			DataTable dt = new DataTable();
			dt = nhanVienBUS.GetDanhSachNhanVien();
			//3dt_nhanvien.ColumnHeadersVisible = false;//ẩn header datagridview
			kryDataView_NhanVien.DataSource = dt;
		}

		// Thêm cột chứa nút vào DataGridView
		private void AddButtonColumn()
		{
			// Tạo một cột nút mới
			DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
			btnColumn.HeaderText = "Xóa";
			btnColumn.Name = "btnDelete";
			btnColumn.Text = "Xóa";
			btnColumn.UseColumnTextForButtonValue = true; // Hiển thị text "Xóa" trên nút
			kryDataView_NhanVien.Columns.Add(btnColumn);
		}
		private void AddButtonColumn_Edit()
		{
			// Tạo một cột nút mới
			DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
			btnColumn.HeaderText = "Chinh sửa";
			btnColumn.Name = "btnEdit";
			btnColumn.Text = "Edit";
			btnColumn.UseColumnTextForButtonValue = true; // Hiển thị text "Xóa" trên nút
			kryDataView_NhanVien.Columns.Add(btnColumn);
		}
		private void kryBt_Function_Click(object sender, EventArgs e)
		{
			THEMSUANV_GUI createnv = new THEMSUANV_GUI(this);
			createnv.HideBtDataView();
			createnv.ShowDialog();
		}

		private void kryDataView_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = kryDataView_NhanVien.Rows[e.RowIndex];
			manv = row.Cells[2].Value.ToString();
			if (e.ColumnIndex == kryDataView_NhanVien.Columns["btnDelete"].Index)
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
			if (e.ColumnIndex == kryDataView_NhanVien.Columns["btnEdit"].Index)
			{
				THEMSUANV_GUI createnv = new THEMSUANV_GUI(this);
				createnv.HideBtAdd();
				createnv.ShowDialog();

			}
		}
	}
}
