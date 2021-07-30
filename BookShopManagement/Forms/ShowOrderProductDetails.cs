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
    public partial class ShowOrderProductDetails : Form
    {
        public ShowOrderProductDetails()
        {
            if (CheckForInternetConnection().ToString() == "True")
            {
                InitializeComponent();
                saleproduct_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
                saleproduct_dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
                saleproduct_dgv.DefaultCellStyle.ForeColor = Color.Black;
            }
            else
            {

            }
        }
        string orderid,sid,pid;
        public ShowOrderProductDetails(string orderID)
        {
            InitializeComponent();
            saleproduct_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            saleproduct_dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            saleproduct_dgv.DefaultCellStyle.ForeColor = Color.Black;

            string getdata = "SELECT saleproduct.Sale_ID as 'ID',product.Product_ID as 'Product ID',product.Product_Name as 'Product Name',product.Product_Model as 'Product Model',saleproduct.Sale_Product_Price as 'Product Price',saleproduct.Sale_Product_Discounted_Amount as 'Discount',saleproduct.Sale_Discounted_Price as 'Discounted Amount',saleproduct.Sale_Product_Quantity as 'Quantity',orderr.Order_Date as 'Order Date' from `products_pos` product join sale_product saleproduct on product.Product_ID=saleproduct.Sale_Product_ID join sale_order orderr on saleproduct.Sale_Order_ID=orderr.Order_ID join customers_pos customer on orderr.Order_Customer_ID=customer.Customer_ID join users_pos userr on orderr.Order_DoneBy=userr.User_ID where orderr.Order_ID='" + orderID + "'";
            MySqlCommand cmd = new MySqlCommand(getdata, BookShopManagement.Conn.ConnectionString);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            BookShopManagement.Conn.ConnectionString.Open();

            orderid = orderID;
            DataTable dt = new DataTable();

            da.Fill(dt);

            saleproduct_dgv.DataSource = dt;
            saleproduct_dgv.Columns["ID"].Visible = false;
            saleproduct_dgv.Columns["Product ID"].Visible = false;
            saleproduct_dgv.Columns["Product Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            saleproduct_dgv.Columns["Discount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            saleproduct_dgv.Columns["Discounted Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            saleproduct_dgv.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            

            foreach (DataGridViewColumn col in saleproduct_dgv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            }
            BookShopManagement.Conn.ConnectionString.Close();

        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void edit_customer_btn_Click(object sender, EventArgs e)
        {
            if (orderid != null && orderid != "")
            {

                using (editOrder rp = new editOrder(orderid, sid,pid))
                {
                    rp.ShowDialog();
                    orderid = "";
                    pid = "";
                }
            }
            else
            {
                alert aa = new alert("Info!", "Please Select A Row You Want To Edit", "info");
                aa.ShowDialog();
            }
        }

        private void saleproduct_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in saleproduct_dgv.SelectedRows)
            {
                sid = row.Cells[0].Value.ToString();
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
        private void saleproduct_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
