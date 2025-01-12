using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
