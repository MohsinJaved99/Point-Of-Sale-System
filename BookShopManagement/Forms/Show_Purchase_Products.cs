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
    public partial class Show_Purchase_Products : Form
    {
        public Show_Purchase_Products()
        {
            if (CheckForInternetConnection().ToString() == "True")
            {
                InitializeComponent();
                purchasedetails_dvg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
                purchasedetails_dvg.DefaultCellStyle.SelectionForeColor = Color.Black;
                purchasedetails_dvg.DefaultCellStyle.ForeColor = Color.Black;
            }
            else
            {

            }
        }

        string id;
        string d;
        string purchaseid,pid;
        public Show_Purchase_Products(string supID,string date)
        {
            InitializeComponent();
            purchasedetails_dvg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            purchasedetails_dvg.DefaultCellStyle.SelectionForeColor = Color.Black;
            purchasedetails_dvg.DefaultCellStyle.ForeColor = Color.Black;
            id = supID;
            d = date;
            string q = "select pd.PD_ID as 'ID',product.Product_ID as 'pid',pd.PD_Product_Quantity as 'Quantity',product.Product_Name as 'Product Name',product.Product_Model as 'Product Model',pd.PD_Product_Price as 'Purchase Amount',pd.PD_Purchase_Discount as 'Discount',pd.PD_Product_Total_Price as 'Total' from purchase_pos p join purchase_details_pos pd on p.Purchase_ID=pd.PD_Purchase_ID join products_pos product on pd.PD_Product_ID=product.Product_ID where p.Purchase_Date='" + date + "' and p.Purchase_Supplier_ID='" + supID + "'";
            MySqlCommand cmd = new MySqlCommand(q, Conn.ConnectionString);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            purchasedetails_dvg.DataSource = dt;
            purchasedetails_dvg.Columns["ID"].Visible = false;
            purchasedetails_dvg.Columns["pid"].Visible = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //if (textBox7.Text != "" || textBox7.Text != string.Empty)
            //{
            //    string q = "select pd.PD_Product_Quantity as 'Quantity',product.Product_Name as 'Product Name',product.Product_Model as 'Product Model',pd.PD_Product_Price as 'Purchase Amount',pd.PD_Purchase_Discount as 'Discount',pd.PD_Product_Total_Price as 'Total' from purchase_pos p join purchase_details_pos pd on p.Purchase_ID=pd.PD_Purchase_ID join products_pos product on pd.PD_Product_ID=product.Product_ID where p.Purchase_Date='" + d + "' and p.Purchase_Supplier_ID='" + id + "' and product.Product_Name like '" + textBox7.Text + "%' or product.Product_Model like '" + textBox7.Text + "%'";
            //    MySqlCommand cmd = new MySqlCommand(q, Conn.ConnectionString);
            //    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    purchasedetails_dvg.DataSource = dt;
            //}
            //else
            //{
            //    string q = "select pd.PD_Product_Quantity as 'Quantity',product.Product_Name as 'Product Name',product.Product_Model as 'Product Model',pd.PD_Product_Price as 'Purchase Amount',pd.PD_Purchase_Discount as 'Discount',pd.PD_Product_Total_Price as 'Total' from purchase_pos p join purchase_details_pos pd on p.Purchase_ID=pd.PD_Purchase_ID join products_pos product on pd.PD_Product_ID=product.Product_ID where p.Purchase_Date='" + d + "' and p.Purchase_Supplier_ID='" + id + "'";
            //    MySqlCommand cmd = new MySqlCommand(q, Conn.ConnectionString);
            //    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    purchasedetails_dvg.DataSource = dt;
            //}


            
        }

        private void edit_customer_btn_Click(object sender, EventArgs e)
        {

            if (purchaseid != null && purchaseid != "")
            {

                using (editPurchase rp = new editPurchase(purchaseid,pid))
                {
                    rp.ShowDialog();
                    purchaseid = "";
                    pid="";
                }
            }
            else
            {
                alert aa = new alert("Info!", "Please Select A Row You Want To Edit", "info");
                aa.ShowDialog();
            }
            
        }

        private void purchasedetails_dvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in purchasedetails_dvg.SelectedRows)
            {
                purchaseid = row.Cells[0].Value.ToString();
                pid = row.Cells[1].Value.ToString();
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
        private void purchasedetails_dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
