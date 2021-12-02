using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Sodoku
{
    public partial class frm_Create_new_account : Form
    {
        public frm_Create_new_account()
        {
            InitializeComponent();
        }
        private string chuoiketnoi = @"Data Source=DESKTOP-C27CGBC\SQLEXPRESS;Initial Catalog=Account_GameSodoku;Integrated Security=True";
        private SqlConnection con;
        private SqlCommand command;
        private int kiemtrasutontaicuataikhoan()
        {
            try
            {
                con = new SqlConnection(chuoiketnoi);
                con.Open();
                string kiemtradangnhap = "select Count(*) from account where username=@acc";
                command = new SqlCommand(kiemtradangnhap, con);
                command.Parameters.Add("@acc", txt_tentaikhoanmoi.Text);
                int x = (int)command.ExecuteScalar();
                return x;
            }
            catch { return 0; }
        }
        public delegate void getdata(string username, string password);
        public getdata mydata;
        private void taotaikhoan()
        {
            if (kiemtrasutontaicuataikhoan() == 0)
            {
                if (images_filename != null)
                {
                    button1.Enabled = true;
                    string themdulieu = "insert into account values (@username,@password,@nameingame,'0',@image)";
                    SqlCommand cmd = new SqlCommand(themdulieu, con);
                    cmd.Parameters.AddWithValue("@username", txt_tentaikhoanmoi.Text);
                    cmd.Parameters.AddWithValue("@password", txt_matkhaulan1.Text);
                    cmd.Parameters.AddWithValue("@nameingame", txt_name_ingame.Text);
                    cmd.Parameters.AddWithValue("@image", images_filename);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo tài khoản thành công !");
                    this.Close();
                }
                else
                {
                    button1.Enabled = true;
                    string themdulieu = "insert into account values (@username,@password,@nameingame,'0',null)";
                    SqlCommand cmd = new SqlCommand(themdulieu, con);
                    cmd.Parameters.AddWithValue("@username", txt_tentaikhoanmoi.Text);
                    cmd.Parameters.AddWithValue("@password", txt_matkhaulan1.Text);
                    cmd.Parameters.AddWithValue("@nameingame", txt_name_ingame.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo tài khoản thành công !");
                    this.Close();
                }
                mydata(txt_tentaikhoanmoi.Text, txt_matkhaulan1.Text);
            }
        }
        private string images_filename = null;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog chonfileanh = new OpenFileDialog();
            chonfileanh.Filter = chonfileanh.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|";
            chonfileanh.FilterIndex = 1;
            chonfileanh.RestoreDirectory = true;
            if (chonfileanh.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = chonfileanh.FileName;
                images_filename = chonfileanh.SafeFileName;
            }
            Image.FromFile(chonfileanh.FileName).Save(Application.StartupPath + "\\images\\"+images_filename);
        }

        private void txt_tentaikhoanmoi_TextChanged(object sender, EventArgs e)
        {

            if (kiemtrasutontaicuataikhoan() == 1)
            {
                lb_baoloitentaikhoan.ForeColor = Color.Red;
                lb_baoloitentaikhoan.Text = "Tên tài khoản đã tồn tại";
            }
            else
            {
                if (txt_tentaikhoanmoi.Text == "")
                {
                    lb_baoloitentaikhoan.ForeColor = Color.Red;
                    lb_baoloitentaikhoan.Text = "chưa nhập tên tài khoản";
                }
                else
                {
                    lb_baoloitentaikhoan.Text = "";
                }
            }
        }

        private void txt_matkhaulan1_TextChanged(object sender, EventArgs e)
        {
            if (txt_matkhaulan1.Text == "")
            {
                lb_baoloimatkhau.ForeColor = Color.Red;
                lb_baoloimatkhau.Text = "Chưa nhập mật khẩu";
            }
            else
            {
                if (txt_matkhaulan1.Text.Length < 8)
                {
                    lb_baoloimatkhau.ForeColor = Color.Red;
                    lb_baoloimatkhau.Text = "Mật khẩu quá ngắn !";
                }
                else
                {
                    lb_baoloimatkhau.Text = "";
                }
            }
        }

        private void txt_matkhaulan2_TextChanged(object sender, EventArgs e)
        {
            if (txt_matkhaulan1.Text.Length >= 8)
            {
                if (string.Compare(txt_matkhaulan1.Text, txt_matkhaulan2.Text) != 0)
                {
                    button1.Enabled = false;
                    lb_baoloimatkhaunhaplai.ForeColor = Color.Red;
                    lb_baoloimatkhaunhaplai.Text = "mật khẩu không khớp";
                }
                else
                {
                    button1.Enabled = true;
                    lb_baoloimatkhaunhaplai.Text = "";
                }
            }
            else
            {
                button1.Enabled = false;
                lb_baoloimatkhau.Text = "mật khẩu quá ngắn !";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            taotaikhoan();
        }

        private void frm_Create_new_account_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                taotaikhoan();
            }
        }
    }
}
