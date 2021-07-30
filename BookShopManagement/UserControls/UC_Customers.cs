using System;
using System.Data;
using System.Windows.Forms;
using BookShopManagement.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Net;


namespace BookShopManagement.UserControls
{
    public partial class UC_Customers : UserControl
    {
        Conn con = new Conn();
        string customerID;

        public UC_Customers()
        {
            InitializeComponent();
            Customer_View();

            customers_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            customers_dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            customers_dgv.DefaultCellStyle.ForeColor = Color.Black;
            //customers_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            //customers_dgv.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void Customer_View()
        {
            try
            {
                string Query = "Select Customer_ID AS `Customer ID`, Customer_Name AS `Customer Name`, Customer_NIC AS `Customer NIC`, Customer_Phone AS `Customer Phone`, Customer_Mail AS `Customer Mail`, Customer_Address AS `Customer Address` from customers_pos;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, Conn.ConnectionString);

                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                Customer_ID.DataPropertyName = dTable.Columns["Customer ID"].ToString();
                Customer_Name.DataPropertyName = dTable.Columns["Customer Name"].ToString();
                Customer_Phone.DataPropertyName = dTable.Columns["Customer Phone"].ToString();
                Customer_Mail.DataPropertyName = dTable.Columns["Customer Mail"].ToString();
                Customer_Address.DataPropertyName = dTable.Columns["Customer Address"].ToString();
                Customer_NIC.DataPropertyName = dTable.Columns["Customer NIC"].ToString();

                customers_dgv.DataSource = dTable;
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

        public void Customer_View_With(string search_txt)
        {
            try
            {
                string Query = "Select Customer_ID AS `Customer ID`, Customer_Name AS `Customer Name`, Customer_NIC AS `Customer NIC`, Customer_Phone AS `Customer Phone`, Customer_Mail AS `Customer Mail`, Customer_Address AS `Customer Address` from customers_pos where Customer_Name like '" + search_txt + "%' or Customer_NIC like '" + search_txt + "%' or Customer_Mail like '" + search_txt + "%' or Customer_Phone like '" + search_txt + "%' or Customer_Address like '" + search_txt + "%'";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, Conn.ConnectionString);

                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                Customer_ID.DataPropertyName = dTable.Columns["Customer ID"].ToString();
                Customer_Name.DataPropertyName = dTable.Columns["Customer Name"].ToString();
                Customer_Phone.DataPropertyName = dTable.Columns["Customer Phone"].ToString();
                Customer_Mail.DataPropertyName = dTable.Columns["Customer Mail"].ToString();
                Customer_Address.DataPropertyName = dTable.Columns["Customer Address"].ToString();
                Customer_NIC.DataPropertyName = dTable.Columns["Customer NIC"].ToString();

                customers_dgv.DataSource = dTable;
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

        private string Delete_Customer()
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `customers_pos` WHERE `customers_pos`.`Customer_ID` = @customerID", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@customerID", customerID);

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
                return "Data Deleted From System Successfully";
            }
            else
            {
                return "Data Not Deleted From System Successfully";
            }
        }

        private void add_customer_btn_Click(object sender, EventArgs e)
        {
            using (Customer_Form cf = new Customer_Form())
            {
                cf.ShowDialog();
                Customer_View();
            }
        }

        private void edit_customer_btn_Click(object sender, EventArgs e)
        {
            if (customerID != null && customerID != "")
            {
                using (Customer_Form cf = new Customer_Form(customerID))
                {
                    cf.ShowDialog();
                    Customer_View();
                    customerID = "";
                }
            }
            else
            {
                alert aa = new alert("Info!", "Please Select A Row You Want To Edit", "info");
                aa.ShowDialog();
            }
        }

        private void delete_customer_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerID != null && customerID != "")
                {
                    string msg = Delete_Customer();
                    alert aa = new alert("Deleted!", msg, "success");
                    aa.ShowDialog();
                    Customer_View();
                }
                else
                {
                    alert aa = new alert("Info!", "Please Select A Row You Want To Delete", "info");
                    aa.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                alert aa = new alert("Error!", "You Can't Delete This Record Because This Customer Exists Somewhere.", "error");
                aa.ShowDialog();

            }
        }

        private void customers_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in customers_dgv.SelectedRows)
            {
                customerID = row.Cells[0].Value.ToString();
            }
        }

        private void search_box_txt_TextChanged(object sender, EventArgs e)
        {
            Customer_View_With(search_box_txt.Text.ToString());
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
        private void customers_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
