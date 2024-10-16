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
			string query = "SELECT MANV AS [Mã nhân viên], TENNV AS [Tên nhân viên], GIOITINH AS [Giới tính], NGAYSINH AS [Ngày sinh], DIACHI AS [Địa chỉ], SDT AS [Số điện thoại], DIENGIAI AS [Diễn giải], FLAG AS [Trạng thái] FROM NHANVIEN";
			return instance.execQuery(query);
		}
		public DataTable getDanhSachNhanVienPage(int limit, int page)
		{
			string query = "SELECT MANV AS [Mã nhân viên], TENNV AS [Tên nhân viên], GIOITINH AS [Giới tính], NGAYSINH AS [Ngày sinh], DIACHI AS [Địa chỉ], SDT AS [Số điện thoại], DIENGIAI AS [Diễn giải], FLAG AS [Trạng thái] FROM NHANVIEN";

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
			string query = "SELECT MANV AS [Mã nhân viên], TENNV AS [Tên nhân viên], GIOITINH AS [Giới tính], NGAYSINH AS [Ngày sinh], DIACHI AS [Địa chỉ], SDT AS [Số điện thoại], DIENGIAI AS [Diễn giải], FLAG AS [Trạng thái] FROM NHANVIEN " +
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
				string query = "delete from NHANVIEN " +
					"WHERE MANV = N'" + maNV + "'";
				// Thực hiện câu lệnh SQL
				instance.execNonQuery(query);
			}
			catch
			{
				return false;
			}
			return true;
		}
		public bool InsertNhanVien(string maNV, string tenNV, string gioiTinh, string ngaySinh, string diaChi, string soDT, string dienGia, int flag)
		{
			try
			{
				string query = "INSERT INTO NHANVIEN(MANV, TENNV, GIOITINH, NGAYSINH, DIACHI, SDT, DIENGIAI, FLAG) " +
							   "VALUES (N'" + maNV + "', N'" + tenNV + "', N'" + gioiTinh + "', N'" + ngaySinh + "', N'" + diaChi + "', N'" + soDT + "', N'" + dienGia + "', " + flag + ")";
				instance.execNonQuery(query);
			}
			catch
			{
				return false;
			}
			return true;
		}
		public bool UpdateNhanVien(string maNV, string tenNV, string gioiTinh, string ngaySinh, string diaChi, string soDT, string dienGia, int flag)
		{
			try
			{
				// Xây dựng câu lệnh SQL với các biến được chèn trực tiếp
				string query = "UPDATE NHANVIEN " +
							   "SET TENNV = N'" + tenNV + "', " +
							   "GIOITINH = N'" + gioiTinh + "', " +
							   "NGAYSINH = '" + ngaySinh + "', " +
							   "DIACHI = N'" + diaChi + "', " +
							   "SDT = N'" + soDT + "', " +
							   "DIENGIAI = N'" + dienGia + "', " +
							   "FLAG = " + flag + " " +
							   "WHERE MANV = N'" + maNV + "'";

				// Thực hiện câu lệnh SQL
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
