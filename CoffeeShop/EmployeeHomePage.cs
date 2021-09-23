using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class EmployeeHomePage : CoffeeShop.EmployeeBaseForm
    {
        public const string Caption = "Interval elapsed.  Continue running?";
        public readonly Timer timer1 = new Timer();
        public int i = 1;
        public EmployeeHomePage()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Start();
            timer1.Tick += new System.EventHandler(timer1_Tick);
            SlideShow.ImageLocation = "BookCovers/1.png";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (i > 1 && i <= 7)
            {
                // SlideShow.ImageLocation = "../images/" + i + ".jpg";
                //SlideShow.SizeMode = PictureBoxSizeMode.StretchImage;
                //MessageBox.Show("The picture is" + i);
                SlideShow.ImageLocation = "BookCovers/" + i.ToString() + ".png";
                //abel28.Text = i.ToString();
                i++;

            }
            else
            {
                i = 1;
                //label28.Text = i.ToString();
                SlideShow.ImageLocation = "BookCovers/" + i.ToString() + ".png";
                //SlideShow.ImageLocation = "../images/" + i + ".jpg";
                //SlideShow.SizeMode = PictureBoxSizeMode.StretchImage;
                i++;
            }
        }
    }
}
