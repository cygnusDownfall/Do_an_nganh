using System;
using System.Collections.Generic;
using Do_an_nganh_QuanLiOrderMonAn.DTO;
using Do_an_nganh_QuanLiOrderMonAn.Class;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
    public class QLOrderDAO
    {
        QLOrderDAO() { }
        public static QLOrderDAO instance = new QLOrderDAO();
        
        public List<Order> DanhSachOrder
        {
            get
            {
                return CSDL.instance.Query<Order>("Order").Result;
            }
        }


        public List<Order> Timkiem(string properties, string value)
        {
            string filter = string.Format("\"{0}\":\"{1}\"", properties, value);
            return CSDL.instance.Query<Order>("Order", filter).Result;
        }
        public void Them(string tenMonAn, string maNhanVien, int soLuong, int ban, string maHoaDon) // ch 
        {
            Order m = new Order(tenMonAn,maNhanVien,soLuong,ban,maHoaDon);
            CSDL.instance.Insert<Order>("Order", m);
        }
        public void CapNhat(Order newvalue)
        {
            CSDL.instance.UpdateOne<Order>("Order",newvalue);
        }
        public bool Xoa(Order value)
        {
            return CSDL.instance.RemoveOne<Order>("Order", value).Result;
        }

    }
}
