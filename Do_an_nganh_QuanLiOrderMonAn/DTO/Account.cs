using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    public class Account
    {
        string username, password;
        bool isAdmin;
        public string Username { get => username; }
        public string Password { get => password; }
        public bool IsAdmin { get => isAdmin; }
        public Account(string user, string pass, bool admin = false)
        {
            username = user;
            password = pass;
            isAdmin = admin;
        }
        public void changePass(string newpass)
        {
            password = newpass;
        }
    }

}
