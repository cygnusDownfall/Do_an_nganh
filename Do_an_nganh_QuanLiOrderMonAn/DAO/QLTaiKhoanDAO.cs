using System.Collections.Generic;
using Do_an_nganh_QuanLiOrderMonAn.DTO;
using Do_an_nganh_QuanLiOrderMonAn.UI;

namespace Do_an_nganh_QuanLiOrderMonAn.DAO
{
    public class QLTaiKhoanDAO
    {
        public static QLTaiKhoanDAO QLTaiKhoan = new QLTaiKhoanDAO();
        QLTaiKhoanDAO()
        {

        }

        public List<string> tentaikhoans  // hien thi danh sach tai khoan
        {
            get
            {
                return null;
            }
        }
        public void ThemTaiKhoan(string name, string pass) //admin tao them tai khoan cho nhan vien
        {
           
        }

        public void XoaTaiKhoanHienTai()
        {
          
        }

        //..........................................
        public bool LogIn(string username, string pass, bool isadmin)
        {
            // neu log in thanh cong goi form main else bao loi 
            if (Account.LoadAccount(username, pass, isadmin))
            {
                //cap nhat trang thai online

                //CSDL.instance.Update("Acccount", Account.instance.Username, "online", true);


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
            //CSDL.instance.Update("Acccount", Account.instance.Username, "online", false);

        }
    }
}
