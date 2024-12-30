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
    }
}
