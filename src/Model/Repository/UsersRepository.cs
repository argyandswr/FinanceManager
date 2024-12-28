using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PersonalFinanceManager.src.Model.Context;
using PersonalFinanceManager.src.Model.Entity;

namespace PersonalFinanceManager.src.Model.Repository
{
    public class UsersRepository
    {
        private SqlConnection _conn;

        public UsersRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Users users)
        {
            int result = 0;

            string sql = @"INSERT INTO users (username, password) VALUES (@username, @password)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@username", users.Username);
                cmd.Parameters.AddWithValue("@password", users.Password);

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

        public int Update(Users users)
        {
            int result = 0;

            string sql = @"UPDATE users SET username = @username, password = @password WHERE user_id = @user_id";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@username", users.Username);
                cmd.Parameters.AddWithValue("@password", users.Password);
                cmd.Parameters.AddWithValue("@user_id", users.UserID);

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

        public int Delete(Users users)
        {
            int result = 0;

            string sql = @"DELETE FROM users WHERE user_id = @user_id";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@user_id", users.UserID);

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

        public bool IsValidUser(string username, string password)
        {
            bool result = false;

            string sql = @"SELECT COUNT (*) AS row_count FROM users
                         WHERE username = @username AND password = @password";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);

                using SqlDataReader dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    result = Convert.ToInt32(dtr["row_count"]) > 0;
                }
            }

            return result;
        }

        public bool IsUsernameAvailable(string username)
        {
            bool result = false;

            string sql = @"SELECT COUNT (*) AS row_count FROM users
                         WHERE username = @username";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("username", username);

                using SqlDataReader dtr = cmd.ExecuteReader();
                // panggil method Read untuk mendapatkan baris dari result set
                if (dtr.Read())
                {
                    result = Convert.ToInt32(dtr["row_count"]) > 0;
                }
            }

            return result;
        }

        public List<Users> ReadAll()
        {
            List<Users> list = new List<Users>();

            try
            {
                string sql = @"SELECT user_id, username, password FROM users";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Users users = new Users();
                            users.UserID = (int)dtr["user_id"];
                            users.Username = (string)dtr["username"];
                            users.Password = (string)dtr["password"];

                            list.Add(users);
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
