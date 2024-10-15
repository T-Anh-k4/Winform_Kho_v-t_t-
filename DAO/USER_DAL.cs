using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class USER_DAL
	{
		DataProvider instance = new DataProvider();
		public DataTable GetDataUserName()
		{
			string query = "SELECT USERNAME AS [Tên người dùng], PASSWORD AS [Mật khẩu],TENNV AS [Tên nhân viên], LOAI AS [Loại người dùng],ACTIVE AS [Trạng thái] FROM NGUOIDUNG JOIN NHANVIEN ON NGUOIDUNG.MANV = NHANVIEN.MANV";
			return instance.execQuery(query);
		}
		public DataTable GetMaNvUser(string manv)
		{
			string query = "SELECT NGUOIDUNG.MANV FROM NGUOIDUNG JOIN NHANVIEN ON NGUOIDUNG.MANV = NHANVIEN.MANV";
			return instance.execQuery(query);
		}
		public bool DeleteUser(string username)
		{
			try
			{
				string query = "DELETE FROM NGUOIDUNG WHERE USERNAME = N'" + username + "'";
				// Thực hiện câu lệnh SQL
				instance.execNonQuery(query);
			}
			catch
			{
				return false;

			}
			return true;
		}
		public bool InsertUser(string username, string password, string loai, int trangthai)
		{
			try
			{
				string query = "INSERT INTO NGUOIDUNG(USERNAME,PASSWORD,LOAI,ACTIVE) " +
							   "VALUES (N'" + username + "', N'" + password + "', N'" + loai + "', N'" + trangthai +"')";
				instance.execNonQuery(query);
			}
			catch
			{
				return false;
			}
			return true;
		}
		public bool UpdateUser(string username, string passwword, string loai, int trangthai)
		{
			try
			{
				// Xây dựng câu lệnh SQL với các biến được chèn trực tiếp
				string query = "UPDATE NGUOIDUNG " +
							   "SET USERNAME = N'" + username + "', " +
							   "PASSWORD = N'" + passwword + "', " +
							   "LOAI = N'" + loai + "', " +
							   "ACTIVE = '" + trangthai + "'"+
							   "WHERE USERNAME = N'" + username + "'";

				// Thực hiện câu lệnh SQL
				instance.execNonQuery(query);
			}
			catch
			{
				return false;
			}
			return true;
		}
		public DataTable SearchUser(string keyword)
		{
			string query = "SELECT USERNAME AS [Tên người dùng], PASSWORD AS [Mật khẩu], LOAI AS [Loại người dùng],ACTIVE AS [Trạng thái] FROM NGUOIDUNG "+
							"WHERE USERNAME LIKE N'%" + keyword + "%'";

			return instance.execQuery(query);
		}
	}
}
