namespace Do_an_nganh_QuanLiOrderMonAn.UI
{
    partial class FormDangNhap_DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap_DangKy));
            this.Tentaikhoantb = new System.Windows.Forms.TextBox();
            this.MKtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ava = new System.Windows.Forms.PictureBox();
            this.isAdmincb = new System.Windows.Forms.ComboBox();
            this.LogInbt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ava)).BeginInit();
            this.SuspendLayout();
            // 
            // Tentaikhoantb
            // 
            this.Tentaikhoantb.Location = new System.Drawing.Point(22, 90);
            this.Tentaikhoantb.Name = "Tentaikhoantb";
            this.Tentaikhoantb.Size = new System.Drawing.Size(255, 30);
            this.Tentaikhoantb.TabIndex = 0;
            // 
            // MKtb
            // 
            this.MKtb.Location = new System.Drawing.Point(22, 157);
            this.MKtb.Name = "MKtb";
            this.MKtb.PasswordChar = '0';
            this.MKtb.Size = new System.Drawing.Size(255, 30);
            this.MKtb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên tài khoản ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // ava
            // 
            this.ava.Image = ((System.Drawing.Image)(resources.GetObject("ava.Image")));
            this.ava.InitialImage = ((System.Drawing.Image)(resources.GetObject("ava.InitialImage")));
            this.ava.Location = new System.Drawing.Point(353, 55);
            this.ava.Name = "ava";
            this.ava.Size = new System.Drawing.Size(170, 183);
            this.ava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ava.TabIndex = 2;
            this.ava.TabStop = false;
            // 
            // isAdmincb
            // 
            this.isAdmincb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.isAdmincb.DisplayMember = "Quản lí ";
            this.isAdmincb.ForeColor = System.Drawing.Color.Black;
            this.isAdmincb.FormattingEnabled = true;
            this.isAdmincb.Location = new System.Drawing.Point(353, 12);
            this.isAdmincb.Name = "isAdmincb";
            this.isAdmincb.Size = new System.Drawing.Size(159, 33);
            this.isAdmincb.TabIndex = 3;
            this.isAdmincb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LogInbt
            // 
            this.LogInbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LogInbt.Location = new System.Drawing.Point(75, 193);
            this.LogInbt.Name = "LogInbt";
            this.LogInbt.Size = new System.Drawing.Size(149, 45);
            this.LogInbt.TabIndex = 4;
            this.LogInbt.Text = "Đăng nhập";
            this.LogInbt.UseVisualStyleBackColor = false;
            this.LogInbt.Click += new System.EventHandler(this.LogInbt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bạn là:";
            // 
            // FormDangNhap_DangKy
            // 
            this.AcceptButton = this.LogInbt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(571, 271);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LogInbt);
            this.Controls.Add(this.isAdmincb);
            this.Controls.Add(this.ava);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MKtb);
            this.Controls.Add(this.Tentaikhoantb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDangNhap_DangKy";
            this.Text = "Đăng nhập ";
            this.Load += new System.EventHandler(this.FormDangNhap_DangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ava)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tentaikhoantb;
        private System.Windows.Forms.TextBox MKtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ava;
        private System.Windows.Forms.ComboBox isAdmincb;
        private System.Windows.Forms.Button LogInbt;
        private System.Windows.Forms.Label label3;
    }
}