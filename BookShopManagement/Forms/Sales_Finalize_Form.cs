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
    public partial class Sales_Finalize_Form : Form
    {
        public Sales_Finalize_Form()
        {
            InitializeComponent();
        }
        String cutomerid;
        String productOrignalPrice;
        String TotalAmount;
        String DicscountCardID;
        String avlpoint;
        String orderID, card;
        String loan="false";
        public Sales_Finalize_Form(ListView sale_list_view, String custid, String productRealPrice, String totalAmount, String dicountcardid)
        {
          
            cutomerid = custid;
            productOrignalPrice = productRealPrice;
            TotalAmount = totalAmount;
         
            if (dicountcardid == null || dicountcardid == "")
            {
                DicscountCardID = "";
        
            }
            else {
             
                DicscountCardID = dicountcardid;
            }
            
            _listView = sale_list_view;
            InitializeComponent();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int result;
        String disincardid1, sumofpoints1;


        private void addCshBank()
        {

            if (loan == "true")
            {
               
                Random r = new Random();
                int serialno = Convert.ToInt32(r.Next(1000000000));
                foreach (ListViewItem itemmm in _listView.Items)
                {
                    string checkquantity = "select Product_Quantity from products_pos where Product_ID='" + itemmm.SubItems[0].Text + "'";
                    MySqlCommand checkquantitycmd = new MySqlCommand(checkquantity, BookShopManagement.Conn.ConnectionString);
                    Conn.ConnectionString.Close();
                    Conn.ConnectionString.Open();
                    int getquantity = Convert.ToInt32(checkquantitycmd.ExecuteScalar().ToString());

                    if (Convert.ToInt32(itemmm.SubItems[2].Text) <= getquantity)
                    {

                        var info = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
                        DateTimeOffset localServerTime = DateTimeOffset.Now;


                        String insertOrder = "INSERT INTO `sale_order`(`Order_ID`, `Serial_Number`, `Order_Date`, `Order_Customer_ID`, `Order_DoneBy`, `Order_Type`, `Order_Discount_Card_ID` , `Order_Paid_Amount_By_Point`) VALUES (null,@srno,@orderdate,@ordercustomer,@orderdoneby,'Loan',@discountcardid,0)";
                        MySqlCommand cmdorder = new MySqlCommand(insertOrder, BookShopManagement.Conn.ConnectionString);
                        cmdorder.Parameters.AddWithValue("@srno", serialno.ToString());
                        cmdorder.Parameters.AddWithValue("@orderdate", TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy"));
                        cmdorder.Parameters.AddWithValue("@ordercustomer", cutomerid);
                        cmdorder.Parameters.AddWithValue("@orderdoneby", Retrieval.User_ID.ToString());
                        cmdorder.Parameters.AddWithValue("@discountcardid", DicscountCardID);


                        int orderres = cmdorder.ExecuteNonQuery();

                        if (orderres > 0)
                        {

                            string getLastOrder = "select Order_ID from sale_order order by Order_ID DESC LIMIT 0,1";
                            MySqlCommand getorderid = new MySqlCommand(getLastOrder, BookShopManagement.Conn.ConnectionString);

                            String orderiddd = getorderid.ExecuteScalar().ToString();
                            //String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,@productid,@productprice,@productdiscountedprice,@productquantity,@productorderid)";
                            //MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
                            foreach (ListViewItem item in _listView.Items)
                            {
                                String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`,`Sale_Product_Discounted_Amount`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,'" + item.SubItems[0].Text + "','" + item.SubItems[4].Text + "','" + item.SubItems[5].Text + "','" + item.SubItems[3].Text + "','" + item.SubItems[2].Text + "','" + orderiddd + "')";
                                MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
                                //cmdproduct.Parameters.AddWithValue("@productid", item.SubItems[0].Text);
                                //cmdproduct.Parameters.AddWithValue("@productprice", item.SubItems[4].Text);
                                //cmdproduct.Parameters.AddWithValue("@ordeproductdiscountedpricertype", item.SubItems[3].Text);
                                //cmdproduct.Parameters.AddWithValue("@productquantity", item.SubItems[2].Text);
                                //cmdproduct.Parameters.AddWithValue("@productorderid", orderiddd);
                                //MessageBox.Show(insertProducts);
                                int prores = cmdproduct.ExecuteNonQuery();
                                if (prores > 0)
                                {
                                    string refreshquantity = "select Product_Quantity from products_pos where Product_ID='" + item.SubItems[0].Text + "'";
                                    MySqlCommand refreshquantitycmd = new MySqlCommand(refreshquantity, BookShopManagement.Conn.ConnectionString);
                                    int refreshquantityres = Convert.ToInt32(refreshquantitycmd.ExecuteScalar().ToString());

                                    int sub = refreshquantityres - Convert.ToInt32(item.SubItems[2].Text);

                                    string updateq = "update products_pos set Product_Quantity='" + sub.ToString() + "' where Product_ID='" + item.SubItems[0].Text + "'";
                                    MySqlCommand upcmd = new MySqlCommand(updateq, BookShopManagement.Conn.ConnectionString);
                                    int upres = upcmd.ExecuteNonQuery();
                                    if (upres > 0)
                                    {

                                        string insertinloan = "INSERT INTO `credit_sale`(`Credit_Sale_ID`, `Credit_Order_ID`, `Credit_Customer_ID`, `Credit_Date`,`Paying_Date`, `Credit_Amount`) VALUES (null,'" + orderiddd + "','" + cutomerid + "','" + TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy") + "','"+payingdate_txt.Text+"','" + total_amount_txt.Text + "')";
                                        MySqlCommand loann=new MySqlCommand(insertinloan,Conn.ConnectionString);
                                        int ll = loann.ExecuteNonQuery();
                                        if (ll > 0)
                                        {
                                            result++;
                                        }
                                   

                                    }

                                }
                            }
                            if (result == 1)
                            {
                                alert aa = new alert("Loan!", "Loan Data Inserted Successfull.", "success");
                                aa.ShowDialog();

                                alert aaa = new alert("Sold!", "Sale Successfull.", "success");
                                aaa.ShowDialog();
                         
                                this.close_button.PerformClick();

                               
                            }
                            else
                            {
                                alert aa = new alert("Error!", "Sale Failed.", "error");
                                aa.ShowDialog();
                            }

                        }
                        else
                        {
                            alert aa = new alert("Error!", "Sale Failed.", "error");
                            aa.ShowDialog();
                        }
                        BookShopManagement.Conn.ConnectionString.Close();

                    }
                }
                        
            }
            else
            {

                Random r = new Random();
                int serialno = Convert.ToInt32(r.Next(1000000000));
                foreach (ListViewItem itemmm in _listView.Items)
                {
                    string checkquantity = "select Product_Quantity from products_pos where Product_ID='" + itemmm.SubItems[0].Text + "'";
                    MySqlCommand checkquantitycmd = new MySqlCommand(checkquantity, BookShopManagement.Conn.ConnectionString);
                    Conn.ConnectionString.Close();
                    Conn.ConnectionString.Open();
                    int getquantity = Convert.ToInt32(checkquantitycmd.ExecuteScalar().ToString());

                    if (Convert.ToInt32(itemmm.SubItems[2].Text) <= getquantity)
                    {

                        var info = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
                        DateTimeOffset localServerTime = DateTimeOffset.Now;
                        if (payment_combo.Text == "Cash")
                        {




                            String insertOrder = "INSERT INTO `sale_order`(`Order_ID`, `Serial_Number`, `Order_Date`, `Order_Customer_ID`, `Order_DoneBy`, `Order_Type`, `Order_Total_Price`, `Order_Paid_Amount`, `Order_Discount_Card_ID`, `Order_Paid_Amount_By_Point`) VALUES (null,@srno,@orderdate,@ordercustomer,@orderdoneby,@ordertype,@ordertotalprice,@orderpaidamount,@discountcardid,@orderpaidamountcard)";
                            MySqlCommand cmdorder = new MySqlCommand(insertOrder, BookShopManagement.Conn.ConnectionString);
                            cmdorder.Parameters.AddWithValue("@srno", serialno.ToString());
                            cmdorder.Parameters.AddWithValue("@orderdate", TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy"));
                            cmdorder.Parameters.AddWithValue("@ordercustomer", cutomerid);
                            cmdorder.Parameters.AddWithValue("@orderdoneby", Retrieval.User_ID.ToString());
                            cmdorder.Parameters.AddWithValue("@ordertype", payment_combo.Text);
                            cmdorder.Parameters.AddWithValue("@ordertotalprice", TotalAmount);
                            cmdorder.Parameters.AddWithValue("@orderpaidamount", paid_amount_txt.Text);
                            if (DicscountCardID == "")
                            {
                                cmdorder.Parameters.AddWithValue("@discountcardid", null);
                            }
                            else
                            {
                                cmdorder.Parameters.AddWithValue("@discountcardid", DicscountCardID);
                            }
                            cmdorder.Parameters.AddWithValue("@orderpaidamountcard", avlpoint);

                            int orderres = cmdorder.ExecuteNonQuery();

                            if (orderres > 0)
                            {

                                string getLastOrder = "select Order_ID from sale_order order by Order_ID DESC LIMIT 0,1";
                                MySqlCommand getorderid = new MySqlCommand(getLastOrder, BookShopManagement.Conn.ConnectionString);

                                String orderiddd = getorderid.ExecuteScalar().ToString();
                                //String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,@productid,@productprice,@productdiscountedprice,@productquantity,@productorderid)";
                                //MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
                                foreach (ListViewItem item in _listView.Items)
                                {
                                    String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`,`Sale_Product_Discounted_Amount`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,'" + item.SubItems[0].Text + "','" + item.SubItems[4].Text + "','" + item.SubItems[5].Text + "','" + item.SubItems[3].Text + "','" + item.SubItems[2].Text + "','" + orderiddd + "')";
                                    MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
                                    //cmdproduct.Parameters.AddWithValue("@productid", item.SubItems[0].Text);
                                    //cmdproduct.Parameters.AddWithValue("@productprice", item.SubItems[4].Text);
                                    //cmdproduct.Parameters.AddWithValue("@ordeproductdiscountedpricertype", item.SubItems[3].Text);
                                    //cmdproduct.Parameters.AddWithValue("@productquantity", item.SubItems[2].Text);
                                    //cmdproduct.Parameters.AddWithValue("@productorderid", orderiddd);
                                    //MessageBox.Show(insertProducts);
                                    int prores = cmdproduct.ExecuteNonQuery();
                                    if (prores > 0)
                                    {
                                        string refreshquantity = "select Product_Quantity from products_pos where Product_ID='" + item.SubItems[0].Text + "'";
                                        MySqlCommand refreshquantitycmd = new MySqlCommand(refreshquantity, BookShopManagement.Conn.ConnectionString);
                                        int refreshquantityres = Convert.ToInt32(refreshquantitycmd.ExecuteScalar().ToString());

                                        int sub = refreshquantityres - Convert.ToInt32(item.SubItems[2].Text);

                                        string updateq = "update products_pos set Product_Quantity='" + sub.ToString() + "' where Product_ID='" + item.SubItems[0].Text + "'";
                                        MySqlCommand upcmd = new MySqlCommand(updateq, BookShopManagement.Conn.ConnectionString);
                                        int upres = upcmd.ExecuteNonQuery();
                                        if (upres > 0)
                                        {
                                            result++;

                                        }

                                    }
                                }
                                if (result == 1)
                                {
                                    alert aa = new alert("Sold!", "Sale Successfull.", "success");
                                    aa.ShowDialog();

                                    confirmationForm cd = new confirmationForm("Sale Report", "Do You Want To Generate Sale Report?");
                                    cd.ShowDialog();
                                    if (cd.r == "yes")
                                    {
                                        loading l = new loading();
                                        l.ShowDialog();

                                        String getorderidd = "select Order_ID from sale_order where Order_Customer_ID='" + cutomerid + "' order by Order_ID DESC LIMIT 0,1";
                                        MySqlCommand getorderidcmd = new MySqlCommand(getorderidd, BookShopManagement.Conn.ConnectionString);
                                        string oid = getorderidcmd.ExecuteScalar().ToString();

                                        //String getcusid = "select Order_Customer_ID from sale_order where Order_ID='" + oid + "'";
                                        //MySqlCommand getcusidcmd = new MySqlCommand(getcusid, BookShopManagement.Conn.ConnectionString);


                                        //string cid = getcusidcmd.ExecuteScalar().ToString();

                                        string checkdc = "select count(*) from discount_card_pos where DC_Customer_ID='" + cutomerid + "'";
                                        MySqlCommand checkdccmd = new MySqlCommand(checkdc, BookShopManagement.Conn.ConnectionString);
                                        string res = checkdccmd.ExecuteScalar().ToString();
                                        orderID = oid;
                                        if (res == "0")
                                        {
                                            card = "false";
                                            using (SaleReport bf = new SaleReport(orderID, card))
                                            {
                                                bf.ShowDialog();

                                                orderID = "";

                                            }
                                        }
                                        else
                                        {
                                            card = "true";
                                            using (SaleReport bf = new SaleReport(orderID, card))
                                            {
                                                bf.ShowDialog();

                                                orderID = "";
                                            }
                                        }

                                        this.close_button.PerformClick();

                                    }
                                    else
                                    {
                                        this.close_button.PerformClick();
                                    }
                                }
                                else
                                {
                                    alert aa = new alert("Error!", "Sale Failed.", "error");
                                    aa.ShowDialog();
                                }

                            }
                            else
                            {
                                alert aa = new alert("Error!", "Sale Failed.", "error");
                                aa.ShowDialog();
                            }
                            BookShopManagement.Conn.ConnectionString.Close();


                        }
                        else
                        {
                            var bankid_combo = bank_name_txt.SelectedItem as ComboboxItem;



                            String insertOrder = "INSERT INTO `sale_order`(`Order_ID`, `Serial_Number`, `Order_Date`, `Order_Customer_ID`, `Order_DoneBy`, `Order_Type`, `Order_Bank_Account_ID`, `Order_Total_Price`, `Order_Paid_Amount`, `Order_Discount_Card_ID`, `Order_Paid_Amount_By_Point`) VALUES (null,@srno,@orderdate,@ordercustomer,@orderdoneby,@ordertype,@orderbank,@ordertotalprice,@orderpaidamount,@discountcardid,@orderpaidamountcard)";
                            MySqlCommand cmdorder = new MySqlCommand(insertOrder, BookShopManagement.Conn.ConnectionString);
                            cmdorder.Parameters.AddWithValue("@srno", serialno.ToString());
                            cmdorder.Parameters.AddWithValue("@orderdate", TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy"));
                            cmdorder.Parameters.AddWithValue("@ordercustomer", cutomerid);
                            cmdorder.Parameters.AddWithValue("@orderdoneby", Retrieval.User_ID.ToString());
                            cmdorder.Parameters.AddWithValue("@ordertype", payment_combo.Text);
                            cmdorder.Parameters.AddWithValue("@orderbank", bankid_combo.Value.ToString());
                            cmdorder.Parameters.AddWithValue("@ordertotalprice", TotalAmount);
                            cmdorder.Parameters.AddWithValue("@orderpaidamount", paid_amount_txt.Text);
                            if (DicscountCardID == "")
                            {
                                cmdorder.Parameters.AddWithValue("@discountcardid", null);
                            }
                            else
                            {
                                cmdorder.Parameters.AddWithValue("@discountcardid", DicscountCardID);
                            }
                            cmdorder.Parameters.AddWithValue("@orderpaidamountcard", avlpoint);
                            BookShopManagement.Conn.ConnectionString.Close();
                            BookShopManagement.Conn.ConnectionString.Open();
                            int orderres = cmdorder.ExecuteNonQuery();

                            if (orderres > 0)
                            {

                                string getLastOrder = "select Order_ID from sale_order order by Order_ID DESC LIMIT 0,1";
                                MySqlCommand getorderid = new MySqlCommand(getLastOrder, BookShopManagement.Conn.ConnectionString);

                                String orderiddd = getorderid.ExecuteScalar().ToString();
                                //String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,@productid,@productprice,@productdiscountedprice,@productquantity,@productorderid)";
                                //MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
                                foreach (ListViewItem item in _listView.Items)
                                {
                                    String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`,`Sale_Product_Discounted_Amount`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,'" + item.SubItems[0].Text + "','" + item.SubItems[4].Text + "','" + item.SubItems[5].Text + "','" + item.SubItems[3].Text + "','" + item.SubItems[2].Text + "','" + orderiddd + "')";
                                    MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
                                    //cmdproduct.Parameters.AddWithValue("@productid", item.SubItems[0].Text);
                                    //cmdproduct.Parameters.AddWithValue("@productprice", item.SubItems[4].Text);
                                    //cmdproduct.Parameters.AddWithValue("@ordeproductdiscountedpricertype", item.SubItems[3].Text);
                                    //cmdproduct.Parameters.AddWithValue("@productquantity", item.SubItems[2].Text);
                                    //cmdproduct.Parameters.AddWithValue("@productorderid", orderiddd);
                                    //MessageBox.Show(insertProducts);
                                    int prores = cmdproduct.ExecuteNonQuery();
                                    if (prores > 0)
                                    {



                                        String dd = TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy hh:mm:ss tt");
                                        String addTransection = "INSERT INTO `transactions_in_pos`(`Transaction_In_ID`, `Transaction_In_Payment_Method`, `Transaction_In_Account_ID`, `Transaction_In_Amount`, `Transaction_In_Date`, `Transaction_In_Sale_ID`) VALUES (null,'" + payment_combo.Text + "','" + bankid_combo.Value.ToString() + "','" + paid_amount_txt.Text + "','" + dd + "','" + orderiddd + "')";
                                        MySqlCommand addTransectioncmd = new MySqlCommand(addTransection, BookShopManagement.Conn.ConnectionString);
                                        int addTransectionres = addTransectioncmd.ExecuteNonQuery();
                                        if (addTransectionres > 0)
                                        {

                                            string getaccountmoney = "select Bank_Acc_Balance from bank_details_pos where Bank_Details_ID='" + bankid_combo.Value.ToString() + "'";
                                            MySqlCommand am = new MySqlCommand(getaccountmoney, Conn.ConnectionString);
                                            int getmoney = Convert.ToInt32(am.ExecuteScalar().ToString());

                                            int summoney = getmoney + Convert.ToInt32(paid_amount_txt.Text);

                                            string updatemoney = "update bank_details_pos set Bank_Acc_Balance='" + summoney.ToString() + "' where Bank_Details_ID='" + bankid_combo.Value.ToString() + "'";
                                            MySqlCommand upm = new MySqlCommand(updatemoney, Conn.ConnectionString);

                                            int upppres = upm.ExecuteNonQuery();
                                            if (upppres > 0)
                                            {

                                                string refreshquantity = "select Product_Quantity from products_pos where Product_ID='" + item.SubItems[0].Text + "'";
                                                MySqlCommand refreshquantitycmd = new MySqlCommand(refreshquantity, BookShopManagement.Conn.ConnectionString);
                                                int refreshquantityres = Convert.ToInt32(refreshquantitycmd.ExecuteScalar().ToString());

                                                int sub = refreshquantityres - Convert.ToInt32(item.SubItems[2].Text);

                                                string updateq = "update products_pos set Product_Quantity='" + sub.ToString() + "' where Product_ID='" + item.SubItems[0].Text + "'";
                                                MySqlCommand upcmd = new MySqlCommand(updateq, BookShopManagement.Conn.ConnectionString);
                                                int upres = upcmd.ExecuteNonQuery();
                                                if (upres > 0)
                                                {
                                                    result++;

                                                }



                                            }



                                        }


                                    }
                                }
                                if (result == 1)
                                {
                                    alert aa = new alert("Sold!", "Sale Successfull.", "success");
                                    aa.ShowDialog();


                                    confirmationForm cd = new confirmationForm("Sale Report", "Do You Want To Generate Sale Report?");
                                    cd.ShowDialog();
                                    if (cd.r == "yes")
                                    {

                                        loading l = new loading();
                                        l.ShowDialog();

                                        String getorderidd = "select Order_ID from sale_order where Order_Customer_ID='" + cutomerid + "' order by Order_ID DESC LIMIT 0,1";
                                        MySqlCommand getorderidcmd = new MySqlCommand(getorderidd, BookShopManagement.Conn.ConnectionString);
                                        string oid = getorderidcmd.ExecuteScalar().ToString();

                                        //String getcusid = "select Order_Customer_ID from sale_order where Order_ID='" + oid + "'";
                                        //MySqlCommand getcusidcmd = new MySqlCommand(getcusid, BookShopManagement.Conn.ConnectionString);


                                        //string cid = getcusidcmd.ExecuteScalar().ToString();

                                        string checkdc = "select count(*) from discount_card_pos where DC_Customer_ID='" + cutomerid + "'";
                                        MySqlCommand checkdccmd = new MySqlCommand(checkdc, BookShopManagement.Conn.ConnectionString);
                                        string res = checkdccmd.ExecuteScalar().ToString();
                                        orderID = oid;
                                        if (res == "0")
                                        {
                                            card = "false";
                                            using (SaleReport bf = new SaleReport(orderID, card))
                                            {
                                                bf.ShowDialog();

                                                orderID = "";

                                            }
                                        }
                                        else
                                        {
                                            card = "true";
                                            using (SaleReport bf = new SaleReport(orderID, card))
                                            {
                                                bf.ShowDialog();

                                                orderID = "";
                                            }
                                        }
                                        this.close_button.PerformClick();
                                    }
                                    else
                                    {
                                        this.close_button.PerformClick();
                                    }
                                }
                                else
                                {
                                    alert aa = new alert("Error!", "Sale Failed.", "error");
                                    aa.ShowDialog();
                                }

                            }
                            else
                            {
                                alert aa = new alert("Error!", "Sale Failed.", "error");
                                aa.ShowDialog();
                            }
                            BookShopManagement.Conn.ConnectionString.Close();
                            //MessageBox.Show("ID : " + item.SubItems[0].Text + ", Quantity:" + item.SubItems[2].Text + ", PRICE AFTER DISCOUNT:" + item.SubItems[3].Text + ", REAL PRICE:" + item.SubItems[4].Text);
                        }

                    }
                    else
                    {
                        alert aa = new alert("Warning", "You Have Exceeded The Product Quantity Limit.", "info");
                        aa.ShowDialog();
                    }
                }
            }
            BookShopManagement.Conn.ConnectionString.Close();
        }









        


        private void save_btn_Click(object sender, EventArgs e)
        {
            if (CheckForInternetConnection().ToString() == "True")
            {
            BookShopManagement.Conn.ConnectionString.Close();
            BookShopManagement.Conn.ConnectionString.Open();

            if (loan == "true")
            {

                Random r = new Random();
                int serialno = Convert.ToInt32(r.Next(1000000000));
                foreach (ListViewItem itemmm in _listView.Items)
                {
                    string checkquantity = "select Product_Quantity from products_pos where Product_ID='" + itemmm.SubItems[0].Text + "'";
                    MySqlCommand checkquantitycmd = new MySqlCommand(checkquantity, BookShopManagement.Conn.ConnectionString);
                    Conn.ConnectionString.Close();
                    Conn.ConnectionString.Open();
                    int getquantity = Convert.ToInt32(checkquantitycmd.ExecuteScalar().ToString());

                    if (Convert.ToInt32(itemmm.SubItems[2].Text) <= getquantity)
                    {

                        var info = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
                        DateTimeOffset localServerTime = DateTimeOffset.Now;


                        String insertOrder = "INSERT INTO `sale_order`(`Order_ID`, `Serial_Number`, `Order_Date`, `Order_Customer_ID`, `Order_DoneBy`, `Order_Type`, `Order_Discount_Card_ID` ,`Order_Total_Price`, `Order_Paid_Amount_By_Point`) VALUES (null,@srno,@orderdate,@ordercustomer,@orderdoneby,'Loan',@discountcardid,@netamount,0)";
                        MySqlCommand cmdorder = new MySqlCommand(insertOrder, BookShopManagement.Conn.ConnectionString);
                        cmdorder.Parameters.AddWithValue("@srno", serialno.ToString());
                        cmdorder.Parameters.AddWithValue("@orderdate", TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy"));
                        cmdorder.Parameters.AddWithValue("@ordercustomer", cutomerid);
                        cmdorder.Parameters.AddWithValue("@orderdoneby", Retrieval.User_ID.ToString());
                        if (DicscountCardID == "")
                        {
                            cmdorder.Parameters.AddWithValue("@discountcardid", null);
                        }
                        else
                        {
                            cmdorder.Parameters.AddWithValue("@discountcardid", DicscountCardID);
                        }
                        cmdorder.Parameters.AddWithValue("@netamount", TotalAmount);

                        int orderres = cmdorder.ExecuteNonQuery();

                        if (orderres > 0)
                        {

                            string getLastOrder = "select Order_ID from sale_order order by Order_ID DESC LIMIT 0,1";
                            MySqlCommand getorderid = new MySqlCommand(getLastOrder, BookShopManagement.Conn.ConnectionString);

                            String orderiddd = getorderid.ExecuteScalar().ToString();
                            //String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,@productid,@productprice,@productdiscountedprice,@productquantity,@productorderid)";
                            //MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
                            foreach (ListViewItem item in _listView.Items)
                            {
                                String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`,`Sale_Product_Discounted_Amount`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,'" + item.SubItems[0].Text + "','" + item.SubItems[4].Text + "','" + item.SubItems[5].Text + "','" + item.SubItems[3].Text + "','" + item.SubItems[2].Text + "','" + orderiddd + "')";
                                MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
                                //cmdproduct.Parameters.AddWithValue("@productid", item.SubItems[0].Text);
                                //cmdproduct.Parameters.AddWithValue("@productprice", item.SubItems[4].Text);
                                //cmdproduct.Parameters.AddWithValue("@ordeproductdiscountedpricertype", item.SubItems[3].Text);
                                //cmdproduct.Parameters.AddWithValue("@productquantity", item.SubItems[2].Text);
                                //cmdproduct.Parameters.AddWithValue("@productorderid", orderiddd);
                                //MessageBox.Show(insertProducts);
                                int prores = cmdproduct.ExecuteNonQuery();
                                if (prores > 0)
                                {
                                    string refreshquantity = "select Product_Quantity from products_pos where Product_ID='" + item.SubItems[0].Text + "'";
                                    MySqlCommand refreshquantitycmd = new MySqlCommand(refreshquantity, BookShopManagement.Conn.ConnectionString);
                                    int refreshquantityres = Convert.ToInt32(refreshquantitycmd.ExecuteScalar().ToString());

                                    int sub = refreshquantityres - Convert.ToInt32(item.SubItems[2].Text);

                                    string updateq = "update products_pos set Product_Quantity='" + sub.ToString() + "' where Product_ID='" + item.SubItems[0].Text + "'";
                                    MySqlCommand upcmd = new MySqlCommand(updateq, BookShopManagement.Conn.ConnectionString);
                                    int upres = upcmd.ExecuteNonQuery();
                                    if (upres > 0)
                                    {

                                        string insertinloan = "INSERT INTO `credit_sale`(`Credit_Sale_ID`, `Credit_Order_ID`, `Credit_Customer_ID`, `Credit_Date`,`Paying_Date`, `Credit_Amount`) VALUES (null,'" + orderiddd + "','" + cutomerid + "','" + TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy") + "','" + payingdate_txt.Text + "','" + total_amount_txt.Text + "')";
                                        MySqlCommand loann = new MySqlCommand(insertinloan, Conn.ConnectionString);
                                        int ll = loann.ExecuteNonQuery();
                                        if (ll > 0)
                                        {
                                            result++;
                                        }


                                    }

                                }
                            }
                            if (result == 1)
                            {
                                alert aa = new alert("Loan!", "Loan Data Inserted Successfull.", "success");
                                aa.ShowDialog();

                                alert aaa = new alert("Sold!", "Sale Successfull.", "success");
                                aaa.ShowDialog();

                                this.close_button.PerformClick();


                            }
                            else
                            {
                                alert aa = new alert("Error!", "Sale Failed.", "error");
                                aa.ShowDialog();
                            }

                        }
                        else
                        {
                            alert aa = new alert("Error!", "Sale Failed.", "error");
                            aa.ShowDialog();
                        }
                        BookShopManagement.Conn.ConnectionString.Close();

                    }
                }

            }
            else
            {

                Random r = new Random();
                int serialno = Convert.ToInt32(r.Next(1000000000));

                var info = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
                DateTimeOffset localServerTime = DateTimeOffset.Now;

                DateTime startDate = DateTime.Parse(TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy"));
                DateTime expiryDate = startDate.AddDays(3);


                String getDate = TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy");


                String checkdiscoundcard = "select count(*) from `discount_card_pos` where DC_Card_Number='" + DicscountCardID + "' and DC_Customer_ID='" + cutomerid + "'";
                MySqlCommand checkdiscountres = new MySqlCommand(checkdiscoundcard, BookShopManagement.Conn.ConnectionString);
                String count = checkdiscountres.ExecuteScalar().ToString();
                if (count == "0")
                {

                    if (Convert.ToInt32(TotalAmount) > 50000)
                    {
                        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                        var stringChars = new char[25];
                        var random = new Random();

                        for (int i = 0; i < stringChars.Length; i++)
                        {
                            stringChars[i] = chars[random.Next(chars.Length)];
                        }

                        var finalString = new String(stringChars);

                        String createDiscoundCard = "INSERT INTO `discount_card_pos`(`DC_Card_Number`, `Serial_Number`, `DC_Customer_ID`, `DC_Current_Points`, `DC_Start_Date`) VALUES ('" + finalString.ToString() + "','" + serialno.ToString() + "','" + cutomerid + "',0,'" + getDate + "')";
                        MySqlCommand createDiscoundCardcmd = new MySqlCommand(createDiscoundCard, BookShopManagement.Conn.ConnectionString);
                        int createDiscoundCardres = createDiscoundCardcmd.ExecuteNonQuery();
                        if (createDiscoundCardres > 0)
                        {
                            alert aa = new alert("Congratulations!", "Discount Card Has Been Created.", "success");
                            aa.ShowDialog();




                        }


                        addCshBank();
                    }
                    else
                    {
                        addCshBank();
                    }




                }
                else
                {

                    int forDiscountCardTotalPrice = Convert.ToInt32(total_amount_txt.Text);
                    int discountCardPointsIn = forDiscountCardTotalPrice / 100;

                    string DiscountCardIn = "INSERT INTO `discount_point_in_pos`(`Discount_In_ID`, `Discount_In_Card_ID`, `Discount_In_Points`, `Discount_In_Start_Date`, `Discount_In_Activation_Date`, `Discound_In_Status`) VALUES (null,'" + DicscountCardID + "','" + discountCardPointsIn + "','" + getDate + "','" + expiryDate.ToString("dd-MMMM-yyyy") + "','Inactive')";
                    MySqlCommand DiscountCardIncmd = new MySqlCommand(DiscountCardIn, BookShopManagement.Conn.ConnectionString);
                    int DiscountCardInres = DiscountCardIncmd.ExecuteNonQuery();
                    if (DiscountCardInres > 0)
                    {
                        string getActivatedpoints = "select COALESCE(SUM(Discount_In_Points),0) as sum from discount_point_in_pos where Discount_In_Card_ID='" + DicscountCardID + "' and Discound_In_Status='Activated'";
                        MySqlCommand getActivatedpointscmd = new MySqlCommand(getActivatedpoints, BookShopManagement.Conn.ConnectionString);
                        int getActivatedpointsres = Convert.ToInt32(getActivatedpointscmd.ExecuteScalar());


                        string getRedeempoints = "select COALESCE(SUM(Discount_Out_Redeem_Points),0) as sum from discount_point_out_pos where Disccount_Out_Card_ID='" + DicscountCardID + "'";
                        MySqlCommand getRedeempointscmd = new MySqlCommand(getRedeempoints, BookShopManagement.Conn.ConnectionString);
                        int getRedeempointsres = Convert.ToInt32(getRedeempointscmd.ExecuteScalar());


                        //string getCurrentpoints = "select DC_Current_Points from discount_card_pos where DC_Card_Number='" + DicscountCardID + "' and DC_Customer_ID='" + cutomerid + "'";
                        //MySqlCommand getCurrentpointscmd = new MySqlCommand(getCurrentpoints, BookShopManagement.Conn.ConnectionString);
                        //int getCurrentpointssres = Convert.ToInt32(getCurrentpointscmd.ExecuteScalar());


                        int updatedcurrentpoints = getActivatedpointsres - getRedeempointsres;

                        string updatecurrentpoints = "UPDATE `discount_card_pos` SET `DC_Current_Points`='" + updatedcurrentpoints.ToString() + "' WHERE DC_Card_Number='" + DicscountCardID + "' and DC_Customer_ID='" + cutomerid + "'";
                        MySqlCommand updatecurrentpointscmd = new MySqlCommand(updatecurrentpoints, BookShopManagement.Conn.ConnectionString);
                        int updatecurrentpointsres = updatecurrentpointscmd.ExecuteNonQuery();
                        if (updatecurrentpointsres > 0)
                        {
                            alert aa = new alert("Points!", discountCardPointsIn.ToString() + " Point Inserted Successfully.", "success");
                            aa.ShowDialog();
                        }
                        else
                        {
                            alert aa = new alert("Error!", "Update Point Failed.", "error");
                            aa.ShowDialog();
                        }
                    }
                    else
                    {
                        alert aa = new alert("Error!", "Point Failed.", "error");
                        aa.ShowDialog();
                    }



                    addCshBank();

                    if (checkBox1.Checked == true)
                    {

                        string discountcardout = "INSERT INTO `discount_point_out_pos`(`Discount_Out_ID`, `Disccount_Out_Card_ID`, `Discount_Out_Redeem_Points`, `Discount_Out_Redeem_Date`) VALUES (null,'" + DicscountCardID + "','" + availablePoints.Text + "','" + getDate + "')";
                        MySqlCommand discountcardoutcmd = new MySqlCommand(discountcardout, BookShopManagement.Conn.ConnectionString);
                        BookShopManagement.Conn.ConnectionString.Open();
                        int discountcardoutres = discountcardoutcmd.ExecuteNonQuery();
                        if (discountcardoutres > 0)
                        {
                            alert aa = new alert("Point Redeem!", availablePoints.Text + " Point Redeem From Customer's Account.", "success");
                            aa.ShowDialog();

                        }
                        else
                        {
                            alert aa = new alert("Failed!", "Failed To Point Redeem From Customer's Account.", "error");
                            aa.ShowDialog();
                        }
                        BookShopManagement.Conn.ConnectionString.Close();


                        MySqlDataReader sdr1;
                        string getActivatedInactivepoints = "select Discount_In_Card_ID,COALESCE(SUM(Discount_In_Points),0) as sum from discount_point_in_pos where Discound_In_Status='Activated' and Discount_In_Card_ID='" + DicscountCardID + "'";
                        MySqlCommand getActivatedInactivepointscmd = new MySqlCommand(getActivatedInactivepoints, BookShopManagement.Conn.ConnectionString);
                        BookShopManagement.Conn.ConnectionString.Open();
                        sdr1 = getActivatedInactivepointscmd.ExecuteReader();

                        while (sdr1.Read())
                        {

                            sumofpoints1 = sdr1["sum"].ToString();
                        }

                        BookShopManagement.Conn.ConnectionString.Close();


                        string getRedeempoints = "select COALESCE(SUM(Discount_Out_Redeem_Points),0) as sum from discount_point_out_pos where Disccount_Out_Card_ID='" + DicscountCardID + "'";
                        MySqlCommand getRedeempointscmd = new MySqlCommand(getRedeempoints, BookShopManagement.Conn.ConnectionString);
                        BookShopManagement.Conn.ConnectionString.Open();
                        int getRedeempointsres = Convert.ToInt32(getRedeempointscmd.ExecuteScalar());


                        if (getRedeempointsres != 0)
                        {
                            int updateredeemtocurrent = Convert.ToInt32(sumofpoints1) - getRedeempointsres;

                            string updatecurrentpointsafterredeem = "update discount_card_pos set DC_Current_Points='" + updateredeemtocurrent.ToString() + "' where DC_Card_Number='" + DicscountCardID + "'";
                            MySqlCommand updatecurrentpointsafterredeemcmd = new MySqlCommand(updatecurrentpointsafterredeem, BookShopManagement.Conn.ConnectionString);
                            int updatecurrentpointsafterredeemres = updatecurrentpointsafterredeemcmd.ExecuteNonQuery();
                            if (updatecurrentpointsafterredeemres > 0)
                            {


                            }
                        }
                        BookShopManagement.Conn.ConnectionString.Close();

                    }


                }
            }

            }
            else
            {

            }
                    
            
            //if (DicscountCardID == "")
            //{


            //    if (payment_combo.Text == "Cash")
            //    {




            //        String insertOrder = "INSERT INTO `sale_order`(`Order_ID`, `Order_Date`, `Order_Customer_ID`, `Order_DoneBy`, `Order_Type`, `Order_Bank_Account_ID`, `Order_Total_Price`, `Order_Paid_Amount`, `Order_Discount_Card_ID`, `Order_Paid_Amount_By_Point`) VALUES (null,@orderdate,@ordercustomer,@orderdoneby,@ordertype,null,@ordertotalprice,@orderpaidamount,null,@orderpaidamountcard)";
            //        MySqlCommand cmdorder = new MySqlCommand(insertOrder, BookShopManagement.Conn.ConnectionString);
            //        cmdorder.Parameters.AddWithValue("@orderdate", TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy hh:mm:ss tt"));
            //        cmdorder.Parameters.AddWithValue("@ordercustomer", cutomerid);
            //        cmdorder.Parameters.AddWithValue("@orderdoneby", Retrieval.User_ID.ToString());
            //        cmdorder.Parameters.AddWithValue("@ordertype", payment_combo.Text);
            //        cmdorder.Parameters.AddWithValue("@ordertotalprice", TotalAmount);
            //        cmdorder.Parameters.AddWithValue("@orderpaidamount", paid_amount_txt.Text);
  
            //        cmdorder.Parameters.AddWithValue("@orderpaidamountcard", availablePoints.Text);

            //        int orderres = cmdorder.ExecuteNonQuery();

            //        if (orderres > 0)
            //        {

            //            string getLastOrder = "select Order_ID from sale_order order by Order_ID DESC LIMIT 0,1";
            //            MySqlCommand getorderid = new MySqlCommand(getLastOrder, BookShopManagement.Conn.ConnectionString);

            //            String orderiddd = getorderid.ExecuteScalar().ToString();
            //            //String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,@productid,@productprice,@productdiscountedprice,@productquantity,@productorderid)";
            //            //MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
            //            foreach (ListViewItem item in _listView.Items)
            //            {
            //                String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,'" + item.SubItems[0].Text + "','" + item.SubItems[4].Text + "','" + item.SubItems[3].Text + "','" + item.SubItems[2].Text + "','" + orderiddd + "')";
            //                MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
            //                //cmdproduct.Parameters.AddWithValue("@productid", item.SubItems[0].Text);
            //                //cmdproduct.Parameters.AddWithValue("@productprice", item.SubItems[4].Text);
            //                //cmdproduct.Parameters.AddWithValue("@ordeproductdiscountedpricertype", item.SubItems[3].Text);
            //                //cmdproduct.Parameters.AddWithValue("@productquantity", item.SubItems[2].Text);
            //                //cmdproduct.Parameters.AddWithValue("@productorderid", orderiddd);
            //                //MessageBox.Show(insertProducts);
            //                int prores = cmdproduct.ExecuteNonQuery();
            //                if (prores > 0)
            //                {
            //                    result = 1;
            //                }
            //            }
            //            if (result == 1)
            //            {
            //                alert aa = new alert("Inserted!", "Sale Successfull.", "success");
            //                aa.ShowDialog();

            //            }
            //            else
            //            {
            //                alert aa = new alert("Error!", "Sale Failed.", "error");
            //                aa.ShowDialog();
            //            }

            //        }
            //        else
            //        {
            //            alert aa = new alert("Error!", "Sale Failed.", "error");
            //            aa.ShowDialog();
            //        }
            //        BookShopManagement.Conn.ConnectionString.Close();


            //    }
            //    else
            //    {
            //        var bankid_combo = listBox1.SelectedItem as ComboboxItem;



            //        String insertOrder = "INSERT INTO `sale_order`(`Order_ID`, `Order_Date`, `Order_Customer_ID`, `Order_DoneBy`, `Order_Type`, `Order_Bank_Account_ID`, `Order_Total_Price`, `Order_Paid_Amount`, `Order_Discount_Card_ID`, `Order_Paid_Amount_By_Point`) VALUES (null,@orderdate,@ordercustomer,@orderdoneby,@ordertype,@orderbank,@ordertotalprice,@orderpaidamount,null,@orderpaidamountcard)";
            //        MySqlCommand cmdorder = new MySqlCommand(insertOrder, BookShopManagement.Conn.ConnectionString);
            //        cmdorder.Parameters.AddWithValue("@orderdate", TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy hh:mm:ss tt"));
            //        cmdorder.Parameters.AddWithValue("@ordercustomer", cutomerid);
            //        cmdorder.Parameters.AddWithValue("@orderdoneby", Retrieval.User_ID.ToString());
            //        cmdorder.Parameters.AddWithValue("@ordertype", payment_combo.Text);
            //        cmdorder.Parameters.AddWithValue("@orderbank", bankid_combo.Value.ToString());
            //        cmdorder.Parameters.AddWithValue("@ordertotalprice", TotalAmount);
            //        cmdorder.Parameters.AddWithValue("@orderpaidamount", paid_amount_txt.Text);

            //        cmdorder.Parameters.AddWithValue("@orderpaidamountcard", availablePoints.Text);
            //        BookShopManagement.Conn.ConnectionString.Open();
            //        int orderres = cmdorder.ExecuteNonQuery();

            //        if (orderres > 0)
            //        {

            //            string getLastOrder = "select Order_ID from sale_order order by Order_ID DESC LIMIT 0,1";
            //            MySqlCommand getorderid = new MySqlCommand(getLastOrder, BookShopManagement.Conn.ConnectionString);

            //            String orderiddd = getorderid.ExecuteScalar().ToString();
            //            //String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,@productid,@productprice,@productdiscountedprice,@productquantity,@productorderid)";
            //            //MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
            //            foreach (ListViewItem item in _listView.Items)
            //            {
            //                String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,'" + item.SubItems[0].Text + "','" + item.SubItems[4].Text + "','" + item.SubItems[3].Text + "','" + item.SubItems[2].Text + "','" + orderiddd + "')";
            //                MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
            //                //cmdproduct.Parameters.AddWithValue("@productid", item.SubItems[0].Text);
            //                //cmdproduct.Parameters.AddWithValue("@productprice", item.SubItems[4].Text);
            //                //cmdproduct.Parameters.AddWithValue("@ordeproductdiscountedpricertype", item.SubItems[3].Text);
            //                //cmdproduct.Parameters.AddWithValue("@productquantity", item.SubItems[2].Text);
            //                //cmdproduct.Parameters.AddWithValue("@productorderid", orderiddd);
            //                //MessageBox.Show(insertProducts);
            //                int prores = cmdproduct.ExecuteNonQuery();
            //                if (prores > 0)
            //                {
            //                    result = 1;
            //                }
            //            }
            //            if (result == 1)
            //            {
            //                alert aa = new alert("Inserted!", "Sale Successfull.", "success");
            //                aa.ShowDialog();
            //            }
            //            else
            //            {
            //                alert aa = new alert("Error!", "Sale Failed.", "error");
            //                aa.ShowDialog();
            //            }

            //        }
            //        else
            //        {
            //            alert aa = new alert("Error!", "Sale Failed.", "error");
            //            aa.ShowDialog();
            //        }

            //        //MessageBox.Show("ID : " + item.SubItems[0].Text + ", Quantity:" + item.SubItems[2].Text + ", PRICE AFTER DISCOUNT:" + item.SubItems[3].Text + ", REAL PRICE:" + item.SubItems[4].Text);
            //    }







            //    //CODDDDDDDDDDDDDDDDDDDDDDDEEEEEEEEEEEEEEEEEEEEEEe

                
            //}
            //else
            //{


            //    String checkdiscoundcard = "select count(*) from `discount_card_pos` where DC_Card_Number='" + DicscountCardID + "' and DC_Customer_ID='" + cutomerid + "'";
            //    MySqlCommand checkdiscountres = new MySqlCommand(checkdiscoundcard, BookShopManagement.Conn.ConnectionString);
            //    String count = checkdiscountres.ExecuteScalar().ToString();
            //    if (count == "0")
            //    {

            //        if (Convert.ToInt32(TotalAmount) > 50000)
            //        {
            //            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            //            var stringChars = new char[25];
            //            var random = new Random();

            //            for (int i = 0; i < stringChars.Length; i++)
            //            {
            //                stringChars[i] = chars[random.Next(chars.Length)];
            //            }

            //            var finalString = new String(stringChars);

            //            String createDiscoundCard = "INSERT INTO `discount_card_pos`(`DC_Card_Number`, `DC_Customer_ID`, `DC_Current_Points`, `DC_Start_Date`) VALUES ('" + finalString.ToString() + "','" + cutomerid + "',0,'" + getDate + "')";
            //            MySqlCommand createDiscoundCardcmd = new MySqlCommand(createDiscoundCard, BookShopManagement.Conn.ConnectionString);
            //            int createDiscoundCardres = createDiscoundCardcmd.ExecuteNonQuery();
            //            if (createDiscoundCardres > 0)
            //            {
            //                alert aa = new alert("Congratulations!", "Discount Card Has Been Created.", "success");
            //                aa.ShowDialog();
            //            }

            //        }





            //        if (payment_combo.Text == "Cash")
            //        {




            //            String insertOrder = "INSERT INTO `sale_order`(`Order_ID`, `Order_Date`, `Order_Customer_ID`, `Order_DoneBy`, `Order_Type`, `Order_Bank_Account_ID`, `Order_Total_Price`, `Order_Paid_Amount`, `Order_Discount_Card_ID`, `Order_Paid_Amount_By_Point`) VALUES (null,@orderdate,@ordercustomer,@orderdoneby,@ordertype,null,@ordertotalprice,@orderpaidamount,@orderdcid,@orderpaidamountcard)";
            //            MySqlCommand cmdorder = new MySqlCommand(insertOrder, BookShopManagement.Conn.ConnectionString);
            //            cmdorder.Parameters.AddWithValue("@orderdate", TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy hh:mm:ss tt"));
            //            cmdorder.Parameters.AddWithValue("@ordercustomer", cutomerid);
            //            cmdorder.Parameters.AddWithValue("@orderdoneby", Retrieval.User_ID.ToString());
            //            cmdorder.Parameters.AddWithValue("@ordertype", payment_combo.Text);
            //            cmdorder.Parameters.AddWithValue("@ordertotalprice", TotalAmount);
            //            cmdorder.Parameters.AddWithValue("@orderpaidamount", paid_amount_txt.Text);
            //            cmdorder.Parameters.AddWithValue("@orderdcid", DicscountCardID);
            //            cmdorder.Parameters.AddWithValue("@orderpaidamountcard", availablePoints.Text);

            //            int orderres = cmdorder.ExecuteNonQuery();

            //            if (orderres > 0)
            //            {

            //                string getLastOrder = "select Order_ID from sale_order order by Order_ID DESC LIMIT 0,1";
            //                MySqlCommand getorderid = new MySqlCommand(getLastOrder, BookShopManagement.Conn.ConnectionString);

            //                String orderiddd = getorderid.ExecuteScalar().ToString();
            //                //String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,@productid,@productprice,@productdiscountedprice,@productquantity,@productorderid)";
            //                //MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
            //                foreach (ListViewItem item in _listView.Items)
            //                {
            //                    String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,'" + item.SubItems[0].Text + "','" + item.SubItems[4].Text + "','" + item.SubItems[3].Text + "','" + item.SubItems[2].Text + "','" + orderiddd + "')";
            //                    MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
            //                    //cmdproduct.Parameters.AddWithValue("@productid", item.SubItems[0].Text);
            //                    //cmdproduct.Parameters.AddWithValue("@productprice", item.SubItems[4].Text);
            //                    //cmdproduct.Parameters.AddWithValue("@ordeproductdiscountedpricertype", item.SubItems[3].Text);
            //                    //cmdproduct.Parameters.AddWithValue("@productquantity", item.SubItems[2].Text);
            //                    //cmdproduct.Parameters.AddWithValue("@productorderid", orderiddd);
            //                    //MessageBox.Show(insertProducts);
            //                    int prores = cmdproduct.ExecuteNonQuery();
            //                    if (prores > 0)
            //                    {
            //                        result = 1;
            //                    }
            //                }
            //                if (result == 1)
            //                {
            //                    alert aa = new alert("Inserted!", "Sale Successfull.", "success");
            //                    aa.ShowDialog();
            //                }
            //                else
            //                {
            //                    alert aa = new alert("Error!", "Sale Failed.", "error");
            //                    aa.ShowDialog();
            //                }

            //            }
            //            else
            //            {
            //                alert aa = new alert("Error!", "Sale Failed.", "error");
            //                aa.ShowDialog();
            //            }
            //            BookShopManagement.Conn.ConnectionString.Close();


            //        }
            //        else
            //        {
            //            var bankid_combo = listBox1.SelectedItem as ComboboxItem;



            //            String insertOrder = "INSERT INTO `sale_order`(`Order_ID`, `Order_Date`, `Order_Customer_ID`, `Order_DoneBy`, `Order_Type`, `Order_Bank_Account_ID`, `Order_Total_Price`, `Order_Paid_Amount`, `Order_Discount_Card_ID`, `Order_Paid_Amount_By_Point`) VALUES (null,@orderdate,@ordercustomer,@orderdoneby,@ordertype,@orderbank,@ordertotalprice,@orderpaidamount,@orderdcid,@orderpaidamountcard)";
            //            MySqlCommand cmdorder = new MySqlCommand(insertOrder, BookShopManagement.Conn.ConnectionString);
            //            cmdorder.Parameters.AddWithValue("@orderdate", TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy hh:mm:ss tt"));
            //            cmdorder.Parameters.AddWithValue("@ordercustomer", cutomerid);
            //            cmdorder.Parameters.AddWithValue("@orderdoneby", Retrieval.User_ID.ToString());
            //            cmdorder.Parameters.AddWithValue("@ordertype", payment_combo.Text);
            //            cmdorder.Parameters.AddWithValue("@orderbank", bankid_combo.Value.ToString());
            //            cmdorder.Parameters.AddWithValue("@ordertotalprice", TotalAmount);
            //            cmdorder.Parameters.AddWithValue("@orderpaidamount", paid_amount_txt.Text);
            //            cmdorder.Parameters.AddWithValue("@orderdcid", DicscountCardID);
            //            cmdorder.Parameters.AddWithValue("@orderpaidamountcard", availablePoints.Text);
            //            BookShopManagement.Conn.ConnectionString.Open();
            //            int orderres = cmdorder.ExecuteNonQuery();

            //            if (orderres > 0)
            //            {

            //                string getLastOrder = "select Order_ID from sale_order order by Order_ID DESC LIMIT 0,1";
            //                MySqlCommand getorderid = new MySqlCommand(getLastOrder, BookShopManagement.Conn.ConnectionString);

            //                String orderiddd = getorderid.ExecuteScalar().ToString();
            //                //String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,@productid,@productprice,@productdiscountedprice,@productquantity,@productorderid)";
            //                //MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
            //                foreach (ListViewItem item in _listView.Items)
            //                {
            //                    String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,'" + item.SubItems[0].Text + "','" + item.SubItems[4].Text + "','" + item.SubItems[3].Text + "','" + item.SubItems[2].Text + "','" + orderiddd + "')";
            //                    MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
            //                    //cmdproduct.Parameters.AddWithValue("@productid", item.SubItems[0].Text);
            //                    //cmdproduct.Parameters.AddWithValue("@productprice", item.SubItems[4].Text);
            //                    //cmdproduct.Parameters.AddWithValue("@ordeproductdiscountedpricertype", item.SubItems[3].Text);
            //                    //cmdproduct.Parameters.AddWithValue("@productquantity", item.SubItems[2].Text);
            //                    //cmdproduct.Parameters.AddWithValue("@productorderid", orderiddd);
            //                    //MessageBox.Show(insertProducts);
            //                    int prores = cmdproduct.ExecuteNonQuery();
            //                    if (prores > 0)
            //                    {
            //                        result = 1;
            //                    }
            //                }
            //                if (result == 1)
            //                {
            //                    alert aa = new alert("Inserted!", "Sale Successfull.", "success");
            //                    aa.ShowDialog();
            //                }
            //                else
            //                {
            //                    alert aa = new alert("Error!", "Sale Failed.", "error");
            //                    aa.ShowDialog();
            //                }

            //            }
            //            else
            //            {
            //                alert aa = new alert("Error!", "Sale Failed.", "error");
            //                aa.ShowDialog();
            //            }

            //            //MessageBox.Show("ID : " + item.SubItems[0].Text + ", Quantity:" + item.SubItems[2].Text + ", PRICE AFTER DISCOUNT:" + item.SubItems[3].Text + ", REAL PRICE:" + item.SubItems[4].Text);
            //        }

            //    }
            //    else
            //    {
            //        int forDiscountCardTotalPrice = Convert.ToInt32(total_amount_txt.Text);
            //        int discountCardPointsIn = forDiscountCardTotalPrice / 100;

            //        string DiscountCardIn = "INSERT INTO `discount_point_in_pos`(`Discount_In_ID`, `Discount_In_Card_ID`, `Discount_In_Points`, `Discount_In_Start_Date`, `Discount_In_Activation_Date`, `Discound_In_Status`) VALUES (null,'" + DicscountCardID + "','" + discountCardPointsIn + "','" + getDate + "','" + expiryDate.ToString("dd-MMMM-yyyy") + "','Inactive')";
            //        MySqlCommand DiscountCardIncmd = new MySqlCommand(DiscountCardIn, BookShopManagement.Conn.ConnectionString);
            //        int DiscountCardInres = DiscountCardIncmd.ExecuteNonQuery();
            //        if (DiscountCardInres > 0)
            //        {
            //            string getActivatedpoints = "select COALESCE(SUM(Discount_In_Points),0) as sum from discount_point_in_pos where Discount_In_Card_ID='" + DicscountCardID + "' and Discound_In_Status='Activated'";
            //            MySqlCommand getActivatedpointscmd = new MySqlCommand(getActivatedpoints, BookShopManagement.Conn.ConnectionString);
            //            int getActivatedpointsres = Convert.ToInt32(getActivatedpointscmd.ExecuteScalar());


            //            string getRedeempoints = "select COALESCE(SUM(Discount_Out_Redeem_Points),0) as sum from discount_point_out_pos where Disccount_Out_Card_ID='" + DicscountCardID + "'";
            //            MySqlCommand getRedeempointscmd = new MySqlCommand(getRedeempoints, BookShopManagement.Conn.ConnectionString);
            //            int getRedeempointsres = Convert.ToInt32(getRedeempointscmd.ExecuteScalar());


            //            //string getCurrentpoints = "select DC_Current_Points from discount_card_pos where DC_Card_Number='" + DicscountCardID + "' and DC_Customer_ID='" + cutomerid + "'";
            //            //MySqlCommand getCurrentpointscmd = new MySqlCommand(getCurrentpoints, BookShopManagement.Conn.ConnectionString);
            //            //int getCurrentpointssres = Convert.ToInt32(getCurrentpointscmd.ExecuteScalar());


            //            int updatedcurrentpoints = getActivatedpointsres - getRedeempointsres;

            //            string updatecurrentpoints = "UPDATE `discount_card_pos` SET `DC_Current_Points`='" + updatedcurrentpoints.ToString() + "' WHERE DC_Card_Number='" + DicscountCardID + "' and DC_Customer_ID='" + cutomerid + "'";
            //            MySqlCommand updatecurrentpointscmd = new MySqlCommand(updatecurrentpoints, BookShopManagement.Conn.ConnectionString);
            //            int updatecurrentpointsres = updatecurrentpointscmd.ExecuteNonQuery();
            //            if (updatecurrentpointsres > 0)
            //            {
            //                alert aa = new alert("Points!", discountCardPointsIn.ToString() + " Point Inserted Successfully.", "success");
            //                aa.ShowDialog();
            //            }
            //            else
            //            {
            //                alert aa = new alert("Error!", "Update Point Failed.", "error");
            //                aa.ShowDialog();
            //            }
            //        }
            //        else
            //        {
            //            alert aa = new alert("Error!", "Point Failed.", "error");
            //            aa.ShowDialog();
            //        }


            //        if (payment_combo.Text == "Cash")
            //        {




            //            String insertOrder = "INSERT INTO `sale_order`(`Order_ID`, `Order_Date`, `Order_Customer_ID`, `Order_DoneBy`, `Order_Type`, `Order_Bank_Account_ID`, `Order_Total_Price`, `Order_Paid_Amount`, `Order_Discount_Card_ID`, `Order_Paid_Amount_By_Point`) VALUES (null,@orderdate,@ordercustomer,@orderdoneby,@ordertype,null,@ordertotalprice,@orderpaidamount,@orderdcid,@orderpaidamountcard)";
            //            MySqlCommand cmdorder = new MySqlCommand(insertOrder, BookShopManagement.Conn.ConnectionString);
            //            cmdorder.Parameters.AddWithValue("@orderdate", TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy hh:mm:ss tt"));
            //            cmdorder.Parameters.AddWithValue("@ordercustomer", cutomerid);
            //            cmdorder.Parameters.AddWithValue("@orderdoneby", Retrieval.User_ID.ToString());
            //            cmdorder.Parameters.AddWithValue("@ordertype", payment_combo.Text);
            //            cmdorder.Parameters.AddWithValue("@ordertotalprice", TotalAmount);
            //            cmdorder.Parameters.AddWithValue("@orderpaidamount", paid_amount_txt.Text);
            //            cmdorder.Parameters.AddWithValue("@orderdcid", DicscountCardID);
            //            cmdorder.Parameters.AddWithValue("@orderpaidamountcard", availablePoints.Text);

            //            int orderres = cmdorder.ExecuteNonQuery();

            //            if (orderres > 0)
            //            {

            //                string getLastOrder = "select Order_ID from sale_order order by Order_ID DESC LIMIT 0,1";
            //                MySqlCommand getorderid = new MySqlCommand(getLastOrder, BookShopManagement.Conn.ConnectionString);

            //                String orderiddd = getorderid.ExecuteScalar().ToString();
            //                //String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,@productid,@productprice,@productdiscountedprice,@productquantity,@productorderid)";
            //                //MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
            //                foreach (ListViewItem item in _listView.Items)
            //                {
            //                    String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,'" + item.SubItems[0].Text + "','" + item.SubItems[4].Text + "','" + item.SubItems[3].Text + "','" + item.SubItems[2].Text + "','" + orderiddd + "')";
            //                    MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
            //                    //cmdproduct.Parameters.AddWithValue("@productid", item.SubItems[0].Text);
            //                    //cmdproduct.Parameters.AddWithValue("@productprice", item.SubItems[4].Text);
            //                    //cmdproduct.Parameters.AddWithValue("@ordeproductdiscountedpricertype", item.SubItems[3].Text);
            //                    //cmdproduct.Parameters.AddWithValue("@productquantity", item.SubItems[2].Text);
            //                    //cmdproduct.Parameters.AddWithValue("@productorderid", orderiddd);
            //                    //MessageBox.Show(insertProducts);
            //                    int prores = cmdproduct.ExecuteNonQuery();
            //                    if (prores > 0)
            //                    {
            //                        result = 1;
            //                    }
            //                }
            //                if (result == 1)
            //                {
            //                    alert aa = new alert("Inserted!", "Sale Successfull.", "success");
            //                    aa.ShowDialog();
            //                }
            //                else
            //                {
            //                    alert aa = new alert("Error!", "Sale Failed.", "error");
            //                    aa.ShowDialog();
            //                }

            //            }
            //            else
            //            {
            //                alert aa = new alert("Error!", "Sale Failed.", "error");
            //                aa.ShowDialog();
            //            }
            //            BookShopManagement.Conn.ConnectionString.Close();


            //        }
            //        else
            //        {
            //            var bankid_combo = listBox1.SelectedItem as ComboboxItem;



            //            String insertOrder = "INSERT INTO `sale_order`(`Order_ID`, `Order_Date`, `Order_Customer_ID`, `Order_DoneBy`, `Order_Type`, `Order_Bank_Account_ID`, `Order_Total_Price`, `Order_Paid_Amount`, `Order_Discount_Card_ID`, `Order_Paid_Amount_By_Point`) VALUES (null,@orderdate,@ordercustomer,@orderdoneby,@ordertype,@orderbank,@ordertotalprice,@orderpaidamount,@orderdcid,@orderpaidamountcard)";
            //            MySqlCommand cmdorder = new MySqlCommand(insertOrder, BookShopManagement.Conn.ConnectionString);
            //            cmdorder.Parameters.AddWithValue("@orderdate", TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy hh:mm:ss tt"));
            //            cmdorder.Parameters.AddWithValue("@ordercustomer", cutomerid);
            //            cmdorder.Parameters.AddWithValue("@orderdoneby", Retrieval.User_ID.ToString());
            //            cmdorder.Parameters.AddWithValue("@ordertype", payment_combo.Text);
            //            cmdorder.Parameters.AddWithValue("@orderbank", bankid_combo.Value.ToString());
            //            cmdorder.Parameters.AddWithValue("@ordertotalprice", TotalAmount);
            //            cmdorder.Parameters.AddWithValue("@orderpaidamount", paid_amount_txt.Text);
            //            cmdorder.Parameters.AddWithValue("@orderdcid", DicscountCardID);
            //            cmdorder.Parameters.AddWithValue("@orderpaidamountcard", availablePoints.Text);
            //            BookShopManagement.Conn.ConnectionString.Open();
            //            int orderres = cmdorder.ExecuteNonQuery();

            //            if (orderres > 0)
            //            {

            //                string getLastOrder = "select Order_ID from sale_order order by Order_ID DESC LIMIT 0,1";
            //                MySqlCommand getorderid = new MySqlCommand(getLastOrder, BookShopManagement.Conn.ConnectionString);

            //                String orderiddd = getorderid.ExecuteScalar().ToString();
            //                //String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,@productid,@productprice,@productdiscountedprice,@productquantity,@productorderid)";
            //                //MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
            //                foreach (ListViewItem item in _listView.Items)
            //                {
            //                    String insertProducts = "INSERT INTO `sale_product`(`Sale_ID`, `Sale_Product_ID`, `Sale_Product_Price`, `Sale_Discounted_Price`, `Sale_Product_Quantity`, `Sale_Order_ID`) VALUES (null,'" + item.SubItems[0].Text + "','" + item.SubItems[4].Text + "','" + item.SubItems[3].Text + "','" + item.SubItems[2].Text + "','" + orderiddd + "')";
            //                    MySqlCommand cmdproduct = new MySqlCommand(insertProducts, BookShopManagement.Conn.ConnectionString);
            //                    //cmdproduct.Parameters.AddWithValue("@productid", item.SubItems[0].Text);
            //                    //cmdproduct.Parameters.AddWithValue("@productprice", item.SubItems[4].Text);
            //                    //cmdproduct.Parameters.AddWithValue("@ordeproductdiscountedpricertype", item.SubItems[3].Text);
            //                    //cmdproduct.Parameters.AddWithValue("@productquantity", item.SubItems[2].Text);
            //                    //cmdproduct.Parameters.AddWithValue("@productorderid", orderiddd);
            //                    //MessageBox.Show(insertProducts);
            //                    int prores = cmdproduct.ExecuteNonQuery();
            //                    if (prores > 0)
            //                    {
            //                        result = 1;
            //                    }
            //                }
            //                if (result == 1)
            //                {
            //                    alert aa = new alert("Inserted!", "Sale Successfull.", "success");
            //                    aa.ShowDialog();
            //                }
            //                else
            //                {
            //                    alert aa = new alert("Error!", "Sale Failed.", "error");
            //                    aa.ShowDialog();
            //                }

            //            }
            //            else
            //            {
            //                alert aa = new alert("Error!", "Sale Failed.", "error");
            //                aa.ShowDialog();
            //            }

            //            //MessageBox.Show("ID : " + item.SubItems[0].Text + ", Quantity:" + item.SubItems[2].Text + ", PRICE AFTER DISCOUNT:" + item.SubItems[3].Text + ", REAL PRICE:" + item.SubItems[4].Text);
            //        }

            //    }



            //}
            //BookShopManagement.Conn.ConnectionString.Close();
            //if (checkBox1.Checked==true)
            //{

            //    string discountcardout = "INSERT INTO `discount_point_out_pos`(`Discount_Out_ID`, `Disccount_Out_Card_ID`, `Discount_Out_Redeem_Points`, `Discount_Out_Redeem_Date`) VALUES (null,'" + DicscountCardID + "','" + availablePoints.Text + "','" + getDate + "')";
            //    MySqlCommand discountcardoutcmd = new MySqlCommand(discountcardout, BookShopManagement.Conn.ConnectionString);
            //    BookShopManagement.Conn.ConnectionString.Open();
            //    int discountcardoutres = discountcardoutcmd.ExecuteNonQuery();
            //    if (discountcardoutres > 0)
            //    {
            //        alert aa = new alert("Point Redeem!", availablePoints.Text + " Point Redeem From Customer's Account.", "success");
            //        aa.ShowDialog();

            //    }
            //    else
            //    {
            //        alert aa = new alert("Failed!", "Failed To Point Redeem From Customer's Account.", "error");
            //        aa.ShowDialog();
            //    }
            //    BookShopManagement.Conn.ConnectionString.Close();


            //    MySqlDataReader sdr1;
            //    string getActivatedInactivepoints = "select Discount_In_Card_ID,COALESCE(SUM(Discount_In_Points),0) as sum from discount_point_in_pos where Discound_In_Status='Activated' and Discount_In_Card_ID='" + DicscountCardID + "'";
            //    MySqlCommand getActivatedInactivepointscmd = new MySqlCommand(getActivatedInactivepoints, BookShopManagement.Conn.ConnectionString);
            //    BookShopManagement.Conn.ConnectionString.Open();
            //    sdr1 = getActivatedInactivepointscmd.ExecuteReader();

            //    while (sdr1.Read())
            //    {

            //        sumofpoints1 = sdr1["sum"].ToString();
            //    }

            //    BookShopManagement.Conn.ConnectionString.Close();


            //    string getRedeempoints = "select COALESCE(SUM(Discount_Out_Redeem_Points),0) as sum from discount_point_out_pos where Disccount_Out_Card_ID='" + DicscountCardID + "'";
            //    MySqlCommand getRedeempointscmd = new MySqlCommand(getRedeempoints, BookShopManagement.Conn.ConnectionString);
            //    BookShopManagement.Conn.ConnectionString.Open();
            //    int getRedeempointsres = Convert.ToInt32(getRedeempointscmd.ExecuteScalar());


            //    if (getRedeempointsres != 0)
            //    {
            //        int updateredeemtocurrent = Convert.ToInt32(sumofpoints1) - getRedeempointsres;

            //        string updatecurrentpointsafterredeem = "update discount_card_pos set DC_Current_Points='" + updateredeemtocurrent.ToString() + "' where DC_Card_Number='" + DicscountCardID + "'";
            //        MySqlCommand updatecurrentpointsafterredeemcmd = new MySqlCommand(updatecurrentpointsafterredeem, BookShopManagement.Conn.ConnectionString);
            //        int updatecurrentpointsafterredeemres = updatecurrentpointsafterredeemcmd.ExecuteNonQuery();
            //        if (updatecurrentpointsafterredeemres > 0)
            //        {


            //        }
            //    }
            //    BookShopManagement.Conn.ConnectionString.Close();
            
            //}
            //else
            //{
                
            //}

           
        }

        private void discount_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void payment_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (payment_combo.Text == "Bank")
            {
                //bank_acc_combo.Enabled = true;
                bank_name_txt_dd.Enabled = true;
            }
            else
            {
             
                bank_name_txt_dd.Enabled = false;
                bank_name_txt_dd.Text = "";
                bank_name_txt.ClearSelected();
            }
        }
        Int64 paidamm;
        public ListView _listView { get; set; }
        int pointssss;
        int avb;
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
        private void Sales_Finalize_Form_Load(object sender, EventArgs e)
        {

            string query = "select * from bank_details_pos where Bank_Acc_Status=0";
            MySqlDataReader sdr;
            MySqlCommand cmd = new MySqlCommand(query, BookShopManagement.Conn.ConnectionString);
            BookShopManagement.Conn.ConnectionString.Close();
            BookShopManagement.Conn.ConnectionString.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                bank_name_txt.DisplayMember = "Text";
                bank_name_txt.ValueMember = "Value";
                bank_name_txt.Items.Add(new ComboboxItem("(" + sdr["Bank_Acc_Number"].ToString() + ")" + sdr["Bank_Acc_Name"].ToString() + "[" + sdr["Bank_Branch"].ToString() + " Branch]", Convert.ToInt16(sdr["Bank_Details_ID"].ToString())));

            }

            BookShopManagement.Conn.ConnectionString.Close();


            payingdate_txt.Enabled = false;

            if (DicscountCardID == null || DicscountCardID == "")
            {
            
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
           
            }
            

            avlpoint = "0";

           
               
            

            BookShopManagement.Conn.ConnectionString.Close();
            BookShopManagement.Conn.ConnectionString.Open();
            availablePoints.Enabled = false;
            if (DicscountCardID == null || DicscountCardID == "")
            {
         
                availablePoints.Enabled = false;
            }
            else if (DicscountCardID != null || DicscountCardID != "")
            {
                String checkdiscoundcard = "select count(*) from `discount_card_pos` where DC_Card_Number='" + DicscountCardID + "' and DC_Customer_ID='" + cutomerid + "'";
                MySqlCommand checkdiscountres = new MySqlCommand(checkdiscoundcard, BookShopManagement.Conn.ConnectionString);
                String count = checkdiscountres.ExecuteScalar().ToString();
                if (count == "1")
                {

                    String getdiscoundcardpoints = "SELECT DC_Current_Points FROM `discount_card_pos` where DC_Card_Number='" + DicscountCardID + "' and DC_Customer_ID='" + cutomerid + "'";
                    MySqlCommand getdiscountpoints = new MySqlCommand(getdiscoundcardpoints, BookShopManagement.Conn.ConnectionString);
                    String points = getdiscountpoints.ExecuteScalar().ToString();
                    availablePoints.Text = points;
                    pointssss = Convert.ToInt32(points);
                    if (points == "0")
                    {
                        checkBox1.Enabled = false;
                    }
                    else
                    {
                        checkBox1.Enabled = true;
                    }
                }
                else
                {

                    availablePoints.Text = "0";

                }
            }



            availablePoints.MaxLength = pointssss;
            net_amount_txt.Text = TotalAmount;
            total_amount_txt.Text = TotalAmount;
            discount_txt.Text = "0";

            paid_amount_txt.Text = net_amount_txt.Text;

           
            paidamm = Convert.ToInt64(net_amount_txt.Text);
            //string query = "select b.Bank_ID,b.Bank_Name from bank_details_pos bd join banks_pos b on b.Bank_ID=bd.Bank_Name_ID";
            //MySqlDataReader sdr;
            //MySqlCommand cmd = new MySqlCommand(query, BookShopManagement.Conn.ConnectionString);
           
            
            //sdr = cmd.ExecuteReader();
            //while (sdr.Read())
            //{
            //    bank_name_combo.DisplayMember = "Text";
            //    bank_name_combo.ValueMember = "Value";
            //    bank_name_combo.Items.Add(new ComboboxItem(sdr["Bank_Name"].ToString(), Convert.ToInt16(sdr["Bank_ID"].ToString())));

            //}

            //BookShopManagement.Conn.ConnectionString.Close();

            
        }

        private void bank_name_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //MySqlDataReader sdr;
            //var bankid = bank_name_combo.SelectedItem as ComboboxItem;

            //string query = "select Bank_Details_ID,Bank_Branch,Bank_Acc_Number,Bank_Acc_Name from bank_details_pos where Bank_Name_ID='" + bankid.Value.ToString() + "' and  Bank_Acc_Status=0";
            //MySqlCommand cmd = new MySqlCommand(query, BookShopManagement.Conn.ConnectionString);
            //BookShopManagement.Conn.ConnectionString.Open();
            //sdr = cmd.ExecuteReader();
            //while (sdr.Read())
            //{
            //    listBox1.DisplayMember = "Text";
            //    listBox1.ValueMember = "Value";
            //    string data = sdr["Bank_Acc_Number"].ToString() + " " + sdr["Bank_Acc_Name"].ToString() + " (" + sdr["Bank_Branch"].ToString() + " Branch)";
              
            //    listBox1.Items.Add(new ComboboxItem(data, Convert.ToInt16(sdr["Bank_Details_ID"].ToString())));

            //}
            //BookShopManagement.Conn.ConnectionString.Close();
            //bank_name_txt.Enabled = true;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            bank_name_txt.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bank_name_txt.SelectedIndex.ToString() == "-1")
            {
            }
            else
            {
                var selectedAcc = bank_name_txt.SelectedItem as ComboboxItem;

                string value1 = selectedAcc.Text.ToString();
                bank_name_txt_dd.Text = value1;
                bank_name_txt.Visible = false;
            }
        }

        private void bank_name_txt_MouseEnter(object sender, EventArgs e)
        {
        }

        private void bank_name_txt_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void discount_txt_TextChanged(object sender, EventArgs e)
        {
            
            if (discount_txt.Text == "")
            {
                discount_txt.Text = "0";
                string dis = discount_txt.Text;
                Int64 a = Convert.ToInt64(net_amount_txt.Text);
                Int64 disPri = ((Convert.ToInt64(discount_txt.Text) * a) / 100);
                Int64 total = Convert.ToInt64(net_amount_txt.Text) - disPri;
                total_amount_txt.Text = total.ToString();
            }
            if (discount_txt.Text == "0")
            {
                discount_txt.SelectAll();
            }
            if (discount_txt.Text != null && discount_txt.Text != "" && discount_txt.Text != "0" && net_amount_txt.Text != null && net_amount_txt.Text != "" && net_amount_txt.Text != "0")
            {
                string dis = discount_txt.Text;
                Int64 a = Convert.ToInt64(net_amount_txt.Text);
                Int64 disPri = ((Convert.ToInt64(discount_txt.Text) * a) / 100);
               
                Int64 total = Convert.ToInt64(net_amount_txt.Text) - disPri;
                total_amount_txt.Text = total.ToString();
                paid_amount_txt.Text = total.ToString();
            }
        }

        private void discount_txt_Click(object sender, EventArgs e)
        {
            if (discount_txt.Text == "0")
            {
                discount_txt.SelectAll();
            }
        }
        int ac=0;
        private void availablePoints_TextChanged(object sender, EventArgs e)
        {
            ac++;
           

      
           
            if (availablePoints.Text == "" || availablePoints.Text == "0" || availablePoints.Text==null)
            {
                avlpoint = "0";
                paid_amount_txt.Text = net_amount_txt.Text;
            }
            else
            {

                if (ac == 1)
                {
                    avlpoint = "0";
                }
                else
                {
                    avlpoint = availablePoints.Text;
                }
                Int64 r = paidamm - Convert.ToInt64(availablePoints.Text);
                paid_amount_txt.Text = r.ToString();
         
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                avlpoint = availablePoints.Text;
                availablePoints.Enabled = true;
                Int64 r = Convert.ToInt64(paid_amount_txt.Text) - Convert.ToInt64(availablePoints.Text);
                paid_amount_txt.Text = r.ToString();
            }
            else
            {
                avlpoint = "0";
                paid_amount_txt.Text = net_amount_txt.Text;
                availablePoints.Enabled = false;
            }
        }

        private void availablePoints_KeyPress(object sender, KeyPressEventArgs e)
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

        private void paid_amount_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void total_amount_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void net_amount_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void net_amount_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(avlpoint);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked==true)
            {
                loan = "true";
                bank_name_txt_dd.Enabled = false;
                availablePoints.Enabled = false;
                checkBox1.Enabled = false;
                discount_txt.Enabled = false;
                payment_combo.Enabled = false;
                payingdate_txt.Enabled = true;
            }
            else
            {
                loan = "false";
                if (payment_combo.Text == "Bank")
                {
                    bank_name_txt_dd.Enabled = true;
                }
                else
                {
                    bank_name_txt_dd.Enabled = false;
                }
                payment_combo.Enabled = true;
                availablePoints.Enabled = false;
                payingdate_txt.Enabled = false;
                if (DicscountCardID == null || DicscountCardID == "")
                {

                    checkBox1.Enabled = false;
                }
                else
                {
                    checkBox1.Enabled = true;

                }
            
                discount_txt.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void date_txt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bank_name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show(loan);
        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            var bankid_combo = bank_name_txt.SelectedItem as ComboboxItem;
            MessageBox.Show(bankid_combo.Value.ToString());
        }

        
    }
}
