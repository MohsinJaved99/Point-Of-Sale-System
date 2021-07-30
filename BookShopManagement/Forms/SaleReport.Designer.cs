namespace BookShopManagement.Forms
{
    partial class SaleReport
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
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.product_label = new System.Windows.Forms.Label();
            this.discount_label = new System.Windows.Forms.Label();
            this.customer_combo = new System.Windows.Forms.ComboBox();
            this.add_to_cart_btn = new System.Windows.Forms.Button();
            this.card_num_txr = new System.Windows.Forms.TextBox();
            this.card_num_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.heading_label = new System.Windows.Forms.Label();
            this.customer_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.copyright_label = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.close_button = new System.Windows.Forms.Button();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label12.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(8, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(994, 46);
            this.label12.TabIndex = 68;
            this.label12.Text = "Sale Report";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Controls.Add(this.product_label);
            this.panel3.Controls.Add(this.discount_label);
            this.panel3.Controls.Add(this.customer_combo);
            this.panel3.Controls.Add(this.add_to_cart_btn);
            this.panel3.Controls.Add(this.card_num_txr);
            this.panel3.Controls.Add(this.card_num_label);
            this.panel3.Controls.Add(this.price_label);
            this.panel3.Controls.Add(this.heading_label);
            this.panel3.Controls.Add(this.customer_label);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel3.Location = new System.Drawing.Point(8, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(994, 8);
            this.panel3.TabIndex = 65;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // product_label
            // 
            this.product_label.AutoSize = true;
            this.product_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_label.Location = new System.Drawing.Point(168, -73);
            this.product_label.Name = "product_label";
            this.product_label.Size = new System.Drawing.Size(122, 20);
            this.product_label.TabIndex = 49;
            this.product_label.Text = "Product Name";
            // 
            // discount_label
            // 
            this.discount_label.AutoSize = true;
            this.discount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_label.Location = new System.Drawing.Point(460, -21);
            this.discount_label.Name = "discount_label";
            this.discount_label.Size = new System.Drawing.Size(80, 20);
            this.discount_label.TabIndex = 47;
            this.discount_label.Text = "Discount";
            // 
            // customer_combo
            // 
            this.customer_combo.FormattingEnabled = true;
            this.customer_combo.Location = new System.Drawing.Point(309, -127);
            this.customer_combo.Name = "customer_combo";
            this.customer_combo.Size = new System.Drawing.Size(427, 28);
            this.customer_combo.TabIndex = 46;
            // 
            // add_to_cart_btn
            // 
            this.add_to_cart_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.add_to_cart_btn.FlatAppearance.BorderSize = 0;
            this.add_to_cart_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_to_cart_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_to_cart_btn.ForeColor = System.Drawing.Color.White;
            this.add_to_cart_btn.Location = new System.Drawing.Point(170, 156);
            this.add_to_cart_btn.Name = "add_to_cart_btn";
            this.add_to_cart_btn.Size = new System.Drawing.Size(566, 38);
            this.add_to_cart_btn.TabIndex = 45;
            this.add_to_cart_btn.Text = "Add to Cart";
            this.add_to_cart_btn.UseVisualStyleBackColor = false;
            // 
            // card_num_txr
            // 
            this.card_num_txr.Location = new System.Drawing.Point(308, 85);
            this.card_num_txr.Name = "card_num_txr";
            this.card_num_txr.Size = new System.Drawing.Size(428, 26);
            this.card_num_txr.TabIndex = 44;
            // 
            // card_num_label
            // 
            this.card_num_label.AutoSize = true;
            this.card_num_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_num_label.Location = new System.Drawing.Point(168, 88);
            this.card_num_label.Name = "card_num_label";
            this.card_num_label.Size = new System.Drawing.Size(79, 20);
            this.card_num_label.TabIndex = 40;
            this.card_num_label.Text = "Card No.";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.Location = new System.Drawing.Point(168, -21);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(49, 20);
            this.price_label.TabIndex = 41;
            this.price_label.Text = "Price";
            // 
            // heading_label
            // 
            this.heading_label.AutoSize = true;
            this.heading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_label.Location = new System.Drawing.Point(378, -185);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(170, 29);
            this.heading_label.TabIndex = 42;
            this.heading_label.Text = "Product Sale ";
            // 
            // customer_label
            // 
            this.customer_label.AutoSize = true;
            this.customer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_label.Location = new System.Drawing.Point(166, -124);
            this.customer_label.Name = "customer_label";
            this.customer_label.Size = new System.Drawing.Size(137, 20);
            this.customer_label.TabIndex = 43;
            this.customer_label.Text = "Customer Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 741);
            this.panel2.TabIndex = 64;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1002, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 741);
            this.panel4.TabIndex = 66;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.copyright_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 741);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 18);
            this.panel1.TabIndex = 67;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // copyright_label
            // 
            this.copyright_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyright_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright_label.ForeColor = System.Drawing.Color.White;
            this.copyright_label.Location = new System.Drawing.Point(8, -1);
            this.copyright_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(557, 18);
            this.copyright_label.TabIndex = 4;
            this.copyright_label.Text = "Copyright © 2020 | All Rights Reserved - KoderSpot.";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(8, 54);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowPageNavigateButtons = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(994, 687);
            this.crystalReportViewer1.TabIndex = 69;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
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
            this.close_button.Location = new System.Drawing.Point(965, 8);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(37, 33);
            this.close_button.TabIndex = 70;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.label12;
            // 
            // SaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 759);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleReport";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label product_label;
        private System.Windows.Forms.Label discount_label;
        private System.Windows.Forms.ComboBox customer_combo;
        private System.Windows.Forms.Button add_to_cart_btn;
        private System.Windows.Forms.TextBox card_num_txr;
        private System.Windows.Forms.Label card_num_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.Label customer_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label copyright_label;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button close_button;
        private DragControlDemo.DragControl dragControl1;
    }
}