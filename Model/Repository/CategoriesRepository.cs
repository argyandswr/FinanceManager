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

        public int GetID(string category_name)
        {
            string sql = @"SELECT category_id FROM categories WHERE category_name = @category_name";
            int result = 0;

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("category_name", category_name);
                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            result = dtr.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("GetID error: {0}", ex.Message);
            }
            return result;
        }

        // Return category_id and name
        public List<Categories> GetCategories(string type)
        {
            List<Categories> list = new List<Categories>();

            string sql = @"SELECT category_id, category_name FROM categories WHERE user_id = @user_id AND type = @type";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", GlobalVariable.UserID);
                    cmd.Parameters.AddWithValue("@type", type);

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Categories categories = new Categories();
                            categories.CategoryID = (int)dtr["category_id"];
                            categories.Name = (string)dtr["category_name"];

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
