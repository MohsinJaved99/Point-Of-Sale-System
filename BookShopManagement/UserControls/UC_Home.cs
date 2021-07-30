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
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            if (CheckForInternetConnection().ToString() == "True")
            {
                InitializeComponent();
            }
            else
            {
                alert aa = new alert("Error!", "Please Connect Your Internet.", "error");
                aa.ShowDialog();
            }
            if (Retrieval.role.ToString() == "1")
            {
                button2.Visible = true;
                button1.Visible = true;
                panel28.Visible = false;
                panel27.Visible = true;
                panel14.Visible = true;
                panel30.Visible = false;

            }
            else
            {
                button2.Visible = false;
                button1.Visible = false;
                panel27.Visible = false;
                panel28.Visible = true;
                panel14.Visible = false;
                panel30.Visible = true;

                //panel13.Location=new Point(309,417);
                label2.Text = "Your Sales and Purchase Overview";
            }
        }
        Random rand = new Random();

        public void LoadChart(string year)
        {
            var cnv = new Bunifu.DataViz.Canvas();
            var dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_splineArea);
            string getjansale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Jan%' and Order_Date like '%" + year + "%'";
            MySqlCommand jansalecmd=new MySqlCommand(getjansale,Conn.ConnectionString);
            BookShopManagement.Conn.ConnectionString.Open();
            string jan=jansalecmd.ExecuteScalar().ToString();


            string getfabsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Feb%' and Order_Date like '%" + year + "%'";
            MySqlCommand fabsalecmd=new MySqlCommand(getfabsale,Conn.ConnectionString);
            string fab=fabsalecmd.ExecuteScalar().ToString();


            string getmarsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Mar%' and Order_Date like '%" + year + "%'";
            MySqlCommand marsalecmd=new MySqlCommand(getmarsale,Conn.ConnectionString);
            string mar=marsalecmd.ExecuteScalar().ToString();

            string getaprsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Apr%' and Order_Date like '%"+year+"%'";
            MySqlCommand aprsalecmd=new MySqlCommand(getaprsale,Conn.ConnectionString);
            string apr=aprsalecmd.ExecuteScalar().ToString();

            string getmaysale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%May%' and Order_Date like '%" + year + "%'";
            MySqlCommand maysalecmd=new MySqlCommand(getmaysale,Conn.ConnectionString);
            string may=maysalecmd.ExecuteScalar().ToString();


            string getjunsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Jun%' and Order_Date like '%" + year + "%'";
            MySqlCommand juansalecmd=new MySqlCommand(getjunsale,Conn.ConnectionString);
            string jun=juansalecmd.ExecuteScalar().ToString();


            string getjulsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Jul%' and Order_Date like '%" + year + "%'";
            MySqlCommand julsalecmd=new MySqlCommand(getjulsale,Conn.ConnectionString);
            string jul=julsalecmd.ExecuteScalar().ToString();


            string getaugsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Aug%' and Order_Date like '%" + year + "%'";
            MySqlCommand augsalecmd=new MySqlCommand(getaugsale,Conn.ConnectionString);
            string aug=augsalecmd.ExecuteScalar().ToString();


            string getsepsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Sep%' and Order_Date like '%" + year + "%'";
            MySqlCommand sepsalecmd=new MySqlCommand(getsepsale,Conn.ConnectionString);
            string sep=sepsalecmd.ExecuteScalar().ToString();


            string getoctsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Oct%' and Order_Date like '%" + year + "%'";
            MySqlCommand octsalecmd=new MySqlCommand(getoctsale,Conn.ConnectionString);
            string oct=octsalecmd.ExecuteScalar().ToString();


            string getnovsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Nov%' and Order_Date like '%" + year + "%'";
            MySqlCommand novjansalecmd=new MySqlCommand(getnovsale,Conn.ConnectionString);
            string nov=novjansalecmd.ExecuteScalar().ToString();


            string getdecsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Dec%' and Order_Date like '%" + year + "%'";
            MySqlCommand decsalecmd=new MySqlCommand(getdecsale,Conn.ConnectionString);
            string dec=decsalecmd.ExecuteScalar().ToString();
            BookShopManagement.Conn.ConnectionString.Close();



            dataPoint.addLabely("Jan",jan);
            dataPoint.addLabely("Feb", fab);
            dataPoint.addLabely("Mar", mar);
            dataPoint.addLabely("Apr", apr);
            dataPoint.addLabely("May", may);
            dataPoint.addLabely("Jun", jun);
            dataPoint.addLabely("Jul", jul);
            dataPoint.addLabely("Aug", aug);
            dataPoint.addLabely("Sep", sep);
            dataPoint.addLabely("Oct", oct);
            dataPoint.addLabely("Nov", nov);
            dataPoint.addLabely("Dec", dec);

            cnv.addData(dataPoint);
            bunifuDataViz2.colorSet.Add(Color.Red);
            bunifuDataViz2.ForeColor = Color.Black;
            bunifuDataViz2.Render(cnv);
            
        }

        public void LoadChartUser(string year)
        {
            var cnv = new Bunifu.DataViz.Canvas();
            var dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_splineArea);
            string getjansale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Jan%' and Order_Date like '%" + year + "%' and Order_DoneBy='"+Retrieval.User_ID+"'";
            MySqlCommand jansalecmd = new MySqlCommand(getjansale, Conn.ConnectionString);
            BookShopManagement.Conn.ConnectionString.Open();
            string jan = jansalecmd.ExecuteScalar().ToString();


            string getfabsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Feb%' and Order_Date like '%" + year + "%' and Order_DoneBy='" + Retrieval.User_ID + "'";
            MySqlCommand fabsalecmd = new MySqlCommand(getfabsale, Conn.ConnectionString);
            string fab = fabsalecmd.ExecuteScalar().ToString();


            string getmarsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Mar%' and Order_Date like '%" + year + "%' and Order_DoneBy='" + Retrieval.User_ID + "'";
            MySqlCommand marsalecmd = new MySqlCommand(getmarsale, Conn.ConnectionString);
            string mar = marsalecmd.ExecuteScalar().ToString();

            string getaprsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Apr%' and Order_Date like '%" + year + "%' and Order_DoneBy='" + Retrieval.User_ID + "'";
            MySqlCommand aprsalecmd = new MySqlCommand(getaprsale, Conn.ConnectionString);
            string apr = aprsalecmd.ExecuteScalar().ToString();

            string getmaysale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%May%' and Order_Date like '%" + year + "%' and Order_DoneBy='" + Retrieval.User_ID + "'";
            MySqlCommand maysalecmd = new MySqlCommand(getmaysale, Conn.ConnectionString);
            string may = maysalecmd.ExecuteScalar().ToString();


            string getjunsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Jun%' and Order_Date like '%" + year + "%' and Order_DoneBy='" + Retrieval.User_ID + "'";
            MySqlCommand juansalecmd = new MySqlCommand(getjunsale, Conn.ConnectionString);
            string jun = juansalecmd.ExecuteScalar().ToString();


            string getjulsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Jul%' and Order_Date like '%" + year + "%' and Order_DoneBy='" + Retrieval.User_ID + "'";
            MySqlCommand julsalecmd = new MySqlCommand(getjulsale, Conn.ConnectionString);
            string jul = julsalecmd.ExecuteScalar().ToString();


            string getaugsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Aug%' and Order_Date like '%" + year + "%' and Order_DoneBy='" + Retrieval.User_ID + "'";
            MySqlCommand augsalecmd = new MySqlCommand(getaugsale, Conn.ConnectionString);
            string aug = augsalecmd.ExecuteScalar().ToString();


            string getsepsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Sep%' and Order_Date like '%" + year + "%' and Order_DoneBy='" + Retrieval.User_ID + "'";
            MySqlCommand sepsalecmd = new MySqlCommand(getsepsale, Conn.ConnectionString);
            string sep = sepsalecmd.ExecuteScalar().ToString();


            string getoctsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Oct%' and Order_Date like '%" + year + "%' and Order_DoneBy='" + Retrieval.User_ID + "'";
            MySqlCommand octsalecmd = new MySqlCommand(getoctsale, Conn.ConnectionString);
            string oct = octsalecmd.ExecuteScalar().ToString();


            string getnovsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Nov%' and Order_Date like '%" + year + "%' and Order_DoneBy='" + Retrieval.User_ID + "'";
            MySqlCommand novjansalecmd = new MySqlCommand(getnovsale, Conn.ConnectionString);
            string nov = novjansalecmd.ExecuteScalar().ToString();


            string getdecsale = "select COALESCE(sum(Order_Total_Price), 0) from sale_order where Order_Date like '%Dec%' and Order_Date like '%" + year + "%' and Order_DoneBy='" + Retrieval.User_ID + "'";
            MySqlCommand decsalecmd = new MySqlCommand(getdecsale, Conn.ConnectionString);
            string dec = decsalecmd.ExecuteScalar().ToString();
            BookShopManagement.Conn.ConnectionString.Close();



            dataPoint.addLabely("Jan", jan);
            dataPoint.addLabely("Feb", fab);
            dataPoint.addLabely("Mar", mar);
            dataPoint.addLabely("Apr", apr);
            dataPoint.addLabely("May", may);
            dataPoint.addLabely("Jun", jun);
            dataPoint.addLabely("Jul", jul);
            dataPoint.addLabely("Aug", aug);
            dataPoint.addLabely("Sep", sep);
            dataPoint.addLabely("Oct", oct);
            dataPoint.addLabely("Nov", nov);
            dataPoint.addLabely("Dec", dec);

            cnv.addData(dataPoint);
            bunifuDataViz2.colorSet.Add(Color.Red);
            bunifuDataViz2.ForeColor = Color.Black;
            bunifuDataViz2.Render(cnv);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadChart(yearr.Text);
            loadingg.Visible = false;
        }
        int a = 0;
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
        private void UC_Home_Load(object sender, EventArgs e)
        {

         
            Cursor.Current = Cursors.WaitCursor;
            
            for (int i = 2020; i < 2030; i++)
            {
                yearr.Items.Add(i.ToString());
            }
            
            yearr.Text = DateTime.Now.Year.ToString();




            BookShopManagement.Conn.ConnectionString.Open();
           

            string query = "select count(*) from customers_pos";

            MySqlCommand cmd = new MySqlCommand(query, BookShopManagement.Conn.ConnectionString);
           
            int count =Convert.ToInt32(cmd.ExecuteScalar());

            customer_count.Text = count.ToString();

            string query1 = "select sum(PD_Product_Quantity) IS NOT NULL from purchase_details_pos";

            MySqlCommand cmd1 = new MySqlCommand(query1, BookShopManagement.Conn.ConnectionString);


            int count1 = Convert.ToInt32(cmd1.ExecuteScalar());

            label5.Text = count1.ToString();

            //string query2 = "select count(*) from sale_order";

            //MySqlCommand cmd2 = new MySqlCommand(query2, BookShopManagement.Conn.ConnectionString);


            //int count2 = Convert.ToInt32(cmd2.ExecuteScalar());
            //label4.Text = count2.ToString();



            string query3 = "select sum(Sale_Product_Quantity) IS NOT NULL from sale_product";

            MySqlCommand cmd3 = new MySqlCommand(query3, BookShopManagement.Conn.ConnectionString);


            int count3 = Convert.ToInt32(cmd3.ExecuteScalar());
            label21.Text = count3.ToString();


            string query4 = "select count(*) from suppliers_pos";

            MySqlCommand cmd4 = new MySqlCommand(query4, BookShopManagement.Conn.ConnectionString);


            int count4 = Convert.ToInt32(cmd4.ExecuteScalar());
            label14.Text = count4.ToString();





            string query6 = "select count(*) from products_pos";

            MySqlCommand cmd6 = new MySqlCommand(query6, BookShopManagement.Conn.ConnectionString);


            int count6 = Convert.ToInt32(cmd6.ExecuteScalar());
            label17.Text = count6.ToString();




            string query5 = "select count(*) from users_pos where User_Role_ID=2";

            MySqlCommand cmd5 = new MySqlCommand(query5, BookShopManagement.Conn.ConnectionString);


            int count5 = Convert.ToInt32(cmd5.ExecuteScalar());
            label16.Text = count5.ToString();




            if (Retrieval.role.ToString() == "2")
            {


                string getsaleamountt = "select if(sum(Order_Total_Price) IS NOT NULL,sum(Order_Total_Price),0) from sale_order where Order_DoneBy='" + Retrieval.User_ID + "'";
                string getpurchasee = "select if(sum(pd.PD_Product_Total_Price) IS NOT NULL,sum(pd.PD_Product_Total_Price),0) from purchase_details_pos pd join purchase_pos p on pd.PD_Purchase_ID=p.Purchase_ID join users_pos u on p.Purchase_Done_By=u.User_ID where u.User_ID='" + Retrieval.User_ID + "'";

                BookShopManagement.Conn.ConnectionString.Close();
                BookShopManagement.Conn.ConnectionString.Open();
                MySqlCommand gsaa = new MySqlCommand(getsaleamountt, Conn.ConnectionString);
                MySqlCommand gpp = new MySqlCommand(getpurchasee, Conn.ConnectionString);
         
                double sale_amountt = Convert.ToDouble(gsaa.ExecuteScalar().ToString());
                double purchase_amountt = Convert.ToDouble(gpp.ExecuteScalar().ToString());
           
                //if (sale_amountt.ToString() != "0" || purchase_amountt.ToString() != "0")
                //{
                //    double ttttt = purchase_amountt;

                //    double tta = sale_amountt - ttttt;

                //    double percntt = tta / sale_amountt * 100;

                //    if (percntt > 0)
                //    {
                //        if (percntt.ToString().Contains("-"))
                //        {
                //            bunifuCircleProgressbar1.Value = 0;
                //        }
                //        else
                //        {
                //            bunifuCircleProgressbar1.Value = Convert.ToInt32(percntt);
                //        }
                //    }

                //    if (percntt.ToString().Contains("-"))
                //    {
                //        bunifuCircleProgressbar1.Value = 0;
                //    }
               

                //usertotalsaleamount.Text = sale_amountt.ToString() + " Rs";
                //usertotalpurchaseamount.Text = purchase_amountt.ToString() + " Rs";
                //userprofit.Text = tta.ToString() + " Rs";
                //if (tta.ToString().Contains("-"))
                //{
                //    userprofit.ForeColor = Color.Maroon;
                //}

                //}
                //else
                //{
                //    bunifuCircleProgressbar1.Value = 0;
                //}


                string queryy = "SELECT if(sum(sp.Sale_Product_Quantity) IS NOT NULL,sum(sp.Sale_Product_Quantity),0) FROM `sale_product` sp join sale_order o on sp.Sale_Order_ID=o.Order_ID join users_pos u on u.User_ID=o.Order_DoneBy where u.User_ID='" + Retrieval.User_ID + "'";

                MySqlCommand cmdd = new MySqlCommand(queryy, BookShopManagement.Conn.ConnectionString);


                int countt = Convert.ToInt32(cmdd.ExecuteScalar());
                usersaleproducts.Text = countt.ToString();




                string queryyy = "SELECT if(sum(pd.PD_Product_Quantity) IS NOT NULL,sum(pd.PD_Product_Quantity),0) FROM `purchase_details_pos` pd join purchase_pos p on p.Purchase_ID=pd.PD_Purchase_ID join users_pos u on p.Purchase_Done_By=u.User_ID where u.User_ID='" + Retrieval.User_ID + "'";

                MySqlCommand cmddd = new MySqlCommand(queryyy, BookShopManagement.Conn.ConnectionString);


                int counttt = Convert.ToInt32(cmddd.ExecuteScalar());
                userpurchaseproducts.Text = counttt.ToString();

                string query6t = "select count(*) from products_pos";

                MySqlCommand cmd6t = new MySqlCommand(query6t, BookShopManagement.Conn.ConnectionString);


                int count6t = Convert.ToInt32(cmd6t.ExecuteScalar());
                usertotalproducts.Text = count6t.ToString();
            }



            BookShopManagement.Conn.ConnectionString.Close();


            Cursor.Current = Cursors.Arrow;

        }
        int countt = 0;
        private void UC_Home_MouseEnter(object sender, EventArgs e)
        {
            countt++;
            if (countt == 1) {

                if (Retrieval.role.ToString() == "1")
                {
                    LoadChart(yearr.Text);
                    loadingg.Visible = false;
                }
                else
                {
                    LoadChartUser(yearr.Text);
                    loadingg.Visible = false;
                }
            }
            
            
        }

        private void bunifuDataViz1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tsa_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label8_MouseUp(object sender, MouseEventArgs e)
        {
        
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            LoadChart(yearr.Text);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            backup b = new backup();
            b.ShowDialog();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void yearr_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChart(yearr.Text);
        }

        private void yearr_TextChanged(object sender, EventArgs e)
        {
            LoadChart(yearr.Text);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        int cc,ccc;
        private void panel28_MouseEnter(object sender, EventArgs e)
        {
            cc++;
            if (cc == 1)
            {
                LoadChartUser(yearr.Text);
                loadingg.Visible = false;
            }
            
        }

        private void panel27_MouseEnter(object sender, EventArgs e)
        {
            ccc++;
            if (ccc == 1)
            {
                LoadChart(yearr.Text);
                loadingg.Visible = false;
            }
        }

        private void loadingg_Click(object sender, EventArgs e)
        {

        }

        private void usertotalsaleamount_Click(object sender, EventArgs e)
        {

        }

        private void panel32_Paint(object sender, PaintEventArgs e)
        {

        }
        double tt;
        private void clear_btn_Click(object sender, EventArgs e)
        {
            string getsaleamount = "select if(sum(Order_Total_Price) IS NOT NULL,sum(Order_Total_Price),0) from sale_order WHERE (Order_Date BETWEEN '" + from.Text + "' AND '" + to.Text + "')";
            string getpurchase = "select if(sum(pd.PD_Product_Total_Price) IS NOT NULL,sum(pd.PD_Product_Total_Price),0) from purchase_details_pos pd join purchase_pos p ON pd.PD_Purchase_ID=p.Purchase_ID WHERE (p.Purchase_Date BETWEEN '" + from.Text + "' AND '" + to.Text + "')";
            string getexp = "select if(sum(Expense_Amount) IS NOT NULL,sum(Expense_Amount),0) from daily_expense_pos WHERE (Expense_Date BETWEEN '" + from.Text + "' AND '" + to.Text + "')";
            BookShopManagement.Conn.ConnectionString.Close();
            BookShopManagement.Conn.ConnectionString.Open();
            MySqlCommand gsa = new MySqlCommand(getsaleamount, Conn.ConnectionString);
            MySqlCommand gp = new MySqlCommand(getpurchase, Conn.ConnectionString);
            MySqlCommand ge = new MySqlCommand(getexp, Conn.ConnectionString);
            double sale_amount = Convert.ToDouble(gsa.ExecuteScalar().ToString());
            double purchase_amount = Convert.ToDouble(gp.ExecuteScalar().ToString());
            double daily_expense = Convert.ToDouble(ge.ExecuteScalar().ToString());

          
            if (sale_amount.ToString() != "0" || purchase_amount.ToString() != "0")
            {
                double tttt = purchase_amount + daily_expense;

                double tt = sale_amount - tttt;

                double percnt = tt / sale_amount * 100;

                if (percnt > 0)
                {
                    if (percnt.ToString().Contains("-"))
                    {
                        bunifuCircleProgressbar2.Value = 0;
                    }
                    else
                    {
                        bunifuCircleProgressbar2.Value = Convert.ToInt32(percnt);
                    }
                }

                if (percnt.ToString().Contains("-"))
                {
                    bunifuCircleProgressbar2.Value = 0;
                }

               

                tsa.Text = sale_amount.ToString() + " Rs";
                tpa.Text = purchase_amount.ToString() + " Rs";
                label19.Text = tt.ToString() + " Rs";
                if (tt.ToString().Contains("-"))
                {
                    label19.ForeColor = Color.Maroon;
                }

            }
            else
            {
               
                double ttttt = purchase_amount + daily_expense;
              
                double tta = sale_amount - ttttt;
                tsa.Text = sale_amount.ToString() + " Rs";
                tpa.Text = ttttt + " Rs";
                label19.Text = tta.ToString() + " Rs";

                //MessageBox.Show(sale_amount.ToString() + " || " + ttttt);
                if (tta.ToString() == "0" || tta.ToString().Contains("-"))
                {
                    bunifuCircleProgressbar2.Value = 0;
                }
            }

            BookShopManagement.Conn.ConnectionString.Close();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CompanyWorth cw = new CompanyWorth();
            cw.ShowDialog();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void panel30_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string getsaleamount = "select if(sum(Order_Total_Price) IS NOT NULL,sum(Order_Total_Price),0) from sale_order WHERE (Order_Date BETWEEN '" + f.Text + "' AND '" + t.Text + "') and Order_DoneBy='"+Retrieval.User_ID+"'";
            MySqlCommand cc = new MySqlCommand(getsaleamount, Conn.ConnectionString);
            Conn.ConnectionString.Close();
            Conn.ConnectionString.Open();
            
            usertotalsaleamount.Text = cc.ExecuteScalar().ToString() +" Rs";
            Conn.ConnectionString.Close();
        }
    }

}