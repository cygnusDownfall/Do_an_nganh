using System.Collections.Generic;
using Do_an_nganh_QuanLiOrderMonAn.DTO;
using Do_an_nganh_QuanLiOrderMonAn.UI;
using Newtonsoft.Json;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
    public class QLTaiKhoanDAO
    {
        public static QLTaiKhoanDAO instance = new QLTaiKhoanDAO();
        public Account current;
        QLTaiKhoanDAO()
        {

        }

        public List<string> tentaikhoans
        {
            get
            {
                return null;
            }
        }
        public List<Account> Timkiem(string properties, string value)
        {
            string filter = string.Format("\"{0}\":\"{1}\"", properties, value);
            return CSDL.instance.Query<Account>("Account", filter).Result;
        }
        public bool Them(string acc, string user, string pass, bool admin = false) // ch 
        {
            Account m = new Account(acc, user, pass, admin);
            return CSDL.instance.Insert<Account>("Account", m).Result;
        }
        public void CapNhat(string search, string searchvalue, string propertie, string value)
        {
            CSDL.instance.UpdateOne("Account", search, searchvalue, propertie, value);
        }
        public bool Xoa(string tentaikhoan)
        {
            string filter = "\"AccountName\":\"" + tentaikhoan + "\"";
            return CSDL.instance.RemoveOne("Account", filter).Result;
        }

        //..........................................
        public bool LogIn(string accname, string pass, bool isadmin)
        {
            // neu log in thanh cong goi form main else bao loi 
            if (Account.LoadAccount(accname, pass, isadmin))
            {
                //cap nhat trang thai online

                CSDL.instance.UpdateOne("Account", "AccountName", accname, "online", "true");
                //


                if (isadmin)
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
            CSDL.instance.UpdateOne("Account", "AccountName", current.AccountName, "online", "false");

        }
        public void changePass(string newpass)
        {
            CSDL.instance.UpdateOne("Account", "AccountName", current.AccountName, "Password", newpass);
            System.Windows.Forms.MessageBox.Show("Doi mat khau thanh cong !");
        }
    }
}
