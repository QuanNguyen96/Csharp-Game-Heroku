namespace Game_Sodoku
{
    partial class frm_game
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchSửToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gảiĐấuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giảiĐấu10010VòngĐấuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chơiĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trungBìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dễToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pl_screen = new System.Windows.Forms.Panel();
            this.ptb_image = new System.Windows.Forms.PictureBox();
            this.lb_nameingame = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_hinhthuc = new System.Windows.Forms.ComboBox();
            this.lb_mucdo = new System.Windows.Forms.Label();
            this.cb_mucdo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_ban = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_diemvan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_thoigianconlai = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_tongdiemkiemduoc = new System.Windows.Forms.Label();
            this.lb_sovanwin = new System.Windows.Forms.Label();
            this.lb_diemtichluy = new System.Windows.Forms.Label();
            this.lb_xephang = new System.Windows.Forms.Label();
            this.lb_sogoiy = new System.Windows.Forms.Label();
            this.btn_sudunggoiy = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_kiemtra = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.btn_xemketqua = new System.Windows.Forms.Button();
            this.btn_tieptuc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tựTạoXemKếtQuảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mànHìnhChínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gh = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.lịchSửToolStripMenuItem,
            this.gảiĐấuToolStripMenuItem,
            this.mànHìnhChínhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnToolStripMenuItem,
            this.thôngTinToolStripMenuItem,
            this.tựTạoXemKếtQuảToolStripMenuItem,
            this.colorScreenToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng Dẫn";
            this.hướngDẫnToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // lịchSửToolStripMenuItem
            // 
            this.lịchSửToolStripMenuItem.Name = "lịchSửToolStripMenuItem";
            this.lịchSửToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.lịchSửToolStripMenuItem.Text = "Lịch sử";
            this.lịchSửToolStripMenuItem.Click += new System.EventHandler(this.lịchSửToolStripMenuItem_Click);
            // 
            // gảiĐấuToolStripMenuItem
            // 
            this.gảiĐấuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giảiĐấu10010VòngĐấuToolStripMenuItem,
            this.chơiĐơnToolStripMenuItem});
            this.gảiĐấuToolStripMenuItem.Name = "gảiĐấuToolStripMenuItem";
            this.gảiĐấuToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.gảiĐấuToolStripMenuItem.Text = "Hình thức";
            // 
            // giảiĐấu10010VòngĐấuToolStripMenuItem
            // 
            this.giảiĐấu10010VòngĐấuToolStripMenuItem.Name = "giảiĐấu10010VòngĐấuToolStripMenuItem";
            this.giảiĐấu10010VòngĐấuToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.giảiĐấu10010VòngĐấuToolStripMenuItem.Text = "Giải đấu 100 (10 vòng đấu)";
            this.giảiĐấu10010VòngĐấuToolStripMenuItem.Click += new System.EventHandler(this.giảiĐấu10010VòngĐấuToolStripMenuItem_Click);
            // 
            // chơiĐơnToolStripMenuItem
            // 
            this.chơiĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khóToolStripMenuItem,
            this.trungBìnhToolStripMenuItem,
            this.dễToolStripMenuItem});
            this.chơiĐơnToolStripMenuItem.Name = "chơiĐơnToolStripMenuItem";
            this.chơiĐơnToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.chơiĐơnToolStripMenuItem.Text = "Chơi đơn";
            this.chơiĐơnToolStripMenuItem.Click += new System.EventHandler(this.chơiĐơnToolStripMenuItem_Click);
            // 
            // khóToolStripMenuItem
            // 
            this.khóToolStripMenuItem.Name = "khóToolStripMenuItem";
            this.khóToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.khóToolStripMenuItem.Text = "Khó";
            this.khóToolStripMenuItem.Click += new System.EventHandler(this.khóToolStripMenuItem_Click);
            // 
            // trungBìnhToolStripMenuItem
            // 
            this.trungBìnhToolStripMenuItem.Name = "trungBìnhToolStripMenuItem";
            this.trungBìnhToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.trungBìnhToolStripMenuItem.Text = "Trung Bình";
            this.trungBìnhToolStripMenuItem.Click += new System.EventHandler(this.trungBìnhToolStripMenuItem_Click);
            // 
            // dễToolStripMenuItem
            // 
            this.dễToolStripMenuItem.Name = "dễToolStripMenuItem";
            this.dễToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.dễToolStripMenuItem.Text = "Dễ";
            this.dễToolStripMenuItem.Click += new System.EventHandler(this.dễToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(301, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Sodoku";
            // 
            // pl_screen
            // 
            this.pl_screen.BackColor = System.Drawing.Color.Silver;
            this.pl_screen.Location = new System.Drawing.Point(16, 150);
            this.pl_screen.Name = "pl_screen";
            this.pl_screen.Size = new System.Drawing.Size(577, 584);
            this.pl_screen.TabIndex = 2;
            // 
            // ptb_image
            // 
            this.ptb_image.Location = new System.Drawing.Point(628, 29);
            this.ptb_image.Name = "ptb_image";
            this.ptb_image.Size = new System.Drawing.Size(100, 71);
            this.ptb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_image.TabIndex = 7;
            this.ptb_image.TabStop = false;
            this.ptb_image.Click += new System.EventHandler(this.ptb_image_Click);
            // 
            // lb_nameingame
            // 
            this.lb_nameingame.AutoSize = true;
            this.lb_nameingame.BackColor = System.Drawing.Color.Transparent;
            this.lb_nameingame.Location = new System.Drawing.Point(626, 9);
            this.lb_nameingame.Name = "lb_nameingame";
            this.lb_nameingame.Size = new System.Drawing.Size(26, 13);
            this.lb_nameingame.TabIndex = 8;
            this.lb_nameingame.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bạn đang chơi ở chế độ  : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hình thức";
            // 
            // cb_hinhthuc
            // 
            this.cb_hinhthuc.FormattingEnabled = true;
            this.cb_hinhthuc.Items.AddRange(new object[] {
            "Chơi Đơn",
            "Đấu Giải"});
            this.cb_hinhthuc.Location = new System.Drawing.Point(72, 73);
            this.cb_hinhthuc.Name = "cb_hinhthuc";
            this.cb_hinhthuc.Size = new System.Drawing.Size(68, 21);
            this.cb_hinhthuc.TabIndex = 12;
            this.cb_hinhthuc.Text = "Chơi Đơn";
            this.cb_hinhthuc.TextChanged += new System.EventHandler(this.cb_ban_TextChanged);
            // 
            // lb_mucdo
            // 
            this.lb_mucdo.AutoSize = true;
            this.lb_mucdo.Location = new System.Drawing.Point(229, 76);
            this.lb_mucdo.Name = "lb_mucdo";
            this.lb_mucdo.Size = new System.Drawing.Size(44, 13);
            this.lb_mucdo.TabIndex = 13;
            this.lb_mucdo.Text = "Mức độ";
            // 
            // cb_mucdo
            // 
            this.cb_mucdo.FormattingEnabled = true;
            this.cb_mucdo.Items.AddRange(new object[] {
            "Khó",
            "Trung Bình",
            "Dễ"});
            this.cb_mucdo.Location = new System.Drawing.Point(279, 73);
            this.cb_mucdo.Name = "cb_mucdo";
            this.cb_mucdo.Size = new System.Drawing.Size(61, 21);
            this.cb_mucdo.TabIndex = 14;
            this.cb_mucdo.Text = "Khó";
            this.cb_mucdo.TextChanged += new System.EventHandler(this.cb_ban_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bàn";
            // 
            // cb_ban
            // 
            this.cb_ban.FormattingEnabled = true;
            this.cb_ban.Items.AddRange(new object[] {
            "9",
            "8",
            "7",
            "6",
            "5",
            "4"});
            this.cb_ban.Location = new System.Drawing.Point(176, 73);
            this.cb_ban.Name = "cb_ban";
            this.cb_ban.Size = new System.Drawing.Size(47, 21);
            this.cb_ban.TabIndex = 16;
            this.cb_ban.Text = "9";
            this.cb_ban.SelectedIndexChanged += new System.EventHandler(this.cb_ban_SelectedIndexChanged);
            this.cb_ban.TextChanged += new System.EventHandler(this.cb_ban_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Điểm chiến thắng :";
            // 
            // lb_diemvan
            // 
            this.lb_diemvan.AutoSize = true;
            this.lb_diemvan.Location = new System.Drawing.Point(725, 253);
            this.lb_diemvan.Name = "lb_diemvan";
            this.lb_diemvan.Size = new System.Drawing.Size(13, 13);
            this.lb_diemvan.TabIndex = 18;
            this.lb_diemvan.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Thời gian còn lại : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Chơi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_thoigianconlai
            // 
            this.lb_thoigianconlai.AutoSize = true;
            this.lb_thoigianconlai.Location = new System.Drawing.Point(725, 202);
            this.lb_thoigianconlai.Name = "lb_thoigianconlai";
            this.lb_thoigianconlai.Size = new System.Drawing.Size(25, 13);
            this.lb_thoigianconlai.TabIndex = 21;
            this.lb_thoigianconlai.Text = "600";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(625, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 44);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tổng điểm kiếm được trong ngày :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(628, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Điểm tích lũy : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(629, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Xếp hạng :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(628, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Số ván win :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(626, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Số gợi ý hiện có";
            // 
            // lb_tongdiemkiemduoc
            // 
            this.lb_tongdiemkiemduoc.AutoSize = true;
            this.lb_tongdiemkiemduoc.Location = new System.Drawing.Point(697, 291);
            this.lb_tongdiemkiemduoc.Name = "lb_tongdiemkiemduoc";
            this.lb_tongdiemkiemduoc.Size = new System.Drawing.Size(13, 13);
            this.lb_tongdiemkiemduoc.TabIndex = 27;
            this.lb_tongdiemkiemduoc.Text = "0";
            this.lb_tongdiemkiemduoc.TextChanged += new System.EventHandler(this.lb_tongdiemkiemduoc_TextChanged);
            // 
            // lb_sovanwin
            // 
            this.lb_sovanwin.AutoSize = true;
            this.lb_sovanwin.Location = new System.Drawing.Point(697, 321);
            this.lb_sovanwin.Name = "lb_sovanwin";
            this.lb_sovanwin.Size = new System.Drawing.Size(13, 13);
            this.lb_sovanwin.TabIndex = 28;
            this.lb_sovanwin.Text = "0";
            // 
            // lb_diemtichluy
            // 
            this.lb_diemtichluy.AutoSize = true;
            this.lb_diemtichluy.Location = new System.Drawing.Point(708, 342);
            this.lb_diemtichluy.Name = "lb_diemtichluy";
            this.lb_diemtichluy.Size = new System.Drawing.Size(13, 13);
            this.lb_diemtichluy.TabIndex = 29;
            this.lb_diemtichluy.Text = "0";
            // 
            // lb_xephang
            // 
            this.lb_xephang.AutoSize = true;
            this.lb_xephang.Location = new System.Drawing.Point(690, 366);
            this.lb_xephang.Name = "lb_xephang";
            this.lb_xephang.Size = new System.Drawing.Size(13, 13);
            this.lb_xephang.TabIndex = 30;
            this.lb_xephang.Text = "0";
            // 
            // lb_sogoiy
            // 
            this.lb_sogoiy.AutoSize = true;
            this.lb_sogoiy.Location = new System.Drawing.Point(716, 154);
            this.lb_sogoiy.Name = "lb_sogoiy";
            this.lb_sogoiy.Size = new System.Drawing.Size(13, 13);
            this.lb_sogoiy.TabIndex = 31;
            this.lb_sogoiy.Text = "0";
            this.lb_sogoiy.TextChanged += new System.EventHandler(this.lb_sogoiy_TextChanged);
            // 
            // btn_sudunggoiy
            // 
            this.btn_sudunggoiy.Enabled = false;
            this.btn_sudunggoiy.Location = new System.Drawing.Point(626, 171);
            this.btn_sudunggoiy.Name = "btn_sudunggoiy";
            this.btn_sudunggoiy.Size = new System.Drawing.Size(124, 23);
            this.btn_sudunggoiy.TabIndex = 32;
            this.btn_sudunggoiy.Text = "Sử dụng gợi ý";
            this.btn_sudunggoiy.UseVisualStyleBackColor = true;
            this.btn_sudunggoiy.Click += new System.EventHandler(this.btn_sudunggoiy_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_kiemtra
            // 
            this.btn_kiemtra.Location = new System.Drawing.Point(16, 116);
            this.btn_kiemtra.Name = "btn_kiemtra";
            this.btn_kiemtra.Size = new System.Drawing.Size(75, 23);
            this.btn_kiemtra.TabIndex = 34;
            this.btn_kiemtra.Text = "Kiểm Tra";
            this.btn_kiemtra.UseVisualStyleBackColor = true;
            this.btn_kiemtra.Click += new System.EventHandler(this.btn_kiemtra_Click);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(740, 29);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(10, 10);
            this.data.TabIndex = 35;
            // 
            // btn_xemketqua
            // 
            this.btn_xemketqua.Location = new System.Drawing.Point(461, 116);
            this.btn_xemketqua.Name = "btn_xemketqua";
            this.btn_xemketqua.Size = new System.Drawing.Size(132, 23);
            this.btn_xemketqua.TabIndex = 36;
            this.btn_xemketqua.Text = "Xem Kết quả";
            this.btn_xemketqua.UseVisualStyleBackColor = true;
            this.btn_xemketqua.Click += new System.EventHandler(this.btn_xemketqua_Click);
            // 
            // btn_tieptuc
            // 
            this.btn_tieptuc.Location = new System.Drawing.Point(121, 116);
            this.btn_tieptuc.Name = "btn_tieptuc";
            this.btn_tieptuc.Size = new System.Drawing.Size(75, 23);
            this.btn_tieptuc.TabIndex = 37;
            this.btn_tieptuc.Text = "Tiếp tục";
            this.btn_tieptuc.UseVisualStyleBackColor = true;
            this.btn_tieptuc.Click += new System.EventHandler(this.btn_tieptuc_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(-3, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(851, 2);
            this.label2.TabIndex = 38;
            this.label2.Text = "label2";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(628, 219);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(122, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 39;
            this.progressBar1.Value = 100;
            // 
            // tựTạoXemKếtQuảToolStripMenuItem
            // 
            this.tựTạoXemKếtQuảToolStripMenuItem.Name = "tựTạoXemKếtQuảToolStripMenuItem";
            this.tựTạoXemKếtQuảToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.tựTạoXemKếtQuảToolStripMenuItem.Text = "Tự  tạo Xem kết quả";
            this.tựTạoXemKếtQuảToolStripMenuItem.Click += new System.EventHandler(this.tựTạoXemKếtQuảToolStripMenuItem_Click);
            // 
            // mànHìnhChínhToolStripMenuItem
            // 
            this.mànHìnhChínhToolStripMenuItem.Name = "mànHìnhChínhToolStripMenuItem";
            this.mànHìnhChínhToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.mànHìnhChínhToolStripMenuItem.Text = "Màn hình chính";
            this.mànHìnhChínhToolStripMenuItem.Click += new System.EventHandler(this.mànHìnhChínhToolStripMenuItem_Click);
            // 
            // colorScreenToolStripMenuItem
            // 
            this.colorScreenToolStripMenuItem.Name = "colorScreenToolStripMenuItem";
            this.colorScreenToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.colorScreenToolStripMenuItem.Text = "Color_Screen";
            this.colorScreenToolStripMenuItem.Click += new System.EventHandler(this.colorScreenToolStripMenuItem_Click);
            // 
            // gh
            // 
            this.gh.AutoSize = true;
            this.gh.BackColor = System.Drawing.Color.Transparent;
            this.gh.Location = new System.Drawing.Point(573, 9);
            this.gh.Name = "gh";
            this.gh.Size = new System.Drawing.Size(50, 13);
            this.gh.TabIndex = 40;
            this.gh.Text = "Xin Chào";
            // 
            // frm_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 754);
            this.Controls.Add(this.gh);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_tieptuc);
            this.Controls.Add(this.btn_xemketqua);
            this.Controls.Add(this.data);
            this.Controls.Add(this.btn_kiemtra);
            this.Controls.Add(this.btn_sudunggoiy);
            this.Controls.Add(this.lb_sogoiy);
            this.Controls.Add(this.lb_xephang);
            this.Controls.Add(this.lb_diemtichluy);
            this.Controls.Add(this.lb_sovanwin);
            this.Controls.Add(this.lb_tongdiemkiemduoc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_thoigianconlai);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_diemvan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_ban);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_mucdo);
            this.Controls.Add(this.lb_mucdo);
            this.Controls.Add(this.cb_hinhthuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_nameingame);
            this.Controls.Add(this.ptb_image);
            this.Controls.Add(this.pl_screen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_game";
            this.Text = "Game_Sodoku";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pl_screen;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.PictureBox ptb_image;
        private System.Windows.Forms.Label lb_nameingame;
        private System.Windows.Forms.ToolStripMenuItem lịchSửToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gảiĐấuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giảiĐấu10010VòngĐấuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chơiĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trungBìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dễToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_hinhthuc;
        private System.Windows.Forms.Label lb_mucdo;
        private System.Windows.Forms.ComboBox cb_mucdo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_ban;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_diemvan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_thoigianconlai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_tongdiemkiemduoc;
        private System.Windows.Forms.Label lb_sovanwin;
        private System.Windows.Forms.Label lb_diemtichluy;
        private System.Windows.Forms.Label lb_xephang;
        private System.Windows.Forms.Label lb_sogoiy;
        private System.Windows.Forms.Button btn_sudunggoiy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_kiemtra;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button btn_xemketqua;
        private System.Windows.Forms.Button btn_tieptuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem tựTạoXemKếtQuảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mànHìnhChínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorScreenToolStripMenuItem;
        private System.Windows.Forms.Label gh;
    }
}

