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
    public partial class FormViewOrders : Form
    {
        public FormViewOrders()
        {
            InitializeComponent();
        }

        private void FormViewOrders_Load(object sender, EventArgs e)
        {
            DB_StockManagementSystemEntities sms = new DB_StockManagementSystemEntities();

            var list = from o in sms.Orders
                       select new { o.OrderID, o.ProductID, o.UnitPrice, o.Quantity, o.TotalAmount, o.EmployeeID, o.CustomerID };

            dataGridView_orders.DataSource = list.ToList();
        }
    }
}
