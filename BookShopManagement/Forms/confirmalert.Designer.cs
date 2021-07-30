namespace BookShopManagement.Forms
{
    partial class confirmalert
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
            this.yes = new System.Windows.Forms.Button();
            this.msg_lbl = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.heading_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.no = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yes
            // 
            this.yes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yes.BackColor = System.Drawing.Color.DarkGreen;
            this.yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yes.FlatAppearance.BorderSize = 0;
            this.yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes.ForeColor = System.Drawing.Color.White;
            this.yes.Location = new System.Drawing.Point(341, 126);
            this.yes.Margin = new System.Windows.Forms.Padding(2);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(99, 44);
            this.yes.TabIndex = 139;
            this.yes.Text = "Yes";
            this.yes.UseVisualStyleBackColor = false;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // msg_lbl
            // 
            this.msg_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msg_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.msg_lbl.Location = new System.Drawing.Point(11, 55);
            this.msg_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msg_lbl.Name = "msg_lbl";
            this.msg_lbl.Size = new System.Drawing.Size(430, 69);
            this.msg_lbl.TabIndex = 138;
            this.msg_lbl.Text = "Do You Want To Generate Sale Report?";
            this.msg_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.close_button.Location = new System.Drawing.Point(416, 8);
            this.close_button.Margin = new System.Windows.Forms.Padding(2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(28, 27);
            this.close_button.TabIndex = 137;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            // 
            // heading_label
            // 
            this.heading_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heading_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.heading_label.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_label.ForeColor = System.Drawing.Color.White;
            this.heading_label.Location = new System.Drawing.Point(8, 8);
            this.heading_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(436, 47);
            this.heading_label.TabIndex = 136;
            this.heading_label.Text = "Sale Report";
            this.heading_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 166);
            this.panel2.TabIndex = 132;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 8);
            this.panel3.TabIndex = 133;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(444, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 174);
            this.panel4.TabIndex = 134;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 174);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 8);
            this.panel1.TabIndex = 135;
            // 
            // no
            // 
            this.no.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.no.FlatAppearance.BorderSize = 0;
            this.no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.ForeColor = System.Drawing.Color.White;
            this.no.Location = new System.Drawing.Point(238, 126);
            this.no.Margin = new System.Windows.Forms.Padding(2);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(99, 44);
            this.no.TabIndex = 140;
            this.no.Text = "No";
            this.no.UseVisualStyleBackColor = false;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // confirmalert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(452, 182);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.msg_lbl);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.heading_label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "confirmalert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dr";
            this.Load += new System.EventHandler(this.confirmalert_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Label msg_lbl;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button no;
    }
}