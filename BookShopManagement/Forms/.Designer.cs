namespace BookShopManagement.Forms
{
    partial class Form_AddCategory
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
            this.category_status_error = new System.Windows.Forms.Label();
            this.category_name_error = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.category_name_txt = new System.Windows.Forms.TextBox();
            this.category_status_label = new System.Windows.Forms.Label();
            this.category_name_label = new System.Windows.Forms.Label();
            this.heading_label = new System.Windows.Forms.Label();
            this.category_status_combo = new System.Windows.Forms.ComboBox();
            this.close_button = new System.Windows.Forms.Button();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.SuspendLayout();
            // 
            // category_status_error
            // 
            this.category_status_error.AutoSize = true;
            this.category_status_error.BackColor = System.Drawing.Color.Transparent;
            this.category_status_error.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_status_error.ForeColor = System.Drawing.Color.Red;
            this.category_status_error.Location = new System.Drawing.Point(150, 136);
            this.category_status_error.Name = "category_status_error";
            this.category_status_error.Size = new System.Drawing.Size(21, 19);
            this.category_status_error.TabIndex = 93;
            this.category_status_error.Text = "*";
            // 
            // category_name_error
            // 
            this.category_name_error.AutoSize = true;
            this.category_name_error.BackColor = System.Drawing.Color.Transparent;
            this.category_name_error.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_name_error.ForeColor = System.Drawing.Color.Red;
            this.category_name_error.Location = new System.Drawing.Point(150, 85);
            this.category_name_error.Name = "category_name_error";
            this.category_name_error.Size = new System.Drawing.Size(21, 19);
            this.category_name_error.TabIndex = 92;
            this.category_name_error.Text = "*";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 232);
            this.panel2.TabIndex = 88;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 10);
            this.panel3.TabIndex = 89;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(497, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 242);
            this.panel4.TabIndex = 90;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 10);
            this.panel1.TabIndex = 91;
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
            this.clear_btn.Location = new System.Drawing.Point(177, 188);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(138, 38);
            this.clear_btn.TabIndex = 86;
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
            this.save_btn.Location = new System.Drawing.Point(321, 188);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(166, 38);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // category_name_txt
            // 
            this.category_name_txt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_name_txt.Location = new System.Drawing.Point(177, 90);
            this.category_name_txt.Name = "category_name_txt";
            this.category_name_txt.Size = new System.Drawing.Size(310, 27);
            this.category_name_txt.TabIndex = 0;
            // 
            // category_status_label
            // 
            this.category_status_label.AutoSize = true;
            this.category_status_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_status_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.category_status_label.Location = new System.Drawing.Point(20, 141);
            this.category_status_label.Name = "category_status_label";
            this.category_status_label.Size = new System.Drawing.Size(135, 23);
            this.category_status_label.TabIndex = 82;
            this.category_status_label.Text = "Category Status";
            // 
            // category_name_label
            // 
            this.category_name_label.AutoSize = true;
            this.category_name_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.category_name_label.Location = new System.Drawing.Point(20, 90);
            this.category_name_label.Name = "category_name_label";
            this.category_name_label.Size = new System.Drawing.Size(132, 23);
            this.category_name_label.TabIndex = 83;
            this.category_name_label.Text = "Category Name";
            // 
            // heading_label
            // 
            this.heading_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heading_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.heading_label.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.heading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_label.ForeColor = System.Drawing.Color.White;
            this.heading_label.Location = new System.Drawing.Point(10, 10);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(487, 49);
            this.heading_label.TabIndex = 84;
            this.heading_label.Text = "Add Product Category";
            this.heading_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // category_status_combo
            // 
            this.category_status_combo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.category_status_combo.AutoCompleteCustomSource.AddRange(new string[] {
            "Active",
            "InActive"});
            this.category_status_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_status_combo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_status_combo.FormattingEnabled = true;
            this.category_status_combo.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.category_status_combo.Location = new System.Drawing.Point(177, 141);
            this.category_status_combo.Name = "category_status_combo";
            this.category_status_combo.Size = new System.Drawing.Size(310, 27);
            this.category_status_combo.TabIndex = 1;
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
            this.close_button.Location = new System.Drawing.Point(457, 10);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(37, 33);
            this.close_button.TabIndex = 124;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.heading_label;
            // 
            // Form_AddCategory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 252);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.category_status_combo);
            this.Controls.Add(this.category_status_error);
            this.Controls.Add(this.category_name_error);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.category_name_txt);
            this.Controls.Add(this.category_status_label);
            this.Controls.Add(this.category_name_label);
            this.Controls.Add(this.heading_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddCategory";
            this.Load += new System.EventHandler(this.Form_AddCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label category_status_error;
        private System.Windows.Forms.Label category_name_error;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox category_name_txt;
        private System.Windows.Forms.Label category_status_label;
        private System.Windows.Forms.Label category_name_label;
        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.ComboBox category_status_combo;
        private System.Windows.Forms.Button close_button;
        private DragControlDemo.DragControl dragControl1;
    }
}