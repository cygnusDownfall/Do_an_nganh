﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_nganh_QuanLiOrderMonAn.BUS
{
    public class NhanVienBUS
    {
        NhanVienBUS() { }
        public static NhanVienBUS instance = new NhanVienBUS();

        public void ThemNhanVien(DTO.NhanVien nv)
        {
            try
            {
                DAO.QLNhanVienDAO.instance.ThemNhanVien(nv);
            }
            catch
            {

            }
        }
        public void CapnhatNhanVien(DTO.NhanVien nv)
        {
            try
            {
                DAO.QLNhanVienDAO.instance.ThemNhanVien(nv);
            }
            catch
            {

            }
        }
        public void XoaNhanVien(DTO.NhanVien nv)
        {
            try
            {
                DAO.QLNhanVienDAO.instance.ThemNhanVien(nv);
            }
            catch
            {

            }
        }
    }
}
