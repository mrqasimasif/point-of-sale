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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=QASIMPC\\SQLEXPRESS;Initial Catalog=pos;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void f3ansB_Click(object sender, EventArgs e)
        {
            var addNewSale = new Form2();
            this.Hide();
            addNewSale.Show();
        }

        private void f3dtsB_Click(object sender, EventArgs e)
        {
            var displayTotalSales = new Form4();
            this.Hide();
            displayTotalSales.Show();
        }

        private void PopulateData(int salesId)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM sales_detail where sales_id = @intSalesId", con);
            cmd.Parameters.AddWithValue("@intSalesId", salesId);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            f3salesDetail.Rows.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
            {
                int intSalesId = salesId;
                string productName = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string productCost = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                

                DataGridViewRow r1 = new DataGridViewRow();
                r1.CreateCells(f3salesDetail);
                r1.Cells[0].Value = intSalesId;
                r1.Cells[1].Value = productName;
                r1.Cells[2].Value = productCost;
                f3salesDetail.Rows.Add(r1);
            }
            
        }

        private void f3displaySaleB_Click(object sender, EventArgs e)
        {
            if(f3salesIdT.TextLength > 0)
            {
                int salesId = int.Parse(f3salesIdT.Text);
                //MessageBox.Show(salesId.ToString());

                con.Open();
                string getSalesId = "Select sales_id from sales where sales_id = @inputSalesId";
                SqlCommand command = new SqlCommand(getSalesId,con);
                command.Parameters.AddWithValue("@inputSalesId", salesId);
                //int intSalesId = Convert.ToInt32(command.ExecuteScalar().ToString());

                object result = command.ExecuteScalar();
                                
                //If no sale exists
                int intMaxSalesId = 0;
                if (result == null)
                {
                    string getMaxSalesId = "select max(sales_id) from sales";
                    SqlCommand maxIdCommand = new SqlCommand(getMaxSalesId, con);
                    
                    object maxId = maxIdCommand.ExecuteScalar();
                    
                    if(maxId == null)
                    {
                        MessageBox.Show("No Sale Exists\nPlease Enter a Sale First to delete");
                        var addSale = new Form2();
                        addSale.Show();
                        this.Hide();
                    }
                    else
                    {
                        intMaxSalesId = Convert.ToInt32(maxId.ToString());
                        //intMaxSalesId = Convert.ToInt32(maxIdCommand.ExecuteScalar().ToString());
                        MessageBox.Show("This sale has been delted or modified\nOr Doesn't Exist \nEnter Sales Id between " + intMaxSalesId+ "\nExcluding this");
                    }
                }
                else
                {
                    //MessageBox.Show(result.ToString());
                    //PopulateData(Convert.ToInt32(result));
                    f3salesDetail.Rows.Clear();
                    PopulateData(salesId);
                }


                //Get Sale Total Amount
                string getTtlAm = "Select total_amount from sales where sales_id = @inputSalesId";
                SqlCommand command1 = new SqlCommand(getTtlAm, con);
                command1.Parameters.AddWithValue("@inputSalesId", salesId);
                //int intSalesId = Convert.ToInt32(command.ExecuteScalar().ToString());

                object ttlAm = command1.ExecuteScalar();

                if (result == null)
                {
                    f3TotalPriceL.Text = String.Format("{0}", 0);
                }
                else
                {
                    //MessageBox.Show(result.ToString());
                    f3TotalPriceL.Text = String.Format("{0}",ttlAm);                    
                }

                //Get Customre Name
                string getCusName = "Select customer_name from sales where sales_id = @inputSalesId";
                SqlCommand command2 = new SqlCommand(getCusName, con);
                command2.Parameters.AddWithValue("@inputSalesId", salesId);
                //int intSalesId = Convert.ToInt32(command.ExecuteScalar().ToString());

                object cusName = command2.ExecuteScalar();

                if (result == null)
                {
                    f3CustomerNT.Text = String.Format("{0}", 0);
                }
                else
                {
                    //MessageBox.Show(result.ToString());
                    f3CustomerNT.Text = String.Format("{0}", cusName);
                }

                con.Close();
            }
            
        }

        private void f3salesIdT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void f3resetB_Click(object sender, EventArgs e)
        {
            f3salesDetail.Rows.Clear();
            f3salesIdT.Clear();
            f3CustomerNT.Clear();
            f3TotalPriceL.Text = String.Format("{0}", 0);
            f3salesIdT.Focus();
        }

        private void f3deleteSaleB_Click(object sender, EventArgs e)
        {
            con.Open();
            if(f3salesIdT.TextLength > 0)
            {
                int inputSalesId = int.Parse(f3salesIdT.Text);
                string getSalesId = "Select sales_id from sales where sales_id = @inputSalesId";
                SqlCommand command = new SqlCommand(getSalesId, con);
                command.Parameters.AddWithValue("@inputSalesId", inputSalesId);
                //int intSalesId = Convert.ToInt32(command.ExecuteScalar().ToString());

                object result = command.ExecuteScalar();

                int intMaxSalesId = 0;
                if (result == null)
                {
                    string getMaxSalesId = "select max(sales_id) from sales";
                    SqlCommand maxIdCommand = new SqlCommand(getMaxSalesId, con);
                    intMaxSalesId = Convert.ToInt32(maxIdCommand.ExecuteScalar().ToString());
                    MessageBox.Show("This sale has been Delete or Modified\nNo Sale exists with this Sales Id \nEnter Sales Id between to " + intMaxSalesId + "\nExcluding this");
                }
                else
                {
                    //MessageBox.Show(result.ToString());
                    //PopulateData(Convert.ToInt32(result));

                    string deleteQuery = "delete from sales_detail where sales_id = @salesId";
                    string deleteQuery1 = "delete from sales where sales_id = @salesId";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, con);
                    SqlCommand deleteCommand1 = new SqlCommand(deleteQuery1, con);
                    deleteCommand.Parameters.AddWithValue("salesId",inputSalesId);
                    deleteCommand1.Parameters.AddWithValue("salesId", inputSalesId);

                    deleteCommand.ExecuteNonQuery();
                    deleteCommand1.ExecuteNonQuery();

                    MessageBox.Show("Sale Deleted");
                    f3resetB_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Sales Id to Delete a Sale");
            }
            
            con.Close();
            
        }

        private void f3homeB_Click(object sender, EventArgs e)
        {
            var home = new Form1();
            home.Show();
            this.Hide();
        }

        private void f3updateCB_Click(object sender, EventArgs e)
        {
            con.Open();
            if (f3salesIdT.TextLength > 0)
            {
                int inputSalesId = int.Parse(f3salesIdT.Text);
                string getSalesId = "Select sales_id from sales where sales_id = @inputSalesId";
                SqlCommand command = new SqlCommand(getSalesId, con);
                command.Parameters.AddWithValue("@inputSalesId", inputSalesId);
                //int intSalesId = Convert.ToInt32(command.ExecuteScalar().ToString());

                object result = command.ExecuteScalar();

                int intMaxSalesId = 0;
                if (result == null)
                {
                    string getMaxSalesId = "select max(sales_id) from sales";
                    SqlCommand maxIdCommand = new SqlCommand(getMaxSalesId, con);
                    intMaxSalesId = Convert.ToInt32(maxIdCommand.ExecuteScalar().ToString());
                    MessageBox.Show("This sale has been Delete or Modified\nNo Sale exists with this Sales Id \nEnter Sales Id between to " + intMaxSalesId + "\nExcluding this");
                }
                else
                {
                    //MessageBox.Show(result.ToString());
                    //PopulateData(Convert.ToInt32(result));
                    if(f3CustomerNT.TextLength>0)
                    {
                        string deleteQuery = "update sales set customer_name = @customerName where sales_id = @salesId";
                        SqlCommand deleteCommand = new SqlCommand(deleteQuery, con);
                        deleteCommand.Parameters.AddWithValue("salesId", inputSalesId);
                        deleteCommand.Parameters.AddWithValue("customerName", f3CustomerNT.Text);

                        deleteCommand.ExecuteNonQuery();

                        MessageBox.Show("Customer Updated Successfully");
                        f3resetB_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Enter a New Customer Name to update");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Sales Id to Update a Customer");
            }

            con.Close();
        }
    }
}
