namespace BookShopManagement.Forms
{
    partial class License
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.copyright_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.start = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unlimited = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.heading_label = new System.Windows.Forms.Label();
            this.av = new System.Windows.Forms.Label();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 10);
            this.panel3.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 407);
            this.panel2.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(456, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 407);
            this.panel4.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.copyright_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 22);
            this.panel1.TabIndex = 34;
            // 
            // copyright_label
            // 
            this.copyright_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyright_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright_label.ForeColor = System.Drawing.Color.White;
            this.copyright_label.Location = new System.Drawing.Point(10, 2);
            this.copyright_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(366, 18);
            this.copyright_label.TabIndex = 4;
            this.copyright_label.Text = "Copyright © 2020 | All Rights Reserved - KoderSpot.";
            this.copyright_label.Click += new System.EventHandler(this.copyright_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Please Enter License Key";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(16, 126);
            this.maskedTextBox1.Mask = "CCCCC-CCCCC-CCCCC-CCCCC-CCCCC";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(434, 31);
            this.maskedTextBox1.TabIndex = 36;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(191, 174);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(244, 35);
            this.start.TabIndex = 38;
            this.start.Text = "-";
            this.start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 43);
            this.label2.TabIndex = 37;
            this.label2.Text = "Start Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // end
            // 
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.Location = new System.Drawing.Point(191, 234);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(244, 35);
            this.end.TabIndex = 40;
            this.end.Text = "-";
            this.end.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.end.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(434, 43);
            this.label4.TabIndex = 39;
            this.label4.Text = "Expire Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(434, 43);
            this.label5.TabIndex = 41;
            this.label5.Text = "Unlimited";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unlimited
            // 
            this.unlimited.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unlimited.Location = new System.Drawing.Point(191, 293);
            this.unlimited.Name = "unlimited";
            this.unlimited.Size = new System.Drawing.Size(244, 35);
            this.unlimited.TabIndex = 42;
            this.unlimited.Text = "-";
            this.unlimited.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.save_btn.Location = new System.Drawing.Point(266, 346);
            this.save_btn.Margin = new System.Windows.Forms.Padding(2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(185, 47);
            this.save_btn.TabIndex = 43;
            this.save_btn.Text = "Activate";
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
            this.close_button.Location = new System.Drawing.Point(427, 10);
            this.close_button.Margin = new System.Windows.Forms.Padding(2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(28, 27);
            this.close_button.TabIndex = 185;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // heading_label
            // 
            this.heading_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.heading_label.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.heading_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.heading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_label.ForeColor = System.Drawing.Color.White;
            this.heading_label.Location = new System.Drawing.Point(10, 10);
            this.heading_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(446, 68);
            this.heading_label.TabIndex = 184;
            this.heading_label.Text = "License";
            this.heading_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // av
            // 
            this.av.Location = new System.Drawing.Point(307, 103);
            this.av.Name = "av";
            this.av.Size = new System.Drawing.Size(143, 20);
            this.av.TabIndex = 186;
            this.av.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.heading_label;
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 429);
            this.Controls.Add(this.av);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.heading_label);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.unlimited);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.end);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "License";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License";
            this.Load += new System.EventHandler(this.License_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label copyright_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label unlimited;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.Label av;
        private DragControlDemo.DragControl dragControl1;
    }
}