using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace BookShopManagement.Forms
{
    public partial class SaleReport : Form
    {
        ReportDocument crys = new ReportDocument();
        public SaleReport()
        {
            InitializeComponent();

           
        }


        public SaleReport(string orderID,string card)
        {
            InitializeComponent();
            if (card == "false")
            {
                string Query = "for_sale_report;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, Conn.ConnectionString);
                MyCommand2.CommandType = CommandType.StoredProcedure;
                MyCommand2.Parameters.AddWithValue("@id", orderID);
                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataSet ds = new DataSet();
                MyAdapter.Fill(ds, "for_sale_report");

                CrystalReport1 cr = new CrystalReport1();
                cr.SetDataSource(ds);
                crystalReportViewer1.ReportSource = cr;


                if (Conn.ConnectionString.State == ConnectionState.Open)
                {
                    Conn.ConnectionString.Close();
                }

            }
            else
            {

                string Queryy = "for_discount_card_holder;";
                MySqlCommand MyCommand22 = new MySqlCommand(Queryy, Conn.ConnectionString);
                MyCommand22.CommandType = CommandType.StoredProcedure;
                MyCommand22.Parameters.AddWithValue("@idd", orderID);
                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                MySqlDataAdapter MyAdapterr = new MySqlDataAdapter();
                MyAdapterr.SelectCommand = MyCommand22;
                DataSet dss = new DataSet();
                MyAdapterr.Fill(dss, "for_discount_card_holder");

                CrystalReport2 crr = new CrystalReport2();
                crr.SetDataSource(dss);
                crystalReportViewer1.ReportSource = crr;


                if (Conn.ConnectionString.State == ConnectionState.Open)
                {
                    Conn.ConnectionString.Close();
                }

            }



        }





        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
