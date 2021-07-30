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
    public partial class UC_Suppliers : UserControl
    {

        Conn con = new Conn();
        string supplierID;
        public UC_Suppliers()
        {
            InitializeComponent();
            Supplier_View();
            //suppliers_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            //suppliers_dgv.DefaultCellStyle.ForeColor = Color.Black;

            suppliers_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            suppliers_dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            suppliers_dgv.DefaultCellStyle.ForeColor = Color.Black;
        }

        public void Supplier_View()
        {
            try
            { 
                string Query = "select * from suppliers_view_pos;";

                MySqlCommand MyCommand2 = new MySqlCommand(Query, Conn.ConnectionString);
                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                Supplier_ID1.DataPropertyName = dTable.Columns["Supplier_ID"].ToString();
                Supplier_Company1.DataPropertyName = dTable.Columns["Supplier Company"].ToString();
                Supplier_Contact_Person1.DataPropertyName = dTable.Columns["Supplier Contact Person"].ToString();
                Supplier_Number1.DataPropertyName = dTable.Columns["Supplier Phone"].ToString();
                Supplier_Address1.DataPropertyName = dTable.Columns["Supplier Address"].ToString();
                Supplier_CNIC1.DataPropertyName = dTable.Columns["Supplier CNIC"].ToString();
                Supplier_Entry_Date1.DataPropertyName = dTable.Columns["Supplier Entry Date"].ToString();
                Supplier_Status.DataPropertyName = dTable.Columns["Supplier Status"].ToString();

                suppliers_dgv.DataSource = dTable;

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

        public void Suppliers_View_With(string search_txt)
        {
            try
            {
                string query = "select Supplier_ID as 'Supplier_ID',Supplier_Company as 'Company Name',Supplier_Contact_Person as 'Contact Person', Supplier_Phone as 'Phone', Supplier_Address as 'Address', Supplier_CNIC as 'CNIC', Supplier_Entry_Date as 'Entry Date', if(Supplier_Status=0,'Active','Inactive') as 'Status' from suppliers_pos where Supplier_Company like '%" + search_txt + "%' or Supplier_Contact_Person like '" + search_txt + "%' or Supplier_Phone like '" + search_txt + "%' or Supplier_CNIC like '" + search_txt + "%' or Supplier_Address like '" + search_txt + "%'";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, BookShopManagement.Conn.ConnectionString);
                DataTable dTable = new DataTable();
                BookShopManagement.Conn.ConnectionString.Open();
                dataadapter.Fill(dTable);
                BookShopManagement.Conn.ConnectionString.Close();
                Supplier_ID1.DataPropertyName = dTable.Columns["Supplier_ID"].ToString();
                Supplier_Company1.DataPropertyName = dTable.Columns["Company Name"].ToString();
                Supplier_Contact_Person1.DataPropertyName = dTable.Columns["Contact Person"].ToString();
                Supplier_Number1.DataPropertyName = dTable.Columns["Phone"].ToString();
                Supplier_Address1.DataPropertyName = dTable.Columns["Address"].ToString();
                Supplier_CNIC1.DataPropertyName = dTable.Columns["CNIC"].ToString();
                Supplier_Entry_Date1.DataPropertyName = dTable.Columns["Entry Date"].ToString();
                Supplier_Status.DataPropertyName = dTable.Columns["Status"].ToString();

                suppliers_dgv.DataSource = dTable;

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

        private string Delete_Supplier()
        {
            MySqlCommand cmd = new MySqlCommand("Update `suppliers_pos` set Supplier_Status=1 WHERE `suppliers_pos`.`Supplier_ID` = @supplierID", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@supplierID", supplierID);

            if (Conn.ConnectionString.State != ConnectionState.Open)
            {
                Conn.ConnectionString.Open();
            }

            int i = cmd.ExecuteNonQuery();

            if (Conn.ConnectionString.State == ConnectionState.Open)
            {
                Conn.ConnectionString.Close();
            }

            if (i > 0)
            {
                return "Supplier Inactivate Successfully.";
            }
            else
            {
                return "Data Not Deleted From System Successfully";
            }
        }

        private void add_supplier_btn_Click(object sender, EventArgs e)
        {
            using (Supplier_Form SF = new Supplier_Form())
            {
                SF.ShowDialog();
                Supplier_View();
            }
        }

        private void edit_supplier_btn_Click(object sender, EventArgs e)
        {
            if (supplierID != null && supplierID != "")
            {
                using (Supplier_Form SF = new Supplier_Form(supplierID))
                {
                    SF.ShowDialog();
                    Supplier_View();
                    supplierID = "";
                }
            }
            else
            {
                alert aa = new alert("Info!", "Please Select A Row You Want To Edit", "info");
                aa.ShowDialog();
            }
        }

        private void delete_supplier_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (supplierID != null && supplierID != "")
                {
                    string msg = Delete_Supplier();
                    alert aa = new alert("Deleted!", msg, "success");
                    aa.ShowDialog();
                    Supplier_View();
                }
                else
                {
                    alert aa = new alert("Info!", "Please Select A Row You Want To Delete", "info");
                    aa.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                alert aa = new alert("Error!", "You Can't Delete This Record Because This Supplier Exists Somewhere.", "error");
                aa.ShowDialog();

            }
        }

        private void suppliers_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in suppliers_dgv.SelectedRows)
            {
                supplierID = row.Cells[0].Value.ToString();
            }
        }

        private void search_box_txt_TextChanged(object sender, EventArgs e)
        {
            Suppliers_View_With(search_box_txt.Text.ToString());
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
        private void suppliers_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void suppliers_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < suppliers_dgv.Rows.Count; i++)
            {

                String status = suppliers_dgv.Rows[i].Cells[7].Value.ToString();


                if (status == "InActive")
                {
                    DataGridViewRow row = suppliers_dgv.Rows[i];// get you required index
                    // check the cell value under your specific column and then you can toggle your colors
                    row.DefaultCellStyle.BackColor = Color.FromArgb(245, 17, 17);
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 0, 0);
                    row.DefaultCellStyle.SelectionForeColor = Color.White;
                }

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
