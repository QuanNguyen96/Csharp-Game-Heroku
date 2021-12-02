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
using System.Diagnostics;

namespace Game_Sodoku
{
    public partial class QuanLy_Account : Form
    {
        public QuanLy_Account()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-C27CGBC\SQLEXPRESS;Initial Catalog=Account_GameSodoku;Integrated Security=True");
        private SqlCommand cmd;
        private SqlDataAdapter da=null;
        private DataSet ds = null;
        private SqlCommandBuilder sqlCB = null;
        private void show_data()
        {
            con.Open();
            try
            {
                
                da = new SqlDataAdapter("SELECT *, 'Delete' AS [edit] FROM account", con);
                sqlCB = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "account");
                data.DataSource = ds.Tables["account"];
                data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                data.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    data[data.Columns.Count - 1, i] = linkCell;
                    data.Rows[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private List<xephang_player> xh;
        private List<string> IdPlayer;
        private void read_rank()
        {
            xh = new List<xephang_player>();
            IdPlayer = new List<string>();
            con.Open();
            string sql = "select* from account order by point desc";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            int hang = 0;
            int point_border =-10;
            int hang1 = 0;
            while (dr.Read())
            {
                hang1++;
                
                if (point_border== int.Parse(dr[4].ToString()))
                {
                }
                else
                {
                    hang = hang1;
                }
                point_border = int.Parse(dr[4].ToString());
                data.Rows[hang1 - 1].ReadOnly = true;
                data.Rows[hang1 - 1].Cells["select"].ReadOnly = false;
                for (int i = 0; i < data.RowCount - 1; i++)
                {
                   
                    if (string.Compare(dr[1].ToString(), data.Rows[i].Cells["username"].Value.ToString(), true) == 0)
                    {
                        data.Rows[i].Cells["rank"].Value = hang;
                        xh.Add(new xephang_player(data.Rows[i].Cells["id"].Value.ToString(), data.Rows[i].Cells["username"].Value.ToString(), data.Rows[i].Cells["password"].Value.ToString(), data.Rows[i].Cells["name"].Value.ToString(), data.Rows[i].Cells["point"].Value.ToString(), data.Rows[i].Cells["image"].Value.ToString(), hang));
                        IdPlayer.Add(data.Rows[i].Cells["id"].Value.ToString());
                        break;
                    }
                }
            }
            con.Close();
            
        }
        private void dongbodulieuvaotextbox()
        {
            txt_id.DataBindings.Clear();
            txt_id.DataBindings.Add("text", data.DataSource, "id");
            txt_username.DataBindings.Clear();
            txt_username.DataBindings.Add("text", data.DataSource, "username");
            txt_password.DataBindings.Clear();
            txt_password.DataBindings.Add("text", data.DataSource, "password");
            txt_nameingame.DataBindings.Clear();
            txt_nameingame.DataBindings.Add("text", data.DataSource, "name");
            txt_point.DataBindings.Clear();
            txt_point.DataBindings.Add("text", data.DataSource, "point");
            txt_image.DataBindings.Clear();
            txt_image.DataBindings.Add("text", data.DataSource, "image");
        }
        private void printdata()
        {
            show_data();
            dongbodulieuvaotextbox();
            read_rank();
        }
        private void QuanLy_Account_Load(object sender, EventArgs e)
        {
            try
            {
                printdata();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                update();
                printdata();
                MessageBox.Show("Update Success!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                con.Close();
                MessageBox.Show("Trùng username, hoặc có lỗi phát sinh, xin vui lòng nhập lại!");
            }
        }

        private void data_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                int lastRow = data.Rows.Count - 2;
                DataGridViewRow nRow = data.Rows[lastRow];
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                data[data.Columns.Count - 1, lastRow] = linkCell;
                nRow.Cells["edit"].Value = "Insert";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void update()
        {
            try
            {
                con.Open();
                sqlCB = new SqlCommandBuilder(da);
                da.Update(ds, "account");
                
                con.Close();
                //show_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            try
            {
                if (e.ColumnIndex == 8)
                {
                    string Task = data.Rows[e.RowIndex].Cells[data.Columns.Count - 1].Value.ToString();
                    if (Task == "Delete")
                    {
                        if (MessageBox.Show("Bạn có chắc chắm muốn xóa không?", "Đang xóa...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            data.Rows.RemoveAt(rowIndex);
                            ds.Tables["account"].Rows[rowIndex].Delete();
                            da.Update(ds, "account");
                            MessageBox.Show("Delete Successfull !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            printdata();
                        }
                    }
                    else if (Task == "Insert")
                    {
                        if (MessageBox.Show("Bạn có chắc chắm muốn thêm dữ liệukhông?", "Đang Thêm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                int row = data.Rows.Count - 2;
                                DataRow dr = ds.Tables["account"].NewRow();
                                dr["username"] = data.Rows[row].Cells["username"].Value;
                                dr["password"] = data.Rows[row].Cells["password"].Value;
                                dr["name"] = data.Rows[row].Cells["name"].Value;
                                if (data.Rows[row].Cells["point"].Value.ToString() == "")
                                {
                                    dr["point"] = "0";
                                }
                                else
                                {
                                    dr["point"] = data.Rows[row].Cells["point"].Value;
                                }
                                dr["image"] = data.Rows[row].Cells["image"].Value;
                                ds.Tables["account"].Rows.Add(dr);
                                ds.Tables["account"].Rows.RemoveAt(ds.Tables["account"].Rows.Count - 1);
                                data.Rows.RemoveAt(data.Rows.Count - 2);
                                data.Rows[e.RowIndex].Cells[data.Columns.Count - 1].Value = "Delete";
                                da.Update(ds, "account");
                                printdata();
                                MessageBox.Show("Insert Successfull !", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                data.Rows[e.RowIndex].Cells[data.Columns.Count - 1].Value = "Insert";
                                MessageBox.Show("Trùng username, hoặc có lỗi phát sinh, xin vui lòng nhập lại!");
                            }
                        }
                    }
                    else if (Task == "Update")
                    {
                        if (MessageBox.Show("Bạn có chắc chắm muốn cập nhật dữ liệu không?", "Đang edit...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                update();
                                printdata();
                                MessageBox.Show("Update Success!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                con.Close();
                                MessageBox.Show("Trùng username, hoặc có lỗi phát sinh, xin vui lòng nhập lại!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void data_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                data.CurrentRow.Selected = true;
                
            }
            catch
            {

            }
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(data.Rows[e.RowIndex].Cells["point"].Value.ToString() =="")
            {
                data.Rows[e.RowIndex].Cells["point"].Value = "0";
            }
            
        }


        #region --- insert edit delete data----------
        private void DeleteData(string id)
        {

            banghichinhsua = banghichinhsua+"\nbản ghi : (" + id + "," + xh[IdPlayer.IndexOf(id)].Username + "," + xh[IdPlayer.IndexOf(id)].Password + "," + xh[IdPlayer.IndexOf(id)].Name + "," + xh[IdPlayer.IndexOf(id)].Point + "," + xh[IdPlayer.IndexOf(id)].Image + ")";
            try
            {
                con.Open();
                string them = "DELETE FROM account WHERE id=@id";
                SqlCommand cmd = new SqlCommand(them, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                

            }
            catch
            {
                con.Close();
                MessageBox.Show("Có lỗi phát sinh, xin vui lòng kiểm tra lại !");
            }
        }
        private void InsertData(string username,string password,string name,string point,string image)
        {
            banghihientai = "Thêm dữ liệu cho bản ghi : (" + username + "," + password + "," + name + "," + point + "," + image + ")";
            if (point=="")
            {
                point = "0";
            }
            try
            {
                con.Open();
                string them = "INSERT INTO account(username,password,name,point,image) VALUES (@username,@password,@name,@point,@image)";
                SqlCommand cmd = new SqlCommand(them, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@point", point);
                cmd.Parameters.AddWithValue("@image", image);
                cmd.ExecuteNonQuery();
                con.Close();
                banghihientai = banghihientai + " thành công";
                MessageBox.Show("Insert Successfull !");
            }
            catch
            {
                banghihientai = banghihientai + " thất bại";
                con.Close();
                MessageBox.Show("UserName đã tồn tại hoặc lỗi kết nối, xin vui lòng kiểm tra lại !");
            }
        }
        private void EditData(int id, string username, string password, string name, string point, string image)
        {
            int ID = int.Parse(txt_id.Text);
            banghihientai = "Edit dữ liệu cho bản ghi ban đầu : (" + ID + "," + xh[IdPlayer.IndexOf(ID.ToString())].Username + "," + xh[IdPlayer.IndexOf(ID.ToString())].Password + "," + xh[IdPlayer.IndexOf(ID.ToString())].Name + "," + xh[IdPlayer.IndexOf(ID.ToString())].Point + "," + xh[IdPlayer.IndexOf(ID.ToString())].Image + ") --->(" + ID + "," + txt_username.Text + "," + txt_password.Text + "," + txt_nameingame.Text + "," + txt_point.Text + "," + txt_image.Text + ") .";

            try
            {
                con.Open();
                string them = "UPDATE account SET password=@password,name=@name,point=@point,image=@image WHERE id=@id";
                SqlCommand cmd = new SqlCommand(them, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@point", point);
                cmd.Parameters.AddWithValue("@image", image);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Edit Successfull !");
                banghihientai = banghihientai + "thành công";
            }
            catch {
                con.Close();
                MessageBox.Show("Có lỗi phát sinh, xin vui lòng kiểm tra lại !");
                banghihientai = banghihientai + "thất bại";
            }
        }
        #endregion



        private void btn_deleteselect_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắm muốn xóa vùng chọn không?", "Đang xóa...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < data.Rows.Count - 1; i++)
                    {
                        bool tf = false;
                        if (data.Rows[i].Cells["select"].Value != null)
                        {
                            tf = (bool)data.Rows[i].Cells["select"].Value;
                        }
                        if (tf == true)
                        {
                            DeleteData(data.Rows[i].Cells["id"].Value.ToString());
                        }
                    }
                    MessageBox.Show("Delete Successfull !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    printdata();
                    ghilichsu(DateTime.Now, "Delete Dữ liệu cho các bản ghi :" + banghichinhsua +"---> thành công");
                }
            }catch
            {
                ghilichsu(DateTime.Now, "Delete Dữ liệu cho các bản ghi :" + banghichinhsua + "--->thất bại");
            }

        }
        private void cb_selectall_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_selectall.Checked==true)
            {
                for(int i=0;i<data.Rows.Count-1;i++)
                {
                    data.Rows[i].Cells["select"].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < data.Rows.Count-1; i++)
                {
                    data.Rows[i].Cells["select"].Value = false;
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắm muốn xóa không?", "Đang xóa...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteData(txt_id.Text);
                MessageBox.Show("Delete Successfull !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                printdata();
                ghilichsu(DateTime.Now, "Delete dữ liệu cho bản ghi" + banghichinhsua+"thành công");
            }
        }
        private string banghihientai = "";
        private string banghichinhsua = "";
        private void btn_insert_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Bạn có chắc chắm muốn thêm dữ liệu không?", "Đang Thêm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                InsertData(txt_username.Text, txt_password.Text, txt_nameingame.Text, txt_point.Text, txt_image.Text);
                printdata();
                ghilichsu(DateTime.Now, "Insert dữ liệu cho bản ghi" + banghihientai);
            }
           
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txt_id.Text);
            if (MessageBox.Show("Bạn có chắc chắm muốn sửa dữ liệu không?", "Đang edit...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                EditData(ID,txt_username.Text, txt_password.Text, txt_nameingame.Text, txt_point.Text, txt_image.Text);
                printdata();
                ghilichsu(DateTime.Now, banghihientai);
            }
          
        }

        private void data_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            data.Rows[e.RowIndex].ReadOnly = false;
            data.Rows[e.RowIndex].Cells["edit"].Value = "Update";
        }
        private string xemchitiet = "0";
        private int id_click = 0;
        private void data_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                xemchitiet = data.Rows[e.RowIndex].Cells["id"].Value.ToString();
                id_click = e.RowIndex;
            }
            catch { }
        }

        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemChiTiet xct = new XemChiTiet();

            xct.id = xemchitiet;
            xct.username = data.Rows[id_click].Cells["username"].Value.ToString();
            xct.passsword = data.Rows[id_click].Cells["password"].Value.ToString();
            xct.nameingame = data.Rows[id_click].Cells["name"].Value.ToString();
            xct.point = data.Rows[id_click].Cells["point"].Value.ToString();
            xct.image = data.Rows[id_click].Cells["image"].Value.ToString();
            xct.xephang = data.Rows[id_click].Cells["rank"].Value.ToString();

            xct.ShowDialog();
            xct.Location = new Point(MousePosition.X - xct.Width, MousePosition.Y - xct.Height);
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
            public xephang_player(string _id,string _username,string _password,string _name,string _point,string _image, int _xephang)
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
        private void btn_search_Click(object sender, EventArgs e)
        {

            con.Open();
            try
            {
                string sql = "select * , 'Delete' AS [edit] from account where id like N'%" + txt_search.Text+"%' or username like N'%"+ txt_search.Text+"%' or password like N'%"+ txt_search.Text+ "%'or name like N'%" + txt_search.Text + "%' or point like N'%" + txt_search.Text + "%' or image like N'%" + txt_search.Text + "%'";
                da = new SqlDataAdapter(sql, con);
                sqlCB = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "account");
                data.DataSource = ds.Tables["account"];
                data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                data.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int i = 0; i < data.Rows.Count-1; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    data[data.Columns.Count - 1, i] = linkCell;
                    data.Rows[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    data.Rows[i].Cells["rank"].Value = xh[IdPlayer.IndexOf(data.Rows[i].Cells["id"].Value.ToString())].Xephang;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            dongbodulieuvaotextbox();
            
        }
        private int sobanghi = -1;
        private void ghilichsu(DateTime dt, string thaotac)
        {
            int height = 50;
            sobanghi++;
            string dulieu = "-TG-" + dt + ":\n" + thaotac;
            Label lb = new Label()
            {
                Width = panel1.Width-10,
                Height= height,
                AutoSize = false,
                Text = dulieu,
                Location = new Point(0, height * sobanghi),
            };
            panel1.Controls.Add(lb);
            using (StreamWriter sr = File.AppendText("History.txt"))
            {
                sr.WriteLine(dulieu);
            }

        }

        private void hIstoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = @"E:\c# winform\CODE_ThuatToanQuayLui_DeQui\Game_Sodoku\Game_Sodoku\bin\Debug\History.txt";// hiển thị ổ đĩa
            prc.Start();
            prc.WaitForExit();
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog(); //Khởi tạo đối tượng ColorDialog 
            dlg.ShowDialog(); //Hiển thị hộp thoại

            if (dlg.ShowDialog() == DialogResult.OK) //Nếu nhấp vào nút OK trên hộp thoại
            {
                this.BackColor = dlg.Color;
                menuStrip1.BackColor = dlg.Color;
            }
        }

        private void daTaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Napdata frm = new Form_Napdata();
            frm.ShowDialog();
        }

        private void data4txtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = @"E:\c# winform\CODE_ThuatToanQuayLui_DeQui_(game_sodoku)\Game_Sodoku\Game_Sodoku\bin\Debug\data4.txt";// hiển thị ổ đĩa
            prc.Start();
            prc.WaitForExit();
        }

        private void data5txtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = @"E:\c# winform\CODE_ThuatToanQuayLui_DeQui_(game_sodoku)\Game_Sodoku\Game_Sodoku\bin\Debug\data5.txt";// hiển thị ổ đĩa
            prc.Start();
            prc.WaitForExit();
        }

        private void data6txtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = @"E:\c# winform\CODE_ThuatToanQuayLui_DeQui_(game_sodoku)\Game_Sodoku\Game_Sodoku\bin\Debug\data6.txt";// hiển thị ổ đĩa
            prc.Start();
            prc.WaitForExit();
        }

        private void data7txtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = @"E:\c# winform\CODE_ThuatToanQuayLui_DeQui_(game_sodoku)\Game_Sodoku\Game_Sodoku\bin\Debug\data7.txt";// hiển thị ổ đĩa
            prc.Start();
        }

        private void data8txtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = @"E:\c# winform\CODE_ThuatToanQuayLui_DeQui_(game_sodoku)\Game_Sodoku\Game_Sodoku\bin\Debug\data8.txt";// hiển thị ổ đĩa
            prc.Start();
            prc.WaitForExit();

        }

        private void data9txtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = @"E:\c# winform\CODE_ThuatToanQuayLui_DeQui_(game_sodoku)\Game_Sodoku\Game_Sodoku\bin\Debug\data9.txt";// hiển thị ổ đĩa
            prc.Start();
            prc.WaitForExit();
        }
    }
}
