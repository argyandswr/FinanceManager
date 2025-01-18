using System.Data;

using PersonalFinanceManager.Model.Context;
using PersonalFinanceManager.Model.Entity;
using PersonalFinanceManager.Model.Repository;

namespace PersonalFinanceManager.Controller
{
    public class CategoriesController
    {
        private CategoriesRepository _repository;

        public List<Categories> GetCategories(string type)
        {
            using (DbContext context = new DbContext())
            {
                _repository = new CategoriesRepository(context);
                return _repository.GetCategories(type);
            }
        }

        public DataTable GetIndexCategories(string type)
        {
            using (DbContext context = new DbContext())
            {
                _repository = new CategoriesRepository(context);
                return _repository.GetIndexCategories(type);
            }
        }

        public int Create(Categories categories)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new CategoriesRepository(context);

                result = _repository.Create(categories);
            }

            if (result > 0)
            {
                MessageBox.Show("Category Added Successfully", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Failed to Add Category!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }



        public int Update(Categories categories)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new CategoriesRepository(context);

                result = _repository.Update(categories);
            }

            if (result > 0)
            {
                MessageBox.Show("Category Updated Successfully", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Failed to Update Category!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }

        public int Delete(Categories categories)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new CategoriesRepository(context);

                result = _repository.Delete(categories);
            }

            if (result > 0)
            {
                MessageBox.Show("Category Deleted Successfully", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Failed to Delete Category!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }

        public int GetID(string category_name)
        {
            using (DbContext dbContext = new DbContext())
            {
                return _repository.GetID(category_name);
            }
        }

        public DataTable DisplayData()
        {
            using (DbContext context = new DbContext())
            {
                _repository = new CategoriesRepository(context);
                return _repository.DisplayData();
            }
        }

        public DataTable DisplayData(DateTime startDate, DateTime endDate)
        {
            using (DbContext context = new DbContext())
            {
                _repository = new CategoriesRepository(context);
                return _repository.DisplayData();
            }
        }
    }
}
