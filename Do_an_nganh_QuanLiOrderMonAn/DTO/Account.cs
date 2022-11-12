using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    [Serializable]
    public class Account
    {
        
        public static Account instance=new Account();
        Account() { }
        string username;
        string  password;
        bool isAdmin;
        bool online=false;
      
        public string Username { get => username; }
        public string Password { get => password; }
        public bool IsAdmin { get => isAdmin; }
        
        Account( string user, string pass, bool admin = false)
        {
            username = user;
            password = pass;
            isAdmin = admin;
        }

        public void init(string user, string pass, bool admin = false)
        {
            instance = new Account(user, pass, admin);
        }
        public static bool LoadAccount(string name,string pass,bool isadmin) //dc goi vao luc nhan nut dang nhap
        {
            bool kq= CSDL.instance.SearchAccount(name,pass,isadmin);
            if (!kq) System.Windows.Forms.MessageBox.Show("Dang nhap khong thanh cong \n Co the ban da nhap sai en dang nhap hoac mat khau ! \n Luu y: ban khong the dang nhap tren nhieu thiet bi cung luc");
         
            return kq;
        }
        public void changePass(string newpass)
        {
            password = newpass;
            CSDL.instance.Update("Account", username, "Password", password);
            System.Windows.Forms.MessageBox.Show("Doi mat khau thanh cong !");
        }
        public void DeleteAccount()
        {
            CSDL.instance.Remove("Account",username);
            instance = null;
            BUS.QLTaiKhoan.instance.LogOut();
        }
    }

}
