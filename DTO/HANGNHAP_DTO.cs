using System;
using System.Data;

namespace DTO
{
    public class HOADONNHAP_DTO
    {
        private string _SoHDNhap;
        private string _MaNCC;
        private string _MaNV;
        private DateTime _NgayLapNhap;
        private int _FlagHoNhap;

        public HOADONNHAP_DTO(string soHDNhap, string maNCC, string maNV, DateTime ngayLapNhap, int flagHoNhap)
        {
            SoHDNhap = soHDNhap;
            MaNCC = maNCC;
            MaNV = maNV;
            NgayLapNhap = ngayLapNhap;
            FlagHoNhap = flagHoNhap;
        }

        public HOADONNHAP_DTO(DataRow row)
        {
            SoHDNhap = row["SO_HD_NHAP"].ToString();
            MaNCC = row["MANCC"].ToString();
            MaNV = row["MANV"].ToString();
            NgayLapNhap = DateTime.Parse(row["NGAYLAP_NHAP"].ToString());
            FlagHoNhap = int.Parse(row["FLAGHONHAP"].ToString());
        }

        public string SoHDNhap { get => _SoHDNhap; set => _SoHDNhap = value; }
        public string MaNCC { get => _MaNCC; set => _MaNCC = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public DateTime NgayLapNhap { get => _NgayLapNhap; set => _NgayLapNhap = value; }
        public int FlagHoNhap { get => _FlagHoNhap; set => _FlagHoNhap = value; }
    }
}