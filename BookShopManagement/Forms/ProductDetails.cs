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
    public partial class ProductDetails : Form
    {
        public ProductDetails()
        {
            InitializeComponent();
        }

        public ProductDetails(string id)
        {
            if (CheckForInternetConnection().ToString() == "True")
            {
                InitializeComponent();

                string query = "select Product_Material,Product_Color,Product_Remarks from products_pos where Product_ID='" + id + "'";
                MySqlCommand cmd = new MySqlCommand(query, Conn.ConnectionString);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    color.Text = row["Product_Color"].ToString();
                    material.Text = row["Product_Material"].ToString();
                    remark.Text = row["Product_Remarks"].ToString();


                }
            }
            else
            {

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
        private void ProductDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
