using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TRANGCHU_BUS
    {
        TRANGCHU_DAL homeDAL = new TRANGCHU_DAL();
        public double TongTienNhap(int thang)
        {
            return homeDAL.TongTienNhap(thang);
        }
        public double TongHangNhap(int thang)
        {
            return homeDAL.TongHangNhap(thang);
        }
        public double TongHangTon(int thang)
        {
            return homeDAL.TongHangTon(thang);
        }


    }
}
