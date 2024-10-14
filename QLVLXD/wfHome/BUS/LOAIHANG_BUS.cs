using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
	public class LOAIHANG_BUS
	{
		LOAIHANG_DAL Loaihang_dal = new LOAIHANG_DAL();

		public DataTable GetDanhSachLoaiHang()
		{
			return Loaihang_dal.getDanhSachLoaiHanh();
		}

		public bool InsertLoaiHang(string malh, string Tenlh, string diengiai, int flag)
		{
			return Loaihang_dal.InsertLoaiHang(malh,Tenlh,diengiai,flag);
		}
		public bool UpdateLoaiHanh(string malh, string Tenlh, string diengiai, int flag)
		{
			return Loaihang_dal.UpdateLoaiHang(malh,Tenlh,diengiai, flag);

		}
		public bool DeleteLoaiHang(string malh)
		{
			return Loaihang_dal.Deleteloaihang(malh);

		}
		public DataTable SearchLoaiHang(string keyword)
		{
			return Loaihang_dal.SearchLoaiHang(keyword);
		}
	}
}
