using QLVTXD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLVLXD
{
	internal class DeleteEvents
	{
		private DataProvider dataProvider;

		public DeleteEvents(DataProvider dataProvider)
		{
			this.dataProvider = dataProvider;
		}

		public void DeleteSelectedHangHoa(DataGridView grview_hang)
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

					try
					{
						// Xóa dữ liệu tham chiếu đến bảng CHITIET_HD_XUAT
						string deleteDetailQueryXuat = $"DELETE FROM CHITIET_HD_XUAT WHERE IDKHO IN ({khoIds})";
						dataProvider.execNonQuery(deleteDetailQueryXuat);

						// Xóa dữ liệu tham chiếu đến bảng KHO
						string deleteDetailQueryKHO = $"DELETE FROM KHO WHERE IDKHO IN ({khoIds})";
						dataProvider.execNonQuery(deleteDetailQueryKHO);
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Lỗi khi xóa dữ liệu trong KHO hoặc CHITIET_HD_XUAT: {ex.Message}");
					}
				}

				try
				{
					// Xóa dữ liệu tham chiếu đến bảng CHITIET_HD_NHAP
					string deleteDetailQueryNhap = $"DELETE FROM CHITIET_HD_NHAP WHERE MAHH IN ({ids})";
					dataProvider.execNonQuery(deleteDetailQueryNhap);

					// Xóa từ bảng HangHoa
					string deleteQuery = $"DELETE FROM HangHoa WHERE MAHH IN ({ids})";
					int rowsAffected = dataProvider.execNonQuery(deleteQuery);

					if (rowsAffected > 0)
					{
						MessageBox.Show("Xóa dữ liệu thành công!");
					}
					else
					{
						MessageBox.Show("Không có dữ liệu nào được xóa!");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Lỗi khi xóa dữ liệu trong CHITIET_HD_NHAP hoặc HangHoa: {ex.Message}");
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
			try
			{
				string getKhoIdsQuery = $"SELECT IDKHO FROM KHO WHERE MAHH IN ({ids})";
				DataTable khoTable = dataProvider.execQuery(getKhoIdsQuery);

				foreach (DataRow row in khoTable.Rows)
				{
					khoIdsToDelete.Add(row["IDKHO"].ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi lấy IDKHO: {ex.Message}");
			}

			return khoIdsToDelete;
		}
	}

}
