using BookShopManagement.Forms;
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

namespace BookShopManagement.UserControls
{
    public partial class UC_Purchases : UserControl
    {
        public UC_Purchases()
        {
            InitializeComponent();
        }

        String purchase_doneby_id;
        private void purchase_done()
        {
            string query = "select User_ID,User_First_Name,User_Last_Name from users_pos where User_ID='" + Retrieval.User_ID + "'";
            MySqlDataReader sdr;
            MySqlCommand cmd = new MySqlCommand(query, BookShopManagement.Conn.ConnectionString);

            BookShopManagement.Conn.ConnectionString.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                String name = sdr["User_First_Name"].ToString() + " " + sdr["User_Last_Name"].ToString();
                purchase_doneby_id = sdr["User_ID"].ToString();
                purchase_doneBy.Text = name;

                purchase_doneBy.Enabled = false;
            }

            BookShopManagement.Conn.ConnectionString.Close();
        }

        private void supplier()
        {
            string query = "select Supplier_ID,Supplier_company,Supplier_Contact_Person from suppliers_pos where Supplier_Status=0";
            MySqlDataReader sdr;
            MySqlCommand cmd = new MySqlCommand(query, BookShopManagement.Conn.ConnectionString);

            BookShopManagement.Conn.ConnectionString.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                String name = "(" + sdr["Supplier_company"].ToString() + ") " + sdr["Supplier_Contact_Person"].ToString();
                supplier_combo.DisplayMember = "Text";
                supplier_combo.ValueMember = "Value";
                supplier_combo.Items.Add(new ComboboxItem(name, Convert.ToInt16(sdr["Supplier_ID"].ToString())));

            }

            BookShopManagement.Conn.ConnectionString.Close();
        }

        private void products()
        {
            string query = "select p.Product_ID,p.Product_Name,b.Product_Brand_Name,p.Product_Model from products_pos p join product_brands_pos b on p.Pro_Brand_ID=b.Product_Brand_ID join product_category_pos c on c.Product_Category_ID=p.Product_Cat_ID where b.Product_Brand_Status=0 and c.Product_Category_Status=0";
            MySqlDataReader sdr;
            MySqlCommand cmd = new MySqlCommand(query, BookShopManagement.Conn.ConnectionString);

            BookShopManagement.Conn.ConnectionString.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                String name = "" + sdr["Product_Brand_Name"].ToString() + " | " + sdr["Product_Name"].ToString() + " (" + sdr["Product_Model"].ToString() + ")";
                purchase_product.DisplayMember = "Text";
                purchase_product.ValueMember = "Value";
                purchase_product.Items.Add(new ComboboxItem(name, Convert.ToInt16(sdr["Product_ID"].ToString())));

            }

            BookShopManagement.Conn.ConnectionString.Close();
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

        private void UC_Purchases_Load(object sender, EventArgs e)
        {

            string query = "select * from bank_details_pos where Bank_Acc_Status=0";
            MySqlDataReader sdr;
            MySqlCommand cmd = new MySqlCommand(query, BookShopManagement.Conn.ConnectionString);

            Conn.ConnectionString.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                bank_account_combo.DisplayMember = "Text";
                bank_account_combo.ValueMember = "Value";
                bank_account_combo.Items.Add(new ComboboxItem("(" + sdr["Bank_Acc_Number"].ToString() + ")" + sdr["Bank_Acc_Name"].ToString() +"[" + sdr["Bank_Branch"].ToString() + " Branch]", Convert.ToInt16(sdr["Bank_Details_ID"].ToString())));

            }

            BookShopManagement.Conn.ConnectionString.Close();
            bank_account_combo.Enabled = false;

            purchase_done();
            supplier();
            products();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //purchase_doneBy.Text = "";
            //purchase_product.SelectedIndex = -1;
            //supplier_combo.SelectedIndex = -1;
            //purchase_date.Value = DateTime.Now;
            //var psale_combo = purchase_doneBy_combo.SelectedItem as ComboboxItem;
            //var pproduct_combo = purchase_product.SelectedItem as ComboboxItem;
            //var supp_combo = supplier_combo.SelectedItem as ComboboxItem;
            //psale_combo.Text = "";
            //pproduct_combo.Text = "";
            //supp_combo.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            purchase_doneBy.Text = "";
            purchase_product.SelectedIndex = -1;
            supplier_combo.SelectedIndex = -1;
            purchase_date.Value = DateTime.Now;
            purchase_discount.Text = "";
            purchase_price.Text = "";
            discount_amount.Text = "";
            total_amount.Text = "";
        }

        private void purchase_discount_TextChanged(object sender, EventArgs e)
        {
            if (purchase_discount.Text == "0")
            {

            }
            else
            {
                if (purchase_discount.Text != null && purchase_discount.Text != "" && purchase_discount.Text != "0")
                {
                    if (purchase_price.Text != "" || purchase_price.Text != "0" || purchase_price != null)
                    {
                        int totalprice = Convert.ToInt32(purchase_price.Text);
                        int discountt = Convert.ToInt32(purchase_discount.Text);
                        int discountedamount = (totalprice * discountt) / 100;

                        int dd = totalprice - discountedamount;

                        //int netamount = dd * Convert.ToInt32(purchase_quantity.Text);

                        total_amount.Text = dd.ToString();
                        discount_amount.Text = discountedamount.ToString();

                    }
                }
                else
                {
                    int qun = Convert.ToInt32(purchase_quantity.Text);
                    int price = Convert.ToInt32(product_price.Text);
                    int total = price * qun;
                    purchase_price.Text = total.ToString();
                    purchase_discount.Text = "0";
                    total_amount.Text = purchase_price.Text;
                    discount_amount.Text = "0";

                }
            }
        }

        private void purchase_price_TextChanged(object sender, EventArgs e)
        {
            if (purchase_price.Text == "")
            {

            }
            else
            {


                purchase_discount.Enabled = true;
                if (purchase_discount.Text != null && purchase_discount.Text != "" && purchase_discount.Text != "0")
                {
                    if (purchase_price.Text != "" || purchase_price.Text != "0" || purchase_price != null)
                    {

                        int purpice = Convert.ToInt32(purchase_price.Text);
                        int discountt = Convert.ToInt32(purchase_discount.Text);
                        int disPri = (discountt * purpice) / 100;
                        int total = purpice - disPri;
                        int total1 = total * Convert.ToInt32(purchase_quantity.Text);
                        discount_amount.Text = disPri.ToString();
                        total_amount.Text = total1.ToString();
                    }
                }
                else
                {
                    purchase_discount.Text = "";
                }
            }
        }

        private void purchase_price_KeyPress(object sender, KeyPressEventArgs e)
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

        private void purchase_discount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void total_amount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void discount_amount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void purchase_quantity_KeyPress(object sender, KeyPressEventArgs e)
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

            if (supplier_combo.Text == "" || purchase_product.Text == "" || product_commision.Text == "" || product_price.Text == "" || total_amount.Text == "")
            {
                alert aa = new alert("Error!", "Please Fill All Fields.", "error");
                aa.ShowDialog();
            }
            else
            {
                if (ptype.Text == "Cash")
                {

                    Random r = new Random();
                    int serialno = Convert.ToInt32(r.Next(1000000000));
                    string theDate = purchase_date.Value.ToString("dd-MMMM-yyyy");
                    //Add to products_pos
                    var supplierr = supplier_combo.SelectedItem as ComboboxItem;
                    var producttt = purchase_product.SelectedItem as ComboboxItem;
                    string query = "INSERT INTO `purchase_pos`(`Purchase_ID`, `Purchase_Date`, `Purchase_Done_By`, `Purchase_Supplier_ID`,`Serial_Number`) VALUES (null,@date,@doneby,@supplier,@srno)";

                    MySqlCommand cmd = new MySqlCommand(query, BookShopManagement.Conn.ConnectionString);
                    cmd.Parameters.AddWithValue("@date", theDate);
                    cmd.Parameters.AddWithValue("@doneby", purchase_doneby_id);
                    cmd.Parameters.AddWithValue("@supplier", supplierr.Value.ToString());
                    cmd.Parameters.AddWithValue("@srno", serialno.ToString());
                    Conn.ConnectionString.Close();
                    BookShopManagement.Conn.ConnectionString.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res != 0)
                    {


                        string query1 = "SELECT Purchase_ID FROM `purchase_pos` ORDER BY `Purchase_ID` DESC  LIMIT 0,1";

                        MySqlCommand cmd1 = new MySqlCommand(query1, BookShopManagement.Conn.ConnectionString);
                        int pid = Convert.ToInt32(cmd1.ExecuteScalar());
                        string query2 = "INSERT INTO `purchase_details_pos`(`PD_ID`,`PD_Purchase_ID`, `PD_Product_ID`, `PD_Product_Price`, `PD_Purchase_Discount`, `PD_Product_Quantity`, `PD_Product_Total_Price`) VALUES (null,@purchaseID,@productID,@productPrice,@prodis,@productQuantity,@productTotal)";
                        MySqlCommand cmd2 = new MySqlCommand(query2, BookShopManagement.Conn.ConnectionString);
                        cmd2.Parameters.AddWithValue("@purchaseID", pid.ToString());
                        cmd2.Parameters.AddWithValue("@productID", producttt.Value.ToString());
                        cmd2.Parameters.AddWithValue("@productPrice", purchase_price.Text);
                        cmd2.Parameters.AddWithValue("@prodis", discount_amount.Text);
                        cmd2.Parameters.AddWithValue("@productQuantity", purchase_quantity.Text);
                        cmd2.Parameters.AddWithValue("@productTotal", total_amount.Text);
                        int res1 = cmd2.ExecuteNonQuery();
                        if (res1 != 0)
                        {
                            string getquantity = "select Product_Quantity from products_pos where Product_ID='" + producttt.Value.ToString() + "'";
                            MySqlCommand getquantitycmd = new MySqlCommand(getquantity, BookShopManagement.Conn.ConnectionString);
                            int getquantityres = Convert.ToInt32(getquantitycmd.ExecuteScalar().ToString());


                            int add = getquantityres + Convert.ToInt32(purchase_quantity.Text);
                            string addquantity = "update products_pos set Product_Quantity='" + add.ToString() + "',Product_Price='" + product_price.Text + "',Product_Comission_Price='" + product_commision.Text + "' where Product_ID='" + producttt.Value.ToString() + "'";

                            MySqlCommand addcmd = new MySqlCommand(addquantity, BookShopManagement.Conn.ConnectionString);
                            int addres = addcmd.ExecuteNonQuery();

                            if (addres > 0)
                            {


                                alert aa = new alert("Purchased!", "You Have Successfully Purchased (" + purchase_quantity.Text + ") " + purchase_product.Text, "success");
                                aa.ShowDialog();

                                supplier_combo.SelectedIndex = -1;
                                purchase_product.SelectedIndex = -1;
                                purchase_quantity.Text = "";
                                product_commision.Text = "";
                                product_price.Text = "";
                                purchase_price.Text = "";
                                purchase_discount.Text = "0";
                                discount_amount.Text = "0";
                                total_amount.Text = "";
                                ptype.SelectedIndex = -1;
                                bank_account_combo.SelectedIndex = -1;
                            }
                            else
                            {
                                alert aa = new alert("Error!", "Product Quantity Addition Failed", "error");
                                aa.ShowDialog();
                            }
                        }
                        else
                        {
                            alert aa = new alert("Error!", "Product Purchased Failed", "error");
                            aa.ShowDialog();
                        }
                    }
                    else
                    {
                        alert aa = new alert("Failed!", "Failed Process.", "error");
                        aa.ShowDialog();
                    }
                    BookShopManagement.Conn.ConnectionString.Close();
                }
                else
                {


                    if (ptype.Text == "Bank" && bank_account_combo.Text == "" || bank_account_combo.SelectedIndex == -1)
                    {
                        alert aa = new alert("Error!", "Please Select A Bank.", "error");
                        aa.ShowDialog();
                    }
                    else
                    {



                        Random r = new Random();
                        int serialno = Convert.ToInt32(r.Next(1000000000));
                        string theDate = purchase_date.Value.ToString("dd-MMMM-yyyy");
                        //Add to products_pos
                        var supplierr = supplier_combo.SelectedItem as ComboboxItem;
                        var producttt = purchase_product.SelectedItem as ComboboxItem;
                        string query = "INSERT INTO `purchase_pos`(`Purchase_ID`, `Purchase_Date`, `Purchase_Done_By`, `Purchase_Supplier_ID`,`Serial_Number`) VALUES (null,@date,@doneby,@supplier,@srno)";

                        MySqlCommand cmd = new MySqlCommand(query, BookShopManagement.Conn.ConnectionString);
                        cmd.Parameters.AddWithValue("@date", theDate);
                        cmd.Parameters.AddWithValue("@doneby", purchase_doneby_id);
                        cmd.Parameters.AddWithValue("@supplier", supplierr.Value.ToString());
                        cmd.Parameters.AddWithValue("@srno", serialno.ToString());
                        Conn.ConnectionString.Close();
                        BookShopManagement.Conn.ConnectionString.Open();
                        int res = cmd.ExecuteNonQuery();
                        if (res != 0)
                        {


                            string query1 = "SELECT Purchase_ID FROM `purchase_pos` ORDER BY `Purchase_ID` DESC  LIMIT 0,1";

                            MySqlCommand cmd1 = new MySqlCommand(query1, BookShopManagement.Conn.ConnectionString);
                            int pid = Convert.ToInt32(cmd1.ExecuteScalar());
                            string query2 = "INSERT INTO `purchase_details_pos`(`PD_ID`,`PD_Purchase_ID`, `PD_Product_ID`, `PD_Product_Price`, `PD_Purchase_Discount`, `PD_Product_Quantity`, `PD_Product_Total_Price`) VALUES (null,@purchaseID,@productID,@productPrice,@prodis,@productQuantity,@productTotal)";
                            MySqlCommand cmd2 = new MySqlCommand(query2, BookShopManagement.Conn.ConnectionString);
                            cmd2.Parameters.AddWithValue("@purchaseID", pid.ToString());
                            cmd2.Parameters.AddWithValue("@productID", producttt.Value.ToString());
                            cmd2.Parameters.AddWithValue("@productPrice", purchase_price.Text);
                            cmd2.Parameters.AddWithValue("@prodis", discount_amount.Text);
                            cmd2.Parameters.AddWithValue("@productQuantity", purchase_quantity.Text);
                            cmd2.Parameters.AddWithValue("@productTotal", total_amount.Text);
                            int res1 = cmd2.ExecuteNonQuery();
                            if (res1 != 0)
                            {
                                string getquantity = "select Product_Quantity from products_pos where Product_ID='" + producttt.Value.ToString() + "'";
                                MySqlCommand getquantitycmd = new MySqlCommand(getquantity, BookShopManagement.Conn.ConnectionString);
                                int getquantityres = Convert.ToInt32(getquantitycmd.ExecuteScalar().ToString());


                                int add = getquantityres + Convert.ToInt32(purchase_quantity.Text);
                                string addquantity = "update products_pos set Product_Quantity='" + add.ToString() + "',Product_Price='" + product_price.Text + "',Product_Comission_Price='" + product_commision.Text + "' where Product_ID='" + producttt.Value.ToString() + "'";

                                MySqlCommand addcmd = new MySqlCommand(addquantity, BookShopManagement.Conn.ConnectionString);
                                int addres = addcmd.ExecuteNonQuery();

                                if (addres > 0)
                                {


                                    if (ptype.Text == "Bank")
                                    {
                                        var account = bank_account_combo.SelectedItem as ComboboxItem;
                                        string checkmoney = "select Bank_Acc_Balance from bank_details_pos where Bank_Details_ID='" + account.Value.ToString() + "'";
                                        MySqlCommand cmddd = new MySqlCommand(checkmoney, Conn.ConnectionString);

                                        int currentmoney = Convert.ToInt32(cmddd.ExecuteScalar().ToString());

                                        int neta = Convert.ToInt32(total_amount.Text);

                                        int final = currentmoney - neta;

                                        string updatemoney = "update bank_details_pos set Bank_Acc_Balance='" + final.ToString() + "' where Bank_Details_ID='" + account.Value.ToString() + "'";
                                        MySqlCommand upm = new MySqlCommand(updatemoney, Conn.ConnectionString);

                                        int upppres = upm.ExecuteNonQuery();
                                        if (upppres > 0)
                                        {

                                            string getlastpurchase = "select Purchase_ID from purchase_pos order by Purchase_ID DESC LIMIT 0,1";
                                            MySqlCommand glp = new MySqlCommand(getlastpurchase, Conn.ConnectionString);
                                            string purrrid = glp.ExecuteScalar().ToString();

                                            string outtransiction = "INSERT INTO `transactions_out_pos`(`Transaction_Out_ID`, `Transaction_Out_Payment_Method`, `Transaction_Out_Account_ID`, `Transaction_Out_Amount`, `Transaction_Out_Date`, `Transaction_Purchase_ID`) VALUES (null,'" + ptype.Text + "','" + account.Value.ToString() + "' ,'" + total_amount.Text + "', '" + DateTime.Now.ToString() + "','" + purrrid + "')";
                                            MySqlCommand ot = new MySqlCommand(outtransiction, Conn.ConnectionString);
                                            int otres = ot.ExecuteNonQuery();

                                        }



                                    }

                                    alert aa = new alert("Purchased!", "You Have Successfully Purchased (" + purchase_quantity.Text + ") " + purchase_product.Text, "success");
                                    aa.ShowDialog();

                                    supplier_combo.SelectedIndex = -1;
                                    purchase_product.SelectedIndex = -1;
                                    purchase_quantity.Text = "";
                                    product_commision.Text = "";
                                    product_price.Text = "";
                                    purchase_price.Text = "";
                                    purchase_discount.Text = "0";
                                    discount_amount.Text = "0";
                                    total_amount.Text = "";
                                    ptype.SelectedIndex = -1;
                                    bank_account_combo.SelectedIndex = -1;
                                }
                                else
                                {
                                    alert aa = new alert("Error!", "Product Quantity Addition Failed", "error");
                                    aa.ShowDialog();
                                }
                            }
                            else
                            {
                                alert aa = new alert("Error!", "Product Purchased Failed", "error");
                                aa.ShowDialog();
                            }
                        }
                        else
                        {
                            alert aa = new alert("Failed!", "Failed Process.", "error");
                            aa.ShowDialog();
                        }
                        BookShopManagement.Conn.ConnectionString.Close();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void product_price_TextChanged(object sender, EventArgs e)
        {
            if (purchase_quantity.Text == "" || purchase_quantity.Text == null)
            {
               
            }
            else
            {
                int qun = Convert.ToInt32(purchase_quantity.Text);
                int price = Convert.ToInt32(product_price.Text);
                int total = price * qun;
                purchase_price.Text = total.ToString();
            }
        }

        private void purchase_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (purchase_product.SelectedIndex.ToString() == "-1")
            {

            }
            else
            {


                var producttt = purchase_product.SelectedItem as ComboboxItem;
                string getp = "select Product_Price,Product_Comission_Price from products_pos where Product_ID='" + producttt.Value.ToString() + "'";
                MySqlCommand getc = new MySqlCommand(getp, Conn.ConnectionString);
                MySqlDataAdapter da = new MySqlDataAdapter(getc);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {

                    if (row["Product_Price"].ToString() != "" || row["Product_Price"].ToString() != null)
                    {
                        product_price.Text = row["Product_Price"].ToString();
                        product_commision.Text = row["Product_Comission_Price"].ToString();
                    }
                    else
                    {
                        product_price.Text = "";
                        product_commision.Text = "";
                    }
                }
            }
            
          
        }

        private void purchase_quantity_TextChanged(object sender, EventArgs e)
        {
            if (purchase_product.SelectedIndex.ToString() == "-1")
            {

            }
            else
            {
                if (product_price.Text == "" || product_price.Text == null)
                {

                }
                else if (purchase_quantity.Text == "")
                {
                    purchase_quantity.Text = "0";
                    purchase_quantity.SelectionStart = 0;
                    purchase_quantity.SelectionLength = purchase_quantity.Text.Length;

                }
                else
                {




                    int qun = Convert.ToInt32(purchase_quantity.Text);
                    int price = Convert.ToInt32(product_price.Text);
                    int total = price * qun;
                    purchase_price.Text = total.ToString();








                    int totalprice = Convert.ToInt32(purchase_price.Text);
                    int discountt = Convert.ToInt32(purchase_discount.Text);
                    int discountedamount = (totalprice * discountt) / 100;

                    int dd = totalprice - discountedamount;


                    //int netamount = dd * Convert.ToInt32(purchase_quantity.Text);

                    total_amount.Text = dd.ToString();
                    discount_amount.Text = discountedamount.ToString();
                }
            }
        }

        private void product_price_KeyPress(object sender, KeyPressEventArgs e)
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

        private void product_commision_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void purchase_doneBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void supplier_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pname_Click(object sender, EventArgs e)
        {

        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ptype.Text == "Bank")
            {
                bank_account_combo.Enabled = true;

            }
            else
            {
                bank_account_combo.SelectedIndex = -1;
                bank_account_combo.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bank_account_combo.Text != "" || bank_account_combo.SelectedIndex != -1)
            {
                var account = bank_account_combo.SelectedItem as ComboboxItem;
                string checkmoney = "select Bank_Acc_Balance from bank_details_pos where Bank_Details_ID='" + account.Value.ToString() + "'";
                MySqlCommand cmd = new MySqlCommand(checkmoney, Conn.ConnectionString);
                Conn.ConnectionString.Open();
                int money = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                if (Convert.ToInt32(total_amount.Text) > money)
                {
                    alert aa = new alert("Opss!", "You Don't Have Enough Money In This Account.", "error");
                    aa.ShowDialog();
                    bank_account_combo.SelectedIndex = -1;
                }
                else
                {
                    alert aa = new alert("Info!", "You Have "+money.ToString()+" In This Account.", "info");
                    aa.ShowDialog();
                }
          

                Conn.ConnectionString.Close();

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void purchase_discount_Click(object sender, EventArgs e)
        {
            if (purchase_discount.Text == "0")
            {
                purchase_discount.SelectAll();
            }
        }
    }
}
