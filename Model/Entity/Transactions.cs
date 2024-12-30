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
        public int TransactionID { get; set; }
        public string TransactionName { get; set; }
        public int UserID { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public int CategoryID { get; set; }
    }
}
