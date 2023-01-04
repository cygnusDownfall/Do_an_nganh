using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    [Serializable]
    public class HoaDon
    {
        public string _id;
        public string TenNhanVienThanhToan;
        public double TongTien;

        public DateTime NgayTao;
        public string GhiChu;
        public HoaDon() { }
        public HoaDon(string id, string tenNhanVienThanhToan, double tongTien, string ghiChu)
        {
            _id = id;
            TenNhanVienThanhToan = tenNhanVienThanhToan;
            TongTien = tongTien;
            GhiChu = ghiChu;
        }
    }
}
