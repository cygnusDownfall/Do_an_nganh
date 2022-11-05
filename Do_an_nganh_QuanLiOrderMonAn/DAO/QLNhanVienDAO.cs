using Do_an_nganh_QuanLiOrderMonAn.DTO;
using System.Collections.Generic;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
     class QLNhanVienDAO
    {
        QLNhanVienDAO()
        {

        }
        public static QLNhanVienDAO instance = new QLNhanVienDAO();


        public List<string> danhsachnhanvien
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
        public void ThemNhanVien(DTO.NhanVien nv)
        {

        }
        public void CapnhatNhanVien(DTO.NhanVien nv)
        {

        }
        public void XoaNhanVien(DTO.NhanVien nv)
        {

        }

    }
}
