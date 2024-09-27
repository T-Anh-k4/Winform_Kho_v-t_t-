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

		private void btn_Delete_Click(object sender, EventArgs e)
{
        List<string> idsToDelete = new List<string>();

    foreach (DataGridViewRow row in grview_hang.Rows)
    {
        if (row.Cells["checkBoxColumn"].Value != null && Convert.ToBoolean(row.Cells["checkBoxColumn"].Value))
        {
            idsToDelete.Add(row.Cells["MAHH"].Value.ToString());
        }
    }

    if (idsToDelete.Count > 0)
    {
        string ids = string.Join(",", idsToDelete.Select(id => $"'{id}'"));
        List<string> khoIdsToDelete = GetKhoIds(ids);

        if (khoIdsToDelete.Count > 0)
        {
            string khoIds = string.Join(",", khoIdsToDelete.Select(id => $"'{id}'"));

            // Xóa dữ liệu tham chiếu đến bảng CHITIET_HD_XUAT
            string deleteDetailQueryXuat = $"DELETE FROM CHITIET_HD_XUAT WHERE IDKHO IN ({khoIds})";
            dataProvider.execNonQuery(deleteDetailQueryXuat);

            // Xóa dữ liệu tham chiếu đến bảng KHO
            string deleteDetailQueryKHO = $"DELETE FROM KHO WHERE IDKHO IN ({khoIds})";
            dataProvider.execNonQuery(deleteDetailQueryKHO);
        }

        // Xóa dữ liệu tham chiếu đến bảng CHITIET_HD_NHAP
        string deleteDetailQueryNhap = $"DELETE FROM CHITIET_HD_NHAP WHERE MAHH IN ({ids})";
        dataProvider.execNonQuery(deleteDetailQueryNhap);

        // Xóa từ bảng HangHoa
        string deleteQuery = $"DELETE FROM HangHoa WHERE MAHH IN ({ids})";
        int rowsAffected = dataProvider.execNonQuery(deleteQuery);

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
    else
    {
        MessageBox.Show("Vui lòng chọn ít nhất một hàng để xóa!");
    }
}


		// Liệt kê danh sách các KHOID được tham chiếu theo MAHH
		private List<string> GetKhoIds(string ids)
		{
			List<string> khoIdsToDelete = new List<string>();
			string getKhoIdsQuery = $"SELECT IDKHO FROM KHO WHERE MAHH IN ({ids})";
			DataTable khoTable = dataProvider.execQuery(getKhoIdsQuery);

			foreach (DataRow row in khoTable.Rows)
			{
				khoIdsToDelete.Add(row["IDKHO"].ToString());
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
			string query = $"SELECT * FROM HangHoa WHERE TENHH LIKE @TENHH + '%'";
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

		private void txb_Search_TextChanged(object sender, EventArgs e)
		{
			string searchTerm = txb_Search.Text.Trim();

			if (string.IsNullOrEmpty(searchTerm))
			{
				loadDt_user();
				return;
			}

			// Thực hiện tìm kiếm
			string query = "SELECT * FROM HangHoa WHERE TENHH LIKE @TENHH + '%'";
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

		// Vào form edit
		private void btn_fix_Click(object sender, EventArgs e)
		{
			if (grview_hang.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = grview_hang.SelectedRows[0];

				string Mahh = selectedRow.Cells["MAHH"].Value.ToString();
				string TenHang = selectedRow.Cells["TENHH"].Value.ToString();
				string Malh = selectedRow.Cells["MALOAI"].Value.ToString();
				string XuatXu = selectedRow.Cells["XUATXU"].Value.ToString();
				string DonViTinh = selectedRow.Cells["DONVI_TINH"].Value.ToString();

				Edit editForm = new Edit(Mahh, TenHang, Malh, XuatXu, DonViTinh, this);
				editForm.ShowDialog();
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một hàng để sửa.");
			}
		}
	}
}
