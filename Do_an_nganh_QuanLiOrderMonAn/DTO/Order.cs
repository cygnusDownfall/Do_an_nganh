using System;
using System.Collections.Generic;


namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    public class Order
    {
        string id;
        
        MonAn monan;

        int SoLuong;

        DateTime NgayTao;
        public DateTime Ngay { get => NgayTao; }

        public Order(string id)
        {
            this.id = id;
            SoLuong = 1;
            NgayTao = DateTime.Now;
        }
        public Order(string id, DateTime ngaytao)
        {
            this.id = id;
            SoLuong = 1;
            NgayTao = ngaytao;
        }
        public Order(string id, string tenmonan,int sl, DateTime ngaytao)
        {
            this.id = id;

            var data= CSDL.instance.Query("MonAnPhucVu", 
                MongoDB.Driver.Builders<MongoDB.Bson.BsonDocument>.Filter.Eq("Name",tenmonan));

            monan = new MonAn(data[0].GetValue(0).ToString(), 
                tenmonan
                ,Convert.ToInt32(data[0].GetValue(2).ToString()));

            NgayTao = ngaytao;
        }
    }
}
