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
            this.condition = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaydp = new System.Windows.Forms.DateTimePicker();
            this.loaidkcb = new System.Windows.Forms.ComboBox();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.order = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.header = new System.Windows.Forms.Panel();
            this.settingpic = new System.Windows.Forms.PictureBox();
            this.Accountpic = new System.Windows.Forms.PictureBox();
            this.footer = new System.Windows.Forms.Panel();
            this.NotifiLB = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.blockingbt = new System.Windows.Forms.Button();
            this.deleteBT = new System.Windows.Forms.Button();
            this.AddnewAccountBT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newAccGB = new System.Windows.Forms.GroupBox();
            this.createAccBT = new System.Windows.Forms.Button();
            this.checknewaccountbt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TrangThaiLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TentkLB = new System.Windows.Forms.Label();
            this.Chutklb = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.motatb = new System.Windows.Forms.RichTextBox();
            this.gianum = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Giá = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.XoaMonAnBT = new System.Windows.Forms.Button();
            this.SuattMonAnBT = new System.Windows.Forms.Button();
            this.addMonAnBT = new System.Windows.Forms.Button();
            this.monanData = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.nhanviendatat = new System.Windows.Forms.ListView();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Accountpic)).BeginInit();
            this.footer.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.newAccGB.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gianum)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // condition
            // 
            this.condition.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.condition.FullRowSelect = true;
            this.condition.GridLines = true;
            this.condition.HideSelection = false;
            this.condition.Location = new System.Drawing.Point(6, 63);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(287, 445);
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
            this.ngaydp.Location = new System.Drawing.Point(433, 17);
            this.ngaydp.Name = "ngaydp";
            this.ngaydp.Size = new System.Drawing.Size(149, 30);
            this.ngaydp.TabIndex = 5;
            // 
            // loaidkcb
            // 
            this.loaidkcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaidkcb.FormattingEnabled = true;
            this.loaidkcb.Items.AddRange(new object[] {
            "Tất cả",
            "Món ăn",
            "Người phục vụ bàn",
            "Thời gian",
            "Bàn"});
            this.loaidkcb.Location = new System.Drawing.Point(123, 17);
            this.loaidkcb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loaidkcb.Name = "loaidkcb";
            this.loaidkcb.Size = new System.Drawing.Size(152, 33);
            this.loaidkcb.TabIndex = 3;
            this.loaidkcb.SelectedIndexChanged += new System.EventHandler(this.loaidkcb_SelectedIndexChanged);
            // 
            // searchtb
            // 
            this.searchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtb.Location = new System.Drawing.Point(600, 17);
            this.searchtb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(221, 30);
            this.searchtb.TabIndex = 1;
            // 
            // order
            // 
            this.order.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.order.FullRowSelect = true;
            this.order.GridLines = true;
            this.order.HideSelection = false;
            this.order.Location = new System.Drawing.Point(313, 63);
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
            this.header.Controls.Add(this.settingpic);
            this.header.Controls.Add(this.Accountpic);
            this.header.Location = new System.Drawing.Point(13, 3);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1150, 45);
            this.header.TabIndex = 1;
            // 
            // settingpic
            // 
            this.settingpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingpic.Image = global::Do_an_nganh_QuanLiOrderMonAn.Properties.Resources.settingicon;
            this.settingpic.Location = new System.Drawing.Point(1053, 3);
            this.settingpic.Name = "settingpic";
            this.settingpic.Size = new System.Drawing.Size(41, 35);
            this.settingpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingpic.TabIndex = 0;
            this.settingpic.TabStop = false;
            // 
            // Accountpic
            // 
            this.Accountpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Accountpic.Image = global::Do_an_nganh_QuanLiOrderMonAn.Properties.Resources.accounticon;
            this.Accountpic.Location = new System.Drawing.Point(1100, 3);
            this.Accountpic.Name = "Accountpic";
            this.Accountpic.Size = new System.Drawing.Size(41, 35);
            this.Accountpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Accountpic.TabIndex = 0;
            this.Accountpic.TabStop = false;
            // 
            // footer
            // 
            this.footer.Controls.Add(this.NotifiLB);
            this.footer.Location = new System.Drawing.Point(12, 622);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1147, 57);
            this.footer.TabIndex = 2;
            // 
            // NotifiLB
            // 
            this.NotifiLB.Location = new System.Drawing.Point(9, 9);
            this.NotifiLB.Name = "NotifiLB";
            this.NotifiLB.Size = new System.Drawing.Size(1123, 44);
            this.NotifiLB.TabIndex = 0;
            this.NotifiLB.Text = "label1";
            this.NotifiLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NotifiLB.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1151, 552);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.order);
            this.tabPage1.Controls.Add(this.ngaydp);
            this.tabPage1.Controls.Add(this.searchtb);
            this.tabPage1.Controls.Add(this.condition);
            this.tabPage1.Controls.Add(this.loaidkcb);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1143, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ORDER";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Do_an_nganh_QuanLiOrderMonAn.Properties.Resources.delfilter;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Image = global::Do_an_nganh_QuanLiOrderMonAn.Properties.Resources.delfilter;
            this.button5.Location = new System.Drawing.Point(976, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 43);
            this.button5.TabIndex = 9;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Do_an_nganh_QuanLiOrderMonAn.Properties.Resources.filtericon;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Image = global::Do_an_nganh_QuanLiOrderMonAn.Properties.Resources.filtericon;
            this.button4.Location = new System.Drawing.Point(917, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 43);
            this.button4.TabIndex = 9;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lọc kết quả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tìm kiếm :  ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(842, 17);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 30);
            this.numericUpDown1.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.blockingbt);
            this.tabPage2.Controls.Add(this.deleteBT);
            this.tabPage2.Controls.Add(this.AddnewAccountBT);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1143, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "QL TÀI KHOẢN";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // blockingbt
            // 
            this.blockingbt.Location = new System.Drawing.Point(273, 150);
            this.blockingbt.Name = "blockingbt";
            this.blockingbt.Size = new System.Drawing.Size(109, 43);
            this.blockingbt.TabIndex = 5;
            this.blockingbt.Text = "Chặn";
            this.blockingbt.UseVisualStyleBackColor = true;
            this.blockingbt.Click += new System.EventHandler(this.blockingbt_Click);
            // 
            // deleteBT
            // 
            this.deleteBT.Location = new System.Drawing.Point(273, 92);
            this.deleteBT.Name = "deleteBT";
            this.deleteBT.Size = new System.Drawing.Size(109, 52);
            this.deleteBT.TabIndex = 5;
            this.deleteBT.Text = "Xóa";
            this.deleteBT.UseVisualStyleBackColor = true;
            this.deleteBT.Click += new System.EventHandler(this.deleteBT_Click);
            // 
            // AddnewAccountBT
            // 
            this.AddnewAccountBT.Location = new System.Drawing.Point(273, 41);
            this.AddnewAccountBT.Name = "AddnewAccountBT";
            this.AddnewAccountBT.Size = new System.Drawing.Size(109, 45);
            this.AddnewAccountBT.TabIndex = 5;
            this.AddnewAccountBT.Text = "Thêm";
            this.AddnewAccountBT.UseMnemonic = false;
            this.AddnewAccountBT.UseVisualStyleBackColor = true;
            this.AddnewAccountBT.Click += new System.EventHandler(this.AddnewAccountBT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.newAccGB);
            this.panel1.Controls.Add(this.TrangThaiLB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TentkLB);
            this.panel1.Controls.Add(this.Chutklb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(388, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 420);
            this.panel1.TabIndex = 2;
            // 
            // newAccGB
            // 
            this.newAccGB.Controls.Add(this.createAccBT);
            this.newAccGB.Controls.Add(this.checknewaccountbt);
            this.newAccGB.Controls.Add(this.label7);
            this.newAccGB.Controls.Add(this.textBox2);
            this.newAccGB.Controls.Add(this.label8);
            this.newAccGB.Controls.Add(this.textBox1);
            this.newAccGB.Location = new System.Drawing.Point(30, 109);
            this.newAccGB.Name = "newAccGB";
            this.newAccGB.Size = new System.Drawing.Size(672, 150);
            this.newAccGB.TabIndex = 6;
            this.newAccGB.TabStop = false;
            this.newAccGB.Text = "Thêm tài khoản ";
            this.newAccGB.Visible = false;
            // 
            // createAccBT
            // 
            this.createAccBT.Location = new System.Drawing.Point(527, 54);
            this.createAccBT.Name = "createAccBT";
            this.createAccBT.Size = new System.Drawing.Size(139, 72);
            this.createAccBT.TabIndex = 5;
            this.createAccBT.Text = "Tạo tài khoản ";
            this.createAccBT.UseVisualStyleBackColor = true;
            this.createAccBT.Click += new System.EventHandler(this.createAccBT_Click);
            // 
            // checknewaccountbt
            // 
            this.checknewaccountbt.Location = new System.Drawing.Point(409, 54);
            this.checknewaccountbt.Name = "checknewaccountbt";
            this.checknewaccountbt.Size = new System.Drawing.Size(112, 72);
            this.checknewaccountbt.TabIndex = 5;
            this.checknewaccountbt.Text = "Kiểm tra ";
            this.checknewaccountbt.UseVisualStyleBackColor = true;
            this.checknewaccountbt.Click += new System.EventHandler(this.checknewaccountbt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tên tài khoản: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 30);
            this.textBox2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mật khẩu :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 30);
            this.textBox1.TabIndex = 5;
            // 
            // TrangThaiLB
            // 
            this.TrangThaiLB.AutoSize = true;
            this.TrangThaiLB.Location = new System.Drawing.Point(130, 78);
            this.TrangThaiLB.Name = "TrangThaiLB";
            this.TrangThaiLB.Size = new System.Drawing.Size(47, 25);
            this.TrangThaiLB.TabIndex = 4;
            this.TrangThaiLB.Text = ".......";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trạng thái: ";
            // 
            // TentkLB
            // 
            this.TentkLB.AutoSize = true;
            this.TentkLB.Location = new System.Drawing.Point(514, 20);
            this.TentkLB.Name = "TentkLB";
            this.TentkLB.Size = new System.Drawing.Size(67, 25);
            this.TentkLB.TabIndex = 3;
            this.TentkLB.Text = "...........";
            // 
            // Chutklb
            // 
            this.Chutklb.AutoSize = true;
            this.Chutklb.Location = new System.Drawing.Point(170, 20);
            this.Chutklb.Name = "Chutklb";
            this.Chutklb.Size = new System.Drawing.Size(67, 25);
            this.Chutklb.TabIndex = 3;
            this.Chutklb.Text = "...........";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chủ tài khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách tài khoản";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(258, 467);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.motatb);
            this.tabPage3.Controls.Add(this.gianum);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.Giá);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.XoaMonAnBT);
            this.tabPage3.Controls.Add(this.SuattMonAnBT);
            this.tabPage3.Controls.Add(this.addMonAnBT);
            this.tabPage3.Controls.Add(this.monanData);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1143, 514);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MÓN ĂN ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // motatb
            // 
            this.motatb.Location = new System.Drawing.Point(642, 93);
            this.motatb.Name = "motatb";
            this.motatb.Size = new System.Drawing.Size(305, 96);
            this.motatb.TabIndex = 5;
            this.motatb.Text = "";
            // 
            // gianum
            // 
            this.gianum.Location = new System.Drawing.Point(642, 194);
            this.gianum.Name = "gianum";
            this.gianum.Size = new System.Drawing.Size(211, 30);
            this.gianum.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(642, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 30);
            this.textBox3.TabIndex = 3;
            // 
            // Giá
            // 
            this.Giá.AutoSize = true;
            this.Giá.Location = new System.Drawing.Point(522, 194);
            this.Giá.Name = "Giá";
            this.Giá.Size = new System.Drawing.Size(64, 25);
            this.Giá.TabIndex = 2;
            this.Giá.Text = "label4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(522, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mô tả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên món ăn:";
            // 
            // XoaMonAnBT
            // 
            this.XoaMonAnBT.Location = new System.Drawing.Point(765, 236);
            this.XoaMonAnBT.Name = "XoaMonAnBT";
            this.XoaMonAnBT.Size = new System.Drawing.Size(88, 37);
            this.XoaMonAnBT.TabIndex = 1;
            this.XoaMonAnBT.Text = "Xóa";
            this.XoaMonAnBT.UseVisualStyleBackColor = true;
            // 
            // SuattMonAnBT
            // 
            this.SuattMonAnBT.Location = new System.Drawing.Point(642, 236);
            this.SuattMonAnBT.Name = "SuattMonAnBT";
            this.SuattMonAnBT.Size = new System.Drawing.Size(88, 37);
            this.SuattMonAnBT.TabIndex = 1;
            this.SuattMonAnBT.Text = "Sửa";
            this.SuattMonAnBT.UseVisualStyleBackColor = true;
            // 
            // addMonAnBT
            // 
            this.addMonAnBT.Location = new System.Drawing.Point(522, 235);
            this.addMonAnBT.Name = "addMonAnBT";
            this.addMonAnBT.Size = new System.Drawing.Size(88, 37);
            this.addMonAnBT.TabIndex = 1;
            this.addMonAnBT.Text = "Thêm";
            this.addMonAnBT.UseVisualStyleBackColor = true;
            // 
            // monanData
            // 
            this.monanData.FullRowSelect = true;
            this.monanData.GridLines = true;
            this.monanData.HideSelection = false;
            this.monanData.Location = new System.Drawing.Point(9, 47);
            this.monanData.Name = "monanData";
            this.monanData.Size = new System.Drawing.Size(482, 226);
            this.monanData.TabIndex = 0;
            this.monanData.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.nhanviendatat);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1143, 514);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "NHÂN VIÊN";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // nhanviendatat
            // 
            this.nhanviendatat.HideSelection = false;
            this.nhanviendatat.Location = new System.Drawing.Point(9, 227);
            this.nhanviendatat.Name = "nhanviendatat";
            this.nhanviendatat.Size = new System.Drawing.Size(1081, 244);
            this.nhanviendatat.TabIndex = 0;
            this.nhanviendatat.UseCompatibleStateImageBehavior = false;
            // 
            // ADMINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1181, 691);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ADMINFORM";
            this.Text = "Quản lí quán ăn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MAIN_FormClosed);
            this.Load += new System.EventHandler(this.ADMINFORM_Load);
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Accountpic)).EndInit();
            this.footer.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.newAccGB.ResumeLayout(false);
            this.newAccGB.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gianum)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox loaidkcb;
        private System.Windows.Forms.TextBox searchtb;
        private System.Windows.Forms.ListView order;
        private System.Windows.Forms.DateTimePicker ngaydp;
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
        private System.Windows.Forms.PictureBox Accountpic;
        private System.Windows.Forms.PictureBox settingpic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button blockingbt;
        private System.Windows.Forms.Button deleteBT;
        private System.Windows.Forms.Button AddnewAccountBT;
        private System.Windows.Forms.Label TrangThaiLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView monanData;
        private System.Windows.Forms.Button XoaMonAnBT;
        private System.Windows.Forms.Button SuattMonAnBT;
        private System.Windows.Forms.Button addMonAnBT;
        private System.Windows.Forms.GroupBox newAccGB;
        private System.Windows.Forms.Button checknewaccountbt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button createAccBT;
        private System.Windows.Forms.Label TentkLB;
        private System.Windows.Forms.Label Chutklb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown gianum;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Giá;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox motatb;
        private System.Windows.Forms.ListView nhanviendatat;
    }
}