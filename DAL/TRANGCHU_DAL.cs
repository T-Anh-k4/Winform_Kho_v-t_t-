using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TRANGCHU_DAL
    {
        DataProvider instance = new DataProvider();
        public double TongTienNhap(int thang)
        {
            string query = "select sum(SOLUONG_NHAP*DONGIA_NHAP) from CHITIET_HD_NHAP JOIN HOADON_NHAP ON HOADON_NHAP.SO_HD_NHAP = CHITIET_HD_NHAP.SO_HD_NHAP WHERE MONTH(NGAYLAP_NHAP) = "+thang+";";
            object result = instance.execScalar(query);
            double tongtiennhap = result != null ? Convert.ToDouble(result) : 0;
            return tongtiennhap;
        }
        public double TongHangNhap(int thang)
        {
            string query = "select sum(SOLUONG_NHAP) from CHITIET_HD_NHAP JOIN HOADON_NHAP ON HOADON_NHAP.SO_HD_NHAP = CHITIET_HD_NHAP.SO_HD_NHAP WHERE MONTH(NGAYLAP_NHAP) = " + thang + ";";
            object result = instance.execScalar(query);
            double tongtiennhap = result != null ? Convert.ToDouble(result) : 0;
            return tongtiennhap;
        }
        public double TongTienXuat(int thang)
        {
            string query = "select sum(SOLUONG_NHAP*DONGIA_NHAP) from CHITIET_HD_NHAP JOIN HOADON_NHAP ON HOADON_NHAP.SO_HD_NHAP = CHITIET_HD_NHAP.SO_HD_NHAP WHERE MONTH(NGAYLAP_NHAP) = " + thang + ";";
            object result = instance.execScalar(query);
            double tongtiennhap = result != null ? Convert.ToDouble(result) : 0;
            return tongtiennhap;
        }
        public double TongHangXuat(int thang)
        {
            string query = "select sum(SOLUONG_NHAP) from CHITIET_HD_NHAP JOIN HOADON_NHAP ON HOADON_NHAP.SO_HD_NHAP = CHITIET_HD_NHAP.SO_HD_NHAP WHERE MONTH(NGAYLAP_NHAP) = " + thang + ";";
            object result = instance.execScalar(query);
            double tongtiennhap = result != null ? Convert.ToDouble(result) : 0;
            return tongtiennhap;
        }
        public double TongHangTon(int thang)
        {
            string query = @"
        SELECT 
            SUM(CHITIET_HD_NHAP.SOLUONG_NHAP - CHITIET_HD_XUAT.SOLUONG_XUAT)
        FROM 
            KHO 
        JOIN 
            HANGHOA ON KHO.MAHH = HANGHOA.MAHH
        LEFT JOIN 
            CHITIET_HD_NHAP ON HANGHOA.MAHH = CHITIET_HD_NHAP.MAHH
        LEFT JOIN 
            CHITIET_HD_XUAT ON KHO.IDKHO = CHITIET_HD_XUAT.IDKHO
        GROUP BY 
            KHO.IDKHO, KHO.MAHH, HANGHOA.TENHH;";
            object result = instance.execScalar(query);
            double tongtiennhap = result != null ? Convert.ToDouble(result) : 0;
            return tongtiennhap;
        }
    }
}
