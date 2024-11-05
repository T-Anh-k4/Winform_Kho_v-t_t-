using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class RDLC_BUS
    {
        RDLC_DAL rdlcDal = new RDLC_DAL();
        public DataSet GetDanhSachChiTietNhap()
        {
            return rdlcDal.GetDanhSachChiTietNhap();
        }
        public DataSet GetDanhSachChiTietNhap1()
        {
            return rdlcDal.GetDanhSachChiTietNhap();
        }

    }
}
