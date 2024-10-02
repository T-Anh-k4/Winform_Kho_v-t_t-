using QLVTXD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLVLXD
{
	public partial class Form1 : Form
	{
		private DataProvider dataProvider;
		private DeleteEvents deleteEvents;
		private SearchHandler searchHandler;
		private Product product;
		private user1 user1 ;

		public Form1()
		{
			InitializeComponent();
			init();
		}

		public void init()
		{
			initUser();
		}

		public void initUser()
		{
			product = new Product();
			user1 = new user1();
			dataProvider = new DataProvider();
			deleteEvents = new DeleteEvents(dataProvider);
			searchHandler = new SearchHandler(dataProvider,grview_hang,this);
			loadDt_user();
			hidebutton();
		}

		public void loadDt_user()
		{
			string connectionString = @"Data Source=DESKTOP-T4N0A0R\SQLEXPRESS;Initial Catalog=QLVATLIEUXD_1;Integrated Security=True";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();
					SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM HangHoa", connection);
					DataTable dataTable = new DataTable();
					dataAdapter.Fill(dataTable);
					grview_hang.DataSource = dataTable;

					if (grview_hang.Columns.Contains("checkBoxColumn"))
					{
						grview_hang.Columns.Remove("checkBoxColumn");
					}

					DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
					{
						Name = "checkBoxColumn",
						HeaderText = "Chọn",
						Width = 35,
						ReadOnly = false
					};

					grview_hang.Columns.Add(checkBoxColumn);

					grview_hang.Columns["MAHH"].Width = 90;
					grview_hang.Columns["MALOAI"].Width = 90;
					grview_hang.Columns["TENHH"].Width = 197;
					grview_hang.Columns["DONVI_TINH"].Width = 80;
					grview_hang.Columns["XUATXU"].Width = 192;

				}
				catch (Exception ex)
				{
					MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu: " + ex.Message);
				}
			}
		}

		private void hidebutton()
		{
			if (user1.CurrentUser == null) return;

			else if (user1.CurrentUser.Loai == "User")
			{
				btn_Delete.Visible= false;
				btn_fix.Visible= false;
				bt_create.Visible= false;
				if (grview_hang.Columns.Contains("checkBoxColumn"))
				{
					grview_hang.Columns["checkBoxColumn"].Visible = false;
				}
				grview_hang.Columns["XUATXU"].Width = 230;

			}
		}

		private void grview_hang_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Kiểm tra xem người dùng đã click vào cột checkbox hay không
			if (e.ColumnIndex == grview_hang.Columns["checkBoxColumn"].Index && e.RowIndex >= 0)
			{
				// Đảo ngược giá trị checkbox
				DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)grview_hang.Rows[e.RowIndex].Cells["checkBoxColumn"];
				checkBoxCell.Value = !(checkBoxCell.Value != null && (bool)checkBoxCell.Value);
				grview_hang.EndEdit(); // Kết thúc chỉnh sửa để cập nhật giá trị
			}
		}

		// Vào form tạo
		private void bt_create_Click(object sender, EventArgs e)
		{
			Create ct = new Create(this);
			ct.ShowDialog();
		}
		// sự kiện xóa dữ liệu
		private void btn_Delete_Click(object sender, EventArgs e)
{
			deleteEvents.DeleteSelectedHangHoa(grview_hang);
			loadDt_user();
		}
		// sự kiện tìm kiếm
		private void btn_search_Click(object sender, EventArgs e)
		{
			string searchTerm = txb_Search.Text.Trim();
			searchHandler.Search(searchTerm);
		}

		private void txb_Search_TextChanged(object sender, EventArgs e)
		{
			string searchTerm = txb_Search.Text.Trim();
			searchHandler.Search(searchTerm);
		}

		// Vào form edit
		private void btn_fix_Click(object sender, EventArgs e)
		{
			if (grview_hang.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = grview_hang.SelectedRows[0];

				product.Malh = selectedRow.Cells["MAHH"].Value.ToString();
				product.TenHang = selectedRow.Cells["TENHH"].Value.ToString();
				product.Malh = selectedRow.Cells["MALOAI"].Value.ToString();
				product.XuatXu = selectedRow.Cells["XUATXU"].Value.ToString();
				product.Dvt = selectedRow.Cells["DONVI_TINH"].Value.ToString();

				Edit editForm = new Edit(product, this);
				editForm.ShowDialog();
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một hàng để sửa.");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
