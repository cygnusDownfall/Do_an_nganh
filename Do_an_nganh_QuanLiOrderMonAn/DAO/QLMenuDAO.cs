using Do_an_nganh_QuanLiOrderMonAn.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
    public class QLMenuDAO
    {
        public static QLMenuDAO instance = new QLMenuDAO();
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
        public bool Them(string tenMenu, List<MonAn> danhSachMonAn, string ghiChu) // ch 
        {
            Menu m = new Menu(tenMenu, danhSachMonAn, ghiChu);
            return CSDL.instance.Insert<Menu>("Menu", m).Result;
        }
        public void CapNhat(string search, string searchvalue, string propertie, string value)
        {
            CSDL.instance.UpdateOne("Menu", search, searchvalue, propertie, value);
        }
        public bool Xoa(string ten)
        {
            string filter = "\"TenMenu\":\"" + ten + "\"";
            return CSDL.instance.RemoveOne("Menu", filter).Result;
        }

    }
}
