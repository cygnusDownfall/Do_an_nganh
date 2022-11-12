using Do_an_nganh_QuanLiOrderMonAn.BUS;
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
            //  CSDL.instance.Post<Order>("Order",new Order("ga nuong", 5, DateTime.Now));
          List<MonAn> ds= await CSDL.instance.Query<MonAn>("MonAn",@"""filter"":{""Tenmonan"":""ga nuong""}");
           foreach(var x in ds)
            {
                MessageBox.Show(x.ToString());
            }
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
