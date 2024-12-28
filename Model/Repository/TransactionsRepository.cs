﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            string sql = @"INSERT INTO transactions (user_id, type, date, amount, category_id, description)
                         VALUES (@user_id, @type, @date, @amount, @category_id, @description)
                         WHERE user_id = @user_id";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@user_id", transactions.UserID);
                cmd.Parameters.AddWithValue("@type", transactions.Type);
                cmd.Parameters.AddWithValue("@date", transactions.Date);
                cmd.Parameters.AddWithValue("@amount", transactions.Amount);
                cmd.Parameters.AddWithValue("@category_id", transactions.CategoryID);
                cmd.Parameters.AddWithValue("@description", transactions.Description);
                cmd.Parameters.AddWithValue("@user_id", transactions.Description);


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
                           SET user_id = @user_id, type = @type, date = @date, amount = @amount,
                               category_id = @category-id, description = @description
                           WHERE transaction_id = @transaction_id";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@user_id", transactions.UserID);
                cmd.Parameters.AddWithValue("@type", transactions.Type);
                cmd.Parameters.AddWithValue("@date", transactions.Date);
                cmd.Parameters.AddWithValue("@amount", transactions.Amount);
                cmd.Parameters.AddWithValue("@category_id", transactions.CategoryID);
                cmd.Parameters.AddWithValue("@description", transactions.Description);
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

            string sql = @"DELETE FROM transactions transaction_id = @transaction_id";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@transaction_id", transactions.TransactionID);

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

        public List<Transactions> GetTransactions()
        {
            List<Transactions> list = new List<Transactions>();

            try
            {
                string sql = @"SELECT transaction_id, user_id, type, date, amount, category_id, description FROM users";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Transactions transactions = new Transactions();
                            transactions.TransactionID = (int)dtr["transaction_id"];
                            transactions.UserID = (int)dtr["user_id"];
                            transactions.Type = transactions.GetType((string)dtr["type"]);
                            transactions.Amount = (float)dtr["amount"];
                            transactions.CategoryID = (int)dtr["category_id"];
                            transactions.Description = (string)dtr["description"];

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