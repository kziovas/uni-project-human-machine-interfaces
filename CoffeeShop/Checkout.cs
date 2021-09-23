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
    public partial class Checkout : CoffeeShop.CustomerBaseForm
    {
        private OleDbConnection connection = new OleDbConnection();
        public Checkout()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            Boolean FL_OK;
            FL_OK = true;

            if (FL_OK == true)
            {
                if (txtCard.Text.Length != 16)
                {
                    MessageBox.Show("Wrong Card Number!");
                    FL_OK = false;
                }
            }
            if (FL_OK == true)
            {
                if (txtCV.Text.Length != 3)
                {
                    MessageBox.Show("Wrong CV! ");
                    FL_OK = false;
                }
            }
            if (FL_OK == true)
            {
                try
                {
                    connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Orders.mdb;";
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {

                        OleDbCommand command1 = new OleDbCommand("update OrderList set status= \"Active\"  where CustomerName=\"" + LoginForm.GlobalUserName + 
                                            "\"", connection);
                        int count = command1.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show(count.ToString() + " Products Paid!");
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!" + ex);
                }
                finally
                {
                    connection.Close();
                }
                MessageBox.Show("Paid Successfully!");

            }
        }
    }
}
