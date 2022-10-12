using System;
using System.Collections.Generic;
using Do_an_nganh_QuanLiOrderMonAn.DTO;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
    public class QLOrderDAO
    {
        List<Order> dsOrder;
        public List<Order> DanhSachOrder
        {
            get
            {
                if (dsOrder == null)
                {
                    dsOrder = CSDL.instance.LayDanhSachOrder();
                }
                return dsOrder;
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
