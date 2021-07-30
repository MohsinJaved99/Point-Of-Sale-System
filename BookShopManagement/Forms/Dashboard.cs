using BookShopManagement.UserControls;
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
    public partial class Dashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public string loading="load";
        public Dashboard()
        {
            InitializeComponent();
           
            
            panelControls.HorizontalScroll.Maximum = 0;
            timer2.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            UC_Home UH = new UC_Home();
            AddControlsToPanel(UH);
        
            Users_Btn.BackColor = Color.FromArgb(225,27,45);
            Home_Btn.BackColor = Color.FromArgb(201,24,40);
            Product_Brand_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Category_Btn.BackColor = Color.FromArgb(225,27,45);
            Customers_Btn.BackColor = Color.FromArgb(225,27,45);
            Sales_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Bank_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Btn.BackColor = Color.FromArgb(225,27,45);
            Suppliers_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Branches_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225,27,45);
            Purchases_Btn.BackColor = Color.FromArgb(225,27,45);
            view_purchase_btn.BackColor = Color.FromArgb(225, 27, 45);
            View_Sales_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225, 27, 45);
            view_purchase_btn.BackColor = Color.FromArgb(225, 27, 45);
            info.BackColor = Color.FromArgb(225, 27, 45);
            loan.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);



            button12.BackColor = Color.FromArgb(225, 27, 45);
            button13.BackColor = Color.FromArgb(225, 27, 45);
            button2.BackColor = Color.FromArgb(225, 27, 45);
            button8.BackColor = Color.FromArgb(201, 24, 40);
            button3.BackColor = Color.FromArgb(225, 27, 45);
        }



        int unactivepoints;
        String disincardid, sumofpoints;
        String disincardid1, sumofpoints1;
        int ressss;
        int count = 0;
        int CalculateupdatedCurrentPoints;
        string cardid;
        private void Form_Dashboard_Load(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            var info = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
                    DateTimeOffset localServerTime = DateTimeOffset.Now;

             

            String getDate=TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy");




            string getInactiveID = "select Discount_In_Card_ID from discount_point_in_pos where Discound_In_Status='Inactive' and Discount_In_Activation_Date='" + getDate + "' order by Discount_In_Card_ID DESC";
            MySqlCommand getInactiveIDcmd = new MySqlCommand(getInactiveID, BookShopManagement.Conn.ConnectionString);
            MySqlDataAdapter dt = new MySqlDataAdapter(getInactiveIDcmd);
            DataTable ds = new DataTable();
                        dt.Fill(ds);
            BookShopManagement.Conn.ConnectionString.Open();

            foreach (DataRow dr in ds.Rows)
            {
                cardid = dr["Discount_In_Card_ID"].ToString();
                string SumOfPointsInactive = "select COALESCE(SUM(Discount_In_Points),0) as sum from discount_point_in_pos where Discound_In_Status='Inactive' and Discount_In_Activation_Date='" + getDate + "' and Discount_In_Card_ID='" + dr["Discount_In_Card_ID"].ToString() + "'";
                MySqlCommand SumOfPointsInactivecmd = new MySqlCommand(SumOfPointsInactive, BookShopManagement.Conn.ConnectionString);
                MySqlDataAdapter dt1 = new MySqlDataAdapter(SumOfPointsInactivecmd);
                DataTable ds1 = new DataTable();

                dt1.Fill(ds1);
                foreach (DataRow dr1 in ds1.Rows)
                {
                    count++;
                    string getCurrentpoints = "select DC_Current_Points from discount_card_pos where DC_Card_Number='" + dr["Discount_In_Card_ID"].ToString() + "'";
                    MySqlCommand getCurrentpointscmd = new MySqlCommand(getCurrentpoints, BookShopManagement.Conn.ConnectionString);
                    int currentpoints = Convert.ToInt32(getCurrentpointscmd.ExecuteScalar());
                    CalculateupdatedCurrentPoints = currentpoints + Convert.ToInt32(dr1["sum"].ToString());
                }

                    string sql = "UPDATE `discount_card_pos` SET `DC_Current_Points` = '" + CalculateupdatedCurrentPoints.ToString() + "' WHERE `DC_Card_Number` = '" + dr["Discount_In_Card_ID"].ToString() + "'";
                    MySqlCommand UpdateCurrentPointcmd = new MySqlCommand(sql, BookShopManagement.Conn.ConnectionString);
                    int UpdateCurrentPointres = UpdateCurrentPointcmd.ExecuteNonQuery();
                    if (UpdateCurrentPointres > 0)
                    {

                        //MessageBox.Show("Updated Record of Card " + ds.Rows[i].ItemArray[0].ToString());
                        string updateactivestatus = "update discount_point_in_pos set Discound_In_Status='Activated' where Discound_In_Status='Inactive' and Discount_In_Activation_Date='" + getDate + "' and Discount_In_Card_ID='" + dr["Discount_In_Card_ID"].ToString() + "'";
                        //MessageBox.Show("Update Actated Status  : " + updateactivestatus);
                        MySqlCommand updateactivestatuscmd = new MySqlCommand(updateactivestatus, BookShopManagement.Conn.ConnectionString);
                        int updateactivestatusres = updateactivestatuscmd.ExecuteNonQuery();
                        if (updateactivestatusres > 0)
                        {

                            ressss = 1;
                        }


                    }


                

                    if (ressss == 1)
                    {
                        //alert aa = new alert("Points Activated!", "All Users Discount Card Points Activated Of Date" + getDate, "success");

                        //aa.ShowDialog();
                    }

            }

            //string getInactiveID = "select Discount_In_Card_ID from discount_point_in_pos where Discound_In_Status='Inactive' and Discount_In_Activation_Date='" + getDate + "' order by Discount_In_Card_ID DESC";
            //MySqlCommand getInactiveIDcmd = new MySqlCommand(getInactiveID, BookShopManagement.Conn.ConnectionString);
            //MySqlDataAdapter dt = new MySqlDataAdapter(getInactiveIDcmd);
            //DataTable ds = new DataTable();



            //    cardid = dr["Discount_In_Card_ID"].ToString();
            //    string SumOfPointsInactive = "select COALESCE(SUM(Discount_In_Points),0) as sum from discount_point_in_pos where Discound_In_Status='Inactive' and Discount_In_Activation_Date='" + getDate + "' and Discount_In_Card_ID='" + dr["Discount_In_Card_ID"].ToString() + "'";
            //    MySqlCommand SumOfPointsInactivecmd = new MySqlCommand(SumOfPointsInactive, BookShopManagement.Conn.ConnectionString);
            //    MySqlDataAdapter dt1 = new MySqlDataAdapter(SumOfPointsInactivecmd);
            //    DataTable ds1 = new DataTable();

            //    dt1.Fill(ds1);

            //    foreach (DataRow dr1 in ds1.Rows)
            //    {
            //        count++;
            //        string getCurrentpoints = "select DC_Current_Points from discount_card_pos where DC_Card_Number='" + dr["Discount_In_Card_ID"].ToString() + "'";
            //        MySqlCommand getCurrentpointscmd = new MySqlCommand(getCurrentpoints, BookShopManagement.Conn.ConnectionString);
            //        int currentpoints = Convert.ToInt32(getCurrentpointscmd.ExecuteScalar());
            //        CalculateupdatedCurrentPoints = currentpoints + Convert.ToInt32(dr1["sum"].ToString());






            //        //string UpdateCurrentPoint = "UPDATE `discount_card_pos` SET `DC_Current_Points` = '" + CalculateupdatedCurrentPoints.ToString() + "' WHERE `DC_Card_Number` = '" + dr["Discount_In_Card_ID"].ToString() + "' and DC_Current_Points='" + currentpoints.ToString()+ "'";
            //        //MySqlCommand UpdateCurrentPointcmd = new MySqlCommand(UpdateCurrentPoint, BookShopManagement.Conn.ConnectionString);
            //        //int UpdateCurrentPointres = UpdateCurrentPointcmd.ExecuteNonQuery();




            //        //break;

            //    }





            //    MySqlDataAdapter adapter = new MySqlDataAdapter();
            //    string sql = null;

            //    sql = "UPDATE `discount_card_pos` SET `DC_Current_Points` = '" + CalculateupdatedCurrentPoints.ToString() + "' WHERE `DC_Card_Number` = '" + dr["Discount_In_Card_ID"].ToString() + "'";


            //    MySqlCommand UpdateCurrentPointcmd = new MySqlCommand(sql, BookShopManagement.Conn.ConnectionString);
            //    int UpdateCurrentPointres = UpdateCurrentPointcmd.ExecuteNonQuery();
            //    if (UpdateCurrentPointres > 0)
            //    {

            //        //MessageBox.Show("Updated Record of Card " + ds.Rows[i].ItemArray[0].ToString());
            //        string updateactivestatus = "update discount_point_in_pos set Discound_In_Status='Activated' where Discound_In_Status='Inactive' and Discount_In_Activation_Date='" + getDate + "' and Discount_In_Card_ID='" + dr["Discount_In_Card_ID"].ToString() + "'";
            //        //MessageBox.Show("Update Actated Status  : " + updateactivestatus);
            //        MySqlCommand updateactivestatuscmd = new MySqlCommand(updateactivestatus, BookShopManagement.Conn.ConnectionString);
            //        int updateactivestatusres = updateactivestatuscmd.ExecuteNonQuery();
            //        if (updateactivestatusres > 0)
            //        {

            //            ressss = 1;
            //        }


            //    }



            //    //try
            //    //{
            //    //    adapter.UpdateCommand = BookShopManagement.Conn.ConnectionString.CreateCommand();
            //    //    adapter.UpdateCommand.CommandText = sql;
            //    //    adapter.UpdateCommand.ExecuteNonQuery();

            //    //}
            //    //catch (Exception ex)
            //    //{
            //    //    MessageBox.Show(ex.ToString());
            //    //}






            //}

            //if (ressss == 1)
            //{
            //    alert aa = new alert("Points Activated!", "All Users Discount Card Points Activated Of Date" + getDate, "success");

            //    aa.ShowDialog();
            //}

            //BookShopManagement.Conn.ConnectionString.Close();






            string getIDforRedeem = "select DISTINCT Discount_In_Card_ID from discount_point_in_pos where Discound_In_Status='Activated'";
            MySqlCommand getIDforRedeemcmd = new MySqlCommand(getIDforRedeem, BookShopManagement.Conn.ConnectionString);
            MySqlDataAdapter dtt = new MySqlDataAdapter(getIDforRedeemcmd);
            DataTable dss = new DataTable();

            dtt.Fill(dss);
        
           
            foreach (DataRow drrr in dss.Rows)
            {
               
                string getSumOfInPoints = "select COALESCE(SUM(Discount_In_Points),0) as sum from discount_point_in_pos where Discound_In_Status='Activated' and Discount_In_Card_ID='" + drrr["Discount_In_Card_ID"].ToString() + "'";
                MySqlCommand getSumOfInPointscmd = new MySqlCommand(getSumOfInPoints, BookShopManagement.Conn.ConnectionString);
                MySqlDataAdapter dtt1 = new MySqlDataAdapter(getSumOfInPointscmd);
                DataTable dss1 = new DataTable();

                dtt1.Fill(dss1);
                foreach (DataRow drrr1 in dss1.Rows)
                {

                    string getRedeempoints = "select COALESCE(SUM(Discount_Out_Redeem_Points),0) as sum from discount_point_out_pos where Disccount_Out_Card_ID='" + drrr["Discount_In_Card_ID"].ToString() + "'";
                    MySqlCommand getRedeempointscmd = new MySqlCommand(getRedeempoints, BookShopManagement.Conn.ConnectionString);
                    int getRedeempointsres = Convert.ToInt32(getRedeempointscmd.ExecuteScalar());
                    if (getRedeempointsres != 0)
                    {
                        int updateredeemtocurrent = Convert.ToInt32(drrr1["sum"].ToString()) - getRedeempointsres;

                        string updatecurrentpointsafterredeem = "update discount_card_pos set DC_Current_Points='" + updateredeemtocurrent.ToString() + "' where DC_Card_Number='" + drrr["Discount_In_Card_ID"].ToString() + "'";
                        MySqlCommand updatecurrentpointsafterredeemcmd = new MySqlCommand(updatecurrentpointsafterredeem, BookShopManagement.Conn.ConnectionString);
                        int updatecurrentpointsafterredeemres = updatecurrentpointsafterredeemcmd.ExecuteNonQuery();
                        if (updatecurrentpointsafterredeemres > 0)
                        {
                            //MessageBox.Show("Discound Card Id : " + drrr["Discount_In_Card_ID"].ToString() + " Sum : " + drrr1["sum"].ToString() + " REDEEEM : " + getRedeempointsres.ToString() + " REDEEMED POINT : " + updateredeemtocurrent.ToString());

                        }
                    }


                    
                }

              
            }
            string qq = "select b.Branch_Area from users_pos u join branches_pos b on u.User_Branch_ID=b.Branch_ID where User_ID='" + Retrieval.User_ID + "'";
            MySqlCommand cc = new MySqlCommand(qq, Conn.ConnectionString);
            string rr = cc.ExecuteScalar().ToString();

            BookShopManagement.Conn.ConnectionString.Close();


            
            
            user_label.Text = Retrieval.Emp_First_Name + " " + Retrieval.Emp_Last_Name + " ("+rr+" Branch)";
            if(Retrieval.role.ToString()=="1") {
                label7.Text = "Admin";
                userDash.Visible = false;
                dashboard_table.Visible = true;
            }
            else
            {
                label7.Text = "User";
                userDash.Visible = true;
                dashboard_table.Visible = false;
                ////Users_Btn.Visible = false;
                //Product_Brand_Btn.Dispose();
                //Product_Category_Btn.Dispose();
                //Product_Btn.Dispose();
                //Suppliers_Btn.Dispose();
                //Daily_Expense_Btn.Dispose();
                //Purchases_Btn.Dispose();
                //view_purchase_btn.Dispose();
                //Bank_Btn.Dispose();
                //Users_Btn.Dispose();
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                if (Retrieval.role.ToString() == "1")
                {
                    label7.Text = "Admin";
                    userDash.Visible = false;

                    button4.Text = "Stock Report";
                    loan.Text = "Loan Sales";
                    view_purchase_btn.Text = "View Purchases";
                    info.Text = "Branches/Accounts Info";
                    Users_Btn.Text = "Users";
                    Home_Btn.Text = "Home";
                    Product_Brand_Btn.Text = "Product Brands";
                    Product_Category_Btn.Text = "Product Categories";
                    Customers_Btn.Text = "Customers";
                    Sales_Btn.Text = "Sales";
                    Bank_Btn.Text = "Accounts";
                    Product_Btn.Text = "Products";
                    Suppliers_Btn.Text = "Suppliers";
                    Branches_Btn.Text = "Branches";
                    Discount_Card_Btn.Text = "Discount Cards";
                    Daily_Expense_Btn.Text = "Daily Expenses";
                    Purchases_Btn.Text = "Purchases";
                    View_Sales_Btn.Text = "View Sales";
                }
                else
                {
                    label7.Text = "User";

                    button5.Text = "Loan Sales";
                    button12.Text = "View Sales";
                    button13.Text = "Sales";
                    button2.Text = "Discount Cards";
                    button8.Text = "Home";
                    button3.Text = "Customers";



                    dashboard_table.Visible = false;
                    ////Users_Btn.Visible = false;
                    //Product_Brand_Btn.Dispose();
                    //Product_Category_Btn.Dispose();
                    //Product_Btn.Dispose();
                    //Suppliers_Btn.Dispose();
                    //Daily_Expense_Btn.Dispose();
                    //Purchases_Btn.Dispose();
                    //view_purchase_btn.Dispose();
                    //Bank_Btn.Dispose();
                    //Users_Btn.Dispose();
                }
                panelLeft.Width = panelLeft.Width + 229;
                if (panelLeft.Width >= PanelWidth)
                {

                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                button12.Text = "";
                button13.Text = "";
                button2.Text = "";
                button8.Text = "";
                button3.Text = "";
                button5.Text = "";



                button4.Text = "";
                loan.Text = "";
                view_purchase_btn.Text = "";
                info.Text = "";
                Users_Btn.Text = "";
                Home_Btn.Text = "";
                Product_Brand_Btn.Text = "";
                Product_Category_Btn.Text = "";
                Customers_Btn.Text = "";
                Sales_Btn.Text = "";
                Bank_Btn.Text = "";
                Product_Btn.Text = "";
                Suppliers_Btn.Text = "";
                Branches_Btn.Text = "";
                Discount_Card_Btn.Text = "";
                Daily_Expense_Btn.Text = "";
                Purchases_Btn.Text = "";
                View_Sales_Btn.Text = "";
                panelLeft.Width = panelLeft.Width - 229;
                if (panelLeft.Width <= 60)
                {
                    
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        int hh,mm;
        
        private void timerTime_Tick(object sender, EventArgs e)
        {
            
            
        }

        private void Logout_Btn_Click(object sender, EventArgs e)
        {
            confirmationForm cd = new confirmationForm("Logout", "Do You Really Want To Logout?");
                                    cd.ShowDialog();
                                    if (cd.r == "yes")
                                    {
                                        this.Dispose();
                                        Login login = new Login();
                                        login.ShowDialog();
                                    }

        }

        private void Home_Btn_Click(object sender, EventArgs e)
        {

            Users_Btn.BackColor = Color.FromArgb(225,27,45);
            Home_Btn.BackColor = Color.FromArgb(201,24,40);
            Product_Brand_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Category_Btn.BackColor = Color.FromArgb(225,27,45);
            Customers_Btn.BackColor = Color.FromArgb(225,27,45);
            Sales_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Bank_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Btn.BackColor = Color.FromArgb(225,27,45);
            Suppliers_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Branches_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225,27,45);
            Purchases_Btn.BackColor = Color.FromArgb(225,27,45);
            View_Sales_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            view_purchase_btn.BackColor = Color.FromArgb(225,27,45);
            info.BackColor = Color.FromArgb(225, 27, 45);
            loan.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);
            UC_Home UH = new UC_Home();
            AddControlsToPanel(UH);
            
        }

        public void aa()
        {
            Users_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Home_Btn.BackColor = Color.FromArgb(201, 24, 40);
            Product_Brand_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Product_Category_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Customers_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Sales_Btn.BackColor = Color.FromArgb(225, 27, 45); ;
            Bank_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Product_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Suppliers_Btn.BackColor = Color.FromArgb(225, 27, 45); ;
            Branches_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Purchases_Btn.BackColor = Color.FromArgb(225, 27, 45);
            View_Sales_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225, 27, 45);
            view_purchase_btn.BackColor = Color.FromArgb(225, 27, 45);
            info.BackColor = Color.FromArgb(225, 27, 45);
            loan.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);
        }
        
        private void Users_Btn_Click(object sender, EventArgs e)
        {
            Users_Btn.BackColor = Color.FromArgb(201,24,40);
            Home_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Brand_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Category_Btn.BackColor = Color.FromArgb(225,27,45);
            Customers_Btn.BackColor = Color.FromArgb(225,27,45);
            Sales_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Bank_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Btn.BackColor = Color.FromArgb(225,27,45);
            Suppliers_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Branches_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225,27,45);
            Purchases_Btn.BackColor = Color.FromArgb(225,27,45);
            View_Sales_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            view_purchase_btn.BackColor = Color.FromArgb(225,27,45);
            info.BackColor = Color.FromArgb(225, 27, 45);
            loan.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);
            UC_Users UU = new UC_Users();
            AddControlsToPanel(UU);
        }

        private void Product_Brand_Btn_Click(object sender, EventArgs e)
        {
            Users_Btn.BackColor = Color.FromArgb(225,27,45);
            Home_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Brand_Btn.BackColor = Color.FromArgb(201,24,40);
            Product_Category_Btn.BackColor = Color.FromArgb(225,27,45);
            Customers_Btn.BackColor = Color.FromArgb(225,27,45);
            Sales_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Bank_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Btn.BackColor = Color.FromArgb(225,27,45);
            Suppliers_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Branches_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225,27,45);
            Purchases_Btn.BackColor = Color.FromArgb(225,27,45);
            View_Sales_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            view_purchase_btn.BackColor = Color.FromArgb(225,27,45);
            loan.BackColor = Color.FromArgb(225, 27, 45);
            info.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);
            UC_Product_Brand UPB = new UC_Product_Brand();
            AddControlsToPanel(UPB);
        }

        private void Product_Category_Btn_Click(object sender, EventArgs e)
        {
            Users_Btn.BackColor = Color.FromArgb(225,27,45);
            Home_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Brand_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Category_Btn.BackColor = Color.FromArgb(201,24,40);
            Customers_Btn.BackColor = Color.FromArgb(225,27,45);
            Sales_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Bank_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Btn.BackColor = Color.FromArgb(225,27,45);
            Suppliers_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Branches_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225,27,45);
            Purchases_Btn.BackColor = Color.FromArgb(225,27,45);
            View_Sales_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            view_purchase_btn.BackColor = Color.FromArgb(225,27,45);
            loan.BackColor = Color.FromArgb(225, 27, 45);
            info.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);
            UC_Product_Category UPC = new UC_Product_Category();
            AddControlsToPanel(UPC);
        }

        private void Product_Btn_Click(object sender, EventArgs e)
        {
            Users_Btn.BackColor = Color.FromArgb(225,27,45);
            Home_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Brand_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Category_Btn.BackColor = Color.FromArgb(225,27,45);
            Customers_Btn.BackColor = Color.FromArgb(225,27,45);
            Sales_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Bank_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Btn.BackColor = Color.FromArgb(201,24,40);
            Suppliers_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Branches_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225,27,45);
            Purchases_Btn.BackColor = Color.FromArgb(225,27,45);
            View_Sales_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            view_purchase_btn.BackColor = Color.FromArgb(225,27,45);
            loan.BackColor = Color.FromArgb(225, 27, 45);
            info.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);
            UC_Products UP = new UC_Products();
            AddControlsToPanel(UP);
        }

        private void Branches_Btn_Click(object sender, EventArgs e)
        {
            Users_Btn.BackColor = Color.FromArgb(225,27,45);
            Home_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Brand_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Category_Btn.BackColor = Color.FromArgb(225,27,45);
            Customers_Btn.BackColor = Color.FromArgb(225,27,45);
            Sales_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Bank_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Btn.BackColor = Color.FromArgb(225,27,45);
            Suppliers_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Branches_Btn.BackColor = Color.FromArgb(201,24,40);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225,27,45);
            Purchases_Btn.BackColor = Color.FromArgb(225,27,45);
            View_Sales_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            loan.BackColor = Color.FromArgb(225, 27, 45);
            info.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);
            UC_Branches UB = new UC_Branches();
            AddControlsToPanel(UB);
        }

        private void Suppliers_Btn_Click(object sender, EventArgs e)
        {
            Users_Btn.BackColor = Color.FromArgb(225,27,45);
            Home_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Brand_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Category_Btn.BackColor = Color.FromArgb(225,27,45);
            Customers_Btn.BackColor = Color.FromArgb(225,27,45);
            Sales_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Bank_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Btn.BackColor = Color.FromArgb(225,27,45);
            Suppliers_Btn.BackColor = Color.FromArgb(201,24,40); ;
            Branches_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225,27,45);
            Purchases_Btn.BackColor = Color.FromArgb(225,27,45);
            View_Sales_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            view_purchase_btn.BackColor = Color.FromArgb(225,27,45);
            loan.BackColor = Color.FromArgb(225, 27, 45);
            info.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);
            UC_Suppliers US = new UC_Suppliers();
            AddControlsToPanel(US);
        }

        private void Customers_Btn_Click(object sender, EventArgs e)
        {
            Users_Btn.BackColor = Color.FromArgb(225,27,45);
            Home_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Brand_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Category_Btn.BackColor = Color.FromArgb(225,27,45);
            Customers_Btn.BackColor = Color.FromArgb(201,24,40);
            Sales_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Bank_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Btn.BackColor = Color.FromArgb(225,27,45);
            Suppliers_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Branches_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225,27,45);
            Purchases_Btn.BackColor = Color.FromArgb(225,27,45);
            View_Sales_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            view_purchase_btn.BackColor = Color.FromArgb(225,27,45);
            loan.BackColor = Color.FromArgb(225, 27, 45);
            info.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);
            UC_Customers UC = new UC_Customers();
            AddControlsToPanel(UC);
        }

        private void Discount_Card_Btn_Click(object sender, EventArgs e)
        {
            Users_Btn.BackColor = Color.FromArgb(225,27,45);
            Home_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Brand_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Category_Btn.BackColor = Color.FromArgb(225,27,45);
            Customers_Btn.BackColor = Color.FromArgb(225,27,45);
            Sales_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Bank_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Btn.BackColor = Color.FromArgb(225,27,45);
            Suppliers_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Branches_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225,27,45);
            Purchases_Btn.BackColor = Color.FromArgb(225,27,45);
            View_Sales_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(201,24,40);
            loan.BackColor = Color.FromArgb(225, 27, 45);
            info.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);
            UC_Discount_Cards UDC = new UC_Discount_Cards();
            AddControlsToPanel(UDC);
        }

        private void Daily_Expense_Btn_Click(object sender, EventArgs e)
        {
            Users_Btn.BackColor = Color.FromArgb(225,27,45);
            Home_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Brand_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Category_Btn.BackColor = Color.FromArgb(225,27,45);
            Customers_Btn.BackColor = Color.FromArgb(225,27,45);
            Sales_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Bank_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Btn.BackColor = Color.FromArgb(225,27,45);
            Suppliers_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Branches_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(201,24,40);
            Purchases_Btn.BackColor = Color.FromArgb(225,27,45);
            View_Sales_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            view_purchase_btn.BackColor = Color.FromArgb(225,27,45);
            loan.BackColor = Color.FromArgb(225, 27, 45);
            info.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);
            UC_Daily_Expenses UDE = new UC_Daily_Expenses();
            AddControlsToPanel(UDE);
        }

        private void Purchases_Btn_Click(object sender, EventArgs e)
        {
            Users_Btn.BackColor = Color.FromArgb(225,27,45);
            Home_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Brand_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Category_Btn.BackColor = Color.FromArgb(225,27,45);
            Customers_Btn.BackColor = Color.FromArgb(225,27,45);
            Sales_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Bank_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Btn.BackColor = Color.FromArgb(225,27,45);
            Suppliers_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Branches_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225,27,45);
            Purchases_Btn.BackColor = Color.FromArgb(201,24,40);
            View_Sales_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            loan.BackColor = Color.FromArgb(225, 27, 45);
            info.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);
            UC_Purchases UPP = new UC_Purchases();
            AddControlsToPanel(UPP);
        }

        private void Sales_Btn_Click(object sender, EventArgs e)
        {
            Users_Btn.BackColor = Color.FromArgb(225,27,45);
            Home_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Brand_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Category_Btn.BackColor = Color.FromArgb(225,27,45);
            Customers_Btn.BackColor = Color.FromArgb(225,27,45);
            Sales_Btn.BackColor = Color.FromArgb(201,24,40); ;
            Bank_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Btn.BackColor = Color.FromArgb(225,27,45);
            Suppliers_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Branches_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225,27,45);
            Purchases_Btn.BackColor = Color.FromArgb(225,27,45);
            View_Sales_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            view_purchase_btn.BackColor = Color.FromArgb(225,27,45);
            loan.BackColor = Color.FromArgb(225, 27, 45);
            info.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);
            Sales_Form USS = new Sales_Form();
            AddControlsToPanel(USS);
        }

        private void View_Sales_Btn_Click(object sender, EventArgs e)
        {
            Users_Btn.BackColor = Color.FromArgb(225,27,45);
            Home_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Brand_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Category_Btn.BackColor = Color.FromArgb(225,27,45);
            Customers_Btn.BackColor = Color.FromArgb(225,27,45);
            Sales_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Bank_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Btn.BackColor = Color.FromArgb(225,27,45);
            Suppliers_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Branches_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225,27,45);
            Purchases_Btn.BackColor = Color.FromArgb(225,27,45);
            View_Sales_Btn.BackColor = Color.FromArgb(201,24,40);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            view_purchase_btn.BackColor = Color.FromArgb(225,27,45);
            loan.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);
            info.BackColor = Color.FromArgb(225, 27, 45);
            ShowSale ss = new ShowSale();
            AddControlsToPanel(ss);
        }

        private void Transaction_In_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Transaction_Out_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Bank_Btn_Click(object sender, EventArgs e)
        {
            Users_Btn.BackColor = Color.FromArgb(225,27,45);
            Home_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Brand_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Category_Btn.BackColor = Color.FromArgb(225,27,45);
            Customers_Btn.BackColor = Color.FromArgb(225,27,45);
            Sales_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Bank_Btn.BackColor = Color.FromArgb(201,24,40);
            Product_Btn.BackColor = Color.FromArgb(225,27,45);
            Suppliers_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Branches_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225,27,45);
            Purchases_Btn.BackColor = Color.FromArgb(225,27,45);
            View_Sales_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            view_purchase_btn.BackColor = Color.FromArgb(225,27,45);
            loan.BackColor = Color.FromArgb(225, 27, 45);
            info.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);
            UC_Banks UBF = new UC_Banks();
            AddControlsToPanel(UBF);
        }

        private void Menu_Btn_Click(object sender, EventArgs e)
        {
            isCollapsed = true;
        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            info.BackColor = Color.FromArgb(225, 27, 45);
            view_purchase_btn.BackColor = Color.FromArgb(201,24,40);
            Users_Btn.BackColor = Color.FromArgb(225,27,45);
            Home_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Brand_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Category_Btn.BackColor = Color.FromArgb(225,27,45);
            Customers_Btn.BackColor = Color.FromArgb(225,27,45);
            Sales_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Bank_Btn.BackColor = Color.FromArgb(225,27,45);
            Product_Btn.BackColor = Color.FromArgb(225,27,45);
            Suppliers_Btn.BackColor = Color.FromArgb(225,27,45); ;
            Branches_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225,27,45);
            Purchases_Btn.BackColor = Color.FromArgb(225,27,45);
            View_Sales_Btn.BackColor = Color.FromArgb(225,27,45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225,27,45);
            loan.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);
            UC_PurchaseView UPP = new UC_PurchaseView();
            AddControlsToPanel(UPP);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //var info = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
            //DateTimeOffset localServerTime = DateTimeOffset.Now;

            //DateTime startDate = DateTime.Parse(TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy"));
            //DateTime expiryDate = startDate.AddDays(3);
            //MessageBox.Show(expiryDate.ToString("dd-MMMM-yyyy"));
        }

        private void button1_Click_2(object sender, EventArgs e)
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromArgb(225, 27, 45);
            button13.BackColor = Color.FromArgb(225, 27, 45);
            button2.BackColor = Color.FromArgb(225, 27, 45);
            button8.BackColor = Color.FromArgb(225, 27, 45);
            button3.BackColor = Color.FromArgb(201, 24, 40);
            button5.BackColor = Color.FromArgb(225, 27, 45);
            UC_Customers UC = new UC_Customers();
            AddControlsToPanel(UC);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromArgb(225, 27, 45);
            button13.BackColor = Color.FromArgb(225, 27, 45);
            button2.BackColor = Color.FromArgb(225, 27, 45);
            button8.BackColor = Color.FromArgb(201, 24, 40);
            button3.BackColor = Color.FromArgb(225, 27, 45);
            button5.BackColor = Color.FromArgb(225, 27, 45);
            UC_Home UH = new UC_Home();
            AddControlsToPanel(UH);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromArgb(225, 27, 45);
            button13.BackColor = Color.FromArgb(225, 27, 45);
            button2.BackColor = Color.FromArgb(201, 24, 40);
            button8.BackColor = Color.FromArgb(225, 27, 45);
            button3.BackColor = Color.FromArgb(225, 27, 45);
            button5.BackColor = Color.FromArgb(225, 27, 45);
            UC_Discount_Cards UDC = new UC_Discount_Cards();
            AddControlsToPanel(UDC);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromArgb(225, 27, 45);
            button13.BackColor = Color.FromArgb(201, 24, 40);
            button2.BackColor = Color.FromArgb(225, 27, 45);
            button8.BackColor = Color.FromArgb(225, 27, 45);
            button3.BackColor = Color.FromArgb(225, 27, 45);
            button5.BackColor = Color.FromArgb(225, 27, 45);
            Sales_Form USS = new Sales_Form();
            AddControlsToPanel(USS);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromArgb(201, 24, 40);
            button13.BackColor = Color.FromArgb(225, 27, 45);
            button2.BackColor = Color.FromArgb(225, 27, 45);
            button8.BackColor = Color.FromArgb(225, 27, 45);
            button3.BackColor = Color.FromArgb(225, 27, 45);
            button5.BackColor = Color.FromArgb(225, 27, 45);
            ShowSale ss = new ShowSale();
            AddControlsToPanel(ss);
        }

        private void userDash_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void info_Click(object sender, EventArgs e)
        {
            view_purchase_btn.BackColor = Color.FromArgb(225, 27, 45);
            info.BackColor = Color.FromArgb(201, 24, 40);
            Users_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Home_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Product_Brand_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Product_Category_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Customers_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Sales_Btn.BackColor = Color.FromArgb(225, 27, 45); ;
            Bank_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Product_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Suppliers_Btn.BackColor = Color.FromArgb(225, 27, 45); ;
            Branches_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Purchases_Btn.BackColor = Color.FromArgb(225, 27, 45);
            View_Sales_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225, 27, 45);
            loan.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);
            BranchInfo UPP = new BranchInfo();
            AddControlsToPanel(UPP);
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
      
            button13.BackColor = Color.FromArgb(225, 27, 45);
            button12.BackColor = Color.FromArgb(225, 27, 45);
            button2.BackColor = Color.FromArgb(225, 27, 45);
            button8.BackColor = Color.FromArgb(225, 27, 45);
            button3.BackColor = Color.FromArgb(225, 27, 45);
            button5.BackColor = Color.FromArgb(225, 27, 45);
            calculator ss = new calculator();
            ss.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calculator cc = new calculator();
            cc.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            calculator cc = new calculator();
            cc.ShowDialog();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(51, 51, 51);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(38,38,38);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            sticknote ss = new sticknote(); 
            ss.ShowDialog();
        }

        private void loan_Click(object sender, EventArgs e)
        {
            loan.BackColor = Color.FromArgb(201, 24, 40);
            view_purchase_btn.BackColor = Color.FromArgb(225, 27, 45);
            info.BackColor = Color.FromArgb(225, 27, 45);
            Users_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Home_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Product_Brand_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Product_Category_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Customers_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Sales_Btn.BackColor = Color.FromArgb(225, 27, 45); ;
            Bank_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Product_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Suppliers_Btn.BackColor = Color.FromArgb(225, 27, 45); ;
            Branches_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Purchases_Btn.BackColor = Color.FromArgb(225, 27, 45);
            View_Sales_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);
            Credit UPP = new Credit();
            AddControlsToPanel(UPP);
        }

        public void ll()
        {

            loan.BackColor = Color.FromArgb(201, 24, 40);
            view_purchase_btn.BackColor = Color.FromArgb(225, 27, 45);
            info.BackColor = Color.FromArgb(225, 27, 45);
            Users_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Home_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Product_Brand_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Product_Category_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Customers_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Sales_Btn.BackColor = Color.FromArgb(225, 27, 45); ;
            Bank_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Product_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Suppliers_Btn.BackColor = Color.FromArgb(225, 27, 45); ;
            Branches_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Purchases_Btn.BackColor = Color.FromArgb(225, 27, 45);
            View_Sales_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225, 27, 45);
            button4.BackColor = Color.FromArgb(225, 27, 45);
            Credit UPP = new Credit();
            AddControlsToPanel(UPP);
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(225, 27, 45);
            loan.BackColor = Color.FromArgb(225, 27, 45);
            view_purchase_btn.BackColor = Color.FromArgb(225, 27, 45);
            info.BackColor = Color.FromArgb(225, 27, 45);
            Users_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Home_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Product_Brand_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Product_Category_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Customers_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Sales_Btn.BackColor = Color.FromArgb(225, 27, 45); ;
            Bank_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Product_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Suppliers_Btn.BackColor = Color.FromArgb(225, 27, 45); ;
            Branches_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Daily_Expense_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Purchases_Btn.BackColor = Color.FromArgb(225, 27, 45);
            View_Sales_Btn.BackColor = Color.FromArgb(225, 27, 45);
            Discount_Card_Btn.BackColor = Color.FromArgb(225, 27, 45);
            murghe UPP = new murghe();
            UPP.ShowDialog();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var info = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
            DateTimeOffset localServerTime = DateTimeOffset.Now;
            timeee.Text = "fafa";

            int hours = Convert.ToInt32(TimeZoneInfo.ConvertTime(localServerTime, info).ToString("hh"));
            int mins = Convert.ToInt32(TimeZoneInfo.ConvertTime(localServerTime, info).ToString("mm"));
            int sec = Convert.ToInt32(TimeZoneInfo.ConvertTime(localServerTime, info).ToString("ss"));
            if (sec > 59)
            {
                mins = mins + 1;
            }
            if (mins > 59)
            {
                hours = hours + 1;
            }
            timeee.Text = TimeZoneInfo.ConvertTime(localServerTime, info).ToString("📆 dd-MMMM-yyyy    🕐 " + hours.ToString() + ":" + mins.ToString() + ":ss tt");
            //MessageBox.Show(TimeZoneInfo.ConvertTime(localServerTime, info).ToString("📆 dd-MMMM-yyyy    🕐 " + hours.ToString() + ":0" + mins.ToString() + ":ss tt"));
            if (mins.ToString().Length == 1)
            {
                timeee.Text = TimeZoneInfo.ConvertTime(localServerTime, info).ToString("📆 dd-MMMM-yyyy    🕐 " + hours.ToString() + ":0" + mins.ToString() + ":ss tt");

            }


            if (hours.ToString().Length == 1)
            {
                timeee.Text = TimeZoneInfo.ConvertTime(localServerTime, info).ToString("📆 dd-MMMM-yyyy    🕐 0" + hours.ToString() + ":" + mins.ToString() + ":ss tt");
            }

            if (mins.ToString().Length == 1 && hours.ToString().Length == 1)
            {
                timeee.Text = TimeZoneInfo.ConvertTime(localServerTime, info).ToString("📆 dd-MMMM-yyyy    🕐 0" + hours.ToString() + ":0" + mins.ToString() + ":ss tt");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.FromArgb(225, 27, 45);
            button5.BackColor = Color.FromArgb(201, 24, 40);
            button12.BackColor = Color.FromArgb(225, 27, 45);
            button2.BackColor = Color.FromArgb(225, 27, 45);
            button8.BackColor = Color.FromArgb(225, 27, 45);
            button3.BackColor = Color.FromArgb(225, 27, 45);
            Credit pl = new Credit();
            AddControlsToPanel(pl);
        }
    }
}
