﻿using Do_an_nganh_QuanLiOrderMonAn.BUS;
using Do_an_nganh_QuanLiOrderMonAn.DTO;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Do_an_nganh_QuanLiOrderMonAn.DAO;

namespace Do_an_nganh_QuanLiOrderMonAn.UI
{
    public partial class ADMINFORM : Form
    {
        public ADMINFORM()
        {
            InitializeComponent();
        }
        #region eventINform
        private void MAIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            QLTaiKhoan.instance.LogOut();
            savesystem.save(QLTaiKhoanDAO.instance.current);
            Application.Exit();
        }
        private void adminpanel_Click(object sender, EventArgs e)
        {

        }

        private void ADMINFORM_Load(object sender, EventArgs e)
        {
            basicloadlistview();//in orderTAB
            
        }
        #endregion
        #region eventINorderTAB
        private void loaidkcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadconditionlistview(loaidkcb.SelectedIndex);
        }
        private void condition_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadlistview(loaidkcb.Text, condition.SelectedItems.ToString());
        }
        private void button4_Click(object sender, EventArgs e) //search button 
        {
            
           
            List<ListViewItem> res = new List<ListViewItem>();
            var bang = order.Items;

            //dung binary search de tim vi tri dau tien 
            int mid;
            int right = order.Items.Count;
            for (int left = 0 ; left <= right;)
            {
                mid= left+(right-left)/2;
                if(DateTime.Compare(DateTime.Parse(bang[mid].SubItems[2].Text.Substring(0, 8)),ngaydp.Value)>=0)
                {
                    right= mid-1;
                }
                else
                {
                    left= mid+1;
                }
            }

            //them cac phan tu thoa dieu kien vao res
            
            for (int i = right+1,n=bang.Count; i < n; i++)
            {
                if (bang[i].SubItems[2].Text.Substring(0, 8) != ngaydp.Text)
                {
                    break;
                   
                }
                res.Add(bang[i]);
            }


            order.Items.Clear();

            //add cac phan tu res vao order.items
            for (int i = 0,n=res.Count;i<n ; i++)
            {
                order.Items.Add(res[i]);
            }

        }
        private void button5_Click(object sender, EventArgs e) //huy loc button 
        {
            //xoa dieu kien tim kiem 
            searchtb.Text = "";
            loaidkcb.Text = "";
            ngaydp.Value = DateTime.Now;
            //load lai list view 
            basicloadlistview();
        }
        #endregion

        #region function
        void basicloadlistview()
        {
            order.Items.Clear();
            List<Order> orderS = CSDL.instance.Query<Order>("Order").Result;

            if (orderS == null) return;

            for (int i = 0, n = orderS.Count; i < n; i++)
            {
                order.Items.Add(orderS[i].TenMonAn);
                order.Items[i].SubItems.Add(orderS[i].MaNhanVien);
               
                order.Items[i].SubItems.Add(orderS[i].Ban.ToString());
            }

        }
        void loadconditionlistview(int index)
        {
            condition.Items.Clear();
            List<string> kq = new List<string>();
            switch (index)
            {
                case 0:
                    {
                        basicloadlistview();
                        break;
                    }
                case 1:
                    {
                        List<MonAn> ma = QLMonAn.instance.MenuMonAn().Result;
                        if (ma == null) return;
                        for (int i = 0, n = ma.Count; i < n; i++)
                        {
                            kq.Add(ma[i].TenMonAn);
                        }
                        break;
                    }
                case 2:
                    {
                        //kq = QLNhanVienDAO.instance.DanhSachNhanVien;
                        break;
                    }
                case 3:
                    {
                        //kq = QLOder.danhsachngay;
                        break;
                    }
                case 4:
                    {
                        kq = null;
                        break;
                    }
            }
            for (int i = 0; i < kq.Count; i++)
            {
                condition.Items.Add(kq[i]);
            }

        }
        void loadlistview(string field, string value)
        {
            order.Items.Clear();

        }




        #endregion

        #region eventINAccountTAB
        private void AddnewAccountBT_Click(object sender, EventArgs e)
        {
            newAccGB.Visible=true;
        }

        private void deleteBT_Click(object sender, EventArgs e)
        {

        }

        private void blockingbt_Click(object sender, EventArgs e)
        {

        }

        private void checknewaccountbt_Click(object sender, EventArgs e)
        {

        }

        private void createAccBT_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }

}
