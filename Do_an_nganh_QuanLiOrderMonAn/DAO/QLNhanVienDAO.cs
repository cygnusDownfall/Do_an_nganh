using Do_an_nganh_QuanLiOrderMonAn.DTO;
using System.Collections.Generic;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
    public class QLNhanVienDAO
    {
        QLNhanVienDAO()
        {

        }
        public static QLNhanVienDAO instance = new QLNhanVienDAO();
        public List<NhanVien> DanhSachNhanVien
        {
            get {
                return CSDL.instance.Query<NhanVien>("NhanVien").Result;
            }
        }

        public List<NhanVien> Timkiem(string properties, string value)
        {
            string filter = string.Format("\"{0}\":\"{1}\"", properties, value);
            return CSDL.instance.Query<NhanVien>("NhanVien", filter).Result;
        }
        public bool Them(NhanVien nv) // ch 
        {
            return CSDL.instance.Insert<NhanVien>("NhanVien",nv).Result;
        }
        public void CapNhat(string search, string searchvalue, string propertie, string value)
        {
            CSDL.instance.UpdateOne("NhanVien", search, searchvalue, propertie, value);
        }
        public bool Xoa(string manhanvien)
        {
            string filter = "\"_id\":\"" + manhanvien + "\"";
            return CSDL.instance.RemoveOne("LichLam", filter).Result;
        }


    }
}
