using System;
using System.Collections.Generic;
using System.IO;

namespace Do_an_nganh_QuanLiOrderMonAn.Model
{
    public static class JSON
    {
        public static List<MonAn> read(string filepath)
        {
            List<MonAn> res = new List<MonAn>();
            using(StreamReader reader=new StreamReader(filepath))
            {

            }
            return res;
        } 
    }
}
