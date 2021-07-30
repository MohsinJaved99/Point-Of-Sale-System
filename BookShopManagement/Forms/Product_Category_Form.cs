using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Net;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class Form_AddCategory : Form
    {
        Conn con = new Conn();
        string categoryIDD;

        public Form_AddCategory()
        {
            InitializeComponent();
            heading_label.Text = "Add Product Category";
        
        }

        public Form_AddCategory(string ID)
        {
            this.categoryIDD = ID;
            InitializeComponent();
            heading_label.Text = "Edit Product Category";

            

            MySqlDataAdapter dtp3 = new MySqlDataAdapter("SELECT * FROM product_category_pos WHERE Product_Category_ID = @Category_ID", Conn.ConnectionString);
            dtp3.SelectCommand.Parameters.AddWithValue("@Category_ID", ID);
            DataTable tp3 = new DataTable();
            dtp3.Fill(tp3);

            foreach (DataRow row1 in tp3.Rows)
            {
                category_name_txt.Text = row1["Product_Category_Name"].ToString();
                if (row1["Product_Category_Status"].ToString() == "0")
                {
                    category_status_combo.Text="Active";
                }
                else {
                    category_status_combo.Text = "InActive";
                }
            }
        }

        private string Insert_Data(string category_name, string category_status)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `product_category_pos` VALUES (null, @Product_Category_Name, @Product_Category_Status);", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@Product_Category_Name", category_name);
     
            cmd.Parameters.AddWithValue("@Product_Category_Status", category_status);
            
            if (Conn.ConnectionString.State != ConnectionState.Open)
            {
                Conn.ConnectionString.Open();
            }

            int i = cmd.ExecuteNonQuery();

            if (Conn.ConnectionString.State == ConnectionState.Open)
            {
                Conn.ConnectionString.Close();
            }



            string PName = category_name_txt.Text;

            if (i > 0)
            {
                return PName + " Category Added To System Successfully";
            }
            else
            {
                return "Data Not Added To System Successfully";
            }
        }

        private string Update_Data(string category_name, string category_status)
        {
            try
            {

                MySqlCommand cmd = new MySqlCommand("UPDATE `product_category_pos` SET `Product_Category_Name` = @Product_Category_Name, `Product_Category_Status` = @Product_Category_Status WHERE `product_category_pos`.`Product_Category_ID` = @Product_Category_ID;", Conn.ConnectionString);
                cmd.Parameters.AddWithValue("@Product_Category_ID", categoryIDD);
                cmd.Parameters.AddWithValue("@Product_Category_Name", category_name);
                cmd.Parameters.AddWithValue("@Product_Category_Status", category_status);

                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                int i = cmd.ExecuteNonQuery();

                if (Conn.ConnectionString.State == ConnectionState.Open)
                {
                    Conn.ConnectionString.Close();
                }



                string PName = category_name_txt.Text;


                if (i > 0)
                {
                    return PName + " Category Updated To System Successfully";
                }
                else
                {
                    return "Data Not Updated To System Successfully";

                }
            }
            catch (Exception ex)
            {
                return "Category Name Duplicated.";
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (CheckForInternetConnection().ToString() == "True")
            {
                if (category_name_txt.Text == "") { category_name_error.Visible = true; } else { category_name_error.Visible = false; }
                if (category_status_combo.Text == "") { category_status_error.Visible = true; } else { category_status_error.Visible = false; }

                if (category_name_error.Visible || category_status_error.Visible)
                {
                    alert aa = new alert("Error!", "Fields With * Are Mandatory.", "error");
                    aa.ShowDialog();

                }
                else
                {
                    if (categoryIDD != null && categoryIDD != "")
                    {

                        string msg = Update_Data(category_name_txt.Text.ToString(), category_status_combo.SelectedIndex.ToString());
                        alert aa = new alert("Updated!", msg, "success");
                        aa.ShowDialog();

                        this.Close();
                    }
                    else
                    {


                        MySqlCommand C1 = new MySqlCommand("SELECT COUNT(*) FROM product_category_pos where Product_Category_Name=@Category_Name", Conn.ConnectionString);
                        C1.Parameters.AddWithValue("@Category_Name", category_name_txt.Text);

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
                            string msg = Insert_Data(category_name_txt.Text.ToString(), category_status_combo.SelectedIndex.ToString());
                            alert aa = new alert("Inserted!", msg, "success");
                            aa.ShowDialog();

                            this.Close();
                        }
                        else
                        {
                            alert aa = new alert("Error!", "Product Category Already Exist.", "error");
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(category_status_combo.SelectedIndex.ToString());
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
        private void Form_AddCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
