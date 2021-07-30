using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.Forms;
using MySql.Data.MySqlClient;
using System.Net;

namespace BookShopManagement.UserControls
{
    public partial class UC_Discount_Cards : UserControl
    {
        public UC_Discount_Cards()
        {
            InitializeComponent();
            //discountcard_dvg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            //discountcard_dvg.DefaultCellStyle.ForeColor = Color.Black;

            discountcard_dvg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            discountcard_dvg.DefaultCellStyle.SelectionForeColor = Color.Black;
            discountcard_dvg.DefaultCellStyle.ForeColor = Color.Black;
            showData();
        }

        string dcID, cusID;
        private void showData()
        {
            string query = "select d.DC_Card_Number as 'Card Number',c.Customer_NIC as 'Customer NIC',c.Customer_Name as 'Customer Name',d.DC_Current_Points as 'Current Points',d.DC_Start_Date as 'Card Start Date' from discount_card_pos d join customers_pos c on d.DC_Customer_ID=c.Customer_ID";

            MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, BookShopManagement.Conn.ConnectionString);
            DataTable dTable = new DataTable();
            dataadapter.Fill(dTable);
            discountcard_dvg.DataSource = dTable;
        }
        private void btnAddNewBranch_Click(object sender, EventArgs e)
        {
            //using (Discount_Card_Form anb = new Discount_Card_Form())
            //{
            //    anb.ShowDialog();
            //}
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
        private void discountcard_dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void discountcard_dvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in discountcard_dvg.SelectedRows)
            {
                dcID = row.Cells[0].Value.ToString();
                cusID = row.Cells[1].Value.ToString();
            }
        }

        private void add_product_btn_Click(object sender, EventArgs e)
        {
            if (dcID != "" || dcID != null)
            {
                ShowAddedPoints sap = new ShowAddedPoints(dcID);
                sap.ShowDialog();
            }
            else {
                alert aa = new alert("Info!", "Please Select A Row.", "info");
                aa.ShowDialog();
            }

        }

        private void edit_product_btn_Click(object sender, EventArgs e)
        {
            if (dcID != "" || dcID != null)
            {
            ShowRedeemPoints sap = new ShowRedeemPoints(dcID);
            sap.ShowDialog();
            }
            else {
                alert aa = new alert("Info!", "Please Select A Row.", "info");
                aa.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cusID != "" || cusID != null)
            {
                PrintDiscountCard aa = new PrintDiscountCard(cusID);
                aa.ShowDialog();
            }
            else
            {
                alert aa = new alert("Info!", "Please Select A Row.", "info");
                aa.ShowDialog();
            }

            //if (cusID != "" || cusID != null)
            //{
            //    PrintDC aa = new PrintDC(cusID);
            //    aa.ShowDialog();
            //}
            //else
            //{
            //    alert aa = new alert("Info!", "Please Select A Row.", "info");
            //    aa.ShowDialog();
            //}
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != "" || textBox7.Text != null)
            {
                string query = "select d.DC_Card_Number as 'Card Number',c.Customer_NIC as 'Customer NIC',c.Customer_Name as 'Customer Name',d.DC_Current_Points as 'Current Points',d.DC_Start_Date as 'Card Start Date' from discount_card_pos d join customers_pos c on d.DC_Customer_ID=c.Customer_ID where d.DC_Card_Number like '" + textBox7.Text + "%' or c.Customer_Name like '" + textBox7.Text + "%' or d.DC_Start_Date like '" + textBox7.Text + "%'";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, BookShopManagement.Conn.ConnectionString);
                DataTable dTable = new DataTable();
                dataadapter.Fill(dTable);
                discountcard_dvg.DataSource = dTable;
            }
            else
            {
                showData();
            }
        }
    }
}
