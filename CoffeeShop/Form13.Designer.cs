namespace CoffeeShop
{
    partial class Basket
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Basket));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersDataSet6 = new CoffeeShop.OrdersDataSet6();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ordersDataSet5 = new CoffeeShop.OrdersDataSet5();
            this.orderListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderListTableAdapter = new CoffeeShop.OrdersDataSet5TableAdapters.OrderListTableAdapter();
            this.orderListTableAdapter1 = new CoffeeShop.OrdersDataSet6TableAdapters.OrderListTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.ConfirmBtn);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.BurlyWood;
            this.groupBox1.Location = new System.Drawing.Point(103, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 436);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 82;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 81;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 80;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(541, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderDetailsDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderListBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(518, 345);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // orderDetailsDataGridViewTextBoxColumn
            // 
            this.orderDetailsDataGridViewTextBoxColumn.DataPropertyName = "OrderDetails";
            this.orderDetailsDataGridViewTextBoxColumn.HeaderText = "OrderDetails";
            this.orderDetailsDataGridViewTextBoxColumn.MinimumWidth = 324;
            this.orderDetailsDataGridViewTextBoxColumn.Name = "orderDetailsDataGridViewTextBoxColumn";
            this.orderDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDetailsDataGridViewTextBoxColumn.Width = 324;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 70;
            // 
            // orderListBindingSource1
            // 
            this.orderListBindingSource1.DataMember = "OrderList";
            this.orderListBindingSource1.DataSource = this.ordersDataSet6;
            // 
            // ordersDataSet6
            // 
            this.ordersDataSet6.DataSetName = "OrdersDataSet6";
            this.ordersDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.ConfirmBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConfirmBtn.Location = new System.Drawing.Point(541, 277);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(194, 35);
            this.ConfirmBtn.TabIndex = 6;
            this.ConfirmBtn.Text = "Procceed Purchasing";
            this.ConfirmBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(541, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NameLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.NameLabel.Location = new System.Drawing.Point(17, 32);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(518, 345);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "<Empty>\r\n";
            // 
            // ordersDataSet5
            // 
            this.ordersDataSet5.DataSetName = "OrdersDataSet5";
            this.ordersDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderListBindingSource
            // 
            this.orderListBindingSource.DataMember = "OrderList";
            this.orderListBindingSource.DataSource = this.ordersDataSet5;
            // 
            // orderListTableAdapter
            // 
            this.orderListTableAdapter.ClearBeforeFill = true;
            // 
            // orderListTableAdapter1
            // 
            this.orderListTableAdapter1.ClearBeforeFill = true;
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(970, 612);
            this.Controls.Add(this.groupBox1);
            this.Name = "Basket";
            this.Text = "Bookworms - Customers -Basket";
            this.Load += new System.EventHandler(this.Basket_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button ConfirmBtn;
        private OrdersDataSet5 ordersDataSet5;
        private System.Windows.Forms.BindingSource orderListBindingSource;
        private OrdersDataSet5TableAdapters.OrderListTableAdapter orderListTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OrdersDataSet6 ordersDataSet6;
        private System.Windows.Forms.BindingSource orderListBindingSource1;
        private OrdersDataSet6TableAdapters.OrderListTableAdapter orderListTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
