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
     
        public List<string> danhsachtheoban
        {
            get
            {
                return null;
            }
        }
        public List<Order> TimOrder(MongoDB.Driver.FilterDefinition<MongoDB.Bson.BsonDocument> filter)
        {
            return null;
        }
        public void SuaThongTinOrder(string tenorder, string thuoctinh, string value)
        {
           
        }
        public void XoaOrder(string tenOrder)
        {
          
        }
    }
}
