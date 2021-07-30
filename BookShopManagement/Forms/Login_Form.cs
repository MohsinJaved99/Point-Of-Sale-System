using BookShopManagement.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement
{
    public partial class Login : Form
    {
        Conn con = new Conn();

        public Login()
        {
            InitializeComponent();
            panel2.Location = new Point(
    this.ClientSize.Width / 2 - panel2.Size.Width / 2,
    this.ClientSize.Height / 2 - panel2.Size.Height / 2);
            panel2.Anchor = AnchorStyles.None;
            panel2.Paint += dropShadow;
   
        }
      
        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {
            if (username_txt.Text == "") { username_txt.BackColor = Color.Red; } else { username_txt.BackColor = Color.White; }
        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {
            if (password_txt.Text == "") { password_txt.BackColor = Color.Red; } else { password_txt.BackColor = Color.White; }
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
        private void login_btn_Click(object sender, EventArgs e)
        {
            if (CheckForInternetConnection().ToString() == "True")
            {

                if (username_txt.Text == "") { username_txt.BackColor = Color.Red; } else { username_txt.BackColor = Color.White; }
                if (password_txt.Text == "") { password_txt.BackColor = Color.Red; } else { password_txt.BackColor = Color.White; }
                if ((username_txt.Text == "") || (password_txt.Text == ""))
                {
                    alert aa = new alert("Error!", "Fields With * Are Mandatory.", "error");
                    aa.ShowDialog();
                }
                else
                {

                    if (Retrieval.getUserDetails(username_txt.Text, password_txt.Text))
                    {
                        this.Hide();
                        loading l = new loading();
                        l.ShowDialog();
                        if (Retrieval.role == 0)
                        {
                            this.Dispose();
                            Dashboard fd = new Dashboard();
                            fd.ShowDialog();

                        }
                        else
                        {
                            this.Dispose();
                            Dashboard fd = new Dashboard();
                            fd.ShowDialog();

                        }
                    }
                    else
                    {
                    }
                }
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void heading_label_Click(object sender, EventArgs e)
        {

        }
        private void dropShadow(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Color[] shadow = new Color[3];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);
            Pen pen = new Pen(shadow[0]);
            using (pen)
            {
                foreach (Panel p in panel.Controls.OfType<Panel>())
                {
                    Point pt = p.Location;
                    pt.Y += p.Height;
                    for (var sp = 0; sp < 3; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X + p.Width - 1, pt.Y);
                        pt.Y++;
                    }
                }
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            username_txt.Select();
            
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
             
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void username_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //murghe m = new murghe();
            //m.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
