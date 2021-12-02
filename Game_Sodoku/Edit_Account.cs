using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Sodoku
{
    public partial class frm_Edit_Account : Form
    {
        public frm_Edit_Account()
        {
            InitializeComponent();
        }
        private string chuoiketnoi = @"Data Source=DESKTOP-C27CGBC\SQLEXPRESS;Initial Catalog=Account_GameSodoku;Integrated Security=True";
        private SqlConnection con;
        private SqlCommand command;
        private void txtmkmoi_TextChanged(object sender, EventArgs e)
        {
            if (txtmkcu.Text.Length >= 8)
            {
                if (string.Compare(txtmkcu.Text, txtmkmoi.Text, true) == 0)
                {
                    btn_luu.Enabled = true;
                    lb_ktramk.Text = "";
                }
                else
                {
                    btn_luu.Enabled = false;
                    lb_ktramk.ForeColor = Color.Red;
                    lb_ktramk.Text = "không khớp";
                }
            }
        }
        public string tentaikhoan;
        private string name_image_player = "avatarnull.jpg";
        private void frm_Edit_Account_Load(object sender, EventArgs e)
        {
            lb_tentaikhoan.Text = tentaikhoan;
            btn_luu.Enabled = false;
            try
            {
                con = new SqlConnection(chuoiketnoi);
                con.Open();
                string sql1 = "select * from account where (username=N'" + tentaikhoan + "')";
                command = new SqlCommand(sql1, con);
                command.ExecuteNonQuery();
                SqlDataReader dr = command.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    lb_nameingame.Text = dr[3].ToString();
                    lb_tentaikhoan.Text = dr[1].ToString();
                    if (dr[5].ToString() != "")
                    {
                        name_image_player = dr[5].ToString();
                    }
                }
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\images\\" + name_image_player);
                con.Close();
            }
            catch { }
        }

        private void frm_Edit_Account_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    con = new SqlConnection(chuoiketnoi);
                    con.Open();
                    string doipass = "UPDATE account SET password=@PASSWORD WHERE username=@USERNAME";
                    command = new SqlCommand(doipass, con);
                    command.Parameters.AddWithValue("@USERNAME", tentaikhoan);
                    command.Parameters.AddWithValue("@PASSWORD", txtmkcu.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Đổi mật khẩu thành công !");
                    this.Close();
                }
                catch { MessageBox.Show("Đổi mật khẩu thất bại !"); }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

            try
            {
                con = new SqlConnection(chuoiketnoi);
                con.Open();
                string doipass = "UPDATE account SET password=@PASSWORD WHERE username=@USERNAME";
                command = new SqlCommand(doipass, con);
                command.Parameters.AddWithValue("@USERNAME", tentaikhoan);
                command.Parameters.AddWithValue("@PASSWORD", txtmkcu.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Đổi mật khẩu thành công !");
                this.Close();
            }
            catch { MessageBox.Show("Đổi mật khẩu thất bại !"); }
        }
    }
}
