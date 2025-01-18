using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PersonalFinanceManager.Model.Context;
using PersonalFinanceManager.Model.Entity;

namespace PersonalFinanceManager.Model.Repository
{
    public class DashboardRepository
    {
        private SqlConnection _conn;

        public DashboardRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public Dashboard GetDashboardData(DateTime startDate, DateTime endDate)
        {
            Dashboard dashboardData = new Dashboard();

            string sql1 = @"SELECT Count(transaction_id) AS 'TotalTransactions', SUM(amount) AS 'TotalAmount' FROM transactions
                            WHERE type = @type AND date BETWEEN @startDate AND @endDate";

            string sql2 = @"SELECT c.category_name AS Category, SUM(t.amount) AS Total FROM transactions t
                            INNER JOIN categories c ON t.category_id = c.category_id
                            WHERE t.type = @type AND date BETWEEN @startDate AND @endDate
                            GROUP BY c.category_name";

            using (SqlCommand cmd = new SqlCommand(sql1, _conn))
            {
                cmd.Parameters.AddWithValue("@type", "Expense");
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                using(SqlDataReader dtr = cmd.ExecuteReader())
                {
                    if (dtr.HasRows)
                    {
                        while (dtr.Read())
                        {
                            dashboardData.TransactionsRecorded += (int)dtr["TotalTransactions"];
                            try
                            {
                                dashboardData.TotalExpenses = (double)dtr["TotalAmount"];
                            }
                            catch
                            {
                                dashboardData.TotalExpenses = 0;
                            }
                        }
                    }
                }
            }

            using (SqlCommand cmd = new SqlCommand(sql1, _conn))
            {
                cmd.Parameters.AddWithValue("@type", "Income");
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                using (SqlDataReader dtr = cmd.ExecuteReader())
                {
                    if (dtr.HasRows)
                    {
                        while (dtr.Read())
                        {
                            dashboardData.TransactionsRecorded += (int)dtr["TotalTransactions"];
                            try
                            {
                                dashboardData.TotalIncomes = (double)dtr["TotalAmount"];
                            }
                            catch
                            {
                                dashboardData.TotalIncomes = 0;
                            }
                        }
                    }
                }
            }

            using (SqlCommand cmd = new SqlCommand(sql2, _conn))
            {
                cmd.Parameters.AddWithValue("@type", "Expense");
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                using (SqlDataReader dtr = cmd.ExecuteReader())
                {
                    if (dtr.HasRows)
                    {
                        while (dtr.Read())
                        {
                            string cat = (string)dtr["Category"];
                            double total = (double)dtr["Total"];
                            try
                            {
                                dashboardData.ExpenseCategory.Add(cat, total);
                            }
                            catch
                            {

                            }
                        }
                    }
                }
            }

            using (SqlCommand cmd = new SqlCommand(sql2, _conn))
            {
                cmd.Parameters.AddWithValue("@type", "Income");
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                using (SqlDataReader dtr = cmd.ExecuteReader())
                {
                    if (dtr.HasRows)
                    {
                        while (dtr.Read())
                        {
                            string cat = (string)dtr["Category"];
                            double total = (double)dtr["Total"];
                            try
                            {
                                dashboardData.IncomeCategory.Add(cat, total);
                            }
                            catch
                            {

                            }
                        }
                    }
                }
            }
            return dashboardData;
        }
    }
}
