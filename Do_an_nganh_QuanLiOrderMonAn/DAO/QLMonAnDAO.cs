using System;
using System.Collections.Generic;
using Do_an_nganh_QuanLiOrderMonAn.DTO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
    public class QLMonAnDAO
    {
        QLMonAnDAO() { }
        public static QLMonAnDAO Instance = new QLMonAnDAO();
        public async  Task<List<MonAn>> TatCaMonAn()
        {
            return await CSDL.instance.Query<MonAn>("MonAn");
        }
        public List<MonAn> TimMonAn(string properties,string value)
        {
            string filter= string.Format("\"{0}\":\"{1}\"", properties,value);
            return CSDL.instance.Query<MonAn>("MonAn",filter).Result;
        }
        public void ThemMonAn(string tenmonan, int gia,List<NguyenLieu> nguyenlieus,string mota="")
        {
            MonAn ma = new MonAn(tenmonan, gia,nguyenlieus,mota);
            CSDL.instance.Insert<MonAn>("MonAn", ma);
        }
        public void CapNhatMonAn(string search, string searchvalue,string propertie,string value)
        {
            CSDL.instance.UpdateOne("MonAn",search,searchvalue, propertie, value);
        }
        public bool XoaMonAn(string tenmon)
        {
            string filter = "\"TenMonAn\":\"" + tenmon + "\"";
            return CSDL.instance.RemoveOne("MonAn",filter).Result;
        }

    }
}
