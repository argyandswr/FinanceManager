using System.Data;
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

        public int Create(Categories categories)
        {
            int result = 0;

            string sql = @"INSERT INTO categories (user_id, type, category_name, description)
                         VALUES (@user_id, @type, @category_name, @description)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@user_id", categories.UserID);
                cmd.Parameters.AddWithValue("@type", categories.Type);
                cmd.Parameters.AddWithValue("@category_name", categories.Name);
                cmd.Parameters.AddWithValue("@description", categories.Description);

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

        public int Update(Categories categories)
        {
            int result = 0;

            string sql = @"UPDATE categories SET user_id=@user_id, type=@type, category_name=@category_name, description=@description
                         WHERE category_id=@category_id";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@user_id", categories.UserID);
                cmd.Parameters.AddWithValue("@type", categories.Type);
                cmd.Parameters.AddWithValue("@category_name", categories.Name);
                cmd.Parameters.AddWithValue("@description", categories.Description);
                cmd.Parameters.AddWithValue("@category_id", categories.CategoryID);

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

        public int Delete(Categories categories)
        {
            int result = 0;

            string sql = @"DELETE FROM categories WHERE category_id = @category_id";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@category_id", categories.CategoryID);

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

        public DataTable DisplayData()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sql = @"SELECT type AS Type, category_name AS Name, description AS Description, category_id AS ID FROM categories WHERE user_id = @user_id";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("user_id", GlobalVariable.UserID);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                return dt;
            }
        }

        // Return category_id and name
        public List<Categories> GetCategories(string type)
        {
            List<Categories> list = new List<Categories>();

            string sql = @"SELECT category_id, category_name FROM categories WHERE user_id = @user_id AND type = @type ORDER BY category_name";

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

        // Return 
        public DataTable GetIndexCategories(string type)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sql = @"SELECT ROW_NUMBER() OVER(ORDER BY category_name) AS 'Index', category_name AS Name, category_id AS Id FROM categories WHERE user_id = @user_id AND type = @type";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@user_id", GlobalVariable.UserID);
                cmd.Parameters.AddWithValue("@type", type);

                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
