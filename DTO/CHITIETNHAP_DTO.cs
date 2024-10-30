using System;

namespace DTO
{
    public class CHITIETNHAP_DTO
    {
        public int ID { get; set; }
        public string MAHH { get; set; }
        public string SO_HD_NHAP { get; set; }
        public int SOLUONG_NHAP { get; set; }
        public int DONGIA_NHAP { get; set; }

        public CHITIETNHAP_DTO() { }

        public CHITIETNHAP_DTO(int id, string maHH, string soHDNhap, int soLuongNhap, int donGiaNhap)
        {
            ID = id;
            MAHH = maHH;
            SO_HD_NHAP = soHDNhap;
            SOLUONG_NHAP = soLuongNhap;
            DONGIA_NHAP = donGiaNhap;
        }
    }
}