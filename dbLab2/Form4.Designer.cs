namespace dbLab2
{
    partial class Form4
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.f4totalSalesDetail = new System.Windows.Forms.DataGridView();
            this.itemNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f4grandTotalL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.f4resetB = new System.Windows.Forms.Button();
            this.f4viewSaleB = new System.Windows.Forms.Button();
            this.f4ansB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.f4dsB = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.f4homeB = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f4totalSalesDetail)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.f4totalSalesDetail);
            this.panel2.Controls.Add(this.f4grandTotalL);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.f4resetB);
            this.panel2.Controls.Add(this.f4viewSaleB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.panel2.Location = new System.Drawing.Point(152, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 372);
            this.panel2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Sales Detail";
            // 
            // f4totalSalesDetail
            // 
            this.f4totalSalesDetail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f4totalSalesDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f4totalSalesDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameCol,
            this.itemPriceCol,
            this.col,
            this.Column1,
            this.Column2});
            this.f4totalSalesDetail.Location = new System.Drawing.Point(20, 42);
            this.f4totalSalesDetail.Name = "f4totalSalesDetail";
            this.f4totalSalesDetail.Size = new System.Drawing.Size(560, 205);
            this.f4totalSalesDetail.TabIndex = 26;
            // 
            // itemNameCol
            // 
            this.itemNameCol.HeaderText = "Sales Id";
            this.itemNameCol.Name = "itemNameCol";
            this.itemNameCol.ReadOnly = true;
            // 
            // itemPriceCol
            // 
            this.itemPriceCol.HeaderText = "Product Name";
            this.itemPriceCol.Name = "itemPriceCol";
            this.itemPriceCol.ReadOnly = true;
            // 
            // col
            // 
            this.col.HeaderText = "Product Cost";
            this.col.Name = "col";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Total Amount";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Customer Name";
            this.Column2.Name = "Column2";
            // 
            // f4grandTotalL
            // 
            this.f4grandTotalL.AutoSize = true;
            this.f4grandTotalL.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f4grandTotalL.ForeColor = System.Drawing.Color.Black;
            this.f4grandTotalL.Location = new System.Drawing.Point(384, 281);
            this.f4grandTotalL.Name = "f4grandTotalL";
            this.f4grandTotalL.Size = new System.Drawing.Size(18, 21);
            this.f4grandTotalL.TabIndex = 23;
            this.f4grandTotalL.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.label4.Location = new System.Drawing.Point(384, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Grand Total Sale";
            // 
            // f4resetB
            // 
            this.f4resetB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f4resetB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f4resetB.ForeColor = System.Drawing.Color.Black;
            this.f4resetB.Location = new System.Drawing.Point(493, 312);
            this.f4resetB.Name = "f4resetB";
            this.f4resetB.Size = new System.Drawing.Size(87, 27);
            this.f4resetB.TabIndex = 21;
            this.f4resetB.Text = "Reset";
            this.f4resetB.UseVisualStyleBackColor = true;
            this.f4resetB.Click += new System.EventHandler(this.f4resetB_Click);
            // 
            // f4viewSaleB
            // 
            this.f4viewSaleB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f4viewSaleB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f4viewSaleB.ForeColor = System.Drawing.Color.Black;
            this.f4viewSaleB.Location = new System.Drawing.Point(388, 312);
            this.f4viewSaleB.Name = "f4viewSaleB";
            this.f4viewSaleB.Size = new System.Drawing.Size(87, 27);
            this.f4viewSaleB.TabIndex = 20;
            this.f4viewSaleB.Text = "View Sales";
            this.f4viewSaleB.UseVisualStyleBackColor = true;
            this.f4viewSaleB.Click += new System.EventHandler(this.f4viewSaleB_Click);
            // 
            // f4ansB
            // 
            this.f4ansB.FlatAppearance.BorderSize = 0;
            this.f4ansB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f4ansB.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f4ansB.ForeColor = System.Drawing.Color.White;
            this.f4ansB.Location = new System.Drawing.Point(0, 130);
            this.f4ansB.Name = "f4ansB";
            this.f4ansB.Size = new System.Drawing.Size(151, 65);
            this.f4ansB.TabIndex = 0;
            this.f4ansB.Text = "Add New Sale";
            this.f4ansB.UseVisualStyleBackColor = true;
            this.f4ansB.Click += new System.EventHandler(this.f4ansB_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(119)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(152, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(632, 27);
            this.panel3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Sales Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(119)))));
            this.panel1.Controls.Add(this.f4homeB);
            this.panel1.Controls.Add(this.f4dsB);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.f4ansB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 411);
            this.panel1.TabIndex = 10;
            // 
            // f4dsB
            // 
            this.f4dsB.FlatAppearance.BorderSize = 0;
            this.f4dsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f4dsB.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f4dsB.ForeColor = System.Drawing.Color.White;
            this.f4dsB.Location = new System.Drawing.Point(0, 195);
            this.f4dsB.Name = "f4dsB";
            this.f4dsB.Size = new System.Drawing.Size(151, 65);
            this.f4dsB.TabIndex = 6;
            this.f4dsB.Text = "Delete Sale";
            this.f4dsB.UseVisualStyleBackColor = true;
            this.f4dsB.Click += new System.EventHandler(this.f4dsB_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 59);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Point Of Sale";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(119)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(784, 411);
            this.panel5.TabIndex = 13;
            // 
            // f4homeB
            // 
            this.f4homeB.FlatAppearance.BorderSize = 0;
            this.f4homeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f4homeB.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f4homeB.ForeColor = System.Drawing.Color.White;
            this.f4homeB.Location = new System.Drawing.Point(0, 59);
            this.f4homeB.Name = "f4homeB";
            this.f4homeB.Size = new System.Drawing.Size(151, 65);
            this.f4homeB.TabIndex = 7;
            this.f4homeB.Text = "Home";
            this.f4homeB.UseVisualStyleBackColor = true;
            this.f4homeB.Click += new System.EventHandler(this.f4homeB_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f4totalSalesDetail)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button f4ansB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button f4dsB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label f4grandTotalL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button f4resetB;
        private System.Windows.Forms.Button f4viewSaleB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView f4totalSalesDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button f4homeB;
    }
}