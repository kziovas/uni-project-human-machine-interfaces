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
    public partial class Photocopy : CoffeeShop.Printer_Prices
    {
        private OleDbConnection connection = new OleDbConnection();
        public Photocopy()
        {
            InitializeComponent();
        }

        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            double price = 0;
            if (textBox2.Text != "")
            {
                price = price + Convert.ToInt32(textBox2.Text) * 0.3;
            }
            if (textBox3.Text != "")
            {
                price = price + Convert.ToInt32(textBox3.Text) * 0.1;
            }
            if (rbSmall.Checked == true)
            {
                price = price + 5;
            }
            if (rbMedium.Checked == true)
            {
                price = price + 8;
            }
            if (rdBig.Checked == true)
            {
                price = price + 12;
            }

            label16.Text = price.ToString();

            DialogResult dialog = MessageBox.Show("The total price is :" +
                        label16.Text + "\nProcceed?", "Confirm", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Orders.mdb;";
                    connection.Open();
                    label16.Text = label16.Text.Replace(",", ".");
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        
                        OleDbCommand command1 = new OleDbCommand("insert into OrderList(CustomerName,OrderDetails,Price,Status)" +
                                                "values (\"" + LoginForm.GlobalUserName + "\",\"Printing-BookBinding\"," + label16.Text + ",\"Pending\")", connection);
                        int count = command1.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show(count.ToString() + " Printing Itmes Added to your Basket!");
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
            }
            if (dialog == DialogResult.No)
            {
                MessageBox.Show("Nothing Happened!");
            }
        }
    }
}
