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
using System.Net;

namespace BookShopManagement.UserControls
{
    public partial class BranchInfo : UserControl
    {
        public BranchInfo()
        {
            InitializeComponent();
            info_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            info_dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            info_dgv.DefaultCellStyle.ForeColor = Color.Black;
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q = "select branch.Branch_Area as 'Branch Area',branch.Branch_Head as 'Branch Head',o.Order_Total_Price as 'Sale Amount',pd.PD_Product_Total_Price as 'Purchase Amount' from branches_pos branch join users_pos userr on userr.User_Branch_ID=branch.Branch_ID join sale_order o on userr.User_ID=o.Order_DoneBy join purchase_pos p on p.Purchase_Done_By=userr.User_ID join purchase_details_pos pd on pd.PD_Purchase_ID=p.Purchase_ID where branch.Branch_Status='Active' group by branch.Branch_Area";
            MySqlCommand cmd = new MySqlCommand(q, Conn.ConnectionString);
            Conn.ConnectionString.Close();
            Conn.ConnectionString.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            info_dgv.DataSource = dt;
            Conn.ConnectionString.Close();
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
        private void info_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string q = "SELECT it.Transaction_In_Payment_Method as 'Payment Method',it.Transaction_In_Amount as 'Amount',it.Transaction_In_Date as 'Date',it.Transaction_In_Sale_ID as 'Sale ID',b.Bank_Name as 'Bank Name',bd.Bank_Branch as 'Branch Name',bd.Bank_Acc_Number as 'Account Number',bd.Bank_Acc_Name as 'Account Name' FROM `transactions_in_pos` it join bank_details_pos bd on it.Transaction_In_Account_ID=bd.Bank_Details_ID join banks_pos b on bd.Bank_Name_ID=b.Bank_ID";
            MySqlCommand cmd = new MySqlCommand(q, Conn.ConnectionString);
            Conn.ConnectionString.Close();
            Conn.ConnectionString.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            info_dgv.DataSource = dt;
            Conn.ConnectionString.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string q = "SELECT ot.Transaction_Out_Payment_Method as 'Payment Method',ot.Transaction_Out_Amount as 'Amount',ot.Transaction_Out_Date as 'Date',ot.Transaction_Purchase_ID as 'Purchase ID',b.Bank_Name as 'Bank Name',bd.Bank_Branch as 'Bank Branch',bd.Bank_Acc_Number as 'Account Number',bd.Bank_Acc_Name as 'Account Name' FROM `transactions_out_pos` ot join bank_details_pos bd on ot.Transaction_Out_Account_ID=bd.Bank_Details_ID join banks_pos b on bd.Bank_Name_ID=b.Bank_ID";
            MySqlCommand cmd = new MySqlCommand(q, Conn.ConnectionString);
            Conn.ConnectionString.Close();
            Conn.ConnectionString.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            info_dgv.DataSource = dt;
            Conn.ConnectionString.Close();
        }
    }
}
