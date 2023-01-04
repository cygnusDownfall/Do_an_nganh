using Do_an_nganh_QuanLiOrderMonAn.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
    internal class QLMenuDAO
    {
        public static QLMenuDAO instance=new QLMenuDAO();
        QLMenuDAO() { }
        public async Task<List<Menu>> DSMenu()
        {
            return await CSDL.instance.Query<Menu>("Menu");
        }
        public List<Menu> Timkiem(string properties, string value)
        {
            string filter = string.Format("\"{0}\":\"{1}\"", properties, value);
            return CSDL.instance.Query<Menu>("Menu", filter).Result;
        }
        public void Them(string tenMenu, List<MonAn> danhSachMonAn, string ghiChu) // ch 
        {
            Menu m = new Menu(tenMenu,danhSachMonAn,ghiChu);
            CSDL.instance.Insert<Menu>("Menu", m);
        }
        public void CapNhat(string search, string searchvalue, string propertie, string value)
        {
            CSDL.instance.UpdateOne("Menu", search, searchvalue, propertie, value);
        }
        public bool Xoa(string ten)
        {
            string filter = "\"TenMenu\":\"" + ten + "\"";
            return CSDL.instance.RemoveOne("MonAn", filter).Result;
        }

    }
}
