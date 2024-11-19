using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAL
{
	public class USER_DAL : DataProvider
    {
		DataProvider instance = new DataProvider();
        SqlDataAdapter nvAdapter = new SqlDataAdapter();
        public DataTable GetDataUserName()
		{
			string query = "SELECT USERNAME AS [Tên người dùng], PASSWORD AS [Mật khẩu], LOAI AS [Loại người dùng],ACTIVE AS [Trạng thái] FROM NGUOIDUNG ORDER BY LOAI";
			return instance.execQuery(query);
		}
		public DataTable GetMaNvUser(string manv)
		{
			string query = "SELECT NGUOIDUNG.MANV FROM NGUOIDUNG JOIN NHANVIEN ON NGUOIDUNG.MANV = NHANVIEN.MANV";
			return instance.execQuery(query);
		}
        public DataTable getDanhSachUserPage(int limit, int page)
        {
            string query = "SELECT USERNAME AS [Tên người dùng], PASSWORD AS [Mật khẩu], LOAI AS [Loại người dùng],CASE WHEN ACTIVE = 0 THEN N'Không hoạt động' ELSE N'Đang hoạt động' end  AS [Trạng thái] FROM NGUOIDUNG ORDER BY LOAI";

            // Khởi tạo đối tượng kết nối
            using (SqlConnection con = new SqlConnection(LinkData))
            {
                con.Open(); // Mở kết nối

                // Khởi tạo SqlDataAdapter với SqlCommand và SqlConnection
                nvAdapter.SelectCommand = new SqlCommand(query, con);

                DataTable dsNv = new DataTable();
                nvAdapter.Fill((page - 1) * limit, limit, dsNv);

                con.Close(); // Đóng kết nối
                return dsNv;
            }
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
        public int GetSLNguoiDung()
        {
            string query = "SELECT COUNT(*) FROM NGUOIDUNG";
            object result = instance.execScalar(query);
            int sluser = result != null ? Convert.ToInt32(result) : 0;
            return sluser;
        }
        public DataTable SearchUser(string keyword)
		{
			string query = "SELECT USERNAME AS [Tên người dùng], PASSWORD AS [Mật khẩu], LOAI AS [Loại người dùng],ACTIVE AS [Trạng thái] FROM NGUOIDUNG "+
							"WHERE USERNAME LIKE N'%" + keyword + "%'";

			return instance.execQuery(query);
		}
	}
}
