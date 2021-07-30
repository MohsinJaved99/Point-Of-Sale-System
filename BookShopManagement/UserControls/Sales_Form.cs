using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.Forms;
using MySql.Data.MySqlClient;
using System.Net;

namespace BookShopManagement.UserControls
{
    public partial class Sales_Form : UserControl
    {
        Conn con = new Conn();
        public Sales_Form()
        {
            InitializeComponent();
            sale_list_view.FullRowSelect = true;
            netAmounttxt.Text = "0";
            discount_txt.Text = "0";
            disPricetxt.Text = "0";

            //MySqlDataReader sdr;
            //MySqlCommand cc = new MySqlCommand("select DISTINCT Pro_Brand_ID from products_pos", Conn.ConnectionString);
            ////MySqlDataAdapter da = new MySqlDataAdapter(cc);
            ////DataTable dd = new DataTable();
            ////da.Fill(dd);
            //Conn.ConnectionString.Close();
            //Conn.ConnectionString.Open();
            //sdr = cc.ExecuteReader();

            //while (sdr.Read())
            //{
            //    MessageBox.Show(sdr["Pro_Brand_ID"].ToString());


                MySqlDataAdapter dtp33 = new MySqlDataAdapter("SELECT * FROM product_brands_pos where Product_Brand_Status=0", Conn.ConnectionString);

                DataTable tp11 = new DataTable();
                dtp33.Fill(tp11);
                product_brand_combo.Items.Clear();
                foreach (DataRow row1 in tp11.Rows)
                {
                    product_brand_combo.DisplayMember = "Text";
                    product_brand_combo.ValueMember = "Value";
                    product_brand_combo.Items.Add(new ComboboxItem(row1["Product_Brand_Name"].ToString(), Convert.ToInt16(row1["Product_Brand_ID"].ToString())));
                }

            //}


            //Conn.ConnectionString.Close();


            //MySqlDataAdapter dtp3 = new MySqlDataAdapter("SELECT * FROM customers_pos ", Conn.ConnectionString);
            //DataTable tp1 = new DataTable();
            //dtp3.Fill(tp1);

            //foreach (DataRow row1 in tp1.Rows)
            //{
            //    customer_combo.DisplayMember = "Text";
            //    customer_combo.ValueMember = "Value";
            //    customer_combo.Items.Add(new ComboboxItem(row1["Customer_Name"].ToString(), Convert.ToInt16(row1["Customer_ID"].ToString())));
            //}
            
        }
        String custid;
        private void finish_btn_Click(object sender, EventArgs e)
        {
            if (CheckForInternetConnection().ToString() == "True")
            {
                //MessageBox.Show(sale_list_view.Items.Count.ToString());
                if (sale_list_view.Items.Count > 0)
                {
                    if (cusname.Text == "")
                    {
                        alert aa = new alert("Error!", "Please Add A Customer.", "error");
                        aa.ShowDialog();
                    }
                    else
                    {
                        //var cc = customer_combo.SelectedItem as ComboboxItem;

                        String productRealPrice = price_txt.Text;
                        String totalAmount = current_amount_label.Text;
                        String dicountcardid = card_num_txt.Text;
                        using (Sales_Finalize_Form uf = new Sales_Finalize_Form(sale_list_view, custid, productRealPrice, totalAmount, dicountcardid))
                        {

                            uf.ShowDialog();
                            sale_list_view.Items.Clear();
                            current_amount_label.Text = "00";
                            //customer_combo.SelectedIndex = -1;
                            cusname.Text = "";
                            custid = "";
                            nic.Text = "";
                            product_brand_combo.SelectedIndex = -1;
                            product_category_combo.SelectedIndex = -1;
                            product_combo.SelectedIndex = -1;
                            price_txt.Text = "";
                            discount_txt.Text = "";
                            disPricetxt.Text = "";
                            netAmounttxt.Text = "";
                            card_num_txt.Text = "";
                            price_txt.BackColor = Color.White;
                        }
                    }
                }
                else
                {
                    alert aa = new alert("Error!", "Please Add Some Product In Cart.", "error");
                    aa.ShowDialog();
                }
            }
            else
            {

            }
        }

        private void product_combo_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        int productPri =0;
        int productWithPric = 0;
        string ProID = "";
        string ProName = "";
        private void product_combo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (product_combo.SelectedIndex.ToString() == "-1")
            {

            }

            else
            {

            
            discount_txt.Text = "0";

            disPricetxt.Text = "0";


            var iddd = product_combo.SelectedItem as ComboboxItem;
            ProID = iddd.Value.ToString();
            ProName = iddd.Text.ToString();
            string ab = "SELECT Product_Comission_Price FROM products_pos WHERE Product_ID='" + ProID + "'";
            MySqlCommand dtpp2 = new MySqlCommand(ab, Conn.ConnectionString);

            if (Conn.ConnectionString.State != ConnectionState.Open)
            {
                Conn.ConnectionString.Open();
            }
            if (dtpp2.ExecuteScalar().ToString() != null || dtpp2.ExecuteScalar().ToString() != "")
            {
                int price = Convert.ToInt32(dtpp2.ExecuteScalar().ToString());
                price_txt.Text = price.ToString();
                productPri = price;
            }
            else
            {

            }


            if (Conn.ConnectionString.State == ConnectionState.Open)
            {
                Conn.ConnectionString.Close();
            }

            if (productPri >= Convert.ToInt64(price_txt.Text))
            {
                price_txt.BackColor = Color.Yellow;
                netAmounttxt.Text = "0";
                add_to_cart_btn.Enabled = false;
            }
        }
        }

        string Priceee="";

        private void price_txt_TextChanged_1(object sender, EventArgs e)
        {
            
            if (price_txt.Text != null && price_txt.Text != "" )
            {
                if (productPri <= Convert.ToInt64(price_txt.Text) && productWithPric >= Convert.ToInt64(price_txt.Text))
                {
                    price_txt.BackColor = Color.Yellow;
                    netAmounttxt.Text = "0";
                    add_to_cart_btn.Enabled = false;
                }
                else if (productPri == Convert.ToInt64(price_txt.Text))
                {
                    price_txt.BackColor = Color.Yellow;
                    netAmounttxt.Text = "0";
                    add_to_cart_btn.Enabled = false;
                }
                else if (productPri >= Convert.ToInt64(price_txt.Text) )
                {
                    price_txt.BackColor = Color.Red;
                    netAmounttxt.Text = "0";
                    add_to_cart_btn.Enabled = false;
                }
                else
                {

                    price_txt.BackColor = Color.Green;
                    netAmounttxt.Text = price_txt.Text;
                    Priceee = price_txt.Text;
                    add_to_cart_btn.Enabled = true;
                }
            }
            
        }

        private void discount_txt_TextChanged(object sender, EventArgs e)
        {

            if (discount_txt.Text == "")
            {

            }
            else
            {

            
            if (discount_txt.Text == "")
            {
                discount_txt.Text = "0";
                string dis = discount_txt.Text;
                Int64 a = Convert.ToInt64(price_txt.Text);
                Int64 disPri = ((Convert.ToInt64(discount_txt.Text) * a) / 100);
                disPricetxt.Text = disPri.ToString();
            }
            if (discount_txt.Text == "0")
            {
                discount_txt.SelectAll();
            }
            if (discount_txt.Text != null && discount_txt.Text != "" && discount_txt.Text != "0" && price_txt.Text != null && price_txt.Text != "" && price_txt.Text != "0")
            {
                string dis = discount_txt.Text;
                Int64 a = Convert.ToInt64(price_txt.Text);
                Int64 disPri = ((Convert.ToInt64(discount_txt.Text) * a) / 100);
                disPricetxt.Text = disPri.ToString();
                Int64 che = Convert.ToInt64(price_txt.Text) - disPri;

                if (productPri <= Convert.ToInt64(che) && productWithPric >= Convert.ToInt64(che))
                {
                    price_txt.BackColor = Color.Yellow;
                    netAmounttxt.Text = "0";
                    add_to_cart_btn.Enabled = false;
                }
                else if (productPri == Convert.ToInt64(price_txt.Text))
                {
                    price_txt.BackColor = Color.Yellow;
                    netAmounttxt.Text = "0";
                    add_to_cart_btn.Enabled = false;
                }
                else if (discount_txt.Text == "0")
                {
                    price_txt.Text = productPri.ToString();
                }
                else if (productPri >= Convert.ToInt64(che))
                {
                    price_txt.BackColor = Color.Red;
                    netAmounttxt.Text = "0";
                    add_to_cart_btn.Enabled = false;
                }
                else
                {

                    price_txt.BackColor = Color.Green;
                    netAmounttxt.Text = (a - disPri).ToString();
                    Priceee = price_txt.Text;
                    add_to_cart_btn.Enabled = true;

                }
            }
        }
        }
        int netAmount = 0;
        int counttt=0;
        private void add_to_cart_btn_Click(object sender, EventArgs e)
        {

            counttt++;

            if (nic.Text == "" || product_combo.Text == "" || product_category_combo.Text == "" || product_brand_combo.Text == "" || price_txt.Text == "" || discount_txt.Text == "" || netAmounttxt.Text == "")
            {
                alert aa = new alert("Error!", "Please Fill All Requirement Of Order.", "error");
                aa.ShowDialog();
            }
            else
            {
                if (sale_list_view.Items.Count > 0)
                {
                    int count = 0;
                    foreach (ListViewItem item in sale_list_view.Items)
                    {
                        string av = "";

                        av = item.Text.ToString();

                        if (av == ProID)
                        {

                            string checkquantity = "select Product_Quantity from products_pos where Product_ID='" + ProID + "'";
                            MySqlCommand checkquantitycmd = new MySqlCommand(checkquantity, BookShopManagement.Conn.ConnectionString);

                            BookShopManagement.Conn.ConnectionString.Close();
                            BookShopManagement.Conn.ConnectionString.Open();
                            int getquantity = Convert.ToInt32(checkquantitycmd.ExecuteScalar().ToString());

                            if (getquantity >= counttt)
                            {
                                count = 1;
                                var temp = sale_list_view.FindItemWithText(ProName);
                                int av1 = Convert.ToInt32(temp.SubItems[2].Text.ToString());
                                int av2 = Convert.ToInt32(temp.SubItems[3].Text.ToString());
                                int av3 = Convert.ToInt32(temp.SubItems[4].Text.ToString());

                                int orgPrice = av3 * av1;
                                int cost = av2 * av1;
                                av1++;
                                temp.SubItems[2].Text = av1.ToString();
                                temp.SubItems[4].Text = orgPrice.ToString();
                                int check = Convert.ToInt32(current_amount_label.Text.ToString());
                                current_amount_label.Text = (check - cost + (av2 * av1)).ToString();
                                sale_list_view.Items[sale_list_view.Items.Count - 1].EnsureVisible();
                                break;
                            }
                            else
                            {
                                alert aa = new alert("Product Quantity", "No Enough Quantity Available.", "info");
                                aa.ShowDialog();
                            }

                            BookShopManagement.Conn.ConnectionString.Close();
                        }


                    }
                    if (count == 0)
                    {
                        string checkquantity = "select Product_Quantity from products_pos where Product_ID='" + ProID + "'";
                        MySqlCommand checkquantitycmd = new MySqlCommand(checkquantity, BookShopManagement.Conn.ConnectionString);

                        BookShopManagement.Conn.ConnectionString.Close();
                        BookShopManagement.Conn.ConnectionString.Open();
                        int getquantity = Convert.ToInt32(checkquantitycmd.ExecuteScalar().ToString());

                        if (getquantity >= counttt)
                        {
                            sale_list_view.Items.Add(new ListViewItem(new string[] { ProID, ProName, "1", netAmounttxt.Text.ToString(), price_txt.Text.ToString(), disPricetxt.Text.ToString() }));
                            sale_list_view.Items[sale_list_view.Items.Count - 1].EnsureVisible();
                            int total = 0;
                            if (current_amount_label.Text == "00")
                            {
                                current_amount_label.Text = netAmounttxt.Text.ToString();
                                netAmount = Convert.ToInt32(current_amount_label.Text);
                            }
                            else
                            {
                                total = Convert.ToInt32(netAmounttxt.Text.ToString());

                                netAmount += total;
                                current_amount_label.Text = netAmount.ToString();
                            }
                        }

                    }

                }
                else
                {

                    sale_list_view.Items.Add(new ListViewItem(new string[] { ProID, ProName, "1", netAmounttxt.Text.ToString(), price_txt.Text.ToString(), disPricetxt.Text.ToString() }));
                    int total = 0;
                    if (current_amount_label.Text == "00" || current_amount_label.Text == "0")
                    {
                        current_amount_label.Text = netAmounttxt.Text.ToString();
                        netAmount = Convert.ToInt32(current_amount_label.Text);
                    }
                    else
                    {
                        total = Convert.ToInt32(netAmounttxt.Text.ToString());

                        netAmount += total;
                        current_amount_label.Text = netAmount.ToString();
                    }

                    sale_list_view.Items[sale_list_view.Items.Count - 1].EnsureVisible();

                }


            }
            //foreach (ListViewItem item in sale_list_view.Items)
            //{
            //    string av = item.SubItems[1].Text.ToString();
            //    MessageBox.Show(av);
            //}
        }
        ListViewItem firstSelectedItem;
        private void sale_list_view_Click(object sender, EventArgs e)
        {

             firstSelectedItem = sale_list_view.FocusedItem;
           
        }

        private void product_plus_btn_Click(object sender, EventArgs e)
        {
            if (sale_list_view.Items.Count > 0)
            {
                try
                {
                    string checkquantity = "select Product_Quantity from products_pos where Product_ID='" + firstSelectedItem.SubItems[0].Text.ToString() + "'";
                    MySqlCommand checkquantitycmd = new MySqlCommand(checkquantity,BookShopManagement.Conn.ConnectionString);
                    BookShopManagement.Conn.ConnectionString.Close();   
                BookShopManagement.Conn.ConnectionString.Open();
                    int getquantity=Convert.ToInt32(checkquantitycmd.ExecuteScalar().ToString());

                    if(getquantity>Convert.ToInt32(firstSelectedItem.SubItems[2].Text)) {
                        int av1 = Convert.ToInt32(firstSelectedItem.SubItems[2].Text.ToString());
                        int av2 = Convert.ToInt32(firstSelectedItem.SubItems[3].Text.ToString());
                        int cost = av2 * av1;
                        av1++;
                        firstSelectedItem.SubItems[2].Text = av1.ToString();
                        int check = Convert.ToInt32(current_amount_label.Text.ToString());
                        current_amount_label.Text = (check - cost + (av2 * av1)).ToString();
                        sale_list_view.Items[sale_list_view.Items.Count - 1].EnsureVisible();
                    }
                    else {
                        alert aa = new alert("Warning", "You Have Exceeded The Product Quantity Limit.", "info");
                        aa.ShowDialog();
                    }

                    BookShopManagement.Conn.ConnectionString.Close();

                }
                catch (Exception ex)
                {
                    alert aa = new alert("Info", "Please Select row.", "info");
                    aa.ShowDialog();
            
                }
            }
        
        }

        private void product_minus_btn_Click(object sender, EventArgs e)
        {
            if (sale_list_view.Items.Count > 0)
            {
                try
                {
                    int av1 = Convert.ToInt32(firstSelectedItem.SubItems[2].Text.ToString());
                    int av2 = Convert.ToInt32(firstSelectedItem.SubItems[3].Text.ToString());
                    if (av1 > 1)
                    {
                       
                        int cost = av2 * av1;
                        av1--;
                        firstSelectedItem.SubItems[2].Text = av1.ToString();
                        int check = Convert.ToInt32(current_amount_label.Text.ToString());
                        current_amount_label.Text = (check - cost + (av2 * av1)).ToString();
                    }

                    sale_list_view.Items[sale_list_view.Items.Count - 1].EnsureVisible();
                }
                catch (Exception ex)
                {
                    alert aa = new alert("Info", "Please Select row.", "info");
                    aa.ShowDialog();
                }
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

            if (sale_list_view.Items.Count > 0)
            {
                try
                {
                    int av1 = Convert.ToInt32(firstSelectedItem.SubItems[2].Text.ToString());
                    int av2 = Convert.ToInt32(firstSelectedItem.SubItems[3].Text.ToString());
                    int cost = av2 * av1;
                    int check = Convert.ToInt32(current_amount_label.Text.ToString());
                    current_amount_label.Text = (check - cost).ToString();
                    sale_list_view.Items.Remove(firstSelectedItem);
                    firstSelectedItem = null;

                }
                catch (Exception ex)
                {
                    alert aa = new alert("Info", "Please Select row.", "info");
                    aa.ShowDialog();
                }
            }
        }

        private void disPricetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void product_label_Click(object sender, EventArgs e)
        {

        }

        private void discount_label_Click(object sender, EventArgs e)
        {

        }

        private void customer_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (customer_combo.SelectedIndex.ToString() == "-1")
            //{

            //}
            //else
            //{
            //    BookShopManagement.Conn.ConnectionString.Close();
            //    var ccc = customer_combo.SelectedItem as ComboboxItem;
            //    String custid1 = ccc.Value.ToString();
            //    String checkdiscoundcard = "select count(*) from `discount_card_pos` where DC_Customer_ID='" + custid1 + "'";
            //    MySqlCommand checkdiscountres = new MySqlCommand(checkdiscoundcard, BookShopManagement.Conn.ConnectionString);
            //    BookShopManagement.Conn.ConnectionString.Open();
            //    String count = checkdiscountres.ExecuteScalar().ToString();
            //    if (count == "0")
            //    {
            //        card_num_txt.Text = "";

            //    }
            //    else
            //    {
            //        String getcardnumber = "select DC_Card_Number from discount_card_pos where DC_Customer_ID='" + custid1 + "'";
            //        MySqlCommand getcmd = new MySqlCommand(getcardnumber, BookShopManagement.Conn.ConnectionString);
            //        card_num_txt.Text = getcmd.ExecuteScalar().ToString();

            //    }
            //    BookShopManagement.Conn.ConnectionString.Close();
            //}
           
        }

        private void netAmounttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void card_num_txr_TextChanged(object sender, EventArgs e)
        {
            //var ccc = customer_combo.SelectedItem as ComboboxItem;
            //String custid1 = ccc.Value.ToString();
            //String checkdiscoundcard = "select count(*) from `discount_card_pos` where DC_Card_Number='" + card_num_txt.Text + "' and DC_Customer_ID='" + custid1 + "'";
            //    MySqlCommand checkdiscountres = new MySqlCommand(checkdiscoundcard, BookShopManagement.Conn.ConnectionString);
            //    BookShopManagement.Conn.ConnectionString.Close();
                
            //BookShopManagement.Conn.ConnectionString.Open();
            //    String count = checkdiscountres.ExecuteScalar().ToString();
            //    if (count == "0")
            //    {
            //        check.ForeColor = Color.FromArgb(192, 0, 0);
            //        check.Text = "Wrong Card Number.";
            //    }
            //    else
            //    {
            //        check.ForeColor = Color.Green;
            //        check.Text = "Card Number Matched.";
            //    }
            //    BookShopManagement.Conn.ConnectionString.Close();
        }

        private void card_num_label_Click(object sender, EventArgs e)
        {

        }

        private void price_label_Click(object sender, EventArgs e)
        {

        }

        private void heading_label_Click(object sender, EventArgs e)
        {

        }

        private void customer_label_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void price_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void discount_txt_Click(object sender, EventArgs e)
        {
            if (discount_txt.Text == "0")
            {
                discount_txt.SelectAll();
            }
        }

        private void Sales_Form_Load(object sender, EventArgs e)
        {

        }

        private void sale_list_view_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            //foreach (ListViewItem item in sale_list_view.Items)
            //{


            //    MessageBox.Show(item.SubItems[0].Text + " " + item.SubItems[1].Text);
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked == true)
            //{
            //    card_num_txt.Enabled = true;
            //    card_num_txt.Select();
            //}
            //else
            //{
            //    card_num_txt.Text = "";
            //    check.Text = "";
            //    card_num_txt.Enabled = false;
            //}
        }

        private void product_brand_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (product_brand_combo.SelectedIndex.ToString() == "-1")
            {

            }
            else
            {


                product_category_combo.Enabled = true;
                product_category_combo.Items.Clear();
                var ccc = product_brand_combo.SelectedItem as ComboboxItem;
                String brandid = ccc.Value.ToString();

                //var aaa = product_category_combo.SelectedItem as ComboboxItem;
                //String catid = aaa.Value.ToString();


                string getcat = "select DISTINCT Product_Cat_ID from products_pos where Pro_Brand_ID='" + brandid + "'";
                MySqlCommand getcatcmd = new MySqlCommand(getcat, Conn.ConnectionString);
                MySqlDataAdapter getcatid = new MySqlDataAdapter(getcatcmd);

                DataTable dt = new DataTable();

                getcatid.Fill(dt);

                foreach (DataRow r in dt.Rows)
                {


                    string getcatname = "SELECT Product_Category_Name FROM product_category_pos where Product_Category_ID='" + r["Product_Cat_ID"].ToString() + "'";
                    MySqlCommand getcatnamecmd = new MySqlCommand(getcatname, Conn.ConnectionString);
                    BookShopManagement.Conn.ConnectionString.Close();
                    BookShopManagement.Conn.ConnectionString.Open();
                    string getcatnameres = getcatnamecmd.ExecuteScalar().ToString();


                    string getcatidd = "SELECT Product_Category_ID FROM product_category_pos where Product_Category_ID='" + r["Product_Cat_ID"].ToString() + "'";
                    MySqlCommand getcatidcmd = new MySqlCommand(getcatidd, Conn.ConnectionString);
                    string getcatidres = getcatidcmd.ExecuteScalar().ToString();

                    //MySqlDataAdapter dtp333 = new MySqlDataAdapter(getcatcmd1);

                    //DataTable tp111 = new DataTable();
                    //dtp333.Fill(tp111);

                    //product_category_combo.Items.Clear();
                    //foreach (DataRow row1 in tp111.Rows)
                    //{

                    product_category_combo.DisplayMember = "Text";
                    product_category_combo.ValueMember = "Value";
                    product_category_combo.Items.Add(new ComboboxItem(getcatnameres, Convert.ToInt16(getcatidres)));
                    //}

                    BookShopManagement.Conn.ConnectionString.Close();

                }


            }
        }
        int stock;
        int abc;
        private void product_category_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (product_brand_combo.SelectedIndex.ToString() == "-1")
            {

            }
            else
            {


                product_combo.Enabled = true;

                var aaaa = product_brand_combo.SelectedItem as ComboboxItem;
                var bbbb = product_category_combo.SelectedItem as ComboboxItem;

                //MessageBox.Show("Brand : " + aaaa.Value.ToString() + "Cat : " + bbbb.Value.ToString());
                MySqlDataAdapter dtp2 = new MySqlDataAdapter("SELECT * FROM `products_pos` WHERE Pro_Brand_ID='" + aaaa.Value.ToString() + "' and Product_Cat_ID='" + bbbb.Value.ToString() + "' and Product_Status='Active'", Conn.ConnectionString);

                DataTable tp = new DataTable();
                dtp2.Fill(tp);

                product_combo.Items.Clear();
                foreach (DataRow row1 in tp.Rows)
                {
                    abc++;
                    if (Convert.ToInt32(row1["Product_Quantity"].ToString()) == 0)
                    {
                        stock = 1;
                    }
                    else
                    {
                        stock = 0;
                        product_combo.DisplayMember = "Text";
                        product_combo.ValueMember = "Value";
                        product_combo.Items.Add(new ComboboxItem(row1["Product_Name"].ToString() + " (" + row1["Product_Model"].ToString() + "," + row1["Product_Color"].ToString() + ")", Convert.ToInt16(row1["Product_ID"].ToString())));
                    }

                }

                if (stock == abc)
                {
                    product_combo.Enabled = false;
                    alert aa = new alert("Info!", "Stock Unavailable.", "info");
                    aa.ShowDialog();

                }
            }
        }
            
      


                
          
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            //customer_combo.SelectedIndex = -1;
            //product_category_combo.SelectedIndex = -1;
            //product_brand_combo.SelectedIndex = -1;
            //product_combo.SelectedIndex = -1;
            //price_txt.Text = "";
            //card_num_txt.Text = "";
            //checkBox1.Checked = false;
            //discount_txt.Text = "0";
            //netAmounttxt.Text = "0";
            //disPricetxt.Text = "0";
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            sale_list_view.Items.Clear();
            current_amount_label.Text = "00";
            cusname.Text = "";
            custid = "";
            nic.Text = "";
            product_brand_combo.SelectedIndex = -1;
            product_category_combo.SelectedIndex = -1;
            product_combo.SelectedIndex = -1;
            price_txt.Text = "";
            price_txt.BackColor = Color.White;
            discount_txt.Text = "";
            disPricetxt.Text = "";
            netAmounttxt.Text = "";
            card_num_txt.Text = "";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            cusname.Text = "";
            custid = "";
            nic.Text = "";
            product_brand_combo.SelectedIndex = -1;
            product_category_combo.SelectedIndex = -1;
            product_combo.SelectedIndex = -1;
            price_txt.Text = "";
            discount_txt.Text = "";
            disPricetxt.Text = "";
            netAmounttxt.Text = "";
            card_num_txt.Text = "";
            price_txt.BackColor = Color.White;
        }

        private void nic_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void nic_TextChanged(object sender, EventArgs e)
        {
           
            string getcustomer = "select * from customers_pos where Customer_NIC='" + nic.Text + "'";
            MySqlCommand getcs = new MySqlCommand(getcustomer, Conn.ConnectionString);
            MySqlDataAdapter da = new MySqlDataAdapter(getcs);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow sdr in dt.Rows)
                {
                    custid = sdr["Customer_ID"].ToString();
                    cusname.Text = sdr["Customer_Name"].ToString();
                }
            }
            else
            {
                cusname.Text = "";
                custid = "";
                card_num_txt.Text = "";
            }
                      
                
           

        }

        private void cusname_TextChanged(object sender, EventArgs e)
        {
            if (cusname.Text == "")
            {

            }
            else
            {
             
                    BookShopManagement.Conn.ConnectionString.Close();


                    String checkdiscoundcard = "select count(*) from `discount_card_pos` where DC_Customer_ID='" + custid + "'";
                    MySqlCommand checkdiscountres = new MySqlCommand(checkdiscoundcard, BookShopManagement.Conn.ConnectionString);
                    BookShopManagement.Conn.ConnectionString.Open();
                    String count = checkdiscountres.ExecuteScalar().ToString();
                    if (count == "0")
                    {
                        card_num_txt.Text = "";

                    }
                    else
                    {
                        String getcardnumber = "select DC_Card_Number from discount_card_pos where DC_Customer_ID='" + custid + "'";
                        MySqlCommand getcmd = new MySqlCommand(getcardnumber, BookShopManagement.Conn.ConnectionString);
                        card_num_txt.Text = getcmd.ExecuteScalar().ToString();

                    }
                    BookShopManagement.Conn.ConnectionString.Close();
                
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
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ProID = "0";
        //    product_combo.SelectedIndex = -1;
        //    customer_combo.SelectedIndex = -1;
        //    discount_txt.Text = "0";
        //    price_txt.Text = "0";
        //    netAmounttxt.Text = "0";
        //    disPricetxt.Text = "0";
        //    card_num_txr.Text = "";
        //}

    }
}
