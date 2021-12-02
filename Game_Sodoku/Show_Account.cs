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
    public partial class frm_Show_Account : Form
    {
        public frm_Show_Account()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-C27CGBC\SQLEXPRESS;Initial Catalog=Account_GameSodoku;Integrated Security=True");
        SqlCommand cmd;
        private string images_filename;
        private void avatar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog chonfileanh = new OpenFileDialog();
                chonfileanh.Filter = chonfileanh.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|";
                chonfileanh.FilterIndex = 1;
                chonfileanh.RestoreDirectory = true;
                if (chonfileanh.ShowDialog() == DialogResult.OK)
                {
                    // anhchon = Image.FromFile(chonfileanh.FileName);
                    //anhSV.Image = anhchon;
                    avatar.ImageLocation = chonfileanh.FileName;
                    images_filename = chonfileanh.SafeFileName;
                    button1.Enabled = true;
                }
                Image.FromFile(chonfileanh.FileName).Save(Application.StartupPath + "\\images\\" + images_filename);
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi trùng tên file, xin vui lòng đổi tên file vs ảnh hiện tại");
            }
        }
        public delegate void getdata(string imgaes);
        public getdata mydata;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "UPDATE account SET image=@Image WHERE username=@Username";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Username", name_player);
                cmd.Parameters.AddWithValue("@Image", images_filename);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Đổi avatar thành công !");
                button1.Enabled = false;

                mydata(images_filename);
            }
            catch { }
        } 
        
        public string name_player;
        private int rank_top = 1;
        private string name_image_player = "avatarnull.jpg";
        private void frm_Show_Account_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql1 = "select * from account where (username=N'" + name_player + "')";
                string sql2 = "select* from account order by point desc";
                cmd = new SqlCommand(sql1, con);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    lb_tentk.Text = dr[3].ToString();
                    lb_diem.Text = dr[4].ToString();
                    if (dr[5].ToString() != "")
                    {
                        name_image_player = dr[5].ToString();
                    }
                    avatar.Image = Image.FromFile(Application.StartupPath + "\\images\\" + name_image_player);
                }
                con.Close();
                con.Open();
                SqlCommand cmd1 = new SqlCommand(sql2, con);
                cmd1.ExecuteNonQuery();
                SqlDataReader dr1 = cmd1.ExecuteReader();
                int hang = 0;
                while (dr1.Read())
                {
                    hang++;
                    if(string.Compare(dr1[1].ToString(),name_player,true)==0)
                    {
                        rank_top = hang;
                    }
                }
                con.Close();
                lb_xephang.Text = rank_top.ToString();
            }
            catch { }
        }

        private void btn_edit_password_Click(object sender, EventArgs e)
        {
            frm_Edit_Account frm = new frm_Edit_Account();
            frm.tentaikhoan += name_player;
            frm.ShowDialog();
        }
    }
}
