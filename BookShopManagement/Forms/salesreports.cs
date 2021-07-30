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
    public partial class salesreports : Form
    {
        public salesreports()
        {
            InitializeComponent();
            sale_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            sale_dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            sale_dgv.DefaultCellStyle.ForeColor = Color.Black;
            day.Enabled = false;
            month.Enabled = false;
            year.Enabled = false;

        }
        string purID, supID, date;
        public string type;
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (CheckForInternetConnection().ToString() == "True")
            {

                if (type == "sales")
                {
      
                    if (radioButton1.Checked)
                    {
                        if (day.Text == "")
                        {
                            alert aa = new alert("Error!", "Please Select A Date.", "error");
                            aa.ShowDialog();
                        }
                        else
                        {
                            string getdata = "SELECT orderr.Order_ID as 'Order ID',orderr.Order_Date as 'Order Date',customer.Customer_Name as 'Customer Name',customer.Customer_NIC as 'Customer NIC',orderr.Order_Type as 'Type',Concat(userr.User_First_Name,' ',userr.User_Last_Name) as 'Sale By',orderr.Order_Paid_Amount_By_Point as 'Redeem Point',orderr.Order_Paid_Amount as 'Paid Amount' from `products_pos` product join sale_product saleproduct on product.Product_ID=saleproduct.Sale_Product_ID join sale_order orderr on saleproduct.Sale_Order_ID=orderr.Order_ID join customers_pos customer on orderr.Order_Customer_ID=customer.Customer_ID join users_pos userr on orderr.Order_DoneBy=userr.User_ID where Order_Date='" + day.Text + "' GROUP BY orderr.Order_ID";
                            MySqlCommand cmd = new MySqlCommand(getdata, BookShopManagement.Conn.ConnectionString);
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                            string getsum = "select if(sum(Order_Paid_Amount) IS NOT NULL,sum(Order_Paid_Amount),0) from sale_order where Order_Date='" + day.Text + "'";
                            MySqlCommand gs = new MySqlCommand(getsum, Conn.ConnectionString);
                            BookShopManagement.Conn.ConnectionString.Close();
                            BookShopManagement.Conn.ConnectionString.Open();
                            tt.Text = gs.ExecuteScalar().ToString() + " Rs";

                            DataTable dt = new DataTable();

                            da.Fill(dt);

                            sale_dgv.DataSource = dt;

                            sale_dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            sale_dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                            BookShopManagement.Conn.ConnectionString.Close();
                        }
                    }
                    else if (radioButton2.Checked)
                    {
                        if (month.Text == "")
                        {
                            alert aa = new alert("Error!", "Please Select A Month.", "error");
                            aa.ShowDialog();
                        }
                        else
                        {
                            string getdata = "SELECT orderr.Order_ID as 'Order ID',orderr.Order_Date as 'Order Date',customer.Customer_Name as 'Customer Name',customer.Customer_NIC as 'Customer NIC',orderr.Order_Type as 'Type',Concat(userr.User_First_Name,' ',userr.User_Last_Name) as 'Sale By',orderr.Order_Paid_Amount_By_Point as 'Redeem Point',orderr.Order_Paid_Amount as 'Paid Amount' from `products_pos` product join sale_product saleproduct on product.Product_ID=saleproduct.Sale_Product_ID join sale_order orderr on saleproduct.Sale_Order_ID=orderr.Order_ID join customers_pos customer on orderr.Order_Customer_ID=customer.Customer_ID join users_pos userr on orderr.Order_DoneBy=userr.User_ID where Order_Date like '%" + month.Text + "%' GROUP BY orderr.Order_ID";
                            MySqlCommand cmd = new MySqlCommand(getdata, BookShopManagement.Conn.ConnectionString);
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            string getsum = "select if(sum(Order_Paid_Amount) IS NOT NULL,sum(Order_Paid_Amount),0) from sale_order where Order_Date like '%" + month.Text + "%'";
                            MySqlCommand gs = new MySqlCommand(getsum, Conn.ConnectionString);
                            BookShopManagement.Conn.ConnectionString.Close();
                            BookShopManagement.Conn.ConnectionString.Open();
                            tt.Text = gs.ExecuteScalar().ToString() + " Rs";

                            DataTable dt = new DataTable();

                            da.Fill(dt);

                            sale_dgv.DataSource = dt;

                            sale_dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            sale_dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                            BookShopManagement.Conn.ConnectionString.Close();
                        }
                    }
                    else if (radioButton3.Checked)
                    {
                        if (year.Text == "")
                        {
                            alert aa = new alert("Error!", "Please Select A Year.", "error");
                            aa.ShowDialog();
                        }
                        else
                        {
                            string getdata = "SELECT orderr.Order_ID as 'Order ID',orderr.Order_Date as 'Order Date',customer.Customer_Name as 'Customer Name',customer.Customer_NIC as 'Customer NIC',orderr.Order_Type as 'Type',Concat(userr.User_First_Name,' ',userr.User_Last_Name) as 'Sale By',orderr.Order_Paid_Amount_By_Point as 'Redeem Point',orderr.Order_Paid_Amount as 'Paid Amount' from `products_pos` product join sale_product saleproduct on product.Product_ID=saleproduct.Sale_Product_ID join sale_order orderr on saleproduct.Sale_Order_ID=orderr.Order_ID join customers_pos customer on orderr.Order_Customer_ID=customer.Customer_ID join users_pos userr on orderr.Order_DoneBy=userr.User_ID where Order_Date like '%" + year.Text + "%' GROUP BY orderr.Order_ID";
                            MySqlCommand cmd = new MySqlCommand(getdata, BookShopManagement.Conn.ConnectionString);
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            string getsum = "select if(sum(Order_Paid_Amount) IS NOT NULL,sum(Order_Paid_Amount),0) from sale_order where Order_Date like '%" + year.Text + "%'";
                            MySqlCommand gs = new MySqlCommand(getsum, Conn.ConnectionString);
                            BookShopManagement.Conn.ConnectionString.Close();
                            BookShopManagement.Conn.ConnectionString.Open();
                            tt.Text = gs.ExecuteScalar().ToString() + " Rs";

                            DataTable dt = new DataTable();

                            da.Fill(dt);

                            sale_dgv.DataSource = dt;

                            sale_dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            sale_dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                            BookShopManagement.Conn.ConnectionString.Close();
                        }

                    }
                }
                else if (type == "purchase")
                {
                    if (radioButton1.Checked)
                    {
                        if (day.Text == "")
                        {
                            alert aa = new alert("Error!", "Please Select A Date.", "error");
                            aa.ShowDialog();
                        }
                        else
                        {
                            string getdata = "select p.Purchase_ID as 'Purchase ID',p.Purchase_Date as 'Purchase Date',p.Purchase_Supplier_ID as 'Supplier ID',s.Supplier_Company as 'Company',s.Supplier_Contact_Person as 'Supplier Name',s.Supplier_Phone as 'Supplier Contact' , CONCAT(u.User_First_Name,' ',u.User_Last_Name) as 'Name' from purchase_pos p join suppliers_pos s on p.Purchase_Supplier_ID=s.Supplier_ID join users_pos u on u.User_ID=p.Purchase_Done_By where Purchase_Date='" + day.Text + "' GROUP BY p.Purchase_Date,p.Purchase_Supplier_ID";
                            MySqlCommand cmd = new MySqlCommand(getdata, BookShopManagement.Conn.ConnectionString);
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                            string getsum = "select if(sum(pd.PD_Product_Total_Price) IS NOT NULL,sum(pd.PD_Product_Total_Price),0) from purchase_pos p join purchase_details_pos pd on p.Purchase_ID=pd.PD_Purchase_ID where p.Purchase_Date='" + day.Text + "'";
                            MySqlCommand gs = new MySqlCommand(getsum, Conn.ConnectionString);
                            BookShopManagement.Conn.ConnectionString.Close();
                            BookShopManagement.Conn.ConnectionString.Open();
                            tt.Text = gs.ExecuteScalar().ToString() + " Rs";

                            DataTable dt = new DataTable();

                            da.Fill(dt);

                            sale_dgv.DataSource = dt;

                            //sale_dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            //sale_dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                            BookShopManagement.Conn.ConnectionString.Close();
                        }
                    }
                    else if (radioButton2.Checked)
                    {
                        if (month.Text == "")
                        {
                            alert aa = new alert("Error!", "Please Select A Month.", "error");
                            aa.ShowDialog();
                        }
                        else
                        {
                            string getdata = "select p.Purchase_ID as 'Purchase ID',p.Purchase_Date as 'Purchase Date',p.Purchase_Supplier_ID as 'Supplier ID',s.Supplier_Company as 'Company',s.Supplier_Contact_Person as 'Supplier Name',s.Supplier_Phone as 'Supplier Contact' , CONCAT(u.User_First_Name,' ',u.User_Last_Name) as 'Name' from purchase_pos p join suppliers_pos s on p.Purchase_Supplier_ID=s.Supplier_ID join users_pos u on u.User_ID=p.Purchase_Done_By where Purchase_Date like '%" + month.Text + "%'  GROUP BY p.Purchase_Date,p.Purchase_Supplier_ID";
                            MySqlCommand cmd = new MySqlCommand(getdata, BookShopManagement.Conn.ConnectionString);
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            string getsum = "select if(sum(pd.PD_Product_Total_Price) IS NOT NULL,sum(pd.PD_Product_Total_Price),0) from purchase_pos p join purchase_details_pos pd on p.Purchase_ID=pd.PD_Purchase_ID where p.Purchase_Date like '%" + month.Text + "%'";
                            MySqlCommand gs = new MySqlCommand(getsum, Conn.ConnectionString);
                            BookShopManagement.Conn.ConnectionString.Close();
                            BookShopManagement.Conn.ConnectionString.Open();
                            tt.Text = gs.ExecuteScalar().ToString() + " Rs";

                            DataTable dt = new DataTable();

                            da.Fill(dt);

                            sale_dgv.DataSource = dt;

                            //sale_dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            //sale_dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                            BookShopManagement.Conn.ConnectionString.Close();
                        }
                    }
                    else if (radioButton3.Checked)
                    {
                        if (year.Text == "")
                        {
                            alert aa = new alert("Error!", "Please Select A Year.", "error");
                            aa.ShowDialog();
                        }
                        else
                        {
                            string getdata = "select p.Purchase_ID as 'Purchase ID',p.Purchase_Date as 'Purchase Date',p.Purchase_Supplier_ID as 'Supplier ID',s.Supplier_Company as 'Company',s.Supplier_Contact_Person as 'Supplier Name',s.Supplier_Phone as 'Supplier Contact' , CONCAT(u.User_First_Name,' ',u.User_Last_Name) as 'Name' from purchase_pos p join suppliers_pos s on p.Purchase_Supplier_ID=s.Supplier_ID join users_pos u on u.User_ID=p.Purchase_Done_By where Purchase_Date like '%" + year.Text + "%'  GROUP BY p.Purchase_Date,p.Purchase_Supplier_ID";
                            MySqlCommand cmd = new MySqlCommand(getdata, BookShopManagement.Conn.ConnectionString);
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            string getsum = "select if(sum(pd.PD_Product_Total_Price) IS NOT NULL,sum(pd.PD_Product_Total_Price),0) from purchase_pos p join purchase_details_pos pd on p.Purchase_ID=pd.PD_Purchase_ID where p.Purchase_Date like '%" + year.Text + "%'";
                            MySqlCommand gs = new MySqlCommand(getsum, Conn.ConnectionString);
                            BookShopManagement.Conn.ConnectionString.Close();
                            BookShopManagement.Conn.ConnectionString.Open();
                            tt.Text = gs.ExecuteScalar().ToString() + " Rs";

                            DataTable dt = new DataTable();

                            da.Fill(dt);

                            sale_dgv.DataSource = dt;

                            //sale_dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            //sale_dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                            BookShopManagement.Conn.ConnectionString.Close();
                        }

                    }
                }
            }
            else
            {
                alert aa = new alert("Info!", "You Are Using Unlimited Package.", "info");
                aa.ShowDialog();
            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            day.Enabled = true;
            month.Enabled = false;
            year.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            day.Enabled = false;
            month.Enabled = true;
            year.Enabled = false;
            year.SelectedIndex = -1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            day.Enabled = false;
            month.Enabled = false;
            year.Enabled = true;
            month.SelectedIndex = -1;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void salesreports_Load(object sender, EventArgs e)
        {
            for (int i = 2020; i < 2030; i++)
            {
                year.Items.Add(i.ToString());
            }

            if (type == "sales")
            {
                saledetails.Visible = true;
                purchasedetails.Visible = false;
            }
            else if (type == "purchase")
            {
                saledetails.Visible = false;
                purchasedetails.Visible = true;
            }
            
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
        string orderID;
        private void delete_product_btn_Click(object sender, EventArgs e)
        {
            if (orderID != null && orderID != "")
            {
                using (ShowOrderProductDetails bf = new ShowOrderProductDetails(orderID))
                {
                    bf.ShowDialog();
                    orderID = "";
                }
            }
            else
            {
                alert aa = new alert("Info!", "Please Select An Order.", "info");
                aa.ShowDialog();
            }
        }

        private void sale_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (type == "sales")
            {
                foreach (DataGridViewRow row in sale_dgv.SelectedRows)
                {
                    orderID = row.Cells[0].Value.ToString();
                }
            }
            else if (type == "purchase")
            {

                foreach (DataGridViewRow row in sale_dgv.SelectedRows)
                {
                    purID = row.Cells[0].Value.ToString();
                    supID = row.Cells[2].Value.ToString();
                    date = row.Cells[1].Value.ToString();
                }
        
            }
        }

        private void year_SelectedIndexChanged(object sender, EventArgs e)
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
        private void sale_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void edit_customer_btn_Click(object sender, EventArgs e)
        {
            if (supID != null && supID != "" && date != null && date != "")
            {

                using (Show_Purchase_Products bf = new Show_Purchase_Products(supID, date))
                {
                    bf.ShowDialog();
                    supID = "";
                    date = "";

                }
            }
            else
            {
                alert aa = new alert("Info!", "Please Select A Purchase.", "info");
                aa.ShowDialog();
            }
        }
    }
}
