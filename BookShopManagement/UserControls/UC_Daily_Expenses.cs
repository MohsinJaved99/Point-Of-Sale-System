using BookShopManagement.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace BookShopManagement.UserControls
{
    public partial class UC_Daily_Expenses : UserControl
    {
        Conn con = new Conn();
        string expenseID;

        public UC_Daily_Expenses()
        {
            InitializeComponent();
            Daily_Expense_View();

            expense_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            expense_dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            expense_dgv.DefaultCellStyle.ForeColor = Color.Black;


            //expense_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            //expense_dgv.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void Daily_Expense_View()
        {
            try
            { 
                string Query = "Select Expense_ID AS `Expense ID`, Expense_Purpose AS `Expense Purpose`, Expense_Amount AS `Expense Amount`, Expense_Date AS `Expense Date` from daily_expense_pos;";

                MySqlCommand MyCommand2 = new MySqlCommand(Query, Conn.ConnectionString);
                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                Expense_ID.DataPropertyName = dTable.Columns["Expense ID"].ToString();
                Expense_Purpose.DataPropertyName = dTable.Columns["Expense Purpose"].ToString();
                Expense_Amount.DataPropertyName = dTable.Columns["Expense Amount"].ToString();
                Expense_Date.DataPropertyName = dTable.Columns["Expense Date"].ToString();
                expense_dgv.Columns["Expense_Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 

                expense_dgv.DataSource = dTable;

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

        public void Daily_Expense_View_With(string search_txt)
        {
            try
            {
                string query = "SELECT `Expense_Purpose` as 'Expense Purpose', `Expense_Amount` as 'Expense Amount', `Expense_Date` as 'Expense Date' FROM `daily_expense_pos` where Expense_Purpose like '%"+search_txt+"%'";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, BookShopManagement.Conn.ConnectionString);
                DataTable dTable = new DataTable();
                BookShopManagement.Conn.ConnectionString.Open();
                dataadapter.Fill(dTable);
                BookShopManagement.Conn.ConnectionString.Close();

                expense_dgv.DataSource = dTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string Delete_Expense()
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `daily_expense_pos` WHERE `daily_expense_pos`.`Expense_ID` = @expenseID", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@expenseID", expenseID);

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
                return "Data Deleted From System Successfully";
            }
            else
            {
                return "Data Not Deleted From System Successfully";
            }
        }

        //private void add_expense_btn_Click(object sender, EventArgs e)
        //{
        //    using (Expense_Form ef = new Expense_Form())
        //    {
        //        ef.ShowDialog();
        //        Daily_Expense_View();
        //    }
        //}

        //private void edit_expense_btn_Click(object sender, EventArgs e)
        //{
        //    if (expenseID != null && expenseID != "")
        //    {
        //        using (Daily_Expense_Form ef = new Daily_Expense_Form(expenseID))
        //        {
        //            ef.ShowDialog();
        //            Daily_Expense_View();
        //            expenseID = "";
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please Select Row");
        //    }
        //}

        //private void delete_expense_btn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (expenseID != null && expenseID != "")
        //        {
        //            string msg = Delete_Expense();
        //            MessageBox.Show(msg);
        //            Daily_Expense_View();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please Select Row");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //}

        private void search_box_txt_TextChanged(object sender, EventArgs e)
        {
            Daily_Expense_View_With(search_box_txt.Text.ToString());
        }

        private void expense_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in expense_dgv.SelectedRows)
            {
                expenseID = row.Cells[0].Value.ToString();
            }
        }

        private void add_expense_btn_Click_1(object sender, EventArgs e)
        {
            using (Daily_Expense_Form ef = new Daily_Expense_Form())
            {
                ef.ShowDialog();
                Daily_Expense_View();
            }
        }

        private void edit_expense_btn_Click_1(object sender, EventArgs e)
        {
            if (expenseID != null && expenseID != "")
            {
                using (Daily_Expense_Form ef = new Daily_Expense_Form(expenseID))
                {
                    ef.ShowDialog();
                    Daily_Expense_View();
                    expenseID = "";
                }
            }
            else
            {
                alert aa = new alert("Info!", "Please Select A Row You Want To Edit", "info");
                aa.ShowDialog();
            }
        }

        private void delete_expense_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (expenseID != null && expenseID != "")
                {
                    string msg = Delete_Expense();
                    alert aa = new alert("Deleted!", msg, "success");
                    aa.ShowDialog();
                    Daily_Expense_View();
                }
                else
                {
                    alert aa = new alert("Info!", "Please Select A Row You Want To Delete", "info");
                    aa.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                alert aa = new alert("Information", ex.Message.ToString(), "info");
                aa.ShowDialog();

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
        private void expense_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void expense_dgv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in expense_dgv.SelectedRows)
            {
                expenseID = row.Cells[0].Value.ToString();
            }
        }

        private void search_box_txt_TextChanged_1(object sender, EventArgs e)
        {
            Daily_Expense_View_With(search_box_txt.Text.ToString());
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
