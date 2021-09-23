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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void BtnON_OFF1_Click(object sender, EventArgs e)
        {

            if (btnON_OFF1.Text == "❆ Off")
            {
                btnON_OFF1.Text = "❆ On";
                btnON_OFF1.ForeColor = Color.BurlyWood;
                btnON_OFF1.BackColor = Color.SaddleBrown;
            }
            else
            {
                btnON_OFF1.ForeColor = Color.SaddleBrown;
                btnON_OFF1.BackColor = Color.BurlyWood;
                btnON_OFF1.Text = "❆ Off";
            }
        }
    }
}
