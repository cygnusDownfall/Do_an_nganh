using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    [Serializable]
    public class NhanVien
    {
        public string _id;
        public string TenNhanVien;
        public string NgaySinh;
        public string DiaChi;
        public string SoDienThoai;
        public NhanVien() { }
        public NhanVien(string id, string tenNhanVien, string ngaySinh, string diaChi, string dienThoai)
        {
            _id = id;
            TenNhanVien = tenNhanVien;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            SoDienThoai = dienThoai;
        }
    }
}
