﻿using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
	public class NHANVIEN_BUS
	{
		NHANVIEN_DAO nhanVienDAO = new NHANVIEN_DAO();

		public DataTable GetDanhSachNhanVien()
		{
			return nhanVienDAO.getDanhSachNhanVien();
		}

		public DataTable GetGioiTinh()
		{
			return nhanVienDAO.GetGioiTinh();
		}

		public bool InsertNhanVien(string manv, string tennv, string gioitinh, string ngaysinh, string diachi, string sdt, string diengiai, int flag)
		{
			return nhanVienDAO.InsertNhanVien(manv, tennv, gioitinh, ngaysinh, diachi, sdt, diengiai, flag);
		}
		public bool UpdateNhanVien(string maNV, string tenNV, string gioiTinh, string ngaySinh, string diaChi, string soDT, string dienGia, int flag)
		{
			return nhanVienDAO.UpdateNhanVien(maNV, tenNV, gioiTinh, ngaySinh, diaChi, soDT, dienGia, flag);

		}
		public bool DeleteNhanVien(string maNV)
		{
			return nhanVienDAO.DeleteNhanVien(maNV);

		}
	}
}
