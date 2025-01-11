using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalFinanceManager.Controller;
using PersonalFinanceManager.Model.Entity;

namespace PersonalFinanceManager.View
{
    public partial class transactionsForm : Form
    {
        // Keep track of DataGridView selected item
        private bool isRowSelected = false;
        private string selectedRowCategory;
        int headerRowTransID = 0;

        public transactionsForm()
        {
            InitializeComponent();
            DisplayData();

            // Bind categories data from database to category combo box
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "CategoryID";
            comboBoxCategory.SelectedItem = null;

            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;

            GlobalVariable.SendMessage(this.comboBoxType.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Select an item...");
            GlobalVariable.SendMessage(this.comboBoxCategory.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Please select type first...");
        }

        private void transactionsForm_Load(object sender, EventArgs e)
        {

        }



        // Get category value after selecting comboBoxType
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoriesController controller = new CategoriesController();

            if (comboBoxType.SelectedIndex == 0)
            {
                comboBoxCategory.DataSource = controller.GetCategories("Expense");
                comboBoxCategory.SelectedItem = null;
                GlobalVariable.SendMessage(this.comboBoxCategory.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Select an item...");
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                comboBoxCategory.DataSource = controller.GetCategories("Income");
                comboBoxCategory.SelectedItem = null;
                GlobalVariable.SendMessage(this.comboBoxCategory.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Select an item...");
            }
        }

        private void dataGridViewTransactions_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ResetInput();
            Transactions transactions = new Transactions();
            comboBoxType.SelectedItem = dataGridViewTransactions.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewTransactions.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxAmount.Text = dataGridViewTransactions.Rows[e.RowIndex].Cells[2].Value.ToString();
            selectedRowCategory = dataGridViewTransactions.Rows[e.RowIndex].Cells[3].Value.ToString();

            DateTime dateTime;
            if (DateTime.TryParse(dataGridViewTransactions.Rows[e.RowIndex].Cells[4].Value.ToString(), out dateTime))
            {
                dateTime = DateTime.Parse(dataGridViewTransactions.Rows[e.RowIndex].Cells[4].Value.ToString());
                datePicker.Value = dateTime;
                timePicker.Value = dateTime;
            }
            else
            {
                datePicker.Value = DateTime.Now;
                timePicker.Value = DateTime.Now;
            }

            if (int.TryParse(dataGridViewTransactions.Rows[e.RowIndex].Cells[5].Value.ToString(), out headerRowTransID))
            {
                headerRowTransID = int.Parse(dataGridViewTransactions.Rows[e.RowIndex].Cells[5].Value.ToString());
                isRowSelected = true;
            }
            else
            {
                isRowSelected = false;
            }
        }

        // Allow numeric only
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



        // CRUD

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || comboBoxCategory.SelectedIndex == -1 || comboBoxType.SelectedIndex == -1 || textBoxAmount.Text == "")
            {
                MessageBox.Show("Please fill all blank fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TransactionsController controller = new TransactionsController();

                Transactions transactions = new Transactions();
                transactions.TransactionID = headerRowTransID;

                controller.Delete(transactions);
                ResetInput();
                DisplayData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || comboBoxCategory.SelectedIndex == -1 || comboBoxType.SelectedIndex == -1 || textBoxAmount.Text == "")
            {
                MessageBox.Show("Please fill all blank fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TransactionsController controller = new TransactionsController();

                Transactions transactions = new Transactions();
                transactions.UserID = GlobalVariable.UserID;
                transactions.TransactionName = textBoxName.Text;
                transactions.Type = (string)comboBoxType.SelectedItem;
                transactions.CategoryID = int.Parse(comboBoxCategory.SelectedValue.ToString());
                transactions.Amount = float.Parse(textBoxAmount.Text);
                DateTime date = datePicker.Value.Date + timePicker.Value.TimeOfDay;
                transactions.Date = date;
                transactions.TransactionID = headerRowTransID;

                controller.Update(transactions);
                ResetInput();
                DisplayData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || comboBoxCategory.SelectedIndex == -1 || comboBoxType.SelectedIndex == -1 || textBoxAmount.Text == "")
            {
                MessageBox.Show("Please fill all blank fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TransactionsController controller = new TransactionsController();

                Transactions transactions = new Transactions();
                transactions.UserID = GlobalVariable.UserID;
                transactions.TransactionName = textBoxName.Text;
                transactions.Type = (string)comboBoxType.SelectedItem;
                transactions.CategoryID = int.Parse(comboBoxCategory.SelectedValue.ToString());
                transactions.Amount = float.Parse(textBoxAmount.Text);
                DateTime date = datePicker.Value.Date + timePicker.Value.TimeOfDay;
                transactions.Date = date;

                controller.Create(transactions);
                ResetInput();
                DisplayData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayData();
        }











        private void DisplayData()
        {
            TransactionsController controller = new TransactionsController();
            dataGridViewTransactions.DataSource = controller.DisplayData();

            // Autosize column in datagrid view
            dataGridViewTransactions.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTransactions.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTransactions.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTransactions.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTransactions.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTransactions.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i <= dataGridViewTransactions.Columns.Count - 1; i++)
            {
                int colw = dataGridViewTransactions.Columns[i].Width;

                dataGridViewTransactions.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dataGridViewTransactions.Columns[i].Width = colw;
            }
        }

        private void ResetInput()
        {
            textBoxName.Clear();
            comboBoxType.SelectedIndex = -1;
            GlobalVariable.SendMessage(this.comboBoxType.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Select an item...");
            comboBoxCategory.SelectedIndex = -1;
            GlobalVariable.SendMessage(this.comboBoxCategory.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Please select type first...");
            datePicker.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
            textBoxAmount.Clear();
        }

        
    }
}
