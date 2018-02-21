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
    public partial class SuppliersReportForm : Form
    {
        public SuppliersReportForm()
        {
            InitializeComponent();
        }

        private void SuppliersReportForm_Load(object sender, EventArgs e)
        {
            SuppliersCrystalReport crystalReport1 = new SuppliersCrystalReport();
            crystalReportViewer1.ReportSource = crystalReport1;
        }
    }
}
