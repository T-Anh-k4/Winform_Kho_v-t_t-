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
		public NHANVIEN_GUI()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			init();
		}
		public void init()
		{
			initUser();
		}
		public void initUser()
		{
			loadDt_NhanVien();
			AddButtonColumn();

		}
		public void loadDt_NhanVien()
		{
			DataTable dt = new DataTable();
			dt = nhanVienBUS.GetDanhSachNhanVien();
			//3dt_nhanvien.ColumnHeadersVisible = false;//ẩn header datagridview
			guna2DataGridView1.DataSource = dt;
		}
		// Thêm cột chứa nút vào DataGridView
		private void AddButtonColumn()
		{
			// Tạo một cột nút mới
			DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
			btnColumn.HeaderText = "Chinh sửa";
			btnColumn.Name = "btnDelete";
			btnColumn.Text = "Xóa";
			btnColumn.UseColumnTextForButtonValue = true; // Hiển thị text "Xóa" trên nút
														  // Thêm cột nút vào DataGridView
			guna2DataGridView1.Columns.Add(btnColumn);
		}
		private void NHANVIEN_GUI_Load(object sender, EventArgs e)
		{
			guna2ShadowForm1.SetShadowForm(this);
		}

		private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == guna2DataGridView1.Columns["btnDelete"].Index)
			{
				DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

				bool result = nhanVienBUS.DeleteNhanVien(row.Cells[1].Value.ToString());
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

		private void guna2CircleButton1_Click(object sender, EventArgs e)
		{
			THEMSUANV_GUI createnv = new THEMSUANV_GUI(this);
			createnv.ShowDialog();
		}
	}
}
