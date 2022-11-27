using System;
using System.Collections.Generic;

namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    public class Block
    {
        public string _id;
        public string hash;
        
        public virtual Block CreateNext() 
        {
           Block block = new Block();
           hash = InitHash(12);
           block._id = CreateNextID(_id,hash, new Random().Next(1, 4));
            return block;
        }
        public Block() { }
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
