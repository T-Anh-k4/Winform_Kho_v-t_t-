using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
	public class LOAIHANG_DAL
	{
		DataProvider instance = new DataProvider();

		public LOAIHANG_DAL()
		{
			instance = new DataProvider();
		}

		public DataTable getDanhSachLoaiHanh()
		{
			string query = "SELECT MALOAI as [Mã loại hàng],TENLOAI as [Tên loại hàng],DIENGIAI as [Diễn giải],FLAG as [Trạng thái] FROM LOAIHANG";
			return instance.execQuery(query);
		}

		public bool Deleteloaihang(string malh)
		{
			try
			{
				string queryLoaihang = "DELETE FROM LOAIHANG WHERE MALOAI = N'" + malh + "'";
				instance.execNonQuery(queryLoaihang);
			}
			catch
			{
				return false;
			}
			return true;
		}

		public bool InsertLoaiHang(string malh, string Tenlh, string diengiai, int flag)
		{
			try
			{
				string query = "INSERT INTO LOAIHANG(MALOAI, TENLOAI, DIENGIAI, FLAG) " +
							   "VALUES (N'" + malh + "', N'" + Tenlh + "', N'" + diengiai + "', N'" + flag + "')";
				instance.execNonQuery(query);
			}
			catch
			{
				return false;
			}
			return true;
		}

		public bool UpdateLoaiHang(string malh, string tenlh, string diengiai, int flag)
		{
			try
			{
				string query = "UPDATE LOAIHANG " +
							   "SET MALOAI = N'" + malh + "', " +
							   "TENLOAI = '" + tenlh + "', " +
							   "DIENGIAI = N'" + diengiai + "', " +
							   "FLAG = N'" + flag + "' " +
							   "WHERE MALOAI = N'" + malh + "'"; // Cần điều kiện WHERE

				instance.execNonQuery(query);
			}
			catch
			{
				return false;
			}
			return true;
		}
		public DataTable SearchLoaiHang(string keyword)
		{
			try
			{
				string query = "SELECT MALOAI as [Mã loại],TENLOAI as [Tên loại hàng],DIENGIAI as [Diễn giải],FLAG as [Trạng thái]" +
							   "FROM LOAIHANG " +
							   "WHERE TENLOAI LIKE N'%" + keyword + "%'";

				return instance.execQuery(query);
			}
			catch
			{
				return null;
			}
		}
	}
}
