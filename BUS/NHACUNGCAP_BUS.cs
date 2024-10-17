using DAL;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class NHACUNGCAP_BUS
    {
        NHACUNGCAP_DAL nhaCungCapDAO = new NHACUNGCAP_DAL();
        DataProvider dataProvider = new DataProvider();

        public DataTable GetDanhSachNhaCungCap()
        {
            return nhaCungCapDAO.getDanhSachNhaCungCap();
        }

        public DataTable GetDanhSachNhaCungCapPage(int limit, int page)
        {
            return nhaCungCapDAO.getDanhSachNhaCungCapPage(limit, page);
        }

        public int GetSLNhaCungCap()
        {
            return nhaCungCapDAO.GetSLNhaCungCap();
        }

        public DataTable GetNhaCungCap(string maNCC)
        {
            return nhaCungCapDAO.GetNhaCungCap(maNCC);
        }

        public bool InsertNhaCungCap(string maNCC, string tenNCC, string diaChi, string soDT)
        {
            return nhaCungCapDAO.InsertNhaCungCap(maNCC, tenNCC, diaChi, soDT);
        }

        public bool UpdateNhaCungCap(string maNCC, string tenNCC, string diaChi, string soDT)
        {
            return nhaCungCapDAO.UpdateNhaCungCap(maNCC, tenNCC, diaChi, soDT);
        }

        public bool DeleteNhaCungCap(string maNCC)
        {
            return nhaCungCapDAO.DeleteNhaCungCap(maNCC);
        }
    }
}
