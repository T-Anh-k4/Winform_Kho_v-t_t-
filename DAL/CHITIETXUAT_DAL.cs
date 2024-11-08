using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using DTO;

    namespace DAL
    {
        public class CHITIETXUAT_DAL : DataProvider
        {
            DataProvider instance = new DataProvider();
            SqlDataAdapter nvAdapter = new SqlDataAdapter();

            public CHITIETXUAT_DAL()
            {
                instance = new DataProvider();
            }

            public DataTable GetDanhSachChiTietXuat(string maHDX)
            {
                string query = "SELECT ID, IDKHO as [Mã kho], SO_HD_XUAT as [Số hóa đơn xuất], SOLUONG_XUAT as [Số lượng xuất], DONGIA_XUAT as [Đơn giá xuất] " +
                               "FROM CHITIET_HD_XUAT WHERE SO_HD_XUAT = @maHDX";
                SqlParameter[] parameters = {
                new SqlParameter("@maHDX", maHDX)
            };
                return instance.execQuery(query, parameters);
            }

            public DataTable GetDanhSachChiTietXuatPage(string maHDX, int limit, int page)
            {
                string query = "SELECT ID, IDKHO as [Mã kho], SO_HD_XUAT as [Số hóa đơn xuất], SOLUONG_XUAT as [Số lượng xuất], DONGIA_XUAT as [Đơn giá xuất] " +
                               "FROM CHITIET_HD_XUAT WHERE SO_HD_XUAT = @maHDX";
                using (SqlConnection con = new SqlConnection(LinkData))
                {
                    con.Open(); // Mở kết nối

                    // Khởi tạo SqlDataAdapter với SqlCommand và SqlConnection
                    nvAdapter.SelectCommand = new SqlCommand(query, con);
                    nvAdapter.SelectCommand.Parameters.AddWithValue("@maHDX", maHDX);
                    DataTable dsChiTietXuat = new DataTable();
                    nvAdapter.Fill((page - 1) * limit, limit, dsChiTietXuat);

                    con.Close(); // Đóng kết nối
                    return dsChiTietXuat;
                }
            }

            public int GetSLChiTietXuat(string maHDX)
            {
                string query = "SELECT COUNT(*) FROM CHITIET_HD_XUAT WHERE SO_HD_XUAT = @maHDX";
                SqlParameter[] parameters = {
                new SqlParameter("@maHDX", maHDX)
            };
                object result = instance.execScalar(query, parameters);
                int slChiTietXuat = result != null ? Convert.ToInt32(result) : 0;
                return slChiTietXuat;
            }


            public int GetMaxID()
            {
                string query = "SELECT ISNULL(MAX(ID), 0) FROM CHITIET_HD_XUAT";
                object result = instance.execScalar(query);
                return result != null ? Convert.ToInt32(result) : 0;
            }

            public bool InsertChiTietXuat(string idKho, string maHDX, int soLuongXuat, int donGiaXuat)
            {
                try
                {
                    int newID = GetMaxID() + 1;
                    string query = "INSERT INTO CHITIET_HD_XUAT(ID, IDKHO, SO_HD_XUAT, SOLUONG_XUAT, DONGIA_XUAT) " +
                                   "VALUES (@id, @idKho, @maHDX, @soLuongXuat, @donGiaXuat)";
                    SqlParameter[] parameters = {
                    new SqlParameter("@id", newID),
                    new SqlParameter("@idKho", idKho),
                    new SqlParameter("@maHDX", maHDX),
                    new SqlParameter("@soLuongXuat", soLuongXuat),
                    new SqlParameter("@donGiaXuat", donGiaXuat)
                };
                    instance.execNonQuery(query, parameters);
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception("Có lỗi xảy ra khi thêm chi tiết xuất: " + ex.Message);
                }
            }

            public bool UpdateChiTietXuat(int id, string idKho, string maHDX, int soLuongXuat, int donGiaXuat)
            {
                try
                {
                    string query = "UPDATE CHITIET_HD_XUAT " +
                                   "SET IDKHO = @idKho, " +
                                   "SO_HD_XUAT = @maHDX, " +
                                   "SOLUONG_XUAT = @soLuongXuat, " +
                                   "DONGIA_XUAT = @donGiaXuat " +
                                   "WHERE ID = @id";
                    SqlParameter[] parameters = {
                    new SqlParameter("@id", id),
                    new SqlParameter("@idKho", idKho),
                    new SqlParameter("@maHDX", maHDX),
                    new SqlParameter("@soLuongXuat", soLuongXuat),
                    new SqlParameter("@donGiaXuat", donGiaXuat)
                };
                    instance.execNonQuery(query, parameters);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public bool DeleteChiTietXuat(int id, string maHDX)
            {
                try
                {
                    string query = "DELETE FROM CHITIET_HD_XUAT WHERE ID = @id AND SO_HD_XUAT = @maHDX";
                    SqlParameter[] parameters = {
                    new SqlParameter("@id", id),
                    new SqlParameter("@maHDX", maHDX)
                };
                    instance.execNonQuery(query, parameters);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public DataTable SearchChiTietXuat(string maHDX, string keyword)
            {
                try
                {
                    string query = "SELECT ID, IDKHO as [Mã kho], SO_HD_XUAT as [Số hóa đơn xuất], SOLUONG_XUAT as [Số lượng xuất], DONGIA_XUAT as [Đơn giá xuất] " +
                                   "FROM CHITIET_HD_XUAT " +
                                   "WHERE SO_HD_XUAT = @maHDX AND (IDKHO LIKE N'%" + keyword + "%' OR SO_HD_XUAT LIKE N'%" + keyword + "%')";
                    SqlParameter[] parameters = {
                    new SqlParameter("@maHDX", maHDX)
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

}
