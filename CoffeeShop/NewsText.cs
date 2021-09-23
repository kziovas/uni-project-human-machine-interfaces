using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class NewsText : UserControl
    {
        public NewsText()
        {
            InitializeComponent();
        }

        private void NewsText_MouseEnter(object sender, EventArgs e)
        {
                linkLabel2.LinkColor = Color.FloralWhite;
        }

        private void NewsText_MouseLeave(object sender, EventArgs e)
        {
            linkLabel2.LinkColor = Color.SaddleBrown;
        }
    }
}
