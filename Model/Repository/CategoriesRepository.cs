using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PersonalFinanceManager.Model.Context;
using PersonalFinanceManager.Model.Entity;

namespace PersonalFinanceManager.Model.Repository
{
    public class CategoriesRepository
    {
        private SqlConnection _conn;

        public CategoriesRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        // Return category_id and name
        public List<Categories> GetCategories()
        {
            List<Categories> list = new List<Categories>();

            string sql = @"SELECT category_id, name FROM categories WHERE user_id = @user_id";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", CurrentUser.UserID);
                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Categories categories = new Categories();
                            categories.CategoryID = (int)dtr["category_id"];
                            categories.Name = (string)dtr["Name"];

                            list.Add(categories);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("GetCategories error: {0}", ex.Message);
            }
            
            return list;
        }
    }
}
