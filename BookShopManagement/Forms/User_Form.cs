using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class User_Form : Form
    {
        Conn con = new Conn();
        string userID;

        public User_Form()
        {
            InitializeComponent();
            heading_label.Text = "Add New User";
            phone_txt.MaxLength = 11;
            MySqlDataAdapter dtp2 = new MySqlDataAdapter("SELECT * FROM branches_pos", Conn.ConnectionString);
            DataTable tp = new DataTable();
            dtp2.Fill(tp);

            foreach (DataRow row1 in tp.Rows)
            {
                branch_combo.DisplayMember = "Text";
                branch_combo.ValueMember = "Value";
                branch_combo.Items.Add(new ComboboxItem(row1["Branch_Area"].ToString(), Convert.ToInt16(row1["Branch_ID"].ToString())));
            }

            MySqlDataAdapter dtp1 = new MySqlDataAdapter("SELECT * FROM roles_pos", Conn.ConnectionString);
            DataTable tp1 = new DataTable();
            dtp1.Fill(tp1);

            foreach (DataRow row1 in tp1.Rows)
            {
                role_combo.DisplayMember = "Text";
                role_combo.ValueMember = "Value";
                role_combo.Items.Add(new ComboboxItem(row1["Role_Name"].ToString(), Convert.ToInt16(row1["Role_ID"].ToString())));
            }
        }
        string uname, nicc, em, ph;
        public User_Form(string ID)
        {
            InitializeComponent();
            this.userID = ID;
            heading_label.Text = "Edit User";
            phone_txt.MaxLength = 11;
            MySqlDataAdapter dtp2 = new MySqlDataAdapter("SELECT * FROM branches_pos", Conn.ConnectionString);
            DataTable tp = new DataTable();
            dtp2.Fill(tp);

            foreach (DataRow row1 in tp.Rows)
            {
                branch_combo.DisplayMember = "Text";
                branch_combo.ValueMember = "Value";
                branch_combo.Items.Add(new ComboboxItem(row1["Branch_Area"].ToString(), Convert.ToInt16(row1["Branch_ID"].ToString())));
            }

            MySqlDataAdapter dtp1 = new MySqlDataAdapter("SELECT * FROM roles_pos", Conn.ConnectionString);
            DataTable tp1 = new DataTable();
            dtp1.Fill(tp1);

            foreach (DataRow row1 in tp1.Rows)
            {
                role_combo.DisplayMember = "Text";
                role_combo.ValueMember = "Value";
                role_combo.Items.Add(new ComboboxItem(row1["Role_Name"].ToString(), Convert.ToInt16(row1["Role_ID"].ToString())));
            }

            MySqlDataAdapter dtp3 = new MySqlDataAdapter("SELECT u.*,b.Branch_Area FROM users_pos u join branches_pos b on u.User_Branch_ID=b.Branch_ID WHERE User_ID = @userID", Conn.ConnectionString);
            dtp3.SelectCommand.Parameters.AddWithValue("@userID", ID);
            DataTable tp3 = new DataTable();
            dtp3.Fill(tp3);
     
            foreach (DataRow row1 in tp3.Rows)
            {
                first_name_txt.Text = row1["User_First_Name"].ToString();
                last_name_txt.Text = row1["User_Last_Name"].ToString();
                username_txt.Text = row1["User_Username"].ToString();
                password_txt.Text = row1["User_Pswd"].ToString();
                phone_txt.Text = row1["User_Phone"].ToString();
                mail_txt.Text = row1["User_Mail"].ToString();
                nic.Text = row1["User_NIC"].ToString();
                string branch = row1["Branch_Area"].ToString();
                branch_combo.Text = branch;
                if (row1["User_Role_ID"].ToString() == "1")
                {
                    role_combo.SelectedIndex=0;
                }
                else
                {
                    role_combo.SelectedIndex = 1;
                }
                user_status.Text = row1["User_Status"].ToString();

                uname = row1["User_Username"].ToString();
                em = row1["User_Mail"].ToString();
                nicc = row1["User_NIC"].ToString();
                ph = row1["User_Phone"].ToString();
            }
        }

        private string Insert_Data(string First_Name, string Last_Name, string Username, string Password, string Phone, string Mail,string NIC, int Branch_ID, int Role_ID,string User_Status)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `users_pos` VALUES (null, @User_First_Name, @User_Last_Name, @User_Username, @User_Pswd, @User_Phone, @User_Mail,@User_NIC, @User_Branch_ID, @User_Role_ID,@User_Status);", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@User_First_Name", First_Name);
            cmd.Parameters.AddWithValue("@User_Last_Name", Last_Name);
            cmd.Parameters.AddWithValue("@User_Username", Username);
            cmd.Parameters.AddWithValue("@User_Pswd", Password);
            cmd.Parameters.AddWithValue("@User_Phone", Phone);
            cmd.Parameters.AddWithValue("@User_Mail", Mail);
            cmd.Parameters.AddWithValue("@User_NIC", NIC);
            cmd.Parameters.AddWithValue("@User_Branch_ID", Branch_ID);
            cmd.Parameters.AddWithValue("@User_Role_ID", Role_ID);
            cmd.Parameters.AddWithValue("@User_Status", User_Status);
        
            if (Conn.ConnectionString.State != ConnectionState.Open)
            {
                Conn.ConnectionString.Open();
            }

            int i = cmd.ExecuteNonQuery();

            if (Conn.ConnectionString.State == ConnectionState.Open)
            {
                Conn.ConnectionString.Close();
            }

            string FName = first_name_txt.Text;
            string LName = last_name_txt.Text;

            if (i > 0)
            {
                return FName + " " + LName + " Inserted To System Successfully";
            }
            else
            {
                return "Data Not Added To System Successfully";
            }
        }

        private string Update_Data(string First_Name, string Last_Name, string Username, string Password, string Phone, string Mail, string NIC, int Branch_ID, int Role_ID,string User_Status) {
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE `users_pos` SET `User_First_Name` = @User_First_Name, `User_Last_Name` = @User_Last_Name, `User_Username` = @User_Username, `User_Pswd` = @User_Pswd, `User_Phone` = @User_Phone, `User_Mail` = @User_Mail, `User_NIC` = @User_NIC, `User_Branch_ID` = @User_Branch_ID,`User_Role_ID`= @User_Role_ID,`User_Status`=@User_Status WHERE `users_pos`.`User_ID` = @User_ID;", Conn.ConnectionString);
                cmd.Parameters.AddWithValue("@User_ID", userID);
                cmd.Parameters.AddWithValue("@User_First_Name", First_Name);
                cmd.Parameters.AddWithValue("@User_Last_Name", Last_Name);
                cmd.Parameters.AddWithValue("@User_Username", Username);
                cmd.Parameters.AddWithValue("@User_Pswd", Password);
                cmd.Parameters.AddWithValue("@User_Phone", Phone);
                cmd.Parameters.AddWithValue("@User_Mail", Mail);
                cmd.Parameters.AddWithValue("@User_NIC", NIC);
                cmd.Parameters.AddWithValue("@User_Branch_ID", Branch_ID);
                cmd.Parameters.AddWithValue("@User_Role_ID", Role_ID);
                cmd.Parameters.AddWithValue("@User_Status", User_Status);
                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                int i = cmd.ExecuteNonQuery();

                if (Conn.ConnectionString.State == ConnectionState.Open)
                {
                    Conn.ConnectionString.Close();
                }

                string FName = first_name_txt.Text;
                string LName = last_name_txt.Text;

                if (i > 0)
                {
                    return FName + " " + LName + " Updated To System Successfully";
                }
                else
                {
                    return "Data Not Added To System Successfully";
                }
            }
            catch (Exception ex)
            {
                return "Username,Email,NIC,Phone Duplicated With Other User.";
            }
        }
        string u, p, m, n;
        private void save_btn_Click(object sender, EventArgs e)
        {
            if (CheckForInternetConnection().ToString() == "True")
            {
                if (first_name_txt.Text == "") { first_name_error.Visible = true; } else { first_name_error.Visible = false; }
                if (last_name_txt.Text == "") { last_name_error.Visible = true; } else { last_name_error.Visible = false; }
                if (phone_txt.Text == "") { phone_error.Visible = true; } else { phone_error.Visible = false; }
                if (mail_txt.Text == "") { mail_error.Visible = true; } else { mail_error.Visible = false; }
                if (branch_combo.Text == "") { branch_error.Visible = true; } else { branch_error.Visible = false; }
                if (username_txt.Text == "") { username_error.Visible = true; } else { username_error.Visible = false; }
                if (password_txt.Text == "") { password_error.Visible = true; } else { password_error.Visible = false; }
                if (role_combo.Text == "") { role_error.Visible = true; } else { role_error.Visible = false; }

                if (first_name_error.Visible || last_name_error.Visible || phone_error.Visible || mail_error.Visible || branch_error.Visible || username_error.Visible || password_error.Visible || role_error.Visible || user_status.Text == "")
                {
                    alert aa = new alert("Error!", "Fields With * Are Mandatory.", "error");
                    aa.ShowDialog();
                }
                else
                {
                    if (userID != null && userID != "")
                    {

                        string selectuser = "select * from users_pos where User_ID='"+userID+"'";
                        MySqlCommand getuser=new MySqlCommand(selectuser,Conn.ConnectionString);
                        Conn.ConnectionString.Close();
                        Conn.ConnectionString.Open();

                        MySqlDataAdapter da = new MySqlDataAdapter(getuser);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        foreach(DataRow row in dt.Rows) {

                            if (row["User_Username"].ToString() == username_txt.Text)
                            {

                            }

                        }
                        Conn.ConnectionString.Close(); 
                        var branch_combo_box = branch_combo.SelectedItem as ComboboxItem;
                        var role_combo_box = role_combo.SelectedItem as ComboboxItem;

                        string msg = Update_Data(first_name_txt.Text.ToString(), last_name_txt.Text.ToString(), username_txt.Text.ToString(), password_txt.Text.ToString(), phone_txt.Text.ToString(), mail_txt.Text.ToString(), nic.Text.ToString(), Convert.ToInt16(branch_combo_box.Value), Convert.ToInt16(role_combo_box.Value), user_status.Text);
                        alert aa = new alert("Updated!", msg, "success");
                        aa.ShowDialog();
                        this.Close();
                            

                    }
                    else
                    {
                        MySqlCommand C1 = new MySqlCommand("SELECT COUNT(*) FROM users_pos where User_NIC=@User_NIC", Conn.ConnectionString);
                        C1.Parameters.AddWithValue("@User_NIC", nic.Text);

                        MySqlCommand C2 = new MySqlCommand("SELECT COUNT(*) FROM users_pos where User_Phone=@User_Phone", Conn.ConnectionString);
                        C2.Parameters.AddWithValue("@User_Phone", phone_txt.Text);

                        MySqlCommand C3 = new MySqlCommand("SELECT COUNT(*) FROM users_pos where User_Mail=@User_Mail", Conn.ConnectionString);
                        C3.Parameters.AddWithValue("@User_Mail", mail_txt.Text);


                        MySqlCommand C4 = new MySqlCommand("SELECT COUNT(*) FROM users_pos where User_Username=@username", Conn.ConnectionString);
                        C4.Parameters.AddWithValue("@username", username_txt.Text);
                        if (Conn.ConnectionString.State != ConnectionState.Open)
                        {
                            Conn.ConnectionString.Open();
                        }

                        int Count = int.Parse(C1.ExecuteScalar().ToString());
                        int Count_2 = int.Parse(C2.ExecuteScalar().ToString());
                        int Count_3 = int.Parse(C3.ExecuteScalar().ToString());
                        int Count_4 = int.Parse(C4.ExecuteScalar().ToString());
                        if (Conn.ConnectionString.State == ConnectionState.Open)
                        {
                            Conn.ConnectionString.Close();
                        }

                        if (Count == 0)
                        {
                            if (Count_2 == 0)
                            {
                                if (Count_3 == 0)
                                {
                                    if (Count_4 == 0)
                                    {
                                        var branch_combo_box = branch_combo.SelectedItem as ComboboxItem;
                                        var role_combo_box = role_combo.SelectedItem as ComboboxItem;
                                        string msg = Insert_Data(first_name_txt.Text.ToString(), last_name_txt.Text.ToString(), username_txt.Text.ToString(), password_txt.Text.ToString(), phone_txt.Text.ToString(), mail_txt.Text.ToString(), nic.Text.ToString(), Convert.ToInt16(branch_combo_box.Value), Convert.ToInt16(role_combo_box.Value), user_status.Text);
                                        alert aa = new alert("Inserted!", msg, "success");
                                        aa.ShowDialog();
                                        this.Close();
                                    }
                                    else
                                    {
                                        alert aa = new alert("Error!", "Username Already Exist.", "error");
                                        aa.ShowDialog();
                                    }
                                }
                                else
                                {
                                    alert aa = new alert("Error!", "Email Already Exist.", "error");
                                    aa.ShowDialog();
                                }
                            }
                            else
                            {
                                alert aa = new alert("Error!", "Phone Number Already Exist.", "error");
                                aa.ShowDialog();

                            }
                        }
                        else
                        {
                            alert aa = new alert("Error!", "NIC Already Exist.", "error");
                            aa.ShowDialog();

                        }
                    }
                }
            }
            else
            {

            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }

            foreach (var c in this.Controls)
            {
                if (c is ComboBox)
                {
                    ((ComboBox)c).Text = String.Empty;
                }
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void User_Form_Load(object sender, EventArgs e)
        {

        }

        private void phone_txt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (phone_txt.Text.Length < 11)
            {
                phone_txt.BackColor = Color.Red;
            }
            else
            {
                phone_txt.BackColor = Color.White;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void mail_txt_TextChanged(object sender, EventArgs e)
        {
            if (mail_txt.Text.Contains("@gmail.com") || mail_txt.Text.Contains("@yahoo.com") || mail_txt.Text.Contains("@outlook.com") || mail_txt.Text.Contains("@hotmail.com") || mail_txt.Text.Contains("@life.com"))
            {
                mail_txt.BackColor = Color.White;
                save_btn.Enabled = true;
            }
            else
            {
                mail_txt.BackColor = Color.Red;
                save_btn.Enabled = false;
            }
        }

        private void phone_txt_Leave(object sender, EventArgs e)
        {
            if (phone_txt.Text.Length != 11)
            {
                phone_txt.BackColor = Color.Red;
            }
            else
            {
                phone_txt.BackColor = Color.White;
            }
        }

        private void phone_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void first_name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void last_name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
