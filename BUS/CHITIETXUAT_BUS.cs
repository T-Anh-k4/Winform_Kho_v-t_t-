using System;
using System.Data;
using DAL;
using DAL.DAL;

namespace BUS
{
    public class CHITIETXUAT_BUS
    {
        private CHITIETXUAT_DAL chiTietXuatDAL;

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

        public bool InsertChiTietXuat(string maHH, string maHDX, int soLuongXuat, int donGiaXuat)
        {
            return chiTietXuatDAL.InsertChiTietXuat(maHH, maHDX, soLuongXuat, donGiaXuat);
        }

        public bool UpdateChiTietXuat(int id, string maHH, string maHDX, int soLuongXuat, int donGiaXuat)
        {
            return chiTietXuatDAL.UpdateChiTietXuat(id, maHH, maHDX, soLuongXuat, donGiaXuat);
        }

        public bool DeleteChiTietXuat(int id, string maHDX)
        {
            return chiTietXuatDAL.DeleteChiTietXuat(id, maHDX);
        }

        public DataTable SearchChiTietXuat(string maHDX, string keyword)
        {
            return chiTietXuatDAL.SearchChiTietXuat(maHDX, keyword);
        }
    }
}
