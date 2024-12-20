﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
	public class LOAIHANG_DAL : DataProvider
	{
		DataProvider instance = new DataProvider();
        SqlDataAdapter nvAdapter = new SqlDataAdapter();
        public LOAIHANG_DAL()
		{
			instance = new DataProvider();
		}

		public DataTable getDanhSachLoaiHanh()
		{
			string query = "SELECT MALOAI as [Mã loại hàng],TENLOAI as [Tên loại hàng],DIENGIAI as [Diễn giải], CASE WHEN FLAG = 1 THEN 'Còn kinh doanh' ELSE 'Không còn kinh doanh' END as [Trạng thái] FROM LOAIHANG";
			return instance.execQuery(query);
		}
        public DataTable getDanhSachLoaiHangPage(int limit, int page)
        {
            string query = "SELECT MALOAI as [Mã loại hàng],TENLOAI as [Tên loại hàng],DIENGIAI as [Diễn giải], CASE WHEN FLAG = 1 THEN 'Còn kinh doanh' ELSE 'Không còn kinh doanh' END as [Trạng thái] FROM LOAIHANG";

            // Khởi tạo đối tượng kết nối
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
        public int GetSLLoaiHang()
        {
            string query = "SELECT COUNT(*) FROM LOAIHANG";
            object result = instance.execScalar(query);
            int slNhanVien = result != null ? Convert.ToInt32(result) : 0;
            return slNhanVien;
        }
        public bool Deleteloaihang(string malh)
		{
			try
			{
				string queryLoaihang = "DELETE FROM LOAIHANG WHERE MALOAI = N'" + malh + "'";
				instance.execNonQuery(queryLoaihang);
			}
			catch
			{
				return false;
			}
			return true;
		}

		public bool InsertLoaiHang(string malh, string Tenlh, string diengiai, int flag)
		{
			try
			{
				string query = "INSERT INTO LOAIHANG(MALOAI, TENLOAI, DIENGIAI, FLAG) " +
							   "VALUES (N'" + malh + "', N'" + Tenlh + "', N'" + diengiai + "', N'" + flag + "')";
				instance.execNonQuery(query);
			}
			catch
			{
				return false;
			}
			return true;
		}

		public bool UpdateLoaiHang(string malh, string tenlh, string diengiai, int flag)
		{
			try
			{
				string query = "UPDATE LOAIHANG " +
							   "SET MALOAI = N'" + malh + "', " +
							   "TENLOAI =N'" + tenlh + "', " +
							   "DIENGIAI = N'" + diengiai + "', " +
							   "FLAG = N'" + flag + "' " +
							   "WHERE MALOAI = N'" + malh + "'"; // Cần điều kiện WHERE

				instance.execNonQuery(query);
			}
			catch
			{
				return false;
			}
			return true;
		}
		public DataTable SearchLoaiHang(string keyword)
		{
			try
			{
				string query = "SELECT MALOAI as [Mã loại],TENLOAI as [Tên loại hàng],DIENGIAI as [Diễn giải],FLAG as [Trạng thái]" +
							   "FROM LOAIHANG " +
							   "WHERE TENLOAI LIKE N'%" + keyword + "%'";

				return instance.execQuery(query);
			}
			catch
			{
				return null;
			}
		}
		public bool IsMaLoaiHangExist(string malh)
		{
			string query = "SELECT COUNT(*) FROM LOAIHANG WHERE MALOAI = @malh";
			SqlParameter[] parameters = {
		new SqlParameter("@malh", malh)
		};
            int count = Convert.ToInt32(instance.execScalar(query, parameters));
            return count > 0;
        }
    }
}
