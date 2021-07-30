namespace BookShopManagement.Forms
{
    partial class Branch_Form
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
            this.branch_number_txt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear_btn = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.branch_head_txt = new System.Windows.Forms.TextBox();
            this.branch_area_txt = new System.Windows.Forms.TextBox();
            this.branch_number_label = new System.Windows.Forms.Label();
            this.branch_head_label = new System.Windows.Forms.Label();
            this.branch_area_label = new System.Windows.Forms.Label();
            this.heading_label = new System.Windows.Forms.Label();
            this.branch_area_error = new System.Windows.Forms.Label();
            this.branch_head_error = new System.Windows.Forms.Label();
            this.branch_number_error = new System.Windows.Forms.Label();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.label3 = new System.Windows.Forms.Label();
            this.branch_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // branch_number_txt
            // 
            this.branch_number_txt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_number_txt.Location = new System.Drawing.Point(156, 127);
            this.branch_number_txt.Margin = new System.Windows.Forms.Padding(2);
            this.branch_number_txt.Name = "branch_number_txt";
            this.branch_number_txt.Size = new System.Drawing.Size(353, 27);
            this.branch_number_txt.TabIndex = 2;
            this.branch_number_txt.TextChanged += new System.EventHandler(this.branch_number_txt_TextChanged);
            this.branch_number_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.branch_number_txt_KeyPress);
            this.branch_number_txt.Leave += new System.EventHandler(this.branch_number_txt_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 227);
            this.panel2.TabIndex = 71;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 8);
            this.panel3.TabIndex = 72;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(512, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 235);
            this.panel4.TabIndex = 73;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 235);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 8);
            this.panel1.TabIndex = 74;
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
            this.clear_btn.Location = new System.Drawing.Point(285, 198);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(2);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(104, 31);
            this.clear_btn.TabIndex = 68;
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
            this.close_button.Location = new System.Drawing.Point(484, 8);
            this.close_button.Margin = new System.Windows.Forms.Padding(2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(28, 27);
            this.close_button.TabIndex = 67;
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
            this.save_btn.Location = new System.Drawing.Point(393, 198);
            this.save_btn.Margin = new System.Windows.Forms.Padding(2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(115, 31);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // branch_head_txt
            // 
            this.branch_head_txt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_head_txt.Location = new System.Drawing.Point(156, 91);
            this.branch_head_txt.Margin = new System.Windows.Forms.Padding(2);
            this.branch_head_txt.Name = "branch_head_txt";
            this.branch_head_txt.Size = new System.Drawing.Size(353, 27);
            this.branch_head_txt.TabIndex = 1;
            this.branch_head_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.branch_head_txt_KeyPress);
            // 
            // branch_area_txt
            // 
            this.branch_area_txt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_area_txt.Location = new System.Drawing.Point(156, 55);
            this.branch_area_txt.Margin = new System.Windows.Forms.Padding(2);
            this.branch_area_txt.Name = "branch_area_txt";
            this.branch_area_txt.Size = new System.Drawing.Size(353, 27);
            this.branch_area_txt.TabIndex = 0;
            this.branch_area_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.branch_area_txt_KeyPress);
            // 
            // branch_number_label
            // 
            this.branch_number_label.AutoSize = true;
            this.branch_number_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_number_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.branch_number_label.Location = new System.Drawing.Point(12, 129);
            this.branch_number_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.branch_number_label.Name = "branch_number_label";
            this.branch_number_label.Size = new System.Drawing.Size(129, 23);
            this.branch_number_label.TabIndex = 59;
            this.branch_number_label.Text = "Phone Number";
            // 
            // branch_head_label
            // 
            this.branch_head_label.AutoSize = true;
            this.branch_head_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_head_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.branch_head_label.Location = new System.Drawing.Point(12, 94);
            this.branch_head_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.branch_head_label.Name = "branch_head_label";
            this.branch_head_label.Size = new System.Drawing.Size(110, 23);
            this.branch_head_label.TabIndex = 61;
            this.branch_head_label.Text = "Branch Head";
            // 
            // branch_area_label
            // 
            this.branch_area_label.AutoSize = true;
            this.branch_area_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_area_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.branch_area_label.Location = new System.Drawing.Point(12, 55);
            this.branch_area_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.branch_area_label.Name = "branch_area_label";
            this.branch_area_label.Size = new System.Drawing.Size(107, 23);
            this.branch_area_label.TabIndex = 62;
            this.branch_area_label.Text = "Branch Area";
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
            this.heading_label.TabIndex = 63;
            this.heading_label.Text = "Add Branch";
            this.heading_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // branch_area_error
            // 
            this.branch_area_error.AutoSize = true;
            this.branch_area_error.BackColor = System.Drawing.Color.Transparent;
            this.branch_area_error.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_area_error.ForeColor = System.Drawing.Color.Red;
            this.branch_area_error.Location = new System.Drawing.Point(115, 54);
            this.branch_area_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.branch_area_error.Name = "branch_area_error";
            this.branch_area_error.Size = new System.Drawing.Size(21, 19);
            this.branch_area_error.TabIndex = 75;
            this.branch_area_error.Text = "*";
            // 
            // branch_head_error
            // 
            this.branch_head_error.AutoSize = true;
            this.branch_head_error.BackColor = System.Drawing.Color.Transparent;
            this.branch_head_error.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_head_error.ForeColor = System.Drawing.Color.Red;
            this.branch_head_error.Location = new System.Drawing.Point(119, 89);
            this.branch_head_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.branch_head_error.Name = "branch_head_error";
            this.branch_head_error.Size = new System.Drawing.Size(21, 19);
            this.branch_head_error.TabIndex = 76;
            this.branch_head_error.Text = "*";
            // 
            // branch_number_error
            // 
            this.branch_number_error.AutoSize = true;
            this.branch_number_error.BackColor = System.Drawing.Color.Transparent;
            this.branch_number_error.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_number_error.ForeColor = System.Drawing.Color.Red;
            this.branch_number_error.Location = new System.Drawing.Point(133, 127);
            this.branch_number_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.branch_number_error.Name = "branch_number_error";
            this.branch_number_error.Size = new System.Drawing.Size(21, 19);
            this.branch_number_error.TabIndex = 77;
            this.branch_number_error.Text = "*";
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.heading_label;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(68, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 19);
            this.label3.TabIndex = 139;
            this.label3.Text = "*";
            // 
            // branch_status
            // 
            this.branch_status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.branch_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branch_status.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_status.FormattingEnabled = true;
            this.branch_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.branch_status.Location = new System.Drawing.Point(156, 163);
            this.branch_status.Margin = new System.Windows.Forms.Padding(2);
            this.branch_status.Name = "branch_status";
            this.branch_status.Size = new System.Drawing.Size(353, 27);
            this.branch_status.TabIndex = 137;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.Location = new System.Drawing.Point(13, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 138;
            this.label4.Text = "Status";
            // 
            // Branch_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 243);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.branch_status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.branch_number_error);
            this.Controls.Add(this.branch_head_error);
            this.Controls.Add(this.branch_area_error);
            this.Controls.Add(this.branch_number_txt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.branch_head_txt);
            this.Controls.Add(this.branch_area_txt);
            this.Controls.Add(this.branch_number_label);
            this.Controls.Add(this.branch_head_label);
            this.Controls.Add(this.branch_area_label);
            this.Controls.Add(this.heading_label);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Branch_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewBranch";
            this.Load += new System.EventHandler(this.Branch_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox branch_number_txt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox branch_head_txt;
        private System.Windows.Forms.TextBox branch_area_txt;
        private System.Windows.Forms.Label branch_number_label;
        private System.Windows.Forms.Label branch_head_label;
        private System.Windows.Forms.Label branch_area_label;
        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.Label branch_area_error;
        private System.Windows.Forms.Label branch_head_error;
        private System.Windows.Forms.Label branch_number_error;
        private DragControlDemo.DragControl dragControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox branch_status;
        private System.Windows.Forms.Label label4;
    }
}