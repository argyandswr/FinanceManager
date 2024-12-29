using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PersonalFinanceManager.Model.Context;
using PersonalFinanceManager.Model.Entity;
using PersonalFinanceManager.Model.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PersonalFinanceManager.Controller
{
    public class TransactionsController
    {
        private TransactionsRepository _repository;

        public int Create(Transactions transactions)
        {
            int result = 0;

            //if (transactions.TransactionID !> 0 )
            //{
            //    MessageBox.Show("UserID cannot be empty!", "Error",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return 0;
            //}

            //if (string.IsNullOrEmpty(transactions.Type))
            //{
            //    MessageBox.Show("Type cannot be empty!", "Warning",
            //            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return 0;
            //}

            //if (transactions.CategoryID !> 0)
            //{
            //    MessageBox.Show("Category cannot be empty!", "Warning",
            //            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return 0;
            //}

            //if (transactions.Amount !> 0)
            //{
            //    MessageBox.Show("Amount cannot be empty!", "Warning",
            //            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return 0;
            //}

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
