using QLVTXD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLVLXD
{
	public partial class Form1 : Form
	{
		private DataProvider dataProvider = new DataProvider();

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
			loadDt_user();
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

		private void bt_create_Click(object sender, EventArgs e)
		{
			Create ct = new Create(this);
			ct.ShowDialog();
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			List<string> idsToDelete = new List<string>();

			// Duyệt qua các hàng trong DataGridView
			foreach (DataGridViewRow row in grview_hang.Rows)
			{
				if (Convert.ToBoolean(row.Cells["checkBoxColumn"].Value))
				{
					idsToDelete.Add(row.Cells["MAHH"].Value.ToString());
				}
			}

			if (idsToDelete.Count > 0)
			{
				string ids = string.Join(",", idsToDelete.Select(id => $"'{id}'"));

				using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T4N0A0R\SQLEXPRESS;Initial Catalog=QLVATLIEUXD_1;Integrated Security=True"))
				{
					try
					{
						connection.Open();

						// Lấy danh sách IDKHO từ bảng KHO trước khi xóa
						List<string> khoIdsToDelete = GetKhoIds(ids, connection);
						if (khoIdsToDelete.Count > 0)
						{
							string khoIds = string.Join(",", khoIdsToDelete.Select(id => $"'{id}'"));

							// Xóa dữ liệu tham chiếu đến bảng CHITIET_HD_XUAT
							string deleteDetailQueryXuat = $"DELETE FROM CHITIET_HD_XUAT WHERE IDKHO IN ({khoIds})";
							using (SqlCommand cmdDeleteDetailsXuat = new SqlCommand(deleteDetailQueryXuat, connection))
							{
								cmdDeleteDetailsXuat.ExecuteNonQuery();
							}

							// Xóa dữ liệu tham chiếu đến bảng KHO
							string deleteDetailQueryKHO = $"DELETE FROM KHO WHERE IDKHO IN ({khoIds})"; 
							using (SqlCommand cmdDeleteDetailsKHO = new SqlCommand(deleteDetailQueryKHO, connection))
							{
								cmdDeleteDetailsKHO.ExecuteNonQuery();
							}
						}
						// Xóa dữ liệu tham chiếu đến bảng CHITIET_HD_NHAP
						string deleteDetailQueryNhap = $"DELETE FROM CHITIET_HD_NHAP WHERE MAHH IN ({ids})";
						using (SqlCommand cmdDeleteDetailsNhap = new SqlCommand(deleteDetailQueryNhap, connection))
						{
							int rowsAffectedNhap = cmdDeleteDetailsNhap.ExecuteNonQuery();
						}
						// Xóa từ bảng HangHoa
						string deleteQuery = $"DELETE FROM HangHoa WHERE MAHH IN ({ids})";
						SqlCommand cmd = new SqlCommand(deleteQuery, connection);
						int rowsAffected = cmd.ExecuteNonQuery();

						if (rowsAffected > 0)
						{
							MessageBox.Show("Xóa dữ liệu thành công!");
							loadDt_user();
						}
						else
						{
							MessageBox.Show("Không có dữ liệu nào được xóa!");
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Có lỗi xảy ra khi xóa dữ liệu: " + ex.Message);
					}
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn ít nhất một hàng để xóa!");
			}
		}

		// liệt kê danh sách các KHOID được tham chiếu theo MAHH
		private List<string> GetKhoIds(string ids, SqlConnection connection)
		{
			List<string> khoIdsToDelete = new List<string>();

			string getKhoIdsQuery = $"SELECT IDKHO FROM KHO WHERE MAHH IN ({ids})";
			using (SqlCommand cmdGetKhoIds = new SqlCommand(getKhoIdsQuery, connection))
			{
				SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdGetKhoIds);
				DataTable khoTable = new DataTable();
				dataAdapter.Fill(khoTable);

				foreach (DataRow row in khoTable.Rows)
				{
					khoIdsToDelete.Add(row["IDKHO"].ToString());
				}
			}

			return khoIdsToDelete;
		}

		private void btn_search_Click(object sender, EventArgs e)
		{
				string searchTerm = txb_Search.Text.Trim(); 

				if (string.IsNullOrEmpty(searchTerm))
				{
					MessageBox.Show("Vui lòng nhập tên hàng để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Thực hiện tìm kiếm
				string query = $"SELECT * FROM HangHoa WHERE TENHH LIKE  @TENHH + '%'";
				DataTable resultTable = dataProvider.execQuery(query, new SqlParameter("@TENHH", searchTerm));

				if (resultTable.Rows.Count > 0)
				{
					grview_hang.DataSource = resultTable; 
				}
		}

		private void txb_Search_TextChanged(object sender, EventArgs e)
		{
			string searchTerm = txb_Search.Text.Trim();

			if (string.IsNullOrEmpty(searchTerm))
			{
				loadDt_user(); 
				return;
			}

			// Thực hiện tìm kiếm
			string query = "SELECT * FROM HangHoa WHERE TENHH LIKE  @TENHH + '%'";
			DataTable resultTable = dataProvider.execQuery(query, new SqlParameter("@TENHH", searchTerm));

			if (resultTable.Rows.Count > 0)
			{
				grview_hang.DataSource = resultTable;
			}
			else
			{
				grview_hang.DataSource = null; 
			}
		}

	}
}
