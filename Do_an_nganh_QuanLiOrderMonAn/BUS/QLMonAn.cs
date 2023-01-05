using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public async Task<List<MonAn>> MenuMonAn()
        {
            return await QLMonAnDAO.Instance.TatCaMonAn();
        }
        public List<MonAn> TimMonAn(string properties, string value)
        {
            try
            {
                return QLMonAnDAO.Instance.TimMonAn(properties,value);
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Khong tim thay mon an :" + e.Message);
                return null;
               
            }
        }
        public void ThemMonAn(string tenmonan, int gia,string mota="")
        {
            try
            {
                QLMonAnDAO.Instance.ThemMonAn(tenmonan, gia,null,mota);
                MessageBox.Show("Da them mon an thanh cong !");
            }
            catch (Exception e)
            {
               MessageBox.Show("Them mon an khong thanh cong vi loi:"+e.Message);
            }
            
        }
        public void CapNhatMonAn(string tenmonan,string thuoctinh,string value)
        {
            try
            {
                QLMonAnDAO.Instance.CapNhatMonAn("TenMonAn",tenmonan,thuoctinh,value);
                MessageBox.Show("Da cap nhat mon an thanh cong !");
            }
            catch (Exception e)
            {
                MessageBox.Show("Cap nhat mon an khong thanh cong vi loi:" + e.Message);
            }
        }
        public void XoaMonAn(string tenmon)
        {
            try
            {
                var x=QLMonAnDAO.Instance.XoaMonAn(tenmon);
                MessageBox.Show("Da xoa mon an thanh cong !");
            }
            catch (Exception e)
            {
                MessageBox.Show("Xoa mon an khong thanh cong vi loi:" + e.Message);
            }
        }
    }
}
