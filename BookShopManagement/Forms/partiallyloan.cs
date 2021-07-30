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
    public partial class partiallyloan : Form
    {
        public partiallyloan()
        {
            InitializeComponent();
        }

        int pointssss;
        string avlpoint;
        string net;
        string dcid;
        string cusid, orderid;
        string ccid;

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

        public partiallyloan(string creditid)
        {
            InitializeComponent();
            
            ccid = creditid;
            Conn.ConnectionString.Close();
            Conn.ConnectionString.Open();
            string getda = "SELECT c.Customer_Name,cr.Credit_Amount FROM `credit_sale` cr join customers_pos c on cr.Credit_Customer_ID=c.Customer_ID where Credit_Sale_ID='" + creditid + "'";
            MySqlCommand gg = new MySqlCommand(getda, Conn.ConnectionString);
            MySqlDataAdapter daa = new MySqlDataAdapter(gg);
            DataTable dtt = new DataTable();
            daa.Fill(dtt);
            
            foreach (DataRow r in dtt.Rows)
            {
                net_amount_txt.Text = r["Credit_Amount"].ToString();
                paying_amount.Text = r["Credit_Amount"].ToString();
                customer_name.Text = r["Customer_Name"].ToString();
            }

            string getcid = "select Credit_Customer_ID from credit_sale where Credit_Sale_ID='" + creditid + "'";

            MySqlCommand gid=new MySqlCommand(getcid,Conn.ConnectionString);
    

            cusid=gid.ExecuteScalar().ToString();


            string getcidd = "select Credit_Order_ID from credit_sale where Credit_Sale_ID='" + creditid + "'";

            MySqlCommand gidd = new MySqlCommand(getcidd, Conn.ConnectionString);


            orderid = gidd.ExecuteScalar().ToString();


            string countcard = "select count(*) from discount_card_pos where DC_Customer_ID='" + cusid + "'";
            MySqlCommand ccccc = new MySqlCommand(countcard, Conn.ConnectionString);

            if (ccccc.ExecuteScalar().ToString() == "0")
            {

            }
            else
            {
                string getdisid = "select DC_Card_Number from discount_card_pos where DC_Customer_ID='" + cusid + "'";
                MySqlCommand gdi = new MySqlCommand(getdisid, Conn.ConnectionString);
                dcid = gdi.ExecuteScalar().ToString();
            }
           
            //String checkdiscoundcard = "select count(*) from `discount_card_pos` where DC_Customer_ID='" + cusid + "'";
            //    MySqlCommand checkdiscountres = new MySqlCommand(checkdiscoundcard, BookShopManagement.Conn.ConnectionString);
            //    String count = checkdiscountres.ExecuteScalar().ToString();
            //    if (count == "1")
            //    {

            //        String getdiscoundcardpoints = "SELECT DC_Current_Points FROM `discount_card_pos` where DC_Customer_ID='" + cusid + "'";
            //        MySqlCommand getdiscountpoints = new MySqlCommand(getdiscoundcardpoints, BookShopManagement.Conn.ConnectionString);
            //        String points = getdiscountpoints.ExecuteScalar().ToString();
            //        availablePoints.Text = points;
            //        pointssss = Convert.ToInt32(points);
            //        if (points == "0")
            //        {
            //            checkBox1.Enabled = false;
            //        }
            //        else
            //        {
            //            checkBox1.Enabled = true;
            //        }
            //    }
            //    else
            //    {

            //        availablePoints.Text = "0";

            //    }

            Conn.ConnectionString.Close();

          
            //SELECT c.Customer_Name,cr.Credit_Amount FROM `credit_sale` cr join customers_pos c on Credit_Customer_ID=c.Customer_ID
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedAcc = listBox1.SelectedItem as ComboboxItem;

            string value1 = selectedAcc.Text.ToString();
            bank_name_txt.Text = value1;
            listBox1.Visible = false;
            save_btn.Enabled = true;
        }

        private void partiallyloan_Load(object sender, EventArgs e)
        {
            string query = "select b.Bank_ID,b.Bank_Name from bank_details_pos bd join banks_pos b on b.Bank_ID=bd.Bank_Name_ID";
            MySqlDataReader sdr;
            MySqlCommand cmd = new MySqlCommand(query, BookShopManagement.Conn.ConnectionString);
            Conn.ConnectionString.Close();
            Conn.ConnectionString.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                bank_name_combo.DisplayMember = "Text";
                bank_name_combo.ValueMember = "Value";
                bank_name_combo.Items.Add(new ComboboxItem(sdr["Bank_Name"].ToString(), Convert.ToInt16(sdr["Bank_ID"].ToString())));

            }
            Conn.ConnectionString.Close();
        }

        private void bank_name_txt_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void payment_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (payment_combo.Text == "Bank")
            {
                //bank_acc_combo.Enabled = true;
                bank_name_txt.Enabled = true;
                bank_name_combo.Enabled = true;
                save_btn.Enabled = false;
            }
            else
            {
                bank_name_combo.SelectedIndex = -1;
                bank_name_txt.Text = "";
                bank_name_txt.Enabled = false;
                bank_name_combo.Enabled = false;
                save_btn.Enabled = true;
            }
        }










        string card, orderID;



        private void addCshBank()
        {






            var info = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
            DateTimeOffset localServerTime = DateTimeOffset.Now;
            if (payment_combo.Text == "Cash")
            {
                Conn.ConnectionString.Close();
                Conn.ConnectionString.Open();
                string getoldpaidamount = "select Order_Paid_Amount from sale_order  where Order_ID='" + orderid + "'";

                MySqlCommand ccc = new MySqlCommand(getoldpaidamount, Conn.ConnectionString);
                int oldpaid = Convert.ToInt32(ccc.ExecuteScalar().ToString());

                int recentpaying = oldpaid + Convert.ToInt32(paying_amount.Text);


                string updateorder = "update sale_order set Order_Type='Loan',Order_Paid_Amount='" + recentpaying.ToString() + "' where Order_ID='" + orderid + "'";
                MySqlCommand uo = new MySqlCommand(updateorder, Conn.ConnectionString);
          
                int ress = uo.ExecuteNonQuery();
                if (ress > 0)
                {
                    int cram=Convert.ToInt32(net_amount_txt.Text)-Convert.ToInt32(paying_amount.Text);
                    string deleteloan = "update `credit_sale` set Credit_Amount='"+cram.ToString()+"' WHERE Credit_Sale_ID='" + ccid + "'";
                    MySqlCommand dl = new MySqlCommand(deleteloan, Conn.ConnectionString);
                    int dddd = dl.ExecuteNonQuery();
                    if (dddd > 0)
                    {
                        alert aaa = new alert("Paid!", "Loan Successfull Paid.", "success");
                        aaa.ShowDialog();
                        confirmationForm cd = new confirmationForm("Sale Report", "Do You Want To Generate Sale Report?");
                        cd.ShowDialog();
                        if (cd.r == "yes")
                        {

                            String getorderidd = "select Order_ID from sale_order where Order_Customer_ID='" + cusid + "' order by Order_ID DESC LIMIT 0,1";
                            MySqlCommand getorderidcmd = new MySqlCommand(getorderidd, BookShopManagement.Conn.ConnectionString);
                            string oid = getorderidcmd.ExecuteScalar().ToString();

                            //String getcusid = "select Order_Customer_ID from sale_order where Order_ID='" + oid + "'";
                            //MySqlCommand getcusidcmd = new MySqlCommand(getcusid, BookShopManagement.Conn.ConnectionString);


                            //string cid = getcusidcmd.ExecuteScalar().ToString();

                            string checkdc = "select count(*) from discount_card_pos where DC_Customer_ID='" + cusid + "'";
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
                        alert aaa = new alert("Error!", "Loan Dont Successfull Paid.", "error");
                        aaa.ShowDialog();
                    }
                }
                else
                {
                    alert aaa = new alert("Error!", "Loan Dont Successfull Paid.", "error");
                    aaa.ShowDialog();
                }
                Conn.ConnectionString.Close();
            }
            else
            {
                var bankid_combo = listBox1.SelectedItem as ComboboxItem;

                var selectedAcc = listBox1.SelectedItem as ComboboxItem;


                string getoldpaidamount = "select Order_Paid_Amount from sale_order where Order_ID='" + orderid + "'";

                MySqlCommand ccc = new MySqlCommand(getoldpaidamount, Conn.ConnectionString);
                int oldpaid = Convert.ToInt32(ccc.ExecuteScalar().ToString());

                int recentpaying = oldpaid + Convert.ToInt32(paying_amount.Text);

                string updateorder = "update sale_order set Order_Type='Loan',Order_Paid_Amount='" + recentpaying.ToString() + "' where Order_ID='" + orderid + "'";
                MySqlCommand uo = new MySqlCommand(updateorder, Conn.ConnectionString);
                Conn.ConnectionString.Close();
                Conn.ConnectionString.Open();
                int ress = uo.ExecuteNonQuery();
                if (ress > 0)
                {
                    int cram = Convert.ToInt32(net_amount_txt.Text) - Convert.ToInt32(paying_amount.Text);
                    string deleteloan = "update `credit_sale` set Credit_Amount='" + cram.ToString() + "' WHERE Credit_Sale_ID='" + ccid + "'";
                    MySqlCommand dl = new MySqlCommand(deleteloan, Conn.ConnectionString);
                    int dddd = dl.ExecuteNonQuery();
                    if (dddd > 0)
                    {

                        String dd = TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy hh:mm:ss tt");
                        String addTransection = "INSERT INTO `transactions_in_pos`(`Transaction_In_ID`, `Transaction_In_Payment_Method`, `Transaction_In_Account_ID`, `Transaction_In_Amount`, `Transaction_In_Date`, `Transaction_In_Sale_ID`) VALUES (null,'" + payment_combo.Text + "','" + selectedAcc.Value.ToString() + "','" + paying_amount.Text + "','" + dd + "','" + orderid + "')";
                        MySqlCommand addTransectioncmd = new MySqlCommand(addTransection, BookShopManagement.Conn.ConnectionString);
                        int addTransectionres = addTransectioncmd.ExecuteNonQuery();
                        if (addTransectionres > 0)
                        {

                            string getaccountmoney = "select Bank_Acc_Balance from bank_details_pos where Bank_Details_ID='" + selectedAcc.Value.ToString() + "'";
                            MySqlCommand am = new MySqlCommand(getaccountmoney, Conn.ConnectionString);
                            int getmoney = Convert.ToInt32(am.ExecuteScalar().ToString());

                            int summoney = getmoney + Convert.ToInt32(paying_amount.Text);

                            string updatemoney = "update bank_details_pos set Bank_Acc_Balance='" + summoney.ToString() + "' where Bank_Details_ID='" + selectedAcc.Value.ToString() + "'";
                            MySqlCommand upm = new MySqlCommand(updatemoney, Conn.ConnectionString);

                            int upppres = upm.ExecuteNonQuery();
                            if (upppres > 0)
                            {
                                alert aaa = new alert("Paid!", "Loan Successfull Paid.", "success");
                                aaa.ShowDialog();
                                confirmationForm cd = new confirmationForm("Sale Report", "Do You Want To Generate Sale Report?");
                                cd.ShowDialog();
                                if (cd.r == "yes")
                                {

                                    String getorderidd = "select Order_ID from sale_order where Order_Customer_ID='" + cusid + "' order by Order_ID DESC LIMIT 0,1";
                                    MySqlCommand getorderidcmd = new MySqlCommand(getorderidd, BookShopManagement.Conn.ConnectionString);
                                    string oid = getorderidcmd.ExecuteScalar().ToString();

                                    //String getcusid = "select Order_Customer_ID from sale_order where Order_ID='" + oid + "'";
                                    //MySqlCommand getcusidcmd = new MySqlCommand(getcusid, BookShopManagement.Conn.ConnectionString);


                                    //string cid = getcusidcmd.ExecuteScalar().ToString();

                                    string checkdc = "select count(*) from discount_card_pos where DC_Customer_ID='" + cusid + "'";
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
                        }


                    }
                    else
                    {
                        alert aaa = new alert("Error!", "Loan Dont Successfull Paid.", "error");
                        aaa.ShowDialog();
                    }
                }
                else
                {
                    alert aaa = new alert("Error!", "Loan Dont Successfull Paid.", "error");
                    aaa.ShowDialog();
                }

            }
        }







        string sumofpoints1;
        private void bank_name_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlDataReader sdr;
            var bankid = bank_name_combo.SelectedItem as ComboboxItem;

            string query = "select Bank_Details_ID,Bank_Branch,Bank_Acc_Number,Bank_Acc_Name from bank_details_pos where Bank_Name_ID='" + bankid.Value.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(query, BookShopManagement.Conn.ConnectionString);
            BookShopManagement.Conn.ConnectionString.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                listBox1.DisplayMember = "Text";
                listBox1.ValueMember = "Value";
                string data = sdr["Bank_Acc_Number"].ToString() + " " + sdr["Bank_Acc_Name"].ToString() + " (" + sdr["Bank_Branch"].ToString() + " Branch)";

                listBox1.Items.Add(new ComboboxItem(data, Convert.ToInt16(sdr["Bank_Details_ID"].ToString())));

            }
            BookShopManagement.Conn.ConnectionString.Close();
            bank_name_txt.Enabled = true;
        }

















        private void addCshBank1()
        {






            var info = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
            DateTimeOffset localServerTime = DateTimeOffset.Now;
            if (payment_combo.Text == "Cash")
            {
                string updateorder = "update sale_order set Order_Type='Cash',Order_Paid_Amount='" + paying_amount.Text + "' where Order_ID='" + orderid + "'";
                MySqlCommand uo = new MySqlCommand(updateorder, Conn.ConnectionString);
                Conn.ConnectionString.Close();
                Conn.ConnectionString.Open();
                int ress = uo.ExecuteNonQuery();
                if (ress > 0)
                {
                    string deleteloan = "DELETE FROM `credit_sale` WHERE Credit_Sale_ID='" + ccid + "'";
                    MySqlCommand dl = new MySqlCommand(deleteloan, Conn.ConnectionString);
                    int dddd = dl.ExecuteNonQuery();
                    if (dddd > 0)
                    {
                        alert aaa = new alert("Paid!", "Complete Loan Successfull Paid.", "success");
                        aaa.ShowDialog();
                        confirmationForm cd = new confirmationForm("Sale Report", "Do You Want To Generate Sale Report?");
                        cd.ShowDialog();
                        if (cd.r == "yes")
                        {

                            String getorderidd = "select Order_ID from sale_order where Order_Customer_ID='" + cusid + "' order by Order_ID DESC LIMIT 0,1";
                            MySqlCommand getorderidcmd = new MySqlCommand(getorderidd, BookShopManagement.Conn.ConnectionString);
                            string oid = getorderidcmd.ExecuteScalar().ToString();

                            //String getcusid = "select Order_Customer_ID from sale_order where Order_ID='" + oid + "'";
                            //MySqlCommand getcusidcmd = new MySqlCommand(getcusid, BookShopManagement.Conn.ConnectionString);


                            //string cid = getcusidcmd.ExecuteScalar().ToString();

                            string checkdc = "select count(*) from discount_card_pos where DC_Customer_ID='" + cusid + "'";
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
                        alert aaa = new alert("Error!", "Loan Dont Successfull Paid.", "error");
                        aaa.ShowDialog();
                    }
                }
                else
                {
                    alert aaa = new alert("Error!", "Loan Dont Successfull Paid.", "error");
                    aaa.ShowDialog();
                }
                Conn.ConnectionString.Close();
            }
            else
            {
                var bankid_combo = listBox1.SelectedItem as ComboboxItem;

                var selectedAcc = listBox1.SelectedItem as ComboboxItem;


                string updateorder = "update sale_order set Order_Type='Cash',Order_Paid_Amount='" + paying_amount.Text + "' where Order_ID='" + orderid + "'";
                MySqlCommand uo = new MySqlCommand(updateorder, Conn.ConnectionString);
                Conn.ConnectionString.Close();
                Conn.ConnectionString.Open();
                int ress = uo.ExecuteNonQuery();
                if (ress > 0)
                {
                    string deleteloan = "DELETE FROM `credit_sale` WHERE Credit_Sale_ID='" + ccid + "'";
                    MySqlCommand dl = new MySqlCommand(deleteloan, Conn.ConnectionString);
                    int dddd = dl.ExecuteNonQuery();
                    if (dddd > 0)
                    {

                        String dd = TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy hh:mm:ss tt");
                        String addTransection = "INSERT INTO `transactions_in_pos`(`Transaction_In_ID`, `Transaction_In_Payment_Method`, `Transaction_In_Account_ID`, `Transaction_In_Amount`, `Transaction_In_Date`, `Transaction_In_Sale_ID`) VALUES (null,'" + payment_combo.Text + "','" + selectedAcc.Value.ToString() + "','" + paying_amount.Text + "','" + dd + "','" + orderid + "')";
                        MySqlCommand addTransectioncmd = new MySqlCommand(addTransection, BookShopManagement.Conn.ConnectionString);
                        int addTransectionres = addTransectioncmd.ExecuteNonQuery();
                        if (addTransectionres > 0)
                        {

                            string getaccountmoney = "select Bank_Acc_Balance from bank_details_pos where Bank_Details_ID='" + selectedAcc.Value.ToString() + "'";
                            MySqlCommand am = new MySqlCommand(getaccountmoney, Conn.ConnectionString);
                            int getmoney = Convert.ToInt32(am.ExecuteScalar().ToString());

                            int summoney = getmoney + Convert.ToInt32(paying_amount.Text);

                            string updatemoney = "update bank_details_pos set Bank_Acc_Balance='" + summoney.ToString() + "' where Bank_Details_ID='" + selectedAcc.Value.ToString() + "'";
                            MySqlCommand upm = new MySqlCommand(updatemoney, Conn.ConnectionString);

                            int upppres = upm.ExecuteNonQuery();
                            if (upppres > 0)
                            {
                                alert aaa = new alert("Paid!", "Complete Loan Successfull Paid.", "success");
                                aaa.ShowDialog();
                                confirmationForm cd = new confirmationForm("Sale Report", "Do You Want To Generate Sale Report?");
                                cd.ShowDialog();
                                if (cd.r == "yes")
                                {

                                    String getorderidd = "select Order_ID from sale_order where Order_Customer_ID='" + cusid + "' order by Order_ID DESC LIMIT 0,1";
                                    MySqlCommand getorderidcmd = new MySqlCommand(getorderidd, BookShopManagement.Conn.ConnectionString);
                                    string oid = getorderidcmd.ExecuteScalar().ToString();

                                    //String getcusid = "select Order_Customer_ID from sale_order where Order_ID='" + oid + "'";
                                    //MySqlCommand getcusidcmd = new MySqlCommand(getcusid, BookShopManagement.Conn.ConnectionString);


                                    //string cid = getcusidcmd.ExecuteScalar().ToString();

                                    string checkdc = "select count(*) from discount_card_pos where DC_Customer_ID='" + cusid + "'";
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
                        }


                    }
                    else
                    {
                        alert aaa = new alert("Error!", "Loan Dont Successfull Paid.", "error");
                        aaa.ShowDialog();
                    }
                }
                else
                {
                    alert aaa = new alert("Error!", "Loan Dont Successfull Paid.", "error");
                    aaa.ShowDialog();
                }

            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (CheckForInternetConnection().ToString() == "True")
            {
                if (payment_combo.Text == "")
                {
                    alert aa = new alert("Error!", "Please Select Payment Method.", "error");
                    aa.ShowDialog();
                }
                //else if (payment_combo.Text!="Cash" && payment_combo.Text == "Bank" && bank_name_txt.Text == "" || bank_name_combo.Text == "")
                //{
                //    alert aa = new alert("Error!", "Please Fill Bank Information.", "error");
                //    aa.ShowDialog();
                //}
                else if(payment_combo.Text=="Cash" || payment_combo.Text=="Bank")
                {

                if (paying_amount.Text == net_amount_txt.Text)
                {
                    BookShopManagement.Conn.ConnectionString.Open();

                Random r = new Random();
                int serialno = Convert.ToInt32(r.Next(1000000000));

                var info = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
                DateTimeOffset localServerTime = DateTimeOffset.Now;

                DateTime startDate = DateTime.Parse(TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy"));
                DateTime expiryDate = startDate.AddDays(3);


                String getDate = TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy");


                String checkdiscoundcard = "select count(*) from `discount_card_pos` where DC_Card_Number='" + dcid + "' and DC_Customer_ID='" + cusid + "'";
                MySqlCommand checkdiscountres = new MySqlCommand(checkdiscoundcard, BookShopManagement.Conn.ConnectionString);
                String count = checkdiscountres.ExecuteScalar().ToString();
                if (count == "0")
                {

                    if (Convert.ToInt32(paying_amount.Text) > 50000)
                    {
                        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                        var stringChars = new char[25];
                        var random = new Random();

                        for (int i = 0; i < stringChars.Length; i++)
                        {
                            stringChars[i] = chars[random.Next(chars.Length)];
                        }

                        var finalString = new String(stringChars);

                        String createDiscoundCard = "INSERT INTO `discount_card_pos`(`DC_Card_Number`, `Serial_Number`, `DC_Customer_ID`, `DC_Current_Points`, `DC_Start_Date`) VALUES ('" + finalString.ToString() + "','" + serialno.ToString() + "','" + cusid + "',0,'" + getDate + "')";
                        MySqlCommand createDiscoundCardcmd = new MySqlCommand(createDiscoundCard, BookShopManagement.Conn.ConnectionString);
                        int createDiscoundCardres = createDiscoundCardcmd.ExecuteNonQuery();
                        if (createDiscoundCardres > 0)
                        {
                            alert aa = new alert("Congratulations!", "Discount Card Has Been Created.", "success");
                            aa.ShowDialog();




                        }


                        addCshBank1();
                    }
                    else
                    {
                        addCshBank1();
                    }




                }
                else
                {

                    int forDiscountCardTotalPrice = Convert.ToInt32(paying_amount.Text);
                    int discountCardPointsIn = forDiscountCardTotalPrice / 100;

                    string DiscountCardIn = "INSERT INTO `discount_point_in_pos`(`Discount_In_ID`, `Discount_In_Card_ID`, `Discount_In_Points`, `Discount_In_Start_Date`, `Discount_In_Activation_Date`, `Discound_In_Status`) VALUES (null,'" + dcid + "','" + discountCardPointsIn + "','" + getDate + "','" + expiryDate.ToString("dd-MMMM-yyyy") + "','Inactive')";
                    MySqlCommand DiscountCardIncmd = new MySqlCommand(DiscountCardIn, BookShopManagement.Conn.ConnectionString);
                    int DiscountCardInres = DiscountCardIncmd.ExecuteNonQuery();
                    if (DiscountCardInres > 0)
                    {
                        string getActivatedpoints = "select COALESCE(SUM(Discount_In_Points),0) as sum from discount_point_in_pos where Discount_In_Card_ID='" + dcid + "' and Discound_In_Status='Activated'";
                        MySqlCommand getActivatedpointscmd = new MySqlCommand(getActivatedpoints, BookShopManagement.Conn.ConnectionString);
                        int getActivatedpointsres = Convert.ToInt32(getActivatedpointscmd.ExecuteScalar());


                        string getRedeempoints = "select COALESCE(SUM(Discount_Out_Redeem_Points),0) as sum from discount_point_out_pos where Disccount_Out_Card_ID='" + dcid + "'";
                        MySqlCommand getRedeempointscmd = new MySqlCommand(getRedeempoints, BookShopManagement.Conn.ConnectionString);
                        int getRedeempointsres = Convert.ToInt32(getRedeempointscmd.ExecuteScalar());


                        //string getCurrentpoints = "select DC_Current_Points from discount_card_pos where DC_Card_Number='" + DicscountCardID + "' and DC_Customer_ID='" + cutomerid + "'";
                        //MySqlCommand getCurrentpointscmd = new MySqlCommand(getCurrentpoints, BookShopManagement.Conn.ConnectionString);
                        //int getCurrentpointssres = Convert.ToInt32(getCurrentpointscmd.ExecuteScalar());


                        int updatedcurrentpoints = getActivatedpointsres - getRedeempointsres;

                        string updatecurrentpoints = "UPDATE `discount_card_pos` SET `DC_Current_Points`='" + updatedcurrentpoints.ToString() + "' WHERE DC_Card_Number='" + dcid + "' and DC_Customer_ID='" + cusid + "'";
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



                    addCshBank1();

                }
                }
                else
                {



                    BookShopManagement.Conn.ConnectionString.Open();

                    Random r = new Random();
                    int serialno = Convert.ToInt32(r.Next(1000000000));

                    var info = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
                    DateTimeOffset localServerTime = DateTimeOffset.Now;

                    DateTime startDate = DateTime.Parse(TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy"));
                    DateTime expiryDate = startDate.AddDays(3);


                    String getDate = TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy");


                    String checkdiscoundcard = "select count(*) from `discount_card_pos` where DC_Card_Number='" + dcid + "' and DC_Customer_ID='" + cusid + "'";
                    MySqlCommand checkdiscountres = new MySqlCommand(checkdiscoundcard, BookShopManagement.Conn.ConnectionString);
                    String count = checkdiscountres.ExecuteScalar().ToString();
                    if (count == "0")
                    {

                        if (Convert.ToInt32(paying_amount.Text) > 50000)
                        {
                            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                            var stringChars = new char[25];
                            var random = new Random();

                            for (int i = 0; i < stringChars.Length; i++)
                            {
                                stringChars[i] = chars[random.Next(chars.Length)];
                            }

                            var finalString = new String(stringChars);

                            String createDiscoundCard = "INSERT INTO `discount_card_pos`(`DC_Card_Number`, `Serial_Number`, `DC_Customer_ID`, `DC_Current_Points`, `DC_Start_Date`) VALUES ('" + finalString.ToString() + "','" + serialno.ToString() + "','" + cusid + "',0,'" + getDate + "')";
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

                        int forDiscountCardTotalPrice = Convert.ToInt32(paying_amount.Text);
                        int discountCardPointsIn = forDiscountCardTotalPrice / 100;

                        string DiscountCardIn = "INSERT INTO `discount_point_in_pos`(`Discount_In_ID`, `Discount_In_Card_ID`, `Discount_In_Points`, `Discount_In_Start_Date`, `Discount_In_Activation_Date`, `Discound_In_Status`) VALUES (null,'" + dcid + "','" + discountCardPointsIn + "','" + getDate + "','" + expiryDate.ToString("dd-MMMM-yyyy") + "','Inactive')";
                        MySqlCommand DiscountCardIncmd = new MySqlCommand(DiscountCardIn, BookShopManagement.Conn.ConnectionString);
                        int DiscountCardInres = DiscountCardIncmd.ExecuteNonQuery();
                        if (DiscountCardInres > 0)
                        {
                            string getActivatedpoints = "select COALESCE(SUM(Discount_In_Points),0) as sum from discount_point_in_pos where Discount_In_Card_ID='" + dcid + "' and Discound_In_Status='Activated'";
                            MySqlCommand getActivatedpointscmd = new MySqlCommand(getActivatedpoints, BookShopManagement.Conn.ConnectionString);
                            int getActivatedpointsres = Convert.ToInt32(getActivatedpointscmd.ExecuteScalar());


                            string getRedeempoints = "select COALESCE(SUM(Discount_Out_Redeem_Points),0) as sum from discount_point_out_pos where Disccount_Out_Card_ID='" + dcid + "'";
                            MySqlCommand getRedeempointscmd = new MySqlCommand(getRedeempoints, BookShopManagement.Conn.ConnectionString);
                            int getRedeempointsres = Convert.ToInt32(getRedeempointscmd.ExecuteScalar());


                            //string getCurrentpoints = "select DC_Current_Points from discount_card_pos where DC_Card_Number='" + DicscountCardID + "' and DC_Customer_ID='" + cutomerid + "'";
                            //MySqlCommand getCurrentpointscmd = new MySqlCommand(getCurrentpoints, BookShopManagement.Conn.ConnectionString);
                            //int getCurrentpointssres = Convert.ToInt32(getCurrentpointscmd.ExecuteScalar());


                            int updatedcurrentpoints = getActivatedpointsres - getRedeempointsres;

                            string updatecurrentpoints = "UPDATE `discount_card_pos` SET `DC_Current_Points`='" + updatedcurrentpoints.ToString() + "' WHERE DC_Card_Number='" + dcid + "' and DC_Customer_ID='" + cusid + "'";
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




                    }
                } 
            }
            }
        }

        private void paying_amount_TextChanged(object sender, EventArgs e)
        {


            if (paying_amount.Text == "" || paying_amount.Text == "0")
            {
                paying_amount.Text = "1";
            }
            else
            {

            }


            if (Convert.ToInt32(paying_amount.Text) > Convert.ToInt32(net_amount_txt.Text))
            {
                string s = paying_amount.Text;

                if (s.Length > 1)
                {
                    s = s.Substring(0, s.Length - 1);
                }
                else
                {
                    s = "0";
                }

                paying_amount.Text = s;
            }
            else
            {

            }
            
        }

        private void bank_name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void heading_label_Click(object sender, EventArgs e)
        {

        }
        
    }
}
