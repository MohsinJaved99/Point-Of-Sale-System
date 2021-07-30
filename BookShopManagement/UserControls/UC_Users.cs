using System;
using System.Data;
using System.Windows.Forms;
using BookShopManagement.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Net;

namespace BookShopManagement.UserControls
{
    public partial class UC_Users : UserControl
    {
        Conn con = new Conn();
        string userID;

        public UC_Users()
        {
            InitializeComponent();
            users_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            users_dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            users_dgv.DefaultCellStyle.ForeColor = Color.Black;
            User_View();
            
            
        }

        private void User_View()
        {
            try
            {
                string Query = "select u.User_ID,u.User_First_Name,u.User_Last_Name,u.User_Mail,u.User_Phone,u.User_Username,u.User_Pswd,u.User_Status,u.User_NIC,b.Branch_Area,r.Role_Name from users_pos u join branches_pos b on u.User_Branch_ID=b.Branch_ID join roles_pos r on u.User_Role_ID=r.Role_ID";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, Conn.ConnectionString);

                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                User_ID.DataPropertyName = dTable.Columns["User_ID"].ToString();
                User_First_Name.DataPropertyName = dTable.Columns["User_First_Name"].ToString();
                User_Last_Name.DataPropertyName = dTable.Columns["User_Last_Name"].ToString();
                User_Mail.DataPropertyName = dTable.Columns["User_Mail"].ToString();
                User_Phone.DataPropertyName = dTable.Columns["User_Phone"].ToString();
                User_Username.DataPropertyName = dTable.Columns["User_Username"].ToString();
                User_Password.DataPropertyName = dTable.Columns["User_Pswd"].ToString();
                User_Branch.DataPropertyName = dTable.Columns["Branch_Area"].ToString();
                NIC.DataPropertyName = dTable.Columns["User_NIC"].ToString();
                User_Role.DataPropertyName = dTable.Columns["Role_Name"].ToString();
                status.DataPropertyName = dTable.Columns["User_Status"].ToString();
                //if(dTable.Columns["User_Role_ID"].ToString()=="1") {
                //      User_Role.DataPropertyName = "Admin";
                //}
                //else
                //{
                //    User_Role.DataPropertyName = "User";
                //}
              
                
                users_dgv.DataSource = dTable;
                if (Conn.ConnectionString.State == ConnectionState.Open)
                {
                    Conn.ConnectionString.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void User_View_With(string search_txt)
        {
            try
            {
                string Query = "select u.User_ID,u.User_First_Name,u.User_Last_Name,u.User_Mail,u.User_Phone,u.User_Username,u.User_Pswd,u.User_Status,u.User_NIC,b.Branch_Area,r.Role_Name from users_pos u join branches_pos b on u.User_Branch_ID=b.Branch_ID join roles_pos r on u.User_Role_ID=r.Role_ID where u.User_Username like '" + search_txt + "%' or u.User_Mail like '" + search_txt + "%' or u.User_NIC like '" + search_txt + "%' or b.Branch_Area like '" + search_txt + "%' or r.Role_Name like '" + search_txt + "%' or u.User_Phone like '" + search_txt + "%' or u.User_Status like '" + search_txt + "%' or u.User_First_Name like '" + search_txt + "%' or u.User_Last_Name like '"+search_txt+"%'";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, Conn.ConnectionString);
                

                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter(MyCommand2);
               
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                User_ID.DataPropertyName = dTable.Columns["User_ID"].ToString();
                User_First_Name.DataPropertyName = dTable.Columns["User_First_Name"].ToString();
                User_Last_Name.DataPropertyName = dTable.Columns["User_Last_Name"].ToString();
                User_Mail.DataPropertyName = dTable.Columns["User_Mail"].ToString();
                User_Phone.DataPropertyName = dTable.Columns["User_Phone"].ToString();
                User_Username.DataPropertyName = dTable.Columns["User_Username"].ToString();

                NIC.DataPropertyName = dTable.Columns["User_NIC"].ToString();
                User_Branch.DataPropertyName = dTable.Columns["Branch_Area"].ToString();
                User_Role.DataPropertyName = dTable.Columns["Role_Name"].ToString();
                status.DataPropertyName = dTable.Columns["User_Status"].ToString();
                users_dgv.DataSource = dTable;
                if (Conn.ConnectionString.State == ConnectionState.Open)
                {
                    Conn.ConnectionString.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int ao;
        private string Delete_User()
        {
            confirmationForm cd = new confirmationForm("Delete", "Do You Really Want To Delete This User?");
            cd.ShowDialog();
            if (cd.r == "yes")
            {

                MySqlCommand cmd = new MySqlCommand("DELETE FROM `users_pos` WHERE `users_pos`.`User_ID` = @userID", Conn.ConnectionString);
                cmd.Parameters.AddWithValue("@userID", userID);

                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                int i = cmd.ExecuteNonQuery();

                if (Conn.ConnectionString.State == ConnectionState.Open)
                {
                    Conn.ConnectionString.Close();
                }

                if (i > 0)
                {
                    ao = 0;
                }
                else
                {
                    ao = 1;
                }
               
            }
            if (ao == 0)
            {
                return "Data Deleted From System Successfully.";
            }
            else
            {
                return "Error While Deleting User.";
            }
       
        }

        private void add_user_btn_Click(object sender, EventArgs e)
        {
            using (User_Form uf = new User_Form())
            {
                uf.ShowDialog();
                User_View();
            }
        }

        private void edit_user_btn_Click(object sender, EventArgs e)
        {
            if (userID != null && userID != "")
            {
                using (User_Form uf = new User_Form(userID))
                {
                    uf.ShowDialog();
                    User_View();
                    userID = "";
                }
            }
            else
            {
                alert aa = new alert("Info!", "Please Select A Row You Want To Edit","info");
                aa.ShowDialog();
            }
        }

        private void delete_user_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (userID != null && userID != "")
                {
                    string msg = Delete_User();
                    alert aa = new alert("Deleted!", msg, "success");
                    aa.ShowDialog();
                    User_View();
                }
                else
                {
                    alert aa = new alert("Info!", "Please Select A Row You Want To Delete", "info");
                    aa.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                alert aa = new alert("Error!","You Can't Delete This Record Because This User Exists Somewhere.", "error");
                aa.ShowDialog();
            }
        }

        private void users_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in users_dgv.SelectedRows)
            {
                userID = row.Cells[0].Value.ToString();
            }
        }

        private void search_box_txt_TextChanged(object sender, EventArgs e)
        {
            User_View_With(search_box_txt.Text.ToString());
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
        private void users_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_Users_Load(object sender, EventArgs e)
        {
            users_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 36, 56);
            users_dgv.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void users_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            for (int i = 0; i < users_dgv.Rows.Count; i++)
            {

                String status = users_dgv.Rows[i].Cells["status"].Value.ToString();


                if (status == "Inactive")
                {
                    DataGridViewRow row = users_dgv.Rows[i];// get you required index
                    // check the cell value under your specific column and then you can toggle your colors
                    row.DefaultCellStyle.BackColor = Color.FromArgb(245, 17, 17);
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 0, 0);
                    row.DefaultCellStyle.SelectionForeColor = Color.White;
                }

            }
   
            //for (int i = 0; i < users_dgv.RowCount; i++)
            //{

            //    //users_dgv.Rows[i].Cells[3].Value = ts.Days;
            //    if (users_dgv.Rows[i].Cells["status"].Value.ToString()=="Active")
            //    {

            //        users_dgv.Rows[i].Cells["status"].Value = "⚫";
            //        //users_dgv.Rows[i].Cells["status"].Style.ForeColor = Color.Green;
            //    }
            //    else
            //    {
            //        users_dgv.Rows[i].Cells["status"].Value = "⚪";
            //    }
            //}
        }
    }
}
