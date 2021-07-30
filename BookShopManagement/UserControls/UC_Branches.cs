using System;
using System.Data;
using System.Windows.Forms;
using BookShopManagement.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Net;

namespace BookShopManagement.UserControls
{
    public partial class UC_Branches : UserControl
    {
        Conn con = new Conn();
        string branchID;

        public UC_Branches()
        {
            InitializeComponent();
            Branch_View();

            branches_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            branches_dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            branches_dgv.DefaultCellStyle.ForeColor = Color.Black;

            //branches_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            //branches_dgv.DefaultCellStyle.ForeColor = Color.Black;
        }

        public void Branch_View()
        {
            try {
                string Query = "SELECT Branch_ID AS `Branch ID`, Branch_Area AS `Branch Area`, Branch_Head AS `Branch Head`, Branch_Phone AS `Branch Phone`,Branch_Status as 'Status' FROM `branches_pos`;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, Conn.ConnectionString);

                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }
                
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                id.DataPropertyName = dTable.Columns["Branch ID"].ToString();
                head.DataPropertyName = dTable.Columns["Branch Head"].ToString();
                area.DataPropertyName = dTable.Columns["Branch Area"].ToString();
                number.DataPropertyName = dTable.Columns["Branch Phone"].ToString();
                Status.DataPropertyName = dTable.Columns["Status"].ToString();
                branches_dgv.DataSource = dTable;

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

        public void Branch_View_With(string search_txt)
        {
            try
            {
                string Query = "SELECT Branch_ID AS `Branch ID`, Branch_Area AS `Branch Area`, Branch_Head AS `Branch Head`, Branch_Phone AS `Branch Phone`,Branch_Status as 'Status' FROM `branches_pos` where Branch_Area like '" + search_txt + "%' or Branch_Phone like '" + search_txt + "%' or Branch_Head like '" + search_txt + "%' or Branch_Status like '" + search_txt + "%'";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, Conn.ConnectionString);

                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                id.DataPropertyName = dTable.Columns["Branch ID"].ToString();
                head.DataPropertyName = dTable.Columns["Branch Head"].ToString();
                area.DataPropertyName = dTable.Columns["Branch Area"].ToString();
                number.DataPropertyName = dTable.Columns["Branch Phone"].ToString();
                Status.DataPropertyName = dTable.Columns["Status"].ToString();
                branches_dgv.DataSource = dTable;

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

        private string Delete_Branch()
        {
            MySqlCommand cmd = new MySqlCommand("update `branches_pos` set Branch_Status='Inactive' WHERE `branches_pos`.`Branch_ID` = @branchID", Conn.ConnectionString);
            cmd.Parameters.AddWithValue("@branchID", branchID);

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
                return "Selected Branch Inactive Successfully";
            }
            else
            {
                return "Data Not Deleted From System Successfully";
            }
        }

        private void add_branch_btn_Click(object sender, EventArgs e)
        {
            using (Branch_Form bf = new Branch_Form())
            {
                bf.ShowDialog();
                Branch_View();
            }
        }

        private void edit_branch_btn_Click(object sender, EventArgs e)
        {
            if (branchID != null && branchID != "")
            {
                using (Branch_Form bf = new Branch_Form(branchID))
                {
                    bf.ShowDialog();
                    Branch_View();
                    branchID = "";
                }
            }
            else
            {
                alert aa = new alert("Info!", "Please Select A Row You Want To Edit", "info");
                aa.ShowDialog();
            }
        }

        private void delete_branch_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (branchID != null && branchID != "")
                {
                    string msg = Delete_Branch();
                    alert aa = new alert("Deleted!", msg, "success");
                    aa.ShowDialog();
                    Branch_View();
                }
                else
                {
                    alert aa = new alert("Info!", "Please Select A Row You Want To Delete", "info");
                    aa.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                alert aa = new alert("Error!", "You Can't Delete This Record Because This Branch Exists Somewhere.", "error");
                aa.ShowDialog();
            }
        }

        private void branches_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in branches_dgv.SelectedRows)
            {
                branchID = row.Cells[0].Value.ToString();
            }
        }
        
        private void search_box_txt_TextChanged(object sender, EventArgs e)
        {
            Branch_View_With(search_box_txt.Text.ToString());
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
        private void branches_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void branches_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < branches_dgv.Rows.Count; i++)
            {

                String status = branches_dgv.Rows[i].Cells["Status"].Value.ToString();


                if (status == "Inactive")
                {
                    DataGridViewRow row = branches_dgv.Rows[i];// get you required index
                    // check the cell value under your specific column and then you can toggle your colors
                    row.DefaultCellStyle.BackColor = Color.FromArgb(245, 17, 17);
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 0, 0);
                    row.DefaultCellStyle.SelectionForeColor = Color.White;
                }

            }
        }
    }
}
