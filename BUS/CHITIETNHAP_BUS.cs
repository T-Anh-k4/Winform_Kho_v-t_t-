﻿using System;
using System.Data;
using DAL;

namespace BUS
{
    public class CHITIETNHAP_BUS
    {
        private CHITIETNHAP_DAL chiTietNhapDAL;

        public CHITIETNHAP_BUS()
        {
            chiTietNhapDAL = new CHITIETNHAP_DAL();
        }

        public DataTable GetDanhSachChiTietNhap(string maHDN)
        {
            return chiTietNhapDAL.GetDanhSachChiTietNhap(maHDN);
        }

        public DataTable GetDanhSachChiTietNhapPage(string maHDN, int limit, int page)
        {
            return chiTietNhapDAL.GetDanhSachChiTietNhapPage(maHDN, limit, page);
        }

        public int GetSLChiTietNhap(string maHDN)
        {
            return chiTietNhapDAL.GetSLChiTietNhap(maHDN);
        }

        public bool InsertChiTietNhap(string maHH, string maHDN, int soLuongNhap, int donGiaNhap)
        {
            return chiTietNhapDAL.InsertChiTietNhap(maHH, maHDN, soLuongNhap, donGiaNhap);
        }

        public bool UpdateChiTietNhap(int id, string maHH, string maHDN, int soLuongNhap, int donGiaNhap)
        {
            return chiTietNhapDAL.UpdateChiTietNhap(id, maHH, maHDN, soLuongNhap, donGiaNhap);
        }

        public bool DeleteChiTietNhap(int id, string maHDN)
        {
            return chiTietNhapDAL.DeleteChiTietNhap(id, maHDN);
        }

        public DataTable SearchChiTietNhap(string maHDN, string keyword)
        {
            return chiTietNhapDAL.SearchChiTietNhap(maHDN, keyword);
        }
    }
}