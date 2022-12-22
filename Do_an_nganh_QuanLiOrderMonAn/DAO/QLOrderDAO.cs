using System;
using System.Collections.Generic;
using _020101125;
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
                return CSDL.instance.Query<Order>("Order").Result;
            }
        }
        public List<string> danhsachtheongay
        {
            get
            {
                List<Order> list = CSDL.instance.Query<Order>("Order").Result;
                List<string> result = new List<string>();
                Sapxep.heapSort<Order>(list,list.Count, (a, b) =>
                {
                    TimeSpan timeSpan = (a.NgayTao - b.NgayTao);
                    return int.Parse(timeSpan.TotalSeconds.ToString());
                });
                for (int i = 0,length=list.Count; i < length; i++)
                {
                    result[i]= list[i].NguoiPhucVu +" "+ list[i].NgayTao;
                }
                return result;
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
