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
    public partial class editOrder : Form
    {
        public editOrder()
        {
            InitializeComponent();
        }
        int quantity, price, discount, ttt;
        string orderID, ppid,ssid;
        int rr = 0;


        public editOrder(string orderid, string sid,string pid)
        {
            InitializeComponent();
            orderID = orderid;
            ppid = pid;
            ssid = sid;
            string q = "SELECT product.Product_ID,product.Product_Name,product.Product_Model,sp.Sale_Product_Price,sp.Sale_Discounted_Price,sp.Sale_Product_Discounted_Amount,sp.Sale_Product_Quantity,so.Order_Total_Price from products_pos product join sale_product sp on sp.Sale_Product_ID=product.Product_ID join sale_order so on sp.Sale_Order_ID=so.Order_ID where so.Order_ID='" + orderid + "' and sp.Sale_ID='" + sid + "'";
            MySqlCommand cmd = new MySqlCommand(q, Conn.ConnectionString);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {

                pname.Text = row["Product_Name"].ToString() + " (" + row["Product_Model"].ToString() + ")";
                pquantity.Text = row["Sale_Product_Quantity"].ToString();

                discount_amount.Text = row["Sale_Product_Discounted_Amount"].ToString();
                ptotal.Text = row["Sale_Discounted_Price"].ToString();
                tprice.Text = row["Sale_Product_Price"].ToString();
                //pprice.Text = row["Sale_Product_Price"].ToString();
                quantity = Convert.ToInt32(row["Sale_Product_Quantity"].ToString());
                price = Convert.ToInt32(row["Sale_Product_Price"].ToString());
                discount = Convert.ToInt32(row["Sale_Product_Discounted_Amount"].ToString());
                ttt = Convert.ToInt32(row["Order_Total_Price"].ToString());
                //MessageBox.Show(row["Order_Total_Price"].ToString());
                int aaa = Convert.ToInt32(row["Sale_Product_Price"].ToString()) * Convert.ToInt32(row["Sale_Product_Quantity"].ToString());
                ta.Text = aaa.ToString();
            }
         
        }
        int total;
        int totalforsaleorder;
        private void pquantity_TextChanged(object sender, EventArgs e)
        {
            if (pquantity.Text == "")
            {

            }
            else
            {
                rr++;
                if (rr > 1)
                {
                    string checkquantity = "select Product_Quantity from products_pos where Product_ID='" + ppid + "'";
                    MySqlCommand checkquantitycmd = new MySqlCommand(checkquantity, BookShopManagement.Conn.ConnectionString);
                    BookShopManagement.Conn.ConnectionString.Close();
                    BookShopManagement.Conn.ConnectionString.Open();
                    int getquantity = Convert.ToInt32(checkquantitycmd.ExecuteScalar().ToString());
                    int gg = getquantity + quantity;
                    //MessageBox.Show(getquantity.ToString()<=gg);
                    if (Convert.ToInt32(pquantity.Text) <= gg)
                    {

                        if (pquantity.Text == "" || pquantity.Text == null)
                        {
                            pquantity.Text = "0";
                            pquantity.SelectionStart = 0;
                            pquantity.SelectionLength = pquantity.Text.Length;
                        }
                        else if (pquantity.Text == quantity.ToString())
                        {


                            int aa = Convert.ToInt32(pquantity.Text);
                            total = aa * price;

                            int totalprice = Convert.ToInt32(tprice.Text);
                            int discountt = Convert.ToInt32(pdiscount.Text);
                            int discountedamount = (totalprice * discountt) / 100;

                            int dd = totalprice - discountedamount;



                            ptotal.Text = dd.ToString();
                            discount_amount.Text = discountedamount.ToString();
                            totalforsaleorder = Convert.ToInt32(ptotal.Text) * Convert.ToInt32(pquantity.Text);
                            ta.Text = totalforsaleorder.ToString();
                        }
                        else
                        {
                            int aa = Convert.ToInt32(pquantity.Text);
                            total = aa * price;

                            int totalprice = Convert.ToInt32(tprice.Text);
                            int discountt = Convert.ToInt32(pdiscount.Text);
                            int discountedamount = (totalprice * discountt) / 100;

                            int dd = totalprice - discountedamount;



                            ptotal.Text = dd.ToString();
                            discount_amount.Text = discountedamount.ToString();
                            totalforsaleorder = Convert.ToInt32(ptotal.Text) * Convert.ToInt32(pquantity.Text);
                            ta.Text = totalforsaleorder.ToString();
                        }
                    }
                    else
                    {
                        alert aa = new alert("Warning", "You Have Exceeded The Product Quantity Limit.", "info");
                        aa.ShowDialog();
                        pquantity.Text = gg.ToString();
                    }
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
        private void editOrder_Load(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pdiscount_TextChanged(object sender, EventArgs e)
        {
            if (pdiscount.Text != null && pdiscount.Text != "" && pdiscount.Text != "0")
            {
                if (tprice.Text != "" || tprice.Text != "0" || tprice != null)
                {
                    int totalprice = Convert.ToInt32(tprice.Text);
                    int discountt = Convert.ToInt32(pdiscount.Text);
                    int discountedamount = (totalprice * discountt) / 100;

                    int dd = totalprice - discountedamount;

                    //int netamount = dd * Convert.ToInt32(purchase_quantity.Text);

                    ptotal.Text = dd.ToString();
                    discount_amount.Text = discountedamount.ToString();
                    totalforsaleorder = Convert.ToInt32(ptotal.Text) * Convert.ToInt32(pquantity.Text);
                    ta.Text = totalforsaleorder.ToString();
                }
            }
            else if (pquantity.Text == "")
            {
                pquantity.Text = "0";
                pquantity.SelectionStart = 0;
                pquantity.SelectionLength = pquantity.Text.Length;

            }
            else
            {
                discount_amount.Text = "0";

                int totalprice = Convert.ToInt32(tprice.Text);
                int discountt = Convert.ToInt32(pdiscount.Text);
                int discountedamount = (totalprice * discountt) / 100;

                int dd = totalprice - discountedamount;

                //int netamount = dd * Convert.ToInt32(purchase_quantity.Text);

                ptotal.Text = dd.ToString();
                discount_amount.Text = discountedamount.ToString();
                totalforsaleorder = Convert.ToInt32(ptotal.Text) * Convert.ToInt32(pquantity.Text);
                ta.Text = totalforsaleorder.ToString();
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (CheckForInternetConnection().ToString() == "True")
            {
                string updatesaleproduct = "UPDATE `sale_product` SET `Sale_Product_Price`='" + tprice.Text + "',`Sale_Product_Discounted_Amount`='" + discount_amount.Text + "',`Sale_Discounted_Price`='" + ptotal.Text + "',`Sale_Product_Quantity`='" + pquantity.Text + "' WHERE Sale_ID='" + ssid + "'";
                MySqlCommand saleproduct = new MySqlCommand(updatesaleproduct, Conn.ConnectionString);
                Conn.ConnectionString.Close();
                Conn.ConnectionString.Open();
                int saleproductres = saleproduct.ExecuteNonQuery();
                if (saleproductres > 0)
                {

                    string getordertotal_amount = "SELECT IF (sum(Sale_Discounted_Price) IS NOT NULL,sum(Sale_Discounted_Price),0) as sum from sale_product WHERE Sale_Product_ID!='" + ppid + "' and Sale_Order_ID='" + orderID + "'";
                    MySqlCommand cmd = new MySqlCommand(getordertotal_amount, Conn.ConnectionString);
                    int ttl = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    int summ = ttl + totalforsaleorder;

                    string checkpointpaid = "SELECT Order_Paid_Amount_By_Point FROM `sale_order` WHERE Order_ID='" + orderID + "'";
                    MySqlCommand cpp = new MySqlCommand(checkpointpaid, Conn.ConnectionString);
                    int ss = Convert.ToInt32(cpp.ExecuteScalar().ToString());
                    int paidamount = summ - ss;

                    string updateorder = "UPDATE sale_order set Order_Total_Price='" + summ.ToString() + "',Order_Paid_Amount='" + paidamount.ToString() + "' where Order_ID='" + orderID + "'";
                    MySqlCommand saleorder = new MySqlCommand(updateorder, Conn.ConnectionString);
                    int saleorderres = saleorder.ExecuteNonQuery();
                    if (saleorderres > 0)
                    {

                        string getallpurchase = "select sum(PD_Product_Quantity) as sum from purchase_details_pos where PD_Product_ID='" + ppid + "'";
                        MySqlCommand getallpurchasecmd = new MySqlCommand(getallpurchase, Conn.ConnectionString);
                        int purchasequa = Convert.ToInt32(getallpurchasecmd.ExecuteScalar().ToString());

                        string getsale = "select sum(Sale_Product_Quantity) as salesum from sale_product where Sale_Product_ID='" + ppid + "'";
                        MySqlCommand getsalecmd = new MySqlCommand(getsale, Conn.ConnectionString);
                        int salequa = Convert.ToInt32(getsalecmd.ExecuteScalar().ToString());

                        int quantity = purchasequa - salequa;

                        string updatequa = "update products_pos set Product_Quantity='" + quantity.ToString() + "' where Product_ID='" + ppid + "'";

                        MySqlCommand updatee = new MySqlCommand(updatequa, Conn.ConnectionString);

                        int rr = updatee.ExecuteNonQuery();

                        if (rr > 0)
                        {
                            alert aa = new alert("Updated!", "Sale Record Updated.", "success");
                            aa.ShowDialog();
                            this.Dispose();
                        }
                        else
                        {
                            alert aa = new alert("Error!", "Sale Record Can't Updated.", "error");
                            aa.ShowDialog();
                        }


                    }

                }
                Conn.ConnectionString.Close();
            }
            else
            {

            }
        }
      
    }
}
