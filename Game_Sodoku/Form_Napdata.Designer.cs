namespace Game_Sodoku
{
    partial class Form_Napdata
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
            this.lb_thongbaoloi = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Button();
            this.txt_colums = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pl_screen = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lb_thongbaoloi
            // 
            this.lb_thongbaoloi.AutoSize = true;
            this.lb_thongbaoloi.ForeColor = System.Drawing.Color.Red;
            this.lb_thongbaoloi.Location = new System.Drawing.Point(180, 18);
            this.lb_thongbaoloi.Name = "lb_thongbaoloi";
            this.lb_thongbaoloi.Size = new System.Drawing.Size(55, 13);
            this.lb_thongbaoloi.TabIndex = 12;
            this.lb_thongbaoloi.Text = "thông báo";
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(13, 47);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(180, 34);
            this.btn_run.TabIndex = 11;
            this.btn_run.Text = "Chạy để nạp dữ liệu";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // txt_colums
            // 
            this.txt_colums.Location = new System.Drawing.Point(63, 15);
            this.txt_colums.Name = "txt_colums";
            this.txt_colums.Size = new System.Drawing.Size(100, 20);
            this.txt_colums.TabIndex = 10;
            this.txt_colums.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_colums.TextChanged += new System.EventHandler(this.txt_colums_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "số cột";
            // 
            // pl_screen
            // 
            this.pl_screen.BackColor = System.Drawing.Color.Silver;
            this.pl_screen.Location = new System.Drawing.Point(12, 129);
            this.pl_screen.Name = "pl_screen";
            this.pl_screen.Size = new System.Drawing.Size(399, 325);
            this.pl_screen.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Dừng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 96);
            this.progressBar1.MarqueeAnimationSpeed = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(398, 23);
            this.progressBar1.Step = 30;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Value = 80;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Napdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 466);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_thongbaoloi);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.txt_colums);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pl_screen);
            this.Name = "Form_Napdata";
            this.Text = "Form_Napdata";
            this.Load += new System.EventHandler(this.Form_Napdata_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_thongbaoloi;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.TextBox txt_colums;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pl_screen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}