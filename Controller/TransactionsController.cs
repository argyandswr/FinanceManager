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
    public class TransactionsController
    {
        private TransactionsRepository _repository;

        public int Create(Transactions transactions)
        {
            int result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new TransactionsRepository(context);

                result = _repository.Create(transactions);
            }

            if (result > 0)
            {
                MessageBox.Show("Transaction Added Successfully", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Failed to Add Transaction!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
    }
}
