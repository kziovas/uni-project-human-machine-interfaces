namespace CoffeeShop
{
    partial class LightBtn
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
            this.btnON_OFF_Light = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnON_OFF_Light
            // 
            this.btnON_OFF_Light.AutoSize = true;
            this.btnON_OFF_Light.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnON_OFF_Light.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnON_OFF_Light.Location = new System.Drawing.Point(0, 0);
            this.btnON_OFF_Light.Name = "btnON_OFF_Light";
            this.btnON_OFF_Light.Size = new System.Drawing.Size(67, 25);
            this.btnON_OFF_Light.TabIndex = 80;
            this.btnON_OFF_Light.Text = "💡 Off";
            this.btnON_OFF_Light.Click += new System.EventHandler(this.Label1_Click);
            // 
            // LightBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.Controls.Add(this.btnON_OFF_Light);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Name = "LightBtn";
            this.Size = new System.Drawing.Size(67, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnON_OFF_Light;
    }
}
