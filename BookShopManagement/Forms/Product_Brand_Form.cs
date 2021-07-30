using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Net;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class Product_Brand_Form : Form
    {
        Conn con = new Conn();
        string brandID;

        public Product_Brand_Form()
        {
            InitializeComponent();
            heading_label.Text = "Add Product Brand";
        }

        public Product_Brand_Form(string ID)
        {
            this.brandID = ID;
            InitializeComponent();
            heading_label.Text = "Edit Product Brand";

            MySqlDataAdapter dtp3 = new MySqlDataAdapter("SELECT * FROM product_brands_view_pos WHERE Brand_ID = @Brand_ID", Conn.ConnectionString);
            dtp3.SelectCommand.Parameters.AddWithValue("@Brand_ID", ID);
            DataTable tp3 = new DataTable();
            dtp3.Fill(tp3);

            foreach (DataRow row1 in tp3.Rows)
            {
                brand_name_txt.Text = row1["Brand Name"].ToString();
                brand_status_combo.Text = row1["Brand Status"].ToString();
            }
        }

        private string Insert_Data(string brand_name, string brand_status)
        {

            MySqlCommand cmd = new MySqlCommand("INSERT INTO `product_brands_pos` VALUES (null,@Brand_Name, @Brand_Status);", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@Brand_Name", brand_name);
            cmd.Parameters.AddWithValue("@Brand_Status", brand_status);


            if (Conn.ConnectionString.State != ConnectionState.Open)
            {
                Conn.ConnectionString.Open();
            }

            int i = cmd.ExecuteNonQuery();

            if (Conn.ConnectionString.State == ConnectionState.Open)
            {
                Conn.ConnectionString.Close();
            }

            string Name = brand_name_txt.Text;

            if (i > 0)
            {
                return Name + " Brand Added To System Successfully";
            }
            else
            {
                return "Data Not Added To System Successfully";
            }
        }


        private string Update_Data(string brand_name, string brand_status)
        {
            try { 
            MySqlCommand cmd = new MySqlCommand("UPDATE `product_brands_pos` SET `Product_Brand_Name` = @Brand_Name, `Product_Brand_Status` = @Brand_Status WHERE `product_brands_pos`.`Product_Brand_ID` = @Brand_ID;", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@Brand_ID", brandID);
            cmd.Parameters.AddWithValue("@Brand_Name", brand_name);
            cmd.Parameters.AddWithValue("@Brand_Status", brand_status);


            if (Conn.ConnectionString.State != ConnectionState.Open)
            {
                Conn.ConnectionString.Open();
            }

            int i = cmd.ExecuteNonQuery();

            if (Conn.ConnectionString.State == ConnectionState.Open)
            {
                Conn.ConnectionString.Close();
            }

            string Name = brand_name_txt.Text;

            if (i > 0)
            {
                return Name + " Category Updated To System Successfully";
            }
            else
            {
                return "Data Not Updated To System Successfully";
            }
            }
            catch (Exception ex)
            {
                return "Brand Name Duplicated.";
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            
            if (CheckForInternetConnection().ToString() == "True")
            {
                if (brand_name_txt.Text == "") { brand_name_error.Visible = true; } else { brand_name_error.Visible = false; }
                if (brand_status_combo.Text == "") { brand_status_error.Visible = true; } else { brand_status_error.Visible = false; }

                if (brand_name_error.Visible || brand_status_error.Visible)
                {
                    alert aa = new alert("Error!", "Fields With * Are Mandatory.", "error");
                    aa.ShowDialog();

                }
                else
                {
                    if (brandID != null && brandID != "")
                    {
                        string msg = Update_Data(brand_name_txt.Text.ToString(), brand_status_combo.SelectedIndex.ToString());
                        alert aa = new alert("Updated!", msg, "success");
                        aa.ShowDialog();

                        this.Close();
                    }
                    else
                    {
                        MySqlCommand C1 = new MySqlCommand("SELECT COUNT(*) FROM product_brands_pos where Product_Brand_Name=@Brand_Name", Conn.ConnectionString);
                        C1.Parameters.AddWithValue("@Brand_Name", brand_name_txt.Text);

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
                            string msg = Insert_Data(brand_name_txt.Text.ToString(), brand_status_combo.Text.ToString());
                            alert aa = new alert("Inserted!", msg, "success");
                            aa.ShowDialog();

                            this.Close();
                        }
                        else
                        {
                            alert aa = new alert("Error!", "Product Brand Already Exist.", "error");
                            aa.ShowDialog();


                        }
                    }
                }
            }
            else
            {
                alert aa = new alert("Error!", "Please Connect Your Internet.", "error");
                aa.ShowDialog();
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
        private void Product_Brand_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
