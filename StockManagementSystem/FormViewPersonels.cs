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
    public partial class FormViewPersonels : Form
    {
        public FormViewPersonels()
        {
            InitializeComponent();
        }

        private void FormViewPersonels_Load(object sender, EventArgs e)
        {
            DB_StockManagementSystemEntities sms = new DB_StockManagementSystemEntities();

            var list = from emp in sms.Employees
                       select new { emp.EmployeeID, emp.Title, emp.TitleOfCourtesy, emp.FirstName, emp.LastName };

            dataGridView_personels.DataSource = list.ToList();
        }
    }
}
