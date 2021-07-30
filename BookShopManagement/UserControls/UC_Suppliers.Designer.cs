namespace BookShopManagement.UserControls
{
    partial class UC_Suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Suppliers));
            this.suppliers_dgv = new System.Windows.Forms.DataGridView();
            this.Supplier_ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_Company1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_Contact_Person1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_Number1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_Address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_CNIC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_Entry_Date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.delete_supplier_btn = new System.Windows.Forms.Button();
            this.edit_supplier_btn = new System.Windows.Forms.Button();
            this.search_box_txt = new System.Windows.Forms.TextBox();
            this.search_label = new System.Windows.Forms.Label();
            this.add_supplier_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.copyright_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.suppliers_dgv)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // suppliers_dgv
            // 
            this.suppliers_dgv.AllowUserToAddRows = false;
            this.suppliers_dgv.AllowUserToDeleteRows = false;
            this.suppliers_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliers_dgv.BackgroundColor = System.Drawing.Color.White;
            this.suppliers_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.suppliers_dgv.ColumnHeadersHeight = 38;
            this.suppliers_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Supplier_ID1,
            this.Supplier_Company1,
            this.Supplier_Contact_Person1,
            this.Supplier_Number1,
            this.Supplier_Address1,
            this.Supplier_CNIC1,
            this.Supplier_Entry_Date1,
            this.Supplier_Status});
            this.suppliers_dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suppliers_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppliers_dgv.GridColor = System.Drawing.Color.Black;
            this.suppliers_dgv.Location = new System.Drawing.Point(8, 63);
            this.suppliers_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.suppliers_dgv.Name = "suppliers_dgv";
            this.suppliers_dgv.ReadOnly = true;
            this.suppliers_dgv.RowHeadersVisible = false;
            this.suppliers_dgv.RowTemplate.Height = 30;
            this.suppliers_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.suppliers_dgv.Size = new System.Drawing.Size(1100, 531);
            this.suppliers_dgv.TabIndex = 18;
            this.suppliers_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliers_dgv_CellClick);
            this.suppliers_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliers_dgv_CellContentClick);
            this.suppliers_dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.suppliers_dgv_CellFormatting);
            // 
            // Supplier_ID1
            // 
            this.Supplier_ID1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Supplier_ID1.HeaderText = "Supplier ID";
            this.Supplier_ID1.Name = "Supplier_ID1";
            this.Supplier_ID1.ReadOnly = true;
            this.Supplier_ID1.Visible = false;
            this.Supplier_ID1.Width = 78;
            // 
            // Supplier_Company1
            // 
            this.Supplier_Company1.HeaderText = "Company";
            this.Supplier_Company1.Name = "Supplier_Company1";
            this.Supplier_Company1.ReadOnly = true;
            // 
            // Supplier_Contact_Person1
            // 
            this.Supplier_Contact_Person1.HeaderText = "Contact Person";
            this.Supplier_Contact_Person1.Name = "Supplier_Contact_Person1";
            this.Supplier_Contact_Person1.ReadOnly = true;
            // 
            // Supplier_Number1
            // 
            this.Supplier_Number1.HeaderText = "Phone Number";
            this.Supplier_Number1.Name = "Supplier_Number1";
            this.Supplier_Number1.ReadOnly = true;
            // 
            // Supplier_Address1
            // 
            this.Supplier_Address1.HeaderText = "Address";
            this.Supplier_Address1.Name = "Supplier_Address1";
            this.Supplier_Address1.ReadOnly = true;
            // 
            // Supplier_CNIC1
            // 
            this.Supplier_CNIC1.HeaderText = "CNIC";
            this.Supplier_CNIC1.Name = "Supplier_CNIC1";
            this.Supplier_CNIC1.ReadOnly = true;
            // 
            // Supplier_Entry_Date1
            // 
            this.Supplier_Entry_Date1.HeaderText = "Entry Date";
            this.Supplier_Entry_Date1.Name = "Supplier_Entry_Date1";
            this.Supplier_Entry_Date1.ReadOnly = true;
            // 
            // Supplier_Status
            // 
            this.Supplier_Status.HeaderText = "Status";
            this.Supplier_Status.Name = "Supplier_Status";
            this.Supplier_Status.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.delete_supplier_btn);
            this.panel5.Controls.Add(this.edit_supplier_btn);
            this.panel5.Controls.Add(this.search_box_txt);
            this.panel5.Controls.Add(this.search_label);
            this.panel5.Controls.Add(this.add_supplier_btn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 8);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1100, 55);
            this.panel5.TabIndex = 17;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // delete_supplier_btn
            // 
            this.delete_supplier_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.delete_supplier_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_supplier_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.delete_supplier_btn.FlatAppearance.BorderSize = 0;
            this.delete_supplier_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_supplier_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_supplier_btn.ForeColor = System.Drawing.Color.White;
            this.delete_supplier_btn.Image = ((System.Drawing.Image)(resources.GetObject("delete_supplier_btn.Image")));
            this.delete_supplier_btn.Location = new System.Drawing.Point(220, 0);
            this.delete_supplier_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_supplier_btn.Name = "delete_supplier_btn";
            this.delete_supplier_btn.Size = new System.Drawing.Size(116, 55);
            this.delete_supplier_btn.TabIndex = 7;
            this.delete_supplier_btn.Text = "   Inactivate  Supplier";
            this.delete_supplier_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_supplier_btn.UseVisualStyleBackColor = false;
            this.delete_supplier_btn.Click += new System.EventHandler(this.delete_supplier_btn_Click);
            // 
            // edit_supplier_btn
            // 
            this.edit_supplier_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.edit_supplier_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_supplier_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.edit_supplier_btn.FlatAppearance.BorderSize = 0;
            this.edit_supplier_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_supplier_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_supplier_btn.ForeColor = System.Drawing.Color.White;
            this.edit_supplier_btn.Image = global::BookShopManagement.Properties.Resources.edit_property_32px;
            this.edit_supplier_btn.Location = new System.Drawing.Point(108, 0);
            this.edit_supplier_btn.Margin = new System.Windows.Forms.Padding(2);
            this.edit_supplier_btn.Name = "edit_supplier_btn";
            this.edit_supplier_btn.Size = new System.Drawing.Size(112, 55);
            this.edit_supplier_btn.TabIndex = 6;
            this.edit_supplier_btn.Text = "   Edit Supplier";
            this.edit_supplier_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_supplier_btn.UseVisualStyleBackColor = false;
            this.edit_supplier_btn.Click += new System.EventHandler(this.edit_supplier_btn_Click);
            // 
            // search_box_txt
            // 
            this.search_box_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box_txt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box_txt.Location = new System.Drawing.Point(860, 16);
            this.search_box_txt.Margin = new System.Windows.Forms.Padding(2);
            this.search_box_txt.Name = "search_box_txt";
            this.search_box_txt.Size = new System.Drawing.Size(233, 31);
            this.search_box_txt.TabIndex = 5;
            this.search_box_txt.TextChanged += new System.EventHandler(this.search_box_txt_TextChanged);
            // 
            // search_label
            // 
            this.search_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_label.ForeColor = System.Drawing.Color.White;
            this.search_label.Location = new System.Drawing.Point(800, 23);
            this.search_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(74, 16);
            this.search_label.TabIndex = 4;
            this.search_label.Text = "Search";
            // 
            // add_supplier_btn
            // 
            this.add_supplier_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.add_supplier_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_supplier_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.add_supplier_btn.FlatAppearance.BorderSize = 0;
            this.add_supplier_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_supplier_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_supplier_btn.ForeColor = System.Drawing.Color.White;
            this.add_supplier_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_supplier_btn.Image")));
            this.add_supplier_btn.Location = new System.Drawing.Point(0, 0);
            this.add_supplier_btn.Margin = new System.Windows.Forms.Padding(2);
            this.add_supplier_btn.Name = "add_supplier_btn";
            this.add_supplier_btn.Size = new System.Drawing.Size(108, 55);
            this.add_supplier_btn.TabIndex = 0;
            this.add_supplier_btn.Text = "   Add Supplier";
            this.add_supplier_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_supplier_btn.UseVisualStyleBackColor = false;
            this.add_supplier_btn.Click += new System.EventHandler(this.add_supplier_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 594);
            this.panel2.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1108, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 594);
            this.panel4.TabIndex = 21;
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
            this.panel1.TabIndex = 22;
            // 
            // copyright_label
            // 
            this.copyright_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyright_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright_label.ForeColor = System.Drawing.Color.White;
            this.copyright_label.Location = new System.Drawing.Point(12, -1);
            this.copyright_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(606, 18);
            this.copyright_label.TabIndex = 4;
            this.copyright_label.Text = "Copyright © 2020 | All Rights Reserved - KoderSpot.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel3.Location = new System.Drawing.Point(8, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 8);
            this.panel3.TabIndex = 20;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // UC_Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.suppliers_dgv);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Suppliers";
            this.Size = new System.Drawing.Size(1116, 612);
            ((System.ComponentModel.ISupportInitialize)(this.suppliers_dgv)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView suppliers_dgv;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox search_box_txt;
        private System.Windows.Forms.Button add_supplier_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button edit_supplier_btn;
        private System.Windows.Forms.Button delete_supplier_btn;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.Label copyright_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_ID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_Company1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_Contact_Person1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_Number1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_Address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_CNIC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_Entry_Date1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_Status;
    }
}