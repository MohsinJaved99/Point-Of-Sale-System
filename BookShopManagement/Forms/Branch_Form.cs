using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class Branch_Form : Form
    {
        Conn con = new Conn();
        string branchIDD;
        public Branch_Form()
        {
            InitializeComponent();
            heading_label.Text = "Add Branch";
        }

        public Branch_Form(string ID)
        {
            this.branchIDD = ID;
            InitializeComponent();
            heading_label.Text = "Edit Branch";
            branch_number_txt.MaxLength = 11;
            MySqlDataAdapter dtp3 = new MySqlDataAdapter("SELECT * FROM branches_pos WHERE Branch_ID = @Branch_ID", Conn.ConnectionString);
            dtp3.SelectCommand.Parameters.AddWithValue("@Branch_ID", ID);
            DataTable tp3 = new DataTable();
            dtp3.Fill(tp3);

            foreach (DataRow row1 in tp3.Rows)
            {
                branch_head_txt.Text = row1["Branch_Head"].ToString();
                branch_area_txt.Text = row1["Branch_Area"].ToString();
                branch_number_txt.Text = row1["Branch_Phone"].ToString();
                branch_status.Text = row1["Branch_Status"].ToString();
            }
        }

        private string Insert_Data(string branch_area, string branch_head, string branch_num,string status)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `branches_pos` VALUES (null,@Branch_Head, @Branch_Area, @Branch_Phone,@Status);", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@Branch_Head", branch_head);
            cmd.Parameters.AddWithValue("@Branch_Area", branch_area);
            cmd.Parameters.AddWithValue("@Branch_Phone", branch_num);
            cmd.Parameters.AddWithValue("@Status", status);
            if (Conn.ConnectionString.State != ConnectionState.Open)
            {
                Conn.ConnectionString.Open();
            }

            int i = cmd.ExecuteNonQuery();

            if (Conn.ConnectionString.State == ConnectionState.Open)
            {
                Conn.ConnectionString.Close();
            }

            string Name = branch_area_txt.Text;

            if (i > 0)
            {
                return Name + " Branch Added To System Successfully";
            }
            else
            {
                return "Data Not Added To System Successfully";
            }
        }

        private string Update_Data(string branch_area, string branch_head, string branch_num,string status)
        {
            try { 
            MySqlCommand cmd = new MySqlCommand("UPDATE `branches_pos` SET `Branch_Head` = @Branch_Head, `Branch_Area` = @Branch_Area, `Branch_Phone` = @Branch_Phone,`Branch_Status` = @Status WHERE `branches_pos`.`Branch_ID` = @Branch_ID;;", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@Branch_ID", branchIDD);
            cmd.Parameters.AddWithValue("@Branch_Head", branch_head);
            cmd.Parameters.AddWithValue("@Branch_Area", branch_area);
            cmd.Parameters.AddWithValue("@Branch_Phone", branch_num);
            cmd.Parameters.AddWithValue("@Status", status);
            if (Conn.ConnectionString.State != ConnectionState.Open)
            {
                Conn.ConnectionString.Open();
            }

            int i = cmd.ExecuteNonQuery();

            if (Conn.ConnectionString.State == ConnectionState.Open)
            {
                Conn.ConnectionString.Close();
            }

            string Name = branch_area_txt.Text;

            if (i > 0)
            {
                return Name + " Branch Updated To System Successfully";
            }
            else
            {
               return "Data Not Updated To System Successfully";
            }
            }
            catch (Exception ex)
            {
                return "Branch Area/Phone Number Duplicated With Other Branch.";
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (CheckForInternetConnection().ToString() == "True")
            {
                if (branch_area_txt.Text == "") { branch_area_error.Visible = true; } else { branch_area_error.Visible = false; }
                if (branch_head_txt.Text == "") { branch_head_error.Visible = true; } else { branch_head_error.Visible = false; }
                if (branch_number_txt.Text == "") { branch_number_error.Visible = true; } else { branch_number_error.Visible = false; }

                if (branch_area_error.Visible || branch_head_error.Visible || branch_number_error.Visible || branch_status.Text == "")
                {
                    alert aa = new alert("Error!", "Fields With * Are Mandatory.", "error");
                    aa.ShowDialog();

                }
                else
                {
                    if (branchIDD != null && branchIDD != "")
                    {
                   
                            string msg = Update_Data(branch_area_txt.Text.ToString(), branch_head_txt.Text.ToString(), branch_number_txt.Text.ToString(), branch_status.Text.ToString());
                            alert aa = new alert("Updated!", msg, "success");
                            aa.ShowDialog();
                            this.Close();
                     
                    }
                    else
                    {
                        MySqlCommand C1 = new MySqlCommand("SELECT COUNT(*) FROM branches_pos where Branch_Phone=@Branch_Phone", Conn.ConnectionString);
                        C1.Parameters.AddWithValue("@Branch_Phone", branch_number_txt.Text);

                        if (Conn.ConnectionString.State != ConnectionState.Open)
                        {
                            Conn.ConnectionString.Open();
                        }

                        int Count = int.Parse(C1.ExecuteScalar().ToString());

                        if (Conn.ConnectionString.State == ConnectionState.Open)
                        {
                            Conn.ConnectionString.Close();
                        }

                        if (Count == 0)
                        {
                            string msg = Insert_Data(branch_area_txt.Text.ToString(), branch_head_txt.Text.ToString(), branch_number_txt.Text.ToString(), branch_status.Text.ToString());
                            alert aa = new alert("Inserted!", msg, "success");
                            aa.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            alert aa = new alert("Error!", "Phone Number Already Exist.", "error");
                            aa.ShowDialog();

                        }
                    }
                }
            }
            else
            {

            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void branch_number_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (branch_number_txt.Text.Length < 11)
            {
                branch_number_txt.BackColor = Color.Red;
            }
            else
            {
                branch_number_txt.BackColor = Color.White;
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

        private void Branch_Form_Load(object sender, EventArgs e)
        {

        }

        private void branch_number_txt_TextChanged(object sender, EventArgs e)
        {
            if (branch_number_txt.Text.Length < 11)
            {
                branch_number_txt.BackColor = Color.Red;
            }
            else
            {
                branch_number_txt.BackColor = Color.White;
            }
        }

        private void branch_number_txt_Leave(object sender, EventArgs e)
        {
            if (branch_number_txt.Text.Length != 11)
            {
                branch_number_txt.BackColor = Color.Red;
            }
            else
            {
                branch_number_txt.BackColor = Color.White;
            }
        }

        private void branch_area_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void branch_head_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
