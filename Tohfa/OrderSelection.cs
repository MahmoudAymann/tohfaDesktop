using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tohfa
{
    public partial class OrderSelection : Form
    {
        public OrderSelection()
        {
            InitializeComponent();
        }

        private void buttonAddFromEmp_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["OrderForEmployee"] == null)
            {
                new OrderForProduct().Show();
            }
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["OrderForService"] == null)
            {
                new OrderForService().Show();
            }
        }
    }
}
