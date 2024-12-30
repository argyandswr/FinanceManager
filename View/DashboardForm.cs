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
    public partial class DashboardForm : UserControl
    {
        string stringConnection = @"Data Source=.;Initial Catalog=finance_manager;Integrated Security=True;Trust Server Certificate=True";
        public DashboardForm()
        {
            InitializeComponent();

            incomeTodayIncome();

            incomeWeekIncome();

            incomeMonthlyIncome();

            expenseTodayExpense();

            expenseWeeklyExpense();

            expenseMonthlyExpense();

            expenseTotalExpense();

            balanceCurrentBalance();
        }

        //INCOME
        public void incomeTodayIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(amount) FROM transactions WHERE type = 'Income' AND CAST(date AS DATE) = @date_today";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_today", today);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);

                        dashboard_todayIncome.Text = todayCost.ToString("N");
                    }
                    else
                    {
                        dashboard_todayIncome.Text = "0.00";
                    }
                }

            }
        }

        public void incomeWeekIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(amount) FROM transactions WHERE type = 'Income' AND DATEPART(week, date) = DATEPART(week, @date_today) AND YEAR(date) = YEAR(@date_today)";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_today", today);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal weeklyCost = Convert.ToDecimal(result);

                        dashboard_weeklyIncome.Text = weeklyCost.ToString("N");
                    }
                    else
                    {
                        dashboard_weeklyIncome.Text = "0.00";
                    }
                }

            }
        }

        public void incomeMonthlyIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(amount) FROM transactions WHERE type = 'Income' AND MONTH(date) = MONTH(@date_today) AND YEAR(date) = YEAR(@date_today)";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_today", today);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal monthlyCost = Convert.ToDecimal(result);

                        dashboard_monthlyIncome.Text = monthlyCost.ToString("N");
                    }
                    else
                    {
                        dashboard_monthlyIncome.Text = "0.00";
                    }
                }

            }
        }

        // EXPENSE

        public void expenseTodayExpense()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(amount) FROM transactions WHERE type = 'Expense' AND CAST(date AS DATE) = @date_today";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_today", today);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);

                        dashboard_todayExpense.Text = todayCost.ToString("N");
                    }
                    else
                    {
                        dashboard_todayExpense.Text = "0.00";
                    }
                }

            }
        }

        public void expenseWeeklyExpense ()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(amount) FROM transactions WHERE type = 'Expense' AND DATEPART(week, date) = DATEPART(week, @date_today) AND YEAR(date) = YEAR(@date_today)";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_today", today);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal weeklyCost = Convert.ToDecimal(result);

                        dashboard_weeklyExpense.Text = weeklyCost.ToString("N");
                    }
                    else
                    {
                        dashboard_weeklyExpense.Text = "0.00";
                    }
                }

            }
        }

        public void expenseMonthlyExpense()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(amount) FROM transactions WHERE type = 'Expense' AND MONTH(date) = MONTH(@date_today) AND YEAR(date) = YEAR(@date_today)";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_today", today);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal monthlyCost = Convert.ToDecimal(result);

                        dashboard_monthlyExpense.Text = monthlyCost.ToString("N");
                    }
                    else
                    {
                        dashboard_monthlyExpense.Text = "0.00";
                    }
                }

            }
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

                        dashboard_totalExpense.Text = totalCost.ToString("N");
                    }
                    else
                    {
                        dashboard_totalExpense.Text = "0.00";
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

                        dashboard_currentBalance.Text = totalCost.ToString("N");
                    }
                    else
                    {
                        dashboard_currentBalance.Text = "0.00";
                    }
                }

            }
        }


        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
