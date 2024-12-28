using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PersonalFinanceManager.Model.Context;
using PersonalFinanceManager.Model.Entity;

namespace PersonalFinanceManager.Model.Repository
{
    public class BudgetsRepository
    {
        private SqlConnection _conn;

        public BudgetsRepository(DbContext context)
        {
            _conn = context.Conn;
        }
        public int Create(Budgets budgets)
        {
            int result = 0;

            string sql = @"INSERT INTO budgets (user_id, category_id, amount, start_date, end_date)
                           VALUES (@user_id, @category_id, @amount, @start_date, @end_date)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@user_id", budgets.UserID);
                cmd.Parameters.AddWithValue("@category_id", budgets.CategoryID);
                cmd.Parameters.AddWithValue("@amount", budgets.Amount);
                cmd.Parameters.AddWithValue("@start_date", budgets.StartDate);
                cmd.Parameters.AddWithValue("@end_date", budgets.EndDate);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Update(Budgets budgets)
        {
            int result = 0;

            string sql = @"UPDATE user_id
                           SET = @user_id, category_id = @category_id, amount = @amount, start_date = @start_date, end_date = @end_date)
                           WHERE budget_id = budget_id";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@user_id", budgets.UserID);
                cmd.Parameters.AddWithValue("@category_id", budgets.CategoryID);
                cmd.Parameters.AddWithValue("@amount", budgets.Amount);
                cmd.Parameters.AddWithValue("@start_date", budgets.StartDate);
                cmd.Parameters.AddWithValue("@end_date", budgets.EndDate);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Delete(Budgets budgets)
        {
            int result = 0;

            string sql = @"INSERT INTO budgets user_id = @user_id, category_id = @category_id, amount = @amount, start_date = @start_date, end_date = @end_date)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@user_id", budgets.UserID);
                cmd.Parameters.AddWithValue("@category_id", budgets.CategoryID);
                cmd.Parameters.AddWithValue("@amount", budgets.Amount);
                cmd.Parameters.AddWithValue("@start_date", budgets.StartDate);
                cmd.Parameters.AddWithValue("@end_date", budgets.EndDate);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }
    }
}
