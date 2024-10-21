using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
	public class NHANVIEN_BUS
	{
		NHANVIEN_DAL nhanVienDAL = new NHANVIEN_DAL();
		DataProvider dataProvider = new DataProvider();

		public DataTable GetDanhSachNhanVien()
		{
			return nhanVienDAL.getDanhSachNhanVien();
		}
		public DataTable GetDanhSachNhanVienPage(int limit, int page)
		{
			return nhanVienDAL.getDanhSachNhanVienPage(limit, page);
		}
		public int GetSLSinhVien()
		{
			return nhanVienDAL.GetSLSinhVien();
		}


		public DataTable GetNhanVien(string manv)
		{
			return nhanVienDAL.GetNhanVien(manv);
		}

		public DataTable GetGioiTinh()
		{
			return nhanVienDAL.GetGioiTinh();
		}

		public bool InsertNhanVien(string manv, string tennv, string gioitinh, string ngaysinh, string diachi, string sdt, string diengiai, int flag)
		{
			return nhanVienDAL.InsertNhanVien(manv, tennv, gioitinh, ngaysinh, diachi, sdt, diengiai, flag);
		}
		public bool UpdateNhanVien(string maNV, string tenNV, string gioiTinh, string ngaySinh, string diaChi, string soDT, string dienGia, int flag)
		{
			return nhanVienDAL.UpdateNhanVien(maNV, tenNV, gioiTinh, ngaySinh, diaChi, soDT, dienGia, flag);

		}
		public bool DeleteNhanVien(string maNV)
		{
			return nhanVienDAL.DeleteNhanVien(maNV);

		}
		public DataTable SearchNV(string key)
		{
			return nhanVienDAL.SearchNhanVien(key);
		}
	}
}
