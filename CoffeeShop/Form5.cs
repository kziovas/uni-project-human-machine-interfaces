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
    public partial class EmployeeBaseForm : Form
    {

        public EmployeeBaseForm()
        {
            InitializeComponent();
        }
        public EmployeeBaseForm(string username)
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripMenuItem18_Click(object sender, EventArgs e)
        {
            EmployeeMusicForm EF = new EmployeeMusicForm();
            EF.Show();
            this.Close();
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeAccountForm EA = new EmployeeAccountForm();
            EA.Show();
            this.Close();
        }


        private void AirconditioningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeControlsAircon aircon = new EmployeeControlsAircon();
            aircon.Show();
            this.Close();
        }

        private void LightingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeControlsLight light = new EmployeeControlsLight();
            light.Show();
            this.Close();
        }

        private void CafeAppliancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cafeAppliancesToolStripMenuItem.Text== "⚡ Cafe Appliances-ON")
            {
                cafeAppliancesToolStripMenuItem.Text = "⚡ Cafe Appliances-OFF";
                cafeAppliancesToolStripMenuItem.ForeColor = Color.BurlyWood;
                cafeAppliancesToolStripMenuItem.BackColor = Color.SaddleBrown;
                basketToolStripMenuItem.ShowDropDown();
            }
            else
            {
                cafeAppliancesToolStripMenuItem.Text = "⚡ Cafe Appliances-ON";
                cafeAppliancesToolStripMenuItem.ForeColor = Color.SaddleBrown;
                cafeAppliancesToolStripMenuItem.BackColor = Color.BurlyWood;
                basketToolStripMenuItem.ShowDropDown();
            }
        }

        private void ToolStripMenuItem23_Click(object sender, EventArgs e)
        {
            EmployeeActiveOrders EAO = new EmployeeActiveOrders();
            EAO.Show();
            this.Close();
        }

        private void ToolStripMenuItem24_Click(object sender, EventArgs e)
        {
            EmployeeOrderHistory EOH = new EmployeeOrderHistory();
            EOH.Show();
            this.Close();
        }

        private void ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            EmployeeHomePage EHF = new EmployeeHomePage();
            EHF.Show();
            this.Close();
        }

        private void ToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            EmployeeWebsite EWF = new EmployeeWebsite();
            EWF.Show();
            this.Close();
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeBookSearch EBSF = new EmployeeBookSearch();
            EBSF.Show();
            this.Close();
        }

        private void ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "UI_Help/Emp_Help/UI_EmpHelp.chm");
        }

        private void ToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();

        }
    }
}
