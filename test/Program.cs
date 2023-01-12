using System;
using Do_an_nganh_QuanLiOrderMonAn.DTO;
using Do_an_nganh_QuanLiOrderMonAn.BUS;
using Do_an_nganh_QuanLiOrderMonAn.DAO;

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

            // QLNhanVienDAO.instance.Them(new NhanVien("NV003","A",DateTime.Parse("17/07/2004"),"Binh duong","0000000"));
            #endregion

            #region CLI
            if (args.Length < 1)
            {
                return;
            }
            switch (args[0])
            {
                case "-login":
                    {
                        if (args.Length > 1)
                        {
                            QLTaiKhoan.instance.LogIn(args[1], args[2], args[3] == "true");
                            break;
                        }
                        Console.Write("Account:");
                        string name = Console.ReadLine();
                        Console.Write("Password:");
                        string pass = Console.ReadLine();
                        Console.Write("Bạn là :\n1.Quản lý\n2.Nhân viên\n");
                        string select = Console.ReadLine();
                        bool res = QLTaiKhoan.instance.LogIn(name, pass, select == "1");
                        Console.WriteLine(res);
                        break;
                    }
                case "-c":
                    {
                        switch (args[1])
                        {
                            case "Order":
                                {
                                    try
                                    {
                                        if(QLOrderDAO.instance.Them(args[2], args[3],Convert.ToInt32( args[4]), Convert.ToInt32(args[5]), args[6]))
                                        {
                                            Console.WriteLine("Them thanh cong!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Them that bai!");
                                        }

                                    }
                                    catch
                                    {
                                        Console.WriteLine("loi nhap du lieu!");
                                    }
                                    break;


                                }
                            case "MonAn":
                                {
                                    try
                                    {
                                        if (QLMonAnDAO.instance.Them(args[2], Convert.ToInt32(args[3]),null, args[4]))
                                        {
                                            Console.WriteLine("Them thanh cong!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Them that bai!");
                                        }

                                    }
                                    catch
                                    {
                                        Console.WriteLine("loi nhap du lieu!");
                                    }
                                    break;

                                }
                            case "NhanVien":
                                {
                                    try
                                    {
                                        if (QLNhanVienDAO.instance.Them(new NhanVien(args[2], args[3], DateTime.Parse(args[4]), args[5], args[6]))) 
                                        {
                                            Console.WriteLine("Them thanh cong!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Them that bai!");
                                        }

                                    }
                                    catch
                                    {
                                        Console.WriteLine("loi nhap du lieu!");
                                    }
                                    break;
                                }
                            case "NguyenLieu":
                                {
                                    try
                                    {
                                        if (QLNguyenLieuDAO.instance.Them(args[2], args[3], args[4]))
                                        {
                                            Console.WriteLine("Them thanh cong!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Them that bai!");
                                        }

                                    }
                                    catch
                                    {
                                        Console.WriteLine("loi nhap du lieu!");
                                    }
                                    break;
                                }
                            case "HoaDon":
                                {
                                    try
                                    {
                                        if (QLHoaDonDAO.instance.Them(args[2],args[3], Convert.ToDouble(args[4]), args[6]))
                                        {
                                            Console.WriteLine("Them thanh cong!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Them that bai!");
                                        }

                                    }
                                    catch
                                    {
                                        Console.WriteLine("loi nhap du lieu!");
                                    }
                                    break;
                                }
                            case "LichLam":
                                {
                                    try
                                    {
                                        if (QLLichLamDAO.instance.Them(Convert.ToInt32(args[2]), Convert.ToInt32(args[3]), Convert.ToInt32(args[4]), args[5]))
                                        {
                                            Console.WriteLine("Them thanh cong!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Them that bai!");
                                        }

                                    }
                                    catch
                                    {
                                        Console.WriteLine("loi nhap du lieu!");
                                    }
                                    break;
                                }
                            case "Menu":
                                {
                                    try
                                    {
                                        if (QLMenuDAO.instance.Them(args[2], null, args[3]))
                                        {
                                            Console.WriteLine("Them thanh cong!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Them that bai!");
                                        }

                                    }
                                    catch
                                    {
                                        Console.WriteLine("loi nhap du lieu!");
                                    }
                                    break;
                                }
                            case "Account":
                                {
                                    try
                                    {
                                        if (QLTaiKhoanDAO.instance.Them(args[2], args[3], null, args[6]=="true"))
                                        {
                                            Console.WriteLine("Them thanh cong!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Them that bai!");
                                        }

                                    }
                                    catch
                                    {
                                        Console.WriteLine("loi nhap du lieu!");
                                    }
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("khong tim thay!");
                                    break;
                                }

                        }
                        break;
                    }
                case "-r":
                    {
                        var x = CSDL.instance.Query<object>(args[1]).Result;
                        foreach (var y in x) { Console.WriteLine(y); }
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
            //Console.ReadKey();
        }
    }
}
