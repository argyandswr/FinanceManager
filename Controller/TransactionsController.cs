using System.Data;

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

        public int Update(Transactions transactions)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new TransactionsRepository(context);

                result = _repository.Update(transactions);
            }

            if (result > 0)
            {
                MessageBox.Show("Transaction Updated Successfully", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Failed to Update Transaction!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }

        public int Delete(Transactions transactions)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new TransactionsRepository(context);
                result = _repository.Delete(transactions);
            }

            if (result > 0)
            {
                MessageBox.Show("Transaction Deleted Successfully", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Failed to Delete Transaction!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }

        public DataTable DisplayData()
        {
            using (DbContext context = new DbContext())
            {
                _repository = new TransactionsRepository(context);
                return _repository.DisplayData();
            }
        }

        public DataTable DisplayData(DateTime startDate, DateTime endDate)
        {
            using (DbContext context = new DbContext())
            {
                _repository = new TransactionsRepository(context);
                return _repository.DisplayData(startDate, endDate);
            }
        }

        public List<Transactions> ReadAll()
        {
            using (DbContext context = new DbContext())
            {
                _repository = new TransactionsRepository(context);
                return _repository.ReadAll();
            }
        }
    }
}
