using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BAOCAOXUATKHO_DAL
    {
        DataProvider instance = new DataProvider();

        public BAOCAOXUATKHO_DAL()
        {
            instance = new DataProvider();
        }

        public DataTable getDanhSachHangHoa()
        {
            string query = @"
        SELECT 
            kh.TENKH AS [Tên khách hàng],
            HH.TENHH AS [Tên hàng hóa],
            HH.DONVI_TINH AS [Đơn vị tính],
            CTHD_X.SOLUONG_XUAT AS [Số lượng],
            CONVERT(DECIMAL(18, 0), DONGIA_XUAT) AS [Đơn giá],
            HD_X.NGAYLAP_XUAT AS [Ngày lập]
        FROM 
            KHACHHANG kh
        JOIN 
            HOADON_XUAT HD_X ON kh.MAKH = HD_X.MAKH
        JOIN 
            CHITIET_HD_XUAT CTHD_X ON HD_X.SO_HD_XUAT = CTHD_X.SO_HD_XUAT
        JOIN
            KHO k ON K.IDKHO = CTHD_X.IDKHO 
        JOIN 
            HANGHOA HH ON K.MAHH = HH.MAHH;
    ";
            return instance.execQuery(query);
        }

        public DataTable GetHanhHoa()
        {
            string query = "SELECT DISTINCT TENHH " +
                           "FROM HANGHOA ";
            return instance.execQuery(query);
        }

        public DataTable SearchHangHoa(string keyword)
        {
            try
            {
                string query = @"
        SELECT 
            kh.TENKH AS [Tên khách hàng],
            HH.TENHH AS [Tên hàng hóa],
            HH.DONVI_TINH AS [Đơn vị tính],
            CTHD_X.SOLUONG_XUAT AS [Số lượng],
            CTHD_X.DONGIA_XUAT AS [Đơn giá],
            HD_X.NGAYLAP_XUAT AS [Ngày lập]
        FROM 
            KHACHHANG kh
        JOIN 
            HOADON_XUAT HD_X ON kh.MAKH = HD_X.MAKH
        JOIN 
            CHITIET_HD_XUAT CTHD_X ON HD_X.SO_HD_XUAT = CTHD_X.SO_HD_XUAT
        JOIN
            KHO k ON K.IDKHO = CTHD_X.IDKHO 
        JOIN 
            HANGHOA HH ON K.MAHH = HH.MAHH
        WHERE 
            HH.TENHH LIKE N'%" + keyword + @"%'";

                return instance.execQuery(query);
            }
            catch
            {
     
                return null;
            }
        }

        public DataTable SearchKHACHHANG(string keyword)
        {
            try
            {
                string query = @"
        SELECT 
            kh.TENKH AS [Tên khách hàng],
            HH.TENHH AS [Tên hàng hóa],
            HH.DONVI_TINH AS [Đơn vị tính],
            CTHD_X.SOLUONG_XUAT AS [Số lượng],
            CTHD_X.DONGIA_XUAT AS [Đơn giá],
            HD_X.NGAYLAP_XUAT AS [Ngày lập]
        FROM 
            KHACHHANG kh
        JOIN 
            HOADON_XUAT HD_X ON kh.MAKH = HD_X.MAKH
        JOIN 
            CHITIET_HD_XUAT CTHD_X ON HD_X.SO_HD_XUAT = CTHD_X.SO_HD_XUAT
        JOIN
            KHO k ON K.IDKHO = CTHD_X.IDKHO 
        JOIN 
            HANGHOA HH ON K.MAHH = HH.MAHH
        WHERE 
            kh.TENKH LIKE N'%" + keyword + @"%'";

                return instance.execQuery(query);
            }
            catch
            {

                return null;
            }
        }

        public DataTable SearchNgay(DateTime? fromDate = null, DateTime? toDate = null)
        {
            try
            {
                string query = @"
        SELECT 
            kh.TENKH AS [Tên khách hàng],
            HH.TENHH AS [Tên hàng hóa],
            HH.DONVI_TINH AS [Đơn vị tính],
            CTHD_X.SOLUONG_XUAT AS [Số lượng],
            CTHD_X.DONGIA_XUAT AS [Đơn giá],
            HD_X.NGAYLAP_XUAT AS [Ngày lập]
        FROM 
            KHACHHANG kh
        JOIN 
            HOADON_XUAT HD_X ON kh.MAKH = HD_X.MAKH
        JOIN 
            CHITIET_HD_XUAT CTHD_X ON HD_X.SO_HD_XUAT = CTHD_X.SO_HD_XUAT
        JOIN
            KHO k ON K.IDKHO = CTHD_X.IDKHO 
        JOIN 
            HANGHOA HH ON K.MAHH = HH.MAHH
        WHERE 1=1";

                List<SqlParameter> parameters = new List<SqlParameter>();

                if (fromDate.HasValue)
                {
                    query += " AND HD_X.NGAYLAP_XUAT >= @FromDate";
                    parameters.Add(new SqlParameter("@FromDate", fromDate.Value));
                }

                if (toDate.HasValue)
                {
                    query += " AND HD_X.NGAYLAP_XUAT <= @ToDate";
                    parameters.Add(new SqlParameter("@ToDate", toDate.Value));
                }

                return instance.execQuery(query, parameters.ToArray());
            }
            catch
            {
                return null;
            }
        }

    }
}
