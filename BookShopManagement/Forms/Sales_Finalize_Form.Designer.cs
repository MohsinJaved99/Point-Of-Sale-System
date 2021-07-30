namespace BookShopManagement.Forms
{
    partial class Sales_Finalize_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.heading_label = new System.Windows.Forms.Label();
            this.net_amount_label = new System.Windows.Forms.Label();
            this.net_amount_txt = new System.Windows.Forms.TextBox();
            this.discount_label = new System.Windows.Forms.Label();
            this.discount_txt = new System.Windows.Forms.TextBox();
            this.total_amount_label = new System.Windows.Forms.Label();
            this.total_amount_txt = new System.Windows.Forms.TextBox();
            this.paid_amount_label = new System.Windows.Forms.Label();
            this.paid_amount_txt = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.payment_combo = new System.Windows.Forms.ComboBox();
            this.payment_method_label = new System.Windows.Forms.Label();
            this.bank_acc_label = new System.Windows.Forms.Label();
            this.availablePoints = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.payingdate_txt = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.dragControl2 = new DragControlDemo.DragControl();
            this.bank_name_txt_dd = new System.Windows.Forms.TextBox();
            this.bank_name_txt = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 622);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 10);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 612);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 10);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(501, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 622);
            this.panel4.TabIndex = 0;
            // 
            // heading_label
            // 
            this.heading_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.heading_label.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.heading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_label.ForeColor = System.Drawing.Color.White;
            this.heading_label.Location = new System.Drawing.Point(10, 9);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(491, 88);
            this.heading_label.TabIndex = 1;
            this.heading_label.Text = "Finalize Your Order";
            this.heading_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // net_amount_label
            // 
            this.net_amount_label.AutoSize = true;
            this.net_amount_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.net_amount_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.net_amount_label.Location = new System.Drawing.Point(36, 222);
            this.net_amount_label.Name = "net_amount_label";
            this.net_amount_label.Size = new System.Drawing.Size(108, 23);
            this.net_amount_label.TabIndex = 1;
            this.net_amount_label.Text = "Net Amount";
            // 
            // net_amount_txt
            // 
            this.net_amount_txt.Location = new System.Drawing.Point(219, 222);
            this.net_amount_txt.Name = "net_amount_txt";
            this.net_amount_txt.ReadOnly = true;
            this.net_amount_txt.Size = new System.Drawing.Size(276, 27);
            this.net_amount_txt.TabIndex = 3;
            this.net_amount_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.net_amount_txt.TextChanged += new System.EventHandler(this.net_amount_txt_TextChanged);
            this.net_amount_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.net_amount_txt_KeyPress);
            // 
            // discount_label
            // 
            this.discount_label.AutoSize = true;
            this.discount_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.discount_label.Location = new System.Drawing.Point(36, 265);
            this.discount_label.Name = "discount_label";
            this.discount_label.Size = new System.Drawing.Size(80, 23);
            this.discount_label.TabIndex = 1;
            this.discount_label.Text = "Discount";
            // 
            // discount_txt
            // 
            this.discount_txt.Location = new System.Drawing.Point(219, 262);
            this.discount_txt.MaxLength = 100;
            this.discount_txt.Name = "discount_txt";
            this.discount_txt.Size = new System.Drawing.Size(276, 27);
            this.discount_txt.TabIndex = 4;
            this.discount_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discount_txt.Click += new System.EventHandler(this.discount_txt_Click);
            this.discount_txt.TextChanged += new System.EventHandler(this.discount_txt_TextChanged);
            this.discount_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discount_txt_KeyPress);
            // 
            // total_amount_label
            // 
            this.total_amount_label.AutoSize = true;
            this.total_amount_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_amount_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.total_amount_label.Location = new System.Drawing.Point(36, 306);
            this.total_amount_label.Name = "total_amount_label";
            this.total_amount_label.Size = new System.Drawing.Size(116, 23);
            this.total_amount_label.TabIndex = 1;
            this.total_amount_label.Text = "Total Amount";
            // 
            // total_amount_txt
            // 
            this.total_amount_txt.Location = new System.Drawing.Point(219, 306);
            this.total_amount_txt.Name = "total_amount_txt";
            this.total_amount_txt.ReadOnly = true;
            this.total_amount_txt.Size = new System.Drawing.Size(276, 27);
            this.total_amount_txt.TabIndex = 5;
            this.total_amount_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.total_amount_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.total_amount_txt_KeyPress);
            // 
            // paid_amount_label
            // 
            this.paid_amount_label.AutoSize = true;
            this.paid_amount_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid_amount_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.paid_amount_label.Location = new System.Drawing.Point(36, 349);
            this.paid_amount_label.Name = "paid_amount_label";
            this.paid_amount_label.Size = new System.Drawing.Size(112, 23);
            this.paid_amount_label.TabIndex = 1;
            this.paid_amount_label.Text = "Paid Amount";
            // 
            // paid_amount_txt
            // 
            this.paid_amount_txt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid_amount_txt.Location = new System.Drawing.Point(219, 349);
            this.paid_amount_txt.Name = "paid_amount_txt";
            this.paid_amount_txt.ReadOnly = true;
            this.paid_amount_txt.Size = new System.Drawing.Size(276, 27);
            this.paid_amount_txt.TabIndex = 6;
            this.paid_amount_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.paid_amount_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paid_amount_txt_KeyPress);
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
            this.save_btn.Location = new System.Drawing.Point(364, 541);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(131, 38);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Done";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
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
            this.close_button.Location = new System.Drawing.Point(464, 9);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(37, 33);
            this.close_button.TabIndex = 68;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // payment_combo
            // 
            this.payment_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payment_combo.FormattingEnabled = true;
            this.payment_combo.Items.AddRange(new object[] {
            "Bank",
            "Cash"});
            this.payment_combo.Location = new System.Drawing.Point(219, 138);
            this.payment_combo.Name = "payment_combo";
            this.payment_combo.Size = new System.Drawing.Size(276, 27);
            this.payment_combo.TabIndex = 0;
            this.payment_combo.SelectedIndexChanged += new System.EventHandler(this.payment_combo_SelectedIndexChanged);
            // 
            // payment_method_label
            // 
            this.payment_method_label.AutoSize = true;
            this.payment_method_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_method_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.payment_method_label.Location = new System.Drawing.Point(36, 141);
            this.payment_method_label.Name = "payment_method_label";
            this.payment_method_label.Size = new System.Drawing.Size(148, 23);
            this.payment_method_label.TabIndex = 71;
            this.payment_method_label.Text = "Payment Method";
            // 
            // bank_acc_label
            // 
            this.bank_acc_label.AutoSize = true;
            this.bank_acc_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank_acc_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.bank_acc_label.Location = new System.Drawing.Point(36, 183);
            this.bank_acc_label.Name = "bank_acc_label";
            this.bank_acc_label.Size = new System.Drawing.Size(118, 23);
            this.bank_acc_label.TabIndex = 73;
            this.bank_acc_label.Text = "Bank Account";
            // 
            // availablePoints
            // 
            this.availablePoints.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablePoints.Location = new System.Drawing.Point(219, 391);
            this.availablePoints.Name = "availablePoints";
            this.availablePoints.Size = new System.Drawing.Size(165, 27);
            this.availablePoints.TabIndex = 7;
            this.availablePoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.availablePoints.TextChanged += new System.EventHandler(this.availablePoints_TextChanged);
            this.availablePoints.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.availablePoints_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(36, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 80;
            this.label1.Text = "Available Points";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.checkBox1.Location = new System.Drawing.Point(390, 393);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 23);
            this.checkBox1.TabIndex = 82;
            this.checkBox1.Text = "Use Points";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.checkBox2.Location = new System.Drawing.Point(219, 431);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(134, 23);
            this.checkBox2.TabIndex = 83;
            this.checkBox2.Text = "Buying On Loan.";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // payingdate_txt
            // 
            this.payingdate_txt.CustomFormat = "dd-MMMM-yyyy";
            this.payingdate_txt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payingdate_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.payingdate_txt.Location = new System.Drawing.Point(203, 32);
            this.payingdate_txt.Name = "payingdate_txt";
            this.payingdate_txt.Size = new System.Drawing.Size(268, 27);
            this.payingdate_txt.TabIndex = 85;
            this.payingdate_txt.ValueChanged += new System.EventHandler(this.date_txt_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.payingdate_txt);
            this.groupBox1.Location = new System.Drawing.Point(16, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 79);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Detail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(20, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 86;
            this.label2.Text = "Paying Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pictureBox1.Image = global::BookShopManagement.Properties.Resources.logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(21, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.heading_label;
            // 
            // bank_name_txt_dd
            // 
            this.bank_name_txt_dd.Enabled = false;
            this.bank_name_txt_dd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank_name_txt_dd.Location = new System.Drawing.Point(219, 180);
            this.bank_name_txt_dd.Name = "bank_name_txt_dd";
            this.bank_name_txt_dd.Size = new System.Drawing.Size(276, 27);
            this.bank_name_txt_dd.TabIndex = 2;
            this.bank_name_txt_dd.Click += new System.EventHandler(this.textBox1_Click);
            this.bank_name_txt_dd.TextChanged += new System.EventHandler(this.bank_name_txt_TextChanged);
            // 
            // bank_name_txt
            // 
            this.bank_name_txt.FormattingEnabled = true;
            this.bank_name_txt.ItemHeight = 19;
            this.bank_name_txt.Location = new System.Drawing.Point(16, 208);
            this.bank_name_txt.Name = "bank_name_txt";
            this.bank_name_txt.ScrollAlwaysVisible = true;
            this.bank_name_txt.Size = new System.Drawing.Size(479, 137);
            this.bank_name_txt.TabIndex = 77;
            this.bank_name_txt.Visible = false;
            this.bank_name_txt.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Sales_Finalize_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 632);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.availablePoints);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bank_name_txt_dd);
            this.Controls.Add(this.bank_name_txt);
            this.Controls.Add(this.bank_acc_label);
            this.Controls.Add(this.payment_combo);
            this.Controls.Add(this.payment_method_label);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.paid_amount_txt);
            this.Controls.Add(this.total_amount_txt);
            this.Controls.Add(this.paid_amount_label);
            this.Controls.Add(this.discount_txt);
            this.Controls.Add(this.total_amount_label);
            this.Controls.Add(this.net_amount_txt);
            this.Controls.Add(this.discount_label);
            this.Controls.Add(this.net_amount_label);
            this.Controls.Add(this.heading_label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales_Finalize_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_FinishOrder";
            this.Load += new System.EventHandler(this.Sales_Finalize_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.Label net_amount_label;
        private System.Windows.Forms.TextBox net_amount_txt;
        private System.Windows.Forms.Label discount_label;
        private System.Windows.Forms.TextBox discount_txt;
        private System.Windows.Forms.Label total_amount_label;
        private System.Windows.Forms.TextBox total_amount_txt;
        private System.Windows.Forms.Label paid_amount_label;
        private System.Windows.Forms.TextBox paid_amount_txt;
        private System.Windows.Forms.Button save_btn;
        private DragControlDemo.DragControl dragControl1;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label bank_acc_label;
        private System.Windows.Forms.ComboBox payment_combo;
        private System.Windows.Forms.Label payment_method_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox availablePoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private DragControlDemo.DragControl dragControl2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker payingdate_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bank_name_txt_dd;
        private System.Windows.Forms.ListBox bank_name_txt;
    }
}