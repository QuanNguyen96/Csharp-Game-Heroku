namespace Game_Sodoku
{
    partial class frm_Create_new_account
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_matkhaulan2 = new System.Windows.Forms.TextBox();
            this.txt_matkhaulan1 = new System.Windows.Forms.TextBox();
            this.txt_tentaikhoanmoi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_baoloimatkhaunhaplai = new System.Windows.Forms.Label();
            this.lb_baoloimatkhau = new System.Windows.Forms.Label();
            this.lb_baoloitentaikhoan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name_ingame = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(174, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(49, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(403, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "Lưu tài khoản";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_matkhaulan2
            // 
            this.txt_matkhaulan2.Location = new System.Drawing.Point(157, 200);
            this.txt_matkhaulan2.Name = "txt_matkhaulan2";
            this.txt_matkhaulan2.PasswordChar = '*';
            this.txt_matkhaulan2.Size = new System.Drawing.Size(166, 20);
            this.txt_matkhaulan2.TabIndex = 13;
            this.txt_matkhaulan2.TextChanged += new System.EventHandler(this.txt_matkhaulan2_TextChanged);
            // 
            // txt_matkhaulan1
            // 
            this.txt_matkhaulan1.Location = new System.Drawing.Point(157, 174);
            this.txt_matkhaulan1.Name = "txt_matkhaulan1";
            this.txt_matkhaulan1.PasswordChar = '*';
            this.txt_matkhaulan1.Size = new System.Drawing.Size(166, 20);
            this.txt_matkhaulan1.TabIndex = 12;
            this.txt_matkhaulan1.TextChanged += new System.EventHandler(this.txt_matkhaulan1_TextChanged);
            // 
            // txt_tentaikhoanmoi
            // 
            this.txt_tentaikhoanmoi.Location = new System.Drawing.Point(157, 149);
            this.txt_tentaikhoanmoi.Name = "txt_tentaikhoanmoi";
            this.txt_tentaikhoanmoi.Size = new System.Drawing.Size(166, 20);
            this.txt_tentaikhoanmoi.TabIndex = 10;
            this.txt_tentaikhoanmoi.TextChanged += new System.EventHandler(this.txt_tentaikhoanmoi_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(46, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(343, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = " !  Mật khẩu ít nhất phải 8 kí tự không phân biệt chữ thường , chữ hoa ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(46, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(55, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Avatar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên đăng nhập";
            // 
            // lb_baoloimatkhaunhaplai
            // 
            this.lb_baoloimatkhaunhaplai.AutoSize = true;
            this.lb_baoloimatkhaunhaplai.BackColor = System.Drawing.Color.White;
            this.lb_baoloimatkhaunhaplai.ForeColor = System.Drawing.Color.Black;
            this.lb_baoloimatkhaunhaplai.Location = new System.Drawing.Point(333, 205);
            this.lb_baoloimatkhaunhaplai.Name = "lb_baoloimatkhaunhaplai";
            this.lb_baoloimatkhaunhaplai.Size = new System.Drawing.Size(0, 13);
            this.lb_baoloimatkhaunhaplai.TabIndex = 15;
            // 
            // lb_baoloimatkhau
            // 
            this.lb_baoloimatkhau.AutoSize = true;
            this.lb_baoloimatkhau.BackColor = System.Drawing.Color.White;
            this.lb_baoloimatkhau.ForeColor = System.Drawing.Color.Black;
            this.lb_baoloimatkhau.Location = new System.Drawing.Point(333, 178);
            this.lb_baoloimatkhau.Name = "lb_baoloimatkhau";
            this.lb_baoloimatkhau.Size = new System.Drawing.Size(0, 13);
            this.lb_baoloimatkhau.TabIndex = 16;
            // 
            // lb_baoloitentaikhoan
            // 
            this.lb_baoloitentaikhoan.AutoSize = true;
            this.lb_baoloitentaikhoan.BackColor = System.Drawing.Color.White;
            this.lb_baoloitentaikhoan.ForeColor = System.Drawing.Color.Black;
            this.lb_baoloitentaikhoan.Location = new System.Drawing.Point(333, 153);
            this.lb_baoloitentaikhoan.Name = "lb_baoloitentaikhoan";
            this.lb_baoloitentaikhoan.Size = new System.Drawing.Size(0, 13);
            this.lb_baoloitentaikhoan.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên trong game";
            // 
            // txt_name_ingame
            // 
            this.txt_name_ingame.Location = new System.Drawing.Point(157, 123);
            this.txt_name_ingame.Name = "txt_name_ingame";
            this.txt_name_ingame.Size = new System.Drawing.Size(166, 20);
            this.txt_name_ingame.TabIndex = 18;
            // 
            // frm_Create_new_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 324);
            this.Controls.Add(this.txt_name_ingame);
            this.Controls.Add(this.lb_baoloimatkhaunhaplai);
            this.Controls.Add(this.lb_baoloimatkhau);
            this.Controls.Add(this.lb_baoloitentaikhoan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_matkhaulan2);
            this.Controls.Add(this.txt_matkhaulan1);
            this.Controls.Add(this.txt_tentaikhoanmoi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "frm_Create_new_account";
            this.Text = "Create_new_account";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Create_new_account_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_matkhaulan2;
        private System.Windows.Forms.TextBox txt_matkhaulan1;
        private System.Windows.Forms.TextBox txt_tentaikhoanmoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_baoloimatkhaunhaplai;
        private System.Windows.Forms.Label lb_baoloimatkhau;
        private System.Windows.Forms.Label lb_baoloitentaikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name_ingame;
    }
}