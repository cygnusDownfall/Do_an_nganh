using System;
using System.Collections.Generic;
using Do_an_nganh_QuanLiOrderMonAn.DTO;

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
                return CSDL.instance.LayDanhSachOrder();
            }
        }
        public List<string> danhsachtheongay
        {
            get
            {
                List<string> list = new List<string>();
                var x = CSDL.instance.GetAllInCollection("Order");
                foreach (var y in x)
                {
                    list.Add(y.GetValue(3).AsDateTime.ToString());
                }
                return list;

            }
        }
        public List<string> danhsachtheoban
        {
            get
            {
                List<string> list = new List<string>();
                var x = CSDL.instance.GetAllInCollection("NhanVien");
                foreach (var y in x)
                {
                    list.Add(y.GetValue(1).AsString);
                }
                return list;
            }
        }
        public List<Order> TimOrder(MongoDB.Driver.FilterDefinition<MongoDB.Bson.BsonDocument> filter)
        {
            return CSDL.instance.LayDanhSachOrder(filter);
        }
        public void SuaThongTinOrder(string tenorder, string thuoctinh, string value)
        {
            CSDL.instance.Update("Order", tenorder, thuoctinh, value);
        }
        public void XoaOrder(string tenOrder)
        {
            CSDL.instance.Remove("Order", tenOrder);
        }
    }
}
