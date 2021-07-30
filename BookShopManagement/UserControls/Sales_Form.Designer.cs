namespace BookShopManagement.UserControls
{
    partial class Sales_Form
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customer_label = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.sale_list_view = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orignalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discountedPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.finish_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.current_amount_label = new System.Windows.Forms.Label();
            this.total_amount_label = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.product_minus_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.product_plus_btn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.heading_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.card_num_label = new System.Windows.Forms.Label();
            this.card_num_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.copyright_label = new System.Windows.Forms.Label();
            this.discount_txt = new System.Windows.Forms.TextBox();
            this.discount_label = new System.Windows.Forms.Label();
            this.product_combo = new System.Windows.Forms.ComboBox();
            this.product_label = new System.Windows.Forms.Label();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.disPricetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.netAmounttxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.product_brand_combo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.product_category_combo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.add_to_cart_btn = new System.Windows.Forms.Button();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.button1 = new System.Windows.Forms.Button();
            this.cusname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nic = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // customer_label
            // 
            this.customer_label.AutoSize = true;
            this.customer_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.customer_label.Location = new System.Drawing.Point(12, 79);
            this.customer_label.Name = "customer_label";
            this.customer_label.Size = new System.Drawing.Size(138, 23);
            this.customer_label.TabIndex = 0;
            this.customer_label.Text = "Customer Name";
            this.customer_label.Click += new System.EventHandler(this.customer_label_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.LightGray;
            this.panelLeft.Controls.Add(this.sale_list_view);
            this.panelLeft.Controls.Add(this.panel5);
            this.panelLeft.Controls.Add(this.panel3);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLeft.Location = new System.Drawing.Point(767, 10);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(426, 656);
            this.panelLeft.TabIndex = 3;
            // 
            // sale_list_view
            // 
            this.sale_list_view.BackColor = System.Drawing.Color.White;
            this.sale_list_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.productName,
            this.ProductQuantity,
            this.ProductAmount,
            this.orignalPrice,
            this.discountedPrice});
            this.sale_list_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sale_list_view.GridLines = true;
            this.sale_list_view.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.sale_list_view.HideSelection = false;
            this.sale_list_view.HoverSelection = true;
            this.sale_list_view.Location = new System.Drawing.Point(10, 0);
            this.sale_list_view.Name = "sale_list_view";
            this.sale_list_view.Size = new System.Drawing.Size(416, 462);
            this.sale_list_view.TabIndex = 5;
            this.sale_list_view.UseCompatibleStateImageBehavior = false;
            this.sale_list_view.View = System.Windows.Forms.View.Details;
            this.sale_list_view.SelectedIndexChanged += new System.EventHandler(this.sale_list_view_SelectedIndexChanged);
            this.sale_list_view.Click += new System.EventHandler(this.sale_list_view_Click);
            // 
            // id
            // 
            this.id.DisplayIndex = 3;
            this.id.Text = "ID";
            // 
            // productName
            // 
            this.productName.DisplayIndex = 0;
            this.productName.Text = "PRODUCT";
            this.productName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.productName.Width = 270;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.DisplayIndex = 1;
            this.ProductQuantity.Text = "QTY.";
            this.ProductQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductQuantity.Width = 52;
            // 
            // ProductAmount
            // 
            this.ProductAmount.DisplayIndex = 2;
            this.ProductAmount.Text = "AMOUNT";
            this.ProductAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductAmount.Width = 93;
            // 
            // orignalPrice
            // 
            this.orignalPrice.Text = "Orignal Price";
            this.orignalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // discountedPrice
            // 
            this.discountedPrice.Text = "DISCOUNT";
            this.discountedPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.finish_btn);
            this.panel5.Controls.Add(this.clear_btn);
            this.panel5.Controls.Add(this.current_amount_label);
            this.panel5.Controls.Add(this.total_amount_label);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 462);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(416, 194);
            this.panel5.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 44);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(416, 7);
            this.panel8.TabIndex = 5;
            // 
            // finish_btn
            // 
            this.finish_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.finish_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finish_btn.FlatAppearance.BorderSize = 0;
            this.finish_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finish_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish_btn.ForeColor = System.Drawing.Color.White;
            this.finish_btn.Location = new System.Drawing.Point(116, 145);
            this.finish_btn.Name = "finish_btn";
            this.finish_btn.Size = new System.Drawing.Size(294, 42);
            this.finish_btn.TabIndex = 2;
            this.finish_btn.Text = "Finish Order";
            this.finish_btn.UseVisualStyleBackColor = false;
            this.finish_btn.Click += new System.EventHandler(this.finish_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.FlatAppearance.BorderSize = 0;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.Location = new System.Drawing.Point(6, 145);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(104, 42);
            this.clear_btn.TabIndex = 2;
            this.clear_btn.Text = "Clear All";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // current_amount_label
            // 
            this.current_amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_amount_label.ForeColor = System.Drawing.Color.Black;
            this.current_amount_label.Location = new System.Drawing.Point(5, 84);
            this.current_amount_label.Name = "current_amount_label";
            this.current_amount_label.Size = new System.Drawing.Size(411, 57);
            this.current_amount_label.TabIndex = 0;
            this.current_amount_label.Text = "00";
            this.current_amount_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total_amount_label
            // 
            this.total_amount_label.BackColor = System.Drawing.Color.Silver;
            this.total_amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_amount_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.total_amount_label.Location = new System.Drawing.Point(0, 51);
            this.total_amount_label.Name = "total_amount_label";
            this.total_amount_label.Size = new System.Drawing.Size(416, 32);
            this.total_amount_label.TabIndex = 0;
            this.total_amount_label.Text = "Total Amount";
            this.total_amount_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.product_minus_btn);
            this.panel7.Controls.Add(this.delete_btn);
            this.panel7.Controls.Add(this.product_plus_btn);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(416, 37);
            this.panel7.TabIndex = 4;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // product_minus_btn
            // 
            this.product_minus_btn.BackColor = System.Drawing.Color.Green;
            this.product_minus_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product_minus_btn.FlatAppearance.BorderSize = 0;
            this.product_minus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.product_minus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_minus_btn.ForeColor = System.Drawing.Color.White;
            this.product_minus_btn.Location = new System.Drawing.Point(47, 3);
            this.product_minus_btn.Name = "product_minus_btn";
            this.product_minus_btn.Size = new System.Drawing.Size(33, 31);
            this.product_minus_btn.TabIndex = 2;
            this.product_minus_btn.Text = "-";
            this.product_minus_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.product_minus_btn.UseVisualStyleBackColor = false;
            this.product_minus_btn.Click += new System.EventHandler(this.product_minus_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.DarkRed;
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(126, 3);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(246, 31);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "Delete Product";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // product_plus_btn
            // 
            this.product_plus_btn.BackColor = System.Drawing.Color.Green;
            this.product_plus_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product_plus_btn.FlatAppearance.BorderSize = 0;
            this.product_plus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.product_plus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_plus_btn.ForeColor = System.Drawing.Color.White;
            this.product_plus_btn.Location = new System.Drawing.Point(86, 3);
            this.product_plus_btn.Name = "product_plus_btn";
            this.product_plus_btn.Size = new System.Drawing.Size(33, 31);
            this.product_plus_btn.TabIndex = 2;
            this.product_plus_btn.Text = "+";
            this.product_plus_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.product_plus_btn.UseVisualStyleBackColor = false;
            this.product_plus_btn.Click += new System.EventHandler(this.product_plus_btn_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(416, 7);
            this.panel6.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 656);
            this.panel3.TabIndex = 4;
            // 
            // heading_label
            // 
            this.heading_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.heading_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.heading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_label.ForeColor = System.Drawing.Color.White;
            this.heading_label.Location = new System.Drawing.Point(0, 0);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(757, 66);
            this.heading_label.TabIndex = 0;
            this.heading_label.Text = "Product Sale ";
            this.heading_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.heading_label.Click += new System.EventHandler(this.heading_label_Click);
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.price_label.Location = new System.Drawing.Point(40, 391);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(50, 23);
            this.price_label.TabIndex = 0;
            this.price_label.Text = "Price";
            this.price_label.Click += new System.EventHandler(this.price_label_Click);
            // 
            // card_num_label
            // 
            this.card_num_label.AutoSize = true;
            this.card_num_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_num_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.card_num_label.Location = new System.Drawing.Point(40, 480);
            this.card_num_label.Name = "card_num_label";
            this.card_num_label.Size = new System.Drawing.Size(115, 23);
            this.card_num_label.TabIndex = 0;
            this.card_num_label.Text = "Card Number";
            this.card_num_label.Click += new System.EventHandler(this.card_num_label_Click);
            // 
            // card_num_txt
            // 
            this.card_num_txt.Enabled = false;
            this.card_num_txt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_num_txt.Location = new System.Drawing.Point(191, 480);
            this.card_num_txt.Name = "card_num_txt";
            this.card_num_txt.Size = new System.Drawing.Size(428, 31);
            this.card_num_txt.TabIndex = 1;
            this.card_num_txt.TextChanged += new System.EventHandler(this.card_num_txr_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 10);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 666);
            this.panel2.TabIndex = 23;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(1193, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 656);
            this.panel9.TabIndex = 25;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel10.Controls.Add(this.copyright_label);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 666);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1203, 22);
            this.panel10.TabIndex = 26;
            // 
            // copyright_label
            // 
            this.copyright_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyright_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright_label.ForeColor = System.Drawing.Color.White;
            this.copyright_label.Location = new System.Drawing.Point(10, 2);
            this.copyright_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(785, 18);
            this.copyright_label.TabIndex = 4;
            this.copyright_label.Text = "Copyright © 2020 | All Rights Reserved - KoderSpot.";
            // 
            // discount_txt
            // 
            this.discount_txt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_txt.Location = new System.Drawing.Point(472, 391);
            this.discount_txt.MaxLength = 100;
            this.discount_txt.Name = "discount_txt";
            this.discount_txt.Size = new System.Drawing.Size(119, 31);
            this.discount_txt.TabIndex = 5;
            this.discount_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discount_txt.Click += new System.EventHandler(this.discount_txt_Click);
            this.discount_txt.TextChanged += new System.EventHandler(this.discount_txt_TextChanged);
            this.discount_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discount_txt_KeyPress);
            // 
            // discount_label
            // 
            this.discount_label.AutoSize = true;
            this.discount_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.discount_label.Location = new System.Drawing.Point(343, 391);
            this.discount_label.Name = "discount_label";
            this.discount_label.Size = new System.Drawing.Size(80, 23);
            this.discount_label.TabIndex = 29;
            this.discount_label.Text = "Discount";
            this.discount_label.Click += new System.EventHandler(this.discount_label_Click);
            // 
            // product_combo
            // 
            this.product_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.product_combo.Enabled = false;
            this.product_combo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_combo.FormattingEnabled = true;
            this.product_combo.Location = new System.Drawing.Point(191, 349);
            this.product_combo.Name = "product_combo";
            this.product_combo.Size = new System.Drawing.Size(428, 31);
            this.product_combo.TabIndex = 3;
            this.product_combo.SelectedIndexChanged += new System.EventHandler(this.product_combo_SelectedIndexChanged_1);
            // 
            // product_label
            // 
            this.product_label.AutoSize = true;
            this.product_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.product_label.Location = new System.Drawing.Point(40, 349);
            this.product_label.Name = "product_label";
            this.product_label.Size = new System.Drawing.Size(123, 23);
            this.product_label.TabIndex = 31;
            this.product_label.Text = "Product Name";
            this.product_label.Click += new System.EventHandler(this.product_label_Click);
            // 
            // price_txt
            // 
            this.price_txt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_txt.Location = new System.Drawing.Point(191, 391);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(133, 31);
            this.price_txt.TabIndex = 4;
            this.price_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.price_txt.TextChanged += new System.EventHandler(this.price_txt_TextChanged_1);
            this.price_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_txt_KeyPress);
            // 
            // disPricetxt
            // 
            this.disPricetxt.Enabled = false;
            this.disPricetxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disPricetxt.Location = new System.Drawing.Point(191, 435);
            this.disPricetxt.Name = "disPricetxt";
            this.disPricetxt.Size = new System.Drawing.Size(133, 31);
            this.disPricetxt.TabIndex = 37;
            this.disPricetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.disPricetxt.TextChanged += new System.EventHandler(this.disPricetxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(40, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Discount Price";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(343, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Net Amount";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // netAmounttxt
            // 
            this.netAmounttxt.Enabled = false;
            this.netAmounttxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netAmounttxt.Location = new System.Drawing.Point(472, 435);
            this.netAmounttxt.Name = "netAmounttxt";
            this.netAmounttxt.Size = new System.Drawing.Size(119, 31);
            this.netAmounttxt.TabIndex = 38;
            this.netAmounttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.netAmounttxt.TextChanged += new System.EventHandler(this.netAmounttxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(597, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "%";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.Location = new System.Drawing.Point(594, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "Rs.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label5.Location = new System.Drawing.Point(256, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "ⓘ Information Required";
            // 
            // product_brand_combo
            // 
            this.product_brand_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.product_brand_combo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_brand_combo.FormattingEnabled = true;
            this.product_brand_combo.Location = new System.Drawing.Point(191, 266);
            this.product_brand_combo.Name = "product_brand_combo";
            this.product_brand_combo.Size = new System.Drawing.Size(428, 31);
            this.product_brand_combo.TabIndex = 1;
            this.product_brand_combo.SelectedIndexChanged += new System.EventHandler(this.product_brand_combo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label6.Location = new System.Drawing.Point(40, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "Product Brand";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // product_category_combo
            // 
            this.product_category_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.product_category_combo.Enabled = false;
            this.product_category_combo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_category_combo.FormattingEnabled = true;
            this.product_category_combo.Location = new System.Drawing.Point(191, 307);
            this.product_category_combo.Name = "product_category_combo";
            this.product_category_combo.Size = new System.Drawing.Size(428, 31);
            this.product_category_combo.TabIndex = 2;
            this.product_category_combo.SelectedIndexChanged += new System.EventHandler(this.product_category_combo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label7.Location = new System.Drawing.Point(40, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 23);
            this.label7.TabIndex = 47;
            this.label7.Text = "Product Category";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // add_to_cart_btn
            // 
            this.add_to_cart_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.add_to_cart_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_to_cart_btn.FlatAppearance.BorderSize = 0;
            this.add_to_cart_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_to_cart_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_to_cart_btn.ForeColor = System.Drawing.Color.White;
            this.add_to_cart_btn.Image = global::BookShopManagement.Properties.Resources.icons8_shopping_cart_24;
            this.add_to_cart_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_to_cart_btn.Location = new System.Drawing.Point(471, 524);
            this.add_to_cart_btn.Name = "add_to_cart_btn";
            this.add_to_cart_btn.Size = new System.Drawing.Size(149, 40);
            this.add_to_cart_btn.TabIndex = 2;
            this.add_to_cart_btn.Text = "Add to Cart";
            this.add_to_cart_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_to_cart_btn.UseVisualStyleBackColor = false;
            this.add_to_cart_btn.Click += new System.EventHandler(this.add_to_cart_btn_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.heading_label;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(361, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 40);
            this.button1.TabIndex = 48;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // cusname
            // 
            this.cusname.Enabled = false;
            this.cusname.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusname.Location = new System.Drawing.Point(163, 76);
            this.cusname.Name = "cusname";
            this.cusname.Size = new System.Drawing.Size(428, 31);
            this.cusname.TabIndex = 49;
            this.cusname.TextChanged += new System.EventHandler(this.cusname_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label8.Location = new System.Drawing.Point(12, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 23);
            this.label8.TabIndex = 50;
            this.label8.Text = "Customer NIC";
            // 
            // nic
            // 
            this.nic.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nic.Location = new System.Drawing.Point(163, 26);
            this.nic.Mask = "00000-0000000-0";
            this.nic.Name = "nic";
            this.nic.Size = new System.Drawing.Size(428, 31);
            this.nic.TabIndex = 51;
            this.nic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nic.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.nic_MaskInputRejected);
            this.nic.TextChanged += new System.EventHandler(this.nic_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nic);
            this.groupBox1.Controls.Add(this.customer_label);
            this.groupBox1.Controls.Add(this.cusname);
            this.groupBox1.Location = new System.Drawing.Point(27, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 129);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.heading_label);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(757, 656);
            this.panel4.TabIndex = 53;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Sales_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.product_category_combo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.product_brand_combo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.netAmounttxt);
            this.Controls.Add(this.disPricetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.product_combo);
            this.Controls.Add(this.product_label);
            this.Controls.Add(this.discount_txt);
            this.Controls.Add(this.discount_label);
            this.Controls.Add(this.add_to_cart_btn);
            this.Controls.Add(this.card_num_txt);
            this.Controls.Add(this.card_num_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel10);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Name = "Sales_Form";
            this.Size = new System.Drawing.Size(1203, 688);
            this.Load += new System.EventHandler(this.Sales_Form_Load);
            this.panelLeft.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customer_label;
        private System.Windows.Forms.Button add_to_cart_btn;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.ListView sale_list_view;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader ProductQuantity;
        private System.Windows.Forms.ColumnHeader ProductAmount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button finish_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label current_amount_label;
        private System.Windows.Forms.Label total_amount_label;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button product_minus_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button product_plus_btn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label card_num_label;
        private System.Windows.Forms.TextBox card_num_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox discount_txt;
        private System.Windows.Forms.Label discount_label;
        private System.Windows.Forms.ComboBox product_combo;
        private System.Windows.Forms.Label product_label;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.TextBox disPricetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox netAmounttxt;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label copyright_label;
        private System.Windows.Forms.ColumnHeader orignalPrice;
        private System.Windows.Forms.ComboBox product_brand_combo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox product_category_combo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader discountedPrice;
        private DragControlDemo.DragControl dragControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cusname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox nic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
    }
}
