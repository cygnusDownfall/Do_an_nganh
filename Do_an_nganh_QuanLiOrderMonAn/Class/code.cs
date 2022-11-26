using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_nganh_QuanLiOrderMonAn.Class
{
    public class code
    {
        public static string documentToJsonarray(string doc)
        {
            int i = 0, n = doc.Length - 1;
            while (doc[n] != ']') { n--; }
            while (doc[i] != '[' && i < n) { i++; }

            return doc.Substring(i, n - i + 1);
        }
        public static int ResupdateToIntRowsImpact(string doc)
        {
            int i = doc.Length - 1;
            while (doc[i] < '0' || doc[i] > '9') i--;
            int j = i;
            j--;
            while (doc[j] > '0' && doc[j] < '9') j--;
            return Convert.ToInt32(doc.Substring(j + 1, i - j));
        }
        public static string InitHash(int length)
        {
            Random rd = new Random();
            string res = "";
            for (int i = 0; i < length; i++)
            {
                switch (rd.Next(0, 2))
                {
                    case 0:
                        {
                            res += rd.Next(0, 9);
                            break;
                        }
                    case 1:
                        {
                            res += Convert.ToChar(rd.Next(65, 90));
                            break;
                        }
                    case 2:
                        {
                            res += Convert.ToChar(rd.Next(97, 122));
                            break;
                        }
                }
            }
            return res;

        }
        public static string CreateNextID(string id, string hash, int htype)
        {
            string res = "";
            int n = id.Length;
            Random rd = new Random();
            int ihash = 0;
            for (int i = 0; i < n && ihash < n;)
            {
                for (int m = i + htype; i < m; i++)
                {
                    res += id[i];
                }

                for (int m = ihash + htype; ihash < m; ihash++)
                {
                    res += hash[ihash];
                }
            }
            return res.Substring(0, n);
        }
    }
}
