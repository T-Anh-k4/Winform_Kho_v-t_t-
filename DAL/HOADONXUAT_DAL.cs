using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class HOADONXUAT_DAL : DataProvider
    {
        DataProvider instance = new DataProvider();
        SqlDataAdapter nvAdapter = new SqlDataAdapter();

        public HOADONXUAT_DAL()
        {
            instance = new DataProvider();
        }

        public DataTable GetDanhSachHoaDonXuat()
        {
            string query = @"
        SELECT 
            SO_HD_XUAT as [Số hóa đơn xuất], 
            KH.TENKH as [Tên khách hàng], 
            NV.TENNV as [Tên nhân viên], 
            NGAYLAP_XUAT as [Ngày lập hóa đơn xuất]
        FROM HOADON_XUAT HDX
        JOIN KHACHHANG KH ON HDX.MAKH = KH.MAKH
        JOIN NHANVIEN NV ON HDX.MANV = NV.MANV";
            return instance.execQuery(query);
        }

        public DataTable GetDanhSachHoaDonXuatPage(int limit, int page)
        {
            string query = @"
        SELECT 
            SO_HD_XUAT as [Số hóa đơn xuất], 
            KH.TENKH as [Tên khách hàng], 
            NV.TENNV as [Tên nhân viên], 
            NGAYLAP_XUAT as [Ngày lập hóa đơn xuất]
        FROM HOADON_XUAT HDX
        JOIN KHACHHANG KH ON HDX.MAKH = KH.MAKH
        JOIN NHANVIEN NV ON HDX.MANV = NV.MANV";

            using (SqlConnection con = new SqlConnection(LinkData))
            {
                con.Open(); // Mở kết nối

                // Khởi tạo SqlDataAdapter với SqlCommand và SqlConnection
                nvAdapter.SelectCommand = new SqlCommand(query, con);
                DataTable dsHoaDonXuat = new DataTable();
                nvAdapter.Fill((page - 1) * limit, limit, dsHoaDonXuat);

                con.Close(); // Đóng kết nối
                return dsHoaDonXuat;
            }
        }


        public int GetSLHoaDonXuat()
        {
            string query = "SELECT COUNT(*) FROM HOADON_XUAT";
            object result = instance.execScalar(query);
            int slHoaDonXuat = result != null ? Convert.ToInt32(result) : 0;
            return slHoaDonXuat;
        }

        public bool InsertHoaDonXuat(string soHDXuat, string tenKH, string tenNV, DateTime ngayLapXuat, int flagHoXuat)
        {
            try
            {
                // Tìm mã khách hàng dựa trên tên
                string queryGetMaKH = "SELECT MAKH FROM KHACHHANG WHERE TENKH = @tenKH";
                SqlParameter paramTenKH = new SqlParameter("@tenKH", tenKH);
                DataTable dtMaKH = instance.execQuery(queryGetMaKH, paramTenKH);
                if (dtMaKH.Rows.Count == 0)
                {
                    throw new Exception("Không tìm thấy khách hàng với tên đã cung cấp.");
                }
                string maKH = dtMaKH.Rows[0]["MAKH"].ToString();

                // Tìm mã nhân viên dựa trên tên
                string queryGetMaNV = "SELECT MANV FROM NHANVIEN WHERE TENNV = @tenNV";
                SqlParameter paramTenNV = new SqlParameter("@tenNV", tenNV);
                DataTable dtMaNV = instance.execQuery(queryGetMaNV, paramTenNV);
                if (dtMaNV.Rows.Count == 0)
                {
                    throw new Exception("Không tìm thấy nhân viên với tên đã cung cấp.");
                }
                string maNV = dtMaNV.Rows[0]["MANV"].ToString();

                // Chèn hóa đơn xuất
                string queryInsert = "INSERT INTO HOADON_XUAT(SO_HD_XUAT, MAKH, MANV, NGAYLAP_XUAT, FLAGXUAT) " +
                                     "VALUES (@soHDXuat, @maKH, @maNV, @ngayLapXuat, @flagXuat)";
                SqlParameter[] parameters = {
            new SqlParameter("@soHDXuat", soHDXuat),
            new SqlParameter("@maKH", maKH),
            new SqlParameter("@maNV", maNV),
            new SqlParameter("@ngayLapXuat", ngayLapXuat),
            new SqlParameter("@flagXuat", flagHoXuat)
        };

                instance.execNonQuery(queryInsert, parameters);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi thêm hóa đơn xuất: " + ex.Message);
            }
        }


        public bool UpdateHoaDonXuat(string soHDXuat, string tenKH, string tenNV, DateTime ngayLapXuat, int flagHoXuat)
        {
            try
            {
                // Tìm mã khách hàng từ tên
                string queryGetMaKH = "SELECT MAKH FROM KHACHHANG WHERE TENKH = @tenKH";
                SqlParameter paramTenKH = new SqlParameter("@tenKH", tenKH);
                DataTable dtMaKH = instance.execQuery(queryGetMaKH, paramTenKH);
                if (dtMaKH.Rows.Count == 0)
                {
                    throw new Exception("Không tìm thấy khách hàng với tên đã cung cấp.");
                }
                string maKH = dtMaKH.Rows[0]["MAKH"].ToString();

                // Tìm mã nhân viên từ tên
                string queryGetMaNV = "SELECT MANV FROM NHANVIEN WHERE TENNV = @tenNV";
                SqlParameter paramTenNV = new SqlParameter("@tenNV", tenNV);
                DataTable dtMaNV = instance.execQuery(queryGetMaNV, paramTenNV);
                if (dtMaNV.Rows.Count == 0)
                {
                    throw new Exception("Không tìm thấy nhân viên với tên đã cung cấp.");
                }
                string maNV = dtMaNV.Rows[0]["MANV"].ToString();

                // Cập nhật hóa đơn xuất
                string queryUpdate = "UPDATE HOADON_XUAT " +
                                     "SET MAKH = @maKH, " +
                                     "MANV = @maNV, " +
                                     "NGAYLAP_XUAT = @ngayLapXuat, " +
                                     "FLAGXUAT = @flagXuat " +
                                     "WHERE SO_HD_XUAT = @soHDXuat";

                SqlParameter[] parameters = {
            new SqlParameter("@soHDXuat", soHDXuat),
            new SqlParameter("@maKH", maKH),
            new SqlParameter("@maNV", maNV),
            new SqlParameter("@ngayLapXuat", ngayLapXuat),
            new SqlParameter("@flagXuat", flagHoXuat)
        };

                instance.execNonQuery(queryUpdate, parameters);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi cập nhật hóa đơn xuất: " + ex.Message);
            }
        }


        public bool DeleteHoaDonXuat(string soHDXuat)
        {
            try
            {
                string query = "DELETE FROM HOADON_XUAT WHERE SO_HD_XUAT = N'" + soHDXuat + "'";
                instance.execNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable SearchHoaDonXuat(string keyword)
        {
            try
            {
                string query = @"
            SELECT 
                HOADON_XUAT.SO_HD_XUAT AS [Số hóa đơn xuất], 
                KHACHHANG.TENKH AS [Tên khách hàng], 
                NHANVIEN.TENNV AS [Tên nhân viên], 
                HOADON_XUAT.NGAYLAP_XUAT AS [Ngày lập hóa đơn xuất]
            FROM 
                HOADON_XUAT
            JOIN 
                KHACHHANG ON HOADON_XUAT.MAKH = KHACHHANG.MAKH
            JOIN 
                NHANVIEN ON HOADON_XUAT.MANV = NHANVIEN.MANV
            WHERE 
                HOADON_XUAT.SO_HD_XUAT LIKE N'%" + keyword + "%'";

                return instance.execQuery(query);
            }
            catch
            {
                return null;
            }
        }


        public DataTable GetDanhSachKhachHangPage(int limit, int page)
        {
            throw new NotImplementedException();
        }

        public bool IsCustomerExists(string customerId)
        {
            string query = "SELECT COUNT(*) AS Count FROM KHACHHANG WHERE TENKH = @customerId";
            DataTable result = execQuery(query, new SqlParameter("@customerId", customerId));

            // Kiểm tra số lượng bản ghi trả về
            return result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0]["Count"]) > 0;
        }

        // Phương thức kiểm tra mã nhân viên có tồn tại không
        public bool IsEmployeeExists(string employeeId)
        {
            string query = "SELECT COUNT(*) AS Count FROM NHANVIEN WHERE TENNV = @employeeId";
            DataTable result = execQuery(query, new SqlParameter("@employeeId", employeeId));

            // Kiểm tra số lượng bản ghi trả về
            return result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0]["Count"]) > 0;
        }
    }
}