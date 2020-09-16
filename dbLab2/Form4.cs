using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbLab2
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=QASIMPC\\SQLEXPRESS;Initial Catalog=pos;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }

        private void f4ansB_Click(object sender, EventArgs e)
        {
            var addNewSale = new Form2();
            addNewSale.Show();
            this.Hide();
        }

        private void f4dsB_Click(object sender, EventArgs e)
        {
            var displayTotalSales = new Form4();
            this.Hide();
            displayTotalSales.Show();
        }

        public void PopulateData()
        {
            con.Open();
            string query = "SELECT* FROM sales INNER Join sales_detail on sales.sales_id = sales_detail.sales_id ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            int grandTotal = 0;
            f4totalSalesDetail.Rows.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
            {
                string sales_id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string total_amount = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string customer_name = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string product_name = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                string product_cost = ds.Tables[0].Rows[i].ItemArray[5].ToString();

                grandTotal += int.Parse(total_amount);
                

                DataGridViewRow r1 = new DataGridViewRow();
                r1.CreateCells(f4totalSalesDetail);
                r1.Cells[0].Value = sales_id;
                r1.Cells[1].Value = product_name;
                r1.Cells[2].Value = product_cost;
                r1.Cells[3].Value = total_amount;
                r1.Cells[4].Value = customer_name;

                f4totalSalesDetail.Rows.Add(r1);
            }
            f4grandTotalL.Text = String.Format("{0}", grandTotal);
            con.Close();
        }

        private void f4viewSaleB_Click(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void f4resetB_Click(object sender, EventArgs e)
        {
            f4totalSalesDetail.Rows.Clear();
            f4grandTotalL.Text = String.Format("{0}", 0);
        }

        private void f4homeB_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
