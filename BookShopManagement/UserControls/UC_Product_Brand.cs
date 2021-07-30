using BookShopManagement.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace BookShopManagement.UserControls
{
    public partial class UC_Product_Brand : UserControl
    {
        Conn con = new Conn();
        string brandID;

        public UC_Product_Brand()
        {
            InitializeComponent();
            Brand_View();
            product_brand_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            product_brand_dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            product_brand_dgv.DefaultCellStyle.ForeColor = Color.Black;

    
        }

        private void Brand_View()
        {
            try
            {
                string Query = "select * from product_brands_view_pos";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, Conn.ConnectionString);

                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                Brand_ID.DataPropertyName = dTable.Columns["Brand_ID"].ToString();
                Brand_Name.DataPropertyName = dTable.Columns["Brand Name"].ToString();
                Brand_Status.DataPropertyName = dTable.Columns["Brand Status"].ToString();

                product_brand_dgv.DataSource = dTable;

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

        private void Product_Brand_View_With(string search_txt)
        {
            try
            {


                string Query = "select Product_Brand_ID as 'Brand_ID',Product_Brand_Name as 'Brand Name',IF(Product_Brand_Status=0,'Active','InActive') as 'Brand Status' from product_brands_pos where Product_Brand_Name like '%" + search_txt + "%'";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, Conn.ConnectionString);

                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                Brand_ID.DataPropertyName = dTable.Columns["Brand_ID"].ToString();
                Brand_Name.DataPropertyName = dTable.Columns["Brand Name"].ToString();
                Brand_Status.DataPropertyName = dTable.Columns["Brand Status"].ToString();

                product_brand_dgv.DataSource = dTable;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string Delete_Brand()
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `product_brands_pos` WHERE `product_brands_pos`.`Product_Brand_ID` = @brandID", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@brandID", brandID);

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
            using (Product_Brand_Form pbf = new Product_Brand_Form())
            {
                pbf.ShowDialog();
                Brand_View();
            }

        }

        private void edit_category_btn_Click(object sender, EventArgs e)
        {
            if (brandID != null && brandID != "")
            {
                using (Product_Brand_Form pbf = new Product_Brand_Form(brandID))
                {
                    pbf.ShowDialog();
                    Brand_View();
                    brandID = "";
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
                if (brandID != null && brandID != "")
                {
                    string msg = Delete_Brand();
                    alert aa = new alert("Deleted!", msg, "success");
                    aa.ShowDialog();
                    Brand_View();
                }
                else
                {
                    alert aa = new alert("Info!", "Please Select A Row You Want To Delete.", "info");
                    aa.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                alert aa = new alert("Error!", "You Can't Delete This Record Because This Brand Exists Somewhere.", "error");
                aa.ShowDialog();
            }
        }

        private void search_box_txt_TextChanged(object sender, EventArgs e)
        {
            Product_Brand_View_With(search_box_txt.Text.ToString());
        }

        private void product_brand_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in product_brand_dgv.SelectedRows)
            {
                brandID = row.Cells[0].Value.ToString();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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
        private void product_brand_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void product_brand_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < product_brand_dgv.Rows.Count; i++)
            {

                String status = product_brand_dgv.Rows[i].Cells[2].Value.ToString();


                if (status == "InActive")
                {
                    DataGridViewRow row = product_brand_dgv.Rows[i];// get you required index
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
