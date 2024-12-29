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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {

        }

        private void transactionName_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void transaction_addBtn_Click(object sender, EventArgs e)
        {
            if (transactionName_txt.Text == "" || transactionCategory.SelectedIndex == -1 || transactionAmount_txt.Text == "")
            {
                MessageBox.Show("Please fill all blank fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TransactionsController controller = new TransactionsController();

                Transactions transactions = new Transactions();
                transactions.TransactionName = transactionName_txt.Text;
                transactions.Type = (string)transactionCategory.SelectedItem;
                transactions.Amount = float.Parse(transactionAmount_txt.Text);
                transactions.Date = transactionDate.Value;

                controller.Create(transactions);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
