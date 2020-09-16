namespace dbLab2
{
    partial class Form3
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
            this.label6 = new System.Windows.Forms.Label();
            this.f3CustomerNT = new System.Windows.Forms.TextBox();
            this.f3TotalPriceL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.f3resetB = new System.Windows.Forms.Button();
            this.f3deleteSaleB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.f3displaySaleB = new System.Windows.Forms.Button();
            this.f3salesDetail = new System.Windows.Forms.DataGridView();
            this.itemNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.f3salesIdT = new System.Windows.Forms.TextBox();
            this.f3ansB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.f3dtsB = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.f3homeB = new System.Windows.Forms.Button();
            this.f3updateCB = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f3salesDetail)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.f3updateCB);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.f3CustomerNT);
            this.panel2.Controls.Add(this.f3TotalPriceL);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.f3resetB);
            this.panel2.Controls.Add(this.f3deleteSaleB);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.f3displaySaleB);
            this.panel2.Controls.Add(this.f3salesDetail);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.f3salesIdT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.panel2.Location = new System.Drawing.Point(152, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 372);
            this.panel2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(512, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Customer Name";
            // 
            // f3CustomerNT
            // 
            this.f3CustomerNT.Location = new System.Drawing.Point(515, 120);
            this.f3CustomerNT.Multiline = true;
            this.f3CustomerNT.Name = "f3CustomerNT";
            this.f3CustomerNT.Size = new System.Drawing.Size(104, 25);
            this.f3CustomerNT.TabIndex = 18;
            // 
            // f3TotalPriceL
            // 
            this.f3TotalPriceL.AutoSize = true;
            this.f3TotalPriceL.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f3TotalPriceL.ForeColor = System.Drawing.Color.Black;
            this.f3TotalPriceL.Location = new System.Drawing.Point(517, 266);
            this.f3TotalPriceL.Name = "f3TotalPriceL";
            this.f3TotalPriceL.Size = new System.Drawing.Size(18, 21);
            this.f3TotalPriceL.TabIndex = 17;
            this.f3TotalPriceL.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.label4.Location = new System.Drawing.Point(517, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total Amount";
            // 
            // f3resetB
            // 
            this.f3resetB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f3resetB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f3resetB.ForeColor = System.Drawing.Color.Black;
            this.f3resetB.Location = new System.Drawing.Point(412, 314);
            this.f3resetB.Name = "f3resetB";
            this.f3resetB.Size = new System.Drawing.Size(87, 27);
            this.f3resetB.TabIndex = 15;
            this.f3resetB.Text = "Reset";
            this.f3resetB.UseVisualStyleBackColor = true;
            this.f3resetB.Click += new System.EventHandler(this.f3resetB_Click);
            // 
            // f3deleteSaleB
            // 
            this.f3deleteSaleB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f3deleteSaleB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f3deleteSaleB.ForeColor = System.Drawing.Color.Black;
            this.f3deleteSaleB.Location = new System.Drawing.Point(515, 314);
            this.f3deleteSaleB.Name = "f3deleteSaleB";
            this.f3deleteSaleB.Size = new System.Drawing.Size(104, 27);
            this.f3deleteSaleB.TabIndex = 14;
            this.f3deleteSaleB.Text = "Delete Sale";
            this.f3deleteSaleB.UseVisualStyleBackColor = true;
            this.f3deleteSaleB.Click += new System.EventHandler(this.f3deleteSaleB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(45, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sales Detail";
            // 
            // f3displaySaleB
            // 
            this.f3displaySaleB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f3displaySaleB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f3displaySaleB.ForeColor = System.Drawing.Color.Black;
            this.f3displaySaleB.Location = new System.Drawing.Point(305, 55);
            this.f3displaySaleB.Name = "f3displaySaleB";
            this.f3displaySaleB.Size = new System.Drawing.Size(87, 27);
            this.f3displaySaleB.TabIndex = 11;
            this.f3displaySaleB.Text = "Display Sale";
            this.f3displaySaleB.UseVisualStyleBackColor = true;
            this.f3displaySaleB.Click += new System.EventHandler(this.f3displaySaleB_Click);
            // 
            // f3salesDetail
            // 
            this.f3salesDetail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f3salesDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f3salesDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameCol,
            this.itemPriceCol,
            this.col});
            this.f3salesDetail.Location = new System.Drawing.Point(49, 165);
            this.f3salesDetail.Name = "f3salesDetail";
            this.f3salesDetail.Size = new System.Drawing.Size(343, 176);
            this.f3salesDetail.TabIndex = 10;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(45, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter Sales Id";
            // 
            // f3salesIdT
            // 
            this.f3salesIdT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f3salesIdT.Location = new System.Drawing.Point(48, 55);
            this.f3salesIdT.Multiline = true;
            this.f3salesIdT.Name = "f3salesIdT";
            this.f3salesIdT.Size = new System.Drawing.Size(259, 27);
            this.f3salesIdT.TabIndex = 0;
            this.f3salesIdT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f3salesIdT_KeyPress);
            // 
            // f3ansB
            // 
            this.f3ansB.FlatAppearance.BorderSize = 0;
            this.f3ansB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f3ansB.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f3ansB.ForeColor = System.Drawing.Color.White;
            this.f3ansB.Location = new System.Drawing.Point(0, 134);
            this.f3ansB.Name = "f3ansB";
            this.f3ansB.Size = new System.Drawing.Size(151, 65);
            this.f3ansB.TabIndex = 0;
            this.f3ansB.Text = "Add New Sale";
            this.f3ansB.UseVisualStyleBackColor = true;
            this.f3ansB.Click += new System.EventHandler(this.f3ansB_Click);
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
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Delete a Sale";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(119)))));
            this.panel1.Controls.Add(this.f3homeB);
            this.panel1.Controls.Add(this.f3dtsB);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.f3ansB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 411);
            this.panel1.TabIndex = 10;
            // 
            // f3dtsB
            // 
            this.f3dtsB.FlatAppearance.BorderSize = 0;
            this.f3dtsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f3dtsB.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f3dtsB.ForeColor = System.Drawing.Color.White;
            this.f3dtsB.Location = new System.Drawing.Point(1, 205);
            this.f3dtsB.Name = "f3dtsB";
            this.f3dtsB.Size = new System.Drawing.Size(151, 65);
            this.f3dtsB.TabIndex = 5;
            this.f3dtsB.Text = "Display Total Sales";
            this.f3dtsB.UseVisualStyleBackColor = true;
            this.f3dtsB.Click += new System.EventHandler(this.f3dtsB_Click);
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
            // f3homeB
            // 
            this.f3homeB.FlatAppearance.BorderSize = 0;
            this.f3homeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f3homeB.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f3homeB.ForeColor = System.Drawing.Color.White;
            this.f3homeB.Location = new System.Drawing.Point(0, 59);
            this.f3homeB.Name = "f3homeB";
            this.f3homeB.Size = new System.Drawing.Size(151, 65);
            this.f3homeB.TabIndex = 6;
            this.f3homeB.Text = "Home";
            this.f3homeB.UseVisualStyleBackColor = true;
            this.f3homeB.Click += new System.EventHandler(this.f3homeB_Click);
            // 
            // f3updateCB
            // 
            this.f3updateCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f3updateCB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f3updateCB.ForeColor = System.Drawing.Color.Black;
            this.f3updateCB.Location = new System.Drawing.Point(515, 165);
            this.f3updateCB.Name = "f3updateCB";
            this.f3updateCB.Size = new System.Drawing.Size(104, 27);
            this.f3updateCB.TabIndex = 20;
            this.f3updateCB.Text = "Update Customer";
            this.f3updateCB.UseVisualStyleBackColor = true;
            this.f3updateCB.Click += new System.EventHandler(this.f3updateCB_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f3salesDetail)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button f3ansB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button f3dtsB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button f3deleteSaleB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button f3displaySaleB;
        private System.Windows.Forms.DataGridView f3salesDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox f3salesIdT;
        private System.Windows.Forms.Button f3resetB;
        private System.Windows.Forms.Label f3TotalPriceL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox f3CustomerNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn col;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button f3homeB;
        private System.Windows.Forms.Button f3updateCB;
    }
}