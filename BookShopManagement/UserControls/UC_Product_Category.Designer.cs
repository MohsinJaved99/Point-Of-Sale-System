namespace BookShopManagement.UserControls
{
    partial class UC_Product_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Product_Category));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.delete_category_btn = new System.Windows.Forms.Button();
            this.edit_category_btn = new System.Windows.Forms.Button();
            this.search_box_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.add_category_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.copyright_label = new System.Windows.Forms.Label();
            this.product_category_dgv = new System.Windows.Forms.DataGridView();
            this.Category_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_category_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 529);
            this.panel2.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1108, 65);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 529);
            this.panel4.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.delete_category_btn);
            this.panel5.Controls.Add(this.edit_category_btn);
            this.panel5.Controls.Add(this.search_box_txt);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.add_category_btn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1116, 65);
            this.panel5.TabIndex = 28;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1106, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 65);
            this.panel7.TabIndex = 27;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 65);
            this.panel6.TabIndex = 26;
            // 
            // delete_category_btn
            // 
            this.delete_category_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.delete_category_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_category_btn.FlatAppearance.BorderSize = 0;
            this.delete_category_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_category_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_category_btn.ForeColor = System.Drawing.Color.White;
            this.delete_category_btn.Image = global::BookShopManagement.Properties.Resources.trash_32px;
            this.delete_category_btn.Location = new System.Drawing.Point(233, 10);
            this.delete_category_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_category_btn.Name = "delete_category_btn";
            this.delete_category_btn.Size = new System.Drawing.Size(124, 55);
            this.delete_category_btn.TabIndex = 7;
            this.delete_category_btn.Text = "   Delete Category";
            this.delete_category_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_category_btn.UseVisualStyleBackColor = false;
            this.delete_category_btn.Click += new System.EventHandler(this.delete_category_btn_Click);
            // 
            // edit_category_btn
            // 
            this.edit_category_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.edit_category_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_category_btn.FlatAppearance.BorderSize = 0;
            this.edit_category_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_category_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_category_btn.ForeColor = System.Drawing.Color.White;
            this.edit_category_btn.Image = global::BookShopManagement.Properties.Resources.edit_property_32px;
            this.edit_category_btn.Location = new System.Drawing.Point(121, 10);
            this.edit_category_btn.Margin = new System.Windows.Forms.Padding(2);
            this.edit_category_btn.Name = "edit_category_btn";
            this.edit_category_btn.Size = new System.Drawing.Size(113, 55);
            this.edit_category_btn.TabIndex = 6;
            this.edit_category_btn.Text = "   Edit Category";
            this.edit_category_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_category_btn.UseVisualStyleBackColor = false;
            this.edit_category_btn.Click += new System.EventHandler(this.edit_category_btn_Click);
            // 
            // search_box_txt
            // 
            this.search_box_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box_txt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box_txt.Location = new System.Drawing.Point(892, 20);
            this.search_box_txt.Margin = new System.Windows.Forms.Padding(2);
            this.search_box_txt.Name = "search_box_txt";
            this.search_box_txt.Size = new System.Drawing.Size(208, 31);
            this.search_box_txt.TabIndex = 5;
            this.search_box_txt.TextChanged += new System.EventHandler(this.search_box_txt_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(814, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Search";
            // 
            // add_category_btn
            // 
            this.add_category_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.add_category_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_category_btn.FlatAppearance.BorderSize = 0;
            this.add_category_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_category_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_category_btn.ForeColor = System.Drawing.Color.White;
            this.add_category_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_category_btn.Image")));
            this.add_category_btn.Location = new System.Drawing.Point(10, 10);
            this.add_category_btn.Margin = new System.Windows.Forms.Padding(2);
            this.add_category_btn.Name = "add_category_btn";
            this.add_category_btn.Size = new System.Drawing.Size(112, 55);
            this.add_category_btn.TabIndex = 0;
            this.add_category_btn.Text = "   Add Category";
            this.add_category_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_category_btn.UseVisualStyleBackColor = false;
            this.add_category_btn.Click += new System.EventHandler(this.add_category_btn_Click);
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
            this.panel1.TabIndex = 33;
            // 
            // copyright_label
            // 
            this.copyright_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyright_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright_label.ForeColor = System.Drawing.Color.White;
            this.copyright_label.Location = new System.Drawing.Point(10, -2);
            this.copyright_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(553, 18);
            this.copyright_label.TabIndex = 4;
            this.copyright_label.Text = "Copyright © 2020 | All Rights Reserved - KoderSpot.";
            // 
            // product_category_dgv
            // 
            this.product_category_dgv.AllowUserToAddRows = false;
            this.product_category_dgv.AllowUserToDeleteRows = false;
            this.product_category_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.product_category_dgv.BackgroundColor = System.Drawing.Color.White;
            this.product_category_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.product_category_dgv.ColumnHeadersHeight = 38;
            this.product_category_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category_ID,
            this.Category_Name,
            this.Category_Status});
            this.product_category_dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product_category_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_category_dgv.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.product_category_dgv.Location = new System.Drawing.Point(10, 65);
            this.product_category_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.product_category_dgv.Name = "product_category_dgv";
            this.product_category_dgv.ReadOnly = true;
            this.product_category_dgv.RowHeadersVisible = false;
            this.product_category_dgv.RowTemplate.Height = 30;
            this.product_category_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_category_dgv.Size = new System.Drawing.Size(1098, 529);
            this.product_category_dgv.TabIndex = 34;
            this.product_category_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_category_dgv_CellClick);
            this.product_category_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_category_dgv_CellContentClick);
            this.product_category_dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.product_category_dgv_CellFormatting);
            // 
            // Category_ID
            // 
            this.Category_ID.HeaderText = "Category ID";
            this.Category_ID.Name = "Category_ID";
            this.Category_ID.ReadOnly = true;
            this.Category_ID.Visible = false;
            // 
            // Category_Name
            // 
            this.Category_Name.HeaderText = "Category Name";
            this.Category_Name.Name = "Category_Name";
            this.Category_Name.ReadOnly = true;
            // 
            // Category_Status
            // 
            this.Category_Status.HeaderText = "Category Status";
            this.Category_Status.Name = "Category_Status";
            this.Category_Status.ReadOnly = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel8.Location = new System.Drawing.Point(10, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1096, 10);
            this.panel8.TabIndex = 35;
            // 
            // UC_Product_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.product_category_dgv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Product_Category";
            this.Size = new System.Drawing.Size(1116, 612);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.product_category_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button delete_category_btn;
        private System.Windows.Forms.Button edit_category_btn;
        private System.Windows.Forms.Button add_category_btn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox search_box_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView product_category_dgv;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label copyright_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Status;
    }
}