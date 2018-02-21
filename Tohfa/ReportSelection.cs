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
    public partial class ReportSelection : Form
    {
        public ReportSelection()
        {
            InitializeComponent();
        }

        private void buttonSuppliersRep_Click(object sender, EventArgs e)
        {
           
                if (Application.OpenForms["SuppliersReportForm"] == null)
            {
                new SuppliersReportForm().Show();
            }
        }

        private void buttonAgentRep_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["AgentReportForm"] == null)
            {
                new AgentReportForm().Show();
            }
        }

        private void buttonEmployeesRep_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["EmployeeReportForm"] == null)
            {
                new EmployeeReportForm().Show();
            }
        }

        private void buttonDepartmentRep_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["DepartmentReportForm"] == null)
            {
                new DepartmentReportForm().Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["OrderForProductReportForm"] == null)
            {
                new OrderForProductReportForm().Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ProductReportForm"] == null)
            {
                new ProductReportForm().Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RawMaterialReportForm"] == null)
            {
                new RawMaterialReportForm().Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["OrderForServiceReportForm"] == null)
            {
                new OrderForServiceReportForm().Show();
            }
        }
    }
}
