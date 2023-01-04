using System;
using System.Collections.Generic;


namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    [Serializable]
    public class Order:Block
    {
        public string TenMonAn;
        public string MaNhanVien;

        public int SoLuong;

        public int Ban;

        public string MaHoaDon;
        public Order() { }
        public Order(string tenMonAn, string maNhanVien, int soLuong, int ban, string maHoaDon)
        {
            TenMonAn = tenMonAn;
            MaNhanVien = maNhanVien;
            SoLuong = soLuong;
            Ban = ban;
            MaHoaDon = maHoaDon;
        }
    }
}
