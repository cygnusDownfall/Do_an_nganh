using System;
using System.Collections.Generic;


namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    public class Order
    {
        string id;
        List<MonAn> dsorder;
        public List<MonAn> DanhSachMonAnDuocOrder { get => dsorder; }
        DateTime NgayTao;
        public DateTime Ngay { get => NgayTao; }
        public int tongtien
        {
            get
            {
                if(dsorder == null) { return 0; }
                int tong = 0;
                foreach(var x in dsorder)
                {
                    tong += x.Gia;
                }
                return tong;
            }
        }
        public Order(string id,List<MonAn> mon)
        {
            this.id = id;
            dsorder = mon;
            NgayTao = DateTime.Now;
        }
        public Order(string id, List<MonAn> mon, DateTime ngaytao)
        {
            this.id = id;
            dsorder = mon;
            NgayTao = ngaytao;
        }
    }
}
