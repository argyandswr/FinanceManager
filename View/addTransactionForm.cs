using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using PersonalFinanceManager.Controller;
using PersonalFinanceManager.Model.Entity;

namespace PersonalFinanceManager.View
{
    public partial class addTransactionForm : Form
    {
        public addTransactionForm()
        {
            InitializeComponent();
        }

        private void addTransactionForm_Load(object sender, EventArgs e)
        {
            CategoriesController controller = new CategoriesController();

            comboBoxType.Items.Add("Income");
            comboBoxType.Items.Add("Expense");

            // Bind categories data from database to category combo box
            comboBoxCategory.DataSource = controller.GetCategories();
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "CategoryID";
        }

        // Only allow numbers and decimal in amount
        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            /*TransactionsController controller = new TransactionsController();

            Transactions transactions = new Transactions();
            transactions.Type = transactions.GetType(comboBoxType.SelectedValue.ToString);

            controller.Create(transactions);*/
        }
    }
}
