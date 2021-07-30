namespace BookShopManagement.UserControls
{
    partial class UC_Daily_Expenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Daily_Expenses));
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.copyright_label = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.add_expense_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.search_box_txt = new System.Windows.Forms.TextBox();
            this.edit_expense_btn = new System.Windows.Forms.Button();
            this.delete_expense_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.expense_dgv = new System.Windows.Forms.DataGridView();
            this.Expense_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expense_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expense_Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expense_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expense_dgv)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.HeaderText = "Tracking ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // title
            // 
            this.title.HeaderText = "Expense Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // amountt
            // 
            this.amountt.HeaderText = "Expense Amount";
            this.amountt.Name = "amountt";
            this.amountt.ReadOnly = true;
            // 
            // purpose
            // 
            this.purpose.HeaderText = "Expense Purpose";
            this.purpose.Name = "purpose";
            this.purpose.ReadOnly = true;
            // 
            // expDate
            // 
            this.expDate.HeaderText = "Expense Date";
            this.expDate.Name = "expDate";
            this.expDate.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1108, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 612);
            this.panel4.TabIndex = 97;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.copyright_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 594);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 18);
            this.panel1.TabIndex = 98;
            // 
            // copyright_label
            // 
            this.copyright_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyright_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright_label.ForeColor = System.Drawing.Color.White;
            this.copyright_label.Location = new System.Drawing.Point(8, -2);
            this.copyright_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(556, 18);
            this.copyright_label.TabIndex = 4;
            this.copyright_label.Text = "Copyright © 2020 | All Rights Reserved - KoderSpot.";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.delete_expense_btn);
            this.panel5.Controls.Add(this.edit_expense_btn);
            this.panel5.Controls.Add(this.search_box_txt);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.add_expense_btn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1108, 61);
            this.panel5.TabIndex = 99;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // add_expense_btn
            // 
            this.add_expense_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.add_expense_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_expense_btn.FlatAppearance.BorderSize = 0;
            this.add_expense_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_expense_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_expense_btn.ForeColor = System.Drawing.Color.White;
            this.add_expense_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_expense_btn.Image")));
            this.add_expense_btn.Location = new System.Drawing.Point(8, 10);
            this.add_expense_btn.Margin = new System.Windows.Forms.Padding(2);
            this.add_expense_btn.Name = "add_expense_btn";
            this.add_expense_btn.Size = new System.Drawing.Size(151, 51);
            this.add_expense_btn.TabIndex = 0;
            this.add_expense_btn.Text = "   Add Expense";
            this.add_expense_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_expense_btn.UseVisualStyleBackColor = false;
            this.add_expense_btn.Click += new System.EventHandler(this.add_expense_btn_Click_1);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(859, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Search";
            // 
            // search_box_txt
            // 
            this.search_box_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box_txt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box_txt.Location = new System.Drawing.Point(917, 19);
            this.search_box_txt.Margin = new System.Windows.Forms.Padding(2);
            this.search_box_txt.Name = "search_box_txt";
            this.search_box_txt.Size = new System.Drawing.Size(185, 31);
            this.search_box_txt.TabIndex = 5;
            this.search_box_txt.TextChanged += new System.EventHandler(this.search_box_txt_TextChanged_1);
            // 
            // edit_expense_btn
            // 
            this.edit_expense_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.edit_expense_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_expense_btn.FlatAppearance.BorderSize = 0;
            this.edit_expense_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_expense_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_expense_btn.ForeColor = System.Drawing.Color.White;
            this.edit_expense_btn.Image = global::BookShopManagement.Properties.Resources.edit_property_32px;
            this.edit_expense_btn.Location = new System.Drawing.Point(159, 10);
            this.edit_expense_btn.Margin = new System.Windows.Forms.Padding(2);
            this.edit_expense_btn.Name = "edit_expense_btn";
            this.edit_expense_btn.Size = new System.Drawing.Size(166, 51);
            this.edit_expense_btn.TabIndex = 6;
            this.edit_expense_btn.Text = "   Edit Expense";
            this.edit_expense_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_expense_btn.UseVisualStyleBackColor = false;
            this.edit_expense_btn.Click += new System.EventHandler(this.edit_expense_btn_Click_1);
            // 
            // delete_expense_btn
            // 
            this.delete_expense_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.delete_expense_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_expense_btn.FlatAppearance.BorderSize = 0;
            this.delete_expense_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_expense_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_expense_btn.ForeColor = System.Drawing.Color.White;
            this.delete_expense_btn.Image = global::BookShopManagement.Properties.Resources.trash_32px;
            this.delete_expense_btn.Location = new System.Drawing.Point(324, 10);
            this.delete_expense_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_expense_btn.Name = "delete_expense_btn";
            this.delete_expense_btn.Size = new System.Drawing.Size(166, 51);
            this.delete_expense_btn.TabIndex = 7;
            this.delete_expense_btn.Text = "   Delete Expense";
            this.delete_expense_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_expense_btn.UseVisualStyleBackColor = false;
            this.delete_expense_btn.Click += new System.EventHandler(this.delete_expense_btn_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 61);
            this.panel3.TabIndex = 96;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(8, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1100, 10);
            this.panel8.TabIndex = 97;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 533);
            this.panel2.TabIndex = 95;
            // 
            // expense_dgv
            // 
            this.expense_dgv.AllowUserToAddRows = false;
            this.expense_dgv.AllowUserToDeleteRows = false;
            this.expense_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expense_dgv.BackgroundColor = System.Drawing.Color.White;
            this.expense_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.expense_dgv.ColumnHeadersHeight = 38;
            this.expense_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Expense_ID,
            this.Expense_Purpose,
            this.Expense_Amount,
            this.Expense_Date});
            this.expense_dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expense_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expense_dgv.GridColor = System.Drawing.Color.Black;
            this.expense_dgv.Location = new System.Drawing.Point(8, 61);
            this.expense_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.expense_dgv.Name = "expense_dgv";
            this.expense_dgv.ReadOnly = true;
            this.expense_dgv.RowHeadersVisible = false;
            this.expense_dgv.RowTemplate.Height = 30;
            this.expense_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.expense_dgv.Size = new System.Drawing.Size(1100, 533);
            this.expense_dgv.TabIndex = 94;
            this.expense_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expense_dgv_CellClick_1);
            this.expense_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expense_dgv_CellContentClick);
            // 
            // Expense_Date
            // 
            this.Expense_Date.HeaderText = "Expense Date";
            this.Expense_Date.Name = "Expense_Date";
            this.Expense_Date.ReadOnly = true;
            // 
            // Expense_Amount
            // 
            this.Expense_Amount.HeaderText = "Expense Amount";
            this.Expense_Amount.Name = "Expense_Amount";
            this.Expense_Amount.ReadOnly = true;
            // 
            // Expense_Purpose
            // 
            this.Expense_Purpose.HeaderText = "Expense Purpose";
            this.Expense_Purpose.Name = "Expense_Purpose";
            this.Expense_Purpose.ReadOnly = true;
            // 
            // Expense_ID
            // 
            this.Expense_ID.HeaderText = "Expense ID";
            this.Expense_ID.Name = "Expense_ID";
            this.Expense_ID.ReadOnly = true;
            this.Expense_ID.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.expense_dgv);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1116, 612);
            this.panel6.TabIndex = 94;
            // 
            // UC_Daily_Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel6);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Daily_Expenses";
            this.Size = new System.Drawing.Size(1116, 612);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expense_dgv)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountt;
        private System.Windows.Forms.DataGridViewTextBoxColumn purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn expDate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label copyright_label;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button delete_expense_btn;
        private System.Windows.Forms.Button edit_expense_btn;
        private System.Windows.Forms.TextBox search_box_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add_expense_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView expense_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expense_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expense_Purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expense_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expense_Date;
        private System.Windows.Forms.Panel panel6;
    }
}