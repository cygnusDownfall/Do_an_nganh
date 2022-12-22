using System;
using System.Collections.Generic;
using Do_an_nganh_QuanLiOrderMonAn.DTO;
using Do_an_nganh_QuanLiOrderMonAn.DAO;
using Do_an_nganh_QuanLiOrderMonAn.BUS;
using System.Runtime.Remoting.Channels;
using System.Collections;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MonAn> Menu =QLMonAn.instance.MenuMonAn().Result;
            for (int i = 0,length=Menu.Count; i < length; i++)
            {
                Console.WriteLine(Menu[i].TenMonAn);
            }
            //QLMonAn.instance.ThemMonAn("dui ga nuong", 15000, "dui ga chat luong");
            QLMonAn.instance.CapNhatMonAn("dui ga nuong", "gia", "20000");
            List<MonAn> duiga= QLMonAn.instance.TimMonAn("TenMonAn", "dui ga nuong");
            QLMonAn.instance.XoaMonAn("dui ga nuong");
            Console.WriteLine("Tim duoc {0} ket qua:{1}",duiga.Count,duiga[0].Gia);



            var x=QLOder.danhsachngay;//find with collection have block
            foreach(var y in x)
            {
                Console.WriteLine(y);   
            }
            //end
            Console.ReadKey();
        }
    }
}
