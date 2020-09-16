using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void F1ansB_Click(object sender, EventArgs e)
        {
            var addNewSale = new Form2();
            addNewSale.Show();
            this.Hide();
        }

        private void F1dsB_Click(object sender, EventArgs e)
        {
            var deleteSale = new Form3();
            deleteSale.Show();
            this.Hide();
        }

        private void F1dtsB_Click(object sender, EventArgs e)
        {
            var displayTotalSales = new Form4();
            displayTotalSales.Show();
            this.Hide();
        }
    }
}
