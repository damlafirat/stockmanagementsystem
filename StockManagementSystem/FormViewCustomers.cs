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
    public partial class FormViewCustomers : Form
    {
        public FormViewCustomers()
        {
            InitializeComponent();
        }

        private void FormViewCustomers_Load(object sender, EventArgs e)
        {
            DB_StockManagementSystemEntities sms = new DB_StockManagementSystemEntities();

            var list = from c in sms.Customers
                       select new { c.CompanyName, c.ContactTitle, c.ContactName, c.City};

            dataGridView_customers.DataSource = list.ToList();
        }
    }
}
