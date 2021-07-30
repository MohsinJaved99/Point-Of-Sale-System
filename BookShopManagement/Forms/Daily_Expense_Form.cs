using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class Daily_Expense_Form : Form
    {
        public Daily_Expense_Form()
        {
            InitializeComponent();
            date_txt.Format = DateTimePickerFormat.Custom; 
            date_txt.CustomFormat="dd-MMMM-yyyy";
        }
        Conn con = new Conn();
        string expenseIDD;

        public Daily_Expense_Form(string ID)
        {
            this.expenseIDD = ID;
            InitializeComponent();
            date_txt.Format = DateTimePickerFormat.Custom;
            date_txt.CustomFormat = "dd-MMMM-yyyy";
            heading_label.Text = "Edit Expense Details";

            MySqlDataAdapter dtp3 = new MySqlDataAdapter("SELECT * FROM daily_expense_pos WHERE Expense_ID = @Expense_ID", Conn.ConnectionString);
            dtp3.SelectCommand.Parameters.AddWithValue("@Expense_ID", ID);
            DataTable tp3 = new DataTable();
            dtp3.Fill(tp3);

            foreach (DataRow row1 in tp3.Rows)
            {
                purpose_txt.Text = row1["Expense_Purpose"].ToString();
                amount_txt.Text = row1["Expense_Amount"].ToString();
                date_txt.Text = row1["Expense_Date"].ToString();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            purpose_txt.Text = "";
            amount_txt.Text = "";
            date_txt.ResetText();

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private string Insert_Data(string expense_purpose, string expense_amount, string expense_date)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `daily_expense_pos` VALUES (null,@Expense_Purpose, @Expense_Amount, @Expense_Date);", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@Expense_Purpose", expense_purpose);
            cmd.Parameters.AddWithValue("@Expense_Amount", expense_amount);
            cmd.Parameters.AddWithValue("@Expense_Date", expense_date);

            if (Conn.ConnectionString.State != ConnectionState.Open)
            {
                Conn.ConnectionString.Open();
            }

            int i = cmd.ExecuteNonQuery();

            if (Conn.ConnectionString.State == ConnectionState.Open)
            {
                Conn.ConnectionString.Close();
            }

            string Name = purpose_txt.Text;

            if (i > 0)
            {
                return Name + " Expense Added To System Successfully";
            }
            else
            {
                return "Data Not Added To System Successfully";
            }
        }


        private string Update_Data(string expense_purpose, string expense_amount, string expense_date)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE `daily_expense_pos` SET `Expense_Purpose` = @Expense_Purpose, `Expense_Amount` = @Expense_Amount, `Expense_Date` = @Expense_Date WHERE `daily_expense_pos`.`Expense_ID` = @Expense_ID;;", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@Expense_ID", expenseIDD);
            cmd.Parameters.AddWithValue("@Expense_Purpose", expense_purpose);
            cmd.Parameters.AddWithValue("@Expense_Amount", expense_amount);
            cmd.Parameters.AddWithValue("@Expense_Date", expense_date);

            if (Conn.ConnectionString.State != ConnectionState.Open)
            {
                Conn.ConnectionString.Open();
            }

            int i = cmd.ExecuteNonQuery();

            if (Conn.ConnectionString.State == ConnectionState.Open)
            {
                Conn.ConnectionString.Close();
            }

            string Name = purpose_txt.Text;

            if (i > 0)
            {
                return Name + " Expense Updated To System Successfully";
            }
            else
            {
                return "Data Not Updated To System Successfully";
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (CheckForInternetConnection().ToString() == "True")
            {
                bool expense_purpose_error, expense_amount_error;
                string theDate = date_txt.Value.ToString("dd-MMMM-yyyy");
                if (purpose_txt.Text == "") { expense_purpose_error = true; } else { expense_purpose_error = false; }
                if (amount_txt.Text == "") { expense_amount_error = true; } else { expense_amount_error = false; }

                if (expense_purpose_error == true || expense_amount_error == true)
                {
                    alert aa = new alert("Error!", "Fields With * Are Mandatory.", "error");
                    aa.ShowDialog();

                }
                else
                {
                    if (expenseIDD != null && expenseIDD != "")
                    {
                        string msg = Update_Data(purpose_txt.Text.ToString(), amount_txt.Text.ToString(), theDate);

                        alert aa = new alert("Updated!", msg, "success");
                        aa.ShowDialog();

                        this.Close();
                    }
                    else
                    {
                        string msg = Insert_Data(purpose_txt.Text.ToString(), amount_txt.Text.ToString(), theDate);
                        alert aa = new alert("Inserted!", msg, "success");
                        aa.ShowDialog();
                        this.Close();
                    }
                }
            }
            else
            {

            }
        }

        private void amount_txt_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Daily_Expense_Form_Load(object sender, EventArgs e)
        {

        }

        private void purpose_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
