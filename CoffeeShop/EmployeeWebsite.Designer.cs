namespace CoffeeShop
{
    partial class EmployeeWebsite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeWebsite));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wormHelp1 = new CoffeeShop.WormHelp();
            this.NameLabel = new System.Windows.Forms.Label();
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
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "About this Website";
            // 
            // wormHelp1
            // 
            this.wormHelp1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wormHelp1.BackgroundImage")));
            this.wormHelp1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wormHelp1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wormHelp1.Location = new System.Drawing.Point(468, 280);
            this.wormHelp1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.wormHelp1.Name = "wormHelp1";
            this.wormHelp1.Size = new System.Drawing.Size(137, 117);
            this.wormHelp1.TabIndex = 71;
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.NameLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.NameLabel.Location = new System.Drawing.Point(49, 52);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(519, 326);
            this.NameLabel.TabIndex = 19;
            this.NameLabel.Text = resources.GetString("NameLabel.Text");
            // 
            // EmployeeWebsite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(964, 611);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeWebsite";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private WormHelp wormHelp1;
        private System.Windows.Forms.Label NameLabel;
    }
}
