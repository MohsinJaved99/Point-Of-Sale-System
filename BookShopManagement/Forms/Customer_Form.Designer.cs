namespace BookShopManagement.Forms
{
    partial class Customer_Form
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
            this.clear_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.customer_mail_label = new System.Windows.Forms.Label();
            this.customer_phone_label = new System.Windows.Forms.Label();
            this.customer_name_label = new System.Windows.Forms.Label();
            this.heading_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customer_address_label = new System.Windows.Forms.Label();
            this.customer_mail_txt = new System.Windows.Forms.TextBox();
            this.customer_name_txt = new System.Windows.Forms.TextBox();
            this.close_button = new System.Windows.Forms.Button();
            this.customer_number_error = new System.Windows.Forms.Label();
            this.customer_mail_error = new System.Windows.Forms.Label();
            this.customer_name_error = new System.Windows.Forms.Label();
            this.customer_address_error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nic = new System.Windows.Forms.MaskedTextBox();
            this.customer_address_txt = new System.Windows.Forms.RichTextBox();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.customer_number_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.clear_btn.Location = new System.Drawing.Point(276, 317);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(2);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(104, 31);
            this.clear_btn.TabIndex = 44;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(384, 317);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // customer_mail_label
            // 
            this.customer_mail_label.AutoSize = true;
            this.customer_mail_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_mail_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.customer_mail_label.Location = new System.Drawing.Point(14, 98);
            this.customer_mail_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customer_mail_label.Name = "customer_mail_label";
            this.customer_mail_label.Size = new System.Drawing.Size(53, 23);
            this.customer_mail_label.TabIndex = 28;
            this.customer_mail_label.Text = "Email";
            // 
            // customer_phone_label
            // 
            this.customer_phone_label.AutoSize = true;
            this.customer_phone_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_phone_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.customer_phone_label.Location = new System.Drawing.Point(16, 133);
            this.customer_phone_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customer_phone_label.Name = "customer_phone_label";
            this.customer_phone_label.Size = new System.Drawing.Size(129, 23);
            this.customer_phone_label.TabIndex = 31;
            this.customer_phone_label.Text = "Phone Number";
            // 
            // customer_name_label
            // 
            this.customer_name_label.AutoSize = true;
            this.customer_name_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.customer_name_label.Location = new System.Drawing.Point(14, 63);
            this.customer_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customer_name_label.Name = "customer_name_label";
            this.customer_name_label.Size = new System.Drawing.Size(138, 23);
            this.customer_name_label.TabIndex = 33;
            this.customer_name_label.Text = "Customer Name";
            // 
            // heading_label
            // 
            this.heading_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heading_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.heading_label.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.heading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_label.ForeColor = System.Drawing.Color.White;
            this.heading_label.Location = new System.Drawing.Point(2, 8);
            this.heading_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(510, 35);
            this.heading_label.TabIndex = 35;
            this.heading_label.Text = "Add Customer Details";
            this.heading_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 357);
            this.panel2.TabIndex = 53;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 8);
            this.panel3.TabIndex = 54;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(512, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 365);
            this.panel4.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 365);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 8);
            this.panel1.TabIndex = 56;
            // 
            // customer_address_label
            // 
            this.customer_address_label.AutoSize = true;
            this.customer_address_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_address_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.customer_address_label.Location = new System.Drawing.Point(16, 169);
            this.customer_address_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customer_address_label.Name = "customer_address_label";
            this.customer_address_label.Size = new System.Drawing.Size(75, 23);
            this.customer_address_label.TabIndex = 28;
            this.customer_address_label.Text = "Address";
            // 
            // customer_mail_txt
            // 
            this.customer_mail_txt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_mail_txt.Location = new System.Drawing.Point(166, 90);
            this.customer_mail_txt.Margin = new System.Windows.Forms.Padding(2);
            this.customer_mail_txt.Name = "customer_mail_txt";
            this.customer_mail_txt.Size = new System.Drawing.Size(341, 27);
            this.customer_mail_txt.TabIndex = 1;
            this.customer_mail_txt.TextChanged += new System.EventHandler(this.customer_mail_txt_TextChanged);
            // 
            // customer_name_txt
            // 
            this.customer_name_txt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name_txt.Location = new System.Drawing.Point(166, 54);
            this.customer_name_txt.Margin = new System.Windows.Forms.Padding(2);
            this.customer_name_txt.Name = "customer_name_txt";
            this.customer_name_txt.Size = new System.Drawing.Size(341, 27);
            this.customer_name_txt.TabIndex = 0;
            this.customer_name_txt.TextChanged += new System.EventHandler(this.customer_name_txt_TextChanged);
            this.customer_name_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customer_name_txt_KeyPress);
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
            this.close_button.Location = new System.Drawing.Point(484, 8);
            this.close_button.Margin = new System.Windows.Forms.Padding(2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(28, 27);
            this.close_button.TabIndex = 68;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // customer_number_error
            // 
            this.customer_number_error.AutoSize = true;
            this.customer_number_error.BackColor = System.Drawing.Color.Transparent;
            this.customer_number_error.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_number_error.ForeColor = System.Drawing.Color.Red;
            this.customer_number_error.Location = new System.Drawing.Point(141, 126);
            this.customer_number_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customer_number_error.Name = "customer_number_error";
            this.customer_number_error.Size = new System.Drawing.Size(21, 19);
            this.customer_number_error.TabIndex = 80;
            this.customer_number_error.Text = "*";
            // 
            // customer_mail_error
            // 
            this.customer_mail_error.AutoSize = true;
            this.customer_mail_error.BackColor = System.Drawing.Color.Transparent;
            this.customer_mail_error.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_mail_error.ForeColor = System.Drawing.Color.Red;
            this.customer_mail_error.Location = new System.Drawing.Point(64, 90);
            this.customer_mail_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customer_mail_error.Name = "customer_mail_error";
            this.customer_mail_error.Size = new System.Drawing.Size(21, 19);
            this.customer_mail_error.TabIndex = 79;
            this.customer_mail_error.Text = "*";
            // 
            // customer_name_error
            // 
            this.customer_name_error.AutoSize = true;
            this.customer_name_error.BackColor = System.Drawing.Color.Transparent;
            this.customer_name_error.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name_error.ForeColor = System.Drawing.Color.Red;
            this.customer_name_error.Location = new System.Drawing.Point(144, 54);
            this.customer_name_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customer_name_error.Name = "customer_name_error";
            this.customer_name_error.Size = new System.Drawing.Size(21, 19);
            this.customer_name_error.TabIndex = 78;
            this.customer_name_error.Text = "*";
            // 
            // customer_address_error
            // 
            this.customer_address_error.AutoSize = true;
            this.customer_address_error.BackColor = System.Drawing.Color.Transparent;
            this.customer_address_error.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_address_error.ForeColor = System.Drawing.Color.Red;
            this.customer_address_error.Location = new System.Drawing.Point(86, 162);
            this.customer_address_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customer_address_error.Name = "customer_address_error";
            this.customer_address_error.Size = new System.Drawing.Size(21, 19);
            this.customer_address_error.TabIndex = 81;
            this.customer_address_error.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(49, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 19);
            this.label1.TabIndex = 84;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(16, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 83;
            this.label2.Text = "NIC";
            // 
            // nic
            // 
            this.nic.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nic.Location = new System.Drawing.Point(166, 276);
            this.nic.Mask = "00000-0000000-0";
            this.nic.Name = "nic";
            this.nic.Size = new System.Drawing.Size(341, 27);
            this.nic.TabIndex = 4;
            this.nic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customer_address_txt
            // 
            this.customer_address_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customer_address_txt.Location = new System.Drawing.Point(166, 162);
            this.customer_address_txt.Name = "customer_address_txt";
            this.customer_address_txt.Size = new System.Drawing.Size(341, 104);
            this.customer_address_txt.TabIndex = 3;
            this.customer_address_txt.Text = "";
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.heading_label;
            // 
            // customer_number_txt
            // 
            this.customer_number_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customer_number_txt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_number_txt.Location = new System.Drawing.Point(166, 126);
            this.customer_number_txt.Margin = new System.Windows.Forms.Padding(2);
            this.customer_number_txt.Name = "customer_number_txt";
            this.customer_number_txt.Size = new System.Drawing.Size(341, 27);
            this.customer_number_txt.TabIndex = 2;
            this.customer_number_txt.TextChanged += new System.EventHandler(this.mobile_txt_TextChanged);
            this.customer_number_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customer_number_txt_KeyPress_1);
            this.customer_number_txt.Leave += new System.EventHandler(this.mobile_txt_Leave);
            // 
            // Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 373);
            this.Controls.Add(this.customer_number_txt);
            this.Controls.Add(this.customer_address_txt);
            this.Controls.Add(this.nic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customer_address_error);
            this.Controls.Add(this.customer_number_error);
            this.Controls.Add(this.customer_mail_error);
            this.Controls.Add(this.customer_name_error);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.customer_name_txt);
            this.Controls.Add(this.customer_mail_txt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customer_address_label);
            this.Controls.Add(this.customer_mail_label);
            this.Controls.Add(this.customer_phone_label);
            this.Controls.Add(this.customer_name_label);
            this.Controls.Add(this.heading_label);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Customer_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dra";
            this.Load += new System.EventHandler(this.Customer_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label customer_mail_label;
        private System.Windows.Forms.Label customer_phone_label;
        private System.Windows.Forms.Label customer_name_label;
        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label customer_address_label;
        private System.Windows.Forms.TextBox customer_mail_txt;
        private System.Windows.Forms.TextBox customer_name_txt;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label customer_number_error;
        private System.Windows.Forms.Label customer_mail_error;
        private System.Windows.Forms.Label customer_name_error;
        private System.Windows.Forms.Label customer_address_error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox nic;
        private System.Windows.Forms.RichTextBox customer_address_txt;
        private DragControlDemo.DragControl dragControl1;
        private System.Windows.Forms.TextBox customer_number_txt;
    }
}