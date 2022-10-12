using System;
using System.Collections.Generic;
using Do_an_nganh_QuanLiOrderMonAn.DTO;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
    public class QLMonAnDAO
    {
        List<MonAn> MonAnPhucVu;
        QLMonAnDAO() { }
        public static QLMonAnDAO Instance = new QLMonAnDAO();
        public List<MonAn> MenuMonAn
        {
            get
            {
                if (MonAnPhucVu == null)
                {
                    MonAnPhucVu = CSDL.instance.LayMenuMonAn();
                }
                return MonAnPhucVu;
            }
        }
        public List<MonAn> TimMonAn(MongoDB.Driver.FilterDefinition<MongoDB.Bson.BsonDocument> filter)
        {
            return CSDL.instance.LayMenuMonAn(filter);
        }
        public void ThemMonAn(string tenmonan, int gia)
        {

            CSDL.instance.Insert("MonAnPhucVu",
                new MongoDB.Bson.BsonDocument
                {
                    {"Name",tenmonan },
                    {"Cost",gia }
                }
            );
        }
        public void CapNhatMonAn(string tenmonan, string thuoctinh, string value)
        {
            CSDL.instance.Update("MonAnPhucVu", tenmonan, thuoctinh, value);
        }
        public void XoaMonAn(string tenmon)
        {
            CSDL.instance.Remove("MonAnPhucVu", tenmon);
        }

    }
}
