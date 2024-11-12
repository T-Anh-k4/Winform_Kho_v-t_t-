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
        public DataSet GetDanhSachChiTietNhap(string ma)
        {
            return rdlcDal.GetDanhSachChiTietNhap(ma);
        }
        public DataSet GetDanhSachChiTietXuat(string soHdXuat)
        {
            return rdlcDal.GetDanhSachChiTietXuat(soHdXuat);
        }
    }
}
