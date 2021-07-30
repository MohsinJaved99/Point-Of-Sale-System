using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class License : Form
    {

        string myIP;
        MySqlConnection ConnectionString = new MySqlConnection("SERVER=23.111.150.106;PORT=3306;DATABASE=makkahel_software;UID=makkahel;PASSWORD=7yisHT(3GY0z+3;");
        Conn con = new Conn();
        public License()
        {
            InitializeComponent();
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {

                if (nic.OperationalStatus == OperationalStatus.Up && (!nic.Description.Contains("Virtual") && !nic.Description.Contains("Pseudo")))
                {
                    if (nic.GetPhysicalAddress().ToString() != "")
                    {
                        myIP = nic.GetPhysicalAddress().ToString();
                    }
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

        private void start_Click(object sender, EventArgs e)
        {

        }

        private void License_Load(object sender, EventArgs e)
        {

            con.checkConnection();
        
          
            if (CheckForInternetConnection().ToString() == "True")
            {
                string checklicense1 = "select count(*) from license where User_IP='" + myIP + "' and Unlimited='True'";
                MySqlCommand cmd11 = new MySqlCommand(checklicense1, Conn.ConnectionString);
                string count11 = cmd11.ExecuteScalar().ToString();

                if (count11 == "0")
                {

                    var info = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
                    DateTimeOffset localServerTime = DateTimeOffset.Now;


                    string checklicense = "select count(*) from license where User_IP='" + myIP + "' and Unlimited='False' and Status='Activated'";
                    MySqlCommand cmd = new MySqlCommand(checklicense, Conn.ConnectionString);
                    string count = cmd.ExecuteScalar().ToString();

                    if (count == "0")
                    {

                    }
                    else
                    {
                        string checkdate = "select Expire_Date from license where User_IP='" + myIP + "' and Unlimited='False' and Status='Activated'";
                        MySqlCommand cmd1 = new MySqlCommand(checkdate, Conn.ConnectionString);
                        string enddatee = cmd1.ExecuteScalar().ToString();

                        if (enddatee == TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy"))
                        {
                            string getkey = "select Lisense_Key FROM license WHERE User_IP='" + myIP + "'";
                            MySqlCommand uk = new MySqlCommand(getkey, Conn.ConnectionString);
                            string keyy = uk.ExecuteScalar().ToString();

                            string updatekey = "update license set User_IP='',Start_Date='',Expire_Date='',Status='Inactive' where Lisense_Key='" + keyy + "'";
                            MySqlCommand ukk = new MySqlCommand(updatekey, Conn.ConnectionString);
                            int ukres = ukk.ExecuteNonQuery();
                            if (ukres>0)
                            {

                                alert aa = new alert("License Expired!", "Please Renew Your License, Contact info@koderspot.com.", "info");
                                aa.ShowDialog();
                            }
                        }
                        else
                        {


                            DateTime d1 = Convert.ToDateTime(TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy"));
                            DateTime d2 = Convert.ToDateTime(enddatee);
                            string days = (d2 - d1).TotalDays.ToString();
                            alert aa = new alert("Info!", "You Are Using Monthly Package.License Expire Date : " + enddatee + " (" + days + " Days Left)", "info");
                            aa.ShowDialog();
                            Login l = new Login();
                            l.ShowDialog();
                            this.Hide();

                        }


                    }

                }
                else
                {
                    alert aa = new alert("Info!", "You Are Using Unlimited Package.", "info");
                    aa.ShowDialog();
                    Login l = new Login();
                    l.ShowDialog();
                    this.Hide();
                }




            }
            else
            {
                alert aa = new alert("Error!", "Please Connect Your Internet.", "error");
                aa.ShowDialog();
                this.Dispose();
            }
            ConnectionString.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void copyright_label_Click(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            ConnectionString.Open();
            if (unlimited.Text == "True")
            {
                string activatekey = "update license set Status='Activated',User_IP='" + myIP + "' where Lisense_Key='" + maskedTextBox1.Text + "' and Unlimited='True'";
                MySqlCommand cmd = new MySqlCommand(activatekey, Conn.ConnectionString);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    alert aa = new alert("Activated!", "Unlimited Package Activated.", "success");
                    aa.ShowDialog();
                    this.Hide();
                    Login l = new Login();
                    l.Show();
                }
                else
                {
                    alert aa = new alert("Error!", "Error Occurs While Activating Unlimited Package.", "error");
                    aa.ShowDialog(); MessageBox.Show("Error");
                }

            }
            else
            {
                string activatekey = "update license set Status='Activated',User_IP='" + myIP + "',Start_Date='" + start.Text + "',Expire_Date='" + end.Text + "' where Lisense_Key='" + maskedTextBox1.Text + "'";
                MySqlCommand cmd = new MySqlCommand(activatekey, Conn.ConnectionString);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    alert aa = new alert("Activated!", "Monthly Key Activated.", "success");
                    aa.ShowDialog();
                    this.Hide();
                    Login l = new Login();
                    l.Show();
                }
                else
                {
                    alert aa = new alert("Error!", "Error Occurs While Activating Monthly Package.", "error");
                    aa.ShowDialog(); MessageBox.Show("Error");
                }
            }
            ConnectionString.Close();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            ConnectionString.Open();
            string checkunlimit = "SELECT count(*) FROM `license` WHERE Lisense_Key='" + maskedTextBox1.Text + "' and Unlimited='True' and Status='Inactive'";

            MySqlCommand cc = new MySqlCommand(checkunlimit, Conn.ConnectionString);
            string coo = cc.ExecuteScalar().ToString();
            if (coo == "1")
            {
                unlimited.Text = "True";
            }
            else
            {
                unlimited.Text = "False";

                string getkey = "SELECT count(*) FROM `license` WHERE Lisense_Key='" + maskedTextBox1.Text + "' and Unlimited='False' and Status='Inactive'";

                MySqlCommand cmd = new MySqlCommand(getkey, Conn.ConnectionString);

                //Conn.ConnectionString.Open();

                string count = cmd.ExecuteScalar().ToString();

                if (count == "1")
                {
                    av.Text = "Available";
                    var info = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
                    DateTimeOffset localServerTime = DateTimeOffset.Now;
                    DateTime startDate = DateTime.Parse(TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy"));
                    DateTime expiryDate = startDate.AddDays(31);
                    start.Text = TimeZoneInfo.ConvertTime(localServerTime, info).ToString("dd-MMMM-yyyy");
                    end.Text = expiryDate.ToString("dd-MMMM-yyyy");
                }
                else
                {
                    av.Text = "";
                    start.Text = "-";
                    end.Text = "-";
                    unlimited.Text = "-";
                }
            }
            ConnectionString.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
