using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Game_Sodoku
{
    public partial class Form_Napdata : Form
    {
        public Form_Napdata()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private string FileName_data = "data4.txt";
        private int colums_screen = 4;
        private List<List<Button>> screen;
        private List<List<int>> nhan_screen;
        private void draw_screen(int n)
        {
            screen = new List<List<Button>>();
            nhan_screen = new List<List<int>>();
            Button btnn = new Button()
            {
                Width = 40,
                Height = 40,
                Location = new Point(20, 20)
            };
            for (int i = 0; i < colums_screen; i++)
            {
                screen.Add(new List<Button>());
                nhan_screen.Add(new List<int>());
                for (int j = 0; j < colums_screen; j++)
                {
                    Button btn = new Button()
                    {
                        Width = btnn.Width,
                        Height = btnn.Height,
                        FlatStyle = FlatStyle.Flat,
                        Tag = i,
                        Location = new Point(btnn.Location.X + btnn.Width * j, btnn.Location.Y + btnn.Height * i)
                    };
                    screen[i].Add(btn);
                    nhan_screen[i].Add(0);
                    pl_screen.Controls.Add(btn);
                }
            }
        }
        private Point location_button(Button btn)
        {
            int location_X = Convert.ToInt32(btn.Tag);
            int location_Y = screen[location_X].IndexOf(btn);

            return new Point(location_X, location_Y);
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
            if (y == colums_screen)
            {
                if (x == colums_screen - 1)
                {
                    tongketqua++;
                    using (StreamWriter sw = File.AppendText(FileName_data))
                    {
                        for (int k = 0; k < colums_screen; k++)
                        {
                            for (int h = 0; h < colums_screen; h++)
                            {
                                sw.Write("" + screen[k][h].Text + " ");
                            }
                            sw.WriteLine();
                        }
                        sw.WriteLine("---------" + tongketqua + "----------");
                    }
                    //MessageBox.Show("da tim thay 1 ket qua");
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
                    for (int i = 1; i <= colums_screen; i++)
                    {
                        if (kiemtratontai(x, y, i) == true)
                        {
                            screen[x][y].Text = (i).ToString();
                            nhan_screen[x][y] = 1;

                            giai_sodoku(x, y + 1, colums);
                            screen[x][y].Text = "";
                            nhan_screen[x][y] = 0;
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
        private Thread tss;
        private void btn_run_Click(object sender, EventArgs e)
        {
            try
            {


                if (txt_colums.Text != "")
                {
                    FileName_data = "data" + txt_colums.Text + ".txt";

                    if (lb_thongbaoloi.Text == "")
                    {
                        using (StreamWriter sw = new StreamWriter(FileName_data))
                        {
                        }
                        tongketqua = 0;
                        tss = new Thread(() => giai_sodoku(0, 0, colums_screen));
                        tss.IsBackground = true;
                        tss.Start();
                        MessageBox.Show("Đang nạp file " + FileName_data);
                    }
                }
            }
            catch { }
        }


        private void Form_Napdata_Load(object sender, EventArgs e)
        {
            lb_thongbaoloi.Text = "";
        }

        private void txt_colums_TextChanged(object sender, EventArgs e)
        {
            colums_screen = int.Parse(txt_colums.Text);
            if (colums_screen < 4 || colums_screen > 9)
            {
                lb_thongbaoloi.Text = "dữ liệu lỗi, nhập từ 4 đến 9";
                pl_screen.Controls.Clear();
            }
            else
            {
                lb_thongbaoloi.Text = "";
                pl_screen.Controls.Clear();
                draw_screen(colums_screen);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformLayout();
        }
    }
}
