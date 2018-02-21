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
    public partial class MainForm : Form
    {
        int panelWidth; //panel width
        bool hided;
        public MainForm()
        {
            InitializeComponent();
            sPanel.Width = 0;
            panelWidth = 200;
            hided = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hided)
                buttonSlide.Text = "H\nI\nD\nE";
            else buttonSlide.Text = "S\nH\nO\nW";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hided)
            {
                sPanel.Width = sPanel.Width + 50;
                if (sPanel.Width >= panelWidth)
                {
                    timer1.Stop();
                    hided = false;
                    Refresh();
                }
            }
            else
            {
                sPanel.Width = sPanel.Width - 40;
                if (sPanel.Width <= 0)
                {
                    timer1.Stop();
                    hided = true;
                    Refresh();
                }
            }
        }//end timer_tick

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = true;
        }

        private void buttonDepartment_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Department"] == null)
            {
                new Department().Show();
            }
        }

        private void buttonAgents_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Agents"] == null)
            {
                new Agents().Show();
            }
        }

        private void buttonSuppliers_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Suppliers"] == null)
            {
                new Suppliers().Show();
            }
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Employees"] == null)
            {
                new Employees().Show();
            }
        }

        private void buttonRaw_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RawMaterials"] == null)
            {
                new RawMaterials().Show();
            }
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Products"] == null)
            {
                new Products().Show();
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["OrderSelection"] == null)
            {
                new OrderSelection().Show();
            }
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ReportSelection"] == null)
            {
                new ReportSelection().Show();
            }
        }

        private void ToolStripMenuItemCurrency_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CurrencyConfig"] == null)
            {
                new CurrencyConfig().Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.tohfa.net");
        }
        
    }//end class
}//end namespace