using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class HANGHOA_BUS
    {
		
		HANGHOA_DAL hanghoaDAL = new HANGHOA_DAL();

		public DataTable GetDanhSachHangHoa()
		{
			return hanghoaDAL.getDanhSachHangHoa();
		}
		public DataTable GetDonViTinh()
		{
			return hanghoaDAL.GetDonViTinh();
		}

		public bool InsertHangHoa(string mahh, string malh, string tenHang, string dvt, string xuatXu)
		{
			return hanghoaDAL.InsertHangHoa(mahh,malh, tenHang, dvt,xuatXu);
		}
		public bool UpdateHanhHoa(string mahh, string malh, string tenHang, string dvt, string xuatXu)
		{
			return hanghoaDAL.UpdateHanhHoa(mahh,malh,tenHang,dvt,xuatXu);

		}
		public bool DeleteHangHoa(string maHH)
		{
			return hanghoaDAL.DeleteHangHoa(maHH);

		}
	}
}
