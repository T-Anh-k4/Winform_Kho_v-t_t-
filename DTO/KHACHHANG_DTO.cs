using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KHACHHANG_DTO
    {
        private string _MaKH;
        private string _TenKH;
        private string _DiaChi;
        private string _SoDT;
        private int _Flag;

        // Constructor đầy đủ
        public KHACHHANG_DTO(string maKH, string tenKH, string diaChi, string soDT, int flag)
        {
            MaKH = maKH;
            TenKH = tenKH;
            DiaChi = diaChi;
            SoDT = soDT;
            Flag = flag;
        }

        // Constructor từ DataRow
        public KHACHHANG_DTO(DataRow row)
        {
            MaKH = row["MAKH"].ToString();
            TenKH = row["TENKH"].ToString();
            DiaChi = row["DIACHI"].ToString();
            SoDT = row["SDT"].ToString();
            Flag = (int)row["FLAG"];
        }

        // Properties
        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string TenKH { get => _TenKH; set => _TenKH = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SoDT { get => _SoDT; set => _SoDT = value; }
        public int Flag { get => _Flag; set => _Flag = value; }
    }
}
