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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
        }
        int a = 0;
        private void loading_Load(object sender, EventArgs e)
        {
 
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            if (a == 30)
            {
                timer1.Stop();
                this.Dispose();
            }
        }
    }
}
