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
    public partial class UC_Banks : UserControl
    {
        Conn con = new Conn();
        string bankID;

        public UC_Banks()
        {
            InitializeComponent();
            Bank_View();
            banks_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            banks_dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            banks_dgv.DefaultCellStyle.ForeColor = Color.Black;

        }

        public void Bank_View()
        {
            try
            {
                string Query = "SELECT b.Bank_Name,bd.Bank_Details_ID,bd.Bank_Branch,bd.Bank_Acc_Name,bd.Bank_Acc_Number,bd.Bank_Acc_Balance,IF(bd.Bank_Acc_Status=0, 'Active', 'InActive') as'Bank_Acc_Status' FROM `banks_pos` b join bank_details_pos bd on b.Bank_ID=bd.Bank_Name_ID";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, Conn.ConnectionString);

                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                bank_id.DataPropertyName = dTable.Columns["Bank_Details_ID"].ToString();
                bank_name.DataPropertyName = dTable.Columns["Bank_Name"].ToString();
                bank_branch.DataPropertyName = dTable.Columns["Bank_Branch"].ToString();
                bank_acc_name.DataPropertyName = dTable.Columns["Bank_Acc_Name"].ToString();
                bank_acc_number.DataPropertyName = dTable.Columns["Bank_Acc_Number"].ToString();
                bank_acc_balance.DataPropertyName = dTable.Columns["Bank_Acc_Balance"].ToString();
                bank_acc_status.DataPropertyName = dTable.Columns["Bank_Acc_Status"].ToString();

                banks_dgv.DataSource = dTable;
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

        public void Bank_View_With(string search_txt)
        {
            try
            {
                string Query = "SELECT b.Bank_Name,bd.Bank_Details_ID,bd.Bank_Branch,bd.Bank_Acc_Name,bd.Bank_Acc_Number,bd.Bank_Acc_Balance,IF(bd.Bank_Acc_Status=0, 'Active', 'InActive') as'Bank_Acc_Status' FROM `banks_pos` b join bank_details_pos bd on b.Bank_ID=bd.Bank_Name_ID where b.Bank_Name like '" + search_txt + "%' or bd.Bank_Branch like '" + search_txt + "%' or bd.Bank_Acc_Number like '" + search_txt + "%' or bd.Bank_Acc_Name like '" + search_txt + "%'";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, Conn.ConnectionString);

                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                bank_id.DataPropertyName = dTable.Columns["Bank_Details_ID"].ToString();
                bank_name.DataPropertyName = dTable.Columns["Bank_Name"].ToString();
                bank_branch.DataPropertyName = dTable.Columns["Bank_Branch"].ToString();
                bank_acc_name.DataPropertyName = dTable.Columns["Bank_Acc_Name"].ToString();
                bank_acc_number.DataPropertyName = dTable.Columns["Bank_Acc_Number"].ToString();
                bank_acc_balance.DataPropertyName = dTable.Columns["Bank_Acc_Balance"].ToString();
                bank_acc_status.DataPropertyName = dTable.Columns["Bank_Acc_Status"].ToString();

                banks_dgv.DataSource = dTable;

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

        private string Delete_Bank()
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `banks_pos` WHERE `banks_pos`.`Bank_ID` = @bankID", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@bankID", bankID);

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

        private void add_bank_btn_Click(object sender, EventArgs e)
        {
            using (Bank_Form bf = new Bank_Form())
            {
                bf.ShowDialog();
                Bank_View();
            }
        }

        private void edit_bank_btn_Click(object sender, EventArgs e)
        {

            if (bankID != null && bankID != "")
            {
                using (Bank_Form bf = new Bank_Form(bankID))
                {
                    bf.ShowDialog();
                    Bank_View();
                    bankID = "";
                }
            }
            else
            {
                alert aa = new alert("Info!", "Please Select A Row You Want To Edit", "info");
                aa.ShowDialog();
            }
        }

        private void delete_bank_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (bankID != null && bankID != "")
                {
                    string msg = Delete_Bank();
                    alert aa = new alert("Deleted!", msg, "success");
                    aa.ShowDialog();
                    Bank_View();
                }
                else
                {
                    alert aa = new alert("Info!", "Please Select A Row You Want To Delete.", "info");
                    aa.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                alert aa = new alert("Error!", "You Can't Delete This Record Because This Bank Account Exists Somewhere.", "error");
                aa.ShowDialog();
            }

        }

        private void searchbox_txt_TextChanged(object sender, EventArgs e)
        {
            Bank_View_With(searchbox_txt.Text.ToString());
        }

        private void banks_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in banks_dgv.SelectedRows)
            {
                bankID = row.Cells[1].Value.ToString();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void banks_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < banks_dgv.Rows.Count; i++)
            {

                String status = banks_dgv.Rows[i].Cells["bank_acc_status"].Value.ToString();


                if (status == "InActive")
                {
                    DataGridViewRow row = banks_dgv.Rows[i];// get you required index
                    // check the cell value under your specific column and then you can toggle your colors
                    row.DefaultCellStyle.BackColor = Color.FromArgb(245, 17, 17);
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 0, 0);
                    row.DefaultCellStyle.SelectionForeColor = Color.White;
                }
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
        private void banks_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
