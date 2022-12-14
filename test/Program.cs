using System;
using System.Collections.Generic;
using Do_an_nganh_QuanLiOrderMonAn.DTO;
using Do_an_nganh_QuanLiOrderMonAn.BUS;
using System.Runtime.Remoting.Channels;
using Do_an_nganh_QuanLiOrderMonAn.Class;
using System.Collections;
using Newtonsoft.Json;

namespace test
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region testthucong
            //List<MonAn> Menu =QLMonAn.instance.MenuMonAn().Result;
            //for (int i = 0,length=Menu.Count; i < length; i++)
            //{
            //    Console.WriteLine(Menu[i].TenMonAn);
            //}
            ////QLMonAn.instance.ThemMonAn("dui ga nuong", 15000, "dui ga chat luong");ok
            
            //List<MonAn> duiga= QLMonAn.instance.TimMonAn("TenMonAn", "dui ga nuong"); ok
            //QLMonAn.instance.XoaMonAn("dui ga nuong");
            //Console.WriteLine("Tim duoc {0} ket qua:{1}",duiga.Count,duiga[0].Gia);


            //var x=QLOder.danhsachngay;//find with collection have block
            //foreach(var y in x)
            //{
            //    Console.WriteLine(y);   
            //}

            //var res=QLTaiKhoan.instance.LogIn("amon","amon",true);
            //Console.WriteLine(res); 
            //var x = CSDL.instance.RemoveAll("Order").Result;
            //Console.WriteLine(x);
            #endregion
            #region CLI
            if (args.Length < 1) {
                return;
            }
            switch (args[0])
            {
                case "-login":
                    {
                        if (args.Length>1)
                        {
                            QLTaiKhoan.instance.LogIn(args[1], args[2], args[3]=="true");
                            break;
                        }
                        Console.Write("Account:");
                        string name=Console.ReadLine();
                        Console.Write("Password:");
                        string pass= Console.ReadLine();
                        Console.Write("Bạn là :\n1.Quản lý\n2.Nhân viên");
                        string select = Console.ReadLine();
                        QLTaiKhoan.instance.LogIn(name,pass,select=="1");
                        break;
                    }
                case "-c":
                    {
                        CSDL.instance.Insert<object>(args[1], JsonConvert.DeserializeObject(args[2]));
                        break;
                    }
                case "-r":
                    {
                        var x=CSDL.instance.Query<object>(args[1]).Result;
                        foreach(var y in x) { Console.WriteLine(y); }
                        break;
                    }
                case "-u":
                    {
                        CSDL.instance.UpdateOne(args[1], args[2], args[3], args[4], args[5]);
                        break;
                    }
                case "-d":
                    {
                        var x = CSDL.instance.RemoveAll(args[1], args[2]).Result;
                        Console.WriteLine(x);
                        break;
                    }
            }
            #endregion
            //end
            Console.ReadKey();
        }
    }
}
