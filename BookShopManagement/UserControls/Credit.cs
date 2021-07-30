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
    public partial class Credit : UserControl
    {
        public Credit()
        {
            InitializeComponent();
            credit_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            credit_dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            credit_dgv.DefaultCellStyle.ForeColor = Color.Black;
            
            load();
        }
        string orderID, creditid;
        public void load()
        {
            string setdata = "SELECT cr.Credit_Order_ID as 'Order ID',cr.Credit_Sale_ID as 'Credit ID',o.Order_Type as 'Type',cr.Credit_Date as 'Loan Date',cr.Paying_Date as 'Estimated Paying Date',c.Customer_Name as 'Customer Name',c.Customer_NIC as 'Customer NIC',c.Customer_Phone as 'Customer Contact',cr.Credit_Amount as 'Loan Amount' FROM `credit_sale` cr join sale_order o on cr.Credit_Order_ID=o.Order_ID join sale_product sp on sp.Sale_Order_ID=o.Order_ID join customers_pos c on c.Customer_ID=cr.Credit_Customer_ID";
            MySqlCommand cmd = new MySqlCommand(setdata, Conn.ConnectionString);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            credit_dgv.DataSource = dt;
            credit_dgv.Columns[0].Visible = false;
            credit_dgv.Columns[1].Visible = false;
            credit_dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colorrow();
           
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
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
        private void credit_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void colorrow()
        {
            //var info = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
            //DateTimeOffset localServerTime = DateTimeOffset.Now;
            //String getDate = TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy");
            //for (int i = 0; i < credit_dgv.Rows.Count; i++)
            //{

            //    String status = credit_dgv.Rows[i].Cells[3].Value.ToString();
            //    if (status == getDate)
            //    {
            //        credit_dgv.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(245, 17, 17);
            //        credit_dgv.Rows[i].DefaultCellStyle.ForeColor = Color.White;
            //        credit_dgv.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 0, 0);
            //        credit_dgv.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
            //    }
            //}
        }
        private void Credit_Load(object sender, EventArgs e)
        {
            
          
            //foreach (DataGridViewRow Myrow in credit_dgv.Rows)
            //{
            //    if (Myrow.Cells[3].Value.ToString() == getDate)
            //    {

            //        Myrow.DefaultCellStyle.ForeColor = Color.Red;
                
            //    }
            //    //if (Myrow.Cells[2].Value.ToString() == DateTime.Now.ToString("dd-MMMM-yyyy"))
            //    //{
            //    //    MessageBox.Show("agaga");
            //    //    MessageBox.Show(Myrow.Cells[2].Value.ToString());
            //    //}
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void credit_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            foreach (DataGridViewRow row in credit_dgv.SelectedRows)
            {
                orderID = row.Cells[0].Value.ToString();
                creditid = row.Cells[1].Value.ToString();
            }
        }

        private void search_box_txt_TextChanged(object sender, EventArgs e)
        {
            string setdata = "SELECT cr.Credit_Order_ID as 'Order ID',cr.Credit_Sale_ID as 'Credit ID',o.Order_Type as 'Type',cr.Credit_Date as 'Loan Date',cr.Paying_Date as 'Estimated Paying Date',c.Customer_Name as 'Customer Name',c.Customer_NIC as 'Customer NIC',c.Customer_Phone as 'Customer Contact',cr.Credit_Amount as 'Loan Amount' FROM `credit_sale` cr join sale_order o on cr.Credit_Order_ID=o.Order_ID join sale_product sp on sp.Sale_Order_ID=o.Order_ID join customers_pos c on c.Customer_ID=cr.Credit_Customer_ID where Paying_Date like '" + search_box_txt.Text + "%' or Customer_NIC like '" + search_box_txt.Text + "%' or Customer_Name like '" + search_box_txt.Text + "%'";
            MySqlCommand cmd = new MySqlCommand(setdata, Conn.ConnectionString);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            credit_dgv.DataSource = dt;
            credit_dgv.Columns[0].Visible = false;
            credit_dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void delete_product_btn_Click(object sender, EventArgs e)
        {
            if (creditid != null && creditid != "")
            {
                using (payingloan bf = new payingloan(creditid))
                {
                    bf.ShowDialog();
                    load();
                    creditid = "";
                }
            }
            else
            {
                alert aa = new alert("Info!", "Please Select A Row.", "info");
                aa.ShowDialog();
            }
        }

        private void credit_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            var info = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
            DateTimeOffset localServerTime = DateTimeOffset.Now;
            String getDate = TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy");
            for (int i = 0; i < credit_dgv.Rows.Count; i++)
            {

                String status = credit_dgv.Rows[i].Cells[4].Value.ToString();
                
                DateTime d1 = Convert.ToDateTime(status);
                DateTime d2 = Convert.ToDateTime(getDate);
                string days = (d2 - d1).TotalDays.ToString();
                
                if (status == getDate)
                {
                    DataGridViewRow row = credit_dgv.Rows[i];// get you required index
                    // check the cell value under your specific column and then you can toggle your colors
                    row.DefaultCellStyle.BackColor = Color.FromArgb(245, 17, 17);
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 0, 0);
                    row.DefaultCellStyle.SelectionForeColor = Color.White;
                }
                else if (Convert.ToInt32(days)>0)
                {
                    DataGridViewRow row = credit_dgv.Rows[i];// get you required index
                    // check the cell value under your specific column and then you can toggle your colors
                    row.DefaultCellStyle.BackColor = Color.FromArgb(245, 17, 17);
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 0, 0);
                    row.DefaultCellStyle.SelectionForeColor = Color.White;
                }
            }

           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (orderID != null && orderID != "")
            {
                using (ShowOrderProductDetails bf = new ShowOrderProductDetails(orderID))
                {
                    bf.ShowDialog();
                    load();
                    orderID = "";
                }
            }
            else
            {
                alert aa = new alert("Info!", "Please Select A Row.", "info");
                aa.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (creditid != null && creditid != "")
            {
                using (partiallyloan bf = new partiallyloan(creditid))
                {
                    bf.ShowDialog();
                    load();
                    creditid = "";
                }
            }
            else
            {
                alert aa = new alert("Info!", "Please Select A Row.", "info");
                aa.ShowDialog();
            }
        }
    }
}
