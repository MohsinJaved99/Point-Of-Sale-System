namespace BookShopManagement.Forms
{
    partial class editOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.copyright_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.discount_amount = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.pquantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ptotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pdiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tprice = new System.Windows.Forms.TextBox();
            this.Product_Price = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.TextBox();
            this.bank_branch_label = new System.Windows.Forms.Label();
            this.ta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dragControl1 = new DragControlDemo.DragControl();
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
            this.close_button.Location = new System.Drawing.Point(389, 10);
            this.close_button.Margin = new System.Windows.Forms.Padding(2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(28, 27);
            this.close_button.TabIndex = 137;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // heading_label
            // 
            this.heading_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heading_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.heading_label.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.heading_label.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_label.ForeColor = System.Drawing.Color.White;
            this.heading_label.Location = new System.Drawing.Point(8, 8);
            this.heading_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(412, 47);
            this.heading_label.TabIndex = 136;
            this.heading_label.Text = "Edit Purchase Details";
            this.heading_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.copyright_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(10, 424);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 18);
            this.panel1.TabIndex = 135;
            // 
            // copyright_label
            // 
            this.copyright_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyright_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright_label.ForeColor = System.Drawing.Color.White;
            this.copyright_label.Location = new System.Drawing.Point(4, -1);
            this.copyright_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(386, 18);
            this.copyright_label.TabIndex = 4;
            this.copyright_label.Text = "Copyright © 2020 | All Rights Reserved - KoderSpot.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 434);
            this.panel2.TabIndex = 132;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 8);
            this.panel3.TabIndex = 133;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(420, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 442);
            this.panel4.TabIndex = 134;
            // 
            // discount_amount
            // 
            this.discount_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.discount_amount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_amount.Location = new System.Drawing.Point(188, 244);
            this.discount_amount.Margin = new System.Windows.Forms.Padding(2);
            this.discount_amount.Name = "discount_amount";
            this.discount_amount.ReadOnly = true;
            this.discount_amount.Size = new System.Drawing.Size(228, 27);
            this.discount_amount.TabIndex = 253;
            this.discount_amount.Text = "0";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lable.Location = new System.Drawing.Point(12, 246);
            this.lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(172, 23);
            this.lable.TabIndex = 252;
            this.lable.Text = "Discounted  Amount";
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
            this.save_btn.Location = new System.Drawing.Point(282, 368);
            this.save_btn.Margin = new System.Windows.Forms.Padding(2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(134, 31);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // pquantity
            // 
            this.pquantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pquantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pquantity.Location = new System.Drawing.Point(187, 122);
            this.pquantity.Margin = new System.Windows.Forms.Padding(2);
            this.pquantity.Name = "pquantity";
            this.pquantity.Size = new System.Drawing.Size(230, 27);
            this.pquantity.TabIndex = 0;
            this.pquantity.TextChanged += new System.EventHandler(this.pquantity_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label5.Location = new System.Drawing.Point(13, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 23);
            this.label5.TabIndex = 249;
            this.label5.Text = "Product Quantity";
            // 
            // ptotal
            // 
            this.ptotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ptotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptotal.Location = new System.Drawing.Point(186, 285);
            this.ptotal.Margin = new System.Windows.Forms.Padding(2);
            this.ptotal.Name = "ptotal";
            this.ptotal.ReadOnly = true;
            this.ptotal.Size = new System.Drawing.Size(230, 27);
            this.ptotal.TabIndex = 248;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(12, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 247;
            this.label2.Text = "Net Amount";
            // 
            // pdiscount
            // 
            this.pdiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pdiscount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdiscount.Location = new System.Drawing.Point(186, 204);
            this.pdiscount.Margin = new System.Windows.Forms.Padding(2);
            this.pdiscount.Name = "pdiscount";
            this.pdiscount.Size = new System.Drawing.Size(230, 27);
            this.pdiscount.TabIndex = 1;
            this.pdiscount.Text = "0";
            this.pdiscount.TextChanged += new System.EventHandler(this.pdiscount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 245;
            this.label3.Text = "Discount";
            // 
            // tprice
            // 
            this.tprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tprice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tprice.Location = new System.Drawing.Point(186, 162);
            this.tprice.Margin = new System.Windows.Forms.Padding(2);
            this.tprice.Name = "tprice";
            this.tprice.ReadOnly = true;
            this.tprice.Size = new System.Drawing.Size(230, 27);
            this.tprice.TabIndex = 244;
            // 
            // Product_Price
            // 
            this.Product_Price.AutoSize = true;
            this.Product_Price.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Product_Price.Location = new System.Drawing.Point(12, 164);
            this.Product_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Product_Price.Name = "Product_Price";
            this.Product_Price.Size = new System.Drawing.Size(96, 23);
            this.Product_Price.TabIndex = 243;
            this.Product_Price.Text = "Total Price ";
            // 
            // pname
            // 
            this.pname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname.Location = new System.Drawing.Point(188, 82);
            this.pname.Margin = new System.Windows.Forms.Padding(2);
            this.pname.Name = "pname";
            this.pname.ReadOnly = true;
            this.pname.Size = new System.Drawing.Size(228, 27);
            this.pname.TabIndex = 242;
            // 
            // bank_branch_label
            // 
            this.bank_branch_label.AutoSize = true;
            this.bank_branch_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank_branch_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.bank_branch_label.Location = new System.Drawing.Point(12, 84);
            this.bank_branch_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bank_branch_label.Name = "bank_branch_label";
            this.bank_branch_label.Size = new System.Drawing.Size(123, 23);
            this.bank_branch_label.TabIndex = 241;
            this.bank_branch_label.Text = "Product Name";
            // 
            // ta
            // 
            this.ta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ta.Location = new System.Drawing.Point(185, 327);
            this.ta.Margin = new System.Windows.Forms.Padding(2);
            this.ta.Name = "ta";
            this.ta.ReadOnly = true;
            this.ta.Size = new System.Drawing.Size(230, 27);
            this.ta.TabIndex = 255;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(11, 330);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 254;
            this.label1.Text = "Total Amount";
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.heading_label;
            // 
            // editOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 442);
            this.Controls.Add(this.ta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.discount_amount);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.pquantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ptotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pdiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tprice);
            this.Controls.Add(this.Product_Price);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.bank_branch_label);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.heading_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editOrder";
            this.Load += new System.EventHandler(this.editOrder_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label copyright_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox discount_amount;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox pquantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ptotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pdiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tprice;
        private System.Windows.Forms.Label Product_Price;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.Label bank_branch_label;
        private System.Windows.Forms.TextBox ta;
        private System.Windows.Forms.Label label1;
        private DragControlDemo.DragControl dragControl1;
    }
}