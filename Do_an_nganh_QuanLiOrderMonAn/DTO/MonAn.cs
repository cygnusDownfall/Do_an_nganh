using System;
using System.Text.Json.Serialization;

namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    [Serializable]
    public class MonAn
    {
        string mamonan;
        public string MaMonAn { get => mamonan; }
        public string TenMonAn;
        public int Gia;
        public string MoTa;
        public MonAn(string tenmon, int gia, string mota)
        {
            TenMonAn= tenmon;
            Gia= gia;
            MoTa= mota;
        }
        [JsonConstructor]
        public MonAn(object _id,string tenmon, int gia, string mota)
        {
            mamonan=_id.ToString();
            TenMonAn = tenmon;
            Gia = gia;
            MoTa = mota;
        }
    }
}
