namespace BookShopManagement.UserControls
{
    partial class UC_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Products));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.product_dgv = new System.Windows.Forms.DataGridView();
            this.search_box_txt = new System.Windows.Forms.TextBox();
            this.search_label = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.delete_product_btn = new System.Windows.Forms.Button();
            this.edit_product_btn = new System.Windows.Forms.Button();
            this.add_product_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.copyright_label = new System.Windows.Forms.Label();
            this.Product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Brand_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Category_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Comission_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Entry_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.product_dgv)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // product_dgv
            // 
            this.product_dgv.AllowUserToAddRows = false;
            this.product_dgv.AllowUserToDeleteRows = false;
            this.product_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.product_dgv.BackgroundColor = System.Drawing.Color.White;
            this.product_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.product_dgv.ColumnHeadersHeight = 50;
            this.product_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_ID,
            this.Product_Brand_Name,
            this.Product_Category_Name,
            this.Product_Name,
            this.Product_Model,
            this.Product_Price,
            this.Product_Comission_Price,
            this.Product_Quantity,
            this.Product_Entry_Date,
            this.Product_Status});
            this.product_dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_dgv.GridColor = System.Drawing.Color.Black;
            this.product_dgv.Location = new System.Drawing.Point(8, 63);
            this.product_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.product_dgv.Name = "product_dgv";
            this.product_dgv.ReadOnly = true;
            this.product_dgv.RowHeadersVisible = false;
            this.product_dgv.RowTemplate.Height = 30;
            this.product_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_dgv.Size = new System.Drawing.Size(1100, 531);
            this.product_dgv.TabIndex = 0;
            this.product_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_dgv_CellClick);
            this.product_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_dgv_CellContentClick);
            this.product_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_dgv_CellDoubleClick);
            // 
            // search_box_txt
            // 
            this.search_box_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box_txt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box_txt.Location = new System.Drawing.Point(879, 15);
            this.search_box_txt.Margin = new System.Windows.Forms.Padding(2);
            this.search_box_txt.Name = "search_box_txt";
            this.search_box_txt.Size = new System.Drawing.Size(217, 31);
            this.search_box_txt.TabIndex = 5;
            this.search_box_txt.TextChanged += new System.EventHandler(this.search_box_txt_TextChanged);
            // 
            // search_label
            // 
            this.search_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_label.ForeColor = System.Drawing.Color.White;
            this.search_label.Location = new System.Drawing.Point(801, 20);
            this.search_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(74, 16);
            this.search_label.TabIndex = 4;
            this.search_label.Text = "Search";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.delete_product_btn);
            this.panel5.Controls.Add(this.edit_product_btn);
            this.panel5.Controls.Add(this.search_box_txt);
            this.panel5.Controls.Add(this.search_label);
            this.panel5.Controls.Add(this.add_product_btn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 8);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1100, 55);
            this.panel5.TabIndex = 11;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
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
            this.delete_product_btn.Image = global::BookShopManagement.Properties.Resources.trash_32px;
            this.delete_product_btn.Location = new System.Drawing.Point(236, 0);
            this.delete_product_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_product_btn.Name = "delete_product_btn";
            this.delete_product_btn.Size = new System.Drawing.Size(119, 55);
            this.delete_product_btn.TabIndex = 8;
            this.delete_product_btn.Text = "   Inactivate Product";
            this.delete_product_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_product_btn.UseVisualStyleBackColor = false;
            this.delete_product_btn.Click += new System.EventHandler(this.delete_product_btn_Click);
            // 
            // edit_product_btn
            // 
            this.edit_product_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.edit_product_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_product_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.edit_product_btn.FlatAppearance.BorderSize = 0;
            this.edit_product_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_product_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_product_btn.ForeColor = System.Drawing.Color.White;
            this.edit_product_btn.Image = global::BookShopManagement.Properties.Resources.edit_property_32px;
            this.edit_product_btn.Location = new System.Drawing.Point(120, 0);
            this.edit_product_btn.Margin = new System.Windows.Forms.Padding(2);
            this.edit_product_btn.Name = "edit_product_btn";
            this.edit_product_btn.Size = new System.Drawing.Size(116, 55);
            this.edit_product_btn.TabIndex = 6;
            this.edit_product_btn.Text = "   Edit Product";
            this.edit_product_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_product_btn.UseVisualStyleBackColor = false;
            this.edit_product_btn.Click += new System.EventHandler(this.edit_product_btn_Click);
            // 
            // add_product_btn
            // 
            this.add_product_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.add_product_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_product_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.add_product_btn.FlatAppearance.BorderSize = 0;
            this.add_product_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_product_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product_btn.ForeColor = System.Drawing.Color.White;
            this.add_product_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_product_btn.Image")));
            this.add_product_btn.Location = new System.Drawing.Point(0, 0);
            this.add_product_btn.Margin = new System.Windows.Forms.Padding(2);
            this.add_product_btn.Name = "add_product_btn";
            this.add_product_btn.Size = new System.Drawing.Size(120, 55);
            this.add_product_btn.TabIndex = 0;
            this.add_product_btn.Text = "   Add Product";
            this.add_product_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_product_btn.UseVisualStyleBackColor = false;
            this.add_product_btn.Click += new System.EventHandler(this.add_product_btn_Click);
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
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 8);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.copyright_label.Location = new System.Drawing.Point(9, -1);
            this.copyright_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(631, 18);
            this.copyright_label.TabIndex = 4;
            this.copyright_label.Text = "Copyright © 2020 | All Rights Reserved - KoderSpot.";
            // 
            // Product_ID
            // 
            this.Product_ID.FillWeight = 47.30513F;
            this.Product_ID.HeaderText = "ID";
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.ReadOnly = true;
            this.Product_ID.Visible = false;
            // 
            // Product_Brand_Name
            // 
            this.Product_Brand_Name.FillWeight = 147.166F;
            this.Product_Brand_Name.HeaderText = "Brand Name";
            this.Product_Brand_Name.Name = "Product_Brand_Name";
            this.Product_Brand_Name.ReadOnly = true;
            // 
            // Product_Category_Name
            // 
            this.Product_Category_Name.FillWeight = 147.166F;
            this.Product_Category_Name.HeaderText = "Category";
            this.Product_Category_Name.Name = "Product_Category_Name";
            this.Product_Category_Name.ReadOnly = true;
            // 
            // Product_Name
            // 
            this.Product_Name.FillWeight = 147.166F;
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            // 
            // Product_Model
            // 
            this.Product_Model.FillWeight = 105.4889F;
            this.Product_Model.HeaderText = "Model";
            this.Product_Model.Name = "Product_Model";
            this.Product_Model.ReadOnly = true;
            // 
            // Product_Price
            // 
            this.Product_Price.FillWeight = 72.00848F;
            this.Product_Price.HeaderText = "Price";
            this.Product_Price.Name = "Product_Price";
            this.Product_Price.ReadOnly = true;
            // 
            // Product_Comission_Price
            // 
            this.Product_Comission_Price.FillWeight = 72.82485F;
            this.Product_Comission_Price.HeaderText = "Comission Price";
            this.Product_Comission_Price.Name = "Product_Comission_Price";
            this.Product_Comission_Price.ReadOnly = true;
            // 
            // Product_Quantity
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Product_Quantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.Product_Quantity.FillWeight = 60.5123F;
            this.Product_Quantity.HeaderText = "Quantity";
            this.Product_Quantity.Name = "Product_Quantity";
            this.Product_Quantity.ReadOnly = true;
            // 
            // Product_Entry_Date
            // 
            this.Product_Entry_Date.FillWeight = 147.166F;
            this.Product_Entry_Date.HeaderText = "Entry Date";
            this.Product_Entry_Date.Name = "Product_Entry_Date";
            this.Product_Entry_Date.ReadOnly = true;
            // 
            // Product_Status
            // 
            this.Product_Status.FillWeight = 53.19616F;
            this.Product_Status.HeaderText = "Status";
            this.Product_Status.Name = "Product_Status";
            this.Product_Status.ReadOnly = true;
            // 
            // UC_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.product_dgv);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Products";
            this.Size = new System.Drawing.Size(1116, 612);
            ((System.ComponentModel.ISupportInitialize)(this.product_dgv)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_product_btn;
        private System.Windows.Forms.DataGridView product_dgv;
        private System.Windows.Forms.TextBox search_box_txt;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button edit_product_btn;
        private System.Windows.Forms.Button delete_product_btn;
        private System.Windows.Forms.Label copyright_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Brand_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Category_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Comission_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Entry_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Status;
    }
}