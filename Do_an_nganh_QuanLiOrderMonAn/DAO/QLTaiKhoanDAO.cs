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
        public bool LogIn(string username,string pass)
        {
            // neu log in thanh cong goi form main else bao loi 
            if(Account.LoadAccount(username, pass))
            {
                MAIN a = new MAIN();
                //cap nhat trang thai online
                CSDL.instance.Update("Acccount", Account.instance.Username, "online", true);
                a.ShowDialog();
                Application.OpenForms[0].Close();
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
