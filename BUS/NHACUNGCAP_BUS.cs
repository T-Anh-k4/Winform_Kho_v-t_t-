using DAL;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class NHACUNGCAP_BUS
    {
        NHACUNGCAP_DAL nhaCungCapDAL = new NHACUNGCAP_DAL();
        DataProvider dataProvider = new DataProvider();

        public DataTable GetDanhSachNhaCungCap()
        {
            return nhaCungCapDAL.getDanhSachNhaCungCap();
        }

        public DataTable GetDanhSachNhaCungCapPage(int limit, int page)
        {
            return nhaCungCapDAL.getDanhSachNhaCungCapPage(limit, page);
        }

        public int GetSLNhaCungCap()
        {
            return nhaCungCapDAL.GetSLNhaCungCap();
        }

        public DataTable GetNhaCungCap(string maNCC)
        {
            return nhaCungCapDAL.GetNhaCungCap(maNCC);
        }

        public bool InsertNhaCungCap(string maNCC, string tenNCC, string diaChi, string soDT)
        {
            return nhaCungCapDAL.InsertNhaCungCap(maNCC, tenNCC, diaChi, soDT);
        }

        public bool UpdateNhaCungCap(string maNCC, string tenNCC, string diaChi, string soDT)
        {
            return nhaCungCapDAL.UpdateNhaCungCap(maNCC, tenNCC, diaChi, soDT);
        }

        public bool DeleteNhaCungCap(string maNCC)
        {
            return nhaCungCapDAL.DeleteNhaCungCap(maNCC);
        }
    }
}
