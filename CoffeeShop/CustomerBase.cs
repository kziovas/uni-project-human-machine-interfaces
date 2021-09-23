using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class CustomerBaseForm : Form
    {
        public CustomerBaseForm()
        {
            InitializeComponent();
            myAccountToolStripMenuItem.Text = LoginForm.GlobalUserName;
        }

        private void BasketToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            checkout.Show();
            this.Close();
        }

        private void ToolStripMenuItem18_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Search_Book book = new Search_Book();
            book.Show();
            this.Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Coffee coffee = new Coffee();
            coffee.Show();
            this.Close();
        }

        private void pricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Printer_Prices prices = new Printer_Prices();
            prices.Show();
            this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Printer printer = new Printer();
            printer.Show();
            this.Close();
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Basket basket = new Basket();
            basket.Show();
            this.Close();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Show();
            this.Close();
        }

        private void photocopierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Photocopy photocopy = new Photocopy();
            photocopy.Show();
            this.Close();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            Website website = new Website();
            website.Show();
            this.Close();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            CafeAbout cafe = new CafeAbout();
            cafe.Show();
            this.Close();
        }

        private void ToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "UI_Help/Cust_Help/UI_CustHelp.chm");
        }
    }
}
