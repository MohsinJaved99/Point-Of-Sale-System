using CrystalDecisions.CrystalReports.Engine;
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
    public partial class PrintDC : Form
    {
        ReportDocument crys = new ReportDocument();
        public PrintDC()
        {
            InitializeComponent();
        }

        public PrintDC(string cusID) {



                string Query = "discount_card;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, Conn.ConnectionString);
                MyCommand2.CommandType = CommandType.StoredProcedure;
                MyCommand2.Parameters.AddWithValue("@Cid", 3);
                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataSet ds = new DataSet();
                MyAdapter.Fill(ds, "discount_card");



                CrystalReport4 cr = new CrystalReport4();
                cr.SetDataSource(ds);
                crystalReportViewer1.ReportSource = cr;

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
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
