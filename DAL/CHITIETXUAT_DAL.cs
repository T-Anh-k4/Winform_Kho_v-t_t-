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
            string query = "SELECT KHO.MAHH as [Mã hàng hóa], CHITIET_HD_XUAT.SOLUONG_XUAT as [Số lượng xuất], CHITIET_HD_XUAT.DONGIA_XUAT as [Đơn giá xuất] " +
                           "FROM CHITIET_HD_XUAT " +
                           "JOIN KHO ON CHITIET_HD_XUAT.IDKHO = KHO.IDKHO " +
                           "WHERE CHITIET_HD_XUAT.SO_HD_XUAT = @maHDX";
            SqlParameter[] parameters = {
                new SqlParameter("@maHDX", maHDX)
            };
            return instance.execQuery(query, parameters);
        }

        public DataTable GetDanhSachChiTietXuatPage(string maHDX, int limit, int page)
        {
            string query = "SELECT IDXUAT AS [Mã chi tiết xuất], KHO.MAHH as [Mã hàng hóa], TENHH as [Tên hàng hóa], SOLUONG_XUAT as [Số lượng xuất]," +
                           "CONVERT(DECIMAL(18, 0), CHITIET_HD_XUAT.DONGIA_XUAT) as [Đơn giá xuất] , CONVERT(DECIMAL(18, 0), (SOLUONG_XUAT * DONGIA_XUAT)) as [Thành tiền] " +
                           "FROM CHITIET_HD_XUAT " +
                           "JOIN KHO ON CHITIET_HD_XUAT.IDKHO = KHO.IDKHO " +
                           "JOIN HANGHOA ON KHO.MAHH = HANGHOA.MAHH " +
                           "WHERE SO_HD_XUAT = @maHDX";
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
            string query = "SELECT KHO.MAHH as [Mã hàng hóa], TENHH as [Tên hàng hóa] FROM KHO JOIN HANGHOA ON KHO.MAHH = HANGHOA.MAHH";
            return instance.execQuery(query);
        }

        public int getTotalCost(string maHDX)
        {
            string query = "SELECT SUM(SOLUONG_XUAT * DONGIA_XUAT) FROM CHITIET_HD_XUAT WHERE SO_HD_XUAT = @maHDX";
            SqlParameter[] parameters = {
                new SqlParameter("@maHDX", maHDX)
            };
            object result = instance.execScalar(query, parameters);
            return result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }

        public DataTable getHoaDonXuatDetail(string maHDX)
        {
            string query = "SELECT SO_HD_XUAT as [Số hóa đơn xuất], TENKH as [Tên khách hàng], TENNV as [Tên nhân viên], NGAYLAP_XUAT as [Ngày lập hóa đơn] " +
                           "FROM HOADON_XUAT " +
                           "JOIN KHACHHANG ON HOADON_XUAT.MAKH = KHACHHANG.MAKH " +
                           "JOIN NHANVIEN ON HOADON_XUAT.MANV = NHANVIEN.MANV " +
                           "WHERE SO_HD_XUAT = @maHDX";
            SqlParameter[] parameters = {
                new SqlParameter("@maHDX", SqlDbType.NVarChar) { Value = maHDX }
            };
            return instance.execQuery(query, parameters);
        }

        public int GetMaxID()
        {
            string query = "SELECT ISNULL(MAX(IDXUAT), 0) FROM CHITIET_HD_XUAT";
            object result = instance.execScalar(query);
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public bool InsertChiTietXuat(string maHH, string maHDX, int soLuongXuat, int donGiaXuat)
        {
            try
            {
                // Retrieve the idKho based on the provided maHH
                string getIdKhoQuery = "SELECT IDKHO FROM KHO WHERE MAHH = @maHH";
                SqlParameter[] getIdKhoParameters = {
                    new SqlParameter("@maHH", maHH)
                };
                object idKhoResult = instance.execScalar(getIdKhoQuery, getIdKhoParameters);

                if (idKhoResult == null)
                {
                    throw new Exception("Không tìm thấy IDKHO cho mã hàng hóa: " + maHH);
                }

                int idKho = Convert.ToInt32(idKhoResult);

                // Check if the record already exists
                string checkQuery = "SELECT SOLUONG_XUAT FROM CHITIET_HD_XUAT WHERE IDKHO = @idKho AND SO_HD_XUAT = @maHDX AND DONGIA_XUAT = @donGiaXuat";
                SqlParameter[] checkParameters = {
                    new SqlParameter("@idKho", idKho),
                    new SqlParameter("@maHDX", maHDX),
                    new SqlParameter("@donGiaXuat", donGiaXuat)
                };
                object result = instance.execScalar(checkQuery, checkParameters);

                if (result != null)
                {
                    int existingSLXuat = Convert.ToInt32(result);
                    int newSLXuat = existingSLXuat + soLuongXuat;
                    string updateQuery = "UPDATE CHITIET_HD_XUAT SET SOLUONG_XUAT = @newSLXuat WHERE IDKHO = @idKho AND SO_HD_XUAT = @maHDX AND DONGIA_XUAT = @donGiaXuat";
                    SqlParameter[] updateParameters = {
                        new SqlParameter("@newSLXuat", newSLXuat),
                        new SqlParameter("@idKho", idKho),
                        new SqlParameter("@maHDX", maHDX),
                        new SqlParameter("@donGiaXuat", donGiaXuat)
                    };
                    instance.execNonQuery(updateQuery, updateParameters);
                }
                else
                {
                    int newID = GetMaxID() + 1;
                    string insertQuery = "INSERT INTO CHITIET_HD_XUAT(IDXUAT, IDKHO, SO_HD_XUAT, SOLUONG_XUAT, DONGIA_XUAT) " +
                                         "VALUES (@id, @idKho, @maHDX, @soLuongXuat, @donGiaXuat)";
                    SqlParameter[] insertParameters = {
                        new SqlParameter("@id", newID),
                        new SqlParameter("@idKho", idKho),
                        new SqlParameter("@maHDX", maHDX),
                        new SqlParameter("@soLuongXuat", soLuongXuat),
                        new SqlParameter("@donGiaXuat", donGiaXuat)
                    };
                    instance.execNonQuery(insertQuery, insertParameters);
                }
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL error occurred while inserting chi tiết xuất: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while inserting chi tiết xuất: " + ex.Message);
            }
        }

        public bool UpdateChiTietXuat(int ID, string maHH, string maHDX, int soLuongXuat, int donGiaXuat)
        {
            try
            {
                // Retrieve the idKho based on the provided maHH
                string getIdKhoQuery = "SELECT IDKHO FROM KHO WHERE MAHH = @maHH";
                SqlParameter[] getIdKhoParameters = {
                    new SqlParameter("@maHH", maHH)
                };
                object idKhoResult = instance.execScalar(getIdKhoQuery, getIdKhoParameters);

                if (idKhoResult == null)
                {
                    throw new Exception("Không tìm thấy IDKHO cho mã hàng hóa: " + maHH);
                }

                int idKho = Convert.ToInt32(idKhoResult);

                // Check if the record already exists
                string checkQuery = "SELECT SOLUONG_XUAT FROM CHITIET_HD_XUAT WHERE IDKHO = @idKho AND SO_HD_XUAT = @maHDX AND DONGIA_XUAT = @donGiaXuat";
                SqlParameter[] checkParameters = {
                    new SqlParameter("@idKho", idKho),
                    new SqlParameter("@maHDX", maHDX),
                    new SqlParameter("@donGiaXuat", donGiaXuat)
                };
                object result = instance.execScalar(checkQuery, checkParameters);
                // Console.WriteLine("Result: ");
                // Console.WriteLine(result.ToString());

                if (result != null)
                {
                    int existingSLXuat = Convert.ToInt32(result);
                    int newSLXuat = existingSLXuat + soLuongXuat;
                    string updateQuery = "UPDATE CHITIET_HD_XUAT SET SOLUONG_XUAT = @newSLXuat WHERE IDKHO = @idKho AND SO_HD_XUAT = @maHDX AND DONGIA_XUAT = @donGiaXuat";
                    SqlParameter[] updateParameters = {
                        new SqlParameter("@newSLXuat", newSLXuat),
                        new SqlParameter("@idKho", idKho),
                        new SqlParameter("@maHDX", maHDX),
                        new SqlParameter("@donGiaXuat", donGiaXuat)
                    };
                    DeleteChiTietXuat(ID);
                    instance.execNonQuery(updateQuery, updateParameters);
                    return true;
                }
                else
                {
                    string query = "UPDATE CHITIET_HD_XUAT " +
                                   "SET IDKHO = @idKho, " +
                                   "SO_HD_XUAT = @maHDX, " +
                                   "SOLUONG_XUAT = @soLuongXuat, " +
                                   "DONGIA_XUAT = @donGiaXuat " +
                                   "WHERE IDXUAT = @id";
                    SqlParameter[] parameters = {
                        new SqlParameter("@id", ID),
                        new SqlParameter("@idKho", idKho),
                        new SqlParameter("@maHDX", maHDX),
                        new SqlParameter("@soLuongXuat", soLuongXuat),
                        new SqlParameter("@donGiaXuat", donGiaXuat)
                    };
                    instance.execNonQuery(query, parameters);
                    return true;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL error occurred while updating chi tiết xuất: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating chi tiết xuất: " + ex.Message);
            }
        }

        public bool DeleteChiTietXuat(int ID)
        {
            try
            {
                string query = "DELETE FROM CHITIET_HD_XUAT WHERE IDXUAT = @id";
                SqlParameter[] parameters = {
                    new SqlParameter("@id", ID)
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
