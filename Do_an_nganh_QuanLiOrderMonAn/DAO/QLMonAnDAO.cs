using System;
using System.Collections.Generic;
using Do_an_nganh_QuanLiOrderMonAn.DTO;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
    public  class QLMonAnDAO
    {
        List<MonAn> MonAnPhucVu;
        QLMonAnDAO() { }
        public static QLMonAnDAO Instance = new QLMonAnDAO();
        public List<MonAn> MenuMonAn { get
            {
                if (MonAnPhucVu == null)
                {
                    MonAnPhucVu = CSDL.instance.LayMenuMonAn();
                }
                return MonAnPhucVu;
            } 
        }
        public void  ThemMonAn()
        {

        }
        public void CapNhatMonAn()
        {

        }
        public void XoaMonAn()
        {

        }
        
    }
}
