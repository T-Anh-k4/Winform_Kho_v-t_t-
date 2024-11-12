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
            string query = "SELECT MAHH as [Mã hàng hóa], SOLUONG_NHAP as [Số lượng nhập], DONGIA_NHAP as [Đơn giá nhập] " +
                           "FROM CHITIET_HD_NHAP WHERE SO_HD_NHAP = @maHDN";
            SqlParameter[] parameters = {
                new SqlParameter("@maHDN", maHDN)
            };
            return instance.execQuery(query, parameters);
        }

        public DataTable GetDanhSachChiTietNhapPage(string maHDN, int limit, int page)
        {
            string query = "SELECT ID AS [Mã chi tiết nhập], HANGHOA.MAHH as [Mã hàng hóa], TENHH as [Tên hàng hóa], SOLUONG_NHAP as [Số lượng nhập], CONVERT(DECIMAL(18, 0), DONGIA_NHAP) as [Đơn giá nhập],CONVERT(DECIMAL(18, 0), (SOLUONG_NHAP * DONGIA_NHAP)) as [Thành tiền] " +
                           "FROM CHITIET_HD_NHAP " +
                            "JOIN HANGHOA ON CHITIET_HD_NHAP.MAHH = HANGHOA.MAHH " +
                           "WHERE SO_HD_NHAP = @maHDN "
                           ;
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

        public DataTable getMaVaTenHH()
        {
            string query = "SELECT MAHH as [Mã hàng hóa], TENHH as [Tên hàng hóa]" +
                           "FROM HANGHOA";
            return instance.execQuery(query);
        }

        public int getTotalCost(string maHDN)
        {
            string query = "SELECT SUM(SOLUONG_NHAP * DONGIA_NHAP) " +
                           "FROM CHITIET_HD_NHAP " +
                           "WHERE SO_HD_NHAP = @maHDN";
            SqlParameter[] parameters = {
                new SqlParameter("@maHDN", maHDN)
            };
            object result = instance.execScalar(query, parameters);
            return result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }

        public DataTable getHoaDonNhapDetail(string maHDN)
        {
            string query = "SELECT SO_HD_NHAP as [Số hóa đơn nhập], TENNCC as [Tên nhà cung cấp], TENNV as [Tên nhân viên], NGAYLAP_NHAP as [Ngày lập hóa đơn] " +
                           "FROM HOADON_NHAP " +
                           "JOIN NHACUNGCAP ON HOADON_NHAP.MANCC = NHACUNGCAP.MANCC " +
                           "JOIN NHANVIEN ON HOADON_NHAP.MANV = NHANVIEN.MANV " +
                           "WHERE SO_HD_NHAP = @maHDN";
            SqlParameter[] parameters = {
                new SqlParameter("@maHDN", SqlDbType.NVarChar) { Value = maHDN }
            };
            return instance.execQuery(query, parameters);
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
                // Truy vấn để kiểm tra xem mặt hàng đã có đơn giá trong hệ thống chưa
                string getDonGiaQuery = "SELECT DONGIA_NHAP FROM CHITIET_HD_NHAP WHERE MAHH = @maHH";
                SqlParameter[] getDonGiaParameters = {
            new SqlParameter("@maHH", maHH)
        };
                object existingDonGia = instance.execScalar(getDonGiaQuery, getDonGiaParameters);

                // Nếu mặt hàng đã có đơn giá, kiểm tra xem đơn giá nhập vào có trùng không
                if (existingDonGia != null)
                {
                    if (donGiaNhap != Convert.ToInt32(existingDonGia))
                    {
                        throw new Exception("Đơn giá của mặt hàng phải trùng với đơn giá đã có trong bản ghi.");
                    }
                }

                // Kiểm tra xem mã hàng hóa, số hóa đơn và đơn giá đã tồn tại chưa
                string checkQuery = "SELECT SOLUONG_NHAP FROM CHITIET_HD_NHAP WHERE MAHH = @maHH AND SO_HD_NHAP = @maHDN AND DONGIA_NHAP = @donGiaNhap";
                SqlParameter[] checkParameters = {
            new SqlParameter("@maHH", maHH),
            new SqlParameter("@maHDN", maHDN),
            new SqlParameter("@donGiaNhap", donGiaNhap)
        };
                object result = instance.execScalar(checkQuery, checkParameters);

                if (result != null)
                {
                    // Nếu mã hàng hóa đã tồn tại và có cùng đơn giá, cập nhật số lượng nhập
                    int existingSLNhap = Convert.ToInt32(result);
                    int newSLNhap = existingSLNhap + soLuongNhap;
                    string updateQuery = "UPDATE CHITIET_HD_NHAP SET SOLUONG_NHAP = @newSLNhap WHERE MAHH = @maHH AND SO_HD_NHAP = @maHDN AND DONGIA_NHAP = @donGiaNhap";
                    SqlParameter[] updateParameters = {
                new SqlParameter("@newSLNhap", newSLNhap),
                new SqlParameter("@maHH", maHH),
                new SqlParameter("@maHDN", maHDN),
                new SqlParameter("@donGiaNhap", donGiaNhap)
            };
                    instance.execNonQuery(updateQuery, updateParameters);
                }
                else
                {
                    // Nếu mã hàng chưa tồn tại trong bảng CHITIET_HD_NHAP, tiến hành thêm mới
                    int newID = GetMaxID() + 1;
                    string insertQuery = "INSERT INTO CHITIET_HD_NHAP(ID, MAHH, SO_HD_NHAP, SOLUONG_NHAP, DONGIA_NHAP) " +
                                         "VALUES (@id, @maHH, @maHDN, @soLuongNhap, @donGiaNhap)";
                    SqlParameter[] insertParameters = {
                new SqlParameter("@id", newID),
                new SqlParameter("@maHH", maHH),
                new SqlParameter("@maHDN", maHDN),
                new SqlParameter("@soLuongNhap", soLuongNhap),
                new SqlParameter("@donGiaNhap", donGiaNhap)
            };
                    instance.execNonQuery(insertQuery, insertParameters);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi thêm chi tiết nhập: " + ex.Message);
            }
        }


        public bool UpdateChiTietNhap(int ID, string maHH, string maHDN, int soLuongNhap, int donGiaNhap)
        {
            try
            {
                // Kiểm tra xem bản ghi đã tồn tại chưa
                string checkQuery = "SELECT SOLUONG_NHAP FROM CHITIET_HD_NHAP WHERE MAHH = @maHH AND SO_HD_NHAP = @maHDN AND DONGIA_NHAP = @donGiaNhap";
                SqlParameter[] checkParameters = {
            new SqlParameter("@maHH", maHH),
            new SqlParameter("@maHDN", maHDN),
            new SqlParameter("@donGiaNhap", donGiaNhap)
        };
                object result = instance.execScalar(checkQuery, checkParameters);

                if (result != null)
                {
                    // Nếu bản ghi tồn tại, cập nhật trực tiếp số lượng với giá trị mới
                    string updateQuery = "UPDATE CHITIET_HD_NHAP SET SOLUONG_NHAP = @soLuongNhap WHERE MAHH = @maHH AND SO_HD_NHAP = @maHDN AND DONGIA_NHAP = @donGiaNhap";
                    SqlParameter[] updateParameters = {
                new SqlParameter("@soLuongNhap", soLuongNhap),
                new SqlParameter("@maHH", maHH),
                new SqlParameter("@maHDN", maHDN),
                new SqlParameter("@donGiaNhap", donGiaNhap)
            };
                    instance.execNonQuery(updateQuery, updateParameters);
                    return true;
                }
                else
                {
                    // Nếu bản ghi chưa tồn tại, tạo một bản ghi mới với các thông tin đã cung cấp
                    string query = "UPDATE CHITIET_HD_NHAP " +
                                   "SET MAHH = @maHH, " +
                                   "SO_HD_NHAP = @maHDN, " +
                                   "SOLUONG_NHAP = @soLuongNhap, " +
                                   "DONGIA_NHAP = @donGiaNhap " +
                                   "WHERE id = @id";
                    SqlParameter[] parameters = {
                new SqlParameter("@id", ID),
                new SqlParameter("@maHH", maHH),
                new SqlParameter("@maHDN", maHDN),
                new SqlParameter("@soLuongNhap", soLuongNhap),
                new SqlParameter("@donGiaNhap", donGiaNhap)
            };
                    instance.execNonQuery(query, parameters);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteChiTietNhap(int ID)
        {
            try
            {
                string query = "DELETE FROM CHITIET_HD_NHAP WHERE ID = @id";
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

        public DataTable SearchChiTietNhap(string maHDN, string keyword)
        {
            try
            {
                string query = "SELECT MAHH as [Mã hàng hóa], SO_HD_NHAP as [Số hóa đơn nhập], SOLUONG_NHAP as [Số lượng nhập], DONGIA_NHAP as [Đơn giá nhập] " +
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