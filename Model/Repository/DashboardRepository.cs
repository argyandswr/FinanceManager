using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            DateTime currentMonth = new DateTime(startDate.Year, startDate.Month, 1);
            DateTime currentMonthEnd = startDate.AddMonths(1).AddDays(-1);

            DateTime startDateStart = new DateTime(startDate.Year, startDate.Month, 1);
            DateTime startDateEnd = startDate.AddMonths(1).AddDays(-1);
            DateTime endDateStart = new DateTime(endDate.Year, endDate.Month, 1);
            DateTime endDateEnd = endDate.AddMonths(1).AddDays(-1);

            BindingList<KeyValuePair<string, double>> list1 = new();
            BindingList<KeyValuePair<string, double>> list2 = new();

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
                                dashboardData.ExpenseCategory.Add(new KeyValuePair<string, double>(cat, total));
                                list2.Add(new KeyValuePair<string, double>(cat, total));
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
                                dashboardData.IncomeCategory.Add(new KeyValuePair<string, double>(cat, total));
                                list2.Add(new KeyValuePair<string, double>(cat, total));
                            }
                            catch
                            {

                            }
                        }
                    }
                }
            }


            string sql3 = @"SELECT c.category_name AS Category, SUM(b.amount) AS Amount FROM budgets b
                            INNER JOIN categories c ON b.category_id = c.category_id
                            WHERE start_date BETWEEN @startDateStart AND @startDateEnd AND end_date BETWEEN @endDateStart AND @endDateEnd
                            GROUP BY c.category_name ORDER BY c.category_name";

            using (SqlCommand cmd = new SqlCommand(sql3, _conn))
            {
                cmd.Parameters.AddWithValue("@startDateStart", startDateStart);
                cmd.Parameters.AddWithValue("@startDateEnd", startDateEnd);
                cmd.Parameters.AddWithValue("@endDateStart", endDateStart);
                cmd.Parameters.AddWithValue("@endDateEnd", endDateEnd);

                using (SqlDataReader dtr = cmd.ExecuteReader())
                {
                    if (dtr.HasRows)
                    {
                        while (dtr.Read())
                        {
                            string cat = (string)dtr["Category"];
                            double amount = (double)dtr["Amount"];
                            dashboardData.CurrentBudget.Add(new KeyValuePair<string, double>(cat, amount));
                            list1.Add(new KeyValuePair<string, double>(cat, amount));
                        }
                    }
                }
            }

            BindingList<KeyValuePair<string, double>> matchedList = RemoveNonMatchKey(list2, list1);

            // Compare each item in both lists
            for (int i = 0; i < matchedList.Count; i++)
            {
                var item1 = dashboardData.CurrentBudget[i];
                var item2 = matchedList[i];

                // Compare both the Key of each pair
                if (item1.Key != item2.Key)
                {
                    dashboardData.CurrentUsage.Add(new KeyValuePair<double, double>(item1.Value, item2.Value));
                }
            }

            return dashboardData;
        }

        public static BindingList<KeyValuePair<string, double>> RemoveNonMatchKey(
        BindingList<KeyValuePair<string, double>> list1,
        BindingList<KeyValuePair<string, double>> list2)
        {
            // Create a list of keys from list1
            var keysInList1 = list1.Select(item => item.Key).ToList();

            // Remove items from list2 that do not exist in list1
            var updatedList = list2
                .Where(item => keysInList1.Contains(item.Key))
                .ToList();

            // Clear the original list2 and add the updated items back
            list2.Clear();
            foreach (var item in updatedList)
            {
                list2.Add(item);
            }

            return list2;
        }
    }
}
