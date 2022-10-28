using Do_an_nganh_QuanLiOrderMonAn.BUS;
using Do_an_nganh_QuanLiOrderMonAn.DTO;
using System;
using MongoDB.Bson;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using MongoDB.Driver;

namespace Do_an_nganh_QuanLiOrderMonAn.UI
{
    public partial class ADMINFORM : Form
    {
        public ADMINFORM()
        {
            InitializeComponent();
        }
        #region event
        private void MAIN_FormClosed(object sender, FormClosedEventArgs e)
        {

            CSDL.instance.Update("Acccount", Account.instance.Username, "online", false);
            
        }

        private void adminpanel_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //xoa dieu kien tim kiem 
            searchtb.Text = "";
            loaidkcb.Text = "";
            ngaydp.Value = DateTime.Now;
            //load lai list view 

        }
        private void ADMINFORM_Load(object sender, EventArgs e)
        {

        }
        private void loaidkcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadconditionlistview(loaidkcb.SelectedIndex);
        }
        private void condition_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadlistview(loaidkcb.Text,condition.SelectedItems.ToString());
        }
        #endregion
        #region function
        void basicloadlistview()
        {
            order.Items.Clear();
            List<BsonDocument> orderS = CSDL.instance.GetAllInCollection("Order");

            if (orderS == null) return;

            for (int i = 0,n=orderS.Count; i<n; i++)
            {
                order.Items.Add(orderS[i].GetValue(1).AsString);
                order.Items[i].SubItems.Add(orderS[i].GetValue(2).AsString);
                order.Items[i].SubItems.Add(orderS[i].GetValue(3).AsString);
                order.Items[i].SubItems.Add(orderS[i].GetValue(4).AsString);
            }

        }
        void loadconditionlistview(int index)
        {
            switch (index)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
            }
        }
        void loadlistview(string field,string value )
        {
            order.Items.Clear();
            List<BsonDocument> orderS = CSDL.instance.Query("Order",Builders<BsonDocument>.Filter.Eq(field,value));

            if (orderS == null) return;

            for (int i = 0, n = orderS.Count; i < n; i++)
            {
                order.Items.Add(orderS[i].GetValue(1).AsString);
                order.Items[i].SubItems.Add(orderS[i].GetValue(2).AsString);
                order.Items[i].SubItems.Add(orderS[i].GetValue(3).AsString);
                order.Items[i].SubItems.Add(orderS[i].GetValue(4).AsString);
            }
        }

        #endregion

        
    }
    
}
