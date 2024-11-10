
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class HOADONXUAT_DTO
    {
        private string _SoHDNhap;
        private string _MaKH;
        private string _MaNV;
        private DateTime _NgayLapXuat;
        private int _FlagHoXuat;

        public HOADONXUAT_DTO(string soHDXuat, string maKH, string maNV, DateTime ngayLapXuat, int flagHoXuat)
        {
            SoHDXuat = soHDXuat;
            MaKH = maKH;
            MaNV = maNV;
            NgayLapXuat = ngayLapXuat;
            FlagHoXuat = flagHoXuat;
        }

        public HOADONXUAT_DTO(DataRow row)
        {
            SoHDXuat = row["SO_HD_XUAT"].ToString();
            MaKH = row["MAKH"].ToString();
            MaNV = row["MANV"].ToString();
            NgayLapXuat = DateTime.Parse(row["NGAYLAP_XUAT"].ToString());
            FlagHoXuat = int.Parse(row["FLAGXUAT"].ToString());
        }

        public string SoHDXuat { get => _SoHDNhap; set => _SoHDNhap = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public DateTime NgayLapXuat { get => _NgayLapXuat; set => _NgayLapXuat = value; }
        public int FlagHoXuat { get => _FlagHoXuat; set => _FlagHoXuat = value; }
    }
}
