namespace BookShopManagement.Forms
{
    partial class Daily_Expense_Form
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
            this.heading_label = new System.Windows.Forms.Label();
            this.product_brand_error = new System.Windows.Forms.Label();
            this.expense_purpose_label = new System.Windows.Forms.Label();
            this.category_status_error = new System.Windows.Forms.Label();
            this.category_name_error = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.expense_date_label = new System.Windows.Forms.Label();
            this.expense_amount_label = new System.Windows.Forms.Label();
            this.purpose_txt = new System.Windows.Forms.TextBox();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.date_txt = new System.Windows.Forms.DateTimePicker();
            this.close_button = new System.Windows.Forms.Button();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 313);
            this.panel2.TabIndex = 92;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 10);
            this.panel3.TabIndex = 93;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(403, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 323);
            this.panel4.TabIndex = 94;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 10);
            this.panel1.TabIndex = 95;
            // 
            // heading_label
            // 
            this.heading_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heading_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.heading_label.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.heading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_label.ForeColor = System.Drawing.Color.White;
            this.heading_label.Location = new System.Drawing.Point(10, 9);
            this.heading_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(393, 62);
            this.heading_label.TabIndex = 122;
            this.heading_label.Text = "Add Daily Expense";
            this.heading_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product_brand_error
            // 
            this.product_brand_error.AutoSize = true;
            this.product_brand_error.BackColor = System.Drawing.Color.Transparent;
            this.product_brand_error.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_brand_error.ForeColor = System.Drawing.Color.Red;
            this.product_brand_error.Location = new System.Drawing.Point(163, 113);
            this.product_brand_error.Name = "product_brand_error";
            this.product_brand_error.Size = new System.Drawing.Size(21, 19);
            this.product_brand_error.TabIndex = 196;
            this.product_brand_error.Text = "*";
            // 
            // expense_purpose_label
            // 
            this.expense_purpose_label.AutoSize = true;
            this.expense_purpose_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_purpose_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.expense_purpose_label.Location = new System.Drawing.Point(16, 116);
            this.expense_purpose_label.Name = "expense_purpose_label";
            this.expense_purpose_label.Size = new System.Drawing.Size(145, 23);
            this.expense_purpose_label.TabIndex = 195;
            this.expense_purpose_label.Text = "Expense Purpose";
            // 
            // category_status_error
            // 
            this.category_status_error.AutoSize = true;
            this.category_status_error.BackColor = System.Drawing.Color.Transparent;
            this.category_status_error.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_status_error.ForeColor = System.Drawing.Color.Red;
            this.category_status_error.Location = new System.Drawing.Point(133, 213);
            this.category_status_error.Name = "category_status_error";
            this.category_status_error.Size = new System.Drawing.Size(21, 19);
            this.category_status_error.TabIndex = 192;
            this.category_status_error.Text = "*";
            // 
            // category_name_error
            // 
            this.category_name_error.AutoSize = true;
            this.category_name_error.BackColor = System.Drawing.Color.Transparent;
            this.category_name_error.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_name_error.ForeColor = System.Drawing.Color.Red;
            this.category_name_error.Location = new System.Drawing.Point(159, 160);
            this.category_name_error.Name = "category_name_error";
            this.category_name_error.Size = new System.Drawing.Size(21, 19);
            this.category_name_error.TabIndex = 191;
            this.category_name_error.Text = "*";
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
            this.clear_btn.Location = new System.Drawing.Point(152, 250);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(120, 38);
            this.clear_btn.TabIndex = 189;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
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
            this.save_btn.Location = new System.Drawing.Point(278, 250);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(120, 38);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // expense_date_label
            // 
            this.expense_date_label.AutoSize = true;
            this.expense_date_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_date_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.expense_date_label.Location = new System.Drawing.Point(16, 215);
            this.expense_date_label.Name = "expense_date_label";
            this.expense_date_label.Size = new System.Drawing.Size(118, 23);
            this.expense_date_label.TabIndex = 187;
            this.expense_date_label.Text = "Expense Date";
            // 
            // expense_amount_label
            // 
            this.expense_amount_label.AutoSize = true;
            this.expense_amount_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_amount_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.expense_amount_label.Location = new System.Drawing.Point(16, 164);
            this.expense_amount_label.Name = "expense_amount_label";
            this.expense_amount_label.Size = new System.Drawing.Size(144, 23);
            this.expense_amount_label.TabIndex = 188;
            this.expense_amount_label.Text = "Expense Amount";
            // 
            // purpose_txt
            // 
            this.purpose_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.purpose_txt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purpose_txt.Location = new System.Drawing.Point(191, 113);
            this.purpose_txt.Margin = new System.Windows.Forms.Padding(2);
            this.purpose_txt.Name = "purpose_txt";
            this.purpose_txt.Size = new System.Drawing.Size(207, 27);
            this.purpose_txt.TabIndex = 0;
            this.purpose_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.purpose_txt_KeyPress);
            // 
            // amount_txt
            // 
            this.amount_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amount_txt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_txt.Location = new System.Drawing.Point(191, 160);
            this.amount_txt.Margin = new System.Windows.Forms.Padding(2);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(207, 27);
            this.amount_txt.TabIndex = 1;
            this.amount_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_txt_KeyPress);
            // 
            // date_txt
            // 
            this.date_txt.CustomFormat = "dd-MMMM-yyyy";
            this.date_txt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_txt.Location = new System.Drawing.Point(191, 209);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(207, 27);
            this.date_txt.TabIndex = 2;
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
            this.close_button.Location = new System.Drawing.Point(375, 9);
            this.close_button.Margin = new System.Windows.Forms.Padding(2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(28, 27);
            this.close_button.TabIndex = 201;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.heading_label;
            // 
            // Daily_Expense_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 333);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.date_txt);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.purpose_txt);
            this.Controls.Add(this.product_brand_error);
            this.Controls.Add(this.expense_purpose_label);
            this.Controls.Add(this.category_status_error);
            this.Controls.Add(this.category_name_error);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.expense_date_label);
            this.Controls.Add(this.expense_amount_label);
            this.Controls.Add(this.heading_label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Daily_Expense_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily_Expense_Form";
            this.Load += new System.EventHandler(this.Daily_Expense_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.Label product_brand_error;
        private System.Windows.Forms.Label expense_purpose_label;
        private System.Windows.Forms.Label category_status_error;
        private System.Windows.Forms.Label category_name_error;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label expense_date_label;
        private System.Windows.Forms.Label expense_amount_label;
        private System.Windows.Forms.TextBox purpose_txt;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.DateTimePicker date_txt;
        private System.Windows.Forms.Button close_button;
        private DragControlDemo.DragControl dragControl1;
    }
}