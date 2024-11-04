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

        public DataSet GetDanhSachChiTietNhap()
        {
            string query = "SELECT MAHH ,MALOAI ,TENHH ,DONVI_TINH ,XUATXU FROM HANGHOA";
            return instance.readDataSet(query);
        }
        public DataSet GetDanhSachChiTietNhap1()
        {
            string query = "  select * from [dbo].[CHITIET_HD_NHAP] join [dbo].[HOADON_NHAP] on [dbo].[HOADON_NHAP].SO_HD_NHAP = .CHITIET_HD_NHAP.SO_HD_NHAP join [dbo].[NHANVIEN] on [dbo].[NHANVIEN].MANV = [dbo].[HOADON_NHAP].MANV join [dbo].[HANGHOA] on [dbo].[HANGHOA].MAHH = [dbo].[CHITIET_HD_NHAP].MAHH";
            return instance.readDataSet(query);
        }
    }
}
