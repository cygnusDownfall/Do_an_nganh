using Do_an_nganh_QuanLiOrderMonAn.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
    internal class QLNguyenLieu
    {
        public async Task<List<NguyenLieu>> TatCaNguyenLieu()
        {
            return await CSDL.instance.Query<NguyenLieu>("NguyenLieu");
        }
        public List<NguyenLieu> TimMonAn(string properties, string value)
        {
            string filter = string.Format("\"{0}\":\"{1}\"", properties, value);
            return CSDL.instance.Query<NguyenLieu>("NguyenLieu", filter).Result;
        }
        public void ThemMonAn(string tenmonan, int gia, List<NguyenLieu> nguyenlieus, string mota = "")
        {
            MonAn ma = new MonAn(tenmonan, gia, nguyenlieus, mota);
            CSDL.instance.Insert<MonAn>("MonAn", ma);
        }
        public void CapNhatMonAn(string search, string searchvalue, string propertie, string value)
        {
            CSDL.instance.UpdateOne("NguyenLieu", search, searchvalue, propertie, value);
        }
        public bool XoaMonAn(string tenmon)
        {
            string filter = "\"TenMonAn\":\"" + tenmon + "\"";
            return CSDL.instance.RemoveOne("MonAn", filter).Result;
        }
    }
}
