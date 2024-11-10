using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KHACHHANG_DAL : DataProvider
    {
        DataProvider instance = new DataProvider();
        SqlDataAdapter khAdapter = new SqlDataAdapter();

        public KHACHHANG_DAL()
        {
            instance = new DataProvider();
        }

        public DataTable getDanhSachKhachHang()
        {
            string query = "SELECT MAKH AS [Mã khách hàng], TENKH AS [Tên khách hàng], DIACHI AS [Địa chỉ], SDT AS [Số điện thoại] FROM KHACHHANG";
            return instance.execQuery(query);
        }

        public DataTable getDanhSachKhachHangPage(int limit, int page)
        {
            string query = "SELECT MAKH AS [Mã khách hàng], TENKH AS [Tên khách hàng], DIACHI AS [Địa chỉ], SDT AS [Số điện thoại] FROM KHACHHANG";

            using (SqlConnection con = new SqlConnection(LinkData))
            {
                con.Open();
                khAdapter.SelectCommand = new SqlCommand(query, con);

                DataTable dsKh = new DataTable();
                khAdapter.Fill((page - 1) * limit, limit, dsKh);

                con.Close();
                return dsKh;
            }
        }

        public int GetSoLuongKhachHang()
        {
            string query = "SELECT COUNT(*) FROM KHACHHANG";
            object result = instance.execScalar(query);
            int slKhachHang = result != null ? Convert.ToInt32(result) : 0;
            return slKhachHang;
        }

        //public DataTable GetKhachHang(string maKH)
        //{
        //    string query = "SELECT MAKH AS [Mã khách hàng], TENKH AS [Tên khách hàng], DIACHI AS [Địa chỉ], SDT AS [Số điện thoại], FLAG AS [Trạng thái] FROM KHACHHANG WHERE MAKH = N'" + maKH + "'";
        //    return instance.execQuery(query);
        //}

        public bool DeleteKhachHang(string maKH)
        {
            try
            {
                string deleteQuery = "DELETE FROM KHACHHANG WHERE MAKH = N'" + maKH + "'";
                instance.execNonQuery(deleteQuery);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool InsertKhachHang(string maKH, string tenKH, string diaChi, string soDT)
        {
            try
            {
                string query = "INSERT INTO KHACHHANG(MAKH, TENKH, DIACHI, SDT) " +
                 "VALUES (N'" + maKH + "', N'" + tenKH + "', N'" + diaChi + "', N'" + soDT + "')";
                instance.execNonQuery(query);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateKhachHang(string maKH, string tenKH, string diaChi, string soDT)
        {
            try
            {
                string query = "UPDATE KHACHHANG " +
                "SET TENKH = N'" + tenKH + "', " +
                "DIACHI = N'" + diaChi + "', " +
                "SDT = N'" + soDT + "' " +  
                "WHERE MAKH = N'" + maKH + "'";


                instance.execNonQuery(query);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public DataTable SearchKhachHang(string keyword)
        {
            try
            {
                string query = "SELECT MAKH AS [Mã khách hàng], TENKH AS [Tên khách hàng], DIACHI AS [Địa chỉ], SDT AS [Số điện thoại]" +
                               "FROM KHACHHANG " +
                               "WHERE TENKH LIKE N'%" + keyword + "%'";

                return instance.execQuery(query);
            }
            catch
            {
                return null;
            }
        }
    }
}
