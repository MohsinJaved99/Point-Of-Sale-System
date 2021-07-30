namespace BookShopManagement.UserControls
{
    partial class ShowSale
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.delete_product_btn = new System.Windows.Forms.Button();
            this.search_box_txt = new System.Windows.Forms.TextBox();
            this.search_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.copyright_label = new System.Windows.Forms.Label();
            this.sale_dgv = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sale_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.delete_product_btn);
            this.panel5.Controls.Add(this.search_box_txt);
            this.panel5.Controls.Add(this.search_label);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 8);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1100, 55);
            this.panel5.TabIndex = 16;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::BookShopManagement.Properties.Resources.icons8_total_sales_32;
            this.button2.Location = new System.Drawing.Point(281, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 55);
            this.button2.TabIndex = 10;
            this.button2.Text = "  Sales Report";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::BookShopManagement.Properties.Resources.icons8_print_file_24;
            this.button1.Location = new System.Drawing.Point(146, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "  Print Report";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete_product_btn
            // 
            this.delete_product_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.delete_product_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_product_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.delete_product_btn.FlatAppearance.BorderSize = 0;
            this.delete_product_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_product_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_product_btn.ForeColor = System.Drawing.Color.White;
            this.delete_product_btn.Image = global::BookShopManagement.Properties.Resources.icons8_view_details_26;
            this.delete_product_btn.Location = new System.Drawing.Point(0, 0);
            this.delete_product_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_product_btn.Name = "delete_product_btn";
            this.delete_product_btn.Size = new System.Drawing.Size(146, 55);
            this.delete_product_btn.TabIndex = 8;
            this.delete_product_btn.Text = "  View Order Details";
            this.delete_product_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_product_btn.UseVisualStyleBackColor = false;
            this.delete_product_btn.Click += new System.EventHandler(this.delete_product_btn_Click);
            // 
            // search_box_txt
            // 
            this.search_box_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box_txt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box_txt.Location = new System.Drawing.Point(885, 13);
            this.search_box_txt.Margin = new System.Windows.Forms.Padding(2);
            this.search_box_txt.Name = "search_box_txt";
            this.search_box_txt.Size = new System.Drawing.Size(208, 31);
            this.search_box_txt.TabIndex = 5;
            this.search_box_txt.TextChanged += new System.EventHandler(this.search_box_txt_TextChanged);
            // 
            // search_label
            // 
            this.search_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_label.ForeColor = System.Drawing.Color.White;
            this.search_label.Location = new System.Drawing.Point(824, 16);
            this.search_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(74, 16);
            this.search_label.TabIndex = 4;
            this.search_label.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 586);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 8);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1108, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 594);
            this.panel4.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.copyright_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 594);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 18);
            this.panel1.TabIndex = 15;
            // 
            // copyright_label
            // 
            this.copyright_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyright_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright_label.ForeColor = System.Drawing.Color.White;
            this.copyright_label.Location = new System.Drawing.Point(9, -1);
            this.copyright_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(631, 18);
            this.copyright_label.TabIndex = 4;
            this.copyright_label.Text = "Copyright © 2020 | All Rights Reserved - KoderSpot.";
            // 
            // sale_dgv
            // 
            this.sale_dgv.AllowUserToAddRows = false;
            this.sale_dgv.AllowUserToDeleteRows = false;
            this.sale_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sale_dgv.BackgroundColor = System.Drawing.Color.White;
            this.sale_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.sale_dgv.ColumnHeadersHeight = 50;
            this.sale_dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sale_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sale_dgv.GridColor = System.Drawing.Color.Black;
            this.sale_dgv.Location = new System.Drawing.Point(8, 63);
            this.sale_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.sale_dgv.Name = "sale_dgv";
            this.sale_dgv.ReadOnly = true;
            this.sale_dgv.RowHeadersVisible = false;
            this.sale_dgv.RowTemplate.Height = 30;
            this.sale_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sale_dgv.Size = new System.Drawing.Size(1100, 531);
            this.sale_dgv.TabIndex = 17;
            this.sale_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sale_dgv_CellClick);
            this.sale_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sale_dgv_CellContentClick);
            this.sale_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sale_dgv_CellDoubleClick);
            this.sale_dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.sale_dgv_CellFormatting);
            // 
            // ShowSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sale_dgv);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "ShowSale";
            this.Size = new System.Drawing.Size(1116, 612);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sale_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox search_box_txt;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label copyright_label;
        private System.Windows.Forms.Button delete_product_btn;
        private System.Windows.Forms.DataGridView sale_dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
