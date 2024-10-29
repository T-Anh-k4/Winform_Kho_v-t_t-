using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class CHITIETNHAP_DAL : DataProvider
    {
        DataProvider instance = new DataProvider();
        SqlDataAdapter nvAdapter = new SqlDataAdapter();

        public CHITIETNHAP_DAL()
        {
            instance = new DataProvider();
        }

        public DataTable GetDanhSachChiTietNhap(string maHDN)
        {
            string query = "SELECT ID, MAHH as [Mã hàng hóa], SO_HD_NHAP as [Số hóa đơn nhập], SOLUONG_NHAP as [Số lượng nhập], DONGIA_NHAP as [Đơn giá nhập] " +
                           "FROM CHITIET_HD_NHAP WHERE SO_HD_NHAP = @maHDN";
            SqlParameter[] parameters = {
                new SqlParameter("@maHDN", maHDN)
            };
            return instance.execQuery(query, parameters);
        }

        public DataTable GetDanhSachChiTietNhapPage(string maHDN, int limit, int page)
        {
            string query = "SELECT ID, MAHH as [Mã hàng hóa], SO_HD_NHAP as [Số hóa đơn nhập], SOLUONG_NHAP as [Số lượng nhập], DONGIA_NHAP as [Đơn giá nhập] " +
                           "FROM CHITIET_HD_NHAP WHERE SO_HD_NHAP = @maHDN";
            using (SqlConnection con = new SqlConnection(LinkData))
            {
                con.Open(); // Mở kết nối

                // Khởi tạo SqlDataAdapter với SqlCommand và SqlConnection
                nvAdapter.SelectCommand = new SqlCommand(query, con);
                nvAdapter.SelectCommand.Parameters.AddWithValue("@maHDN", maHDN);
                DataTable dsChiTietNhap = new DataTable();
                nvAdapter.Fill((page - 1) * limit, limit, dsChiTietNhap);

                con.Close(); // Đóng kết nối
                return dsChiTietNhap;
            }
        }

        public int GetSLChiTietNhap(string maHDN)
        {
            string query = "SELECT COUNT(*) FROM CHITIET_HD_NHAP WHERE SO_HD_NHAP = @maHDN";
            SqlParameter[] parameters = {
                new SqlParameter("@maHDN", maHDN)
            };
            object result = instance.execScalar(query, parameters);
            int slChiTietNhap = result != null ? Convert.ToInt32(result) : 0;
            return slChiTietNhap;
        }


        public int GetMaxID()
        {
            string query = "SELECT ISNULL(MAX(ID), 0) FROM CHITIET_HD_NHAP";
            object result = instance.execScalar(query);
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public bool InsertChiTietNhap(string maHH, string maHDN, int soLuongNhap, int donGiaNhap)
        {
            try
            {
                int newID = GetMaxID() + 1;
                string query = "INSERT INTO CHITIET_HD_NHAP(ID, MAHH, SO_HD_NHAP, SOLUONG_NHAP, DONGIA_NHAP) " +
                               "VALUES (@id, @maHH, @maHDN, @soLuongNhap, @donGiaNhap)";
                SqlParameter[] parameters = {
            new SqlParameter("@id", newID),
            new SqlParameter("@maHH", maHH),
            new SqlParameter("@maHDN", maHDN),
            new SqlParameter("@soLuongNhap", soLuongNhap),
            new SqlParameter("@donGiaNhap", donGiaNhap)
        };
                instance.execNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi thêm chi tiết nhập: " + ex.Message);
            }
        }

        public bool UpdateChiTietNhap(int id, string maHH, string maHDN, int soLuongNhap, int donGiaNhap)
        {
            try
            {
                string query = "UPDATE CHITIET_HD_NHAP " +
                               "SET MAHH = @maHH, " +
                               "SO_HD_NHAP = @maHDN, " +
                               "SOLUONG_NHAP = @soLuongNhap, " +
                               "DONGIA_NHAP = @donGiaNhap " +
                               "WHERE ID = @id";
                SqlParameter[] parameters = {
                    new SqlParameter("@id", id),
                    new SqlParameter("@maHH", maHH),
                    new SqlParameter("@maHDN", maHDN),
                    new SqlParameter("@soLuongNhap", soLuongNhap),
                    new SqlParameter("@donGiaNhap", donGiaNhap)
                };
                instance.execNonQuery(query, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteChiTietNhap(int id, string maHDN)
        {
            try
            {
                string query = "DELETE FROM CHITIET_HD_NHAP WHERE ID = @id AND SO_HD_NHAP = @maHDN";
                SqlParameter[] parameters = {
                    new SqlParameter("@id", id),
                    new SqlParameter("@maHDN", maHDN)
                };
                instance.execNonQuery(query, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable SearchChiTietNhap(string maHDN, string keyword)
        {
            try
            {
                string query = "SELECT ID, MAHH as [Mã hàng hóa], SO_HD_NHAP as [Số hóa đơn nhập], SOLUONG_NHAP as [Số lượng nhập], DONGIA_NHAP as [Đơn giá nhập] " +
                               "FROM CHITIET_HD_NHAP " +
                               "WHERE SO_HD_NHAP = @maHDN AND (MAHH LIKE N'%" + keyword + "%' OR SO_HD_NHAP LIKE N'%" + keyword + "%')";
                SqlParameter[] parameters = {
                    new SqlParameter("@maHDN", maHDN)
                };
                return instance.execQuery(query, parameters);
            }
            catch
            {
                return null;
            }
        }
    }
}