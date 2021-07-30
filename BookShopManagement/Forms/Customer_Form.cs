using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class Customer_Form : Form
    {
        Conn con = new Conn();
        string customerIDDD;

        public Customer_Form()
        {
            InitializeComponent();
            heading_label.Text = "Add Customer Details";
            customer_number_txt.MaxLength = 11;
        }

        public Customer_Form(string ID)
        {
            this.customerIDDD = ID;
            InitializeComponent();
            heading_label.Text = "Edit Customer Details";
            customer_number_txt.MaxLength = 11;
            MySqlDataAdapter dtp3 = new MySqlDataAdapter("SELECT * FROM customers_pos WHERE Customer_ID = @Customer_ID", Conn.ConnectionString);
            dtp3.SelectCommand.Parameters.AddWithValue("@Customer_ID", ID);
            DataTable tp3 = new DataTable();
            dtp3.Fill(tp3);

            foreach (DataRow row1 in tp3.Rows)
            {
                customer_name_txt.Text = row1["Customer_Name"].ToString();
                nic.Text=row1["Customer_NIC"].ToString();
                customer_number_txt.Text = row1["Customer_Phone"].ToString();
                customer_mail_txt.Text = row1["Customer_Mail"].ToString();
                customer_address_txt.Text = row1["Customer_Address"].ToString();
            }
        }

        private string Insert_Data(string customer_name,string customer_number,string customer_mail,string customer_address,string nic)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `customers_pos` VALUES (null,@Customer_Name,@nicc, @Customer_Phone, @Customer_Mail,@Customer_Address);", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@Customer_Name", customer_name);
            cmd.Parameters.AddWithValue("@nicc", nic);
            cmd.Parameters.AddWithValue("@Customer_Phone", customer_number);
            cmd.Parameters.AddWithValue("@Customer_Mail", customer_mail);
            cmd.Parameters.AddWithValue("@Customer_Address", customer_address);

            if (Conn.ConnectionString.State != ConnectionState.Open)
            {
                Conn.ConnectionString.Open();
            }

            int i = cmd.ExecuteNonQuery();

            if (Conn.ConnectionString.State == ConnectionState.Open)
            {
                Conn.ConnectionString.Close();
            }

            string Name = customer_name_txt.Text;

            if (i > 0)
            {
                return Name + " Added To System Successfully";
            }
            else
            {
                return "Data Not Added To System Successfully";
            }
        }

        private string Update_Data(string customer_name, string customer_number, string customer_mail, string customer_address,string nic)
        {
            try { 
            MySqlCommand cmd = new MySqlCommand("UPDATE `customers_pos` SET `Customer_Name` = @Customer_Name,`Customer_NIC` = @nicc , `Customer_Phone` = @Customer_Phone, `Customer_Mail` = @Customer_Mail, `Customer_Address` = @Customer_Address WHERE `customers_pos`.`Customer_ID` = @Customer_ID;", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@Customer_ID", customerIDDD);
            cmd.Parameters.AddWithValue("@Customer_Name", customer_name);
            cmd.Parameters.AddWithValue("@nicc", nic);
            cmd.Parameters.AddWithValue("@Customer_Phone", customer_number);
            cmd.Parameters.AddWithValue("@Customer_Mail", customer_mail);
            cmd.Parameters.AddWithValue("@Customer_Address", customer_address);

            if (Conn.ConnectionString.State != ConnectionState.Open)
            {
                Conn.ConnectionString.Open();
            }

            int i = cmd.ExecuteNonQuery();

            if (Conn.ConnectionString.State == ConnectionState.Open)
            {
                Conn.ConnectionString.Close();
            }

            string Name = customer_name_txt.Text;

            if (i > 0)
            {
                return Name + " Updated To System Successfully";
            }
            else
            {
                return "Data Not Updated To System Successfully";
            }
            }
            catch (Exception ex)
            {
                return "Email/NIC/Phone Duplicated With Other Customer.";
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            
            if (CheckForInternetConnection().ToString() == "True")
            {
                if (customer_number_txt.Text.Length == 11)
                {
                if (customer_name_txt.Text == "") { customer_name_error.Visible = true; } else { customer_name_error.Visible = false; }
                if (customer_mail_txt.Text == "") { customer_mail_error.Visible = true; } else { customer_mail_error.Visible = false; }
                if (customer_number_txt.Text == "") { customer_number_error.Visible = true; } else { customer_number_error.Visible = false; }
                if (customer_address_txt.Text == "") { customer_address_error.Visible = true; } else { customer_address_error.Visible = false; }

                if (customer_name_error.Visible || customer_mail_error.Visible || customer_number_error.Visible || customer_address_error.Visible)
                {
                    alert aa = new alert("Error!", "Fields With * Are Mandatory.", "error");
                    aa.ShowDialog();

                }
                else
                {
                    if (customerIDDD != null && customerIDDD != "")
                    {



                        string msg = Update_Data(customer_name_txt.Text.ToString(), customer_number_txt.Text.ToString(), customer_mail_txt.Text.ToString(), customer_address_txt.Text.ToString(), nic.Text.ToString());
                        alert aa = new alert("Updated!", msg, "success");
                        aa.ShowDialog();
                        this.Close();
                        ;

                    }
                    else
                    {
                        MySqlCommand C = new MySqlCommand("SELECT COUNT(*) FROM customers_pos where Customer_NIC=@Customer_NIC", Conn.ConnectionString);
                        C.Parameters.AddWithValue("@Customer_NIC", nic.Text);

                        MySqlCommand C1 = new MySqlCommand("SELECT COUNT(*) FROM customers_pos where Customer_Phone=@Customer_Phone", Conn.ConnectionString);
                        C1.Parameters.AddWithValue("@Customer_Phone", customer_number_txt.Text);

                        MySqlCommand C2 = new MySqlCommand("SELECT COUNT(*) FROM customers_pos where Customer_Mail=@Customer_Mail", Conn.ConnectionString);
                        C2.Parameters.AddWithValue("@Customer_Mail", customer_mail_txt.Text);

                        if (Conn.ConnectionString.State != ConnectionState.Open)
                        {
                            Conn.ConnectionString.Open();
                        }
                        int Count1 = int.Parse(C.ExecuteScalar().ToString());
                        int Count = int.Parse(C1.ExecuteScalar().ToString());
                        int Count_2 = int.Parse(C2.ExecuteScalar().ToString());

                        if (Conn.ConnectionString.State == ConnectionState.Open)
                        {
                            Conn.ConnectionString.Close();
                        }
                        if (Count1 == 0)
                        {


                            if (Count == 0)
                            {
                                if (Count_2 == 0)
                                {
                                    string msg = Insert_Data(customer_name_txt.Text.ToString(), customer_number_txt.Text.ToString(), customer_mail_txt.Text.ToString(), customer_address_txt.Text.ToString(), nic.Text.ToString());
                                    alert aa = new alert("Inserted!", msg, "success");
                                    aa.ShowDialog();
                                    this.Close();
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
                    alert aa = new alert("Error!", "Incomplete Mobile Number.", "error");
                    aa.ShowDialog();
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
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customer_mail_txt_TextChanged(object sender, EventArgs e)
        {
            if (customer_mail_txt.Text.Contains("@gmail.com") || customer_mail_txt.Text.Contains("@yahoo.com") || customer_mail_txt.Text.Contains("@outlook.com") || customer_mail_txt.Text.Contains("@hotmail.com") || customer_mail_txt.Text.Contains("@life.com"))
            {
                customer_mail_txt.BackColor = Color.White;
                button1.Enabled = true;
            }
            else
            {
                customer_mail_txt.BackColor = Color.Red;
                button1.Enabled = false;
            }
        }

        private void customer_number_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void Customer_Form_Load(object sender, EventArgs e)
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
        private void customer_address_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void customer_number_txt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void customer_number_txt_Click(object sender, EventArgs e)
        {
            //if (customer_number_txt.Text != "")
            //{
            //    customer_number_txt.Select();
            //}
        }

        private void mobile_txt_TextChanged(object sender, EventArgs e)
        {
            if (customer_number_txt.Text.Length < 11)
            {
                customer_number_txt.BackColor = Color.Red;
            }
            else
            {
                customer_number_txt.BackColor = Color.White;
            }
        }

        private void mobile_txt_Leave(object sender, EventArgs e)
        {
            if (customer_number_txt.Text.Length != 11)
            {
                customer_number_txt.BackColor = Color.Red;
            }
            else
            {
                customer_number_txt.BackColor = Color.White;
            }
        }

        private void customer_number_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
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

        private void customer_name_txt_TextChanged(object sender, EventArgs e)
        {
            //if (!System.Text.RegularExpressions.Regex.IsMatch(customer_name_txt.Text, "^[a-zA-Z ]"))
            //{
            //    MessageBox.Show("This textbox accepts only alphabetical characters");
            //    customer_name_txt.Text.Remove(customer_name_txt.Text.Length - 1);
            //}
        }

        private void customer_name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
