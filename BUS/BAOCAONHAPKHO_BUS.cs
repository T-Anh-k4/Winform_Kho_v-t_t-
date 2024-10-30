using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BAOCAONHAPKHO_BUS
    {
        BAOCAONHAPKHO_DAL hanghoaDAL = new BAOCAONHAPKHO_DAL();

        public DataTable GetDanhSachHangHoa()
        {
            return hanghoaDAL.getDanhSachHangHoa();
        }
        public DataTable GetNhaCC()
        {
            return hanghoaDAL.GetNhaCungCap();
        }
        public DataTable GetHangHoa()
        {
            return hanghoaDAL.GetHanhHoa();
        }
        public DataTable SearchHangHoa(string keyword)
        {
            return hanghoaDAL.SearchHangHoa(keyword);
        }
        public DataTable SearchNhaCC(string keyword)
        {
            return hanghoaDAL.SearchNhaCC(keyword);
        }
        public DataTable SearchNgay(DateTime? fromDate = null, DateTime? toDate = null)
        {
            return hanghoaDAL.SearchNgay(fromDate, toDate);
        }

    }
}
