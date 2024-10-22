using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class NHACUNGCAP_DAL : DataProvider
    {
        DataProvider instance = new DataProvider();
        SqlDataAdapter nvAdapter = new SqlDataAdapter();

        public NHACUNGCAP_DAL()
        {
            instance = new DataProvider();
        }

        public DataTable GetDanhSachNhaCungCap()
        {
            string query = "SELECT MANCC as [Mã nhà cung cấp], TENNCC as [Tên nhà cung cấp], DIACHI as [Địa chỉ], SDT as [Số điện thoại] FROM NHACUNGCAP";
            return instance.execQuery(query);
        }

        public DataTable GetDanhSachNhaCungCapPage(int limit, int page)
        {
            string query = "SELECT MANCC as [Mã nhà cung cấp], TENNCC as [Tên nhà cung cấp], DIACHI as [Địa chỉ], SDT as [Số điện thoại] FROM NHACUNGCAP";
            //return instance.execQuery(query);
            using (SqlConnection con = new SqlConnection(LinkData))
            {
                con.Open(); // Mở kết nối

                // Khởi tạo SqlDataAdapter với SqlCommand và SqlConnection
                nvAdapter.SelectCommand = new SqlCommand(query, con);
                DataTable dsNv = new DataTable();
                nvAdapter.Fill((page - 1) * limit, limit, dsNv);

                con.Close(); // Đóng kết nối
                return dsNv;
            }
        }

        public int GetSLNhaCungCap()
        {
            string query = "SELECT COUNT(*) FROM NHACUNGCAP";
            object result = instance.execScalar(query);
            int slNhanVien = result != null ? Convert.ToInt32(result) : 0;
            return slNhanVien;
        }


        public bool InsertNhaCungCap(string maNCC, string tenNCC, string diaChi, string sdt)
        {
            try
            {
                string query = "INSERT INTO NHACUNGCAP(MANCC, TENNCC, DIACHI, SDT) " +
                               "VALUES (N'" + maNCC + "', N'" + tenNCC + "', N'" + diaChi + "', N'" + sdt + "')";
                instance.execNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi thêm nhà cung cấp: " + ex.Message);
            }
        }

        public bool UpdateNhaCungCap(string maNCC, string tenNCC, string diaChi, string sdt)
        {
            try
            {
                string query = "UPDATE NHACUNGCAP " +
                               "SET TENNCC = N'" + tenNCC + "', " +
                               "DIACHI = N'" + diaChi + "', " +
                               "SDT = N'" + sdt + "' " +
                               "WHERE MANCC = N'" + maNCC + "'";
                instance.execNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteNhaCungCap(string maNCC)
        {
            try
            {
                string query = "DELETE FROM NHACUNGCAP WHERE MANCC = N'" + maNCC + "'";
                instance.execNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable SearchNhaCungCap(string keyword)
        {
            try
            {
                string query = "SELECT MANCC as [Mã nhà cung cấp], TENNCC as [Tên nhà cung cấp], DIACHI as [Địa chỉ], SDT as [Số điện thoại] " +
                               "FROM NHACUNGCAP " +
                               "WHERE TENNCC LIKE N'%" + keyword + "%'";
                return instance.execQuery(query);
            }
            catch
            {
                return null;
            }
        }
    }
}