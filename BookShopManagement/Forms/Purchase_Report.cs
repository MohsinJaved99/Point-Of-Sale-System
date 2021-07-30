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

namespace BookShopManagement.Forms
{
    public partial class Purchase_Report : Form
    {

        ReportDocument crys = new ReportDocument();
        public Purchase_Report()
        {
            InitializeComponent();
        }


         public Purchase_Report(string supID,string date)
        {
            InitializeComponent();

                string Query = "purchase_report;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, Conn.ConnectionString);
                MyCommand2.CommandType = CommandType.StoredProcedure;
                MyCommand2.Parameters.AddWithValue("@sid", supID);
                MyCommand2.Parameters.AddWithValue("@date", date);
                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataSet ds = new DataSet();
                MyAdapter.Fill(ds, "purchase_report");




                string Query1 = "purchase_report_net_amount;";
                MySqlCommand MyCommand21 = new MySqlCommand(Query1, Conn.ConnectionString);
                MyCommand21.CommandType = CommandType.StoredProcedure;
                MyCommand21.Parameters.AddWithValue("@sid", supID);
                MyCommand21.Parameters.AddWithValue("@date", date);
                if (Conn.ConnectionString.State != ConnectionState.Open)
                {
                    Conn.ConnectionString.Open();
                }

                MySqlDataAdapter MyAdapter1 = new MySqlDataAdapter();
                MyAdapter1.SelectCommand = MyCommand21;
                DataSet ds1 = new DataSet();
                MyAdapter1.Fill(ds1, "purchase_report_net_amount");








                CrystalReport3 cr = new CrystalReport3();

                cr.Database.Tables[0].SetDataSource(ds);
                cr.Database.Tables[1].SetDataSource(ds1);

                crystalReportViewer1.ReportSource = cr;


                if (Conn.ConnectionString.State == ConnectionState.Open)
                {
                    Conn.ConnectionString.Close();
                }


          }


        private void label12_Click(object sender, EventArgs e)
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

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
