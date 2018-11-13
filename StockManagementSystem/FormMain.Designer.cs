namespace StockManagementSystem
{
    partial class FormMain
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
            this.button_exit = new System.Windows.Forms.Button();
            this.button_viewCustomer = new System.Windows.Forms.Button();
            this.button_viewPersonel = new System.Windows.Forms.Button();
            this.button_productSale = new System.Windows.Forms.Button();
            this.button_viewOrders = new System.Windows.Forms.Button();
            this.button_viewStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_exit.Location = new System.Drawing.Point(40, 375);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(150, 60);
            this.button_exit.TabIndex = 11;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_viewCustomer
            // 
            this.button_viewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_viewCustomer.Location = new System.Drawing.Point(40, 305);
            this.button_viewCustomer.Name = "button_viewCustomer";
            this.button_viewCustomer.Size = new System.Drawing.Size(150, 60);
            this.button_viewCustomer.TabIndex = 10;
            this.button_viewCustomer.Text = "View Customer Details";
            this.button_viewCustomer.UseVisualStyleBackColor = true;
            this.button_viewCustomer.Click += new System.EventHandler(this.button_viewCustomer_Click);
            // 
            // button_viewPersonel
            // 
            this.button_viewPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_viewPersonel.Location = new System.Drawing.Point(40, 235);
            this.button_viewPersonel.Name = "button_viewPersonel";
            this.button_viewPersonel.Size = new System.Drawing.Size(150, 60);
            this.button_viewPersonel.TabIndex = 9;
            this.button_viewPersonel.Text = "View Personel Details";
            this.button_viewPersonel.UseVisualStyleBackColor = true;
            this.button_viewPersonel.Click += new System.EventHandler(this.button_viewPersonel_Click);
            // 
            // button_productSale
            // 
            this.button_productSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_productSale.Location = new System.Drawing.Point(40, 165);
            this.button_productSale.Name = "button_productSale";
            this.button_productSale.Size = new System.Drawing.Size(150, 60);
            this.button_productSale.TabIndex = 8;
            this.button_productSale.Text = "Product Sale";
            this.button_productSale.UseVisualStyleBackColor = true;
            this.button_productSale.Click += new System.EventHandler(this.button_productSale_Click);
            // 
            // button_viewOrders
            // 
            this.button_viewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_viewOrders.Location = new System.Drawing.Point(40, 95);
            this.button_viewOrders.Name = "button_viewOrders";
            this.button_viewOrders.Size = new System.Drawing.Size(150, 60);
            this.button_viewOrders.TabIndex = 7;
            this.button_viewOrders.Text = "View Orders Detail";
            this.button_viewOrders.UseVisualStyleBackColor = true;
            this.button_viewOrders.Click += new System.EventHandler(this.button_stockTransaction_Click);
            // 
            // button_viewStock
            // 
            this.button_viewStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_viewStock.Location = new System.Drawing.Point(40, 25);
            this.button_viewStock.Name = "button_viewStock";
            this.button_viewStock.Size = new System.Drawing.Size(150, 60);
            this.button_viewStock.TabIndex = 6;
            this.button_viewStock.Text = "View Stock";
            this.button_viewStock.UseVisualStyleBackColor = true;
            this.button_viewStock.Click += new System.EventHandler(this.button_viewStock_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 505);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_viewCustomer);
            this.Controls.Add(this.button_viewPersonel);
            this.Controls.Add(this.button_productSale);
            this.Controls.Add(this.button_viewOrders);
            this.Controls.Add(this.button_viewStock);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_viewCustomer;
        private System.Windows.Forms.Button button_viewPersonel;
        private System.Windows.Forms.Button button_productSale;
        private System.Windows.Forms.Button button_viewOrders;
        private System.Windows.Forms.Button button_viewStock;
    }
}

