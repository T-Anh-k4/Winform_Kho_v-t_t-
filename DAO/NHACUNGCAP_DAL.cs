using System;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace DAO
{
    public class NHACUNGCAP_DAL : DataProvider
    {
        DataProvider instance = new DataProvider();
        SqlDataAdapter nccAdapter = new SqlDataAdapter();

        public NHACUNGCAP_DAL()
        {
            instance = new DataProvider();
        }

        public DataTable getDanhSachNhaCungCap()
        {
            string query = "SELECT MANCC AS [Mã nhà cung cấp], TENNCC AS [Tên nhà cung cấp], DIACHI AS [Địa chỉ], SDT AS [Số điện thoại] FROM NHACUNGCAP";
            return instance.execQuery(query);
        }

        public DataTable getDanhSachNhaCungCapPage(int limit, int page)
        {
            string query = "SELECT MANCC AS [Mã nhà cung cấp], TENNCC AS [Tên nhà cung cấp], DIACHI AS [Địa chỉ], SDT AS [Số điện thoại] FROM NHACUNGCAP";

            using (SqlConnection con = new SqlConnection(LinkData))
            {
                con.Open();

                nccAdapter.SelectCommand = new SqlCommand(query, con);

                DataTable dsNcc = new DataTable();
                nccAdapter.Fill((page - 1) * limit, limit, dsNcc);

                con.Close();
                return dsNcc;
            }
        }

        public int GetSLNhaCungCap()
        {
            string query = "SELECT COUNT(*) FROM NHACUNGCAP";
            object result = instance.execScalar(query);
            int slNhaCungCap = result != null ? Convert.ToInt32(result) : 0;
            return slNhaCungCap;
        }

        public DataTable GetNhaCungCap(string maNCC)
        {
            string query = "SELECT MANCC AS [Mã nhà cung cấp], TENNCC AS [Tên nhà cung cấp], DIACHI AS [Địa chỉ], SDT AS [Số điện thoại] FROM NHACUNGCAP " +
                           "WHERE MANCC = N'" + maNCC + "'";
            return instance.execQuery(query);
        }

        public bool DeleteNhaCungCap(string maNCC)
        {
            try
            {
                string query = "DELETE FROM NHACUNGCAP WHERE MANCC = N'" + maNCC + "'";
                instance.execNonQuery(query);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool InsertNhaCungCap(string maNCC, string tenNCC, string diaChi, string soDT)
        {
            try
            {
                string query = "INSERT INTO NHACUNGCAP(MANCC, TENNCC, DIACHI, SDT) " +
                               "VALUES (N'" + maNCC + "', N'" + tenNCC + "', N'" + diaChi + "', N'" + soDT + "')";
                instance.execNonQuery(query);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateNhaCungCap(string maNCC, string tenNCC, string diaChi, string soDT)
        {
            try
            {
                string query = "UPDATE NHACUNGCAP " +
                               "SET TENNCC = N'" + tenNCC + "', " +
                               "DIACHI = N'" + diaChi + "', " +
                               "SDT = N'" + soDT + "' " +
                               "WHERE MANCC = N'" + maNCC + "'";

                instance.execNonQuery(query);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}