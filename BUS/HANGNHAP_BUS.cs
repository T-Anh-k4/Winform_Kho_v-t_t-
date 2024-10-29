using DAL;
using System.Data;
using DTO;
using System;

namespace BUS
{
    public class HANGNHAP_BUS
    {
        HANGNHAP_DAL hangNhapDAL = new HANGNHAP_DAL();

        public DataTable GetDanhSachHoaDonNhap()
        {
            return hangNhapDAL.GetDanhSachHoaDonNhap();
        }

        public bool InsertHoaDonNhap(string soHDNhap, string maNCC, string maNV, DateTime ngayLapNhap, int flagHoNhap)
        {
            return hangNhapDAL.InsertHoaDonNhap(soHDNhap, maNCC, maNV, ngayLapNhap, flagHoNhap);
        }

        public bool UpdateHoaDonNhap(string soHDNhap, string maNCC, string maNV, DateTime ngayLapNhap, int flagHoNhap)
        {
            return hangNhapDAL.UpdateHoaDonNhap(soHDNhap, maNCC, maNV, ngayLapNhap, flagHoNhap);
        }

        public bool DeleteHoaDonNhap(string soHDNhap)
        {
            return hangNhapDAL.DeleteHoaDonNhap(soHDNhap);
        }

        public DataTable SearchHoaDonNhap(string keyword)
        {
            return hangNhapDAL.SearchHoaDonNhap(keyword);
        }

        public int GetSLNhaCungCap()
        {
            return hangNhapDAL.GetSLHoaDonNhap();
        }

        public DataTable GetDanhSachNhaCungCapPage(int limit, int page)
        {
            return hangNhapDAL.GetDanhSachHoaDonNhapPage(limit, page);
        }

        public DataTable SearchNCC(string key)
        {
            return hangNhapDAL.SearchHoaDonNhap(key);
        }
    }
}