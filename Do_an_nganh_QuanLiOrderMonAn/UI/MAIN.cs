using Do_an_nganh_QuanLiOrderMonAn.BUS;
using Do_an_nganh_QuanLiOrderMonAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_nganh_QuanLiOrderMonAn.UI
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }

        private void MAIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            CSDL.instance.Update("Acccount", Account.instance.Username, "online", false);
        }
    }
}
