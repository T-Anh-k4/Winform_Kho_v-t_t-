using DAL;
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
	public class HANGHOA_DAL : DataProvider
    {
        SqlDataAdapter nvAdapter = new SqlDataAdapter();
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
        public DataTable getDanhSachHangHoaPage(int limit, int page)
        {
            string query = "SELECT MAHH as [Mã hàng hóa],TENLOAI as [Tên loại hàng],HANGHOA.MALOAI as [Mã loại],TENHH as [Tên hàng hóa],DONVI_TINH as [Đơn vị],XUATXU as [Xuất xứ] "
			+"FROM HANGHOA "+"JOIN LOAIHANG ON HANGHOA.MALOAI = LOAIHANG.MALOAI";

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
        public int GetSLHangHoa()
        {
            string query = "SELECT COUNT(*) FROM HANGHOA";
            object result = instance.execScalar(query);
            int slNhanVien = result != null ? Convert.ToInt32(result) : 0;
            return slNhanVien;
        }
        public bool CheckMaHH(string username)
        {
            string query = "select count(MAHH) from HANGHOA where MAHH in (select MAHH from HANGHOA ) and MAHH = N'" + username + "'";
            // Gọi execScalar để thực hiện truy vấn và lấy số lượng
            object result = instance.execScalar(query);
            // Chuyển đổi kết quả thành int và kiểm tra xem có lớn hơn 0 hay không
            return result != null && (int)result > 0; // Trả về true nếu USERNAME đã tồn tại
        }
        public DataTable GetLoaihang()
		{
			string query = "SELECT MALOAI, TENLOAI " +
						   "FROM LOAIHANG ";
			return instance.execQuery(query);
		}
		public bool DeleteHangHoa(string maHH)
		{
			try
			{
				// Lấy danh sách IDKHO từ bảng KHO tương ứng với MAHH
				string queryGetIDKho = "SELECT IDKHO FROM KHO WHERE MAHH = N'" + maHH + "'";
				DataTable dtKho = instance.execQuery(queryGetIDKho);

				// Xóa các bản ghi trong CHITIET_HD_XUAT dựa trên IDKHO
				foreach (DataRow row in dtKho.Rows)
				{
					string idKho = row["IDKHO"].ToString();
					string queryXuat = "DELETE FROM CHITIET_HD_XUAT WHERE IDKHO = N'" + idKho + "'";
					instance.execNonQuery(queryXuat);
				}

				// Xóa các bản ghi trong KHO dựa trên MAHH
				string queryKho = "DELETE FROM KHO WHERE MAHH = N'" + maHH + "'";
				instance.execNonQuery(queryKho);

				// Xóa các bản ghi trong CHITIET_HD_NHAP dựa trên MAHH
				string queryNhap = "DELETE FROM CHITIET_HD_NHAP WHERE MAHH = N'" + maHH + "'";
				instance.execNonQuery(queryNhap);

				// Cuối cùng, xóa hàng hóa trong HANGHOA
				string queryHangHoa = "DELETE FROM HANGHOA WHERE MAHH = N'" + maHH + "'";
				instance.execNonQuery(queryHangHoa);
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
				string query = "INSERT INTO HANGHOA(MAHH, MALOAI, TENHH, DONVI_TINH, XUATXU) " +
							   "VALUES (N'" + mahh + "', N'" + malh + "', N'" + tenHang + "', N'" + dvt + "', N'" + xuatXu + "')";
				instance.execNonQuery(query);
				return true;
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra khi thêm hàng hóa: " + ex.Message);
			}
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
		public DataTable SearchHangHoa(string keyword)
		{
			try
			{
				string query = "SELECT MAHH as [Mã hàng hóa], MALOAI as [Mã loại], TENHH as [Tên hàng hóa], DONVI_TINH as [Đơn vị], XUATXU as [Xuất xứ] " +
							   "FROM HANGHOA " +
							   "WHERE TENHH LIKE N'%" + keyword + "%'";

				return instance.execQuery(query);
			}
			catch
			{
				return null;
			}
		}

	}
}
