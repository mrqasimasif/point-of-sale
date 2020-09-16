namespace dbLab2
{
    partial class Form2
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.f2cusotmerN = new System.Windows.Forms.TextBox();
            this.itemName = new System.Windows.Forms.RichTextBox();
            this.itemPrice = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.salesDetail = new System.Windows.Forms.DataGridView();
            this.itemNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addNewSaleB = new System.Windows.Forms.Button();
            this.f2TotalPriceL = new System.Windows.Forms.Label();
            this.f2finishSaleB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.f1posLabel = new System.Windows.Forms.Label();
            this.f2hB = new System.Windows.Forms.Button();
            this.f2dtsB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.f2deleteSaleB = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDetail)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(119)))));
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(152, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(632, 383);
            this.panel5.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.f2cusotmerN);
            this.panel2.Controls.Add(this.itemName);
            this.panel2.Controls.Add(this.itemPrice);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.salesDetail);
            this.panel2.Controls.Add(this.addNewSaleB);
            this.panel2.Controls.Add(this.f2TotalPriceL);
            this.panel2.Controls.Add(this.f2finishSaleB);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 373);
            this.panel2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(515, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Customer Name";
            // 
            // f2cusotmerN
            // 
            this.f2cusotmerN.Location = new System.Drawing.Point(518, 186);
            this.f2cusotmerN.Name = "f2cusotmerN";
            this.f2cusotmerN.Size = new System.Drawing.Size(82, 20);
            this.f2cusotmerN.TabIndex = 13;
            // 
            // itemName
            // 
            this.itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(54, 73);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(302, 25);
            this.itemName.TabIndex = 12;
            this.itemName.Text = "";
            // 
            // itemPrice
            // 
            this.itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrice.Location = new System.Drawing.Point(362, 72);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(84, 26);
            this.itemPrice.TabIndex = 11;
            this.itemPrice.Text = "";
            this.itemPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemPrice_Keypress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(53, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sales Detail";
            // 
            // salesDetail
            // 
            this.salesDetail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salesDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameCol,
            this.itemPriceCol});
            this.salesDetail.Location = new System.Drawing.Point(57, 155);
            this.salesDetail.Name = "salesDetail";
            this.salesDetail.Size = new System.Drawing.Size(389, 176);
            this.salesDetail.TabIndex = 9;
            // 
            // itemNameCol
            // 
            this.itemNameCol.HeaderText = "Item Name";
            this.itemNameCol.Name = "itemNameCol";
            this.itemNameCol.ReadOnly = true;
            this.itemNameCol.Width = 250;
            // 
            // itemPriceCol
            // 
            this.itemPriceCol.HeaderText = "Price";
            this.itemPriceCol.Name = "itemPriceCol";
            this.itemPriceCol.ReadOnly = true;
            // 
            // addNewSaleB
            // 
            this.addNewSaleB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewSaleB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewSaleB.ForeColor = System.Drawing.Color.Black;
            this.addNewSaleB.Location = new System.Drawing.Point(518, 73);
            this.addNewSaleB.Name = "addNewSaleB";
            this.addNewSaleB.Size = new System.Drawing.Size(81, 25);
            this.addNewSaleB.TabIndex = 8;
            this.addNewSaleB.Text = "New";
            this.addNewSaleB.UseVisualStyleBackColor = true;
            this.addNewSaleB.Click += new System.EventHandler(this.addNewSaleB_Click);
            // 
            // f2TotalPriceL
            // 
            this.f2TotalPriceL.AutoSize = true;
            this.f2TotalPriceL.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2TotalPriceL.ForeColor = System.Drawing.Color.Black;
            this.f2TotalPriceL.Location = new System.Drawing.Point(514, 260);
            this.f2TotalPriceL.Name = "f2TotalPriceL";
            this.f2TotalPriceL.Size = new System.Drawing.Size(18, 21);
            this.f2TotalPriceL.TabIndex = 4;
            this.f2TotalPriceL.Text = "0";
            // 
            // f2finishSaleB
            // 
            this.f2finishSaleB.BackColor = System.Drawing.Color.Transparent;
            this.f2finishSaleB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.f2finishSaleB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f2finishSaleB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2finishSaleB.ForeColor = System.Drawing.Color.Black;
            this.f2finishSaleB.Location = new System.Drawing.Point(518, 302);
            this.f2finishSaleB.Name = "f2finishSaleB";
            this.f2finishSaleB.Size = new System.Drawing.Size(81, 29);
            this.f2finishSaleB.TabIndex = 3;
            this.f2finishSaleB.Text = "Finish Sale ";
            this.f2finishSaleB.UseVisualStyleBackColor = false;
            this.f2finishSaleB.Click += new System.EventHandler(this.f2finishSaleB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.label4.Location = new System.Drawing.Point(514, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(348, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(49, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add New Sale";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(119)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(152, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(632, 28);
            this.panel3.TabIndex = 7;
            // 
            // f1posLabel
            // 
            this.f1posLabel.AutoSize = true;
            this.f1posLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f1posLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f1posLabel.ForeColor = System.Drawing.Color.White;
            this.f1posLabel.Location = new System.Drawing.Point(19, 19);
            this.f1posLabel.Name = "f1posLabel";
            this.f1posLabel.Size = new System.Drawing.Size(115, 20);
            this.f1posLabel.TabIndex = 1;
            this.f1posLabel.Text = "Point Of Sale";
            // 
            // f2hB
            // 
            this.f2hB.FlatAppearance.BorderSize = 0;
            this.f2hB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f2hB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2hB.ForeColor = System.Drawing.Color.White;
            this.f2hB.Location = new System.Drawing.Point(0, 61);
            this.f2hB.Name = "f2hB";
            this.f2hB.Size = new System.Drawing.Size(151, 65);
            this.f2hB.TabIndex = 6;
            this.f2hB.Text = "Home";
            this.f2hB.UseVisualStyleBackColor = true;
            this.f2hB.Click += new System.EventHandler(this.f1hB_Click);
            // 
            // f2dtsB
            // 
            this.f2dtsB.FlatAppearance.BorderSize = 0;
            this.f2dtsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f2dtsB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2dtsB.ForeColor = System.Drawing.Color.White;
            this.f2dtsB.Location = new System.Drawing.Point(0, 198);
            this.f2dtsB.Name = "f2dtsB";
            this.f2dtsB.Size = new System.Drawing.Size(151, 65);
            this.f2dtsB.TabIndex = 5;
            this.f2dtsB.Text = "Display Total Sales";
            this.f2dtsB.UseVisualStyleBackColor = true;
            this.f2dtsB.Click += new System.EventHandler(this.f2dtsB_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(119)))));
            this.panel1.Controls.Add(this.f2deleteSaleB);
            this.panel1.Controls.Add(this.f2hB);
            this.panel1.Controls.Add(this.f2dtsB);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 411);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.f1posLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 59);
            this.panel4.TabIndex = 1;
            // 
            // f2deleteSaleB
            // 
            this.f2deleteSaleB.FlatAppearance.BorderSize = 0;
            this.f2deleteSaleB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f2deleteSaleB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2deleteSaleB.ForeColor = System.Drawing.Color.White;
            this.f2deleteSaleB.Location = new System.Drawing.Point(-1, 129);
            this.f2deleteSaleB.Name = "f2deleteSaleB";
            this.f2deleteSaleB.Size = new System.Drawing.Size(151, 65);
            this.f2deleteSaleB.TabIndex = 7;
            this.f2deleteSaleB.Text = "Delete Sale";
            this.f2deleteSaleB.UseVisualStyleBackColor = true;
            this.f2deleteSaleB.Click += new System.EventHandler(this.f2deleteSaleB_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDetail)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView salesDetail;
        private System.Windows.Forms.Button addNewSaleB;
        private System.Windows.Forms.Label f2TotalPriceL;
        private System.Windows.Forms.Button f2finishSaleB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label f1posLabel;
        private System.Windows.Forms.Button f2hB;
        private System.Windows.Forms.Button f2dtsB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceCol;
        private System.Windows.Forms.TextBox f2cusotmerN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox itemName;
        private System.Windows.Forms.Button f2deleteSaleB;
    }
}