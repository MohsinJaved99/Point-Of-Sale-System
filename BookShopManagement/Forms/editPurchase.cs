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
    public partial class editPurchase : Form
    {
        public editPurchase()
        {
            InitializeComponent();
        }
        int qua, price, discount,ttt;
        string ID,ppid;
        public editPurchase(string purchaseid,string pid)
        {
            InitializeComponent();
            ID = purchaseid;
            ppid = pid;
            string q = "select pd.PD_Product_Quantity as 'Quantity',product.Product_ID as 'pid',product.Product_Name as 'Product Name',product.Product_Model as 'Product Model',product.Product_Price as 'Single',pd.PD_Product_Price as 'Purchase Amount',pd.PD_Purchase_Discount as 'Discount',pd.PD_Product_Total_Price as 'Total' from purchase_pos p join purchase_details_pos pd on p.Purchase_ID=pd.PD_Purchase_ID join products_pos product on pd.PD_Product_ID=product.Product_ID where pd.PD_ID='" + purchaseid + "'";
            MySqlCommand cmd = new MySqlCommand(q, Conn.ConnectionString);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
              
                pname.Text = row["Product Name"].ToString() + " (" + row["Product Model"].ToString() + ")";
                pquantity.Text = row["Quantity"].ToString();
                tprice.Text=row["Purchase Amount"].ToString();
                discount_amount.Text = row["Discount"].ToString();
                ptotal.Text = row["Total"].ToString();
                tprice.Text = row["Total"].ToString();
                pprice.Text = row["Single"].ToString();
                qua = Convert.ToInt32(row["Quantity"].ToString());
                price = Convert.ToInt32(row["Single"].ToString());
                discount = Convert.ToInt32(row["Discount"].ToString());
                ttt = Convert.ToInt32(row["Total"].ToString());
                
            }
         
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
        private void editPurchase_Load(object sender, EventArgs e)
        {

        }
        int rr=0;

        private void pquantity_TextChanged(object sender, EventArgs e)
        {
            //rr++;
            //if (rr > 1) { 
            //string checkquantity = "select Product_Quantity from products_pos where Product_ID='" + ppid + "'";
            //    MySqlCommand checkquantitycmd = new MySqlCommand(checkquantity, BookShopManagement.Conn.ConnectionString);
            //    BookShopManagement.Conn.ConnectionString.Close();
            //    BookShopManagement.Conn.ConnectionString.Open();
            //    int getquantity = Convert.ToInt32(checkquantitycmd.ExecuteScalar().ToString());
            //    int gg = getquantity + qua;
            //    //MessageBox.Show(getquantity.ToString()<=gg);
            //    if (Convert.ToInt32(pquantity.Text) <= gg)
            //    {
                    //MessageBox.Show("accpted");
                    if (pquantity.Text == "" || pquantity.Text == null)
                    {
                        pquantity.Text = "0";
                        pquantity.SelectionStart = 0;
                        pquantity.SelectionLength = pquantity.Text.Length;
                    }
                    else if (pquantity.Text == qua.ToString())
                    {


                        int aa = Convert.ToInt32(pquantity.Text);
                        int total = aa * price;
                        tprice.Text = total.ToString();

                        pprice.Text = price.ToString();

                        int totalprice = Convert.ToInt32(tprice.Text);
                        int discountt = Convert.ToInt32(pdiscount.Text);
                        int discountedamount = (totalprice * discountt) / 100;

                        int dd = totalprice - discountedamount;

                        //int netamount = dd * Convert.ToInt32(purchase_quantity.Text);

                        ptotal.Text = dd.ToString();
                        discount_amount.Text = discountedamount.ToString();
                    }
                    else
                    {
                        int aa = Convert.ToInt32(pquantity.Text);
                        int total = aa * price;
                        tprice.Text = total.ToString();

                        pprice.Text = price.ToString();

                        int totalprice = Convert.ToInt32(tprice.Text);
                        int discountt = Convert.ToInt32(pdiscount.Text);
                        int discountedamount = (totalprice * discountt) / 100;

                        int dd = totalprice - discountedamount;

                        //int netamount = dd * Convert.ToInt32(purchase_quantity.Text);

                        ptotal.Text = dd.ToString();
                        discount_amount.Text = discountedamount.ToString();
                    }
                //}
                //else
                //{
                //    alert aa = new alert("Warning", "You Have Exceeded The Product Quantity Limit.", "info");
                //    aa.ShowDialog();
                //    pquantity.Text = gg.ToString();
                //}
            //}
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


                int aa = Convert.ToInt32(pquantity.Text);
                int totall = aa * price;
                ptotal.Text = totall.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ptotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {


            if (CheckForInternetConnection().ToString() == "True")
            {

                //string checkquantity = "select Product_Quantity from products_pos where Product_ID='" + ppid + "'";
                //MySqlCommand checkquantitycmd = new MySqlCommand(checkquantity, BookShopManagement.Conn.ConnectionString);
                //BookShopManagement.Conn.ConnectionString.Close();
                //BookShopManagement.Conn.ConnectionString.Open();
                //int getquantity = Convert.ToInt32(checkquantitycmd.ExecuteScalar().ToString());
                //int gg = getquantity + qua;

                //if (Convert.ToInt32(pquantity.Text) <= gg)
                //{

                string q = "UPDATE `purchase_details_pos` SET `PD_Product_Price`='" + tprice.Text + "',`PD_Purchase_Discount`='" + discount_amount.Text + "',`PD_Product_Quantity`='" + pquantity.Text + "',`PD_Product_Total_Price`='" + ptotal.Text + "' WHERE PD_ID='" + ID + "'";
                MySqlCommand cmd = new MySqlCommand(q, Conn.ConnectionString);
                BookShopManagement.Conn.ConnectionString.Close();
                BookShopManagement.Conn.ConnectionString.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
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
                        alert aa = new alert("Updated!", "Purchase Record Updated.", "success");
                        aa.ShowDialog();
                        this.Dispose();
                    }
                    else
                    {
                        alert aa = new alert("Error!", "Purchase Record Can't Updated.", "error");
                        aa.ShowDialog();
                    }





                }
                Conn.ConnectionString.Close();
                //}
                //else
                //{
                //    alert aa = new alert("Warning", "You Have Exceeded The Product Quantity Limit.", "info");
                //    aa.ShowDialog();
                //}

                //Conn.ConnectionString.Close();
            }
            else
            {

            }

        }

        private void tprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void pquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void pprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void pdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ptotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
