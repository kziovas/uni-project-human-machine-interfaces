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
        }
        public CustomerBaseForm(string username)
        {
            InitializeComponent();
        }

        private void BasketToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem18_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Search_Book book = new Search_Book();
            book.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Coffee coffee = new Coffee();
            coffee.Show();
        }

        private void pricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Printer_Prices prices = new Printer_Prices();
            prices.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Printer printer = new Printer();
            printer.Show();
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Basket basket = new Basket();
            basket.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Show();
        }

        private void photocopierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Photocopy photocopy = new Photocopy();
            photocopy.Show();
        }
    }
}
