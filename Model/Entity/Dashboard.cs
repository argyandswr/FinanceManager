using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceManager.Model.Entity
{
    public class Dashboard
    {
        public int TransactionsRecorded { get; set; }
        public double TotalExpenses { get; set; }
        public double TotalIncomes { get; set; }
        public Dictionary<string, double> ExpenseCategory { get; set; }
        public Dictionary<string, double> IncomeCategory { get; set; }

        public Dashboard()
        {
            ExpenseCategory = new Dictionary<string, double>();
            IncomeCategory = new Dictionary<string, double>();
        }
    }
}
