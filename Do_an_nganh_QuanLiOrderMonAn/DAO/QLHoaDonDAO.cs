using Do_an_nganh_QuanLiOrderMonAn.DTO;
using Do_an_nganh_QuanLiOrderMonAn.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
    public class QLHoaDonDAO
    {
       public static QLHoaDonDAO instance=new QLHoaDonDAO();
       QLHoaDonDAO() { }
        public List<string> danhsachtheongay
        {
            get
            {
                List<HoaDon> list = CSDL.instance.Query<HoaDon>("HoaDon").Result;
                List<string> result = new List<string>();
                Sapxep.heapSort<HoaDon>(list, list.Count, (a, b) =>
                {
                    TimeSpan timeSpan = (a.NgayTao - b.NgayTao);
                    return int.Parse(timeSpan.TotalSeconds.ToString());
                });
                for (int i = 0, length = list.Count; i < length; i++)
                {
                    result[i] = list[i].TenNhanVienThanhToan + " " + list[i].NgayTao;
                }
                return result;
            }
        }
        public List<HoaDon> Timkiem(string properties, string value)
        {
            string filter = string.Format("\"{0}\":\"{1}\"", properties, value);
            return CSDL.instance.Query<HoaDon>("HoaDon", filter).Result;
        }
        public void Them(string id, string tenNhanVienThanhToan, double tongTien, string ghiChu) // ch 
        {
            HoaDon m = new HoaDon(id,tenNhanVienThanhToan,tongTien,ghiChu);
            CSDL.instance.Insert<HoaDon>("HoaDon", m);
        }
        public void CapNhat(string search, string searchvalue, string propertie, string value)
        {
            CSDL.instance.UpdateOne("HoaDon", search, searchvalue, propertie, value);
        }
        public bool Xoa(string id)
        {
            string filter = "\"_id\":\"" + id + "\"";
            return CSDL.instance.RemoveOne("HoaDon", filter).Result;
        }

    }
}
