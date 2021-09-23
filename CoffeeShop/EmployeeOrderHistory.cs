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
    public partial class EmployeeOrderHistory : CoffeeShop.EmployeeOrdersForm
    {
        private OleDbConnection connection = new OleDbConnection();
        public EmployeeOrderHistory()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Orders.mdb;";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            OrdersData.DefaultCellStyle.ForeColor = Color.Black;
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM OrderList WHERE CustomerName LIKE '%" + textBox3.Text + "%';";
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt);
            OrdersData.DataSource = dt.Tables[0].DefaultView;
            connection.Close();
        }

        private void EmployeeOrderHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ordersDataSet2.OrderList' table. You can move, or remove it, as needed.
            this.orderListTableAdapter.Fill(this.ordersDataSet2.OrderList);
        }
    }
}
