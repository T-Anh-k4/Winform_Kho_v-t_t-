using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class NHANVIEN_DTO
	{
		private string _MaNV;
		private string _TenNV;
		private string _GioiTinh;
		private string _NgaySinh;
		private string _DiaChi;
		private string _SoDT;
		private string _DienGiai;
		private int _Flag;

		public NHANVIEN_DTO(string maNV, string tenNV, string gioiTinh, string ngaySinh, string diaChi, string soDT, string dienGia, int flag)
		{
			MaNV = maNV;
			TenNV = tenNV;
			GioiTinh = gioiTinh;
			NgaySinh = ngaySinh;
			DiaChi = diaChi;
			SoDT = soDT;
			DienGia = dienGia;
			Flag = flag;
		}

		public NHANVIEN_DTO(DataRow row)
		{
			MaNV = row["MANV"].ToString();
			TenNV = row["TENNV"].ToString();
			GioiTinh = row["GIOITINH"].ToString();
			NgaySinh = row["NGAYSINH"].ToString();
			DiaChi = row["DIACHI"].ToString();
			SoDT = row["SDT"].ToString();
			DienGia = row["DIENGIAI"].ToString();
			Flag = (int)row["FLAG"];
		}

		public string MaNV { get => _MaNV; set => _MaNV = value; }
		public string TenNV { get => _TenNV; set => _TenNV = value; }
		public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
		public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
		public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
		public string SoDT { get => _SoDT; set => _SoDT = value; }
		private string DienGia { get => _DienGiai; set => _DienGiai = value; }
		public int Flag { get => _Flag; set => _Flag = value; }


	}
}
