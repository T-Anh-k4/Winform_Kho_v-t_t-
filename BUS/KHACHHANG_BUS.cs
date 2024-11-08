using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KHACHHANG_BUS
    {
        KHACHHANG_DAL khachHangDAO = new KHACHHANG_DAL();

        public DataTable GetDanhSachKhachHang()
        {
            return khachHangDAO.getDanhSachKhachHang();
        }

        public DataTable GetDanhSachKhachHangPage(int limit, int page)
        {
            return khachHangDAO.getDanhSachKhachHangPage(limit, page);
        }

        public int GetSoLuongKhachHang()
        {
            return khachHangDAO.GetSoLuongKhachHang();
        }

        public DataTable GetKhachHang(string maKH)
        {
            return khachHangDAO.GetKhachHang(maKH);
        }

        public bool InsertKhachHang(string maKH, string tenKH, string diaChi, string soDT, int flag)
        {
            return khachHangDAO.InsertKhachHang(maKH, tenKH, diaChi, soDT, flag);
        }

        public bool UpdateKhachHang(string maKH, string tenKH, string diaChi, string soDT, int flag)
        {
            return khachHangDAO.UpdateKhachHang(maKH, tenKH, diaChi, soDT, flag);
        }

        public bool DeleteKhachHang(string maKH)
        {
            return khachHangDAO.DeleteKhachHang(maKH);
        }

        public DataTable SearchKhachHang(string keyword)
        {
            return khachHangDAO.SearchKhachHang(keyword);
        }
    }
}
