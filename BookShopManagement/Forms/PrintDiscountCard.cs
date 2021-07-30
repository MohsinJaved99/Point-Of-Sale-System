using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class PrintDiscountCard : Form
    {
        public PrintDiscountCard()
        {
            InitializeComponent();

        }
        string customername, customerphone, cardnumber, cardstartdate;
        ReportDocument crys = new ReportDocument();
        string barcode;
        public PrintDiscountCard(string cusID)
        {
            InitializeComponent();
            //MessageBox.Show(cusID);


            string query = "SELECT c.Customer_Name,c.Customer_Phone,d.DC_Card_Number,d.Serial_Number,d.DC_Start_Date from customers_pos c join discount_card_pos d on d.DC_Customer_ID=c.Customer_ID where c.Customer_NIC='" + cusID + "'";
            MySqlDataAdapter sd = new MySqlDataAdapter(query, BookShopManagement.Conn.ConnectionString);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                name.Text = row["Customer_Name"].ToString();
                //phone.Text = row["Customer_Phone"].ToString();
                sr.Text = row["Serial_Number"].ToString();
                bar.Text = row["DC_Card_Number"].ToString();
                //date.Text = row["DC_Start_Date"].ToString();
            }

       


            

            //ParameterFieldDefinitions crParameterFieldDefinitions ;
            //ParameterFieldDefinition crParameterFieldDefinition ;
            //ParameterValues crParameterValues = new ParameterValues();
            //ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            //crParameterDiscreteValue.Value = customername;
            //crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            //crParameterFieldDefinition = crParameterFieldDefinitions["cname"];
            //crParameterValues = crParameterFieldDefinition.CurrentValues;

            



            //crParameterValues.Clear();
            //crParameterValues.Add(crParameterDiscreteValue);
            //crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            //crystalReportViewer1.ReportSource = cryRpt;
            //crystalReportViewer1.Refresh();






            
          
            //cr.SetParameterValue("cphone", customerphone);
            //cr.SetParameterValue("date", cardstartdate);
            //cr.SetParameterValue("cid", cardnumber);

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap bmp = new Bitmap(panel6.Width, panel6.Height, panel6.CreateGraphics());
            panel6.DrawToBitmap(bmp, new Rectangle(0, 0, panel6.Width, panel6.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        //Bitmap bitmap;
        //private void CaptureScreen()
        //{
        //    Graphics myGraphics = this.CreateGraphics();
        //    Size s = panel6.Size;
        //    bitmap = new Bitmap(s.Width, s.Height, myGraphics);
        //    Graphics memoryGraphics = Graphics.FromImage(bitmap);
        //    memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        //}  

        private void add_to_cart_btn_Click(object sender, EventArgs e)
        {
            if (CheckForInternetConnection().ToString() == "True")
            {
                System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
                doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
                doc.Print();
            }
            else
            {

            }

            //PrintDialog myPrintDialog = new PrintDialog();
            //System.Drawing.Bitmap memoryImage = new System.Drawing.Bitmap(panel6.Width, panel6.Height);
            //panel1.DrawToBitmap(memoryImage, panel1.ClientRectangle);
            //if (myPrintDialog.ShowDialog() == DialogResult.OK)
            //{
            //    System.Drawing.Printing.PrinterSettings values;
            //    values = myPrintDialog.PrinterSettings;
            //    myPrintDialog.Document = printDocument1;
            //    printDocument1.PrintController = new StandardPrintController();
            //    printDocument1.Print();
            //}
            //printDocument1.Dispose();
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
        private void PrintDiscountCard_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
