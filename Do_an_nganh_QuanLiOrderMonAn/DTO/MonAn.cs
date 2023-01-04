using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    [Serializable]
    public class MonAn
    {
        public string TenMonAn;
        public int Gia;
        public List<NguyenLieu> DanhSachNguyenLieu;
        public string MoTa;
        public MonAn() { }
        public MonAn(string tenmon, int gia, List<NguyenLieu> danhSachNL, string mota)
        {
            DanhSachNguyenLieu= danhSachNL;
            TenMonAn = tenmon;
            Gia = gia;
            MoTa = mota;
        }

    }
}
