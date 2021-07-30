using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class CompanyWorth : Form
    {
        public CompanyWorth()
        {
            InitializeComponent();
        }

        private void CompanyWorth_Load(object sender, EventArgs e)
        {
            string getbanktotal = "select if(sum(Bank_Acc_Balance) IS NOT NULL,sum(Bank_Acc_Balance),0) from bank_details_pos";
            MySqlCommand gbt = new MySqlCommand(getbanktotal,Conn.ConnectionString);
            Conn.ConnectionString.Close();
            Conn.ConnectionString.Open();


            label1.Text = gbt.ExecuteScalar().ToString() + " Rs";




            string sumofbranch = "select if(sum(Order_Total_Price) IS NOT NULL,sum(Order_Total_Price) ,0) from sale_order";
            MySqlCommand cmd = new MySqlCommand(sumofbranch, Conn.ConnectionString);

            label2.Text = cmd.ExecuteScalar().ToString() + " Rs";


            string getpricequa = "SELECT if(sum(Product_Comission_Price*Product_Quantity) IS NOT NULL,sum(Product_Comission_Price*Product_Quantity),0) FROM `products_pos`";
            MySqlCommand cmd1 = new MySqlCommand(getpricequa, Conn.ConnectionString);

            label3.Text = cmd1.ExecuteScalar().ToString() + " Rs";


            Int64 total = Convert.ToInt64(gbt.ExecuteScalar().ToString()) + Convert.ToInt64(cmd.ExecuteScalar().ToString()) + Convert.ToInt64(cmd1.ExecuteScalar().ToString());

            label5.Text = total.ToString() + " Rs";



            string recv = "select if(sum(Credit_Amount) IS NOT NULL,sum(Credit_Amount) ,0) from credit_sale";
            MySqlCommand cmd22 = new MySqlCommand(recv, Conn.ConnectionString);

            label6.Text = cmd22.ExecuteScalar().ToString() + " Rs";


            Conn.ConnectionString.Close();

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
