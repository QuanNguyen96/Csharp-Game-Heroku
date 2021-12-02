using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Game_Sodoku
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private string str_connect = @"Data Source=DESKTOP-C27CGBC\SQLEXPRESS;Initial Catalog=Account_GameSodoku;Integrated Security=True";
        private SqlConnection con;
        private SqlCommand command;
        private void login()
        {
            if (txt_user.Text == "admin" && txt_pass.Text == "admin")
            {
                QuanLy_Account frm = new QuanLy_Account();
                frm.Show();
            }
            else
            {


                con = new SqlConnection(str_connect);
                con.Open();
                string kiemtradangnhap = "select Count(*) from account where username=@UserName and password=@PassWord";
                command = new SqlCommand(kiemtradangnhap, con);
                command.Parameters.Add("@UserName", txt_user.Text);
                command.Parameters.Add("@PassWord", txt_pass.Text);
                int x = (int)command.ExecuteScalar();
                if (x == 1)
                {
                    this.Hide();
                    frm_game frm = new frm_game();
                    frm.username = txt_user.Text;
                    frm.ShowDialog();

                }
                else
                {
                    lb_login.ForeColor = Color.Red;
                    lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
                    lb_login.Text = "bạn đã nhập sai tên đăng nhập hoặc mật khẩu,xin vui lòng kiểm tra lại!";
                }
                con.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            lb_login.Text = "";
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            login();
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            lb_login.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = txt_pass.PasswordChar == '*' ? '\0' : '*';
        }
        private void getvalue(string name, string password)
        {
            txt_user.Text = name;
            txt_pass.Text = password;
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Create_new_account frm = new frm_Create_new_account();
            frm.mydata += new frm_Create_new_account.getdata(getvalue);
            frm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("xin lỗi chưa nâng cấp chức năng , xin vui lòng thử lại","Thông báo");
        }
    }
}
