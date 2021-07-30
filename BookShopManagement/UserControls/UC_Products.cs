using System;
using System.Data;
using System.Windows.Forms;
using BookShopManagement.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Net;

namespace BookShopManagement.UserControls
{
    public partial class UC_Products : UserControl
    {
        Conn con = new Conn();
        string productID;

        public UC_Products()
        {
            InitializeComponent();
            Product_View();
            //product_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            //product_dgv.DefaultCellStyle.ForeColor = Color.Black;

            product_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            product_dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            product_dgv.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void Product_View() {
            try
            {
                Conn.ConnectionString.Close();
                string query = "select p.Product_ID,b.Product_Brand_Name,c.Product_Category_Name,p.Product_Name,p.Product_Price,p.Product_Comission_Price,p.Product_Quantity,p.Product_Model,p.Product_Entry_Date,p.Product_Status from products_pos as p join product_brands_pos as b on p.Pro_Brand_ID=b.Product_Brand_ID join product_category_pos as c on p.Product_Cat_ID=c.Product_Category_ID";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, BookShopManagement.Conn.ConnectionString);
                DataTable dTable = new DataTable();
                BookShopManagement.Conn.ConnectionString.Open();
                dataadapter.Fill(dTable);
                BookShopManagement.Conn.ConnectionString.Close();
                Product_ID.DataPropertyName = dTable.Columns["Product_ID"].ToString();
                Product_Name.DataPropertyName = dTable.Columns["Product_Name"].ToString();
                Product_Quantity.DataPropertyName = dTable.Columns["Product_Quantity"].ToString();
                Product_Category_Name.DataPropertyName = dTable.Columns["Product_Category_Name"].ToString();
                Product_Price.DataPropertyName = dTable.Columns["Product_Price"].ToString();
                Product_Comission_Price.DataPropertyName = dTable.Columns["Product_Comission_Price"].ToString();
                Product_Model.DataPropertyName = dTable.Columns["Product_Model"].ToString();
                //Product_Material.DataPropertyName = dTable.Columns["Product_Material"].ToString();
                //Product_Color.DataPropertyName = dTable.Columns["Product_Color"].ToString();
                //Product_Remarks.DataPropertyName = dTable.Columns["Product_Remarks"].ToString();
                Product_Brand_Name.DataPropertyName = dTable.Columns["Product_Brand_Name"].ToString();
                Product_Entry_Date.DataPropertyName = dTable.Columns["Product_Entry_Date"].ToString();
                Product_Status.DataPropertyName = dTable.Columns["Product_Status"].ToString();

                product_dgv.Columns["Product_Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                product_dgv.Columns["Product_Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                product_dgv.Columns["Product_Comission_Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 

                product_dgv.DataSource = dTable;


                //string Query = "select * from products_pos";

                //MySqlCommand MyCommand2 = new MySqlCommand(Query, Conn.ConnectionString);
                //if (Conn.ConnectionString.State != ConnectionState.Open)
                //{
                //    Conn.ConnectionString.Open();
                //}

                //MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                //MyAdapter.SelectCommand = MyCommand2;
                //DataTable dTable = new DataTable();
                //MyAdapter.Fill(dTable);

                //Product_ID.DataPropertyName = dTable.Columns["Product_ID"].ToString();
                //Product_Name.DataPropertyName = dTable.Columns["Product_Name"].ToString();
                //Product_Category_Name.DataPropertyName = dTable.Columns["Product_Category_Name"].ToString();
                //Product_Model.DataPropertyName = dTable.Columns["Product_Model"].ToString();
                //Product_Material.DataPropertyName = dTable.Columns["Product_Material"].ToString();
                //Product_Color.DataPropertyName = dTable.Columns["Product_Color"].ToString();
                //Product_Points.DataPropertyName = dTable.Columns["Product_Redeem_Points"].ToString();
                //Product_Remarks.DataPropertyName = dTable.Columns["Product_Remarks"].ToString();
                //Product_Brand_Name.DataPropertyName = dTable.Columns["Product_Brand_Name"].ToString();
                //Product_Entry_Date.DataPropertyName = dTable.Columns["Product_EntryDate"].ToString();
                
                //product_dgv.DataSource = dTable;

                //if (Conn.ConnectionString.State == ConnectionState.Open)
                //{
                //    Conn.ConnectionString.Close();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        public void Product_View_With(string search_txt)
        {
            try
            {
                string query = "select p.Product_ID,b.Product_Brand_Name,c.Product_Category_Name,p.Product_Price,p.Product_Comission_Price,p.Product_Name,p.Product_Quantity,p.Product_Model,p.Product_Entry_Date,p.Product_Status from products_pos as p join product_brands_pos as b on p.Pro_Brand_ID=b.Product_Brand_ID join product_category_pos as c on p.Product_Cat_ID=c.Product_Category_ID where b.Product_Brand_Name like '" + search_txt + "%' or p.Product_Model like '"+search_txt+"%' or p.Product_color like '" + search_txt + "%' or c.Product_Category_Name like '" + search_txt + "%' or p.Product_Name like '" + search_txt + "%' or p.Product_Comission_Price like '" + search_txt + "%' or p.Product_Quantity like '" + search_txt + "%' or p.Product_Entry_Date like '" + search_txt + "%'";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, BookShopManagement.Conn.ConnectionString);
                DataTable dTable = new DataTable();
                Conn.ConnectionString.Close();
                BookShopManagement.Conn.ConnectionString.Open();
                dataadapter.Fill(dTable);
                BookShopManagement.Conn.ConnectionString.Close();
                Product_ID.DataPropertyName = dTable.Columns["Product_ID"].ToString();
                Product_Name.DataPropertyName = dTable.Columns["Product_Name"].ToString();
                Product_Quantity.DataPropertyName = dTable.Columns["Product_Quantity"].ToString();
                Product_Category_Name.DataPropertyName = dTable.Columns["Product_Category_Name"].ToString();
                Product_Price.DataPropertyName = dTable.Columns["Product_Price"].ToString();
                Product_Comission_Price.DataPropertyName = dTable.Columns["Product_Comission_Price"].ToString();
                Product_Model.DataPropertyName = dTable.Columns["Product_Model"].ToString();
                //Product_Material.DataPropertyName = dTable.Columns["Product_Material"].ToString();
                //Product_Color.DataPropertyName = dTable.Columns["Product_Color"].ToString();
                //Product_Remarks.DataPropertyName = dTable.Columns["Product_Remarks"].ToString();
                Product_Brand_Name.DataPropertyName = dTable.Columns["Product_Brand_Name"].ToString();
                Product_Entry_Date.DataPropertyName = dTable.Columns["Product_Entry_Date"].ToString();
                Product_Status.DataPropertyName = dTable.Columns["Product_Status"].ToString();
                
                product_dgv.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string Delete_Product()
        {
            MySqlCommand cmd = new MySqlCommand("update `products_pos` set Product_Status='Inactive' WHERE `products_pos`.`Product_ID` = @productID", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@productID", productID);
      

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
                return "Product Inactive Successfully";
            }
            else
            {
                return "Data Not Deleted From System Successfully";
            }
        }

        private void add_product_btn_Click(object sender, EventArgs e)
        {
            using (Product_Form PF = new Product_Form())
            {
                PF.ShowDialog();
                Product_View();
            }
        }

        private void edit_product_btn_Click(object sender, EventArgs e)
        {
            if (productID != null && productID != "")
            {
                using (Product_Form PF = new Product_Form(productID))
                {
                    PF.ShowDialog();
                    Product_View();
                    productID = "";
                }
            }
            else
            {
                alert aa = new alert("Info!", "Please Select A Row You Want To Edit", "info");
                aa.ShowDialog();
            }
        }

        private void delete_product_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (productID != null && productID != "")
                {
                    string msg = Delete_Product();
                    alert aa = new alert("Deleted!", msg, "success");
                    aa.ShowDialog();
                    Product_View();
                }
                else
                {
                    alert aa = new alert("Info!", "Please Select A Row You Want To Delete", "info");
                    aa.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                alert aa = new alert("Error!", "You Can't Delete This Record Because This Product Exists Somewhere.", "error");
                aa.ShowDialog();

            }
        }

        private void product_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in product_dgv.SelectedRows)
            {
                productID = row.Cells[0].Value.ToString();
            }
        }

        private void search_box_txt_TextChanged(object sender, EventArgs e)
        {
            Product_View_With(search_box_txt.Text.ToString());
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        string productIDdetails;
        private void product_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in product_dgv.SelectedRows)
            {
                productIDdetails = row.Cells[0].Value.ToString();
                if (productIDdetails != null && productIDdetails != "")
                {
                    using (ProductDetails PF = new ProductDetails(productIDdetails))
                    {
                        PF.ShowDialog();
                        Product_View();
                        productIDdetails = "";
                    }
                }
                else
                {
                    alert aa = new alert("Info!", "Please Select A Row To View Details.", "info");
                    aa.ShowDialog();
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
        private void product_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
