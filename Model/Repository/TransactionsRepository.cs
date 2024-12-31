using System.Data;
using Microsoft.Data.SqlClient;

using PersonalFinanceManager.Model.Context;
using PersonalFinanceManager.Model.Entity;

namespace PersonalFinanceManager.Model.Repository
{
    public class TransactionsRepository
    {
        private SqlConnection _conn;

        public TransactionsRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Transactions transactions)
        {
            int result = 0;

            string sql = @"INSERT INTO transactions (user_id, transaction_name, type, date, amount, category_id)
                         VALUES (@user_id, @name, @type, @date, @amount, @category_id)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@user_id", transactions.UserID);
                cmd.Parameters.AddWithValue("@name", transactions.TransactionName);
                cmd.Parameters.AddWithValue("@type", transactions.Type);
                cmd.Parameters.AddWithValue("@date", transactions.Date);
                cmd.Parameters.AddWithValue("@amount", transactions.Amount);
                cmd.Parameters.AddWithValue("@category_id", transactions.CategoryID);


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

        public int Update(Transactions transactions)
        {
            int result = 0;

            string sql = @"UPDATE transactions
                           SET user_id = @user_id, transaction_name = @name, type = @type, date = @date, amount = @amount,
                               category_id = @category_id
                           WHERE transaction_id = @transaction_id";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@user_id", transactions.UserID);
                cmd.Parameters.AddWithValue("@name", transactions.TransactionName);
                cmd.Parameters.AddWithValue("@type", transactions.Type);
                cmd.Parameters.AddWithValue("@date", transactions.Date);
                cmd.Parameters.AddWithValue("@amount", transactions.Amount);
                cmd.Parameters.AddWithValue("@category_id", transactions.CategoryID);
                cmd.Parameters.AddWithValue("@transaction_id", transactions.TransactionID);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Delete(Transactions transactions)
        {
            int result = 0;

            string sql = @"DELETE FROM transactions WHERE transaction_id = @id";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id", transactions.TransactionID);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }
            return result;
        }

        public DataTable DisplayData()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sql = @"SELECT t.type AS Type, transaction_name AS Name, amount AS Amount, category_name AS Category, date AS Date, transaction_id AS ID
                           FROM transactions t
                           JOIN categories c ON t.category_id = c.category_id
                           WHERE t.user_id = @user_id";
            
            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("user_id", GlobalVariable.UserID);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                return dt;
            }
        }

        public List<Transactions> ReadAll()
        {
            List<Transactions> list = new List<Transactions>();

            try
            {
                string sql = @"SELECT t.transaction_id, t.user_id, t.transaction_name, t.type, t.date, t.amount, t.category_id
                               FROM transactions t
                               JOIN categories c ON t.category_id = c.category_id
                               WHERE t.user_id = @user_id";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Transactions transactions = new Transactions();
                            transactions.TransactionID = (int)dtr["transaction_id"];
                            transactions.UserID = (int)dtr["user_id"];
                            transactions.TransactionName = (string)dtr["transaction_name"];
                            transactions.Type = (string)dtr["type"];
                            transactions.Date = dtr.GetFieldValue<DateTime>(dtr.GetOrdinal("date"));
                            transactions.Amount = (float)dtr["amount"];
                            transactions.CategoryID = (int)dtr["category_id"];
                            
                            list.Add(transactions);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }
    }
}
