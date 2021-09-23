namespace CoffeeShop
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnON_OFF1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnON_OFF1
            // 
            this.btnON_OFF1.AutoSize = true;
            this.btnON_OFF1.BackColor = System.Drawing.Color.BurlyWood;
            this.btnON_OFF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnON_OFF1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnON_OFF1.Location = new System.Drawing.Point(0, 0);
            this.btnON_OFF1.Name = "btnON_OFF1";
            this.btnON_OFF1.Size = new System.Drawing.Size(66, 25);
            this.btnON_OFF1.TabIndex = 76;
            this.btnON_OFF1.Text = "❆ Off";
            this.btnON_OFF1.Click += new System.EventHandler(this.BtnON_OFF1_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnON_OFF1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(66, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnON_OFF1;
    }
}
