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
    public partial class EmployeeReportForm : Form
    {
        public EmployeeReportForm()
        {
            InitializeComponent();
        }

        private void EmployeeReportForm_Load(object sender, EventArgs e)
        {
            EmployeeCrystalReport crystalReport1 = new EmployeeCrystalReport();
            crystalReportViewer1.ReportSource = crystalReport1;
        }
    }
}
