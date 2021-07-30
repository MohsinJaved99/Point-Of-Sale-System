namespace BookShopManagement.Forms
{
    partial class Show_Purchase_Products
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.copyright_label = new System.Windows.Forms.Label();
            this.purchasedetails_dvg = new System.Windows.Forms.DataGridView();
            this.close_button = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.edit_customer_btn = new System.Windows.Forms.Button();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedetails_dvg)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 515);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(793, 8);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(793, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 523);
            this.panel4.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.copyright_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 523);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 18);
            this.panel1.TabIndex = 22;
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
            // purchasedetails_dvg
            // 
            this.purchasedetails_dvg.AllowUserToAddRows = false;
            this.purchasedetails_dvg.AllowUserToDeleteRows = false;
            this.purchasedetails_dvg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchasedetails_dvg.BackgroundColor = System.Drawing.Color.White;
            this.purchasedetails_dvg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.purchasedetails_dvg.ColumnHeadersHeight = 38;
            this.purchasedetails_dvg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchasedetails_dvg.GridColor = System.Drawing.Color.Black;
            this.purchasedetails_dvg.Location = new System.Drawing.Point(8, 58);
            this.purchasedetails_dvg.Margin = new System.Windows.Forms.Padding(2);
            this.purchasedetails_dvg.Name = "purchasedetails_dvg";
            this.purchasedetails_dvg.ReadOnly = true;
            this.purchasedetails_dvg.RowHeadersVisible = false;
            this.purchasedetails_dvg.RowTemplate.Height = 30;
            this.purchasedetails_dvg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchasedetails_dvg.Size = new System.Drawing.Size(785, 465);
            this.purchasedetails_dvg.TabIndex = 24;
            this.purchasedetails_dvg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchasedetails_dvg_CellClick);
            this.purchasedetails_dvg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchasedetails_dvg_CellContentClick);
            // 
            // close_button
            // 
            this.close_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.ForeColor = System.Drawing.Color.White;
            this.close_button.Location = new System.Drawing.Point(753, 6);
            this.close_button.Margin = new System.Windows.Forms.Padding(2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(28, 27);
            this.close_button.TabIndex = 130;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.edit_customer_btn);
            this.panel5.Controls.Add(this.close_button);
            this.panel5.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 8);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(785, 50);
            this.panel5.TabIndex = 23;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
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
            this.edit_customer_btn.Location = new System.Drawing.Point(0, 0);
            this.edit_customer_btn.Margin = new System.Windows.Forms.Padding(2);
            this.edit_customer_btn.Name = "edit_customer_btn";
            this.edit_customer_btn.Size = new System.Drawing.Size(138, 50);
            this.edit_customer_btn.TabIndex = 131;
            this.edit_customer_btn.Text = "   Edit Purchase";
            this.edit_customer_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_customer_btn.UseVisualStyleBackColor = false;
            this.edit_customer_btn.Click += new System.EventHandler(this.edit_customer_btn_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panel5;
            // 
            // Show_Purchase_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 541);
            this.Controls.Add(this.purchasedetails_dvg);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Show_Purchase_Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show_Purchase_Products";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchasedetails_dvg)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label copyright_label;
        private System.Windows.Forms.DataGridView purchasedetails_dvg;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button edit_customer_btn;
        private DragControlDemo.DragControl dragControl1;
    }
}