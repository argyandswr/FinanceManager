using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalFinanceManager.Controller;

namespace PersonalFinanceManager.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = true;
            budgetingForm1.Visible = false;
            reportForm1.Visible = false;
            transactionForm1.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            budgetingForm1.Visible = true;
            reportForm1.Visible = false;
            transactionForm1.Visible = false;
        }

        private void LogOut_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loginForm logForm = new loginForm();
                logForm.Show();

                this.Hide();
            }

        }

        private void Transaction_Btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            budgetingForm1.Visible = false;
            reportForm1.Visible = false;
            transactionForm1.Visible = true;
        }

        private void Report_Btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            budgetingForm1.Visible = false;
            reportForm1.Visible = true;
            transactionForm1.Visible = false;
        }
    }
}
