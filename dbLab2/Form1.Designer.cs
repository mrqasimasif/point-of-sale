namespace dbLab2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.F1ansB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.F1dsB = new System.Windows.Forms.Button();
            this.F1dtsB = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.posLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.panel2.Location = new System.Drawing.Point(152, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 372);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // F1ansB
            // 
            this.F1ansB.FlatAppearance.BorderSize = 0;
            this.F1ansB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.F1ansB.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F1ansB.ForeColor = System.Drawing.Color.White;
            this.F1ansB.Location = new System.Drawing.Point(0, 59);
            this.F1ansB.Name = "F1ansB";
            this.F1ansB.Size = new System.Drawing.Size(151, 65);
            this.F1ansB.TabIndex = 0;
            this.F1ansB.Text = "Add New Sale";
            this.F1ansB.UseVisualStyleBackColor = true;
            this.F1ansB.Click += new System.EventHandler(this.F1ansB_Click);
            // 
            // panel3
            // 
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
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to Point of Sale by Muhammad Qasim";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.F1dsB);
            this.panel1.Controls.Add(this.F1dtsB);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.F1ansB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 411);
            this.panel1.TabIndex = 10;
            // 
            // F1dsB
            // 
            this.F1dsB.FlatAppearance.BorderSize = 0;
            this.F1dsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.F1dsB.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F1dsB.ForeColor = System.Drawing.Color.White;
            this.F1dsB.Location = new System.Drawing.Point(0, 124);
            this.F1dsB.Name = "F1dsB";
            this.F1dsB.Size = new System.Drawing.Size(151, 65);
            this.F1dsB.TabIndex = 6;
            this.F1dsB.Text = "Delete Sale";
            this.F1dsB.UseVisualStyleBackColor = true;
            this.F1dsB.Click += new System.EventHandler(this.F1dsB_Click);
            // 
            // F1dtsB
            // 
            this.F1dtsB.FlatAppearance.BorderSize = 0;
            this.F1dtsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.F1dtsB.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F1dtsB.ForeColor = System.Drawing.Color.White;
            this.F1dtsB.Location = new System.Drawing.Point(1, 189);
            this.F1dtsB.Name = "F1dtsB";
            this.F1dtsB.Size = new System.Drawing.Size(151, 65);
            this.F1dtsB.TabIndex = 5;
            this.F1dtsB.Text = "Display Total Sales";
            this.F1dtsB.UseVisualStyleBackColor = true;
            this.F1dtsB.Click += new System.EventHandler(this.F1dtsB_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.posLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 59);
            this.panel4.TabIndex = 1;
            // 
            // posLabel
            // 
            this.posLabel.AutoSize = true;
            this.posLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.posLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posLabel.ForeColor = System.Drawing.Color.White;
            this.posLabel.Location = new System.Drawing.Point(10, 18);
            this.posLabel.Name = "posLabel";
            this.posLabel.Size = new System.Drawing.Size(131, 24);
            this.posLabel.TabIndex = 0;
            this.posLabel.Text = "Point Of Sale";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(784, 411);
            this.panel5.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button F1ansB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button F1dsB;
        private System.Windows.Forms.Button F1dtsB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label posLabel;
        private System.Windows.Forms.Panel panel5;
    }
}

