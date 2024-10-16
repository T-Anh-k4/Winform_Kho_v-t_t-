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
		NHANVIEN_DAL nhanVienDAO = new NHANVIEN_DAL();
		DataProvider dataProvider = new DataProvider();

		public DataTable GetDanhSachNhanVien()
		{
			return nhanVienDAO.getDanhSachNhanVien();
		}
		public DataTable GetDanhSachNhanVienPage(int limit, int page)
		{
			return nhanVienDAO.getDanhSachNhanVienPage(limit, page);
		}
		public int GetSLSinhVien()
		{
			return nhanVienDAO.GetSLSinhVien();
		}


		public DataTable GetNhanVien(string manv)
		{
			return nhanVienDAO.GetNhanVien(manv);
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
