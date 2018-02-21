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
    public partial class ProductReportForm : Form
    {
        public ProductReportForm()
        {
            InitializeComponent();
        }

        private void ProductReportForm_Load(object sender, EventArgs e)
        {
            ProductCrystalReport productCrystalReport = new ProductCrystalReport();
            crystalReportViewer1.ReportSource= productCrystalReport;
            
        }
    }
}
