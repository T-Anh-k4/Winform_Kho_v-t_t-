﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class HOADONXUAT_BUS
    {
        HOADONXUAT_DAL dal = new HOADONXUAT_DAL();
        public DataTable GetDanhSachHoaDonXuat()
        {
            return dal.GetDanhSachHoaDonXuat();
        }

        public DataTable GetDanhSachHoaDonXuatPage(int limit, int page)
        {
            return dal.GetDanhSachHoaDonXuatPage(limit, page);
        }

        public int GetSLHoaDonXuat()
        {
            return dal.GetSLHoaDonXuat();
        }

        public bool InsertHoaDonXuat(string soHDXuat, string maKH, string maNV, DateTime ngayLapXuat, int flagHoXuat)
        {
            return dal.InsertHoaDonXuat(soHDXuat, maKH, maNV, ngayLapXuat, flagHoXuat);
        }

        public bool UpdateHoaDonXuat(string soHDXuat, string maKH, string maNV, DateTime ngayLapXuat, int flagHoXuat)
        {
            return dal.UpdateHoaDonXuat(soHDXuat, maKH, maNV, ngayLapXuat, flagHoXuat);
        }

        public bool DeleteHoaDonXuat(string soHDXuat)
        {
            return dal.DeleteHoaDonXuat(soHDXuat);
        }

        public DataTable SearchHoaDonXuat(string keyword)
        {
            return dal.SearchHoaDonXuat(keyword);
        }
    }
}
