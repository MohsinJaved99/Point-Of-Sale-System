namespace BookShopManagement.UserControls
{
    partial class UC_Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Users));
            this.users_dgv = new System.Windows.Forms.DataGridView();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.search_box_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.delete_user_btn = new System.Windows.Forms.Button();
            this.edit_user_btn = new System.Windows.Forms.Button();
            this.add_user_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.copyright_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.users_dgv)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // users_dgv
            // 
            this.users_dgv.AllowUserToAddRows = false;
            this.users_dgv.AllowUserToDeleteRows = false;
            this.users_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.users_dgv.BackgroundColor = System.Drawing.Color.White;
            this.users_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.users_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.users_dgv.ColumnHeadersHeight = 42;
            this.users_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_ID,
            this.User_First_Name,
            this.User_Last_Name,
            this.User_Mail,
            this.User_Phone,
            this.User_Username,
            this.NIC,
            this.User_Password,
            this.User_Branch,
            this.User_Role,
            this.status});
            this.users_dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.users_dgv.GridColor = System.Drawing.Color.Black;
            this.users_dgv.Location = new System.Drawing.Point(10, 89);
            this.users_dgv.Name = "users_dgv";
            this.users_dgv.ReadOnly = true;
            this.users_dgv.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.users_dgv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.users_dgv.RowTemplate.Height = 30;
            this.users_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.users_dgv.Size = new System.Drawing.Size(1096, 501);
            this.users_dgv.TabIndex = 16;
            this.users_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.users_dgv_CellClick);
            this.users_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.users_dgv_CellContentClick);
            this.users_dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.users_dgv_CellFormatting);
            // 
            // User_ID
            // 
            this.User_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.User_ID.HeaderText = "User ID";
            this.User_ID.Name = "User_ID";
            this.User_ID.ReadOnly = true;
            this.User_ID.Visible = false;
            this.User_ID.Width = 63;
            // 
            // User_First_Name
            // 
            this.User_First_Name.FillWeight = 105.6472F;
            this.User_First_Name.HeaderText = "First Name";
            this.User_First_Name.Name = "User_First_Name";
            this.User_First_Name.ReadOnly = true;
            // 
            // User_Last_Name
            // 
            this.User_Last_Name.FillWeight = 105.6472F;
            this.User_Last_Name.HeaderText = "Last Name";
            this.User_Last_Name.Name = "User_Last_Name";
            this.User_Last_Name.ReadOnly = true;
            // 
            // User_Mail
            // 
            this.User_Mail.FillWeight = 105.6472F;
            this.User_Mail.HeaderText = "Email";
            this.User_Mail.Name = "User_Mail";
            this.User_Mail.ReadOnly = true;
            // 
            // User_Phone
            // 
            this.User_Phone.FillWeight = 105.6472F;
            this.User_Phone.HeaderText = "Phone Number";
            this.User_Phone.Name = "User_Phone";
            this.User_Phone.ReadOnly = true;
            // 
            // User_Username
            // 
            this.User_Username.FillWeight = 105.6472F;
            this.User_Username.HeaderText = "Username";
            this.User_Username.Name = "User_Username";
            this.User_Username.ReadOnly = true;
            // 
            // NIC
            // 
            this.NIC.FillWeight = 105.6472F;
            this.NIC.HeaderText = "NIC";
            this.NIC.Name = "NIC";
            this.NIC.ReadOnly = true;
            // 
            // User_Password
            // 
            this.User_Password.HeaderText = "Password";
            this.User_Password.Name = "User_Password";
            this.User_Password.ReadOnly = true;
            this.User_Password.Visible = false;
            // 
            // User_Branch
            // 
            this.User_Branch.FillWeight = 105.6472F;
            this.User_Branch.HeaderText = "Branch";
            this.User_Branch.Name = "User_Branch";
            this.User_Branch.ReadOnly = true;
            // 
            // User_Role
            // 
            this.User_Role.FillWeight = 105.6472F;
            this.User_Role.HeaderText = "Role";
            this.User_Role.Name = "User_Role";
            this.User_Role.ReadOnly = true;
            // 
            // status
            // 
            this.status.FillWeight = 54.82233F;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.search_box_txt);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.delete_user_btn);
            this.panel5.Controls.Add(this.edit_user_btn);
            this.panel5.Controls.Add(this.add_user_btn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1096, 79);
            this.panel5.TabIndex = 15;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // search_box_txt
            // 
            this.search_box_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_box_txt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box_txt.Location = new System.Drawing.Point(789, 15);
            this.search_box_txt.Name = "search_box_txt";
            this.search_box_txt.Size = new System.Drawing.Size(301, 31);
            this.search_box_txt.TabIndex = 10;
            this.search_box_txt.TextChanged += new System.EventHandler(this.search_box_txt_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(709, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Search";
            // 
            // delete_user_btn
            // 
            this.delete_user_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.delete_user_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_user_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.delete_user_btn.FlatAppearance.BorderSize = 0;
            this.delete_user_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_user_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_user_btn.ForeColor = System.Drawing.Color.White;
            this.delete_user_btn.Image = global::BookShopManagement.Properties.Resources.trash_32px;
            this.delete_user_btn.Location = new System.Drawing.Point(323, 0);
            this.delete_user_btn.Name = "delete_user_btn";
            this.delete_user_btn.Size = new System.Drawing.Size(168, 79);
            this.delete_user_btn.TabIndex = 8;
            this.delete_user_btn.Text = "   Delete User";
            this.delete_user_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_user_btn.UseVisualStyleBackColor = false;
            this.delete_user_btn.Click += new System.EventHandler(this.delete_user_btn_Click);
            // 
            // edit_user_btn
            // 
            this.edit_user_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.edit_user_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_user_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.edit_user_btn.FlatAppearance.BorderSize = 0;
            this.edit_user_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_user_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_user_btn.ForeColor = System.Drawing.Color.White;
            this.edit_user_btn.Image = global::BookShopManagement.Properties.Resources.edit_property_32px;
            this.edit_user_btn.Location = new System.Drawing.Point(164, 0);
            this.edit_user_btn.Name = "edit_user_btn";
            this.edit_user_btn.Size = new System.Drawing.Size(159, 79);
            this.edit_user_btn.TabIndex = 6;
            this.edit_user_btn.Text = "   Edit User";
            this.edit_user_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_user_btn.UseVisualStyleBackColor = false;
            this.edit_user_btn.Click += new System.EventHandler(this.edit_user_btn_Click);
            // 
            // add_user_btn
            // 
            this.add_user_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.add_user_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_user_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.add_user_btn.FlatAppearance.BorderSize = 0;
            this.add_user_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_user_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_user_btn.ForeColor = System.Drawing.Color.White;
            this.add_user_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_user_btn.Image")));
            this.add_user_btn.Location = new System.Drawing.Point(0, 0);
            this.add_user_btn.Name = "add_user_btn";
            this.add_user_btn.Size = new System.Drawing.Size(164, 79);
            this.add_user_btn.TabIndex = 0;
            this.add_user_btn.Text = "   Add User";
            this.add_user_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_user_btn.UseVisualStyleBackColor = false;
            this.add_user_btn.Click += new System.EventHandler(this.add_user_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1096, 10);
            this.panel3.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 590);
            this.panel2.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1106, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 590);
            this.panel4.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.copyright_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 590);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 22);
            this.panel1.TabIndex = 26;
            // 
            // copyright_label
            // 
            this.copyright_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyright_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright_label.ForeColor = System.Drawing.Color.White;
            this.copyright_label.Location = new System.Drawing.Point(10, 2);
            this.copyright_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(742, 18);
            this.copyright_label.TabIndex = 4;
            this.copyright_label.Text = "Copyright © 2020 | All Rights Reserved - KoderSpot.";
            // 
            // UC_Users
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.users_dgv);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Name = "UC_Users";
            this.Size = new System.Drawing.Size(1116, 612);
            this.Load += new System.EventHandler(this.UC_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.users_dgv)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView users_dgv;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button add_user_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button edit_user_btn;
        private System.Windows.Forms.Button delete_user_btn;
        private System.Windows.Forms.TextBox search_box_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label copyright_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}
