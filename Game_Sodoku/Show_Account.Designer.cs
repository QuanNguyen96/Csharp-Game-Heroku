namespace Game_Sodoku
{
    partial class frm_Show_Account
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
            this.button1 = new System.Windows.Forms.Button();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.điểm = new System.Windows.Forms.Label();
            this.lb_xephang = new System.Windows.Forms.Label();
            this.lb_diem = new System.Windows.Forms.Label();
            this.lb_tentk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_edit_password = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(221, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "cập nhật avatar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // avatar
            // 
            this.avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avatar.Location = new System.Drawing.Point(221, 26);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(100, 87);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 12;
            this.avatar.TabStop = false;
            this.avatar.Click += new System.EventHandler(this.avatar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Để thay đổi avatar , mời bạn click vào vào avatar và chọn file";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Xếp hạng :";
            // 
            // điểm
            // 
            this.điểm.AutoSize = true;
            this.điểm.Location = new System.Drawing.Point(26, 96);
            this.điểm.Name = "điểm";
            this.điểm.Size = new System.Drawing.Size(40, 13);
            this.điểm.TabIndex = 6;
            this.điểm.Text = "Điểm : ";
            // 
            // lb_xephang
            // 
            this.lb_xephang.AutoSize = true;
            this.lb_xephang.Location = new System.Drawing.Point(108, 140);
            this.lb_xephang.Name = "lb_xephang";
            this.lb_xephang.Size = new System.Drawing.Size(51, 13);
            this.lb_xephang.TabIndex = 7;
            this.lb_xephang.Text = "xếp hạng";
            // 
            // lb_diem
            // 
            this.lb_diem.AutoSize = true;
            this.lb_diem.Location = new System.Drawing.Point(108, 96);
            this.lb_diem.Name = "lb_diem";
            this.lb_diem.Size = new System.Drawing.Size(31, 13);
            this.lb_diem.TabIndex = 8;
            this.lb_diem.Text = "Điểm";
            // 
            // lb_tentk
            // 
            this.lb_tentk.AutoSize = true;
            this.lb_tentk.Location = new System.Drawing.Point(108, 55);
            this.lb_tentk.Name = "lb_tentk";
            this.lb_tentk.Size = new System.Drawing.Size(73, 13);
            this.lb_tentk.TabIndex = 9;
            this.lb_tentk.Text = "Tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thông tin tài khoản";
            // 
            // btn_edit_password
            // 
            this.btn_edit_password.Location = new System.Drawing.Point(221, 140);
            this.btn_edit_password.Name = "btn_edit_password";
            this.btn_edit_password.Size = new System.Drawing.Size(100, 23);
            this.btn_edit_password.TabIndex = 14;
            this.btn_edit_password.Text = "Đổi mật khẩu";
            this.btn_edit_password.UseVisualStyleBackColor = true;
            this.btn_edit_password.Click += new System.EventHandler(this.btn_edit_password_Click);
            // 
            // frm_Show_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 212);
            this.Controls.Add(this.btn_edit_password);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.điểm);
            this.Controls.Add(this.lb_xephang);
            this.Controls.Add(this.lb_diem);
            this.Controls.Add(this.lb_tentk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Show_Account";
            this.Text = "Show_Account";
            this.Load += new System.EventHandler(this.frm_Show_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label điểm;
        private System.Windows.Forms.Label lb_xephang;
        private System.Windows.Forms.Label lb_diem;
        private System.Windows.Forms.Label lb_tentk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_edit_password;
    }
}