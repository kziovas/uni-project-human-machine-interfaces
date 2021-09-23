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
    public partial class LightBtn : UserControl
    {
        public LightBtn()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            if (btnON_OFF_Light.Text == "💡 Off")
            {
                btnON_OFF_Light.Text = "💡 On";
                btnON_OFF_Light.ForeColor = Color.BurlyWood;
                btnON_OFF_Light.BackColor = Color.SaddleBrown;
            }
            else
            {
                btnON_OFF_Light.ForeColor = Color.SaddleBrown;
                btnON_OFF_Light.BackColor = Color.BurlyWood;
                btnON_OFF_Light.Text = "💡 Off";
            }
        }
    }
}
