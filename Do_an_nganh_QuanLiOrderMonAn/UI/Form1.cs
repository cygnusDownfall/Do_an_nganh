using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Do_an_nganh_QuanLiOrderMonAn.BUS;
using System.Windows.Forms;

namespace Do_an_nganh_QuanLiOrderMonAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(var x in QLMonAn.instance.MenuMonAn)
            {
                testlv.Items.Add(x.TenMonAn);
            }
        }
    }
}
