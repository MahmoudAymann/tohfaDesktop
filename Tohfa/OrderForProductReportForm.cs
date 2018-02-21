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
    public partial class OrderForProductReportForm : Form
    {
        public OrderForProductReportForm()
        {
            InitializeComponent();
        }

        private void OrderForProductReportForm_Load(object sender, EventArgs e)
        {
            OrderForProductCrystalReport crystalReport1 = new OrderForProductCrystalReport();
            crystalReportViewer1.ReportSource = crystalReport1;
        }
    }
}
