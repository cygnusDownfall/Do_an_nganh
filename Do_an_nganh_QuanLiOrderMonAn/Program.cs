﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Do_an_nganh_QuanLiOrderMonAn
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UI.FormDangNhap_DangKy());
        }
    }
}
