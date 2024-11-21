using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CHITIETNGUOIDUNG_DAL
    {
        DataProvider instance = new DataProvider();
        public CHITIETNGUOIDUNG_DTO GetUserDetails(string username)
        {
            CHITIETNGUOIDUNG_DTO user = null;
            string query = @"SELECT NGUOIDUNG.USERNAME,NGUOIDUNG.LOAI, NHANVIEN.TENNV, NHANVIEN.DIACHI, NHANVIEN.SDT, NHANVIEN.DIENGIAI 
                             FROM NGUOIDUNG 
                             JOIN NHANVIEN ON NGUOIDUNG.USERNAME = NHANVIEN.USERNAME
                             WHERE NGUOIDUNG.USERNAME = @username";

            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLVATLIEUXD;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add(new SqlParameter("@username", username));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new CHITIETNGUOIDUNG_DTO
                            {
                                UserName = reader["USERNAME"].ToString(),
                                TenNV = reader["TENNV"].ToString(),
                                DiaChi = reader["DIACHI"].ToString(),
                                SoDT = reader["SDT"].ToString(),
                                Loai = reader["LOAI"].ToString(),
                                DienGia = reader["DIENGIAI"].ToString()
                            };
                        }
                    }
                }
            }
            return user;
        }
    }
}
