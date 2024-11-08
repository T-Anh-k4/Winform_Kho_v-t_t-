using System;
using System.Data;
using DAL;

namespace BUS
{
    public class CHITIETNHAP_BUS
    {
        private CHITIETNHAP_DAL chiTietNhapDAL;

        public CHITIETNHAP_BUS()
        {
            chiTietNhapDAL = new CHITIETNHAP_DAL();
        }

        public DataTable GetDanhSachChiTietNhap(string maHDN)
        {
            return chiTietNhapDAL.GetDanhSachChiTietNhap(maHDN);
        }

        public DataTable GetDanhSachChiTietNhapPage(string maHDN, int limit, int page)
        {
            return chiTietNhapDAL.GetDanhSachChiTietNhapPage(maHDN, limit, page);
        }

        public int GetSLChiTietNhap(string maHDN)
        {
            return chiTietNhapDAL.GetSLChiTietNhap(maHDN);
        }
        
		public DataTable getMaVaTenHH()
		{
			return chiTietNhapDAL.getMaVaTenHH();
		}

        public bool InsertChiTietNhap(string maHH, string maHDN, int soLuongNhap, int donGiaNhap)
        {
            return chiTietNhapDAL.InsertChiTietNhap(maHH, maHDN, soLuongNhap, donGiaNhap);
        }

        public bool UpdateChiTietNhap(string maHH, string maHDN, int soLuongNhap, int donGiaNhap)
        {
            return chiTietNhapDAL.UpdateChiTietNhap(maHH, maHDN, soLuongNhap, donGiaNhap);
        }

        public bool DeleteChiTietNhap(string maHH, string maHDN, int donGiaNhap)
        {
            return chiTietNhapDAL.DeleteChiTietNhap(maHH, maHDN, donGiaNhap);
        }

        public DataTable SearchChiTietNhap(string maHDN, string keyword)
        {
            return chiTietNhapDAL.SearchChiTietNhap(maHDN, keyword);
        }
    }
}