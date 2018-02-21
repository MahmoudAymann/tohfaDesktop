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
    public partial class RawMaterialReportForm : Form
    {
        public RawMaterialReportForm()
        {
            InitializeComponent();
        }

        private void RawMaterialReportForm_Load(object sender, EventArgs e)
        {
            RawMaterialReportForm rawMaterialReportForm = new RawMaterialReportForm();
            crystalReportViewer1.ReportSource = rawMaterialReportForm;
        }
    }
}
