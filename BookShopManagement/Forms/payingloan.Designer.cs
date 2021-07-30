namespace BookShopManagement.Forms
{
    partial class payingloan
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
            this.close_button = new System.Windows.Forms.Button();
            this.heading_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.copyright_label = new System.Windows.Forms.Label();
            this.bank_name_txt = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bank_name_combo = new System.Windows.Forms.ComboBox();
            this.bank_acc_label = new System.Windows.Forms.Label();
            this.bank_name_label = new System.Windows.Forms.Label();
            this.payment_combo = new System.Windows.Forms.ComboBox();
            this.payment_method_label = new System.Windows.Forms.Label();
            this.net_amount_txt = new System.Windows.Forms.TextBox();
            this.net_amount_label = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.availablePoints = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customer_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paid_amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.close_button.Location = new System.Drawing.Point(428, 9);
            this.close_button.Margin = new System.Windows.Forms.Padding(2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(28, 27);
            this.close_button.TabIndex = 239;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // heading_label
            // 
            this.heading_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heading_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.heading_label.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_label.ForeColor = System.Drawing.Color.White;
            this.heading_label.Location = new System.Drawing.Point(10, 9);
            this.heading_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(446, 47);
            this.heading_label.TabIndex = 238;
            this.heading_label.Text = "Paying Loan";
            this.heading_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 10);
            this.panel3.TabIndex = 235;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 430);
            this.panel2.TabIndex = 234;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(456, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 430);
            this.panel4.TabIndex = 236;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.copyright_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 22);
            this.panel1.TabIndex = 237;
            // 
            // copyright_label
            // 
            this.copyright_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyright_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright_label.ForeColor = System.Drawing.Color.White;
            this.copyright_label.Location = new System.Drawing.Point(10, 2);
            this.copyright_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(385, 18);
            this.copyright_label.TabIndex = 4;
            this.copyright_label.Text = "Copyright © 2020 | All Rights Reserved - KoderSpot.";
            // 
            // bank_name_txt
            // 
            this.bank_name_txt.Enabled = false;
            this.bank_name_txt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank_name_txt.Location = new System.Drawing.Point(197, 163);
            this.bank_name_txt.Name = "bank_name_txt";
            this.bank_name_txt.Size = new System.Drawing.Size(253, 27);
            this.bank_name_txt.TabIndex = 242;
            this.bank_name_txt.Click += new System.EventHandler(this.bank_name_txt_Click);
            this.bank_name_txt.TextChanged += new System.EventHandler(this.bank_name_txt_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(18, 191);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(432, 118);
            this.listBox1.TabIndex = 246;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bank_name_combo
            // 
            this.bank_name_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bank_name_combo.Enabled = false;
            this.bank_name_combo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank_name_combo.FormattingEnabled = true;
            this.bank_name_combo.Location = new System.Drawing.Point(197, 119);
            this.bank_name_combo.Name = "bank_name_combo";
            this.bank_name_combo.Size = new System.Drawing.Size(253, 27);
            this.bank_name_combo.TabIndex = 241;
            this.bank_name_combo.SelectedIndexChanged += new System.EventHandler(this.bank_name_combo_SelectedIndexChanged);
            // 
            // bank_acc_label
            // 
            this.bank_acc_label.AutoSize = true;
            this.bank_acc_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank_acc_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.bank_acc_label.Location = new System.Drawing.Point(14, 167);
            this.bank_acc_label.Name = "bank_acc_label";
            this.bank_acc_label.Size = new System.Drawing.Size(118, 23);
            this.bank_acc_label.TabIndex = 244;
            this.bank_acc_label.Text = "Bank Account";
            // 
            // bank_name_label
            // 
            this.bank_name_label.AutoSize = true;
            this.bank_name_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank_name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.bank_name_label.Location = new System.Drawing.Point(14, 123);
            this.bank_name_label.Name = "bank_name_label";
            this.bank_name_label.Size = new System.Drawing.Size(100, 23);
            this.bank_name_label.TabIndex = 245;
            this.bank_name_label.Text = "Bank Name";
            // 
            // payment_combo
            // 
            this.payment_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payment_combo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_combo.FormattingEnabled = true;
            this.payment_combo.Items.AddRange(new object[] {
            "Bank",
            "Cash"});
            this.payment_combo.Location = new System.Drawing.Point(197, 73);
            this.payment_combo.Name = "payment_combo";
            this.payment_combo.Size = new System.Drawing.Size(253, 27);
            this.payment_combo.TabIndex = 240;
            this.payment_combo.SelectedIndexChanged += new System.EventHandler(this.payment_combo_SelectedIndexChanged);
            // 
            // payment_method_label
            // 
            this.payment_method_label.AutoSize = true;
            this.payment_method_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_method_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.payment_method_label.Location = new System.Drawing.Point(14, 77);
            this.payment_method_label.Name = "payment_method_label";
            this.payment_method_label.Size = new System.Drawing.Size(148, 23);
            this.payment_method_label.TabIndex = 243;
            this.payment_method_label.Text = "Payment Method";
            // 
            // net_amount_txt
            // 
            this.net_amount_txt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.net_amount_txt.Location = new System.Drawing.Point(197, 211);
            this.net_amount_txt.Name = "net_amount_txt";
            this.net_amount_txt.ReadOnly = true;
            this.net_amount_txt.Size = new System.Drawing.Size(253, 27);
            this.net_amount_txt.TabIndex = 248;
            this.net_amount_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.net_amount_txt.TextChanged += new System.EventHandler(this.net_amount_txt_TextChanged);
            // 
            // net_amount_label
            // 
            this.net_amount_label.AutoSize = true;
            this.net_amount_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.net_amount_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.net_amount_label.Location = new System.Drawing.Point(14, 215);
            this.net_amount_label.Name = "net_amount_label";
            this.net_amount_label.Size = new System.Drawing.Size(108, 23);
            this.net_amount_label.TabIndex = 247;
            this.net_amount_label.Text = "Net Amount";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.checkBox1.Location = new System.Drawing.Point(368, 348);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 253;
            this.checkBox1.Text = "Use Points";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // availablePoints
            // 
            this.availablePoints.Enabled = false;
            this.availablePoints.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablePoints.Location = new System.Drawing.Point(197, 346);
            this.availablePoints.Name = "availablePoints";
            this.availablePoints.Size = new System.Drawing.Size(165, 27);
            this.availablePoints.TabIndex = 251;
            this.availablePoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.availablePoints.TextChanged += new System.EventHandler(this.availablePoints_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(14, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 252;
            this.label2.Text = "Available Points";
            // 
            // customer_name
            // 
            this.customer_name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name.Location = new System.Drawing.Point(197, 256);
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            this.customer_name.Size = new System.Drawing.Size(253, 27);
            this.customer_name.TabIndex = 255;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(14, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 254;
            this.label3.Text = "Customer Name";
            // 
            // paid_amount
            // 
            this.paid_amount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid_amount.Location = new System.Drawing.Point(197, 301);
            this.paid_amount.Name = "paid_amount";
            this.paid_amount.ReadOnly = true;
            this.paid_amount.Size = new System.Drawing.Size(253, 27);
            this.paid_amount.TabIndex = 257;
            this.paid_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.paid_amount.TextChanged += new System.EventHandler(this.paid_amount_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.Location = new System.Drawing.Point(14, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 256;
            this.label4.Text = "Paid Amount";
            // 
            // save_btn
            // 
            this.save_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.Enabled = false;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(319, 383);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(131, 38);
            this.save_btn.TabIndex = 258;
            this.save_btn.Text = "Done";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // payingloan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 452);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.paid_amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customer_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.availablePoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.net_amount_txt);
            this.Controls.Add(this.net_amount_label);
            this.Controls.Add(this.bank_name_txt);
            this.Controls.Add(this.bank_name_combo);
            this.Controls.Add(this.bank_acc_label);
            this.Controls.Add(this.bank_name_label);
            this.Controls.Add(this.payment_combo);
            this.Controls.Add(this.payment_method_label);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.heading_label);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "payingloan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "payingloan";
            this.Load += new System.EventHandler(this.payingloan_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label copyright_label;
        private System.Windows.Forms.TextBox bank_name_txt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox bank_name_combo;
        private System.Windows.Forms.Label bank_acc_label;
        private System.Windows.Forms.Label bank_name_label;
        private System.Windows.Forms.ComboBox payment_combo;
        private System.Windows.Forms.Label payment_method_label;
        private System.Windows.Forms.TextBox net_amount_txt;
        private System.Windows.Forms.Label net_amount_label;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox availablePoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox paid_amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save_btn;
    }
}