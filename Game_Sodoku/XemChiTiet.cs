using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Sodoku
{
    public partial class XemChiTiet : Form
    {
        public XemChiTiet()
        {
            InitializeComponent();
        }
        public string id = "";
        public string xephang = "0";
        public string nameingame;
        public string username;
        public string passsword;
        public string point;
        public string image="";
        private void btn_update_Click(object sender, EventArgs e)
        {

        }
        private void XemChiTiet_Load(object sender, EventArgs e)
        {
            txt_id.Text = id;
            txt_xephang.Text = xephang;
            txt_nameingame.Text = nameingame;
            txt_username.Text = username;
            txt_password.Text = passsword;
            txt_point.Text = point;
            txt_image.Text = image;
            txt_nameingame.Text = nameingame;
            if(image=="")
            {
                image = "avatarnull.jpg";
            }
            ptb_image.Image = Image.FromFile(Application.StartupPath + "\\images\\" + image);
        }
    }
}
