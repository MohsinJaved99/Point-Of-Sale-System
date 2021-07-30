namespace BookShopManagement.UserControls
{
    partial class UC_Customers
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customers));
            this.search_box_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customers_dgv = new System.Windows.Forms.DataGridView();
            this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_NIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.delete_customer_btn = new System.Windows.Forms.Button();
            this.edit_customer_btn = new System.Windows.Forms.Button();
            this.add_customer_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.copyright_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customers_dgv)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_box_txt
            // 
            this.search_box_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box_txt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box_txt.Location = new System.Drawing.Point(916, 15);
            this.search_box_txt.Margin = new System.Windows.Forms.Padding(2);
            this.search_box_txt.Name = "search_box_txt";
            this.search_box_txt.Size = new System.Drawing.Size(180, 31);
            this.search_box_txt.TabIndex = 5;
            this.search_box_txt.TextChanged += new System.EventHandler(this.search_box_txt_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(860, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Search";
            // 
            // customers_dgv
            // 
            this.customers_dgv.AllowUserToAddRows = false;
            this.customers_dgv.AllowUserToDeleteRows = false;
            this.customers_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customers_dgv.BackgroundColor = System.Drawing.Color.White;
            this.customers_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.customers_dgv.ColumnHeadersHeight = 38;
            this.customers_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_ID,
            this.Customer_Name,
            this.Customer_NIC,
            this.Customer_Phone,
            this.Customer_Mail,
            this.Customer_Address});
            this.customers_dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customers_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customers_dgv.GridColor = System.Drawing.Color.Black;
            this.customers_dgv.Location = new System.Drawing.Point(8, 63);
            this.customers_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.customers_dgv.Name = "customers_dgv";
            this.customers_dgv.ReadOnly = true;
            this.customers_dgv.RowHeadersVisible = false;
            this.customers_dgv.RowTemplate.Height = 30;
            this.customers_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customers_dgv.Size = new System.Drawing.Size(1100, 531);
            this.customers_dgv.TabIndex = 0;
            this.customers_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customers_dgv_CellClick);
            this.customers_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customers_dgv_CellContentClick);
            // 
            // Customer_ID
            // 
            this.Customer_ID.HeaderText = "Customer ID";
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.ReadOnly = true;
            this.Customer_ID.Visible = false;
            // 
            // Customer_Name
            // 
            this.Customer_Name.HeaderText = "Customer Name";
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.ReadOnly = true;
            // 
            // Customer_NIC
            // 
            this.Customer_NIC.HeaderText = "Customer NIC";
            this.Customer_NIC.Name = "Customer_NIC";
            this.Customer_NIC.ReadOnly = true;
            // 
            // Customer_Phone
            // 
            this.Customer_Phone.HeaderText = "Customer Phone";
            this.Customer_Phone.Name = "Customer_Phone";
            this.Customer_Phone.ReadOnly = true;
            // 
            // Customer_Mail
            // 
            this.Customer_Mail.HeaderText = "Customer Email";
            this.Customer_Mail.Name = "Customer_Mail";
            this.Customer_Mail.ReadOnly = true;
            // 
            // Customer_Address
            // 
            this.Customer_Address.HeaderText = "Customer Address";
            this.Customer_Address.Name = "Customer_Address";
            this.Customer_Address.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.delete_customer_btn);
            this.panel5.Controls.Add(this.edit_customer_btn);
            this.panel5.Controls.Add(this.search_box_txt);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.add_customer_btn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 8);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1100, 55);
            this.panel5.TabIndex = 11;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // delete_customer_btn
            // 
            this.delete_customer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.delete_customer_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_customer_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.delete_customer_btn.FlatAppearance.BorderSize = 0;
            this.delete_customer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_customer_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_customer_btn.ForeColor = System.Drawing.Color.White;
            this.delete_customer_btn.Image = global::BookShopManagement.Properties.Resources.trash_32px;
            this.delete_customer_btn.Location = new System.Drawing.Point(238, 0);
            this.delete_customer_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_customer_btn.Name = "delete_customer_btn";
            this.delete_customer_btn.Size = new System.Drawing.Size(134, 55);
            this.delete_customer_btn.TabIndex = 7;
            this.delete_customer_btn.Text = "   Delete Customer";
            this.delete_customer_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_customer_btn.UseVisualStyleBackColor = false;
            this.delete_customer_btn.Click += new System.EventHandler(this.delete_customer_btn_Click);
            // 
            // edit_customer_btn
            // 
            this.edit_customer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.edit_customer_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_customer_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.edit_customer_btn.FlatAppearance.BorderSize = 0;
            this.edit_customer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_customer_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_customer_btn.ForeColor = System.Drawing.Color.White;
            this.edit_customer_btn.Image = global::BookShopManagement.Properties.Resources.edit_property_32px;
            this.edit_customer_btn.Location = new System.Drawing.Point(117, 0);
            this.edit_customer_btn.Margin = new System.Windows.Forms.Padding(2);
            this.edit_customer_btn.Name = "edit_customer_btn";
            this.edit_customer_btn.Size = new System.Drawing.Size(121, 55);
            this.edit_customer_btn.TabIndex = 6;
            this.edit_customer_btn.Text = "   Edit Customer";
            this.edit_customer_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_customer_btn.UseVisualStyleBackColor = false;
            this.edit_customer_btn.Click += new System.EventHandler(this.edit_customer_btn_Click);
            // 
            // add_customer_btn
            // 
            this.add_customer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.add_customer_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_customer_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.add_customer_btn.FlatAppearance.BorderSize = 0;
            this.add_customer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_customer_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_customer_btn.ForeColor = System.Drawing.Color.White;
            this.add_customer_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_customer_btn.Image")));
            this.add_customer_btn.Location = new System.Drawing.Point(0, 0);
            this.add_customer_btn.Margin = new System.Windows.Forms.Padding(2);
            this.add_customer_btn.Name = "add_customer_btn";
            this.add_customer_btn.Size = new System.Drawing.Size(117, 55);
            this.add_customer_btn.TabIndex = 0;
            this.add_customer_btn.Text = "   Add Customer";
            this.add_customer_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_customer_btn.UseVisualStyleBackColor = false;
            this.add_customer_btn.Click += new System.EventHandler(this.add_customer_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 586);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 8);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1108, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 594);
            this.panel4.TabIndex = 9;
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
            this.panel1.TabIndex = 10;
            // 
            // copyright_label
            // 
            this.copyright_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyright_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright_label.ForeColor = System.Drawing.Color.White;
            this.copyright_label.Location = new System.Drawing.Point(10, -2);
            this.copyright_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(506, 18);
            this.copyright_label.TabIndex = 4;
            this.copyright_label.Text = "Copyright © 2020 | All Rights Reserved - KoderSpot.";
            // 
            // UC_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.customers_dgv);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Customers";
            this.Size = new System.Drawing.Size(1116, 612);
            ((System.ComponentModel.ISupportInitialize)(this.customers_dgv)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox search_box_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView customers_dgv;
        private System.Windows.Forms.Button add_customer_btn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button edit_customer_btn;
        private System.Windows.Forms.Button delete_customer_btn;
        private System.Windows.Forms.Label copyright_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_NIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Address;
    }
}