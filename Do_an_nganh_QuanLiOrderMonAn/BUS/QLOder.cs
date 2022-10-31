using System;
using System.Collections.Generic;
using Do_an_nganh_QuanLiOrderMonAn.DAO;

namespace Do_an_nganh_QuanLiOrderMonAn.BUS
{
    public class QLOder
    {
        public static List<string> danhsachngay
        {
            get
            {
                
                return QLOrderDAO.instance.danhsachtheongay;
             
            }
        }
    }
}
