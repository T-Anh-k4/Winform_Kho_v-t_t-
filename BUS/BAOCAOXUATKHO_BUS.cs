using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BAOCAOXUATKHO_BUS
    {
        BAOCAOXUATKHO_DAL hanghoaDAL = new BAOCAOXUATKHO_DAL();

        public DataTable GetDanhSachHangHoa()
        {
            return hanghoaDAL.getDanhSachHangHoa();
        }
        public DataTable GetHangHoa()
        {
            return hanghoaDAL.GetHanhHoa();
        }
        public DataTable SearchHangHoa(string keyword)
        {
            return hanghoaDAL.SearchHangHoa(keyword);
        }
        public DataTable SearchKH(string keyword)
        {
            return hanghoaDAL.SearchKHACHHANG(keyword);
        }
        public DataTable SearchNgay(DateTime? fromDate = null, DateTime? toDate = null)
        {
            return hanghoaDAL.SearchNgay(fromDate, toDate);
        }

    }
}
