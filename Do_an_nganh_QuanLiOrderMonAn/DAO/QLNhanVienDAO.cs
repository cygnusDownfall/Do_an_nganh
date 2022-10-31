using Do_an_nganh_QuanLiOrderMonAn.DTO;
using System.Collections.Generic;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
     class QLNhanVienDAO
    {
        public static List<string> danhsachnhanvien
        {
            get
            {
                List<string> list = new List<string>();
                var x = CSDL.instance.GetAllInCollection("NhanVien");
                foreach (var y in x)
                {
                    list.Add(y.GetValue(1).AsString);
                }
                return list;
            }
        }
       
    }
}
