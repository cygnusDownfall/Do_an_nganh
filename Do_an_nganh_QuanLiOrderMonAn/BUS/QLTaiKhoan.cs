﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Do_an_nganh_QuanLiOrderMonAn.DAO;

namespace Do_an_nganh_QuanLiOrderMonAn.BUS
{
    public  class QLTaiKhoan
    {
        QLTaiKhoan() { }
        public static QLTaiKhoan instance = new QLTaiKhoan();
        public bool LogIn(string name,string pass,bool isadmin)
        {
            try
            {
                return QLTaiKhoanDAO.instance.LogIn(name, pass, isadmin);
            }catch(Exception)
            {
                
                return false;
            }
            
            
        }
        public void LogOut()
        {
            QLTaiKhoanDAO.instance.LogOut();
        }

    }
}
