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
    public partial class Supplier_Form : Form
    {
        Conn con = new Conn();
        string SupplierIDD;

        public Supplier_Form()
        {
            InitializeComponent();
            heading_label.Text = "Add Supplier";
            mobile_txt.MaxLength = 11;
        }

        public Supplier_Form(string ID)
        {
            InitializeComponent();
            heading_label.Text = "Edit Supplier";
            mobile_txt.MaxLength = 11;
            this.SupplierIDD = ID;

            MySqlDataAdapter dtp3 = new MySqlDataAdapter("SELECT * FROM suppliers_view_pos WHERE Supplier_ID = @Supplier_ID", Conn.ConnectionString);
            dtp3.SelectCommand.Parameters.AddWithValue("@Supplier_ID", ID);
            DataTable tp3 = new DataTable();
            dtp3.Fill(tp3);

            foreach (DataRow row1 in tp3.Rows)
            {
                company_txt.Text = row1["Supplier Company"].ToString();
                contact_person_txt.Text = row1["Supplier Contact Person"].ToString();
                mobile_txt.Text = row1["Supplier Phone"].ToString();
                address_txt.Text = row1["Supplier Address"].ToString();
                cnic_txt.Text = row1["Supplier CNIC"].ToString();
                status_combo.Text = row1["Supplier Status"].ToString();
            }
        }
       
        private string Insert_Data(string Supplier_Company, string Supplier_Contact_Person, string Supplier_Phone, string Supplier_Address, string Supplier_CNIC, string Supplier_Entry_Date, string Supplier_Status)
        {

            MySqlCommand cmd = new MySqlCommand("INSERT INTO `suppliers_pos` VALUES (null,@Supplier_Company, @Supplier_Contact_Person, @Supplier_Phone, @Supplier_Address, @Supplier_CNIC, @Supplier_Entry_Date, @Supplier_Status);", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@Supplier_Company", Supplier_Company);
            cmd.Parameters.AddWithValue("@Supplier_Contact_Person", Supplier_Contact_Person);
            cmd.Parameters.AddWithValue("@Supplier_Phone", Supplier_Phone);
            cmd.Parameters.AddWithValue("@Supplier_Address", Supplier_Address);
            cmd.Parameters.AddWithValue("@Supplier_CNIC", Supplier_CNIC);
            cmd.Parameters.AddWithValue("@Supplier_Entry_Date", Supplier_Entry_Date);
            cmd.Parameters.AddWithValue("@Supplier_Status", Supplier_Status);

            if (Conn.ConnectionString.State != ConnectionState.Open)
            {
                Conn.ConnectionString.Open();
            }

            int i = cmd.ExecuteNonQuery();

            if (Conn.ConnectionString.State == ConnectionState.Open)
            {
                Conn.ConnectionString.Close();
            }

            string Name = company_txt.Text;

            if (i > 0)
            {
                return Name + " Supplier Added To System Successfully";
            }
            else
            {
                return "Data Not Added To System Successfully";
            }
        }

        private string Update_Data(string Supplier_Company, string Supplier_Contact_Person, string Supplier_Phone, string Supplier_Address, string Supplier_CNIC, string Supplier_Entry_Date, string Supplier_Status)
        {
          try {
            MySqlCommand cmd = new MySqlCommand("UPDATE `suppliers_pos` SET  `Supplier_Company` = @Supplier_Company,  `Supplier_Contact_Person` = @Supplier_Contact_Person, `Supplier_Phone` = @Supplier_Phone, `Supplier_Address` = @Supplier_Address, `Supplier_CNIC` = @Supplier_CNIC, `Supplier_Status` = @Supplier_Status WHERE `suppliers_pos`.`Supplier_ID` = @Supplier_IDD;", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@Supplier_IDD", SupplierIDD);
            cmd.Parameters.AddWithValue("@Supplier_Company", Supplier_Company);
            cmd.Parameters.AddWithValue("@Supplier_Contact_Person", Supplier_Contact_Person);
            cmd.Parameters.AddWithValue("@Supplier_Phone", Supplier_Phone);
            cmd.Parameters.AddWithValue("@Supplier_Address", Supplier_Address);
            cmd.Parameters.AddWithValue("@Supplier_CNIC", Supplier_CNIC);
            cmd.Parameters.AddWithValue("@Supplier_Entry_Date", Supplier_Entry_Date);
            cmd.Parameters.AddWithValue("@Supplier_Status", Supplier_Status);

            if (Conn.ConnectionString.State != ConnectionState.Open)
            {
                Conn.ConnectionString.Open();
            }

            int i = cmd.ExecuteNonQuery();

            if (Conn.ConnectionString.State == ConnectionState.Open)
            {
                Conn.ConnectionString.Close();
            }

            string Name = company_txt.Text;

            if (i > 0)
            {
                return Name + " Supplier Updated To System Successfully";
            }
            else
            {
                return "Data Not Added To System Successfully";
            }
            }
            catch (Exception ex)
            {
                return "Company/NIC/Phone Duplicated With Other Supplier.";
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (CheckForInternetConnection().ToString() == "True")
            {
                if (mobile_txt.Text.Length == 11)
                {
                    if (SupplierIDD != null && SupplierIDD != "")
                    {

                        string msg = Update_Data(company_txt.Text.ToString(), contact_person_txt.Text.ToString(), mobile_txt.Text.ToString(), address_txt.Text.ToString(), cnic_txt.Text.ToString(), DateTime.Now.ToString("dd-MMMM-yyyy"), status_combo.SelectedIndex.ToString());
                        alert aa = new alert("Updated!", msg, "success");
                        aa.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        string aaa = "SELECT COUNT(*) FROM suppliers_pos where Supplier_Company='" + company_txt.Text + "' and Supplier_CNIC='" + cnic_txt.Text + "' and Supplier_Phone='" + mobile_txt.Text + "'";

                        MySqlCommand cmd = new MySqlCommand(aaa, Conn.ConnectionString);

                        Conn.ConnectionString.Close();
                        Conn.ConnectionString.Open();
                        int Count1 = int.Parse(cmd.ExecuteScalar().ToString());

                        if (Count1 == 0)
                        {
                            string msg = Insert_Data(company_txt.Text.ToString(), contact_person_txt.Text.ToString(), mobile_txt.Text.ToString(), address_txt.Text.ToString(), cnic_txt.Text.ToString(), DateTime.Now.ToString("dd-MMMM-yyyy"), status_combo.SelectedIndex.ToString());
                            alert aa = new alert("Inserted!", msg, "success");
                            aa.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            alert aa = new alert("Error!", "Supplier Already Exist", "error");
                            aa.ShowDialog();
                        }
                        Conn.ConnectionString.Close();
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

            foreach (var c in this.Controls)
            {
                if (c is ComboBox)
                {
                    ((ComboBox)c).Text = String.Empty;
                }
            }
        }

        private void contact_person_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void mobile_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mobile_txt.Text.Length < 11)
            {
                mobile_txt.BackColor = Color.Red;
            }
            else
            {
                mobile_txt.BackColor = Color.White;
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
        private void Supplier_Form_Load(object sender, EventArgs e)
        {

        }

        private void company_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void contact_person_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void mobile_txt_TextChanged(object sender, EventArgs e)
        {

            if (mobile_txt.Text.Length < 11)
            {
                mobile_txt.BackColor = Color.Red;
            }
            else
            {
                mobile_txt.BackColor = Color.White;
            }
            //if (mobile_txt.Text.Length > 11)
            //{
            //    string s = mobile_txt.Text;

            //    if (s.Length > 1)
            //    {
            //        s = s.Substring(0, s.Length - 1);
            //    }
            //    else
            //    {
            //        s = "0";
            //    }

            //    mobile_txt.Text = s;
            //}
        }

        private void mobile_txt_Leave(object sender, EventArgs e)
        {
            if (mobile_txt.Text.Length != 11)
            {
                mobile_txt.BackColor = Color.Red;
            }
            else
            {
                mobile_txt.BackColor = Color.White;
            }
        }

        private void company_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
