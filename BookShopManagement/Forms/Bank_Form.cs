using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Net;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class Bank_Form : Form
    {
        Conn con = new Conn();
        string bankID;

        public Bank_Form()
        {
            InitializeComponent();
            heading_label.Text = "Add Bank Details";
            MySqlDataAdapter dtp2 = new MySqlDataAdapter("SELECT * FROM banks_pos", Conn.ConnectionString);
            DataTable tp = new DataTable();
            dtp2.Fill(tp);

            foreach (DataRow row2 in tp.Rows)
            {
                bank_name_combo.DisplayMember = "Text";
                bank_name_combo.ValueMember = "Value";
                bank_name_combo.Items.Add(new ComboboxItem(row2["Bank_Name"].ToString(), Convert.ToInt16(row2["Bank_ID"].ToString())));

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
        public Bank_Form(string ID)
        {
            this.bankID = ID;
            InitializeComponent();
            heading_label.Text = "Edit Bank Details";

            MySqlDataAdapter dtp2 = new MySqlDataAdapter("SELECT * FROM banks_pos", Conn.ConnectionString);
            DataTable tp = new DataTable();
            dtp2.Fill(tp);

            foreach (DataRow row2 in tp.Rows)
            {
                bank_name_combo.DisplayMember = "Text";
                bank_name_combo.ValueMember = "Value";
                bank_name_combo.Items.Add(new ComboboxItem(row2["Bank_Name"].ToString(), Convert.ToInt16(row2["Bank_ID"].ToString())));

            }

            MySqlDataAdapter dtp3 = new MySqlDataAdapter("SELECT b.Bank_Name,bd.Bank_Details_ID,bd.Bank_Branch,bd.Bank_Acc_Name,bd.Bank_Acc_Number,bd.Bank_Acc_Balance,IF(bd.Bank_Acc_Status=0, 'Active', 'InActive') as'Bank_Acc_Status' FROM `banks_pos` b join bank_details_pos bd on b.Bank_ID=bd.Bank_Name_ID where bd.Bank_Details_ID = @Bank_ID", Conn.ConnectionString);
            dtp3.SelectCommand.Parameters.AddWithValue("@Bank_ID", ID);
            DataTable tp3 = new DataTable();
            dtp3.Fill(tp3);

            foreach (DataRow row1 in tp3.Rows)
            {
                bank_name_combo.Text = row1["Bank_Name"].ToString();
                bank_branch_txt.Text = row1["Bank_Branch"].ToString();
                account_name_txt.Text = row1["Bank_Acc_Name"].ToString();
                account_number_txt.Text = row1["Bank_Acc_Number"].ToString();
                current_balance_txt.Text = row1["Bank_Acc_Balance"].ToString();
                account_status_combo.Text = row1["Bank_Acc_Status"].ToString();
            }
        }

        private string Insert_Data(string bank_name, string bank_branch, string account_name, string account_number, string current_balance, string account_status)
        {

            MySqlCommand cmd = new MySqlCommand("INSERT INTO `bank_details_pos` VALUES (null, @Bank_Name, @Bank_Branch, @Account_Name, @Account_Number, @Current_Balance, @Account_Status);", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@Bank_Name", bank_name);
            cmd.Parameters.AddWithValue("@Bank_Branch", bank_branch);
            cmd.Parameters.AddWithValue("@Account_Name", account_name);
            cmd.Parameters.AddWithValue("@Account_Number", account_number);
            cmd.Parameters.AddWithValue("@Current_Balance", current_balance);
            cmd.Parameters.AddWithValue("@Account_Status", account_status);

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
                return "Bank Account Details Added To System Successfully";
            }
            else
            {
                return "Data Not Added To System Successfully";
            }
        }


        private string Update_Data(string bank_name, string bank_branch, string account_name, string account_number, string current_balance, string account_status)
        {
            try { 
            MySqlCommand cmd = new MySqlCommand("UPDATE `bank_details_pos` SET `Bank_Name_ID` = @Bank_Name, `Bank_Branch` = @Bank_Branch, `Bank_Acc_Name` = @Account_Name, `Bank_Acc_Number` = @Account_Number, `Bank_Acc_Status` = @Current_Balance, `Bank_Acc_Status` = @Account_Status WHERE `Bank_Details_ID` = @Bank_ID;", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@Bank_ID", bankID);
            cmd.Parameters.AddWithValue("@Bank_Name", bank_name);
            cmd.Parameters.AddWithValue("@Bank_Branch", bank_branch);
            cmd.Parameters.AddWithValue("@Account_Name", account_name);
            cmd.Parameters.AddWithValue("@Account_Number", account_number);
            cmd.Parameters.AddWithValue("@Current_Balance", current_balance);
            cmd.Parameters.AddWithValue("@Account_Status", account_status);
            
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
                return  "Bank Account Details Updated To System Successfully";
            }
            else
            {
                return "Data Not Updated To System Successfully";
            }
            }
            catch (Exception ex)
            {
                return "Account Name/Account Number Duplicated With Other Bank.";
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (CheckForInternetConnection().ToString() == "True")
            {

                if (bank_name_combo.Text == "") { bank_name_error.Visible = true; } else { bank_name_error.Visible = false; }
                if (bank_branch_txt.Text == "") { bank_branch_error.Visible = true; } else { bank_branch_error.Visible = false; }
                if (account_name_txt.Text == "") { account_name_error.Visible = true; } else { account_name_error.Visible = false; }
                if (account_number_txt.Text == "") { account_number_error.Visible = true; } else { account_number_error.Visible = false; }
                if (current_balance_txt.Text == "") { current_balance_error.Visible = true; } else { current_balance_error.Visible = false; }
                if (account_status_combo.Text == "") { account_status_error.Visible = true; } else { account_status_error.Visible = false; }

                if (bank_name_error.Visible || bank_branch_error.Visible || account_name_error.Visible || account_number_error.Visible || account_status_error.Visible)
                {
                    alert aa = new alert("Error!", "Fields With * Are Mandatory.", "error");
                    aa.ShowDialog();

                }
                else
                {
                    if (bankID != null && bankID != "")
                    {

                        var bank_combo = bank_name_combo.SelectedItem as ComboboxItem;
                        string msg = Update_Data(bank_combo.Value.ToString(), bank_branch_txt.Text.ToString(), account_name_txt.Text.ToString(), account_number_txt.Text.ToString(), current_balance_txt.Text.ToString(), account_status_combo.SelectedIndex.ToString());
                        alert aa = new alert("Updated!", msg, "success");
                        aa.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MySqlCommand C1 = new MySqlCommand("SELECT COUNT(*) FROM bank_details_pos where Bank_Acc_Number=@Bank_Acc_Number", Conn.ConnectionString);
                        C1.Parameters.AddWithValue("@Bank_Acc_Number", account_number_txt.Text);

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
                            var bank_combo = bank_name_combo.SelectedItem as ComboboxItem;
                            string msg = Insert_Data(bank_combo.Value.ToString(), bank_branch_txt.Text.ToString(), account_name_txt.Text.ToString(), account_number_txt.Text.ToString(), current_balance_txt.Text.ToString(), account_status_combo.SelectedIndex.ToString());
                            alert aa = new alert("Inserted!", msg, "success");
                            aa.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            alert aa = new alert("Error!", "Account Number Already Exist.", "error");
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

        private void Bank_Form_Load(object sender, EventArgs e)
        {

        }

        private void account_number_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void current_balance_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void bank_name_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void account_status_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void current_balance_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void account_number_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void account_name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bank_branch_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
