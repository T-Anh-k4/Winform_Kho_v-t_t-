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
		private static string linkData = @"Data Source=DESKTOP-T4N0A0R\SQLEXPRESS;Initial Catalog=QLVATLIEUXD;Integrated Security=True";

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
            bool isAdmin = false;
            using (SqlConnection con = new SqlConnection(linkData))
            {
                con.Open();
                string query = "SELECT USERNAME, PASSWORD, LOAI FROM NGUOIDUNG " +
                               "WHERE USERNAME = @username AND PASSWORD = @password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", userDTO.UserName);
                cmd.Parameters.AddWithValue("@password", userDTO.PassWord);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            user = reader.GetString(0);
                            var loai = reader.IsDBNull(2) ? null : reader.GetString(2);
                            isAdmin = (loai == "Admin");
                        }
                    }
                    else
                    {
                        return "Tai khoan mat khau khong chinh xac";
                    }
                }
            }
            return isAdmin ? "Admin" : "User"; // Return the role to be used
        }

        // Thực hiện truy vấn SELECT và trả về kết quả dưới dạng DataTable
        public DataSet readDataSet(string query, params SqlParameter[] parameters)
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection con = new SqlConnection(linkData))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet); // Điền dữ liệu vào DataSet
                con.Close();
            }
            return dataSet;
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
