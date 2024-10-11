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
using BUS;
namespace GUI
{
	public partial class USER_GUI : KryptonForm
	{
		USER_BUS userBUS = new USER_BUS();
		bool createExplore = true;
		public USER_GUI()
		{
			InitializeComponent();
			panel2_nv.Height = 0;
			loadDataUser();
			DelButtonColumn();
			AddButtonColumn_Edit();
		}
		public void loadDataUser()
		{
			userBUS.GetDataUserName();
			DataTable dt = new DataTable();
			dt = userBUS.GetDataUserName();
			dataViewUser.DataSource = dt;
		}
		private void DelButtonColumn()
		{
			// Tạo một cột hình ảnh mới
			DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
			imgColumn.HeaderText = "Xóa";
			imgColumn.Name = "imgDelete";
			imgColumn.Image = Image.FromFile(@"E:\\CODE\\LapTrinhTrucQuan\\Winform_Kho_v-t_t-\\Images\\icon-delete.png"); // Đường dẫn đến hình ảnh
			imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
			imgColumn.Width = 20;
			// Thêm cột hình ảnh vào DataGridView
			dataViewUser.Columns.Add(imgColumn);
			// Căn giữa header của cột hình ảnh
			dataViewUser.Columns["imgDelete"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}
		private void AddButtonColumn_Edit()
		{
			// Tạo một cột hình ảnh mới
			DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
			imgColumn.HeaderText = "Edit";
			imgColumn.Name = "imgEdit";
			imgColumn.Image = Image.FromFile(@"E:\\CODE\\LapTrinhTrucQuan\\Winform_Kho_v-t_t-\\Images\\icon-edit.png"); // Đường dẫn đến hình ảnh
			imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
																	  // Thêm cột hình ảnh vào DataGridView
			dataViewUser.Columns.Add(imgColumn);
			// Căn giữa header của cột hình ảnh
			dataViewUser.Columns["imgEdit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}
		private void createTransition_Tick(object sender, EventArgs e)
		{
			if (createExplore)
			{
				panel2_nv.Height -= 5;
				if (panel2_nv.Height <= 0)
				{
					createTransition_User.Stop();
					createExplore = false;
				}
			}
			else
			{
				panel2_nv.Height += 5;
				if (panel2_nv.Height >= 170)
				{
					createTransition_User.Stop();
					createExplore = true;
				}
			}
		}

		private void kryBtShowCreate_User_Click(object sender, EventArgs e)
		{
			kryBt_Add.Visible = true;
			createTransition_User.Start();
			if (kryBt_Edit.Visible)
			{
				kryBt_Edit.Visible = false;
			}
		}

		private void dataViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
