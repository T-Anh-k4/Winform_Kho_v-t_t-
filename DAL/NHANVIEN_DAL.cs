using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
	public class NHANVIEN_DAL : DataProvider
	{
		DataProvider instance = new DataProvider();
		SqlDataAdapter nvAdapter = new SqlDataAdapter();

		//NHANVIEN_DTO nhanVienDTO = new NHANVIEN_DTO();
		public NHANVIEN_DAL()
		{
			instance = new DataProvider();
		}

		public DataTable getDanhSachNhanVien()
		{
            string query = "SELECT MANV AS [Mã nhân viên], TENNV AS [Tên nhân viên], GIOITINH AS [Giới tính], NGAYSINH AS [Ngày sinh], DIACHI AS [Địa chỉ], SDT AS [Số điện thoại], DIENGIAI AS [Diễn giải], CASE WHEN FLAG = 0 THEN N'không hoạt động'	ELSE N'Đang hoạt động' end as [Trạng thái] ,USERNAME AS [Tên tài khoản] FROM NHANVIEN";
            return instance.execQuery(query);
		}
		public DataTable getDanhSachNhanVienPage(int limit, int page)
		{
            string query = "SELECT MANV AS [Mã nhân viên], TENNV AS [Tên nhân viên], GIOITINH AS [Giới tính], NGAYSINH AS [Ngày sinh], DIACHI AS [Địa chỉ], SDT AS [Số điện thoại], DIENGIAI AS [Diễn giải], CASE WHEN FLAG = 0 THEN N'Không hoạt động'	ELSE N'Đang hoạt động' end as [Trạng thái] ,USERNAME AS [Tên tài khoản] FROM NHANVIEN";

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
		public int GetSLSinhVien()
		{
			string query = "SELECT COUNT(*) FROM NHANVIEN";
			object result = instance.execScalar(query);
			int slNhanVien = result != null ? Convert.ToInt32(result) : 0;
			return slNhanVien;
		}
		public DataTable GetNhanVien(string maNV)
		{
            string query = "SELECT MANV AS [Mã nhân viên], TENNV AS [Tên nhân viên], GIOITINH AS [Giới tính], NGAYSINH AS [Ngày sinh], DIACHI AS [Địa chỉ], SDT AS [Số điện thoại], DIENGIAI AS [Diễn giải], FLAG AS [Trạng thái],USERNAME AS [Tên tài khoản] FROM NHANVIEN " +
            "WHERE MANV = N'" + maNV + "'";
			return instance.execQuery(query);	
		}
		public DataTable GetGioiTinh()
		{
			string query = "SELECT GIOITINH FROM NHANVIEN";
			return instance.execQuery(query);
		}
        public bool DeleteNhanVien(string maNV)
        {
            try
            {
                string deleteTaiKhoanQuery = "DELETE FROM NHANVIEN WHERE MANV = N'" + maNV + "'";
                // Thực hiện câu lệnh SQL
                instance.execNonQuery(deleteTaiKhoanQuery);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool InsertNhanVien(string maNV, string tenNV, string gioiTinh, string ngaySinh, string diaChi, string soDT, string dienGia, int flag, string username)
        {
            try
            {
                // Kiểm tra nếu username rỗng
                string query = "INSERT INTO NHANVIEN(MANV, TENNV, GIOITINH, NGAYSINH, DIACHI, SDT, DIENGIAI, FLAG, USERNAME) " +
                               "VALUES (N'" + maNV + "', N'" + tenNV + "', N'" + gioiTinh + "', N'" + ngaySinh + "', N'" + diaChi + "', N'" + soDT + "', N'" + dienGia + "', " + flag + ", " + (string.IsNullOrEmpty(username) ? "NULL" : "N'" + username + "'") + ")";
                instance.execNonQuery(query);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateNhanVien(string maNV, string tenNV, string gioiTinh, string ngaySinh, string diaChi, string soDT, string dienGia, int flag, string username)
        {
            try
            {
                // Sử dụng NULL cho USERNAME nếu username trống
                string query = "UPDATE NHANVIEN " +
                               "SET TENNV = N'" + tenNV + "', " +
                               "GIOITINH = N'" + gioiTinh + "', " +
                               "NGAYSINH = '" + ngaySinh + "', " +
                               "DIACHI = N'" + diaChi + "', " +
                               "SDT = N'" + soDT + "', " +
                               "DIENGIAI = N'" + dienGia + "', " +
                               "FLAG = " + flag + ", " +
                               "USERNAME = " + (string.IsNullOrEmpty(username) ? "NULL" : $"'{username}'") + " " +
                               "WHERE MANV = N'" + maNV + "'";

                instance.execNonQuery(query);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool CheckUserName(string username)
        {
            // Kiểm tra xem tên tài khoản đã tồn tại hoặc là NULL
            string query = "select count(USERNAME) from NGUOIDUNG where USERNAME in (select USERNAME from NHANVIEN ) and USERNAME = N'" + username + "'";
            object result = instance.execScalar(query); 
            return result != null && (int)result > 0; // Trả về true nếu USERNAME đã tồn tại hoặc là NULL
        }


        public DataTable SearchNhanVien(string keyword)
		{
			try
			{
				string query = "SELECT MANV AS [Mã nhân viên], TENNV AS [Tên nhân viên], GIOITINH AS [Giới tính], NGAYSINH AS [Ngày sinh], DIACHI AS [Địa chỉ], SDT AS [Số điện thoại], DIENGIAI AS [Diễn giải], FLAG AS [Trạng thái] " +
				" FROM NHANVIEN " +
				" WHERE TENNV LIKE N'%" + keyword + "%'";

				return instance.execQuery(query);
			}
			catch
			{
				return null;
			}
		}

	}
}
