namespace BookShopManagement.UserControls
{
    partial class UC_PurchaseView
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
            this.button1 = new System.Windows.Forms.Button();
            this.edit_customer_btn = new System.Windows.Forms.Button();
            this.search_box_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.purchase_dgv = new System.Windows.Forms.DataGridView();
            this.Purchase_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_SupplierCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.copyright_label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.edit_customer_btn);
            this.panel5.Controls.Add(this.search_box_txt);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 8);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1100, 55);
            this.panel5.TabIndex = 17;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
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
            this.button1.Location = new System.Drawing.Point(138, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "  Print Report";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.edit_customer_btn.Image = global::BookShopManagement.Properties.Resources.icons8_view_details_261;
            this.edit_customer_btn.Location = new System.Drawing.Point(0, 0);
            this.edit_customer_btn.Margin = new System.Windows.Forms.Padding(2);
            this.edit_customer_btn.Name = "edit_customer_btn";
            this.edit_customer_btn.Size = new System.Drawing.Size(138, 55);
            this.edit_customer_btn.TabIndex = 6;
            this.edit_customer_btn.Text = "   Purchase Details";
            this.edit_customer_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_customer_btn.UseVisualStyleBackColor = false;
            this.edit_customer_btn.Click += new System.EventHandler(this.edit_customer_btn_Click);
            // 
            // search_box_txt
            // 
            this.search_box_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box_txt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box_txt.Location = new System.Drawing.Point(861, 15);
            this.search_box_txt.Margin = new System.Windows.Forms.Padding(2);
            this.search_box_txt.Name = "search_box_txt";
            this.search_box_txt.Size = new System.Drawing.Size(234, 31);
            this.search_box_txt.TabIndex = 5;
            this.search_box_txt.TextChanged += new System.EventHandler(this.search_box_txt_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(781, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 604);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 8);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1108, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 612);
            this.panel4.TabIndex = 16;
            // 
            // purchase_dgv
            // 
            this.purchase_dgv.AllowUserToAddRows = false;
            this.purchase_dgv.AllowUserToDeleteRows = false;
            this.purchase_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchase_dgv.BackgroundColor = System.Drawing.Color.White;
            this.purchase_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.purchase_dgv.ColumnHeadersHeight = 48;
            this.purchase_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Purchase_ID,
            this.Supplier_ID,
            this.Purchase_Date,
            this.Purchase_By,
            this.Purchase_SupplierCompany,
            this.Purchase_SupplierName,
            this.Supplier_Contact});
            this.purchase_dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchase_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchase_dgv.GridColor = System.Drawing.Color.Black;
            this.purchase_dgv.Location = new System.Drawing.Point(8, 63);
            this.purchase_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.purchase_dgv.Name = "purchase_dgv";
            this.purchase_dgv.ReadOnly = true;
            this.purchase_dgv.RowHeadersVisible = false;
            this.purchase_dgv.RowTemplate.Height = 30;
            this.purchase_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchase_dgv.Size = new System.Drawing.Size(1100, 549);
            this.purchase_dgv.TabIndex = 0;
            this.purchase_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchase_dgv_CellClick);
            this.purchase_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchase_dgv_CellContentClick);
            // 
            // Purchase_ID
            // 
            this.Purchase_ID.HeaderText = "Customer ID";
            this.Purchase_ID.Name = "Purchase_ID";
            this.Purchase_ID.ReadOnly = true;
            this.Purchase_ID.Visible = false;
            // 
            // Supplier_ID
            // 
            this.Supplier_ID.HeaderText = "Supplier_ID";
            this.Supplier_ID.Name = "Supplier_ID";
            this.Supplier_ID.ReadOnly = true;
            this.Supplier_ID.Visible = false;
            // 
            // Purchase_Date
            // 
            this.Purchase_Date.FillWeight = 128.9266F;
            this.Purchase_Date.HeaderText = "Date";
            this.Purchase_Date.Name = "Purchase_Date";
            this.Purchase_Date.ReadOnly = true;
            // 
            // Purchase_By
            // 
            this.Purchase_By.FillWeight = 97.27048F;
            this.Purchase_By.HeaderText = "Purchase By";
            this.Purchase_By.Name = "Purchase_By";
            this.Purchase_By.ReadOnly = true;
            // 
            // Purchase_SupplierCompany
            // 
            this.Purchase_SupplierCompany.FillWeight = 97.27048F;
            this.Purchase_SupplierCompany.HeaderText = "Supplier Company";
            this.Purchase_SupplierCompany.Name = "Purchase_SupplierCompany";
            this.Purchase_SupplierCompany.ReadOnly = true;
            // 
            // Purchase_SupplierName
            // 
            this.Purchase_SupplierName.FillWeight = 97.27048F;
            this.Purchase_SupplierName.HeaderText = "Supplier Name";
            this.Purchase_SupplierName.Name = "Purchase_SupplierName";
            this.Purchase_SupplierName.ReadOnly = true;
            // 
            // Supplier_Contact
            // 
            this.Supplier_Contact.HeaderText = "Contact";
            this.Supplier_Contact.Name = "Supplier_Contact";
            this.Supplier_Contact.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.copyright_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(8, 594);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 18);
            this.panel1.TabIndex = 61;
            // 
            // copyright_label
            // 
            this.copyright_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyright_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright_label.ForeColor = System.Drawing.Color.White;
            this.copyright_label.Location = new System.Drawing.Point(4, -1);
            this.copyright_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(607, 18);
            this.copyright_label.TabIndex = 4;
            this.copyright_label.Text = "Copyright © 2020 | All Rights Reserved - KoderSpot.";
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
            this.button2.Location = new System.Drawing.Point(272, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 55);
            this.button2.TabIndex = 11;
            this.button2.Text = "   Purchase Report";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UC_PurchaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.purchase_dgv);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "UC_PurchaseView";
            this.Size = new System.Drawing.Size(1116, 612);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button edit_customer_btn;
        private System.Windows.Forms.TextBox search_box_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView purchase_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_By;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_SupplierCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_Contact;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label copyright_label;
        private System.Windows.Forms.Button button2;

    }
}
