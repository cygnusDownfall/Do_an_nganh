using System;
using System.Collections.Generic;


namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    [Serializable]
    public class Order:Block
    {
        public string TenMonAn;
        public string NguoiPhucVu;

        public int SoLuong;

        public DateTime NgayTao;
        public int Ban;

        public Order()
        {
            SoLuong = 1;
            NgayTao = DateTime.Now;
        }
        public Order( DateTime ngaytao)
        {
            SoLuong = 1;
            NgayTao = ngaytao;
        }
        public Order(string _id,string tenmonan,int sl, DateTime ngaytao)
        {
            this._id= _id;
            SoLuong = sl;
            NgayTao = ngaytao;
        }
       
    }
}
