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
            string query = "SELECT SO_HD_NHAP as [Số hóa đơn nhập], MANCC as [Mã nhà cung cấp], MANV as [Mã nhân viên], NGAYLAP_NHAP as [Ngày lập hóa đơn nhập], FLAGHONHAP as [Trạng thái hóa đơn nhập] FROM HOADON_NHAP";
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

        public bool InsertHoaDonNhap(string soHDNhap, string maNCC, string maNV, DateTime ngayLapNhap, int flagHoNhap)
        {
            Console.WriteLine(soHDNhap, maNCC, maNV, ngayLapNhap, flagHoNhap);
            try
            {
                string query = "INSERT INTO HOADON_NHAP(SO_HD_NHAP, MANCC, MANV, NGAYLAP_NHAP, FLAGHONHAP) " +
                               "VALUES (N'" + soHDNhap + "', N'" + maNCC + "', N'" + maNV + "', @ngayLapNhap, " + flagHoNhap + ")";
                SqlParameter[] parameters = {
                    new SqlParameter("@ngayLapNhap", ngayLapNhap)
                };
                instance.execNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi thêm hóa đơn nhập: " + ex.Message);
            }
        }

        public bool UpdateHoaDonNhap(string soHDNhap, string maNCC, string maNV, DateTime ngayLapNhap, int flagHoNhap)
        {
            try
            {
                string query = "UPDATE HOADON_NHAP " +
                               "SET MANCC = N'" + maNCC + "', " +
                               "MANV = N'" + maNV + "', " +
                               "NGAYLAP_NHAP = @ngayLapNhap, " +
                               "FLAGHONHAP = " + flagHoNhap + " " +
                               "WHERE SO_HD_NHAP = N'" + soHDNhap + "'";
                SqlParameter[] parameters = {
                    new SqlParameter("@ngayLapNhap", ngayLapNhap)
                };
                instance.execNonQuery(query, parameters);
                return true;
            }
            catch
            {
                return false;
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
    }
}