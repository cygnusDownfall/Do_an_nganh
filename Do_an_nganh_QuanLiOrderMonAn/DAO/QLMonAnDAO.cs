using System;
using System.Collections.Generic;
using Do_an_nganh_QuanLiOrderMonAn.DTO;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
    public class QLMonAnDAO
    {
        QLMonAnDAO() { }
        public static QLMonAnDAO Instance = new QLMonAnDAO();
        public  List<MonAn> MenuMonAn
        {
            get
            {
                return CSDL.instance.Query<MonAn>("MonAn").Result;
            }
        }
        public List<MonAn> TimMonAn(string properties,string value)
        {
            return null;
        }
        public void ThemMonAn(string tenmonan, int gia)
        {

        }
        public void CapNhatMonAn(string tenmonan, string thuoctinh, string value)
        {
            
        }
        public void XoaMonAn(string tenmon)
        {
            
        }

    }
}
