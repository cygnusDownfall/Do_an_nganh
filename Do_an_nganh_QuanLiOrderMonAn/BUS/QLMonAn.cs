using System;
using System.Collections.Generic;
using Do_an_nganh_QuanLiOrderMonAn.DAO;
using Do_an_nganh_QuanLiOrderMonAn.DTO;
using MongoDB.Bson;
using MongoDB.Driver;

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
        public List<MonAn> TimMonAn(string properties, string value)
        {
            try
            {
                return QLMonAnDAO.Instance.TimMonAn(properties,value);
                
            }
            catch (Exception e)
            {
                return null;
                System.Windows.Forms.MessageBox.Show("Khong tim thay mon an :" + e.Message);
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
        public void CapNhatMonAn(string tenmonan,string thuoctinh, int gia)
        {
            try
            {
                QLMonAnDAO.Instance.CapNhatMonAn(tenmonan,thuoctinh, gia.ToString());
                System.Windows.Forms.MessageBox.Show("Da cap nhat mon an thanh cong !");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Cap nhat mon an khong thanh cong vi loi:" + e.Message);
            }
        }
        public void XoaMonAn(string tenmon)
        {
            try
            {
                QLMonAnDAO.Instance.XoaMonAn(tenmon);
                System.Windows.Forms.MessageBox.Show("Da xoa mon an thanh cong !");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Xoa mon an khong thanh cong vi loi:" + e.Message);
            }
        }
    }
}
