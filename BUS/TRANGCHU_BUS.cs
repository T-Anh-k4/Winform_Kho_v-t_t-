using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TRANGCHU_BUS
    {
        TRANGCHU_DAL homeDAL = new TRANGCHU_DAL();
        public Decimal TongTienNhap(int thang)
        {
            return homeDAL.TongTienNhap(thang);
        }
        public double TongHangNhap(int thang)
        {
            return homeDAL.TongHangNhap(thang);
        }
        public Decimal TongTienXuat(int thang)
        {
            return homeDAL.TongTienXuat(thang);
        }
        public double TongHangXuat(int thang)
        {
            return homeDAL.TongHangXuat(thang);
        }
        public double TongHangTon()
        {
            return homeDAL.TongHangTon();
        }
        public double TongHangTonThang(int thang)
        {
            return homeDAL.TongHangTonThang(thang);
        }

        public DataTable GetMonthCTHD()
        {
            return homeDAL.GetMonthCTHD();
        }
        public DataTable GetMonthCTHDXUAT()
        {
            return homeDAL.GetMonthCTHDXUAT();
        }
        public DataTable GetTenNhaCungCap()
        {
            return homeDAL.GetTenNhaCungCap();
        }
        public DataTable GetTenKhachHang()
        {
            return homeDAL.GetTenKhachHang();
        }

    }
}
