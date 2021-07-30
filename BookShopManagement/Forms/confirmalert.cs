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
    public partial class confirmalert : Form
    {
        public confirmalert()
        {
            InitializeComponent();
        }
        public string confirmation;
        private void confirmalert_Load(object sender, EventArgs e)
        {

        }

        private void yes_Click(object sender, EventArgs e)
        {
            confirmation = "yes";
            this.Dispose();
        }

        private void no_Click(object sender, EventArgs e)
        {
            confirmation = "no";
            this.Dispose();
        }
    }
}
