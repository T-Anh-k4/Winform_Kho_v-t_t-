using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class HANGNHAP_DAL : DataProvider
    {
        DataProvider instance = new DataProvider();
        SqlDataAdapter nvAdapter = new SqlDataAdapter();

        public HANGNHAP_DAL()
        {
            instance = new DataProvider();
        }

        public DataTable GetDanhSachHoaDonNhap()
        {
            string query = "SELECT SO_HD_NHAP as [Số hóa đơn nhập], MANCC as [Mã nhà cung cấp], MANV as [Mã nhân viên], NGAYLAP_NHAP as [Ngày lập hóa đơn nhập], FLAGHONHAP as [Trạng thái hóa đơn nhập] FROM HOADON_NHAP";
            return instance.execQuery(query);
        }

        public DataTable GetDanhSachHoaDonNhapPage(int limit, int page)
        {
            string query = "SELECT SO_HD_NHAP as [Số hóa đơn nhập], NHACUNGCAP.MANCC as [Mã nhà cung cấp],TENNCC as [Tên nhà cung cấp], NHANVIEN.MANV as [Mã nhân viên], TENNV as [Tên nhân viên], NGAYLAP_NHAP as [Ngày lập hóa đơn nhập], FLAGHONHAP as [Trạng thái hóa đơn nhập] FROM HOADON_NHAP JOIN NHACUNGCAP ON HOADON_NHAP.MANCC = NHACUNGCAP.MANCC JOIN NHANVIEN ON HOADON_NHAP.MANV = NHANVIEN.MANV";
            using (SqlConnection con = new SqlConnection(LinkData))
            {
                con.Open(); // Mở kết nối

                // Khởi tạo SqlDataAdapter với SqlCommand và SqlConnection
                nvAdapter.SelectCommand = new SqlCommand(query, con);
                DataTable dsHoaDonNhap = new DataTable();
                nvAdapter.Fill((page - 1) * limit, limit, dsHoaDonNhap);

                con.Close(); // Đóng kết nối
                return dsHoaDonNhap;
            }
        }

        public int GetSLHoaDonNhap()
        {
            string query = "SELECT COUNT(*) FROM HOADON_NHAP";
            object result = instance.execScalar(query);
            int slHoaDonNhap = result != null ? Convert.ToInt32(result) : 0;
            return slHoaDonNhap;
        }

        public bool InsertHoaDonNhap(string soHDNhap, string tenNCC, string tenNV, DateTime ngayLapNhap, int flagHoNhap)
        {
            try
            {
                // Retrieve the maNCC based on the provided tenNCC
                string getMaNCCQuery = "SELECT MANCC FROM NHACUNGCAP WHERE TENNCC = @tenNCC";
                SqlParameter[] getMaNCCParameters = {
                    new SqlParameter("@tenNCC", tenNCC)
                };
                object maNCCResult = instance.execScalar(getMaNCCQuery, getMaNCCParameters);

                if (maNCCResult == null)
                {
                    throw new Exception("Không tìm thấy MANCC cho tên nhà cung cấp: " + tenNCC);
                }

                string maNCC = maNCCResult.ToString();

                // Retrieve the maNV based on the provided tenNV
                string getMaNVQuery = "SELECT MANV FROM NHANVIEN WHERE TENNV = @tenNV";
                SqlParameter[] getMaNVParameters = {
                    new SqlParameter("@tenNV", tenNV)
                };
                object maNVResult = instance.execScalar(getMaNVQuery, getMaNVParameters);

                if (maNVResult == null)
                {
                    throw new Exception("Không tìm thấy MANV cho tên nhân viên: " + tenNV);
                }

                string maNV = maNVResult.ToString();

                // Insert the record into HOADON_NHAP
                string query = "INSERT INTO HOADON_NHAP(SO_HD_NHAP, MANCC, MANV, NGAYLAP_NHAP, FLAGHONHAP) " +
                               "VALUES (@soHDNhap, @maNCC, @maNV, @ngayLapNhap, @flagHoNhap)";
                SqlParameter[] parameters = {
                    new SqlParameter("@soHDNhap", soHDNhap),
                    new SqlParameter("@maNCC", maNCC),
                    new SqlParameter("@maNV", maNV),
                    new SqlParameter("@ngayLapNhap", ngayLapNhap),
                    new SqlParameter("@flagHoNhap", flagHoNhap)
                };
                instance.execNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi thêm hóa đơn nhập: " + ex.Message);
            }
        }

        public bool UpdateHoaDonNhap(string soHDNhap, string tenNCC, string tenNV, DateTime ngayLapNhap, int flagHoNhap)
        {
            try
            {
                // Retrieve the maNCC based on the provided tenNCC
                string getMaNCCQuery = "SELECT MANCC FROM NHACUNGCAP WHERE TENNCC = @tenNCC";
                SqlParameter[] getMaNCCParameters = {
            new SqlParameter("@tenNCC", tenNCC)
        };
                object maNCCResult = instance.execScalar(getMaNCCQuery, getMaNCCParameters);

                if (maNCCResult == null)
                {
                    throw new Exception("Không tìm thấy MANCC cho tên nhà cung cấp: " + tenNCC);
                }

                string maNCC = maNCCResult.ToString();

                // Retrieve the maNV based on the provided tenNV
                string getMaNVQuery = "SELECT MANV FROM NHANVIEN WHERE TENNV = @tenNV";
                SqlParameter[] getMaNVParameters = {
            new SqlParameter("@tenNV", tenNV)
        };
                object maNVResult = instance.execScalar(getMaNVQuery, getMaNVParameters);

                if (maNVResult == null)
                {
                    throw new Exception("Không tìm thấy MANV cho tên nhân viên: " + tenNV);
                }

                string maNV = maNVResult.ToString();

                string query = "UPDATE HOADON_NHAP " +
                               "SET MANCC = @maNCC, " +
                               "MANV = @maNV, " +
                               "NGAYLAP_NHAP = @ngayLapNhap, " +
                               "FLAGHONHAP = @flagHoNhap " +
                               "WHERE SO_HD_NHAP = @soHDNhap";
                SqlParameter[] parameters = {
            new SqlParameter("@maNCC", maNCC),
            new SqlParameter("@maNV", maNV),
            new SqlParameter("@ngayLapNhap", ngayLapNhap),
            new SqlParameter("@flagHoNhap", flagHoNhap),
            new SqlParameter("@soHDNhap", soHDNhap)
        };
                instance.execNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi cập nhật hóa đơn nhập: " + ex.Message);
            }
        }

        public bool DeleteHoaDonNhap(string soHDNhap)
        {
            try
            {
                string query = "DELETE FROM HOADON_NHAP WHERE SO_HD_NHAP = N'" + soHDNhap + "'";
                instance.execNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable SearchHoaDonNhap(string keyword)
        {
            try
            {
                string query = "SELECT SO_HD_NHAP as [Số hóa đơn nhập], MANCC as [Mã nhà cung cấp], MANV as [Mã nhân viên], NGAYLAP_NHAP as [Ngày lập hóa đơn nhập], FLAGHONHAP as [Trạng thái hóa đơn nhập] " +
                               "FROM HOADON_NHAP " +
                               "WHERE SO_HD_NHAP LIKE N'%" + keyword + "%'";
                return instance.execQuery(query);
            }
            catch
            {
                return null;
            }
        }
        public bool IsMaHangExist(string mah)
        {
            string query = "SELECT COUNT(*) FROM HOADON_NHAP WHERE SO_HD_NHAP = @mah";
            SqlParameter[] parameters = {
        new SqlParameter("@mah", mah)
        };
            int count = Convert.ToInt32(instance.execScalar(query, parameters));
            return count > 0;
        }
        public bool IsTenNCCExist(string mah)
        {
            string query = "SELECT COUNT(*) FROM NHACUNGCAP WHERE TENNCC = @mah";
            SqlParameter[] parameters = {
        new SqlParameter("@mah", mah)
        };
            int count = Convert.ToInt32(instance.execScalar(query, parameters));
            return count > 0;
        }
        public bool IsTenNVExist(string mah)
        {
            string query = "SELECT COUNT(*) FROM NHANVIEN WHERE TENNV = @mah";
            SqlParameter[] parameters = {
        new SqlParameter("@mah", mah)
        };
            int count = Convert.ToInt32(instance.execScalar(query, parameters));
            return count > 0;
        }
    }
}