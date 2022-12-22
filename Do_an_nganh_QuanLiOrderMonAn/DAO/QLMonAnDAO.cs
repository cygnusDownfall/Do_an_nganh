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
        public async  Task<List<MonAn>> MenuMonAn()
        {
            return await CSDL.instance.Query<MonAn>("MonAn");
        }
        public List<MonAn> TimMonAn(string properties,string value)
        {
            string filter= string.Format("\"{0}\":\"{1}\"", properties,value);
            return CSDL.instance.Query<MonAn>("MonAn",filter).Result;
        }
        public void ThemMonAn(string tenmonan, int gia,string mota="")
        {
            MonAn ma = new MonAn(tenmonan, gia,mota);
            CSDL.instance.Insert<MonAn>("MonAn", ma);
        }
        public void CapNhatMonAn(string id, string thuoctinh,string value)
        {
            CSDL.instance.UpdateOne("MonAn", "id", id, thuoctinh, value);
        }
        public void XoaMonAn(string tenmon)
        {
            string filter = "\"TenMonAn\":\"" + tenmon + "\"";
            CSDL.instance.RemoveOne("MonAn",filter);
        }

    }
}
