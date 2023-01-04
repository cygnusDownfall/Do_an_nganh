using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    [Serializable]
    public class LichLam
    {
        public LichLam() { }
        public int Thu { get=>Thu; set { 
            if(value< 2||value>7) throw new ArgumentOutOfRangeException("value"); Thu = value;
            } }
        public int Tuan
        {
            get => Tuan; 
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("value"); Thu = value;
            }
        }
        public int Ca;
        public string MaNhanVien;
        public LichLam(int thu, int tuan, int ca, string maNhanVien)
        {
            Thu = thu;
            Tuan = tuan;
            Ca = ca;
            MaNhanVien = maNhanVien;
        }
    }
}
