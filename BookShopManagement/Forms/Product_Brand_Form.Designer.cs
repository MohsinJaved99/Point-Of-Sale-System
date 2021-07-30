namespace BookShopManagement.Forms
{
    partial class Product_Brand_Form
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
            this.brand_status_combo = new System.Windows.Forms.ComboBox();
            this.brand_status_error = new System.Windows.Forms.Label();
            this.brand_name_error = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear_btn = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.brand_name_txt = new System.Windows.Forms.TextBox();
            this.category_status_label = new System.Windows.Forms.Label();
            this.category_name_label = new System.Windows.Forms.Label();
            this.heading_label = new System.Windows.Forms.Label();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.SuspendLayout();
            // 
            // brand_status_combo
            // 
            this.brand_status_combo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brand_status_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brand_status_combo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand_status_combo.FormattingEnabled = true;
            this.brand_status_combo.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.brand_status_combo.Location = new System.Drawing.Point(149, 113);
            this.brand_status_combo.Margin = new System.Windows.Forms.Padding(2);
            this.brand_status_combo.Name = "brand_status_combo";
            this.brand_status_combo.Size = new System.Drawing.Size(254, 27);
            this.brand_status_combo.TabIndex = 1;
            // 
            // brand_status_error
            // 
            this.brand_status_error.AutoSize = true;
            this.brand_status_error.BackColor = System.Drawing.Color.Transparent;
            this.brand_status_error.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand_status_error.ForeColor = System.Drawing.Color.Red;
            this.brand_status_error.Location = new System.Drawing.Point(117, 113);
            this.brand_status_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brand_status_error.Name = "brand_status_error";
            this.brand_status_error.Size = new System.Drawing.Size(21, 19);
            this.brand_status_error.TabIndex = 107;
            this.brand_status_error.Text = "*";
            // 
            // brand_name_error
            // 
            this.brand_name_error.AutoSize = true;
            this.brand_name_error.BackColor = System.Drawing.Color.Transparent;
            this.brand_name_error.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand_name_error.ForeColor = System.Drawing.Color.Red;
            this.brand_name_error.Location = new System.Drawing.Point(117, 76);
            this.brand_name_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brand_name_error.Name = "brand_name_error";
            this.brand_name_error.Size = new System.Drawing.Size(21, 19);
            this.brand_name_error.TabIndex = 106;
            this.brand_name_error.Text = "*";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 196);
            this.panel2.TabIndex = 102;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 8);
            this.panel3.TabIndex = 103;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(415, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 204);
            this.panel4.TabIndex = 104;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 204);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 8);
            this.panel1.TabIndex = 105;
            // 
            // clear_btn
            // 
            this.clear_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clear_btn.BackColor = System.Drawing.Color.DimGray;
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.FlatAppearance.BorderSize = 0;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.Location = new System.Drawing.Point(180, 156);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(2);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(104, 31);
            this.clear_btn.TabIndex = 100;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
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
            this.close_button.Location = new System.Drawing.Point(386, 8);
            this.close_button.Margin = new System.Windows.Forms.Padding(2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(28, 27);
            this.close_button.TabIndex = 99;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // save_btn
            // 
            this.save_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(288, 156);
            this.save_btn.Margin = new System.Windows.Forms.Padding(2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(115, 31);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // brand_name_txt
            // 
            this.brand_name_txt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand_name_txt.Location = new System.Drawing.Point(149, 77);
            this.brand_name_txt.Margin = new System.Windows.Forms.Padding(2);
            this.brand_name_txt.Name = "brand_name_txt";
            this.brand_name_txt.Size = new System.Drawing.Size(254, 27);
            this.brand_name_txt.TabIndex = 0;
            // 
            // category_status_label
            // 
            this.category_status_label.AutoSize = true;
            this.category_status_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_status_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.category_status_label.Location = new System.Drawing.Point(12, 115);
            this.category_status_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.category_status_label.Name = "category_status_label";
            this.category_status_label.Size = new System.Drawing.Size(111, 23);
            this.category_status_label.TabIndex = 96;
            this.category_status_label.Text = "Brand Status";
            // 
            // category_name_label
            // 
            this.category_name_label.AutoSize = true;
            this.category_name_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.category_name_label.Location = new System.Drawing.Point(12, 80);
            this.category_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.category_name_label.Name = "category_name_label";
            this.category_name_label.Size = new System.Drawing.Size(108, 23);
            this.category_name_label.TabIndex = 97;
            this.category_name_label.Text = "Brand Name";
            // 
            // heading_label
            // 
            this.heading_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heading_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.heading_label.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.heading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_label.ForeColor = System.Drawing.Color.White;
            this.heading_label.Location = new System.Drawing.Point(8, 8);
            this.heading_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(408, 48);
            this.heading_label.TabIndex = 98;
            this.heading_label.Text = "Add Product Brand";
            this.heading_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.heading_label;
            // 
            // Product_Brand_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(423, 212);
            this.ControlBox = false;
            this.Controls.Add(this.brand_status_combo);
            this.Controls.Add(this.brand_status_error);
            this.Controls.Add(this.brand_name_error);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.brand_name_txt);
            this.Controls.Add(this.category_status_label);
            this.Controls.Add(this.category_name_label);
            this.Controls.Add(this.heading_label);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Product_Brand_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_Category_Brand";
            this.Load += new System.EventHandler(this.Product_Brand_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox brand_status_combo;
        private System.Windows.Forms.Label brand_status_error;
        private System.Windows.Forms.Label brand_name_error;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox brand_name_txt;
        private System.Windows.Forms.Label category_status_label;
        private System.Windows.Forms.Label category_name_label;
        private System.Windows.Forms.Label heading_label;
        private DragControlDemo.DragControl dragControl1;
    }
}