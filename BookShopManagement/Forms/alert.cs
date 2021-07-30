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
    public partial class alert : Form
    {
        public alert()
        {
            InitializeComponent();
        }
       
        public alert(string headingg, string msg,string icn)
        {
            InitializeComponent();
            heading_label.Text = headingg;
            msg_lbl.Text = msg;
            if (icn == "error")
            {
                icon.Text = "☒";
            }
            else if (icn == "info")
            {
                icon.Text = "ⓘ";
            }
            else if (icn=="success"){
                icon.Text = "✓";
            }
            else
            {
                icon.Text = "";
            }
        }
        private void alert_Load(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
