namespace StockManagementSystem
{
    partial class FormSales
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_sell = new System.Windows.Forms.Button();
            this.label_totalAmount = new System.Windows.Forms.Label();
            this.label_resultUIP = new System.Windows.Forms.Label();
            this.label_unitInPrice = new System.Windows.Forms.Label();
            this.comboBox_quantity = new System.Windows.Forms.ComboBox();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.comboBox_customer = new System.Windows.Forms.ComboBox();
            this.label_customer = new System.Windows.Forms.Label();
            this.comboBox_employee = new System.Windows.Forms.ComboBox();
            this.label_employee = new System.Windows.Forms.Label();
            this.comboBox_product = new System.Windows.Forms.ComboBox();
            this.label_product = new System.Windows.Forms.Label();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label_category = new System.Windows.Forms.Label();
            this.label_resultTA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(214, 180);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 34;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_sell
            // 
            this.button_sell.Location = new System.Drawing.Point(116, 180);
            this.button_sell.Name = "button_sell";
            this.button_sell.Size = new System.Drawing.Size(75, 23);
            this.button_sell.TabIndex = 33;
            this.button_sell.Text = "Sell";
            this.button_sell.UseVisualStyleBackColor = true;
            this.button_sell.Click += new System.EventHandler(this.button_sell_Click);
            // 
            // label_totalAmount
            // 
            this.label_totalAmount.AutoSize = true;
            this.label_totalAmount.Location = new System.Drawing.Point(220, 143);
            this.label_totalAmount.Name = "label_totalAmount";
            this.label_totalAmount.Size = new System.Drawing.Size(76, 13);
            this.label_totalAmount.TabIndex = 32;
            this.label_totalAmount.Text = "Total Amount :";
            // 
            // label_resultUIP
            // 
            this.label_resultUIP.AutoSize = true;
            this.label_resultUIP.Location = new System.Drawing.Point(310, 113);
            this.label_resultUIP.Name = "label_resultUIP";
            this.label_resultUIP.Size = new System.Drawing.Size(0, 13);
            this.label_resultUIP.TabIndex = 31;
            // 
            // label_unitInPrice
            // 
            this.label_unitInPrice.AutoSize = true;
            this.label_unitInPrice.Location = new System.Drawing.Point(220, 113);
            this.label_unitInPrice.Name = "label_unitInPrice";
            this.label_unitInPrice.Size = new System.Drawing.Size(70, 13);
            this.label_unitInPrice.TabIndex = 30;
            this.label_unitInPrice.Text = "Unit in Price :";
            // 
            // comboBox_quantity
            // 
            this.comboBox_quantity.FormattingEnabled = true;
            this.comboBox_quantity.Location = new System.Drawing.Point(70, 143);
            this.comboBox_quantity.Name = "comboBox_quantity";
            this.comboBox_quantity.Size = new System.Drawing.Size(121, 21);
            this.comboBox_quantity.TabIndex = 29;
            this.comboBox_quantity.SelectedIndexChanged += new System.EventHandler(this.comboBox_quantity_SelectedIndexChanged);
            // 
            // label_Quantity
            // 
            this.label_Quantity.AutoSize = true;
            this.label_Quantity.Location = new System.Drawing.Point(15, 143);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(46, 13);
            this.label_Quantity.TabIndex = 28;
            this.label_Quantity.Text = "Quantity";
            // 
            // comboBox_customer
            // 
            this.comboBox_customer.FormattingEnabled = true;
            this.comboBox_customer.Location = new System.Drawing.Point(70, 53);
            this.comboBox_customer.Name = "comboBox_customer";
            this.comboBox_customer.Size = new System.Drawing.Size(121, 21);
            this.comboBox_customer.TabIndex = 27;
            // 
            // label_customer
            // 
            this.label_customer.AutoSize = true;
            this.label_customer.Location = new System.Drawing.Point(15, 53);
            this.label_customer.Name = "label_customer";
            this.label_customer.Size = new System.Drawing.Size(51, 13);
            this.label_customer.TabIndex = 26;
            this.label_customer.Text = "Customer";
            // 
            // comboBox_employee
            // 
            this.comboBox_employee.FormattingEnabled = true;
            this.comboBox_employee.Location = new System.Drawing.Point(70, 18);
            this.comboBox_employee.Name = "comboBox_employee";
            this.comboBox_employee.Size = new System.Drawing.Size(121, 21);
            this.comboBox_employee.TabIndex = 25;
            // 
            // label_employee
            // 
            this.label_employee.AutoSize = true;
            this.label_employee.Location = new System.Drawing.Point(15, 23);
            this.label_employee.Name = "label_employee";
            this.label_employee.Size = new System.Drawing.Size(53, 13);
            this.label_employee.TabIndex = 24;
            this.label_employee.Text = "Employee";
            // 
            // comboBox_product
            // 
            this.comboBox_product.FormattingEnabled = true;
            this.comboBox_product.Location = new System.Drawing.Point(70, 113);
            this.comboBox_product.Name = "comboBox_product";
            this.comboBox_product.Size = new System.Drawing.Size(121, 21);
            this.comboBox_product.TabIndex = 23;
            this.comboBox_product.SelectedIndexChanged += new System.EventHandler(this.comboBox_product_SelectedIndexChanged);
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Location = new System.Drawing.Point(15, 113);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(44, 13);
            this.label_product.TabIndex = 22;
            this.label_product.Text = "Product";
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(70, 83);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(121, 21);
            this.comboBox_category.TabIndex = 21;
            this.comboBox_category.SelectedIndexChanged += new System.EventHandler(this.comboBox_category_SelectedIndexChanged);
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Location = new System.Drawing.Point(15, 83);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(52, 13);
            this.label_category.TabIndex = 20;
            this.label_category.Text = "Category ";
            // 
            // label_resultTA
            // 
            this.label_resultTA.AutoSize = true;
            this.label_resultTA.Location = new System.Drawing.Point(310, 143);
            this.label_resultTA.Name = "label_resultTA";
            this.label_resultTA.Size = new System.Drawing.Size(0, 13);
            this.label_resultTA.TabIndex = 35;
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.label_resultTA);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_sell);
            this.Controls.Add(this.label_totalAmount);
            this.Controls.Add(this.label_resultUIP);
            this.Controls.Add(this.label_unitInPrice);
            this.Controls.Add(this.comboBox_quantity);
            this.Controls.Add(this.label_Quantity);
            this.Controls.Add(this.comboBox_customer);
            this.Controls.Add(this.label_customer);
            this.Controls.Add(this.comboBox_employee);
            this.Controls.Add(this.label_employee);
            this.Controls.Add(this.comboBox_product);
            this.Controls.Add(this.label_product);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.label_category);
            this.Name = "FormSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSales";
            this.Load += new System.EventHandler(this.FormSales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_sell;
        private System.Windows.Forms.Label label_totalAmount;
        private System.Windows.Forms.Label label_resultUIP;
        private System.Windows.Forms.Label label_unitInPrice;
        private System.Windows.Forms.ComboBox comboBox_quantity;
        private System.Windows.Forms.Label label_Quantity;
        private System.Windows.Forms.ComboBox comboBox_customer;
        private System.Windows.Forms.Label label_customer;
        private System.Windows.Forms.ComboBox comboBox_employee;
        private System.Windows.Forms.Label label_employee;
        private System.Windows.Forms.ComboBox comboBox_product;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.Label label_resultTA;
    }
}