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
    public partial class Coffee : CoffeeShop.CustomerBaseForm
    {
        private OleDbConnection connection = new OleDbConnection();
        public Coffee()
        {
            InitializeComponent();
            Control mycontrol = new Control();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            {
                listBox1.Items.Add(checkedListBox1.CheckedIndices[i]);
                //double d = double.Parse(lbl[checkedListBox1.CheckedIndices[i]].Text);
            }
            double price = 0;

            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                double d = double.Parse(lbl0.Text);
                price = price + d;
            }
            if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                double d = double.Parse(lbl1.Text);
                price = price + d;
            }
            if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked)
            {
                double d = double.Parse(lbl2.Text);
                price = price + d;
            }
            if (checkedListBox1.GetItemCheckState(3) == CheckState.Checked)
            {
                double d = double.Parse(lbl3.Text);
                price = price + d;
            }
            if (checkedListBox1.GetItemCheckState(4) == CheckState.Checked)
            {
                double d = double.Parse(lbl4.Text);
                price = price + d;
            }
            if (checkedListBox1.GetItemCheckState(5) == CheckState.Checked)
            {
                double d = double.Parse(lbl5.Text);
                price = price + d;
            }
            if (checkedListBox1.GetItemCheckState(6) == CheckState.Checked)
            {
                double d = double.Parse(lbl6.Text);
                price = price + d;
            }
            if (checkedListBox1.GetItemCheckState(7) == CheckState.Checked)
            {
                double d = double.Parse(lbl7.Text);
                price = price + d;
            }
            if (checkedListBox1.GetItemCheckState(8) == CheckState.Checked)
            {
                double d = double.Parse(lbl8.Text);
                price = price + d;
            }
            if (checkedListBox1.GetItemCheckState(9) == CheckState.Checked)
            {
                double d = double.Parse(lbl9.Text);
                price = price + d;
            }
            if (checkedListBox1.GetItemCheckState(10) == CheckState.Checked)
            {
                double d = double.Parse(lbl10.Text);
                price = price + d;
            }
            if (checkedListBox1.GetItemCheckState(11) == CheckState.Checked)
            {
                double d = double.Parse(lbl11.Text);
                price = price + d;
            }
            price = price * 0.01;

            lblsum.Text = price.ToString();
            lblsum.Text = lblsum.Text.Replace(",", ".");

            DialogResult dialog = MessageBox.Show("The total price is :" +
                        lblsum.Text + "\nProcceed?", "Confirm", MessageBoxButtons.YesNo);

             if (dialog == DialogResult.Yes)
             {
                 try
                 {
                     connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Orders.mdb;";
                     connection.Open();
                     if (connection.State == System.Data.ConnectionState.Open)
                     {
                         
                         OleDbCommand command1 = new OleDbCommand("insert into OrderList(CustomerName,OrderDetails,Price,Status)" +
                                                 "values (\"" + LoginForm.GlobalUserName + "\",\"Drinks\"," + lblsum.Text + ",\"Pending\")", connection);
                         int count = command1.ExecuteNonQuery();
                         connection.Close();
                         MessageBox.Show(count.ToString() + "Drinks Added to your Basket!");
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

        private void Coffee_Load(object sender, EventArgs e)
        {
            /*
            Label[] lbl = new Label[12];
            lbl[0] = lbl0;
            lbl[1] = lbl1;
            lbl[2] = lbl2;
            lbl[3] = lbl3;
            lbl[4] = lbl4;
            lbl[5] = lbl5;
            lbl[6] = lbl6;
            lbl[7] = lbl7;
            lbl[8] = lbl8;
            lbl[9] = lbl9;
            lbl[10] = lbl10;
            lbl[11] = lbl11;
            */
        }
    }
}
