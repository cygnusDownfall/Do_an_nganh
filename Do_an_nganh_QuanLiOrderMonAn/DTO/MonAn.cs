using System;
using System.Collections.Generic;


namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    [Serializable]
    public class MonAn
    {
        public string _id;
        public string Tenmonan;
        public int Gia;
        public string Mota;
        public MonAn(string tenmon, int gia, string mota)
        {
            Tenmonan= tenmon;
            Gia= gia;
            Mota= mota;
        }

    }
}
