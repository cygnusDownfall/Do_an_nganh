using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    [Serializable]
    public class Menu
    {
        public string TenMenu;
        public List<MonAn> DanhSachMonAn;
        public string GhiChu;
        public Menu(string tenMenu, List<MonAn> danhSachMonAn, string ghiChu)
        {
            TenMenu = tenMenu;
            DanhSachMonAn = danhSachMonAn;
            GhiChu = ghiChu;
        }
    }
}
