using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CoffeeShop
{
    public partial class LoginForm : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public static string GlobalUserName;
        public static string GlobalEmployeeName;
        public LoginForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Users.mdb;";
        }



        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            // Create a command object, give it a connection object, give it a query to update our database
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT CustomerPass FROM Customers WHERE CustomerName='"+Username.Text+"';";
            // Now simply execute it!
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt);
            if (dt.Tables[0].Rows.Count != 0)
            {
               
                string pswd = dt.Tables[0].Rows[0]["CustomerPass"].ToString();
                connection.Close();
                if (pswd == Password.Text)
                {
                    GlobalUserName = Username.Text;
                    this.Hide();
                    Home home2 = new Home();
                    home2.Show();
                   

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Wrong Password ! Try again.");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Wrong Username! Try again.");
                connection.Close();
            }

        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            // Create a command object, give it a connection object, give it a query to update our database
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT EmployeePass FROM Employees WHERE EmployeeName='" + Username.Text + "';";
            // Now simply execute it!
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt);
            if (dt.Tables[0].Rows.Count != 0)
            {

                string pswd = dt.Tables[0].Rows[0]["EmployeePass"].ToString();
                connection.Close();
                if (pswd == Password.Text)
                {
                    EmployeeHomePage EHF = new EmployeeHomePage();
                    GlobalEmployeeName = Username.Text;
                    EHF.Show();
                    this.Hide();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Wrong Password ! Try again.");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Wrong Username! Try again.");
                connection.Close();
            }



        }
    }
}
