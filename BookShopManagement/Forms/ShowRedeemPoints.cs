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
    public partial class ShowRedeemPoints : Form
    {
        public ShowRedeemPoints()
        {
            if (CheckForInternetConnection().ToString() == "True")
            {
                InitializeComponent();
                discountout_dvg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
                discountout_dvg.DefaultCellStyle.SelectionForeColor = Color.Black;
                discountout_dvg.DefaultCellStyle.ForeColor = Color.Black;
            }
            else
            {

            }
        }
        public ShowRedeemPoints(string dcid)
        {
           
            InitializeComponent();
            ShowwOutPoints(dcid);
            discountout_dvg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            discountout_dvg.DefaultCellStyle.SelectionForeColor = Color.Black;
            discountout_dvg.DefaultCellStyle.ForeColor = Color.Black;

        }
        string aa;
        private void ShowwOutPoints(string cardid)
        {
            aa = cardid;
            string query = "select d.DC_Card_Number as 'Card Number',o.Discount_Out_Redeem_Points as 'Redeemed Points',o.Discount_Out_Redeem_Date as 'Redeem On' from discount_card_pos d join discount_point_out_pos o on d.DC_Card_Number=o.Disccount_Out_Card_ID where d.DC_Card_Number='" + cardid + "'";

            MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, BookShopManagement.Conn.ConnectionString);
            DataTable dTable = new DataTable();
            dataadapter.Fill(dTable);
            discountout_dvg.DataSource = dTable;
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
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
                string query = "select d.DC_Card_Number as 'Card Number',o.Discount_Out_Redeem_Points as 'Redeemed Points',o.Discount_Out_Redeem_Date as 'Redeem On' from discount_card_pos d join discount_point_out_pos o on d.DC_Card_Number=o.Disccount_Out_Card_ID where d.DC_Card_Number='" + aa + "%' and o.Discount_Out_Redeem_Date like '"+textBox7.Text+"%'";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, BookShopManagement.Conn.ConnectionString);
                DataTable dTable = new DataTable();
                dataadapter.Fill(dTable);
                discountout_dvg.DataSource = dTable;
            }
            else
            {
                ShowwOutPoints(aa);
            }
        }

        private void ShowRedeemPoints_Load(object sender, EventArgs e)
        {
            discountout_dvg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            discountout_dvg.DefaultCellStyle.ForeColor = Color.Black;
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
        private void discountout_dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
