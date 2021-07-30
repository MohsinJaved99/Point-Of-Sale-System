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
    public partial class sticknote : Form
    {
        string aa, bb, cc;
        public sticknote()
        {
            if (CheckForInternetConnection().ToString() == "True")
            {
                InitializeComponent();

                for (int i = 1; i < 50; i++)
                {
                    size.Items.Add(i.ToString());
                }
                if (font.Text != "")
                {
                    richTextBox1.Enabled = true;
                }

                string checknote = "select count(*) from sticknote where Note_User_ID='" + Retrieval.User_ID + "'";
                MySqlCommand cmd = new MySqlCommand(checknote, Conn.ConnectionString);
                Conn.ConnectionString.Open();
                string count = cmd.ExecuteScalar().ToString();
                if (count == "1")
                {
                    MySqlDataReader sdr;
                    string texnote = "select * from sticknote where Note_User_ID='" + Retrieval.User_ID + "'";
                    MySqlCommand cmdd = new MySqlCommand(texnote, Conn.ConnectionString);

                    sdr = cmdd.ExecuteReader();

                    while (sdr.Read())
                    {
                        //MessageBox.Show(sdr["Font_Color"].ToString());
                        richTextBox1.Text = sdr["Note_Text"].ToString();
                        //font.Text = sdr["Font_Name"].ToString();
                        //size.Text = sdr["Font_Size"].ToString();
                        //color = sdr["Font_Color"].ToString();
                        aa = sdr["Font_Name"].ToString();

                        cc = sdr["Font_Size"].ToString();
                    }
                    font.Text = aa;
                    size.Text = cc;

                    richTextBox1.Font = new Font(aa, Convert.ToInt32(cc));

                }
                Conn.ConnectionString.Close();
            }
            else
            {

            }
        }

        private void sticknote_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
        string color;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string checknote = "select count(*) from sticknote where Note_User_ID='" + Retrieval.User_ID + "'";
            MySqlCommand cmd = new MySqlCommand(checknote,Conn.ConnectionString);
            Conn.ConnectionString.Open();
            string count = cmd.ExecuteScalar().ToString();
            if (count == "1")
            {
                string updatenote = "update `sticknote` set `Note_Text`='" + richTextBox1.Text + "' where Note_User_ID='"+Retrieval.User_ID+"'";
                MySqlCommand cmd2 = new MySqlCommand(updatenote, Conn.ConnectionString);
                int res1 = cmd2.ExecuteNonQuery();
                if (res1 > 0)
                {

                }
            }
            else
            {
                string createnote = "INSERT INTO `sticknote`(`Note_User_ID`, `Note_Text`, `Font_Name`, `Font_Size`) VALUES ('" + Retrieval.User_ID + "','" + richTextBox1.Text + "','"+font.Text+"','"+size.Text+"')";
                MySqlCommand cmd1 = new MySqlCommand(createnote,Conn.ConnectionString);
                int res = cmd1.ExecuteNonQuery();
                if (res > 0)
                {

                }

            }
            Conn.ConnectionString.Close();
        }

        private void bank_branch_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (font.Text != "")
            {
                richTextBox1.Font = new Font(font.Text, Convert.ToInt32(size.Text));
            }
            if (size.Text != "" && font.Text != "" && color != "")
            {
                richTextBox1.Enabled = true;
            }
            string checknote = "select count(*) from sticknote where Note_User_ID='" + Retrieval.User_ID + "'";
            MySqlCommand cmd = new MySqlCommand(checknote, Conn.ConnectionString);
             Conn.ConnectionString.Close();
            Conn.ConnectionString.Open();
            string count = cmd.ExecuteScalar().ToString();
            if (count == "1")
            {
                string updatefont = "update sticknote set Font_Size='" + size.Text + "' where Note_User_ID='" + Retrieval.User_ID + "'";
                MySqlCommand uf = new MySqlCommand(updatefont, Conn.ConnectionString);
                uf.ExecuteNonQuery();
            }
            Conn.ConnectionString.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult fontResult = fontDialog1.ShowDialog();
            if (fontResult == DialogResult.OK)
            {
                font.Text = fontDialog1.Font.Name.ToString();
                
                if (size.Text != "")
                {
                    richTextBox1.Font = new Font(font.Text, Convert.ToInt32(size.Text));
                }
                else
                {
                    richTextBox1.Font = fontDialog1.Font;
                }
                 
            }

            if (size.Text != "" && font.Text != "" && color!="")
            {
                richTextBox1.Enabled = true;
            }

            if (font.Text != "")
            {
                
                string checknote = "select count(*) from sticknote where Note_User_ID='" + Retrieval.User_ID + "'";
                MySqlCommand cmd = new MySqlCommand(checknote,Conn.ConnectionString);
                Conn.ConnectionString.Open();
                string count = cmd.ExecuteScalar().ToString();
                if (count == "1")
                {
                    string updatefont = "update sticknote set Font_Name='" + font.Text + "' where Note_User_ID='" + Retrieval.User_ID + "'";
                    MySqlCommand uf = new MySqlCommand(updatefont, Conn.ConnectionString);
                    uf.ExecuteNonQuery();
                }
                Conn.ConnectionString.Close();
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            //colorDialog1.ShowDialog();
            //clear_btn.BackColor = colorDialog1.Color;
            //color = colorDialog1.Color.;

            //string checknote = "select count(*) from sticknote where Note_User_ID='" + Retrieval.User_ID + "'";
            //MySqlCommand cmd = new MySqlCommand(checknote, Conn.ConnectionString);
            //Conn.ConnectionString.Open();
            //string count = cmd.ExecuteScalar().ToString();
            //if (count == "1")
            //{
            //    string updatefont = "update sticknote set Font_Color='" + color + "' where Note_User_ID='" + Retrieval.User_ID + "'";
            //    MySqlCommand uf = new MySqlCommand(updatefont, Conn.ConnectionString);
            //    uf.ExecuteNonQuery();
            //}
            //Conn.ConnectionString.Close();

            //if (size.Text != "" && font.Text != "" && color != "")
            //{
            //    richTextBox1.Enabled = true;
            //}
        }

        private void heading_label_Click(object sender, EventArgs e)
        {

        }
    }
}
