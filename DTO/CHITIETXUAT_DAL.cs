using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CHITIETXUAT_DTO
    {
        public int ID { get; set; }
        public string MAHH { get; set; }
        public string SO_HD_NHAP { get; set; }
        public int SOLUONG_NHAP { get; set; }
        public int DONGIA_NHAP { get; set; }

        public CHITIETXUAT_DTO() { }

        public CHITIETXUAT_DTO(int id, string maHH, string soHDNhap, int soLuongNhap, int donGiaNhap)
        {
            ID = id;
            MAHH = maHH;
            SO_HD_NHAP = soHDNhap;
            SOLUONG_NHAP = soLuongNhap;
            DONGIA_NHAP = donGiaNhap;
        }
    }
}
