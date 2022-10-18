using System;
using System.Collections.Generic;
using Do_an_nganh_QuanLiOrderMonAn.DTO;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
    public class QLTaiKhoanDAO
    {
        public static QLTaiKhoanDAO QLTaiKhoan=new QLTaiKhoanDAO();
        QLTaiKhoanDAO()
        {

        }
        public void TaoTaiKhoan(string name,string pass,bool isAdmin) 
        //do nguoi dung dang ki tao tai khoan
        {
            if (isAdmin)
            {

            }
            CSDL.instance.Insert("Account", new MongoDB.Bson.BsonDocument()
            {
                {"Name",name},
                {"Password",pass},
                {"isAdmin",isAdmin }
            });
            LogIn(name, pass);
        }
        public void ThemTaiKhoan(string name, string pass) //admin tao them tai khoan cho nhan vien
        {
            CSDL.instance.Insert("Account", new MongoDB.Bson.BsonDocument()
            {
                {"Name",name},
                { "Password", pass },
                {"isAdmin",false }
            });
        }
        
        public void XoaTaiKhoanHienTai()
        {
            Account.instance.DeleteAccount();
        }

        //..........................................
        public void LogIn(string username,string pass)
        {
            // neu log in thanh cong goi form main else bao loi 
            if(Account.instance.LoadAccount(username, pass))
            {

            }
            else
            {

            }
        }
        public void LogOut()
        {
            //goi form dang nhap 

            UI.FormDangNhap_DangKy f=new UI.FormDangNhap_DangKy();
            f.ShowDialog();
        }
    }
}
