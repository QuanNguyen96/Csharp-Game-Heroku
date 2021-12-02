namespace Game_Sodoku
{
    partial class frm_Edit_Account
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
            this.lb_tentaikhoan = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.txtmkcu = new System.Windows.Forms.TextBox();
            this.txtmkmoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_ktramk = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_nameingame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_tentaikhoan
            // 
            this.lb_tentaikhoan.AutoSize = true;
            this.lb_tentaikhoan.Location = new System.Drawing.Point(122, 77);
            this.lb_tentaikhoan.Name = "lb_tentaikhoan";
            this.lb_tentaikhoan.Size = new System.Drawing.Size(69, 13);
            this.lb_tentaikhoan.TabIndex = 11;
            this.lb_tentaikhoan.Text = "tên tài khoản";
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(27, 208);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(502, 33);
            this.btn_luu.TabIndex = 10;
            this.btn_luu.Text = "Lưu thay đổi";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txtmkcu
            // 
            this.txtmkcu.Location = new System.Drawing.Point(115, 106);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.PasswordChar = '*';
            this.txtmkcu.Size = new System.Drawing.Size(178, 20);
            this.txtmkcu.TabIndex = 7;
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.Location = new System.Drawing.Point(115, 143);
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.PasswordChar = '*';
            this.txtmkmoi.Size = new System.Drawing.Size(178, 20);
            this.txtmkmoi.TabIndex = 8;
            this.txtmkmoi.TextChanged += new System.EventHandler(this.txtmkmoi_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(22, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = " !  Mật khẩu ít nhất phải 8 kí tự có phân biệt chữ thường , chữ hoa ";
            // 
            // lb_ktramk
            // 
            this.lb_ktramk.AutoSize = true;
            this.lb_ktramk.Location = new System.Drawing.Point(300, 122);
            this.lb_ktramk.Name = "lb_ktramk";
            this.lb_ktramk.Size = new System.Drawing.Size(0, 13);
            this.lb_ktramk.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "nhập lại MK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mật khâu mới";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên trong game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(357, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lb_nameingame
            // 
            this.lb_nameingame.AutoSize = true;
            this.lb_nameingame.Location = new System.Drawing.Point(122, 50);
            this.lb_nameingame.Name = "lb_nameingame";
            this.lb_nameingame.Size = new System.Drawing.Size(78, 13);
            this.lb_nameingame.TabIndex = 11;
            this.lb_nameingame.Text = "tên trong game";
            // 
            // frm_Edit_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 256);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_nameingame);
            this.Controls.Add(this.lb_tentaikhoan);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.txtmkcu);
            this.Controls.Add(this.txtmkmoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_ktramk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Edit_Account";
            this.Text = "Edit_Account";
            this.Load += new System.EventHandler(this.frm_Edit_Account_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Edit_Account_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tentaikhoan;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.TextBox txtmkcu;
        private System.Windows.Forms.TextBox txtmkmoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_ktramk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_nameingame;
    }
}