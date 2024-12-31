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
<<<<<<< Updated upstream
=======
        bool isRowSelected = false;
        string selectedRowCategory;
        int headerRowTransID = 0;


>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
=======
        private void DisplayData()
        {
            TransactionsController controller = new TransactionsController();
            dataGridView1.DataSource = controller.DisplayData();
            dataGridView1.DefaultCellStyle.ForeColor = SystemColors.ControlText;

            // Autosize column in datagrid view
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            {
                int colw = dataGridView1.Columns[i].Width;

                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dataGridView1.Columns[i].Width = colw;
            }
        }

>>>>>>> Stashed changes
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
