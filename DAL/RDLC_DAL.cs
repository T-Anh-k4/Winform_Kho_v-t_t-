using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class RDLC_DAL
    {
        DataProvider instance = new DataProvider();

        public RDLC_DAL()
        {
            instance = new DataProvider();
        }

        public DataSet GetDanhSachChiTietNhap(string soHdNhap)
        {
            string query = @"SELECT CHITIET_HD_NHAP.SO_HD_NHAP, 
                            CHITIET_HD_NHAP.SOLUONG_NHAP, 
                            CHITIET_HD_NHAP.DONGIA_NHAP, 
                            HOADON_NHAP.NGAYLAP_NHAP, 
                            HANGHOA.TENHH, 
                            HANGHOA.DONVI_TINH, 
                            HANGHOA.XUATXU, 
                            NHANVIEN.TENNV, 
                            NHACUNGCAP.TENNCC,
                            CAST(SOLUONG_NHAP * DONGIA_NHAP AS INT) AS THANHTIEN,
                            SUM(CAST(SOLUONG_NHAP * DONGIA_NHAP AS INT)) OVER() AS TONGTIEN
                     FROM CHITIET_HD_NHAP 
                     INNER JOIN HANGHOA ON CHITIET_HD_NHAP.MAHH = HANGHOA.MAHH 
                     INNER JOIN HOADON_NHAP ON CHITIET_HD_NHAP.SO_HD_NHAP = HOADON_NHAP.SO_HD_NHAP 
                     INNER JOIN NHACUNGCAP ON HOADON_NHAP.MANCC = NHACUNGCAP.MANCC 
                     INNER JOIN NHANVIEN ON HOADON_NHAP.MANV = NHANVIEN.MANV
                     WHERE CHITIET_HD_NHAP.SO_HD_NHAP = @SO_HD_NHAP";

            SqlParameter parameter = new SqlParameter("@SO_HD_NHAP", soHdNhap);
            return instance.readDataSet(query, parameter);
        }
    }
}
