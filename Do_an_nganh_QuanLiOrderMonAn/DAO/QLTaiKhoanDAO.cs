using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Do_an_nganh_QuanLiOrderMonAn.DTO;
using Do_an_nganh_QuanLiOrderMonAn.UI;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
    public class QLTaiKhoanDAO
    {
        public static QLTaiKhoanDAO QLTaiKhoan=new QLTaiKhoanDAO();
        QLTaiKhoanDAO()
        {

        }
      
        public void ThemTaiKhoan(string name, string pass) //admin tao them tai khoan cho nhan vien
        {
            
            CSDL.instance.Insert("Account", new MongoDB.Bson.BsonDocument()
            {
                {"Name",name},
                { "Password", pass },
                {"isAdmin",false },
                {"online",false }
            });
        }
        
        public void XoaTaiKhoanHienTai()
        {
            Account.instance.DeleteAccount();
        }

        //..........................................
        public bool LogIn(string username,string pass,bool isadmin)
        {
            // neu log in thanh cong goi form main else bao loi 
            if(Account.LoadAccount(username, pass,isadmin))
            {
                //cap nhat trang thai online
                CSDL.instance.Update("Acccount", Account.instance.Username, "online", true);
                if (Account.instance.IsAdmin)
                {
                    ADMINFORM a = new ADMINFORM();
                    a.ShowDialog();
                }
                else
                {
                    NHANVIENFORM nvf = new NHANVIENFORM();
                    nvf.ShowDialog();
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public void LogOut()
        {
            //cap nhat trang thai online
            CSDL.instance.Update("Acccount", Account.instance.Username, "online", false);
            //goi form dang nhap 
            UI.FormDangNhap_DangKy f=new UI.FormDangNhap_DangKy();
            f.ShowDialog();
            
        }
    }
}
