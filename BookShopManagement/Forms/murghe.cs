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
    public partial class murghe : Form
    {
        public murghe()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void murghe_Load(object sender, EventArgs e)
        {
            //dataGridView1.AutoGenerateColumns = false;
            string aa = "SELECT b.Product_Brand_Name as 'Brand',pc.Product_Category_Name as 'Category',p.Product_Model as 'Model',p.Product_Comission_Price as 'Price',p.Product_Quantity as 'Quantity' FROM products_pos p join product_brands_pos b on p.Pro_Brand_ID=b.Product_Brand_ID join product_category_pos pc on p.Product_Cat_ID=pc.Product_Category_ID ORDER BY b.Product_Brand_Name,pc.Product_Category_Name";
            MySqlCommand cmd = new MySqlCommand(aa, Conn.ConnectionString);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 14F, GraphicsUnit.Pixel);
            }
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16F, GraphicsUnit.Pixel);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(173, 21, 35);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 118;


            string sum = "select sum(Product_Comission_Price) from products_pos";
            MySqlCommand cmd1 = new MySqlCommand(sum, Conn.ConnectionString);
            Conn.ConnectionString.Close();
            Conn.ConnectionString.Open();
            tt.Text = cmd1.ExecuteScalar().ToString()+" Rs";
            Conn.ConnectionString.Close();
;        }

        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = dataGridView1[column, row];
            DataGridViewCell cell2 = dataGridView1[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

        //private void CompareDelete(string strTagNumb, string strAtual, DataView dt, String columnName)
        //{
        //    foreach (DataRowView row in dt)
        //    {
        //        if (row.Row["Product_Brand_Name"].ToString().Equals(strAtual))
        //        {
        //            string nl = Environment.NewLine;
        //            row.Row[columnName] += string.Concat(nl, strTagNumb);
        //            return;
        //        }
        //    }
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = dataGridView1.AdvancedCellBorderStyle.Top;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void search_box_txt_TextChanged(object sender, EventArgs e)
        {
            string aa = "SELECT b.Product_Brand_Name as 'Brand',pc.Product_Category_Name as 'Category',p.Product_Model as 'Model',p.Product_Comission_Price as 'Price',p.Product_Quantity as 'Quantity' FROM products_pos p join product_brands_pos b on p.Pro_Brand_ID=b.Product_Brand_ID join product_category_pos pc on p.Product_Cat_ID=pc.Product_Category_ID where b.Product_Brand_Name like '" + search_box_txt.Text + "%' or pc.Product_Category_Name like '" + search_box_txt.Text + "%' or p.Product_Model like '" + search_box_txt.Text + "%' ORDER BY b.Product_Brand_Name,pc.Product_Category_Name";
            MySqlCommand cmd = new MySqlCommand(aa, Conn.ConnectionString);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
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
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        string brand,cat;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Conn.ConnectionString.Close();
                Conn.ConnectionString.Open();
                foreach (DataGridViewCell row in dataGridView1.SelectedCells)
                {
                    if (row.ColumnIndex == 0)
                    {

                        string getbrandid = "select Product_Brand_ID from product_brands_pos where Product_Brand_Name='" + row.Value.ToString() + "'";
                        MySqlCommand gb = new MySqlCommand(getbrandid, Conn.ConnectionString);
                        string brandid = gb.ExecuteScalar().ToString();

                        string getsumofbrand = "select sum(Product_Comission_Price) from products_pos where Pro_Brand_ID='" + brandid + "'";
                        MySqlCommand ggg = new MySqlCommand(getsumofbrand, Conn.ConnectionString);
                        string sum = ggg.ExecuteScalar().ToString();
                        alert aa = new alert("Total", "Total Price Of Brand (" + row.Value.ToString() + ") : " + sum + " Rs", "info");
                        aa.ShowDialog();
                    }
                    else if (row.ColumnIndex == 1)
                    {
                        string getcatid = "select Product_Category_ID from product_category_pos where Product_Category_Name='" + row.Value.ToString() + "'";
                        MySqlCommand gc = new MySqlCommand(getcatid, Conn.ConnectionString);
                        string catid = gc.ExecuteScalar().ToString();

                        string getsumofcat = "select sum(Product_Comission_Price) from products_pos where Product_Cat_ID='" + catid + "'";
                        MySqlCommand gggg = new MySqlCommand(getsumofcat, Conn.ConnectionString);
                        string summ = gggg.ExecuteScalar().ToString();
                        alert aa = new alert("Total", "Total Price Of Category (" + row.Value.ToString() + ") : " + summ + " Rs", "info");
                        aa.ShowDialog();
                    }
                }
                Conn.ConnectionString.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
