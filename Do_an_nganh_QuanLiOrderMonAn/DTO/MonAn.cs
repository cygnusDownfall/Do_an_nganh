using System;
using System.Collections.Generic;


namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    public class MonAn
    {
        string ID;
        public string id { get => ID; }

        string _TenMonAn;
        public string TenMonAn { get { return _TenMonAn; } set { _TenMonAn = value; } }

        int _gia;
        public int Gia { get { return _gia; } set { _gia = value; } }

        public MonAn(string Id,string tenmon,int gia)
        {
            ID = Id;
            _TenMonAn = tenmon;
            _gia = gia;
        }
    }
}
