namespace StockManagementSystem
{
    partial class FormViewPersonels
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
            this.dataGridView_personels = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_personels)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_personels
            // 
            this.dataGridView_personels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_personels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_personels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_personels.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_personels.Name = "dataGridView_personels";
            this.dataGridView_personels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_personels.Size = new System.Drawing.Size(584, 261);
            this.dataGridView_personels.TabIndex = 0;
            // 
            // FormViewPersonels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.dataGridView_personels);
            this.Name = "FormViewPersonels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormViewPersonels";
            this.Load += new System.EventHandler(this.FormViewPersonels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_personels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_personels;
    }
}