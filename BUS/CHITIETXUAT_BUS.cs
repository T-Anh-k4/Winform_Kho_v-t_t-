using System;
using System.Data;
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

        public int getTotalCost(string maHDX)
        {
            return chiTietXuatDAL.getTotalCost(maHDX);
        }

        public DataTable getHoaDonXuatDetail(string maHDX)
        {
            return chiTietXuatDAL.getHoaDonXuatDetail(maHDX);
        }

        public bool InsertChiTietXuat(string maHH, string maHDX, int soLuongXuat, int donGiaXuat)
        {
            return chiTietXuatDAL.InsertChiTietXuat(maHH, maHDX, soLuongXuat, donGiaXuat);
        }

        public bool UpdateChiTietXuat(int ID, string maHH, string maHDX, int soLuongXuat, int donGiaXuat)
        {
            return chiTietXuatDAL.UpdateChiTietXuat(ID, maHH, maHDX, soLuongXuat, donGiaXuat);
        }

        public bool DeleteChiTietXuat(int ID)
        {
            return chiTietXuatDAL.DeleteChiTietXuat(ID);
        }

        public DataTable SearchChiTietXuat(string maHDX, string keyword)
        {
            return chiTietXuatDAL.SearchChiTietXuat(maHDX, keyword);
        }
    }
}
