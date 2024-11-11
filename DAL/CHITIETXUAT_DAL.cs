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
            string query = "SELECT KHO.MAHH as [Mã hàng hóa], CHITIET_HD_XUAT.SOLUONG_XUAT as [Số lượng xuất], " +
               "CHITIET_HD_XUAT.DONGIA_XUAT as [Đơn giá xuất] " +
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
            string query = "SELECT KHO.MAHH as [Mã hàng hóa], CHITIET_HD_XUAT.SOLUONG_XUAT as [Số lượng xuất], " +
                        "CHITIET_HD_XUAT.DONGIA_XUAT as [Đơn giá xuất] " +
                        "FROM CHITIET_HD_XUAT " +
                        "JOIN KHO ON CHITIET_HD_XUAT.IDKHO = KHO.IDKHO " +
                        "WHERE CHITIET_HD_XUAT.SO_HD_XUAT = @maHDX";

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
            string query = "SELECT MAHH as [Mã hàng hóa] FROM KHO";
            return instance.execQuery(query); 
        }



        public DataTable getHoaDonXUatDetail(string maHDX)
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

        public bool InsertChiTietXuat(string maHH, string maHDX, int soLuongXuat, decimal donGiaXuat)
        {
            try
            {
                // Kiểm tra xem mã hàng hóa và hóa đơn xuất đã tồn tại trong bảng CHITIET_HD_XUAT chưa
                string checkQuery = "SELECT SOLUONG_XUAT FROM CHITIET_HD_XUAT cthdx " +
                                    "JOIN KHO k ON cthdx.IDKHO = k.IDKHO " +
                                    "WHERE k.MAHH = @maHH AND cthdx.SO_HD_XUAT = @maHDX AND cthdx.DONGIA_XUAT = @donGiaXuat";
                SqlParameter[] checkParameters = {
            new SqlParameter("@maHH", maHH),
            new SqlParameter("@maHDX", maHDX),
            new SqlParameter("@donGiaXuat", donGiaXuat)
        };
                object result = instance.execScalar(checkQuery, checkParameters);

                if (result != null)
                {
                    // Nếu có dữ liệu, cập nhật số lượng xuất
                    int existingSLXuat = Convert.ToInt32(result);
                    int newSLXuat = existingSLXuat + soLuongXuat;

                    string updateQuery = "UPDATE CHITIET_HD_XUAT SET SOLUONG_XUAT = @newSLXuat " +
                                         "WHERE IDKHO = (SELECT IDKHO FROM KHO WHERE MAHH = @maHH) AND SO_HD_XUAT = @maHDX AND DONGIA_XUAT = @donGiaXuat";
                    SqlParameter[] updateParameters = {
                new SqlParameter("@newSLXuat", newSLXuat),
                new SqlParameter("@maHH", maHH),
                new SqlParameter("@maHDX", maHDX),
                new SqlParameter("@donGiaXuat", donGiaXuat)
            };
                    instance.execNonQuery(updateQuery, updateParameters);
                }
                else
                {
                    // Nếu chưa có, thực hiện thêm mới vào bảng CHITIET_HD_XUAT
                    int newID = GetMaxID() + 1;

                    // Lấy ID kho tương ứng với mã hàng hóa từ bảng KHO
                    string idKhoQuery = "SELECT IDKHO FROM KHO WHERE MAHH = @maHH"; // Sửa lại
                    SqlParameter[] idKhoParameters = {
                new SqlParameter("@maHH", maHH)
            };
                    object idKhoResult = instance.execScalar(idKhoQuery, idKhoParameters);

                    if (idKhoResult == null)
                    {
                        // Thông báo lỗi nếu không tìm thấy mã hàng hóa trong bảng KHO
                        throw new Exception("Không tìm thấy kho cho mã hàng hóa: " + maHH);
                    }

                    int idKho = Convert.ToInt32(idKhoResult);

                    // Câu lệnh INSERT chi tiết xuất
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
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
                return false; // Trả về false khi có lỗi
            }
        }





        public bool UpdateChiTietXuat(string maHH, string maHDX, int soLuongXuat, decimal donGiaXuat)
        {
            try
            {
                // Kiểm tra nếu mã hàng hóa rỗng hoặc null
                if (string.IsNullOrEmpty(maHH))
                {
                    throw new Exception("Mã hàng hóa không được để trống.");
                }

                // Lấy IDKHO tương ứng với MAHH từ bảng KHO
                string idKhoQuery = "SELECT IDKHO FROM KHO WHERE MAHH = @maHH";
                SqlParameter[] idKhoParameters = {
            new SqlParameter("@maHH", maHH)
        };
                object idKhoResult = instance.execScalar(idKhoQuery, idKhoParameters);

                if (idKhoResult == null)
                {
                    throw new Exception("Không tìm thấy kho cho mã hàng hóa: " + maHH);
                }

                int idKho = Convert.ToInt32(idKhoResult);

                // Cập nhật số lượng xuất và giá xuất
                string query = "UPDATE CHITIET_HD_XUAT " +
                               "SET IDKHO = @idKho, " +
                               "SOLUONG_XUAT = @soLuongXuat, " +
                               "DONGIA_XUAT = @donGiaXuat " +
                               "WHERE IDKHO = @idKho AND SO_HD_XUAT = @maHDX";

                SqlParameter[] parameters = {
            new SqlParameter("@idKho", idKho),
            new SqlParameter("@maHDX", maHDX),
            new SqlParameter("@soLuongXuat", soLuongXuat),
            new SqlParameter("@donGiaXuat", donGiaXuat)
        };

                // Thực thi câu lệnh SQL
                int rowsAffected = instance.execNonQuery(query, parameters);
                return rowsAffected > 0;  // Nếu có bản ghi bị ảnh hưởng, trả về true
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi cập nhật chi tiết xuất: " + ex.Message);
            }
        }





        public bool DeleteChiTietXuat(string maHH, string maHDX, decimal donGiaXuat)
        {
            try
            {
                // Lấy ID kho từ bảng KHO dựa trên mã hàng hóa
                string idKhoQuery = "SELECT IDKHO FROM KHO WHERE MAHH = @maHH";
                SqlParameter[] idKhoParameters = {
            new SqlParameter("@maHH", maHH)
        };

                // Thực thi câu truy vấn để lấy ID kho
                object idKhoResult = instance.execScalar(idKhoQuery, idKhoParameters);

                if (idKhoResult == null)
                {
                    throw new Exception("Không tìm thấy kho cho mã hàng hóa: " + maHH);
                }

                int idKho = Convert.ToInt32(idKhoResult);

                // Xóa chi tiết xuất dựa trên IDKHO thay vì MAHH
                string query = "DELETE FROM CHITIET_HD_XUAT WHERE IDKHO = @idKho AND SO_HD_XUAT = @maHDX AND DONGIA_XUAT = @donGiaXuat";

                SqlParameter[] parameters = {
            new SqlParameter("@idKho", idKho),
            new SqlParameter("@maHDX", maHDX),
            new SqlParameter("@donGiaXuat", donGiaXuat)
        };

                // Thực thi câu lệnh SQL
                instance.execNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                throw new Exception("Có lỗi xảy ra khi xóa chi tiết xuất: " + ex.Message);
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
