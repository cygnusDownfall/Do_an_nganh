using System;
using System.Collections.Generic;



namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    public class Account
    {
        public static Account instance;
        string username, password;
        bool isAdmin;
        public string Username { get => username; }
        public string Password { get => password; }
        public bool IsAdmin { get => isAdmin; }
        Account(string user, string pass, bool admin = false)
        {
            username = user;
            password = pass;
            isAdmin = admin;
        }
        public void init(string user, string pass, bool admin = false)
        {
            instance = new Account(user, pass, admin);
        }
        bool LoadAccount(string name,string pass) //dc goi vao luc nhan nut dang nhap
        {
            bool kq= CSDL.instance.SearchAccount(name,pass);
            if (!kq) System.Windows.Forms.MessageBox.Show("Ten dang nhap hoac mat khau sai!");
         
            return kq;
        }
        public void changePass(string newpass)
        {
            password = newpass;
            CSDL.instance.Update("Account", username, "password", password);
            System.Windows.Forms.MessageBox.Show("Doi mat khau thanh cong !");
        }
    }

}
