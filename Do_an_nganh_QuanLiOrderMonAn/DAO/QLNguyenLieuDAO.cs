using Do_an_nganh_QuanLiOrderMonAn.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
    public class QLNguyenLieuDAO
    {
        QLNguyenLieuDAO() { }
        public static QLNguyenLieuDAO instance=new QLNguyenLieuDAO();
        public async Task<List<NguyenLieu>> TatCaNguyenLieu()
        {
            return await CSDL.instance.Query<NguyenLieu>("NguyenLieu");
        }
        public List<NguyenLieu> Tim(string properties, string value)
        {
            string filter = string.Format("\"{0}\":\"{1}\"", properties, value);
            return CSDL.instance.Query<NguyenLieu>("NguyenLieu", filter).Result;
        }
        public bool Them(string tenNguyenLieu, string nguonCungCap, string ghiChu)
        {
            NguyenLieu ma=new NguyenLieu(tenNguyenLieu,nguonCungCap,ghiChu);
            return CSDL.instance.Insert("NguyenLieu", ma).Result;
        }
        public void CapNhat(string search, string searchvalue, string propertie, string value)
        {
            CSDL.instance.UpdateOne("NguyenLieu", search, searchvalue, propertie, value);
        }
        public bool Xoa(string tennguyenlieu)
        {
            string filter = "\"TenNguyenLieu\":\"" + tennguyenlieu + "\"";
            return CSDL.instance.RemoveOne("NguyenLieu", filter).Result;
        }
    }
}
