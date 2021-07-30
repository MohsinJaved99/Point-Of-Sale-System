using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Net;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class Product_Form : Form
    {
        Conn con = new Conn();
        string productIDD;

        public Product_Form()
        {
            InitializeComponent();
            heading_label.Text = "Add New Product";

            MySqlDataAdapter dtp2 = new MySqlDataAdapter("SELECT * FROM product_brands_pos WHERE Product_Brand_Status = 0", Conn.ConnectionString);
            DataTable tp = new DataTable();
            dtp2.Fill(tp);

            foreach (DataRow row1 in tp.Rows)
            {
                product_brand_combo.DisplayMember = "Text";
                product_brand_combo.ValueMember = "Value";
                product_brand_combo.Items.Add(new ComboboxItem(row1["Product_Brand_Name"].ToString(), Convert.ToInt16(row1["Product_Brand_ID"].ToString())));
            }

            MySqlDataAdapter dtp = new MySqlDataAdapter("SELECT * FROM product_category_pos WHERE Product_Category_Status = 0", Conn.ConnectionString);
            DataTable tp1 = new DataTable();
            dtp.Fill(tp1);

            foreach (DataRow row1 in tp1.Rows)
            {
                product_category_combo.DisplayMember = "Text";
                product_category_combo.ValueMember = "Value";
                product_category_combo.Items.Add(new ComboboxItem(row1["Product_Category_Name"].ToString(), Convert.ToInt16(row1["Product_Category_ID"].ToString())));
            }
        }
        
        public Product_Form(string ID)
        {
            this.productIDD = ID;
            InitializeComponent();
            heading_label.Text = "Edit Product";

            MySqlDataAdapter dtp2 = new MySqlDataAdapter("SELECT * FROM product_brands_pos WHERE Product_Brand_Status = 0", Conn.ConnectionString);
            DataTable tp = new DataTable();
            dtp2.Fill(tp);

            foreach (DataRow row2 in tp.Rows)
            {
                product_brand_combo.DisplayMember = "Text";
                product_brand_combo.ValueMember = "Value";
                product_brand_combo.Items.Add(new ComboboxItem(row2["Product_Brand_Name"].ToString(), Convert.ToInt16(row2["Product_Brand_ID"].ToString())));
                
            }

            MySqlDataAdapter dtp = new MySqlDataAdapter("SELECT * FROM product_category_pos WHERE Product_Category_Status = 0", Conn.ConnectionString);
            DataTable tp1 = new DataTable();
            dtp.Fill(tp1);

            foreach (DataRow row1 in tp1.Rows)
            {
                product_category_combo.DisplayMember = "Text";
                product_category_combo.ValueMember = "Value";
                product_category_combo.Items.Add(new ComboboxItem(row1["Product_Category_Name"].ToString(), Convert.ToInt16(row1["Product_Category_ID"].ToString())));
                
            }

            MySqlDataAdapter dtp3 = new MySqlDataAdapter("select p.Product_ID AS `Product_ID`,p.Product_Name AS `Product Name`,c.Product_Category_Name AS `Product Category Name`,p.Product_Model AS `Product Model`,p.Product_Material AS `Product Material`,p.Product_Color AS `Product Color`,b.Product_Brand_Name AS `Product Brand Name`,p.Product_Remarks AS `Product Remarks`,p.Product_Entry_Date AS `Product Entry Date`,p.Product_Status AS `Product Status` from products_pos p join product_category_pos c on p.Product_Cat_ID=c.Product_Category_ID join product_brands_pos b on p.Pro_Brand_ID=b.Product_Brand_ID where p.Product_ID=@Product_ID", Conn.ConnectionString);
            dtp3.SelectCommand.Parameters.AddWithValue("@Product_ID", ID);
            DataTable tp3 = new DataTable();
            dtp3.Fill(tp3);

            foreach (DataRow row1 in tp3.Rows)
            {
                product_name_txt.Text = row1["Product Name"].ToString();
                product_category_combo.Text = row1["Product Category Name"].ToString();
                product_model_txt.Text = row1["Product Model"].ToString();
                product_material_txt.Text = row1["Product Material"].ToString();
                product_color_txt.Text = row1["Product Color"].ToString();
                product_remarks_txt.Text = row1["Product Remarks"].ToString();
                product_brand_combo.Text = row1["Product Brand Name"].ToString();
                Product_Status.Text = row1["Product Status"].ToString();
            }
        }

        private string Insert_Data(string Product_Name, string Product_Category, string Product_Model, string Product_Color, string Product_Material, string Product_Remarks, string Product_Entry_Date, string Product_Brand,string product_statuss)
        {


            MySqlCommand cmd = new MySqlCommand("INSERT INTO `products_pos`(`Product_ID`, `Product_Cat_ID`, `Product_Name`, `Pro_Brand_ID`, `Product_Model`, `Product_Color`, `Product_Material`, `Product_Remarks`, `Product_Entry_Date`,`Product_Status`) VALUES (null, @Product_Category_ID, @Product_Name, @Product_Brand_ID, @Product_Model_Number, @Product_Color, @Product_Material, @Product_Remarks, @Product_Entry_Date,@status);", Conn.ConnectionString);
                cmd.Parameters.AddWithValue("@Product_Category_ID", Product_Category);
                cmd.Parameters.AddWithValue("@Product_Name", Product_Name);
                cmd.Parameters.AddWithValue("@Product_Brand_ID", Product_Brand);
                cmd.Parameters.AddWithValue("@Product_Model_Number", Product_Model);
                cmd.Parameters.AddWithValue("@Product_Color", Product_Color);
                cmd.Parameters.AddWithValue("@Product_Material", Product_Material);
                cmd.Parameters.AddWithValue("@Product_Remarks", Product_Remarks);
                cmd.Parameters.AddWithValue("@Product_Entry_Date", Product_Entry_Date);
                cmd.Parameters.AddWithValue("@status", product_statuss);
                Conn.ConnectionString.Close();
                Conn.ConnectionString.Open();

                int i = cmd.ExecuteNonQuery();

                string Name = product_name_txt.Text;

                if (i > 0)
                {
                    return Name + " Added To System Successfully";
                }
                else
                {
                    return "Data Not Added To System Successfully";
                }
            
            
            if (Conn.ConnectionString.State == ConnectionState.Open)
            {
                Conn.ConnectionString.Close();
            }
        }


        private string Update_Data(string Product_Name, string Product_Category, string Product_Model, string Product_Color, string Product_Material, string Product_Remarks, string Product_Entry_Date, string Product_Brand, string product_statuss)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE `products_pos` SET `Product_Cat_ID` = @Product_Category_ID, `Product_Name` = @Product_Name, `Pro_Brand_ID` = @Product_Brand_ID, `Product_Model` = @Product_Model_Number, `Product_Color` = @Product_Color, `Product_Material` = @Product_Material, `Product_Remarks` = @Product_Remarks,`Product_Status`=@status  WHERE `products_pos`.`Product_ID` = @Product_ID;", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@Product_ID", productIDD);
            cmd.Parameters.AddWithValue("@Product_Category_ID", Product_Category);
            cmd.Parameters.AddWithValue("@Product_Name", Product_Name);
            cmd.Parameters.AddWithValue("@Product_Brand_ID", Product_Brand);
            cmd.Parameters.AddWithValue("@Product_Model_Number", Product_Model);
            cmd.Parameters.AddWithValue("@Product_Color", Product_Color);
            cmd.Parameters.AddWithValue("@Product_Material", Product_Material);
            cmd.Parameters.AddWithValue("@Product_Remarks", Product_Remarks);
            cmd.Parameters.AddWithValue("@status", product_statuss);

            if (Conn.ConnectionString.State != ConnectionState.Open)
            {
                Conn.ConnectionString.Open();
            }

            int i = cmd.ExecuteNonQuery();

            if (Conn.ConnectionString.State == ConnectionState.Open)
            {
                Conn.ConnectionString.Close();
            }

            string Name = product_name_txt.Text;

            if (i > 0)
            {
                return Name + " Updated To System Successfully";
            }
            else
            {
                return "Data Not Added To System Successfully";
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (CheckForInternetConnection().ToString() == "True")
            {
                if (product_category_combo.Text == "") { product_category_error.Visible = true; } else { product_category_error.Visible = false; }
                if (product_brand_combo.Text == "") { product_brand_error.Visible = true; } else { product_brand_error.Visible = false; }
                if (product_name_txt.Text == "") { product_name_error.Visible = true; } else { product_name_error.Visible = false; }
                if (product_model_txt.Text == "") { product_model_error.Visible = true; } else { product_model_error.Visible = false; }
                if (product_material_txt.Text == "") { product_material_error.Visible = true; } else { product_material_error.Visible = false; }
                if (product_color_txt.Text == "") { product_color_error.Visible = true; } else { product_color_error.Visible = false; }
                if (product_remarks_txt.Text == "") { product_remarks_error.Visible = true; } else { product_remarks_error.Visible = false; }


                if (product_category_error.Visible || product_brand_error.Visible || product_name_error.Visible || product_model_error.Visible || product_material_error.Visible || product_color_error.Visible || product_remarks_error.Visible || Product_Status.Text=="")
                {
                    alert aa = new alert("Error!", "Fields With * Are Mandatory.", "error");
                    aa.ShowDialog();

                }
                else
                {
                    if (productIDD != null && productIDD != "")
                    {
                        var category_comboo = product_category_combo.SelectedItem as ComboboxItem;
                        var brandName = product_brand_combo.SelectedItem as ComboboxItem;



                        string msg = Update_Data(product_name_txt.Text.ToString(), category_comboo.Value.ToString(), product_model_txt.Text.ToString(), product_color_txt.Text.ToString(), product_material_txt.Text.ToString(), product_remarks_txt.Text.ToString(), DateTime.Now.ToString("dd-MMMM-yyyy"), brandName.Value.ToString(), Product_Status.Text.ToString());
                        alert aa = new alert("Updated!", msg, "success");
                        aa.ShowDialog();

                        this.Close();

                    }
                    else
                    {
                        var category_comboo = product_category_combo.SelectedItem as ComboboxItem;
                        MySqlCommand C1 = new MySqlCommand("SELECT COUNT(*) FROM products_pos where Product_Name=@Product_Name", Conn.ConnectionString);
                        C1.Parameters.AddWithValue("@Product_Name", product_name_txt.Text);

                        MySqlCommand C2 = new MySqlCommand("SELECT COUNT(*) FROM products_pos where Product_Cat_ID=@cat and Product_Model=@Product_Model", Conn.ConnectionString);
                        C2.Parameters.AddWithValue("@Product_Model", product_model_txt.Text);
                        C2.Parameters.AddWithValue("@cat", category_comboo.Value.ToString());
                        if (Conn.ConnectionString.State != ConnectionState.Open)
                        {
                            Conn.ConnectionString.Open();
                        }

                        int Count = int.Parse(C1.ExecuteScalar().ToString());
                        int Count_2 = int.Parse(C2.ExecuteScalar().ToString());

                        if (Conn.ConnectionString.State == ConnectionState.Open)
                        {
                            Conn.ConnectionString.Close();
                        }

                        if (Count == 0)
                        {
                            if (Count_2 == 0)
                            {
                                var category_combo = product_category_combo.SelectedItem as ComboboxItem;
                                var brand_combo = product_brand_combo.SelectedItem as ComboboxItem;
                                string msg = Insert_Data(product_name_txt.Text.ToString(), category_combo.Value.ToString(), product_model_txt.Text.ToString(), product_color_txt.Text.ToString(), product_material_txt.Text.ToString(), product_remarks_txt.Text.ToString(), DateTime.Now.ToString("dd-MMMM-yyyy"), brand_combo.Value.ToString(),Product_Status.Text.ToString());
                                alert aa = new alert("Inserted!", msg, "success");
                                aa.ShowDialog();

                                this.Close();
                            }
                            else
                            {
                                alert aa = new alert("Error!", "Product Model Already Exist.", "error");
                                aa.ShowDialog();


                            }
                        }
                        else
                        {
                            alert aa = new alert("Error!", "Product Name Already Exist.", "error");
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
        private void Product_Form_Load(object sender, EventArgs e)
        {

        }

        private void product_name_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
