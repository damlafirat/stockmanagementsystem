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
    public partial class FormSales : Form
    {
        DB_StockManagementSystemEntities sms = new DB_StockManagementSystemEntities();

        public FormSales()
        {
            InitializeComponent();
        }

        private void button_sell_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBox_employee.Text) && !String.IsNullOrEmpty(comboBox_customer.Text) && !String.IsNullOrEmpty(comboBox_category.Text) && !String.IsNullOrEmpty(comboBox_product.Text) && !String.IsNullOrEmpty(comboBox_quantity.Text))
            {
                using (var context = new DB_StockManagementSystemEntities())
                {
                    var o = new Orders()
                    {
                        EmployeeID = context.Employees.Where(p => p.LastName == comboBox_employee.Text).Select(p => p.EmployeeID).FirstOrDefault(),
                        ProductID = context.Products.Where(p => p.ProductName == comboBox_product.Text).Select(p => p.ProductID).FirstOrDefault(),
                        CustomerID = context.Customers.Where(p => p.CompanyName == comboBox_customer.Text).Select(p => p.CustomerID).FirstOrDefault(),
                        UnitPrice = int.Parse(label_resultUIP.Text),
                        Quantity = int.Parse(comboBox_quantity.Text),
                        TotalAmount = int.Parse(label_resultTA.Text)
                    };

                    context.Orders.Add(o);
                    context.SaveChanges();
                }

                using (var context = new DB_StockManagementSystemEntities())
                {
                    var product = (from p in sms.Products
                                   where p.ProductName == comboBox_product.Text
                                   select p).FirstOrDefault();

                    product.UnitsInStock -= int.Parse(comboBox_quantity.Text);

                    context.SaveChanges();
                }

                DialogResult dr = MessageBox.Show("Transaction succesfull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (dr == DialogResult.OK)
                    this.Close();
            }

            else
            {
                DialogResult dr = MessageBox.Show("İnvalid input/inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dr == DialogResult.OK)
                    this.Close();
            }
        }

        private void FormSales_Load(object sender, EventArgs e)
        {
            comboBox_product.Enabled = false;
            comboBox_quantity.Enabled = false;

            label_unitInPrice.Visible = false;
            label_totalAmount.Visible = false;

            var employees = (from emp in sms.Employees
                             select emp.LastName);

            foreach (var item in employees)
            {
                comboBox_employee.Items.Add(item);
            }

            var customers = (from c in sms.Customers
                             select c.CompanyName);

            foreach (var item in customers)
            {
                comboBox_customer.Items.Add(item);
            }

            var categories = (from c in sms.Categories
                              select c.CategoryName);

            foreach (var item in categories)
            {
                comboBox_category.Items.Add(item);
            }
        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_product.Enabled = true;

            comboBox_product.Items.Clear();

            var sCategoryID = (from c in sms.Categories
                              where c.CategoryName == comboBox_category.Text
                              select c.CategoryID).FirstOrDefault();

            var products = (from p in sms.Products
                            where p.CategoryID == sCategoryID && p.UnitsInStock != 0
                            select p.ProductName);

            foreach (var item in products)
            {
                comboBox_product.Items.Add(item);
            }
        }

        private void comboBox_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_quantity.Items.Clear();

            var quantities = (from q in sms.Products
                              where q.ProductName == comboBox_product.Text
                              select q.UnitsInStock).FirstOrDefault();

            for (int i = 1; i <= quantities; i++)
            {
                comboBox_quantity.Items.Add(i.ToString());
            }

            var unitInPrice = (from q in sms.Products
                              where q.ProductName == comboBox_product.Text
                              select q.UnitPrice).FirstOrDefault();

            comboBox_quantity.Enabled = true;

            label_unitInPrice.Visible = true;

            label_resultUIP.Text = unitInPrice.ToString();
        }

        private void comboBox_quantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_totalAmount.Visible = true;

            label_resultTA.Text = (Convert.ToInt32(comboBox_quantity.Text) * Convert.ToInt32(label_resultUIP.Text)).ToString();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
