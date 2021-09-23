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
    public partial class EmployeeActiveOrders : CoffeeShop.EmployeeOrdersForm
    {
        private OleDbConnection connection = new OleDbConnection();
        public EmployeeActiveOrders()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Orders.mdb;";
            OrdersData.DefaultCellStyle.ForeColor = Color.Black;
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM OrderList WHERE Status='Active';";
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt);
            OrdersData.DataSource = dt.Tables[0].DefaultView;
            connection.Close();
        }

        private void EmployeeActiveOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ordersDataSet3.OrderList' table. You can move, or remove it, as needed.
            this.orderListTableAdapter.Fill(this.ordersDataSet3.OrderList);

        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {
      
            connection.Open();
            // Create a command object, give it a connection object, give it a query to update our database
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE OrderList SET Status='Completed' WHERE OrderID="+ OrdersData.SelectedCells[0].Value.ToString() + ";";
            // Now simply execute it!
            command.ExecuteNonQuery();


            OleDbDataAdapter upd = new OleDbDataAdapter(command);
            command.CommandText = "SELECT * FROM OrderList WHERE Status='Active';";
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt);
            OrdersData.DataSource = dt.Tables[0].DefaultView;
            connection.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            connection.Open();
            // Create a command object, give it a connection object, give it a query to update our database
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE OrderList SET Status='Cancelled' WHERE OrderID=" + OrdersData.SelectedCells[0].Value.ToString() + ";";
            // Now simply execute it!
            command.ExecuteNonQuery();

            OleDbDataAdapter upd = new OleDbDataAdapter(command);
            command.CommandText = "SELECT * FROM OrderList WHERE Status='Active';";
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt);
            OrdersData.DataSource = dt.Tables[0].DefaultView;
            connection.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            // Create a command object, give it a connection object, give it a query to update our database
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string id = OrdersData.CurrentRow.Cells[0].Value.ToString();
            string name = OrdersData.CurrentRow.Cells[1].Value.ToString();
            string details = OrdersData.CurrentRow.Cells[2].Value.ToString();
            string price = OrdersData.CurrentRow.Cells[3].Value.ToString();
            string status = OrdersData.CurrentRow.Cells[4].Value.ToString();
            command.CommandText = "INSERT INTO OrderList(CustomerName,OrderDetails,Price,Status) VALUES('"+ name + "','" + details + "'," + price + ",'" + status + "'); ";
            // Now simply execute it!
            command.ExecuteNonQuery();


            OleDbDataAdapter upd = new OleDbDataAdapter(command);
            command.CommandText = "SELECT * FROM OrderList WHERE Status='Active';";
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt);
            OrdersData.DataSource = dt.Tables[0].DefaultView;
            connection.Close();
        }
    }
}
