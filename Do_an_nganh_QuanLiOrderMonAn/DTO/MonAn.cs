using System;
using System.Collections.Generic;


namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    [Serializable]
    public class MonAn
    {
        public string _id;
        public string TenMonAn;
        public int Gia;
        public string MoTa;
        public MonAn(string tenmon, int gia, string mota)
        {
            TenMonAn= tenmon;
            Gia= gia;
            MoTa= mota;
        }

    }
}
