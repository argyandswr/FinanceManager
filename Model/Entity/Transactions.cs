using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PersonalFinanceManager.Model.Entity
{
    public class Transactions
    {
        public enum TransactionType
        {
            Income,
            Expense
        }

        // Get type from database (convert type from database (string) to TransactionType (Enum))
        public TransactionType GetType(string type)
        {
            if (type == "Expense")
            {
                return TransactionType.Expense;
            }
            
            return TransactionType.Income;
        }

        public int TransactionID { get; set; }
        public string TransactionName { get; set; }
        public int UserID { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public int CategoryID { get; set; }
    }
}
