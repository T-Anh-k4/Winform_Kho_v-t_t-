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

namespace wfHome
{
	public partial class HangHoaGui : Form1
	{
		HANGHOA_BUS hanghoa_bus;
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

		}
		private void HangHoaGui_Load()
		{
			try
			{
				DataTable dt = hanghoa_bus.GetDanhSachHangHoa();

				if (dt.Rows.Count > 0)
				{
					dtgrview_hang_hoa.DataSource = dt;
				}
				else
				{
					MessageBox.Show("Không có dữ liệu để hiển thị.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
			}
		}

		private void AddButtonColumn()
		{
			if (!dtgrview_hang_hoa.Columns.Contains("btnDelete"))
			{
				DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
				btnColumn.HeaderText = "Chỉnh sửa";
				btnColumn.Name = "btnDelete";
				btnColumn.Text = "Xóa";
				btnColumn.UseColumnTextForButtonValue = true;

				dtgrview_hang_hoa.Columns.Add(btnColumn);
			}
		}


		private void dtgrview_hang_hoa_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == dtgrview_hang_hoa.Columns["btnDelete"].Index)
			{
				DataGridViewRow row = dtgrview_hang_hoa.Rows[e.RowIndex];

				bool result = hanghoa_bus.DeleteHangHoa(row.Cells[1].Value.ToString());
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

	}
}
