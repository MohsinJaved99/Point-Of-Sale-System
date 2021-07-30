using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BookShopManagement.Forms;
using System.Net;

namespace BookShopManagement.UserControls
{
    public partial class ShowSale : UserControl
    {
        public ShowSale()
        {
            InitializeComponent();
            sale_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            sale_dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            sale_dgv.DefaultCellStyle.ForeColor = Color.Black;
            Load();

        }
        String orderID,card;
        private void Load()
        {
            Cursor.Current = Cursors.WaitCursor;
            string getdata = "SELECT orderr.Order_ID as 'Order ID',orderr.Order_Date as 'Order Date',customer.Customer_Name as 'Customer Name',customer.Customer_NIC as 'Customer NIC',orderr.Order_Type as 'Type',orderr.Order_Paid_Amount as 'Paid Amount',orderr.Order_Paid_Amount_By_Point as 'Redeem Point',Concat(userr.User_First_Name,' ',userr.User_Last_Name) as 'Sale By' from `products_pos` product join sale_product saleproduct on product.Product_ID=saleproduct.Sale_Product_ID join sale_order orderr on saleproduct.Sale_Order_ID=orderr.Order_ID join customers_pos customer on orderr.Order_Customer_ID=customer.Customer_ID join users_pos userr on orderr.Order_DoneBy=userr.User_ID GROUP BY orderr.Order_ID";
            MySqlCommand cmd = new MySqlCommand(getdata,BookShopManagement.Conn.ConnectionString);
            MySqlDataAdapter da=new MySqlDataAdapter(cmd);
            BookShopManagement.Conn.ConnectionString.Close();
            BookShopManagement.Conn.ConnectionString.Open();

            DataTable dt=new DataTable();

            da.Fill(dt);

            sale_dgv.DataSource=dt;

            sale_dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            sale_dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            BookShopManagement.Conn.ConnectionString.Close();
            Cursor.Current = Cursors.Arrow;
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_box_txt_TextChanged(object sender, EventArgs e)
        {
            if (search_box_txt.Text != "" || search_box_txt.Text != null)
            {
                string getdata = "SELECT orderr.Order_ID as 'Order ID',orderr.Order_Date as 'Order Date',customer.Customer_Name as 'Customer Name',customer.Customer_NIC as 'Customer NIC',orderr.Order_Type as 'Type',orderr.Order_Paid_Amount as 'Paid Amount',orderr.Order_Paid_Amount_By_Point as 'Redeem Point',Concat(userr.User_First_Name,' ',userr.User_Last_Name) as 'Sale By' from `products_pos` product join sale_product saleproduct on product.Product_ID=saleproduct.Sale_Product_ID join sale_order orderr on saleproduct.Sale_Order_ID=orderr.Order_ID join customers_pos customer on orderr.Order_Customer_ID=customer.Customer_ID join users_pos userr on orderr.Order_DoneBy=userr.User_ID where customer.Customer_Name like '" + search_box_txt.Text + "%' or product.Product_Name like '" + search_box_txt.Text + "%' or orderr.Order_Date like '" + search_box_txt.Text + "%' or customer.Customer_NIC like '" + search_box_txt.Text + "%' or orderr.Order_Type like '" + search_box_txt.Text + "%' or CONCAT(userr.User_First_Name,' ',userr.User_Last_Name) like '" + search_box_txt.Text + "%' or orderr.Order_ID like '" + search_box_txt.Text + "%' GROUP BY orderr.Order_ID";
                MySqlCommand cmd = new MySqlCommand(getdata, BookShopManagement.Conn.ConnectionString);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                BookShopManagement.Conn.ConnectionString.Open();


                DataTable dt = new DataTable();

                da.Fill(dt);

                sale_dgv.DataSource = dt;



                BookShopManagement.Conn.ConnectionString.Close();
            }
            else
            {
                Load();
            }
        }

        private void sale_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in sale_dgv.SelectedRows)
            {
                orderID = row.Cells[0].Value.ToString();
            }
        }

        private void delete_product_btn_Click(object sender, EventArgs e)
        {
            if (orderID != null && orderID != "")
            {
                using (ShowOrderProductDetails bf = new ShowOrderProductDetails(orderID))
                {
                    bf.ShowDialog();
                    Load();
                    orderID = "";
                }
            }
            else
            {
                alert aa = new alert("Info!", "Please Select An Order.", "info");
                aa.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            loading l = new loading();
            l.ShowDialog();
            if (orderID != null && orderID != "")
            {

                String getcusid="select Order_Customer_ID from sale_order where Order_ID='"+orderID+"'";
                MySqlCommand getcusidcmd = new MySqlCommand(getcusid, BookShopManagement.Conn.ConnectionString);
                BookShopManagement.Conn.ConnectionString.Open();

                string cid = getcusidcmd.ExecuteScalar().ToString();

                string checkdc = "select count(*) from discount_card_pos where DC_Customer_ID='" + cid + "'";
                MySqlCommand checkdccmd = new MySqlCommand(checkdc, BookShopManagement.Conn.ConnectionString);
                string res = checkdccmd.ExecuteScalar().ToString();

                if (res == "0")
                {
                    card = "false";
                    using (SaleReport bf = new SaleReport(orderID, card))
                    {
              
                        bf.ShowDialog();
                        Load();
                        orderID = "";
                    
                    }
                }
                else
                {
                    card = "true";
                    using (SaleReport bf = new SaleReport(orderID, card))
                    {
              
                        bf.ShowDialog();
                        Load();
                        orderID = "";
                      
                    }
                }
                BookShopManagement.Conn.ConnectionString.Close();
            
                Cursor.Current = Cursors.Arrow;
                
            }
            else
            {
                alert aa = new alert("Info!", "Please Select An Order", "info");
                aa.ShowDialog();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sale_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < sale_dgv.Rows.Count; i++)
            {

                String status = sale_dgv.Rows[i].Cells[4].Value.ToString();
                if (status == "Loan")
                {
                    DataGridViewRow row = sale_dgv.Rows[i];// get you required index
                    // check the cell value under your specific column and then you can toggle your colors
                    row.DefaultCellStyle.BackColor = Color.FromArgb(245, 17, 17);
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 0, 0);
                    row.DefaultCellStyle.SelectionForeColor = Color.White;
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
        private void button2_Click(object sender, EventArgs e)
        {
            salesreports srr = new salesreports();
            srr.type = "sales";
            srr.ShowDialog();
            
        }

        private void sale_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sale_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Dashboard d = new Dashboard();
            d.ll();
        }


    }
}
