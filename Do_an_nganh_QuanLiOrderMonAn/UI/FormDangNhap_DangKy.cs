using Do_an_nganh_QuanLiOrderMonAn.BUS;
using Do_an_nganh_QuanLiOrderMonAn.Class;
using Do_an_nganh_QuanLiOrderMonAn.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Do_an_nganh_QuanLiOrderMonAn.UI
{
    public partial class FormDangNhap_DangKy : Form
    {
        public FormDangNhap_DangKy()
        {
            Account acc = savesystem.load();
            if (acc!= null)
            {
                if(MessageBox.Show("Bạn muốn tiếp tục đăng nhập bằng tài khoản trước đó không?",
                   "Đăng nhập",MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    
                    QLTaiKhoan.instance.LogIn(acc.Username, acc.Password, acc.IsAdmin);
                }
                
            }
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] s = { "\\bin" };

            if (isAdmincb.SelectedIndex == 0)
            {
                ava.Load(Application.StartupPath.Split(s, StringSplitOptions.None)[0] +
                    "\\resource\\picture\\icon_avatar_quanli.png");

            }
            else
            {
                ava.Load(Application.StartupPath.Split(s, StringSplitOptions.None)[0] +
                    "\\resource\\picture\\icon_avatar_nhanvien.png");

            }
        }

        private async void FormDangNhap_DangKy_Load(object sender, EventArgs e)
        {
            isAdmincb.Items.Add("Quản lí");
            isAdmincb.Items.Add("Nhân viên");
            isAdmincb.SelectedText = "Quản lí";

            string hash = Block<Order>.InitHash(9);
            MessageBox.Show(hash);
            string id = code.InitHash(9);
            MessageBox.Show(id);

            string idnext= code.CreateNextID(id, hash,1);
            MessageBox.Show(idnext);

            //CSDL.instance.Insert<MonAn>("MonAn", new MonAn("4", "com chien", 15000, "com cien rat ngon"));
            //CSDL.instance.Insert<MonAn>("MonAn", new MonAn("5", "com chien", 15000, "com cien rat ngon"));
            //CSDL.instance.Insert<MonAn>("MonAn", new MonAn("6", "com chien", 15000, "com cien rat ngon"));

            //int i=await CSDL.instance.RemoveAll("MonAn");

            //int y = await CSDL.instance.UpdateMany("MonAn", "\"Gia\":15000", "Gia", "12");
            //MessageBox.Show(y.ToString());

            //List<MonAn> ma = await CSDL.instance.Query<MonAn>("MonAn");
            //foreach (var x in ma)
            //{
            //    MessageBox.Show(x._id);
            //}
        }

        private void LogInbt_Click(object sender, EventArgs e)
        {
            if (checkinputtk())
            {
                this.Hide();
                if (!QLTaiKhoan.instance.LogIn(Tentaikhoantb.Text, MKtb.Text,(isAdmincb.Text=="Quản lí")))
                {
                    this.Show();
                    Tentaikhoantb.BackColor = Color.IndianRed;
                    MKtb.BackColor = Color.IndianRed;
                    Tentaikhoantb.Focus();
                    Class.NotifyAdapterSystem.BaoLoi(loilb, "Đăng nhập không thành công");
                }
            }
        }
        #region hamrieng
        bool checkinputtk()
        {
            if (Tentaikhoantb.Text == "" || MKtb.Text == "" || isAdmincb.Text == "")
            {
                MessageBox.Show("Ban chua nhap du thong tin!");
                return false;
            }
            foreach (var x in Tentaikhoantb.Text)
            {
                if (x == '(' || x == ')' || x == '[' || x == ']' || x == '}' || x == '{'||x==',')
                {
                    MessageBox.Show("Ten tai khoan khong dung!");
                    return false;
                }
            }

            return true;
        }
        #endregion

    }
}
