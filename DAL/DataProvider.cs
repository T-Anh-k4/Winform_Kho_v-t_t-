using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
	public class DataProvider
	{
		private static string linkData = @"Data Source=2DAWNG\SQLEXPRESS;Initial Catalog=QLVATLIEUXD;Integrated Security=True";

		public string LinkData { get => linkData; set => linkData = value; }

		// Thực hiện truy vấn SELECT và trả về kết quả dưới dạng DataTable
		public DataTable execQuery(string query, params SqlParameter[] parameters)
		{
			DataTable data = new DataTable();
			using (SqlConnection con = new SqlConnection(linkData))
			{
				con.Open();
				SqlCommand cmd = new SqlCommand(query, con);
				if (parameters != null)
				{
					cmd.Parameters.AddRange(parameters);
				}
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(data);
				con.Close();
			}
			return data;
		}

		// Thực hiện các câu lệnh INSERT, UPDATE, DELETE và trả về số dòng bị tác động
		public int execNonQuery(string query, params SqlParameter[] parameters)
		{
			int data = 0;
			using (SqlConnection con = new SqlConnection(linkData))
			{
				con.Open();
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddRange(parameters);
				data = cmd.ExecuteNonQuery();
			}
			return data;
		}

		public object execScalar(string query, params SqlParameter[] parameters)
		{
			object data = null;
			using (SqlConnection con = new SqlConnection(linkData))
			{
				con.Open();
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddRange(parameters);
				data = cmd.ExecuteScalar();
			}
			return data;
		}
		public static string CheckLoginDTO(USER_DTO userDTO)
		{
			string user = null;
			SqlConnection con = new SqlConnection(linkData);
			con.Open();
			string query = "SELECT USERNAME,PASSWORD FROM NGUOIDUNG " +
				"WHERE USERNAME LIKE N'" + userDTO.UserName + "' and PASSWORD LIKE N'" + userDTO.PassWord + "'";
			SqlCommand cmd = new SqlCommand(query, con);
			cmd.Connection = con;
			SqlDataReader reader = cmd.ExecuteReader();
			if (reader.HasRows) //neu ton tai
			{
				while (reader.Read())
				{
					user = reader.GetString(0);
				}
				reader.Close();
				con.Close();

			}
			else return "Tai khoan mat khau khong chinh xac";
			return user;

		}
		//public DataTable getDanhSachNhanVienPage(int limit, int page)
		//{
		//	SqlDataAdapter nvAdapter = new SqlDataAdapter();
		//	string query = "SELECT MANV AS [Mã nhân viên], TENNV AS [Tên nhân viên], GIOITINH AS [Giới tính], NGAYSINH AS [Ngày sinh], DIACHI AS [Địa chỉ], SDT AS [Số điện thoại], DIENGIAI AS [Diễn giải], FLAG AS [Trạng thái] FROM NHANVIEN";

		//	// Khởi tạo đối tượng kết nối
		//	using (SqlConnection con = new SqlConnection(linkData))
		//	{
		//		con.Open(); // Mở kết nối
		//		// Khởi tạo SqlDataAdapter với SqlCommand và SqlConnection
		//		nvAdapter.SelectCommand = new SqlCommand(query, con);
		//		DataTable dsNv = new DataTable();
		//		nvAdapter.Fill((page - 1) * limit, limit, dsNv);
		//		con.Close(); // Đóng kết nối
		//		return dsNv;
		//	}
		//}
	}
}
