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


        public bool InsertKhachHang(string maKH, string tenKH, string diaChi, string soDT)
        {
            return khachHangDAO.InsertKhachHang(maKH, tenKH, diaChi, soDT);
        }

        public bool UpdateKhachHang(string maKH, string tenKH, string diaChi, string soDT)
        {
            return khachHangDAO.UpdateKhachHang(maKH, tenKH, diaChi, soDT);
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
