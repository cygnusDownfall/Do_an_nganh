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
        public Order( DateTime ngaytao)
        {
            SoLuong = 1;
            NgayTao = ngaytao;
        }
        public Order(string tenmonan,int sl, DateTime ngaytao)
        {
            var data= CSDL.instance.Query("MonAn", 
                MongoDB.Driver.Builders<MongoDB.Bson.BsonDocument>.Filter.Eq("Name",tenmonan));
            if (data != null&&data.Count!=0)
            {
                monan = new MonAn(
                    tenmonan
                    , data[0].GetValue(2).AsInt32, data[0].GetValue(3).AsString);
            }
            else System.Windows.Forms.MessageBox.Show(String.Format("Khong tim thay mon an nao co ten la; {0} !", tenmonan));
            NgayTao = ngaytao;
        }
    }
}
