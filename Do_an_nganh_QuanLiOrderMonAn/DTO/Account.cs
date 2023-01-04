using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    [Serializable]
    public class Account
    {
       
        public string AccountName;
        public string Password;
        public string Username;
        public bool IsAdmin;

        public Account(string acc,string user, string pass, bool admin = false)
        {
            Username = user;
            IsAdmin = admin;
        }

       
        public static bool LoadAccount(string name,string pass,bool isadmin) //dc goi vao luc nhan nut dang nhap
        {
            string body = "\"tentk\":\""+name+"\" ,\"mk\":\""+pass+"\" ,\"quyen\": \""+isadmin.ToString().ToLower()+ "\"";
            string kq = CSDL.instance.SendToMongoAPI("Account", "action/checkTK",body).Result;
            if (kq != "true")
            {
                MessageBox.Show("Dang nhap khong thanh cong \n Co the ban da nhap sai en dang nhap hoac mat khau ! \n Luu y: ban khong the dang nhap tren nhieu thiet bi cung luc");
                return false;
            }
            
            
            return true;
        }
       
        
    }

}
