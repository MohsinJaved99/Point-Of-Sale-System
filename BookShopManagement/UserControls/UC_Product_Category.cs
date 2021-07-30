using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using BookShopManagement.Forms;
using System.Drawing;
using System.Net;

namespace BookShopManagement.UserControls
{
    public partial class UC_Product_Category : UserControl
    {
        Conn con = new Conn();
        string categoryID;

        public UC_Product_Category()
        {
            InitializeComponent();
            Product_Category_View();
            //product_category_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            //product_category_dgv.DefaultCellStyle.ForeColor = Color.Black;

            product_category_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            product_category_dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            product_category_dgv.DefaultCellStyle.ForeColor = Color.Black;
        }     
        
        private void Product_Category_View() {
            try
            {
                string query = "SELECT `Product_Category_ID` as 'Category_ID', `Product_Category_Name` as 'Category Name', if(`Product_Category_Status`=0,'Active','InActive') as 'Category Status' FROM `product_category_pos`";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, BookShopManagement.Conn.ConnectionString);
                DataTable dTable = new DataTable();
                BookShopManagement.Conn.ConnectionString.Open();
                dataadapter.Fill(dTable);
                BookShopManagement.Conn.ConnectionString.Close();

                Category_ID.DataPropertyName = dTable.Columns["Category_ID"].ToString();
                Category_Name.DataPropertyName = dTable.Columns["Category Name"].ToString();
                Category_Status.DataPropertyName = dTable.Columns["Category Status"].ToString();

                product_category_dgv.DataSource = dTable;

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

        private void Product_Category_View_With(string search_txt)
        {
            try
            {
                string query = "SELECT `Product_Category_ID` as 'Category_ID', `Product_Category_Name` as 'Category Name', if(`Product_Category_Status`=0,'Active','InActive') as 'Category Status' FROM `product_category_pos` where Product_Category_Name like '" + search_txt + "%'";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, BookShopManagement.Conn.ConnectionString);
                DataTable dTable = new DataTable();
                BookShopManagement.Conn.ConnectionString.Open();
                dataadapter.Fill(dTable);
                BookShopManagement.Conn.ConnectionString.Close();

                Category_ID.DataPropertyName = dTable.Columns["Category_ID"].ToString();
                Category_Name.DataPropertyName = dTable.Columns["Category Name"].ToString();
                Category_Status.DataPropertyName = dTable.Columns["Category Status"].ToString();

                product_category_dgv.DataSource = dTable;

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

        private string Delete_Category()
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `product_category_pos` WHERE `product_category_pos`.`Product_Category_ID` = @categoryID", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@categoryID", categoryID);

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

        private void add_category_btn_Click(object sender, EventArgs e)
        {
            using (Form_AddCategory pcf = new Form_AddCategory())
            {
                pcf.ShowDialog();
                Product_Category_View();
            }
        }

        private void edit_category_btn_Click(object sender, EventArgs e)
        {
            if (categoryID != null && categoryID != "")
            {
                using (Form_AddCategory pcf = new Form_AddCategory(categoryID))
                {
                    pcf.ShowDialog();
                    Product_Category_View();
                    categoryID = "";
                }
            }
            else
            {
                alert aa = new alert("Info!", "Please Select A Row You Want To Edit", "info");
                aa.ShowDialog();
            }
        }

        private void delete_category_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoryID != null && categoryID != "")
                {
                    string msg = Delete_Category();
                    alert aa = new alert("Deleted!", msg, "success");
                    aa.ShowDialog();
                    Product_Category_View();
                }
                else
                {
                    alert aa = new alert("Info!", "Please Select A Row You Want To Delete", "info");
                    aa.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                alert aa = new alert("Error!", "You Can't Delete This Record Because This Category Exists Somewhere.", "error");
                aa.ShowDialog();
            }
        }

        private void product_category_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in product_category_dgv.SelectedRows)
            {
                categoryID = row.Cells[0].Value.ToString();
            }
        }

        private void search_box_txt_TextChanged(object sender, EventArgs e)
        {
            Product_Category_View_With(search_box_txt.Text.ToString());
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
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
        private void product_category_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void product_category_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < product_category_dgv.Rows.Count; i++)
            {

                String status = product_category_dgv.Rows[i].Cells[2].Value.ToString();


                if (status == "InActive")
                {
                    DataGridViewRow row = product_category_dgv.Rows[i];// get you required index
                    // check the cell value under your specific column and then you can toggle your colors
                    row.DefaultCellStyle.BackColor = Color.FromArgb(245, 17, 17);
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 0, 0);
                    row.DefaultCellStyle.SelectionForeColor = Color.White;
                }

            }
        }
    }
}
