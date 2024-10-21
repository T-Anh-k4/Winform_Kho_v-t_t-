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

        public bool InsertNhanVien(string maNV, string tenNV, string gioiTinh, string ngaySinh, string diaChi, string soDT, string dienGia, int flag, string username)
        {
            return nhanVienDAO.InsertNhanVien(maNV, tenNV, gioiTinh, ngaySinh, diaChi, soDT, dienGia, flag,username);
		}
        public bool UpdateNhanVien(string maNV, string tenNV, string gioiTinh, string ngaySinh, string diaChi, string soDT, string dienGia, int flag, string username)
        {
            return nhanVienDAO.UpdateNhanVien(maNV, tenNV, gioiTinh, ngaySinh, diaChi, soDT, dienGia, flag, username);

		}
		public bool DeleteNhanVien(string maNV)
		{
			return nhanVienDAO.DeleteNhanVien(maNV);

		}
		public DataTable SearchNV(string key)
		{
			return nhanVienDAO.SearchNhanVien(key);
		}
        public bool CheckUserName(string username)
		{
			return nhanVienDAO.CheckUserName(username);
		}
    }
}
