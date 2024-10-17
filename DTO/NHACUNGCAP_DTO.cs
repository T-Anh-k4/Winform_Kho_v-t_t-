using System;
using System.Data;

namespace DTO
{
    public class NHACUNGCAP_DTO
    {
        private string _MaNCC;
        private string _TenNCC;
        private string _DiaChi;
        private string _SoDT;

        public NHACUNGCAP_DTO(string maNCC, string tenNCC, string diaChi, string soDT)
        {
            MaNCC = maNCC;
            TenNCC = tenNCC;
            DiaChi = diaChi;
            SoDT = soDT;
        }

        public NHACUNGCAP_DTO(DataRow row)
        {
            MaNCC = row["MANCC"].ToString();
            TenNCC = row["TENNCC"].ToString();
            DiaChi = row["DIACHI"].ToString();
            SoDT = row["SDT"].ToString();
        }

        public string MaNCC { get => _MaNCC; set => _MaNCC = value; }
        public string TenNCC { get => _TenNCC; set => _TenNCC = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SoDT { get => _SoDT; set => _SoDT = value; }
    }
}