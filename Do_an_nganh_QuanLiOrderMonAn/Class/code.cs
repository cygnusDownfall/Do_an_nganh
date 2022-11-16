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
        public static int ResupdateToIntRowsImpact(string doc)
        {
            int i = doc.Length - 1;
            while (doc[i] < '0' || doc[i] > '9') i--;
            int j = i--;
            while (doc[j] > '0' && doc[j] < '9') j--;
            return Convert.ToInt32( doc.Substring(j+1,i-j));
        }
    }
}
