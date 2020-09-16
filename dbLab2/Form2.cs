using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace dbLab2
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=QASIMPC\\SQLEXPRESS;Initial Catalog=pos;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }

        private void f1hB_Click(object sender, EventArgs e)
        {
            var home = new Form1();
            this.Hide();
            home.Show();
            
        }

        private void f2dtsB_Click(object sender, EventArgs e)
        {
            var displayTotalSales = new Form4();
            this.Hide();
            displayTotalSales.Show();
        }
        struct salesData
        {
            public string itemNameArray { get; set; }
            public int itemPriceArray { get; set; }  
        };
        List<salesData> sd = new List<salesData>();
       
        public List<string> INA = new List<string>();
        public List<int> IPA = new List<int>();

        private void addNewSaleB_Click(object sender, EventArgs e)
        {                    
            
            if (itemName.Text.Length > 0)
            {
                string itName = itemName.Text;

                if (itemPrice.Text.Length > 0)
                {
                    //int itPrice = int.Parse(itemPrice.Text);
                    string itPrice = (itemPrice.Text);

                    INA.Add(itName);
                    IPA.Add(int.Parse(itPrice));

                    int totalSaleAmount = IPA.Sum();
                    f2TotalPriceL.Text = String.Format("{0}", totalSaleAmount);
                
                    //Struct method
                    var helperSale = new salesData();
                    helperSale.itemNameArray = itName;
                    helperSale.itemPriceArray = int.Parse(itPrice);
                    sd.Add(helperSale);

                    //salesDetail.DataSource = sd;
                    
                    /*
                    DataGridViewRow r = new DataGridViewRow();
                    r.CreateCells(salesDetail);
                    r.Cells[0].Value = itName;
                    r.Cells[1].Value = itPrice;
                    salesDetail.Rows.Add(r);*/

                    string[] row = { itName, itPrice };
                    salesDetail.Rows.Add(row);

                    itemName.Clear();
                    itemPrice.Clear();
                    itemName.Focus();

                }
                else
                {
                    MessageBox.Show("Price should be Greater than 0");
                }
            }
            else
            {
                MessageBox.Show("Plese Enter a Valid Item Name");
            }
            
        }

        private void itemPrice_Keypress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            
        }

        private void f2finishSaleB_Click(object sender, EventArgs e)
        {
            if(f2cusotmerN.TextLength >0 )
            {
                con.Open();
                int totalSaleAmount = IPA.Sum();
                string customerName = f2cusotmerN.Text;
                string query = "INSERT INTO sales(total_amount,customer_name) values(@TSA,@CN)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@TSA", totalSaleAmount);
                cmd.Parameters.AddWithValue("@CN", customerName);

                cmd.ExecuteNonQuery();

                string getSalesId = "select max(sales_id) from sales";
                SqlCommand command = new SqlCommand(getSalesId, con);
                
                //3rd Working
                              
                int intSalesId = Convert.ToInt32(command.ExecuteScalar().ToString());
                //MessageBox.Show(intSalesId.ToString());
                
                //write lists
                
                string InsertSalesDetail = "Insert into sales_detail(sales_id,product_name,product_cost) values(@SalesId,@INA, @IPA)";
                SqlCommand InsertSalesDetailQuery = new SqlCommand(InsertSalesDetail,con);

                var sqlTran = con.BeginTransaction();
                for(int i=0; i<INA.Count; ++i )
                {
                    InsertSalesDetailQuery.Transaction = sqlTran;
                    InsertSalesDetailQuery.Parameters.Clear();
                    InsertSalesDetailQuery.Parameters.AddWithValue("@SalesId", intSalesId);
                    InsertSalesDetailQuery.Parameters.AddWithValue("@INA", INA[i]);
                    InsertSalesDetailQuery.Parameters.AddWithValue("@IPA", IPA[i]);
                    InsertSalesDetailQuery.ExecuteNonQuery();

                }
                sqlTran.Commit();
                
                con.Close();
                MessageBox.Show("Sale price added");

                //Clear Window
                f2cusotmerN.Clear();
                f2TotalPriceL.Text = String.Format("{0}",0);
                salesDetail.Rows.Clear();

            }
            else
            {
                MessageBox.Show("Enter the Customer Name");
            }
        
            
        }

        private void f2deleteSaleB_Click(object sender, EventArgs e)
        {
            var home = new Form3();
            home.Show();
            this.Hide();
        }
    }
}
