using System;
using System.Data;
using DAL;
using DAL;

namespace BUS
{
    public class CHITIETXUAT_BUS
    {
        private CHITIETXUAT_DAL chiTietXuatDAL = new CHITIETXUAT_DAL();

        public CHITIETXUAT_BUS()
        {
            chiTietXuatDAL = new CHITIETXUAT_DAL();
        }

        public DataTable GetDanhSachChiTietXuat(string maHDX)
        {
            return chiTietXuatDAL.GetDanhSachChiTietXuat(maHDX);
        }

        public DataTable GetDanhSachChiTietXuatPage(string maHDX, int limit, int page)
        {
            return chiTietXuatDAL.GetDanhSachChiTietXuatPage(maHDX, limit, page);
        }

        public int GetSLChiTietXuat(string maHDX)
        {
            return chiTietXuatDAL.GetSLChiTietXuat(maHDX);
        }

        public DataTable getMaVaTenHH()
        {
            return chiTietXuatDAL.getMaVaTenHH();
        }

        public DataTable getHoaDonXuatpDetail(string maHDX)
        {
            return chiTietXuatDAL.getHoaDonXUatDetail(maHDX);
        }

        public bool InsertChiTietXuat(string maHH, string maHDX, int soLuongXuat, decimal donGiaXuat)
        {
            return chiTietXuatDAL.InsertChiTietXuat(maHH, maHDX, soLuongXuat, donGiaXuat);
        }

        public bool UpdateChiTietXuat(string maHH, string maHDX, int soLuongNhap, decimal donGiaNhap)
        {
            return chiTietXuatDAL.UpdateChiTietXuat(maHH, maHDX, soLuongNhap, donGiaNhap);
        }

        public bool DeleteChiTietXuat(string maHH, string maHDX, decimal donGiaNhap)
        {
            return chiTietXuatDAL.DeleteChiTietXuat(maHH, maHDX, donGiaNhap);
        }

        public DataTable SearchChiTietXuat(string maHDX, string keyword)
        {
            return chiTietXuatDAL.SearchChiTietXuat(maHDX, keyword);
        }
    }
}
