namespace CoffeeShop
{
    partial class Photocopy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Photocopy));
            this.btnAddToBasket = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rdBig = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddToBasket
            // 
            this.btnAddToBasket.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAddToBasket.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToBasket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddToBasket.Location = new System.Drawing.Point(465, 374);
            this.btnAddToBasket.Name = "btnAddToBasket";
            this.btnAddToBasket.Size = new System.Drawing.Size(157, 35);
            this.btnAddToBasket.TabIndex = 76;
            this.btnAddToBasket.Text = "AddToBasket";
            this.btnAddToBasket.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddToBasket.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.rdBig);
            this.groupBox2.Controls.Add(this.rbMedium);
            this.groupBox2.Controls.Add(this.rbSmall);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnAddToBasket);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.BurlyWood;
            this.groupBox2.Location = new System.Drawing.Point(178, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 416);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prices";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(121, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 326);
            this.label1.TabIndex = 19;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(138, 276);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(14, 13);
            this.rbSmall.TabIndex = 77;
            this.rbSmall.TabStop = true;
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(138, 308);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(14, 13);
            this.rbMedium.TabIndex = 78;
            this.rbMedium.TabStop = true;
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rdBig
            // 
            this.rdBig.AutoSize = true;
            this.rdBig.Location = new System.Drawing.Point(138, 337);
            this.rdBig.Name = "rdBig";
            this.rdBig.Size = new System.Drawing.Size(14, 13);
            this.rdBig.TabIndex = 79;
            this.rdBig.TabStop = true;
            this.rdBig.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(472, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 36);
            this.textBox2.TabIndex = 81;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(472, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(43, 36);
            this.textBox3.TabIndex = 78;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.BurlyWood;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(540, 329);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 28);
            this.label16.TabIndex = 82;
            this.label16.Text = "Sum $";
            // 
            // Photocopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(964, 611);
            this.Controls.Add(this.groupBox2);
            this.Name = "Photocopy";
            this.Text = "Bookworms - Customers - Photocopy";
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddToBasket;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rdBig;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Label label16;
    }
}
