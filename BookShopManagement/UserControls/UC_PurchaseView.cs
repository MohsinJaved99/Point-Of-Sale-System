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
    public partial class UC_PurchaseView : UserControl
    {
        public UC_PurchaseView()
        {
            InitializeComponent();
            ViewPurchase();
            //purchase_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            //purchase_dgv.DefaultCellStyle.ForeColor = Color.Black;


            purchase_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            purchase_dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            purchase_dgv.DefaultCellStyle.ForeColor = Color.Black;

        }
        string purID,supID,date;
        private void ViewPurchase()
        {
            try
            {
                string Query = "select p.Purchase_ID as 'Purchase ID',p.Purchase_Date as 'Purchase Date',p.Purchase_Supplier_ID as 'Supplier ID',s.Supplier_Company as 'Company',s.Supplier_Contact_Person as 'Supplier Name',s.Supplier_Phone as 'Supplier Contact' , CONCAT(u.User_First_Name,' ',u.User_Last_Name) as 'Name' from purchase_pos p join suppliers_pos s on p.Purchase_Supplier_ID=s.Supplier_ID join users_pos u on u.User_ID=p.Purchase_Done_By GROUP BY p.Purchase_Date,p.Purchase_Supplier_ID";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, Conn.ConnectionString);

                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                Purchase_ID.DataPropertyName = dTable.Columns["Purchase ID"].ToString();
                Purchase_Date.DataPropertyName = dTable.Columns["Purchase Date"].ToString();
                Purchase_By.DataPropertyName = dTable.Columns["Name"].ToString();
                Purchase_SupplierCompany.DataPropertyName = dTable.Columns["Company"].ToString();
                Purchase_SupplierName.DataPropertyName = dTable.Columns["Supplier Name"].ToString();
                Supplier_Contact.DataPropertyName = dTable.Columns["Supplier Contact"].ToString();
                Supplier_ID.DataPropertyName = dTable.Columns["Supplier ID"].ToString();

             
               
                purchase_dgv.DataSource = dTable;
                if (Conn.ConnectionString.State == ConnectionState.Open)
                {
                    Conn.ConnectionString.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        private void purchase_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_box_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "select p.Purchase_ID as 'Purchase ID',p.Purchase_Date as 'Purchase Date',p.Purchase_Supplier_ID as 'Supplier ID',s.Supplier_Company as 'Company',s.Supplier_Contact_Person as 'Supplier Name',s.Supplier_Phone as 'Supplier Contact' , CONCAT(u.User_First_Name,' ',u.User_Last_Name) as 'Name' from purchase_pos p join suppliers_pos s on p.Purchase_Supplier_ID=s.Supplier_ID join users_pos u on u.User_ID=p.Purchase_Done_By where p.`Purchase_Done_By` like '" + search_box_txt.Text + "%' or s.`Supplier_Company` like '" + search_box_txt.Text + "%' or s.`Supplier_Contact_Person` like '" + search_box_txt.Text + "%' or p.`Purchase_Date` like '" + search_box_txt.Text + "%'  GROUP BY p.Purchase_Date,p.Purchase_Supplier_ID";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, Conn.ConnectionString);

                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                Purchase_ID.DataPropertyName = dTable.Columns["Purchase ID"].ToString();
                Purchase_Date.DataPropertyName = dTable.Columns["Purchase Date"].ToString();
                Purchase_By.DataPropertyName = dTable.Columns["Name"].ToString();
                Purchase_SupplierCompany.DataPropertyName = dTable.Columns["Company"].ToString();
                Purchase_SupplierName.DataPropertyName = dTable.Columns["Supplier Name"].ToString();
                Supplier_Contact.DataPropertyName = dTable.Columns["Supplier Contact"].ToString();
                Supplier_ID.DataPropertyName = dTable.Columns["Supplier ID"].ToString();
                purchase_dgv.DataSource = dTable;
                if (Conn.ConnectionString.State == ConnectionState.Open)
                {
                    Conn.ConnectionString.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Delete_Purchase()
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `purchase_details_pos` WHERE `PD_Purchase_ID` = @purrID", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@purrID", purID);

            Conn.ConnectionString.Open();

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                MySqlCommand cmd1 = new MySqlCommand("DELETE FROM `purchase_pos` WHERE `Purchase_ID` = @purrID", Conn.ConnectionString);
                cmd1.Parameters.AddWithValue("@purrID", purID);
                int i1 = cmd1.ExecuteNonQuery();
                if (i1 > 0)
                {
                    alert aa = new alert("Deleted!", "Data Delete From System Successfully", "success");
                    aa.ShowDialog();
                }
                else
                {
                    alert aa = new alert("Error!", "Failed To Delete", "error");
                    aa.ShowDialog();
                }
            }
            else
            {
                alert aa = new alert("Failed!", "Failed Process", "error");
                aa.ShowDialog();
            }

            Conn.ConnectionString.Close();
           
        }


        private void delete_customer_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (purID != null && purID != "")
                {
                    Delete_Purchase();
                    ViewPurchase();
                }
                else
                {
                    alert aa = new alert("Info!", "Please Select A Row You Want To Edit","info");
                    aa.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                alert aa = new alert("Information", ex.Message.ToString(), "info");
                aa.ShowDialog();

            }
        }

        private void purchase_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in purchase_dgv.SelectedRows)
            {
                purID = row.Cells[0].Value.ToString();
                supID = row.Cells[2].Value.ToString();
                date = row.Cells[1].Value.ToString();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void edit_customer_btn_Click(object sender, EventArgs e)
        {
            if (supID != null && supID != "" && date != null && date != "")
            {

            using (Show_Purchase_Products bf = new Show_Purchase_Products(supID, date))
            {
                bf.ShowDialog();
                ViewPurchase();
                supID = "";
                date = "";

            }
            }
            else
            {
                alert aa = new alert("Info!", "Please Select A Purchase.", "info");
                aa.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            loading l = new loading();
            l.ShowDialog();
            if (supID != null && supID != "" && date != null && date != "")
            {

                using (Purchase_Report bf = new Purchase_Report(supID, date))
                    {
                        bf.ShowDialog();
                        ViewPurchase();
                        supID = "";
                        date = "";

                    }
              



            }
            else
            {
                alert aa = new alert("Info!", "Please Select A Purchase.", "info");
                aa.ShowDialog();
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salesreports s = new salesreports();
            s.type = "purchase";
            s.ShowDialog();
        }
    }
}
