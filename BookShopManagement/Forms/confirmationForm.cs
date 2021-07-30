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
    public partial class confirmationForm : Form
    {
        public confirmationForm()
        {
            InitializeComponent();
        }

        public confirmationForm(string heading,string text)
        {
            InitializeComponent();
            heading_label.Text = heading;
            msg_lbl.Text = text;
        }

        public string r;

        private void save_btn_Click(object sender, EventArgs e)
        {
            r = "yes";
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r = "no";
            this.Dispose();
        }

        private void confirmationForm_Load(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
