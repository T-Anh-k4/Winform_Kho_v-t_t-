using DAL;
using System.Data;
using DTO;

namespace BUS
{
    public class NHACUNGCAP_BUS
    {
        NHACUNGCAP_DAL nhaCungCapDAL = new NHACUNGCAP_DAL();

        public DataTable GetDanhSachNhaCungCap()
        {
            return nhaCungCapDAL.GetDanhSachNhaCungCap();
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

        public DataTable SearchNhaCungCap(string keyword)
        {
            return nhaCungCapDAL.SearchNhaCungCap(keyword);
        }

        public int GetSLNhaCungCap()
        {
            return nhaCungCapDAL.GetSLNhaCungCap();
        }

        public DataTable GetDanhSachNhaCungCapPage(int limit, int page)
        {
            return nhaCungCapDAL.GetDanhSachNhaCungCapPage(limit, page);
        }

        public DataTable SearchNCC(string key)
        {
            return nhaCungCapDAL.SearchNhaCungCap(key);
        }
    }
}
