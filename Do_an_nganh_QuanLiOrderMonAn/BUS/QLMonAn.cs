using System;
using System.Collections.Generic;
using Do_an_nganh_QuanLiOrderMonAn.DAO;
using Do_an_nganh_QuanLiOrderMonAn.DTO;

namespace Do_an_nganh_QuanLiOrderMonAn.BUS
{
    internal class QLMonAn
    {
        public List<MonAn> MonAnPhucVu
        {
            get
            {
                return QLMonAnDAO.MonAnPhucVu;
            }
        }
        public void ThemMonAn()
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
