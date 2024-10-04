using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
	public class HANGHOA_DAL
	{

		DataProvider instance = new DataProvider();

		public HANGHOA_DAL()
		{
			instance = new DataProvider();
		}

		public DataTable getDanhSachHangHoa()
		{
			string query = "SELECT MAHH as [Mã hàng hóa],MALOAI as [Mã loại],TENHH as [Tên hàng hóa],DONVI_TINH as [Đơn vị],XUATXU as [Xuất xứ] FROM HANGHOA";
			return instance.execQuery(query);
		}

		public DataTable GetDonViTinh()
		{
			string query = "SELECT DONVI_TINH FROM HANGHOA";
			return instance.execQuery(query);
		}
		public bool DeleteHangHoa(string maHH)
		{
			try
			{
				string query = "delete from HANGHOA " +
					"WHERE MAHH = N'" + maHH + "'";
				instance.execNonQuery(query);
			}
			catch
			{
				return false;
			}
			return true;
		}
		public bool InsertHangHoa(string mahh, string malh, string tenHang, string dvt, string xuatXu)
		{
			try
			{
				string query = "INSERT INTO HangHoa(MAHH, MALOAI, TENHH, DONVI_TINH, XUATXU) " +
							   "VALUES (N'" + mahh + "', N'" + malh + "', N'" + tenHang + "', N'" + dvt + "', N'" + xuatXu + "')";
				instance.execNonQuery(query);
			}
			catch
			{
				return false;
			}
			return true;
		}

		public bool UpdateHanhHoa(string mahh, string malh, string tenHang, string dvt, string xuatXu)
		{
			try
			{
				string query = "UPDATE HANGHOA " +
							   "SET MALOAI = N'" + malh + "', " +
							   "TENHH = '" + tenHang + "', " +
							   "DONVI_TINH = N'" + dvt + "', " +
							   "XUATXU = N'" + xuatXu + "' " +
							   "WHERE MAHH = N'" + mahh + "'"; // Cần điều kiện WHERE

				instance.execNonQuery(query);
			}
			catch
			{
				return false;
			}
			return true;
		}
	}
}
