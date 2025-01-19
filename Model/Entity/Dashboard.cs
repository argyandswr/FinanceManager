using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public BindingList<KeyValuePair<string, double>> ExpenseCategory { get; set; }
        public BindingList<KeyValuePair<string, double>> IncomeCategory { get; set; }
        public DateTime CurrentBudgetStartDate { get; set; }
        public DateTime CurrentBudgetEndDate { get; set; }
        public BindingList<KeyValuePair<double, double>> CurrentUsage { get; set; }
        public BindingList<KeyValuePair<string, double>> CurrentBudget {  get; set; }


        public Dashboard()
        {
            ExpenseCategory = new();
            IncomeCategory = new ();
            CurrentUsage = new();
            CurrentBudget = new();
        }
    }
}
