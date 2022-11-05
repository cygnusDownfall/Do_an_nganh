using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    public class NhanVien
    {
        string _tennhanvien, _tknhanvien;
        public string Tennhanvien { get
            {
                return _tennhanvien;
            } set
            {
                _tennhanvien = value;
            }
        }
        public string TenTKnhanvien
        {
            get
            {
                return _tknhanvien;
            }
        }
        public NhanVien(string tennhanvien, string tknhanvien)
        {
            _tennhanvien = tennhanvien;
            _tknhanvien = tknhanvien;
        }
    }
}
