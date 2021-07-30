namespace BookShopManagement.UserControls
{
    partial class UC_Discount_Cards
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.discountcard_dvg = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.edit_product_btn = new System.Windows.Forms.Button();
            this.add_product_btn = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountcard_dvg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.edit_product_btn);
            this.panel5.Controls.Add(this.add_product_btn);
            this.panel5.Controls.Add(this.textBox7);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 8);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1100, 55);
            this.panel5.TabIndex = 15;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(888, 13);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(199, 31);
            this.textBox7.TabIndex = 5;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(827, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Search";
            // 
            // discountcard_dvg
            // 
            this.discountcard_dvg.AllowUserToAddRows = false;
            this.discountcard_dvg.AllowUserToDeleteRows = false;
            this.discountcard_dvg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.discountcard_dvg.BackgroundColor = System.Drawing.Color.White;
            this.discountcard_dvg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.discountcard_dvg.ColumnHeadersHeight = 38;
            this.discountcard_dvg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discountcard_dvg.GridColor = System.Drawing.Color.Black;
            this.discountcard_dvg.Location = new System.Drawing.Point(8, 63);
            this.discountcard_dvg.Margin = new System.Windows.Forms.Padding(2);
            this.discountcard_dvg.Name = "discountcard_dvg";
            this.discountcard_dvg.ReadOnly = true;
            this.discountcard_dvg.RowHeadersVisible = false;
            this.discountcard_dvg.RowTemplate.Height = 30;
            this.discountcard_dvg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.discountcard_dvg.Size = new System.Drawing.Size(1100, 531);
            this.discountcard_dvg.TabIndex = 17;
            this.discountcard_dvg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.discountcard_dvg_CellClick);
            this.discountcard_dvg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.discountcard_dvg_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(8, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 8);
            this.panel3.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 594);
            this.panel2.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1108, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 594);
            this.panel4.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Location = new System.Drawing.Point(0, 594);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 18);
            this.panel1.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, -1);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(354, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Copyright © 2020 | All Rights Reserved - KoderSpot";
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
            this.button1.Location = new System.Drawing.Point(310, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Print Card";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.edit_product_btn.Image = global::BookShopManagement.Properties.Resources.icons8_minus_24;
            this.edit_product_btn.Location = new System.Drawing.Point(155, 0);
            this.edit_product_btn.Margin = new System.Windows.Forms.Padding(2);
            this.edit_product_btn.Name = "edit_product_btn";
            this.edit_product_btn.Size = new System.Drawing.Size(155, 55);
            this.edit_product_btn.TabIndex = 8;
            this.edit_product_btn.Text = "  Show Redeem Points";
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
            this.add_product_btn.Image = global::BookShopManagement.Properties.Resources.icons8_coin_wallet_24;
            this.add_product_btn.Location = new System.Drawing.Point(0, 0);
            this.add_product_btn.Margin = new System.Windows.Forms.Padding(2);
            this.add_product_btn.Name = "add_product_btn";
            this.add_product_btn.Size = new System.Drawing.Size(155, 55);
            this.add_product_btn.TabIndex = 7;
            this.add_product_btn.Text = "  Show Add Points";
            this.add_product_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_product_btn.UseVisualStyleBackColor = false;
            this.add_product_btn.Click += new System.EventHandler(this.add_product_btn_Click);
            // 
            // UC_Discount_Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.discountcard_dvg);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Discount_Cards";
            this.Size = new System.Drawing.Size(1116, 612);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountcard_dvg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView discountcard_dvg;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button edit_product_btn;
        private System.Windows.Forms.Button add_product_btn;
        private System.Windows.Forms.Button button1;
    }
}