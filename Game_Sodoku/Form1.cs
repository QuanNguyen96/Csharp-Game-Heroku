using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Data.SqlClient;

namespace Game_Sodoku
{
    public partial class frm_game : Form
    {
        public frm_game()
        {
            InitializeComponent();
        }
        private int colums_screen = 4;
        public string username;
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-C27CGBC\SQLEXPRESS;Initial Catalog=Account_GameSodoku;Integrated Security=True");
        private SqlCommand cmd;
        private string name_image_player = "avatarnull.jpg";
        private void load_thongtinnguoichoi()
        {
            con.Open();
            string timkiem = "select * from account where (username=N'"+username+"')";
            cmd = new SqlCommand(timkiem, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            lb_nameingame.Text = dr[3].ToString();
            if(dr[5].ToString()!="")
            {
                name_image_player = dr[5].ToString();
            }
            lb_diemtichluy.Text = dr[4].ToString();
            ptb_image.Image = Image.FromFile(Application.StartupPath + "\\images\\"+name_image_player);
            con.Close();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private SqlDataAdapter da = null;
        private DataSet ds = null;
        private SqlCommandBuilder sqlCB = null;
        private void loaddatagridview()
        {
            con.Open();
            try
            {

                da = new SqlDataAdapter("SELECT * FROM  account", con);
                sqlCB = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "account");
                data.DataSource = ds.Tables["account"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_tieptuc.Enabled = false;
            btn_kiemtra.Enabled = false;
            load_thongtinnguoichoi();
            thoigiantimer = thoigianchay;
            lb_thoigianconlai.Text = thoigianchay.ToString();
            loaddatagridview();
            data.Hide();
            read_rank();
            lb_xephang.Text = xh[UsernamePlayer.IndexOf(username)].Xephang.ToString();
            if(int.Parse(lb_sogoiy.Text)>0)
            {
                btn_sudunggoiy.Enabled = true;
            }
            else
            {
                btn_sudunggoiy.Enabled = false;
            }
            draw_screen(9);
        }
        private List<List<TextBox>> screen;
        private List<List<int>> nhan_screen;
        private void draw_screen(int colums_screen)
        {
            pl_screen.Controls.Clear();
            screen = new List<List<TextBox>>();
            nhan_screen = new List<List<int>>();
            TextBox btnn = new TextBox()
            {
                Width = 60,
                Height = 60,
                Multiline = true,
                Location = new Point(20, 20)
            };
            for(int i=0;i< colums_screen; i++)
            {
                screen.Add(new List<TextBox>());
                nhan_screen.Add(new List<int>());
                for(int j=0;j<colums_screen;j++)
                {
                    TextBox btn = new TextBox()
                    {
                        Width = btnn.Width,
                        Height = btnn.Height,
                        Multiline = true,
                        TextAlign = HorizontalAlignment.Center,
                        Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        Tag = i,
                        Location = new Point(btnn.Location.X + btnn.Width * j, btnn.Location.Y + btnn.Height * i)
                    };
                    screen[i].Add(btn);
                    nhan_screen[i].Add(0);
                    pl_screen.Controls.Add(btn);
                    btn.KeyPress += Btn_KeyPress;
                    btn.TextChanged += Btn_TextChanged;
                    btn.ReadOnly = true;
                }
            }
        }

        private void Btn_TextChanged(object sender, EventArgs e)
        {
           TextBox tb = sender as TextBox;
            Point toado = location_button(tb);
            if (tb.Text != "")
            {
                nhan_screen[toado.X][toado.Y] = 1;
            }
        }
        
       
        private void Btn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
              
                e.Handled = true;
            }
            
        }
        private Point location_button(TextBox btn)
        {
            int location_X = Convert.ToInt32(btn.Tag);
            int location_Y = screen[location_X].IndexOf(btn);
            
            return new Point(location_X,location_Y);
        }


        #region --- Giải thuật toán cho game sodoku---

        private void ganlainhan_screen()
        {
            for (int i = 0; i < colums_screen; i++)
            {
                for (int j = 0; j < colums_screen; j++)
                {
                    nhan_screen[i][j] = 0;
                }
            }

        }
        private bool kiemtratontai(int x, int y, int k)
        {
            for (int i = 0; i < colums_screen; i++)
            {
                if (nhan_screen[x][i] == 1)
                {
                    if (int.Parse(screen[x][i].Text) == k)
                    {
                        return false;
                    }
                }

            }
            for (int i = 0; i < colums_screen; i++)
            {
                if (nhan_screen[i][y] == 1)
                {
                    if (int.Parse(screen[i][y].Text) == k)
                    {
                        return false;
                    }
                }

            }
            return true;
        }
        private int tongketqua = 0;
        private void giai_sodoku(int x, int y, int colums)
        {

            if (y == colums)
            {
                if (x == colums - 1)
                {
                    tongketqua++;
                    for (int h = 0; h < colums; h++)
                    {
                        for (int k = 0; k < colums; k++)
                        {
                            nhan_screen[h][k] = 1;
                        }
                    }
                    return;
                }
                else
                {
                    giai_sodoku(x + 1, 0, colums);
                }
            }
            else
            {
                if (nhan_screen[x][y] == 0)
                {
                    for (int i = 1; i <= colums; i++)
                    {
                        if (kiemtratontai(x, y, i) == true)
                        {
                            if (tongketqua < 1)
                            {
                                screen[x][y].Text = (i).ToString();
                                nhan_screen[x][y] = 1;

                                giai_sodoku(x, y + 1, colums);
                                nhan_screen[x][y] = 0;
                            }
                        }
                    }
                }
                else
                {
                    giai_sodoku(x, y + 1, colums);
                }
            }

        }
        #endregion

        
        private void ptb_image_Click(object sender, EventArgs e)
        {
            frm_Show_Account frm = new frm_Show_Account();
            frm.mydata += new frm_Show_Account.getdata(getvalue);
            frm.name_player = username;
            frm.Show();
        }
        private void getvalue(string images_filename)
        {
            ptb_image.Image = Image.FromFile(Application.StartupPath + "\\images\\" + images_filename);
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan hd = new HuongDan();
            hd.ShowDialog();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTin tt = new ThongTin();
            tt.ShowDialog();
        }

        private void lịchSửToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void giảiĐấu10010VòngĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chơiĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void khóToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trungBìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dễToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private List<int> DsNull;
        private void napdulieu(string file,int cot,int dokho,int vitri_kqrandom)
        {
            ganlainhan_screen();
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    int vtrihientaicuadong = 0;
                    int dong = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        vtrihientaicuadong++;
                        if (vtrihientaicuadong >= (vitri_kqrandom - 1) * (cot + 1) + 1 && vtrihientaicuadong < vitri_kqrandom * (cot + 1))
                        {
                            string[] data = line.Split(' ');
                            for (int i = 0; i < cot; i++)
                            {
                                if (string.Compare(data[i], "0") == 0)
                                {
                                    screen[dong][i].Text = "";
                                    nhan_screen[dong][i] = 0;

                                }
                                else
                                {
                                    screen[dong][i].Text = data[i];
                                    nhan_screen[dong][i] = 1;
                                    screen[dong][i].BackColor = Color.Gainsboro;
                                    screen[dong][i].ReadOnly = true;
                                }
                            }
                            dong++;
                        }
                    }
                    DsNull = new List<int>();
                    int dem = 0;
                    int c = cot;
                    while (dem <= dokho)
                    {
                        Random rd = new Random();
                        int o = rd.Next(0, cot * cot - 1);
                        if (DsNull.Contains(o) == false)
                        {
                            dem++;
                            DsNull.Add(o);
                            int row = (int)(o / c);
                            int colum = o % c;
                            screen[row][colum].Text = "";
                            screen[row][colum].BackColor = Color.WhiteSmoke;
                            screen[row][colum].ReadOnly = false;
                            nhan_screen[row][colum] = 0;
                        }
                    }

                }
            }
            catch (Exception e)
            {
                // thong bao loi.
                MessageBox.Show("Có lỗi phát sinh : ");
                MessageBox.Show(e.Message);
            }
        }
        private int loai = 1;
        private int diem = 1;
        private void cb_ban_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            btn_kiemtra.Enabled = false;
            btn_tieptuc.Enabled = false;
            btn_xemketqua.Enabled = false;
            if(cb_hinhthuc.Text == "Đấu Giải")
            {
                loai = 19;
                cb_ban.Enabled = false;
                cb_mucdo.Enabled = false;
            }
            else
            {
                cb_ban.Enabled = true;
                cb_mucdo.Enabled = true;
                if (cb_hinhthuc.Text == "Chơi Đơn" && cb_ban.Text == "9" && cb_mucdo.Text == "Khó")
                {
                    loai = 1;
                }
                if (cb_hinhthuc.Text == "Chơi Đơn" && cb_ban.Text == "9" && cb_mucdo.Text == "Trung Bình")
                {
                    loai = 2;
                }
                if (cb_hinhthuc.Text == "Chơi Đơn" && cb_ban.Text == "9" && cb_mucdo.Text == "Dễ")
                {
                    loai = 3;
                }
                if (cb_hinhthuc.Text == "Chơi Đơn" && cb_ban.Text == "8" && cb_mucdo.Text == "Khó")
                {
                    loai = 4;
                }
                if (cb_hinhthuc.Text == "Chơi Đơn" && cb_ban.Text == "8" && cb_mucdo.Text == "Trung Bình")
                {
                    loai = 5;
                }
                if (cb_hinhthuc.Text == "Chơi Đơn" && cb_ban.Text == "8" && cb_mucdo.Text == "Dễ")
                {
                    loai = 6;
                }
                if (cb_hinhthuc.Text == "Chơi Đơn" && cb_ban.Text == "7" && cb_mucdo.Text == "Khó")
                {
                    loai = 7;
                }
                if (cb_hinhthuc.Text == "Chơi Đơn" && cb_ban.Text == "7" && cb_mucdo.Text == "Trung Bình")
                {
                    loai = 8;
                }
                if (cb_hinhthuc.Text == "Chơi Đơn" && cb_ban.Text == "7" && cb_mucdo.Text == "Dễ")
                {
                    loai = 9;
                }
                if (cb_hinhthuc.Text == "Chơi Đơn" && cb_ban.Text == "6" && cb_mucdo.Text == "Khó")
                {
                    loai = 10;
                }
                if (cb_hinhthuc.Text == "Chơi Đơn" && cb_ban.Text == "6" && cb_mucdo.Text == "Trung Bình")
                {
                    loai = 11;
                }
                if (cb_hinhthuc.Text == "Chơi Đơn" && cb_ban.Text == "6" && cb_mucdo.Text == "Dễ")
                {
                    loai = 12;
                }
                if (cb_hinhthuc.Text == "Chơi Đơn" && cb_ban.Text == "5" && cb_mucdo.Text == "Khó")
                {
                    loai = 13;
                }
                if (cb_hinhthuc.Text == "Chơi Đơn" && cb_ban.Text == "5" && cb_mucdo.Text == "Trung Bình")
                {
                    loai = 14;
                }
                if (cb_hinhthuc.Text == "Chơi Đơn" && cb_ban.Text == "5" && cb_mucdo.Text == "Dễ")
                {
                    loai = 15;
                }
                if (cb_hinhthuc.Text == "Chơi Đơn" && cb_ban.Text == "4" && cb_mucdo.Text == "Khó")
                {
                    loai = 16;
                }
                if (cb_hinhthuc.Text == "Chơi Đơn" && cb_ban.Text == "4" && cb_mucdo.Text == "Trung Bình")
                {
                    loai = 17;
                }
                if (cb_hinhthuc.Text == "Chơi Đơn" && cb_ban.Text == "4" && cb_mucdo.Text == "Dễ")
                {
                    loai = 18;
                }
            }
            if(loai==1)
            {
                diem = 5;
                thoigianchay = 600;
            }
            if (loai == 2 || loai == 4)
            {
                diem = 4;
                thoigianchay = 500;
            }
            if (loai == 3 || loai == 5 || loai == 7)
            {
                diem = 3;
                thoigianchay = 420;
            }
            if (loai == 6 || loai == 8)
            {
                diem = 2;
                thoigianchay = 360;
            }
            if(loai==19)
            {
                diem = 60;
                thoigianchay = 5000;
            }
            lb_diemvan.Text = diem.ToString();
            thoigiantimer = thoigianchay;
            lb_thoigianconlai.Text = thoigiantimer.ToString();
        }
        private void play()
        {
            btn_kiemtra.Enabled = true;
            btn_xemketqua.Enabled = true;
            cb_hinhthuc.Enabled = false;
            cb_ban.Enabled = false;
            cb_mucdo.Enabled = false;
            button1.Enabled = false;
            string tenfile = "data" + cb_ban.Text + ".txt";
            Random rd = new Random();
            timer1.Start();
            try
            {
                if (loai == 1)
                {
                    napdulieu(tenfile, int.Parse(cb_ban.Text), 23, rd.Next(1, 100));
                }
                else
                {
                    if (loai == 2 || loai == 4)
                    {
                        napdulieu(tenfile, int.Parse(cb_ban.Text), 27, rd.Next(1, 100));
                    }
                    else
                    {
                        if (loai == 3 || loai == 5 || loai == 7)
                        {
                            napdulieu(tenfile, int.Parse(cb_ban.Text), 30, rd.Next(1, 100));
                        }
                        else
                        {
                            if (loai == 6 || loai == 8)
                            {
                                napdulieu(tenfile, int.Parse(cb_ban.Text), 33, rd.Next(1, 100));
                            }
                            else
                            {
                                napdulieu(tenfile, int.Parse(cb_ban.Text), 10, rd.Next(1, 100));
                            }
                        }
                    }
                }
            }
            catch { }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(int.Parse(lb_sogoiy.Text)<=0)
            {
                btn_sudunggoiy.Enabled = false;
            }
            else
            {
                btn_sudunggoiy.Enabled = true;
            }
            valueprocessbar = 100;
           
            btn_kiemtra.Enabled = false;
            btn_xemketqua.Enabled = true;
            btn_kiemtra.Enabled = true;
            cb_hinhthuc.Enabled = false;
            cb_ban.Enabled = false;
            cb_mucdo.Enabled = false;
            button1.Enabled = false;
            string tenfile = "data" + cb_ban.Text + ".txt";
            Random rd = new Random();
            timer1.Start();
            try
            {
                if (loai == 1)
                {
                    napdulieu(tenfile, int.Parse(cb_ban.Text), 23, rd.Next(1, 100));
                }
                else
                {
                    if (loai == 2 || loai == 4)
                    {
                        napdulieu(tenfile, int.Parse(cb_ban.Text), 27, rd.Next(1, 100));
                    }
                    else
                    {
                        if (loai == 3 || loai == 5 || loai == 7)
                        {
                            napdulieu(tenfile, int.Parse(cb_ban.Text), 30, rd.Next(1, 100));
                        }
                        else
                        {
                            if (loai == 6 || loai == 8)
                            {
                                napdulieu(tenfile, int.Parse(cb_ban.Text), 33, rd.Next(1, 100));
                            }
                            else
                            {
                                napdulieu(tenfile, int.Parse(cb_ban.Text), 10, rd.Next(1, 100));
                            }
                        }
                    }
                }
            }
            catch { }

        }
        private int thoigianchay = 600;
        private int thoigiantimer=0 ;
        private int valueprocessbar = 100;
        private void timer1_Tick(object sender, EventArgs e)
        {
            thoigiantimer--;
            lb_thoigianconlai.Text = thoigiantimer.ToString();
            if(thoigiantimer <= 0)
            {
                thoigiantimer = thoigianchay;
                timer1.Stop();
                MessageBox.Show("thua cuộc,hết giờ");
                cb_hinhthuc.Enabled = true;
                cb_ban.Enabled = true;
                cb_ban.Enabled = true;
                btn_kiemtra.Enabled = false;
            }
            if(thoigiantimer%(thoigianchay/100)==0)
            {
                valueprocessbar--;
                progressBar1.Value = valueprocessbar;
                if(valueprocessbar<=10)
                {
                    progressBar1.ForeColor = Color.Red;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(loai==1)
            {

            }
            
        }
        private int sovanwin = 0;
        private int tongdiemkiemduoctrongngay = 0;
        private void btn_kiemtra_Click(object sender, EventArgs e)
        {
            colums_screen = int.Parse(cb_ban.Text);
            bool kiemtraketqua = true;
            List<string> manghangtu1den9;
            List<string> mangcottu1den9;
            for (int i = 0; i < colums_screen; i++)
            {
                manghangtu1den9 = new List<string>();
                mangcottu1den9 = new List<string>();
                for (int j = 0; j < colums_screen; j++)
                {
                    // MessageBox.Show("" + screen[i][j].Text);
                    if (manghangtu1den9.Contains(screen[i][j].Text) == true)
                    {
                        kiemtraketqua = false;
                        break;
                    }
                    else
                    {
                        manghangtu1den9.Add(screen[i][j].Text);
                    }
                    if (mangcottu1den9.Contains(screen[j][i].Text) == true)
                    {
                        kiemtraketqua = false;
                        break;
                    }
                    else
                    {
                        mangcottu1den9.Add(screen[j][i].Text);
                    }
                }

            }
            if (kiemtraketqua == true && thoigiantimer >= 0)
            {
                timer1.Stop();
                MessageBox.Show("Đã Win");
                sovanwin++;
                tongdiemkiemduoctrongngay += int.Parse(lb_diemvan.Text);
                lb_sovanwin.Text = sovanwin.ToString();
                lb_tongdiemkiemduoc.Text = tongdiemkiemduoctrongngay.ToString();
                int diemtichluy = int.Parse(lb_diemtichluy.Text) + int.Parse(lb_diemvan.Text);
                lb_diemtichluy.Text = diemtichluy.ToString();
                updatedulieu();
                lb_xephang.Text = xh[UsernamePlayer.IndexOf(username)].Xephang.ToString();
                cb_hinhthuc.Enabled = true;
                btn_tieptuc.Enabled = true;
                btn_kiemtra.Enabled = false;
                btn_xemketqua.Enabled = false;
                btn_sudunggoiy.Enabled = false;
                if (cb_hinhthuc.Text == "Đấu Giải")
                {
                    cb_ban.Enabled = false;
                    cb_mucdo.Enabled = false;
                }
                else
                {
                    cb_ban.Enabled = true;
                    cb_mucdo.Enabled = true;
                }
                for (int i = 0; i < colums_screen; i++)
                {
                    for (int j = 0; j < colums_screen; j++)
                    {
                        screen[i][j].ReadOnly = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Kết quả chưa đúng");
                btn_tieptuc.Enabled = false;
                btn_kiemtra.Enabled = true;
                btn_xemketqua.Enabled = true;
            }
        }
        private struct xephang_player
        {
            private string id;

            private string username;
            private string password;
            private string name;
            private string point;
            private string image;
            private int xephang;
            public string Id
            {
                get { return id; }
                set { id = value; }
            }


            public string Username
            {
                get { return username; }
                set { username = value; }
            }
            public string Password
            {
                get { return password; }
                set { password = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Point
            {
                get { return point; }
                set { point = value; }
            }
            public string Image
            {
                get { return image; }
                set { image = value; }
            }
            public int Xephang
            {
                get { return xephang; }
                set { xephang = value; }
            }
            public xephang_player(string _id, string _username, string _password, string _name, string _point, string _image, int _xephang)
            {
                this.id = _id;
                this.username = _username;
                this.password = _password;
                this.name = _name;
                this.point = _point;
                this.xephang = _xephang;
                this.image = _image;
            }
        }
        private List<xephang_player> xh;
        private List<string> UsernamePlayer;
        private void read_rank()
        {
            xh = new List<xephang_player>();
            UsernamePlayer = new List<string>();
            con.Open();
            string sql = "select* from account order by point desc";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            int hang = 0;
            int point_border = -10;
            int hang1 = 0;
            while (dr.Read())
            {
                hang1++;

                if (point_border == int.Parse(dr[4].ToString()))
                {
                }
                else
                {
                    hang = hang1;
                }
                point_border = int.Parse(dr[4].ToString());
                for (int i = 0; i < data.RowCount - 1; i++)
                {
                    if (string.Compare(dr[1].ToString(), data.Rows[i].Cells["username"].Value.ToString(), true) == 0)
                    {
                        xh.Add(new xephang_player(data.Rows[i].Cells["id"].Value.ToString(), data.Rows[i].Cells["username"].Value.ToString(), data.Rows[i].Cells["password"].Value.ToString(), data.Rows[i].Cells["name"].Value.ToString(), data.Rows[i].Cells["point"].Value.ToString(), data.Rows[i].Cells["image"].Value.ToString(), hang));
                        UsernamePlayer.Add(data.Rows[i].Cells["username"].Value.ToString());
                        break;
                    }
                }
            }
            con.Close();

        }
        private void updatedulieu()
        {
            try
            {
                con.Open();
                string them = "UPDATE account SET point=@point WHERE username=@username";
                SqlCommand cmd = new SqlCommand(them, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@point", lb_diemtichluy.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                read_rank();
            }
            catch { con.Close(); }
        }

        private void lb_tongdiemkiemduoc_TextChanged(object sender, EventArgs e)
        {
            int tongsogoiy = int.Parse(lb_tongdiemkiemduoc.Text) / 5;
            lb_sogoiy.Text = tongsogoiy.ToString();
        }

        private void lb_sogoiy_TextChanged(object sender, EventArgs e)
        {
            if(int.Parse(lb_sogoiy.Text)>0)
            {
                btn_sudunggoiy.Enabled = true;
            }
            else
            {
                btn_sudunggoiy.Enabled = false;
            }
        }

        private void cb_ban_SelectedIndexChanged(object sender, EventArgs e)
        {
            draw_screen(int.Parse(cb_ban.Text));
            DsNull = new List<int>();
            if(menutaoketqua==true)
            {
                lb_sogoiy.Text = "" + (int.Parse(cb_ban.Text) * int.Parse(cb_ban.Text)).ToString();
                button1.Enabled = false;
                btn_kiemtra.Enabled = true;
                btn_sudunggoiy.Enabled = true;
                btn_xemketqua.Enabled = true;
            }
        }
        private  bool kiemtradienso=true;
        private void btn_xemketqua_Click(object sender, EventArgs e)
        {
            colums_screen = int.Parse(cb_ban.Text);
            if (DsNull != null)
            {
                for (int i = 0; i < DsNull.Count; i++)
                {
                    int row = (int)(DsNull[i] / colums_screen);
                    int colum = DsNull[i] % colums_screen;
                    if (nhan_screen[row][colum] == 1)
                    {
                        nhan_screen[row][colum] = 0;
                        if (screen[row][colum].Text != "")
                        {
                            kiemtradienso = kiemtratontai(row, colum, int.Parse(screen[row][colum].Text));
                        }
                    }
                }
            }
            if (kiemtradienso == true)
            {
                

                for (int h = 0; h < colums_screen; h++)
                {
                    for (int k = 0; k < colums_screen; k++)
                    {
                        if (screen[h][k].Text == "")
                        {
                            nhan_screen[h][k] = 0;
                        }
                        else
                        {
                            nhan_screen[h][k] = 1;
                        }

                    }
                }
                tongketqua = 0;
                giai_sodoku(0, 0, colums_screen);
                if (tongketqua == 0)
                {
                    MessageBox.Show("Ko thể tìm ra kết quả, xin vui lòng nhập lại ");
                    for (int i = 0; i < DsNull.Count; i++)
                    {
                        int row1 = (int)(DsNull[i] / colums_screen);
                        int colum1 = DsNull[i] % colums_screen;
                        screen[row1][colum1].Text = "";
                        screen[row1][colum1].ReadOnly = false;
                        nhan_screen[row1][colum1] = 0;

                    }
                }
            }
            else
            {
                MessageBox.Show("Ko thể tìm ra kết quả, xin vui lòng nhập lại ");
            }
        }

        private void btn_tieptuc_Click(object sender, EventArgs e)
        {
            if (int.Parse(lb_sogoiy.Text) <= 0)
            {
                btn_sudunggoiy.Enabled = false;
            }
            else
            {
                btn_sudunggoiy.Enabled = true;
            }
            btn_kiemtra.Enabled = true;
            play();
            valueprocessbar = 100;
            btn_tieptuc.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
        private void btn_sudunggoiy_Click(object sender, EventArgs e)
        {
            lb_sogoiy.Text = (int.Parse(lb_sogoiy.Text) - 1).ToString();
            

            // giải rồi điền gợi ý cho người chơi
            colums_screen = int.Parse(cb_ban.Text);
            tongketqua = 0;
            giai_sodoku(0, 0, colums_screen);
            for (int h = 0; h < colums_screen; h++)
            {
                for (int k = 0; k < colums_screen; k++)
                {
                    nhan_screen[h][k] = 1;
                }
            }
            if(DsNull==null)
            {
                DsNull = new List<int>();
                for(int i=0;i<colums_screen;i++)
                {
                    for (int j = 0; j < colums_screen; j++)
                    {
                        DsNull.Add(i * colums_screen + j);
                    }
                }
            }
            Random rd = new Random();
            int chon = rd.Next(0, DsNull.Count - 1);
            int row = (int)(DsNull[chon] / colums_screen);
            int colum = DsNull[chon] % colums_screen;
            screen[row][colum].BackColor = Color.Pink;
            screen[row][colum].ReadOnly = true;
            DsNull.Remove(DsNull[chon]);

            for (int i = 0; i < DsNull.Count; i++)
            {
                int row1 = (int)(DsNull[i] / colums_screen);
                int colum1 = DsNull[i] % colums_screen;
                screen[row1][colum1].Text = "";
                screen[row1][colum1].ReadOnly = false;
                nhan_screen[row1][colum1] = 0;

            }
            
            // MessageBox.Show("" + mangketquagoiy[row, colum].ToString());
            //screen[row][colum].Text = mangketquagoiy[row, colum].ToString();
            //
        }

        private void tựTạoXemKếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cb_hinhthuc.Enabled = false;
            cb_ban.Enabled = true;
            cb_mucdo.Enabled = false;
            button1.Enabled = false;
            btn_kiemtra.Enabled = true;
            btn_tieptuc.Enabled = false;
            btn_xemketqua.Enabled = true;
            btn_sudunggoiy.Enabled = true;
            lb_sogoiy.Text = ""+(int.Parse(cb_ban.Text)* int.Parse(cb_ban.Text)).ToString();
            menutaoketqua = true;
        }
        private bool menutaoketqua = true;
        private void mànHìnhChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cb_hinhthuc.Enabled = true;
            cb_ban.Enabled = true;
            cb_mucdo.Enabled = true;
            button1.Enabled = true;
            btn_xemketqua.Enabled = false;
            btn_kiemtra.Enabled = false;
            btn_tieptuc.Enabled = false;
            btn_sudunggoiy.Enabled = false;
            lb_sogoiy.Text = "0";
            menutaoketqua = false;
        }

        private void colorScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog(); //Khởi tạo đối tượng ColorDialog 
            dlg.ShowDialog(); //Hiển thị hộp thoại

            if (dlg.ShowDialog() == DialogResult.OK) //Nếu nhấp vào nút OK trên hộp thoại
            {
                this.BackColor = dlg.Color;
                menuStrip1.BackColor = dlg.Color;
            }
        }
    }
}
