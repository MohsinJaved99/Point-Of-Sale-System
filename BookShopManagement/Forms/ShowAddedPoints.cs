using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class ShowAddedPoints : Form
    {
        public ShowAddedPoints()
        {
            if (CheckForInternetConnection().ToString() == "True")
            {
                InitializeComponent();
                discountin_dvg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
                discountin_dvg.DefaultCellStyle.SelectionForeColor = Color.Black;
                discountin_dvg.DefaultCellStyle.ForeColor = Color.Black;
            }
            else
            {

            }
            
        }
        public ShowAddedPoints(string dcid)
        {

            InitializeComponent();
            ShowwInPoints(dcid);
            discountin_dvg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            discountin_dvg.DefaultCellStyle.SelectionForeColor = Color.Black;
            discountin_dvg.DefaultCellStyle.ForeColor = Color.Black;
        }
        string aa;
        private void ShowwInPoints(string cardid)
        {
            aa = cardid;
            string query = "select d.DC_Card_Number as 'Card Number',innn.Discount_In_Points as 'Added Points',innn.Discount_In_Start_Date as 'Add Points On',innn.Discount_In_Activation_Date as 'Points Activated On',innn.Discound_In_Status as 'Status' from discount_card_pos d join discount_point_in_pos innn on d.DC_Card_Number=innn.Discount_In_Card_ID where d.DC_Card_Number='" + cardid + "'";

            MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, BookShopManagement.Conn.ConnectionString);
            DataTable dTable = new DataTable();
            dataadapter.Fill(dTable);
            discountin_dvg.DataSource = dTable;
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
        private void discountin_dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != "" || textBox7.Text != string.Empty)
            {
                string query = "select d.DC_Card_Number as 'Card Number',innn.Discount_In_Points as 'Added Points',innn.Discount_In_Start_Date as 'Add Points On',innn.Discount_In_Activation_Date as 'Points Activated On',innn.Discound_In_Status as 'Status' from discount_card_pos d join discount_point_in_pos innn on d.DC_Card_Number=innn.Discount_In_Card_ID where d.DC_Card_Number='" + aa + "%' or innn.Discound_In_Status like '" + textBox7.Text + "%' or innn.Discount_In_Start_Date like '" + textBox7.Text + "%' or innn.Discount_In_Activation_Date like '" + textBox7.Text + "%'";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, BookShopManagement.Conn.ConnectionString);
                DataTable dTable = new DataTable();
                dataadapter.Fill(dTable);
                discountin_dvg.DataSource = dTable;
            }
            else
            {
                ShowwInPoints(aa);
            }
        }

        private void ShowAddedPoints_Load(object sender, EventArgs e)
        {
            discountin_dvg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            discountin_dvg.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
