using System.Collections.Generic;
using Do_an_nganh_QuanLiOrderMonAn.DTO;
using Do_an_nganh_QuanLiOrderMonAn.UI;
using Newtonsoft.Json;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
    public class QLTaiKhoanDAO
    {
        public static QLTaiKhoanDAO QLTaiKhoan = new QLTaiKhoanDAO();
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
        public void ThemTaiKhoan(string name, string pass,bool isadmin,string username) //admin tao them tai khoan cho nhan vien
        {
            string objjson = JsonConvert.SerializeObject(new Account(name,username,pass,isadmin));
            CSDL.instance.addBlock("Account",objjson);
        }

        public void XoaTaiKhoanHienTai()
        {
          
        }

        //..........................................
        public bool LogIn(string accname, string pass, bool isadmin)
        {
            // neu log in thanh cong goi form main else bao loi 
            if (Account.LoadAccount(accname, pass, isadmin))
            {
                //cap nhat trang thai online

                CSDL.instance.UpdateOne("Account","AccountName", accname, "online", "true");
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
            CSDL.instance.UpdateOne("Account","AccountName",current.AccountName, "online", "false");

        }
        public void changePass(string newpass)
        {
            CSDL.instance.UpdateOne("Account", "AccountName", current.AccountName, "Password", newpass);
            System.Windows.Forms.MessageBox.Show("Doi mat khau thanh cong !");
        }
    }
}
