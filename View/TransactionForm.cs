using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using PersonalFinanceManager.Controller;
using PersonalFinanceManager.View;
using PersonalFinanceManager.Model.Entity;


namespace PersonalFinanceManager.View
{
    public partial class TransactionForm : UserControl
    {
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            CategoriesController controller = new CategoriesController();

            // Bind categories data from database to category combo box
            transactionCategory.DataSource = controller.GetCategories();
            transactionCategory.DisplayMember = "Name";
            transactionCategory.ValueMember = "CategoryID";
            transactionCategory.SelectedItem = null;

            transactionTimePicker.Format = DateTimePickerFormat.Time;
            transactionTimePicker.ShowUpDown = true;

            GlobalVariable.SendMessage(this.transactionType.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Select an item...");
            GlobalVariable.SendMessage(this.transactionCategory.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Select an item...");
        }

        private void transaction_addBtn_Click(object sender, EventArgs e)
        {
            if (transactionName_txt.Text == "" || transactionCategory.SelectedIndex == -1 || transactionType.SelectedIndex == -1 || transactionAmount_txt.Text == "")
            {
                MessageBox.Show("Please fill all blank fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TransactionsController controller = new TransactionsController();

                Transactions transactions = new Transactions();
                transactions.UserID = GlobalVariable.UserID;
                transactions.TransactionName = transactionName_txt.Text;
                transactions.Type = (string)transactionType.SelectedItem;
                transactions.CategoryID = int.Parse(transactionCategory.SelectedValue.ToString());
                transactions.Amount = float.Parse(transactionAmount_txt.Text);
                transactions.Date = transactionDatePicker.Value;

                controller.Create(transactions);
                ResetInput();
            }
        }

        private void transactionAmount_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ResetInput()
        {
            transactionName_txt.Clear();
            transactionType.SelectedIndex = -1;
            GlobalVariable.SendMessage(this.transactionType.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Select an item...");
            transactionCategory.SelectedIndex = -1;
            GlobalVariable.SendMessage(this.transactionCategory.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Select an item...");
            transactionDatePicker.Value = DateTime.Now;
            transactionTimePicker.Value = DateTime.Now;
            transactionAmount_txt.Clear();
        }

        private void transaction_updateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
