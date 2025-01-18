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
    public class DashboardController
    {
        private DashboardRepository _repository;

        public Dashboard GetDashboardData(DateTime startDate, DateTime endDate)
        {
            using (DbContext context = new DbContext())
            {
                _repository = new DashboardRepository(context);
                return _repository.GetDashboardData(startDate, endDate);
            }
        }
    }
}
