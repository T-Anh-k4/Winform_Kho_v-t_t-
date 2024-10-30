using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class KHO_BUS
    {
        KHO_DAL kho = new KHO_DAL();
        public DataTable GetDanhSachHangHoa()
        {
            return kho.getDanhSachHangHoa();
        }
    }
}
