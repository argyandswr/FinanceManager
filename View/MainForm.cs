using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalFinanceManager.View;

namespace PersonalFinanceManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addTransactionBtn_Click(object sender, EventArgs e)
        {
            addTransactionForm addTransactionForm = new addTransactionForm();
            addTransactionForm.Show();

            this.Close();
        }
    }
}
