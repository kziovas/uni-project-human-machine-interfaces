using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;



namespace CoffeeShop
{
    public partial class Search_Book : CoffeeShop.CustomerBaseForm
    {
        private OleDbConnection connection = new OleDbConnection();
        public Search_Book()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb;";
            groupBox1.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
        }


        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT ID,Title,Author,Details,Price FROM Books where title like '%" + textBox3.Text + "%'";
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SearchBook.DataSource = dt;
                connection.Close();
            }
            catch(Exception ex)
            {

            }

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.database1DataSet.Books);

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            try
            {
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Orders.mdb;";
                label3.Text = label3.Text.Replace(",", ".");
                connection.Open();
                OleDbCommand command1 = new OleDbCommand("insert into OrderList(CustomerName,OrderDetails,Price,Status)" +
                                        "values (\"" + LoginForm.GlobalUserName + "\",\"" + label2.Text + "\"," + label3.Text + ",\"Pending\")", connection);
                int count = command1.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(count.ToString() + " Book Added to your Basket!");
                //MessageBox.Show("Book Added to your Basket!");
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!"+ex);
            }
            finally
            {
                connection.Close();
            }
        }

        private void SearchBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            DataGridViewRow selectedRow = SearchBook.Rows[index];
            label1.Text = selectedRow.Cells[0].Value.ToString();
            label2.Text = selectedRow.Cells[1].Value.ToString();
            label3.Text = selectedRow.Cells[4].Value.ToString();
            label1.Show();
            label2.Show();
            label3.Show();

        }
    }
}
