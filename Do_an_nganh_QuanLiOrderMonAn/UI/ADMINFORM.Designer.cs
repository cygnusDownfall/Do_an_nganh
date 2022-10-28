namespace Do_an_nganh_QuanLiOrderMonAn.UI
{
    partial class ADMINFORM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adminpanel = new System.Windows.Forms.Panel();
            this.condition = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaydp = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loaidkcb = new System.Windows.Forms.ComboBox();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.order = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.header = new System.Windows.Forms.Panel();
            this.footer = new System.Windows.Forms.Panel();
            this.NotifiLB = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.adminpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.footer.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminpanel
            // 
            this.adminpanel.Controls.Add(this.condition);
            this.adminpanel.Controls.Add(this.ngaydp);
            this.adminpanel.Controls.Add(this.pictureBox2);
            this.adminpanel.Controls.Add(this.pictureBox1);
            this.adminpanel.Controls.Add(this.loaidkcb);
            this.adminpanel.Controls.Add(this.searchtb);
            this.adminpanel.Controls.Add(this.order);
            this.adminpanel.Location = new System.Drawing.Point(7, 8);
            this.adminpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminpanel.Name = "adminpanel";
            this.adminpanel.Size = new System.Drawing.Size(1119, 529);
            this.adminpanel.TabIndex = 0;
            this.adminpanel.Tag = "";
            this.adminpanel.Visible = false;
            this.adminpanel.Click += new System.EventHandler(this.adminpanel_Click);
            // 
            // condition
            // 
            this.condition.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.condition.FullRowSelect = true;
            this.condition.GridLines = true;
            this.condition.HideSelection = false;
            this.condition.Location = new System.Drawing.Point(4, 8);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(287, 473);
            this.condition.TabIndex = 6;
            this.condition.UseCompatibleStateImageBehavior = false;
            this.condition.View = System.Windows.Forms.View.Details;
            this.condition.SelectedIndexChanged += new System.EventHandler(this.condition_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.Width = 280;
            // 
            // ngaydp
            // 
            this.ngaydp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaydp.Location = new System.Drawing.Point(550, 7);
            this.ngaydp.Name = "ngaydp";
            this.ngaydp.Size = new System.Drawing.Size(149, 30);
            this.ngaydp.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Image = global::Do_an_nganh_QuanLiOrderMonAn.Properties.Resources.delfilter;
            this.pictureBox2.Location = new System.Drawing.Point(1053, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Do_an_nganh_QuanLiOrderMonAn.Properties.Resources.filtericon;
            this.pictureBox1.Location = new System.Drawing.Point(310, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // loaidkcb
            // 
            this.loaidkcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaidkcb.FormattingEnabled = true;
            this.loaidkcb.Items.AddRange(new object[] {
            "Người phục vụ bàn",
            "Ngày tạo",
            "Bàn",
            "Món ăn"});
            this.loaidkcb.Location = new System.Drawing.Point(370, 7);
            this.loaidkcb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loaidkcb.Name = "loaidkcb";
            this.loaidkcb.Size = new System.Drawing.Size(173, 33);
            this.loaidkcb.TabIndex = 3;
            this.loaidkcb.SelectedIndexChanged += new System.EventHandler(this.loaidkcb_SelectedIndexChanged);
            // 
            // searchtb
            // 
            this.searchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtb.Location = new System.Drawing.Point(706, 7);
            this.searchtb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(283, 30);
            this.searchtb.TabIndex = 1;
            // 
            // order
            // 
            this.order.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.order.GridLines = true;
            this.order.HideSelection = false;
            this.order.Location = new System.Drawing.Point(310, 57);
            this.order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(796, 424);
            this.order.TabIndex = 0;
            this.order.UseCompatibleStateImageBehavior = false;
            this.order.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Món ăn";
            this.columnHeader1.Width = 221;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nhân viên phục vụ bàn";
            this.columnHeader2.Width = 226;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thời gian";
            this.columnHeader3.Width = 271;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bàn ";
            this.columnHeader4.Width = 73;
            // 
            // header
            // 
            this.header.Location = new System.Drawing.Point(13, 3);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1106, 33);
            this.header.TabIndex = 1;
            // 
            // footer
            // 
            this.footer.Controls.Add(this.NotifiLB);
            this.footer.Location = new System.Drawing.Point(12, 636);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1106, 57);
            this.footer.TabIndex = 2;
            // 
            // NotifiLB
            // 
            this.NotifiLB.Location = new System.Drawing.Point(9, 9);
            this.NotifiLB.Name = "NotifiLB";
            this.NotifiLB.Size = new System.Drawing.Size(1099, 44);
            this.NotifiLB.TabIndex = 0;
            this.NotifiLB.Text = "label1";
            this.NotifiLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1128, 588);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.adminpanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1120, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "QUẢN LÍ ORDER";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1120, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "QUẢN LÍ TÀI KHOẢN";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1120, 522);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "QUẢN LÍ MÓN ĂN ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1120, 522);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "QUẢN LÍ NHÂN VIÊN";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ADMINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1141, 703);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ADMINFORM";
            this.Text = "Quản lí quán ăn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MAIN_FormClosed);
            this.Load += new System.EventHandler(this.ADMINFORM_Load);
            this.adminpanel.ResumeLayout(false);
            this.adminpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.footer.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminpanel;
        private System.Windows.Forms.ComboBox loaidkcb;
        private System.Windows.Forms.TextBox searchtb;
        private System.Windows.Forms.ListView order;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker ngaydp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView condition;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Label NotifiLB;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}