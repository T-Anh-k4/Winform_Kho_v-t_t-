using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TRANGCHU_DAL
    {
        DataProvider instance = new DataProvider();
        public Decimal TongTienNhap(int thang)
        {
            string query = "select sum(SOLUONG_NHAP*DONGIA_NHAP) from CHITIET_HD_NHAP JOIN HOADON_NHAP ON HOADON_NHAP.SO_HD_NHAP = CHITIET_HD_NHAP.SO_HD_NHAP WHERE MONTH(NGAYLAP_NHAP) = "+thang+";";
            object result = instance.execScalar(query);
            decimal tongtiennhap = (result == DBNull.Value) ? 0 : Convert.ToDecimal(result);
            tongtiennhap = Math.Round(tongtiennhap, 0); // Làm tròn đến số nguyên (bỏ phần thập phân)
            return tongtiennhap;
        }
        public double TongHangNhap(int thang)
        {
            string query = "select sum(SOLUONG_NHAP) from CHITIET_HD_NHAP JOIN HOADON_NHAP ON HOADON_NHAP.SO_HD_NHAP = CHITIET_HD_NHAP.SO_HD_NHAP WHERE MONTH(NGAYLAP_NHAP) = " + thang + ";";
            object result = instance.execScalar(query);
            double tongtiennhap = (result == DBNull.Value) ? 0 : Convert.ToDouble(result);
            return tongtiennhap;
        }
        public Decimal TongTienXuat(int thang)
        {
            string query = "select sum(SOLUONG_XUAT*DONGIA_XUAT) from CHITIET_HD_XUAT JOIN HOADON_XUAT ON HOADON_XUAT.SO_HD_XUAT = CHITIET_HD_XUAT.SO_HD_XUAT WHERE MONTH(NGAYLAP_XUAT) = " + thang + ";";
            object result = instance.execScalar(query);
            decimal tongtienxuat = (result == DBNull.Value) ? 0 : Convert.ToDecimal(result);
            tongtienxuat = Math.Round(tongtienxuat, 0); // Làm tròn đến số nguyên (bỏ phần thập phân)
            return tongtienxuat;
        }
        public double TongHangXuat(int thang)
        {
            string query = "select sum(SOLUONG_XUAT) from CHITIET_HD_XUAT JOIN HOADON_XUAT ON HOADON_XUAT.SO_HD_XUAT = CHITIET_HD_XUAT.SO_HD_XUAT WHERE MONTH(NGAYLAP_XUAT) = " + thang + ";";
            object result = instance.execScalar(query);
            double tongtiennhap = (result == DBNull.Value) ? 0 : Convert.ToDouble(result);
            return tongtiennhap;
        }
        public double TongHangTon()
        {
            string query = @"
        SELECT 
            SUM(COALESCE(CHITIET_HD_NHAP.SOLUONG_NHAP, 0)) - SUM(COALESCE(CHITIET_HD_XUAT.SOLUONG_XUAT, 0)) AS [TongHangTon]
        FROM 
            KHO
        LEFT JOIN 
            CHITIET_HD_NHAP ON KHO.MAHH = CHITIET_HD_NHAP.MAHH
        LEFT JOIN 
            CHITIET_HD_XUAT ON KHO.IDKHO = CHITIET_HD_XUAT.IDKHO";

            object result = instance.execScalar(query);
            double tongtiennhap = (result == DBNull.Value) ? 0 : Convert.ToDouble(result);
            return tongtiennhap;
        }
        public double TongHangTonThang(int thang)
        {
            string query = @"
        SELECT 
            SUM(COALESCE(CHITIET_HD_NHAP.SOLUONG_NHAP, 0)) - SUM(COALESCE(CHITIET_HD_XUAT.SOLUONG_XUAT, 0)) AS [TongHangTon]
        FROM 
            KHO 
        LEFT JOIN 
            CHITIET_HD_NHAP ON KHO.MAHH = CHITIET_HD_NHAP.MAHH 
        LEFT JOIN 
            CHITIET_HD_XUAT ON KHO.IDKHO = CHITIET_HD_XUAT.IDKHO
        LEFT JOIN 
            HOADON_NHAP ON HOADON_NHAP.SO_HD_NHAP = CHITIET_HD_NHAP.SO_HD_NHAP
        LEFT JOIN 
            HOADON_XUAT ON HOADON_XUAT.SO_HD_XUAT = CHITIET_HD_XUAT.SO_HD_XUAT
        WHERE 
            (MONTH(HOADON_NHAP.NGAYLAP_NHAP) = @thang OR HOADON_NHAP.NGAYLAP_NHAP IS NULL)
            AND (MONTH(HOADON_XUAT.NGAYLAP_XUAT) = @thang OR HOADON_XUAT.NGAYLAP_XUAT IS NULL)";

            SqlParameter[] parameters = {
        new SqlParameter("@thang", thang)
    };

            object result = instance.execScalar(query, parameters);
            double tongHangTon = (result == DBNull.Value) ? 0 : Convert.ToDouble(result);
            return tongHangTon;
        }
        public DataTable GetTenNhaCungCap()
        {
            string query = "SELECT TENNCC,SUM(SOLUONG_NHAP) AS TongSoLuongNhap FROM HOADON_NHAP JOIN NHACUNGCAP ON NHACUNGCAP.MANCC = HOADON_NHAP.MANCC JOIN CHITIET_HD_NHAP ON HOADON_NHAP.SO_HD_NHAP = CHITIET_HD_NHAP.SO_HD_NHAP GROUP BY TENNCC";
            return instance.execQuery(query);  
        }

        public DataTable GetTenKhachHang()
        {
            string query = "SELECT TENKH,SUM(SOLUONG_XUAT) AS TongSoLuongXuat FROM HOADON_XUAT JOIN KHACHHANG ON KHACHHANG.MAKH = HOADON_XUAT.MAKH JOIN CHITIET_HD_XUAT ON HOADON_XUAT.SO_HD_XUAT = CHITIET_HD_XUAT.SO_HD_XUAT GROUP BY TENKH";
            return instance.execQuery(query);
        }
        public DataTable GetMonthCTHD()
        {
            string query = "select  month(NGAYLAP_NHAP) as Thang,sum(SOLUONG_NHAP*DONGIA_NHAP) as TienChi  from CHITIET_HD_NHAP JOIN HOADON_NHAP ON HOADON_NHAP.SO_HD_NHAP = CHITIET_HD_NHAP.SO_HD_NHAP group by NGAYLAP_NHAP ,SOLUONG_NHAP,DONGIA_NHAP;";
            return instance.execQuery(query);
        }
        public DataTable GetMonthCTHDXUAT()
        {
            string query = "select  month(NGAYLAP_XUAT) as Thang,sum(SOLUONG_XUAT*DONGIA_XUAT) as TienChi  from CHITIET_HD_XUAT JOIN HOADON_XUAT ON HOADON_XUAT.SO_HD_XUAT = CHITIET_HD_XUAT.SO_HD_XUAT group by NGAYLAP_XUAT ,SOLUONG_XUAT,DONGIA_XUAT;";
            return instance.execQuery(query);
        }

    }
}
