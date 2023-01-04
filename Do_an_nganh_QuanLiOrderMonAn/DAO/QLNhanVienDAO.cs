﻿using Do_an_nganh_QuanLiOrderMonAn.DTO;
using System.Collections.Generic;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
     class QLNhanVienDAO
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
        public void Them(int thu, int tuan, int ca, string maNhanVien) // ch 
        {
            LichLam m = new LichLam(thu, tuan, ca, maNhanVien);
            CSDL.instance.Insert<LichLam>("LichLam", m);
        }
        public void CapNhat(string search, string searchvalue, string propertie, string value)
        {
            CSDL.instance.UpdateOne("LichLam", search, searchvalue, propertie, value);
        }
        public bool Xoa(int thu, int tuan, int ca)
        {
            string filter = "\"Thu\":\"" + thu + "\"" + ",\"Tuan\":\"" + tuan + "\"" + "\"Ca\":\"" + ca + "\"";
            return CSDL.instance.RemoveOne("LichLam", filter).Result;
        }


    }
}
