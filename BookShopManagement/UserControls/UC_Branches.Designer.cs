namespace BookShopManagement.UserControls
{
    partial class UC_Branches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Branches));
            this.search_box_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.delete_branch_btn = new System.Windows.Forms.Button();
            this.edit_branch_btn = new System.Windows.Forms.Button();
            this.add_branch_btn = new System.Windows.Forms.Button();
            this.branches_dgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.head = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.copyright_label = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branches_dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_box_txt
            // 
            this.search_box_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box_txt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box_txt.Location = new System.Drawing.Point(846, 18);
            this.search_box_txt.Margin = new System.Windows.Forms.Padding(2);
            this.search_box_txt.Name = "search_box_txt";
            this.search_box_txt.Size = new System.Drawing.Size(243, 31);
            this.search_box_txt.TabIndex = 5;
            this.search_box_txt.TextChanged += new System.EventHandler(this.search_box_txt_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(790, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Search";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.delete_branch_btn);
            this.panel5.Controls.Add(this.edit_branch_btn);
            this.panel5.Controls.Add(this.search_box_txt);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.add_branch_btn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 8);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1100, 55);
            this.panel5.TabIndex = 13;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // delete_branch_btn
            // 
            this.delete_branch_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.delete_branch_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_branch_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.delete_branch_btn.FlatAppearance.BorderSize = 0;
            this.delete_branch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_branch_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_branch_btn.ForeColor = System.Drawing.Color.White;
            this.delete_branch_btn.Image = global::BookShopManagement.Properties.Resources.trash_32px;
            this.delete_branch_btn.Location = new System.Drawing.Point(265, 0);
            this.delete_branch_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_branch_btn.Name = "delete_branch_btn";
            this.delete_branch_btn.Size = new System.Drawing.Size(138, 55);
            this.delete_branch_btn.TabIndex = 7;
            this.delete_branch_btn.Text = "   Inactivate Branch";
            this.delete_branch_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_branch_btn.UseVisualStyleBackColor = false;
            this.delete_branch_btn.Click += new System.EventHandler(this.delete_branch_btn_Click);
            // 
            // edit_branch_btn
            // 
            this.edit_branch_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.edit_branch_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_branch_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.edit_branch_btn.FlatAppearance.BorderSize = 0;
            this.edit_branch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_branch_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_branch_btn.ForeColor = System.Drawing.Color.White;
            this.edit_branch_btn.Image = global::BookShopManagement.Properties.Resources.edit_property_32px;
            this.edit_branch_btn.Location = new System.Drawing.Point(138, 0);
            this.edit_branch_btn.Margin = new System.Windows.Forms.Padding(2);
            this.edit_branch_btn.Name = "edit_branch_btn";
            this.edit_branch_btn.Size = new System.Drawing.Size(127, 55);
            this.edit_branch_btn.TabIndex = 6;
            this.edit_branch_btn.Text = "   Edit Branch";
            this.edit_branch_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_branch_btn.UseVisualStyleBackColor = false;
            this.edit_branch_btn.Click += new System.EventHandler(this.edit_branch_btn_Click);
            // 
            // add_branch_btn
            // 
            this.add_branch_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.add_branch_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_branch_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.add_branch_btn.FlatAppearance.BorderSize = 0;
            this.add_branch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_branch_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_branch_btn.ForeColor = System.Drawing.Color.White;
            this.add_branch_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_branch_btn.Image")));
            this.add_branch_btn.Location = new System.Drawing.Point(0, 0);
            this.add_branch_btn.Margin = new System.Windows.Forms.Padding(2);
            this.add_branch_btn.Name = "add_branch_btn";
            this.add_branch_btn.Size = new System.Drawing.Size(138, 55);
            this.add_branch_btn.TabIndex = 0;
            this.add_branch_btn.Text = "   Add Branch";
            this.add_branch_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_branch_btn.UseVisualStyleBackColor = false;
            this.add_branch_btn.Click += new System.EventHandler(this.add_branch_btn_Click);
            // 
            // branches_dgv
            // 
            this.branches_dgv.AllowUserToAddRows = false;
            this.branches_dgv.AllowUserToDeleteRows = false;
            this.branches_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.branches_dgv.BackgroundColor = System.Drawing.Color.White;
            this.branches_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.branches_dgv.ColumnHeadersHeight = 38;
            this.branches_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.area,
            this.head,
            this.number,
            this.Status});
            this.branches_dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.branches_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.branches_dgv.GridColor = System.Drawing.Color.Black;
            this.branches_dgv.Location = new System.Drawing.Point(8, 63);
            this.branches_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.branches_dgv.Name = "branches_dgv";
            this.branches_dgv.ReadOnly = true;
            this.branches_dgv.RowHeadersVisible = false;
            this.branches_dgv.RowTemplate.Height = 30;
            this.branches_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.branches_dgv.Size = new System.Drawing.Size(1100, 531);
            this.branches_dgv.TabIndex = 14;
            this.branches_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.branches_dgv_CellClick);
            this.branches_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.branches_dgv_CellContentClick);
            this.branches_dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.branches_dgv_CellFormatting);
            // 
            // id
            // 
            this.id.HeaderText = "Branch ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // area
            // 
            this.area.HeaderText = "Branch Area";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // head
            // 
            this.head.HeaderText = "Branch Head";
            this.head.Name = "head";
            this.head.ReadOnly = true;
            // 
            // number
            // 
            this.number.HeaderText = "Branch Phone";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(8, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 8);
            this.panel3.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 594);
            this.panel2.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1108, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 594);
            this.panel4.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.copyright_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 594);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 18);
            this.panel1.TabIndex = 26;
            // 
            // copyright_label
            // 
            this.copyright_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyright_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright_label.ForeColor = System.Drawing.Color.White;
            this.copyright_label.Location = new System.Drawing.Point(12, -2);
            this.copyright_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(388, 18);
            this.copyright_label.TabIndex = 3;
            this.copyright_label.Text = "Copyright © 2020 | All Rights Reserved - KoderSpot.";
            // 
            // UC_Branches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.branches_dgv);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Branches";
            this.Size = new System.Drawing.Size(1116, 612);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branches_dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox search_box_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add_branch_btn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView branches_dgv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button edit_branch_btn;
        private System.Windows.Forms.Button delete_branch_btn;
        private System.Windows.Forms.Label copyright_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn head;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}