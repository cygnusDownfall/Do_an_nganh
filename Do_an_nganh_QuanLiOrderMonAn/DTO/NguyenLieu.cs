using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    [Serializable]
    public class NguyenLieu
    {
        public string TenNguyenLieu;
        public string NguonCungCap;
        public string GhiChu;
        public NguyenLieu() { }
        public NguyenLieu(string tenNguyenLieu, string nguonCungCap, string ghiChu)
        {
            TenNguyenLieu = tenNguyenLieu;
            NguonCungCap = nguonCungCap;
            GhiChu = ghiChu;
        }
    }
}
