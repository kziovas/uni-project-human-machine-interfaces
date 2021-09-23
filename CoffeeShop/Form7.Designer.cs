namespace CoffeeShop
{
    partial class EmployeeMusicForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MusicBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // MusicBrowser
            // 
            this.MusicBrowser.Location = new System.Drawing.Point(0, 42);
            this.MusicBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.MusicBrowser.Name = "MusicBrowser";
            this.MusicBrowser.Size = new System.Drawing.Size(964, 510);
            this.MusicBrowser.TabIndex = 18;
            this.MusicBrowser.Url = new System.Uri("https://www.youtube.com/watch?v=raRqgKqIM3M", System.UriKind.Absolute);
            // 
            // EmployeeMusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(964, 611);
            this.Controls.Add(this.MusicBrowser);
            this.Name = "EmployeeMusicForm";
            this.Text = "Bookworms-Employee-Control-Music";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.Controls.SetChildIndex(this.MusicBrowser, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser MusicBrowser;
    }
}
