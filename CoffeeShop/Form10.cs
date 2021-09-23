using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Spire.Pdf;
using System.Drawing.Printing;

namespace CoffeeShop
{
    public partial class Printer : CoffeeShop.CustomerBaseForm
    {
        public Printer()
        {
            InitializeComponent();
            printPreviewControl1.Hide();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "All Files|*.*|Texts| *.txt; *.docx;*.pdf|Images| *.jpg; *.png ";
         
            if (fd.ShowDialog() == DialogResult.OK)
            {
                //string filenameforprint = fd.FileName;
                // MessageBox.Show(filenameforprint);
                PrintDialog dlg = new PrintDialog();
                dlg.ShowDialog();
                PdfDocument pdf = new PdfDocument();
                pdf.LoadFromFile("notes.pdf");

                this.printPreviewControl1.Rows = 1;
                this.printPreviewControl1.Columns = 2;

                pdf.Preview(this.printPreviewControl1);
                printPreviewControl1.Show();
            }
            else
            {
                MessageBox.Show("File not Loaded");
            }

        }

        
/*
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);   
        }

        Bitmap bmp; */

        private void btnPrint_Click(object sender, EventArgs e)
        {
            /*Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();*/

            MessageBox.Show("File sent to the printer successfully!");
            printPreviewControl1.Hide();

            
        }
    }
}
