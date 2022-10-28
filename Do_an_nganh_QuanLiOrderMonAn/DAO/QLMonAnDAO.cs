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
        public List<MonAn> MenuMonAn
        {
            get
            {
                    return CSDL.instance.LayMenuMonAn();
            }
        }
        public List<MonAn> TimMonAn(string properties,string value)
        {
                var filter = Builders<BsonDocument>.Filter.Eq(properties, value);
                return CSDL.instance.LayMenuMonAn(filter);
        }
        public void ThemMonAn(string tenmonan, int gia)
        {

            CSDL.instance.Insert("MonAn",
                new MongoDB.Bson.BsonDocument
                {
                    {"Name",tenmonan },
                    {"Cost",gia }
                }
            );
        }
        public void CapNhatMonAn(string tenmonan, string thuoctinh, string value)
        {
            CSDL.instance.Update("MonAn", tenmonan, thuoctinh, value);
        }
        public void XoaMonAn(string tenmon)
        {
            CSDL.instance.Remove("MonAn", tenmon);
        }

    }
}
