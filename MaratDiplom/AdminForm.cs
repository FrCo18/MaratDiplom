using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaratDiplom
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            ServicesForm servicesForm = new ServicesForm();
            servicesForm.Show();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }

        private void ordersForMeBtn_Click(object sender, EventArgs e)
        {
            OrdersWorkersForm ordersWorkersForm = new OrdersWorkersForm();
            ordersWorkersForm.Show();
        }
    }
}
