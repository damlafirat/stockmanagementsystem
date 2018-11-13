using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class FormViewStock : Form
    {
        DB_StockManagementSystemEntities sms = new DB_StockManagementSystemEntities();

        public FormViewStock()
        {
            InitializeComponent();
        }

        private void FormViewStock_Load(object sender, EventArgs e)
        {
            comboBox_product.Enabled = false;

            var categories = (from c in sms.Categories
                              select c.CategoryName).Distinct();

            foreach (var item in categories)
            {
                comboBox_category.Items.Add(item);
            }
        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_product.Items.Clear();

            comboBox_product.Enabled = true;

            var scategoryID = (from c in sms.Categories
                               where c.CategoryName == comboBox_category.Text
                               select c.CategoryID).FirstOrDefault();

            var products = (from p in sms.Products
                            where p.CategoryID == scategoryID
                            select p.ProductName).Distinct();

            foreach (var item in products)
            {
                comboBox_product.Items.Add(item);
            }
        }

        private void comboBox_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = (from p in sms.Products
                        where p.ProductName == comboBox_product.Text
                        select new { p.ProductID, p.ProductName, p.UnitPrice, p.UnitsInStock});

            dataGridView_products.DataSource = list.ToList();
        }
    }
}
