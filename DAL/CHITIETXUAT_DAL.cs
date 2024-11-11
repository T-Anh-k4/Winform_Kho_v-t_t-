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
            string query = "SELECT MAHH as [Mã hàng hóa], SOLUONG_XUAT as [Số lượng xuất], DONGIA_XUAT as [Đơn giá xuất] " +
                           "FROM CHITIET_HD_XUAT WHERE SO_HD_XUAT = @maHDX";
            SqlParameter[] parameters = {
                new SqlParameter("@maHDX", maHDX)
            };
            return instance.execQuery(query, parameters);
        }

        public DataTable GetDanhSachChiTietXuatPage(string maHDX, int limit, int page)
        {
            string query = "SELECT MAHH as [Mã hàng hóa], SOLUONG_XUAT as [Số lượng xuất], DONGIA_XUAT as [Đơn giá xuất] " +
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

        public DataTable getMaVaTenHH()
        {
            string query = "SELECT MAHH as [Mã hàng hóa], TENHH as [Tên hàng hóa]" +
                           "FROM HANGHOA";
            return instance.execQuery(query);
        }

        public DataTable getHoaDonXUatDetail(string maHDX)
        {
            string query = "SELECT SO_HD_XUAT as [Số hóa đơn xuất], TENKH as [Tên khách hàng], TENNV as [Tên nhân viên], NGAYLAP_XUAT as [Ngày lập hóa đơn] " +
                           "FROM HOADON_XUAT " +
                           "JOIN KHACHHANG ON HOADON_XUAT.MANKH = KHACHHANG.MANKH " +
                           "JOIN NHANVIEN ON HOADON_XUAT.MANV = NHANVIEN.MANV " +
                           "WHERE SO_HD_XUAT = @maHDX";
            SqlParameter[] parameters = {
                new SqlParameter("@maHDX", SqlDbType.NVarChar) { Value = maHDX }
            };
            return instance.execQuery(query, parameters);
        }

        public int GetMaxID()
        {
            string query = "SELECT ISNULL(MAX(ID), 0) FROM CHITIET_HD_XUAT";
            object result = instance.execScalar(query);
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public bool InsertChiTietXUAT(string maHH, string maHDX, int soLuongXuat, int donGiaXuat)
        {
            try
            {
                string checkQuery = "SELECT SOLUONG_XUAT FROM CHITIET_HD_XUAT WHERE MAHH = @maHH AND SO_HD_XUAT = @maHDX AND DONGIA_XUAT = @donGiaXuat";
                SqlParameter[] checkParameters = {
                    new SqlParameter("@maHH", maHH),
                    new SqlParameter("@maHDX", maHDX),
                    new SqlParameter("@donGiaXuat", donGiaXuat)
                };
                object result = instance.execScalar(checkQuery, checkParameters);

                if (result != null)
                {
                    int existingSLXuat = Convert.ToInt32(result);
                    int newSLXuat = existingSLXuat + soLuongXuat;
                    string updateQuery = "UPDATE CHITIET_HD_XUAT SET SOLUONG_XUAT = @newSLXuat WHERE MAHH = @maHH AND SO_HD_XUAT = @maHDX AND DONGIA_XUAT = @donGiaXuat";
                    SqlParameter[] updateParameters = {
                        new SqlParameter("@newSLNhap", newSLXuat),
                        new SqlParameter("@maHH", maHH),
                        new SqlParameter("@maHDX", maHDX),
                        new SqlParameter("@donGiaXuat", soLuongXuat)
                    };
                    instance.execNonQuery(updateQuery, updateParameters);
                }
                else
                {
                    int newID = GetMaxID() + 1;
                    string insertQuery = "INSERT INTO CHITIET_HD_XUAT(IDXUAT, MAHH, SO_HD_XUAT, SOLUONG_XUAT, DONGIA_XUAT) " +
                                         "VALUES (@id, @maHH, @maHDX, @soLuongXuat, @donGiaXuat)";
                    SqlParameter[] insertParameters = {
                        new SqlParameter("@id", newID),
                        new SqlParameter("@maHH", maHH),
                        new SqlParameter("@maHDX", maHDX),
                        new SqlParameter("@soLuongXuat", soLuongXuat),
                        new SqlParameter("@donGiaXuat", donGiaXuat)
                    };
                    instance.execNonQuery(insertQuery, insertParameters);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi thêm chi tiết xuất: " + ex.Message);
            }
        }

        public bool UpdateChiTietXuat(string maHH, string maHDX, int soLuongXuat, int donGiaXuat)
        {
            try
            {
                string query = "UPDATE CHITIET_HD_XUAT " +
                               "SET MAHH = @maHH, " +
                               "SO_HD_XUAT = @maHDX, " +
                               "SOLUONG_XUAT = @soLuongXuat, " +
                               "DONGIA_XUAT = @donGiaXuat " +
                               "WHERE MAHH = @maHH AND SO_HD_XUAT = @maHDN AND DONGIA_XUAT = @donGiaXuat";
                SqlParameter[] parameters = {
                    new SqlParameter("@maHH", maHH),
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

        public bool DeleteChiTietXuat(string maHH, string maHDX, int donGiaXuat)
        {
            try
            {
                string query = "DELETE FROM CHITIET_HD_XUAT WHERE MaHH = @maHH AND SO_HD_XUAT = @maHDX AND DONGIA_XUAT = @donGiaXuat";
                SqlParameter[] parameters = {
                    new SqlParameter("@maHH", maHH),
                    new SqlParameter("@maHDX", maHDX),
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

        public DataTable SearchChiTietXuat(string maHDX, string keyword)
        {
            try
            {
                string query = "SELECT MAHH as [Mã hàng hóa], SO_HD_XUAT as [Số hóa đơn xuất], SOLUONG_XUAT as [Số lượng xuất], DONGIA_XUAT as [Đơn giá xuất] " +
                               "FROM CHITIET_HD_XUAT " +
                               "WHERE SO_HD_XUAT = @maHDX AND (MAHH LIKE N'%" + keyword + "%' OR SO_HD_XUAT LIKE N'%" + keyword + "%')";
                SqlParameter[] parameters = {
                    new SqlParameter("@maHDN", maHDX)
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
