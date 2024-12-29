using System;
using System.Collections.Generic;
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
        private CategoriesRepository _categoriesRepository;

        public List<Categories> GetCategories()
        {
            using (DbContext context = new DbContext())
            {
                _categoriesRepository = new CategoriesRepository(context);
                return _categoriesRepository.GetCategories();
            }
        }
    }
}
