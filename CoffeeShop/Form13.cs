using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CoffeeShop
{
    public partial class Basket : CoffeeShop.CustomerBaseForm
    {
        private OleDbConnection connection = new OleDbConnection();
        public Basket()
        {
            InitializeComponent();

            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Orders.mdb;";
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM OrderList WHERE Status= 'Pending' and CustomerName='" + LoginForm.GlobalUserName + "'; ";
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0].DefaultView;
            connection.Close();

        }


        private void Basket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ordersDataSet6.OrderList' table. You can move, or remove it, as needed.
            this.orderListTableAdapter1.Fill(this.ordersDataSet6.OrderList);
            // TODO: This line of code loads data into the 'ordersDataSet5.OrderList' table. You can move, or remove it, as needed.
            this.orderListTableAdapter.Fill(this.ordersDataSet5.OrderList);

            /* try
             {

                 connection.Open();
                 OleDbCommand command = new OleDbCommand();
                 command.Connection = connection;
                 command.CommandText = "SELECT OrderDetail,Price FROM OrderList where Status= \"Pending\"";
                 OleDbDataAdapter da = new OleDbDataAdapter(command);
                 DataTable dt = new DataTable();
                 da.Fill(dt);
                 dataGridView1.DataSource = dt;
                 connection.Close();
             }
             catch (Exception ex)
             {

             }*/

        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE OrderList SET Status = 'Confirmed' where CustomerName='" + LoginForm.GlobalUserName + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                int count = command.ExecuteNonQuery();
                MessageBox.Show(count.ToString() + " Orders Updated!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            label1.Text = selectedRow.Cells[0].Value.ToString();
            label2.Text = selectedRow.Cells[1].Value.ToString();
            label3.Text = selectedRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Orders.mdb;";

                connection.Open();
                OleDbCommand command1 = new OleDbCommand("delete from OrderList where OrderID=" + label1.Text, connection);
                int count = command1.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(count.ToString() + " Deleted from Orders!");
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowIndex);
                //MessageBox.Show("Book Added to your Basket!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
