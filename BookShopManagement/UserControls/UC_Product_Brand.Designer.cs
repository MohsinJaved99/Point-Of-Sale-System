namespace BookShopManagement.UserControls
{
    partial class UC_Product_Brand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Product_Brand));
            this.product_brand_dgv = new System.Windows.Forms.DataGridView();
            this.Brand_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.delete_category_btn = new System.Windows.Forms.Button();
            this.edit_category_btn = new System.Windows.Forms.Button();
            this.search_box_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.add_category_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.copyright_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.product_brand_dgv)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // product_brand_dgv
            // 
            this.product_brand_dgv.AllowUserToAddRows = false;
            this.product_brand_dgv.AllowUserToDeleteRows = false;
            this.product_brand_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.product_brand_dgv.BackgroundColor = System.Drawing.Color.White;
            this.product_brand_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.product_brand_dgv.ColumnHeadersHeight = 38;
            this.product_brand_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Brand_ID,
            this.Brand_Name,
            this.Brand_Status});
            this.product_brand_dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product_brand_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_brand_dgv.GridColor = System.Drawing.Color.Black;
            this.product_brand_dgv.Location = new System.Drawing.Point(8, 63);
            this.product_brand_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.product_brand_dgv.Name = "product_brand_dgv";
            this.product_brand_dgv.ReadOnly = true;
            this.product_brand_dgv.RowHeadersVisible = false;
            this.product_brand_dgv.RowTemplate.Height = 30;
            this.product_brand_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_brand_dgv.Size = new System.Drawing.Size(1100, 531);
            this.product_brand_dgv.TabIndex = 41;
            this.product_brand_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_brand_dgv_CellClick);
            this.product_brand_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_brand_dgv_CellContentClick);
            this.product_brand_dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.product_brand_dgv_CellFormatting);
            // 
            // Brand_ID
            // 
            this.Brand_ID.HeaderText = "Brand ID";
            this.Brand_ID.Name = "Brand_ID";
            this.Brand_ID.ReadOnly = true;
            this.Brand_ID.Visible = false;
            // 
            // Brand_Name
            // 
            this.Brand_Name.HeaderText = "Brand Name";
            this.Brand_Name.Name = "Brand_Name";
            this.Brand_Name.ReadOnly = true;
            // 
            // Brand_Status
            // 
            this.Brand_Status.HeaderText = "Brand Status";
            this.Brand_Status.Name = "Brand_Status";
            this.Brand_Status.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.delete_category_btn);
            this.panel5.Controls.Add(this.edit_category_btn);
            this.panel5.Controls.Add(this.search_box_txt);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.add_category_btn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 8);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1100, 55);
            this.panel5.TabIndex = 35;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // delete_category_btn
            // 
            this.delete_category_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.delete_category_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_category_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.delete_category_btn.FlatAppearance.BorderSize = 0;
            this.delete_category_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_category_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_category_btn.ForeColor = System.Drawing.Color.White;
            this.delete_category_btn.Image = global::BookShopManagement.Properties.Resources.trash_32px;
            this.delete_category_btn.Location = new System.Drawing.Point(311, 0);
            this.delete_category_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_category_btn.Name = "delete_category_btn";
            this.delete_category_btn.Size = new System.Drawing.Size(154, 55);
            this.delete_category_btn.TabIndex = 7;
            this.delete_category_btn.Text = "   Delete Brand";
            this.delete_category_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_category_btn.UseVisualStyleBackColor = false;
            this.delete_category_btn.Click += new System.EventHandler(this.delete_category_btn_Click);
            // 
            // edit_category_btn
            // 
            this.edit_category_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.edit_category_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_category_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.edit_category_btn.FlatAppearance.BorderSize = 0;
            this.edit_category_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_category_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_category_btn.ForeColor = System.Drawing.Color.White;
            this.edit_category_btn.Image = global::BookShopManagement.Properties.Resources.edit_property_32px;
            this.edit_category_btn.Location = new System.Drawing.Point(157, 0);
            this.edit_category_btn.Margin = new System.Windows.Forms.Padding(2);
            this.edit_category_btn.Name = "edit_category_btn";
            this.edit_category_btn.Size = new System.Drawing.Size(154, 55);
            this.edit_category_btn.TabIndex = 6;
            this.edit_category_btn.Text = "   Edit Brand";
            this.edit_category_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_category_btn.UseVisualStyleBackColor = false;
            this.edit_category_btn.Click += new System.EventHandler(this.edit_category_btn_Click);
            // 
            // search_box_txt
            // 
            this.search_box_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box_txt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box_txt.Location = new System.Drawing.Point(925, 12);
            this.search_box_txt.Margin = new System.Windows.Forms.Padding(2);
            this.search_box_txt.Name = "search_box_txt";
            this.search_box_txt.Size = new System.Drawing.Size(170, 31);
            this.search_box_txt.TabIndex = 5;
            this.search_box_txt.TextChanged += new System.EventHandler(this.search_box_txt_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(861, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Search";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // add_category_btn
            // 
            this.add_category_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.add_category_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_category_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.add_category_btn.FlatAppearance.BorderSize = 0;
            this.add_category_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_category_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_category_btn.ForeColor = System.Drawing.Color.White;
            this.add_category_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_category_btn.Image")));
            this.add_category_btn.Location = new System.Drawing.Point(0, 0);
            this.add_category_btn.Margin = new System.Windows.Forms.Padding(2);
            this.add_category_btn.Name = "add_category_btn";
            this.add_category_btn.Size = new System.Drawing.Size(157, 55);
            this.add_category_btn.TabIndex = 0;
            this.add_category_btn.Text = "   Add Brand";
            this.add_category_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_category_btn.UseVisualStyleBackColor = false;
            this.add_category_btn.Click += new System.EventHandler(this.add_category_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.copyright_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(8, 594);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 18);
            this.panel1.TabIndex = 40;
            // 
            // copyright_label
            // 
            this.copyright_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyright_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright_label.ForeColor = System.Drawing.Color.White;
            this.copyright_label.Location = new System.Drawing.Point(0, -2);
            this.copyright_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(550, 18);
            this.copyright_label.TabIndex = 4;
            this.copyright_label.Text = "Copyright © 2020 | All Rights Reserved - KoderSpot.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(8, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 8);
            this.panel3.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 612);
            this.panel2.TabIndex = 37;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1108, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 612);
            this.panel4.TabIndex = 39;
            // 
            // UC_Product_Brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.product_brand_dgv);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Product_Brand";
            this.Size = new System.Drawing.Size(1116, 612);
            ((System.ComponentModel.ISupportInitialize)(this.product_brand_dgv)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView product_brand_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand_Status;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button delete_category_btn;
        private System.Windows.Forms.Button edit_category_btn;
        private System.Windows.Forms.TextBox search_box_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add_category_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label copyright_label;
    }
}