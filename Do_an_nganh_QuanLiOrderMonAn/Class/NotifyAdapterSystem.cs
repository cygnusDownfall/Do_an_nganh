
using System.Drawing;
using System.Windows.Forms;

namespace Do_an_nganh_QuanLiOrderMonAn.Class
{
    class NotifyAdapterSystem
    {
        public static void BaoLoi(Label label,string loi)
        {
            label.Text = loi;
            label.Visible = true;
            label.BackColor = Color.IndianRed;
        }
        public static void BaoThanhCong(Label label, string loi)
        {
            label.Text = loi;
            label.Visible = true;
            label.BackColor = Color.Green;
            
        }
    }
}
