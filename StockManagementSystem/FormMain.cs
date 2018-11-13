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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button_viewStock_Click(object sender, EventArgs e)
        {
            FormViewStock frmVS = new FormViewStock();
            frmVS.ShowDialog();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_viewCustomer_Click(object sender, EventArgs e)
        {
            FormViewCustomers frmVC = new FormViewCustomers();
            frmVC.ShowDialog();
        }

        private void button_viewPersonel_Click(object sender, EventArgs e)
        {
            FormViewPersonels frmVP = new FormViewPersonels();
            frmVP.ShowDialog();
        }

        private void button_productSale_Click(object sender, EventArgs e)
        {
            FormSales frmPS = new FormSales();
            frmPS.ShowDialog();
        }

        private void button_stockTransaction_Click(object sender, EventArgs e)
        {
            FormViewOrders frmVO = new FormViewOrders();
            frmVO.ShowDialog();
        }
    }
}
