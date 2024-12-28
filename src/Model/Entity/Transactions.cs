using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceManager.Model.Entity
{
    public class Transactions
    {
        public enum TransactionType
        {
            income,
            expense
        }
        public int TransactionID { get; set; }
        public int UserID { get; set; }
        public TransactionType Type { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public Decimal CategoryID { get; set; }
        public string Description { get; set; }
    }
}
