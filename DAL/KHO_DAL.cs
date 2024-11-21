using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KHO_DAL
    {
        DataProvider instance = new DataProvider();
        public KHO_DAL()
        {
            instance = new DataProvider();
        }

        public DataTable getDanhSachHangHoa()
        {
            string query = @"
        SELECT 
            KHO.MAHH AS [Mã hàng hóa],
            HANGHOA.TENHH[Tên hàng hóa], 
            COALESCE(SUM(CHITIET_HD_NHAP.SOLUONG_NHAP), 0) - COALESCE(SUM(CHITIET_HD_XUAT.SOLUONG_XUAT), 0) AS [Số lượng tồn]
        FROM 
            KHO 
        JOIN 
            HANGHOA ON KHO.MAHH = HANGHOA.MAHH
        LEFT JOIN 
            CHITIET_HD_NHAP ON HANGHOA.MAHH = CHITIET_HD_NHAP.MAHH
        LEFT JOIN 
            CHITIET_HD_XUAT ON KHO.IDKHO = CHITIET_HD_XUAT.IDKHO
        GROUP BY 
            KHO.IDKHO, KHO.MAHH, HANGHOA.TENHH,KHO.SOLUONG;";

            return instance.execQuery(query);
        }


    }
}
