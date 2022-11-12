using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_nganh_QuanLiOrderMonAn.Class
{
    public class code
    {
        public static string documentToJsonarray(string doc)
        {
            int i = 0, n = doc.Length-1;
            while (doc[n] != ']') { n--; }
            while (doc[i]!='['&&i<n) { i++; }
            
            return doc.Substring(i,n-i+1);
        }
    }
}
