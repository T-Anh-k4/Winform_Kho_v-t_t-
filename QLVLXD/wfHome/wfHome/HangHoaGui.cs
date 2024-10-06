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
namespace wfHome
{
	public partial class HangHoaGui : Form1
	{
		private HANGHOA_BUS hanghoa_bus;
		public HangHoaGui()
		{
			InitializeComponent();
			hanghoa_bus = new HANGHOA_BUS();
			init();
		}

		public void init()
		{
			initUser();
		}
		public void initUser()
		{
			HangHoaGui_Load();
			AddButtonColumn();
			AddButtonColumn_Edit();
		}
		public void HangHoaGui_Load()
		{
			DataTable dt = hanghoa_bus.GetDanhSachHangHoa();
		k_datagrview_hang_hoa.DataSource = dt;
	
		}

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
			if (e.ColumnIndex == k_datagrview_hang_hoa.Columns["btnDelete"].Index)
			{
				DataGridViewRow row = k_datagrview_hang_hoa.Rows[e.RowIndex];

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
		}

		private void b_btn_form_them_Click(object sender, EventArgs e)
		{
			THEMSUAGUI tHEMSUAGUI = new THEMSUAGUI(this);
			tHEMSUAGUI.ShowDialog();
		}
	}
}
