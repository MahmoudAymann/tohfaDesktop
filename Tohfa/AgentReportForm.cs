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
    public partial class AgentReportForm : Form
    {
        public AgentReportForm()
        {
            InitializeComponent();
        }

        private void AgentReportForm_Load(object sender, EventArgs e)
        {
            AgentCrystalReport crystalReport1 = new AgentCrystalReport();
            crystalReportViewer1.ReportSource = crystalReport1;
        }
    }
}
