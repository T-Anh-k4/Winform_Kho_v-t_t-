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
            string query = "SELECT SO_HD_XUAT as [Số hóa đơn xuất], MAKH as [Mã khách hàng], MANV as [Mã nhân viên], NGAYLAP_XUAT as [Ngày lập hóa đơn xuất], FLAGHOXUAT as [Trạng thái hóa đơn xuất] FROM HOADON_XUAT";
            return instance.execQuery(query);
        }

        public DataTable GetDanhSachHoaDonXuatPage(int limit, int page)
        {
            string query = "SELECT SO_HD_XUAT as [Số hóa đơn xuất], MAKH as [Mã khách hàng], MANV as [Mã nhân viên], NGAYLAP_XUAT as [Ngày lập hóa đơn xuất], FLAGHOXUAT as [Trạng thái hóa đơn xuất] FROM HOADON_XUAT";
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

        public bool InsertHoaDonXuat(string soHDXuat, string maKH, string maNV, DateTime ngayLapXuat, int flagHoXuat)
        {
            try
            {
                string query = "INSERT INTO HOADON_XUAT(SO_HD_XUAT, MAKH, MANV, NGAYLAP_XUAT, FLAGHOXUAT) " +
                               "VALUES (N'" + soHDXuat + "', N'" + maKH + "', N'" + maNV + "', @ngayLapXuat, " + flagHoXuat + ")";
                SqlParameter[] parameters = {
                    new SqlParameter("@ngayLapXuat", ngayLapXuat)
                };
                instance.execNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi thêm hóa đơn xuất: " + ex.Message);
            }
        }

        public bool UpdateHoaDonXuat(string soHDXuat, string maKH, string maNV, DateTime ngayLapXuat, int flagHoXuat)
        {
            try
            {
                string query = "UPDATE HOADON_XUAT " +
                               "SET MAKH = N'" + maKH + "', " +
                               "MANV = N'" + maNV + "', " +
                               "NGAYLAP_XUAT = @ngayLapXuat, " +
                               "FLAGHOXUAT = " + flagHoXuat + " " +
                               "WHERE SO_HD_XUAT = N'" + soHDXuat + "'";
                SqlParameter[] parameters = {
                    new SqlParameter("@ngayLapXuat", ngayLapXuat)
                };
                instance.execNonQuery(query, parameters);
                return true;
            }
            catch
            {
                return false;
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
                string query = "SELECT SO_HD_XUAT as [Số hóa đơn xuất], MAKH as [Mã khách hàng], MANV as [Mã nhân viên], NGAYLAP_XUAT as [Ngày lập hóa đơn xuất], FLAGHOXUAT as [Trạng thái hóa đơn xuất] " +
                               "FROM HOADON_XUAT " +
                               "WHERE SO_HD_XUAT LIKE N'%" + keyword + "%'";
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
    }
}