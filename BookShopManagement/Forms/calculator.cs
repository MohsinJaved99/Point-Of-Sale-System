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
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }
        double a, b;
        string opration;
        private void button10_Click(object sender, EventArgs e)
        {
            if (val.Text != "0")
            {
                val.Text = val.Text + "0";
            }
            else
            {
                val.Text = "0";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (opration == "sum")
            {
                b = double.Parse(val.Text);
                double res = a + b;
                val.Text = res.ToString();
                button14.Enabled = true;
                button13.Enabled = true;
                button12.Enabled = true;
            }
            else if (opration == "sub")
            {
                b = double.Parse(val.Text);
                double res = a - b;
                val.Text = res.ToString();
                button15.Enabled = true;
                button13.Enabled = true;
                button12.Enabled = true;
            }
            else if (opration == "mult")
            {
                b = double.Parse(val.Text);
                double res = a * b;
                val.Text = res.ToString();
                button15.Enabled = true;
                button14.Enabled = true;
                button12.Enabled = true;
            }
            else if (opration == "div")
            {
                b = double.Parse(val.Text);
                double res = a / b;
                val.Text = res.ToString();
                button15.Enabled = true;
                button14.Enabled = true;
                button13.Enabled = true;
            }

           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (val.Text.Contains("."))
            {

            }
            else
            {
                val.Text = val.Text + ".";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (a != null)
            {
                opration = "sum";
                a = double.Parse(val.Text);
                val.Text = "";
                button14.Enabled = false;
                button13.Enabled = false;
                button12.Enabled = false;
                val.Select();
            }
            else
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (a != null)
            {
                opration = "mult";
                a = double.Parse(val.Text);
                val.Text = "";
                button15.Enabled = false;
                button14.Enabled = false;
                button12.Enabled = false;
                val.Select();
            }
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (a != null)
            {
                opration = "sub";
                a = double.Parse(val.Text);
                val.Text = "";
                button15.Enabled = false;
                button13.Enabled = false;
                button12.Enabled = false;
                val.Select();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (a != null)
            {
                opration = "div";
                a = double.Parse(val.Text);
                val.Text = "";
                button15.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                val.Select();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (val.Text == "0")
            {
                val.Text = "";
            }
            val.Text = val.Text + "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (val.Text == "0")
            {
                val.Text = "";
            }
            val.Text = val.Text + "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (val.Text == "0")
            {
                val.Text = "";
            }

            val.Text = val.Text + "6";
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void heading_label_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (val.Text == "0")
            {
                val.Text = "";
            }
            val.Text = val.Text + "7";
        }

        private void purpose_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (val.Text == "0")
            {
                val.Text = "";
            }
            val.Text=val.Text+"1";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (val.Text == "0")
            {
                val.Text = "";
            }
            val.Text = val.Text + "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (val.Text == "0")
            {
                val.Text = "";
            }
            val.Text = val.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (val.Text == "0")
            {
                val.Text = "";
            }
            val.Text = val.Text + "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (val.Text == "0")
            {
                val.Text = "";
            }
            val.Text = val.Text + "5";
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            val.Text = "0";
            a = 0;
            b = 0;
            opration = "";
        }

        private void calculator_KeyPress(object sender, KeyPressEventArgs e)
        {

           
        }

        private void val_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void calculator_KeyDown(object sender, KeyEventArgs e)
        {
        if (e.KeyCode == Keys.Enter)  
        {
            MessageBox.Show("Hello You have pressed Enter");
        }  
        }

        private void val_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string s = val.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "0";
            }

            val.Text = s;
        }

        private void val_Click(object sender, EventArgs e)
        {
            if (val.Text == "0")
            {
                val.SelectAll();
            }
        }
    }
}
