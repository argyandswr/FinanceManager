using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
using PersonalFinanceManager.Model.Entity;
using PersonalFinanceManager.Controller;

namespace PersonalFinanceManager.View
{
    public partial class ReportForm : UserControl
    {
        string stringConnection = @"Data Source=.;Initial Catalog=finance_manager;Integrated Security=True;Trust Server Certificate=True";
        public ReportForm()
        {
            InitializeComponent();
            balanceCurrentBalance();
            expenseTotalExpense();

            DisplayData();
        }

        // TOTAL EXPENSE 

        public void expenseTotalExpense()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(amount) FROM transactions WHERE type = 'Expense'";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal totalCost = Convert.ToDecimal(result);

                        report_totalExpense.Text = totalCost.ToString("N");
                    }
                    else
                    {
                        report_totalExpense.Text = "0.00";
                    }
                }

            }
        }

        // Current Balance 
        public void balanceCurrentBalance()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = @"
                     SELECT 
                        (SUM(CASE WHEN type = 'Income' THEN amount ELSE 0 END) - 
                        SUM(CASE WHEN type = 'Expense' THEN amount ELSE 0 END)) AS current_balance
                     FROM transactions";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal totalCost = Convert.ToDecimal(result);

                        report_currentBalance.Text = totalCost.ToString("N");
                    }
                    else
                    {
                        report_currentBalance.Text = "0.00";
                    }
                }

            }
        }

        private void report_totalExpense_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayData()
        {
            TransactionsController controller = new TransactionsController();
            dataGridView1.DataSource = controller.DisplayData();
            dataGridView1.DefaultCellStyle.ForeColor = SystemColors.ControlText;

            // Autosize column in datagrid view
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            {
                int colw = dataGridView1.Columns[i].Width;

                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dataGridView1.Columns[i].Width = colw;
            }
        }
    }
}
