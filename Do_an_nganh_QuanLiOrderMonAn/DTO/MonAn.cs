using System;
using System.Text.Json.Serialization;

namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    [Serializable]
    public class MonAn
    {

        public string _id;
       
        public string TenMonAn;
        public int Gia;
        public string MoTa;
        public MonAn() { }
        public MonAn(string id,string tenmon, int gia, string mota)
        {
            _id = id;
            TenMonAn = tenmon;
            Gia = gia;
            MoTa = mota;
        }
       
    }
}
