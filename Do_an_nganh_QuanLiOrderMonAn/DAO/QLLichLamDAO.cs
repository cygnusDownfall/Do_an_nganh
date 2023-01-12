using Do_an_nganh_QuanLiOrderMonAn.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
    public class QLLichLamDAO
    {
        QLLichLamDAO() { }
        public static QLLichLamDAO instance= new QLLichLamDAO();   
        public List<LichLam> Timkiem(string properties, string value)
        {
            string filter = string.Format("\"{0}\":\"{1}\"", properties, value);
            return CSDL.instance.Query<LichLam>("LichLam", filter).Result;
        }
        public bool Them(int thu, int tuan, int ca, string maNhanVien) // ch 
        {
            LichLam m = new LichLam(thu,tuan, ca, maNhanVien);
           return CSDL.instance.Insert<LichLam>("LichLam", m).Result;
        }
        public bool CapNhat(string search, string searchvalue, string propertie, string value)
        {
            return CSDL.instance.UpdateOne("LichLam", search, searchvalue, propertie, value);
        }
        public bool Xoa(int thu, int tuan, int ca)
        {
            string filter = "\"Thu\":\"" + thu + "\""+",\"Tuan\":\"" + tuan + "\""+"\"Ca\":\"" +ca + "\"";
            return CSDL.instance.RemoveOne("LichLam", filter).Result;
        }

    }
}
