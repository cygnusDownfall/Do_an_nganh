using System;
using System.Collections.Generic;
using Do_an_nganh_QuanLiOrderMonAn.DAO;

namespace Do_an_nganh_QuanLiOrderMonAn.BUS
{
    public  class QLTaiKhoan
    {
        QLTaiKhoan() { }
        public static QLTaiKhoan instance = new QLTaiKhoan();
        public void LogIn()
        {

        }
        public void LogOut()
        {
            QLTaiKhoanDAO.QLTaiKhoan.LogOut();
        }

    }
}
