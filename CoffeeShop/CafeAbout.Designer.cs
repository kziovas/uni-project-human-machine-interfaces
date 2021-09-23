namespace CoffeeShop
{
    partial class CafeAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CafeAbout));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.wormHelp1 = new CoffeeShop.WormHelp();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Controls.Add(this.wormHelp1);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.BurlyWood;
            this.groupBox1.Location = new System.Drawing.Point(168, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 416);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prices";
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.NameLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.NameLabel.Location = new System.Drawing.Point(27, 48);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(452, 326);
            this.NameLabel.TabIndex = 19;
            this.NameLabel.Text = resources.GetString("NameLabel.Text");
            // 
            // wormHelp1
            // 
            this.wormHelp1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wormHelp1.BackgroundImage")));
            this.wormHelp1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wormHelp1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wormHelp1.Location = new System.Drawing.Point(450, 272);
            this.wormHelp1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.wormHelp1.Name = "wormHelp1";
            this.wormHelp1.Size = new System.Drawing.Size(159, 125);
            this.wormHelp1.TabIndex = 71;
            // 
            // CafeAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(964, 611);
            this.Controls.Add(this.groupBox1);
            this.Name = "CafeAbout";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NameLabel;
        private WormHelp wormHelp1;
    }
}
