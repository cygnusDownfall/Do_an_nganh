using System;
using System.Collections.Generic;

namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    public class Block
    {
        public string id;
        public string hash;
        
        private static int numhash=20;
        
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
        
    }
}
