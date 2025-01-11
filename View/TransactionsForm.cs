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

namespace PersonalFinanceManager.View
{
    public partial class transactionsForm : Form
    {
        public transactionsForm()
        {
            InitializeComponent();
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
    }
}
