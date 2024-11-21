using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BAOCAONHAPKHO_DAL
    {
        DataProvider instance = new DataProvider();

        public BAOCAONHAPKHO_DAL()
        {
            instance = new DataProvider();
        }

        public DataTable getDanhSachHangHoa()
        {
            string query = @"
        SELECT 
            NCC.TENNCC AS [Tên nhà cung cấp],
            HH.TENHH AS [Tên hàng hóa],
            HH.DONVI_TINH AS [Đơn vị tính],
            CTHD_N.SOLUONG_NHAP AS [Số lượng],
            CONVERT(DECIMAL(18, 0), DONGIA_NHAP) AS [Đơn giá],
            HD_N.NGAYLAP_NHAP AS [Ngày lập]
        FROM 
            NHACUNGCAP NCC
        JOIN 
            HOADON_NHAP HD_N ON NCC.MANCC = HD_N.MANCC
        JOIN 
            CHITIET_HD_NHAP CTHD_N ON HD_N.SO_HD_NHAP = CTHD_N.SO_HD_NHAP
        JOIN 
            HANGHOA HH ON CTHD_N.MAHH = HH.MAHH;
    ";
            return instance.execQuery(query);
        }

        public DataTable GetNhaCungCap()
        {
            string query = "SELECT DISTINCT TENNCC " +
                           "FROM NHACUNGCAP ";
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
            NCC.TENNCC AS [Tên nhà cung cấp],
            HH.TENHH AS [Tên hàng hóa],
            HH.DONVI_TINH AS [Đơn vị tính],
            CTHD_N.SOLUONG_NHAP AS [Số lượng],
            CTHD_N.DONGIA_NHAP AS [Đơn giá],
            HD_N.NGAYLAP_NHAP AS [Ngày lập]
        FROM 
            NHACUNGCAP NCC
        JOIN 
            HOADON_NHAP HD_N ON NCC.MANCC = HD_N.MANCC
        JOIN 
            CHITIET_HD_NHAP CTHD_N ON HD_N.SO_HD_NHAP = CTHD_N.SO_HD_NHAP
        JOIN 
            HANGHOA HH ON CTHD_N.MAHH = HH.MAHH
        WHERE 
            HH.TENHH LIKE N'%" + keyword + @"%'";

                return instance.execQuery(query);
            }
            catch
            {
                return null;
            }
        }
        public DataTable SearchNhaCC(string keyword)
        {
            try
            {
                string query = @"
        SELECT 
            NCC.TENNCC AS [Tên nhà cung cấp],
            HH.TENHH AS [Tên hàng hóa],
            HH.DONVI_TINH AS [Đơn vị tính],
            CTHD_N.SOLUONG_NHAP AS [Số lượng],
            CTHD_N.DONGIA_NHAP AS [Đơn giá],
            HD_N.NGAYLAP_NHAP AS [Ngày lập]
        FROM 
            NHACUNGCAP NCC
        JOIN 
            HOADON_NHAP HD_N ON NCC.MANCC = HD_N.MANCC
        JOIN 
            CHITIET_HD_NHAP CTHD_N ON HD_N.SO_HD_NHAP = CTHD_N.SO_HD_NHAP
        JOIN 
            HANGHOA HH ON CTHD_N.MAHH = HH.MAHH
        WHERE 
            NCC.TENNCC LIKE N'%" + keyword + @"%'";

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
            NCC.TENNCC AS [Tên nhà cung cấp],
            HH.TENHH AS [Tên hàng hóa],
            HH.DONVI_TINH AS [Đơn vị tính],
            CTHD_N.SOLUONG_NHAP AS [Số lượng],
            CTHD_N.DONGIA_NHAP AS [Đơn giá],
            HD_N.NGAYLAP_NHAP AS [Ngày lập]
        FROM 
            NHACUNGCAP NCC
        JOIN 
            HOADON_NHAP HD_N ON NCC.MANCC = HD_N.MANCC
        JOIN 
            CHITIET_HD_NHAP CTHD_N ON HD_N.SO_HD_NHAP = CTHD_N.SO_HD_NHAP
        JOIN 
            HANGHOA HH ON CTHD_N.MAHH = HH.MAHH
        WHERE 1=1";

                // Thêm điều kiện từ ngày và đến ngày nếu có
                List<SqlParameter> parameters = new List<SqlParameter>();

                if (fromDate.HasValue)
                {
                    query += " AND HD_N.NGAYLAP_NHAP >= @FromDate";
                    parameters.Add(new SqlParameter("@FromDate", fromDate.Value));
                }

                if (toDate.HasValue)
                {
                    query += " AND HD_N.NGAYLAP_NHAP <= @ToDate";
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

