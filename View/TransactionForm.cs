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
        bool isRowSelected = false;
        string selectedRowCategory;

        public TransactionForm()
        {
            InitializeComponent();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            CategoriesController controller = new CategoriesController();

            DisplayData();

            // Bind categories data from database to category combo box
            transactionCategory.DisplayMember = "Name";
            transactionCategory.ValueMember = "CategoryID";
            transactionCategory.SelectedItem = null;

            transactionTimePicker.Format = DateTimePickerFormat.Time;
            transactionTimePicker.ShowUpDown = true;

            GlobalVariable.SendMessage(this.transactionType.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Select an item...");
            GlobalVariable.SendMessage(this.transactionCategory.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Please select type first...");
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
                DateTime date = transactionDatePicker.Value.Date + transactionTimePicker.Value.TimeOfDay;
                transactions.Date = date;


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

        private void DisplayData()
        {
            TransactionsController controller = new TransactionsController();
            dataGridView1.DataSource = controller.DisplayData();
        }

        private void ResetInput()
        {
            transactionName_txt.Clear();
            transactionType.SelectedIndex = -1;
            GlobalVariable.SendMessage(this.transactionType.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Select an item...");
            transactionCategory.SelectedIndex = -1;
            GlobalVariable.SendMessage(this.transactionCategory.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Please select type first...");
            transactionDatePicker.Value = DateTime.Now;
            transactionTimePicker.Value = DateTime.Now;
            transactionAmount_txt.Clear();
        }

        private void transaction_updateBtn_Click(object sender, EventArgs e)
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
                DateTime date = transactionDatePicker.Value.Date + transactionTimePicker.Value.TimeOfDay;
                transactions.Date = date;


                controller.Update(transactions);
                ResetInput();
            }
        }

        private void transactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoriesController controller = new CategoriesController();

            if (transactionType.SelectedIndex == 0)
            {
                transactionCategory.DataSource = controller.GetCategories("Income");
                transactionCategory.SelectedItem = null;
                GlobalVariable.SendMessage(this.transactionCategory.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Select an item...");
            }
            else if (transactionType.SelectedIndex == 1)
            {
                transactionCategory.DataSource = controller.GetCategories("Expense");
                transactionCategory.SelectedItem = null;
                GlobalVariable.SendMessage(this.transactionCategory.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Select an item...");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ResetInput();
            Transactions transactions = new Transactions();
            transactionType.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            transactionName_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            transactionAmount_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            selectedRowCategory = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            DateTime dateTime = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            transactionDatePicker.Value = dateTime;
            transactionTimePicker.Value = dateTime;

            isRowSelected = true;
        }

        static (string DateOnly, string TimeOnly) SplitDateTime(string dateTime)
        {
            string[] parts = dateTime.Split(' ');
            if (parts.Length >= 2)
            {
                string dateOnly = parts[0];
                string timeOnly = parts[1];
                return (dateOnly, timeOnly);
            }

            throw new FormatException("Invalid DateTime format.");
        }

        private void transactionCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label7.Text = transactionCategory.Text;
        }

        private void transactionType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (isRowSelected)
            //{
            //    if (string.IsNullOrEmpty(selectedRowCategory))
            //    {
            //        transactionCategory.SelectedItem = selectedRowCategory;
            //        isRowSelected = false;
            //        selectedRowCategory = null;
            //    }
            //}
        }
    }
}
