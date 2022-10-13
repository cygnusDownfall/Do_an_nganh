using System;
using System.Collections.Generic;
using Do_an_nganh_QuanLiOrderMonAn.DAO;
using Do_an_nganh_QuanLiOrderMonAn.DTO;

namespace Do_an_nganh_QuanLiOrderMonAn.BUS
{
    public  class QLMonAn
    {
        QLMonAn()
        {

        }
        public static  QLMonAn instance = new QLMonAn();
        public List<MonAn> MenuMonAn
        {
            get
            {
                return QLMonAnDAO.Instance.MenuMonAn;
            }
        }
        public void ThemMonAn(string tenmonan, int gia)
        {
            try
            {
                QLMonAnDAO.Instance.ThemMonAn(tenmonan, gia);
                System.Windows.Forms.MessageBox.Show("Da them mon an thanh cong !");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Them mon an khong thanh cong vi loi:"+e.Message);
            }
            
        }
        public void CapNhatMonAn()
        {

        }
        public void XoaMonAn()
        {

        }
    }
}
