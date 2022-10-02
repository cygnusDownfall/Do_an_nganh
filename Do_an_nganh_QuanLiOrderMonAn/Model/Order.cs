using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Do_an_nganh_QuanLiOrderMonAn.Model
{
    public class Order
    {
        List<MonAn> dsorder;
        public List<MonAn> DanhSachMonAnDuocOrder { get => dsorder; }
        public Order(List<string> IDs)
        {
            dsorder = new List<MonAn>();
            foreach(var x in IDs)
            {

            }
        }
    }
}
