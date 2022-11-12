using System;
using System.Collections.Generic;


namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    [Serializable]
    public class Order
    {
        public string _id;

        public string TenMonAn;

        public int SoLuong;

        public DateTime NgayTao;
       

        public Order(string id)
        {
            _id = id;
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

            SoLuong = sl;
            NgayTao = ngaytao;
        }
    }
}
