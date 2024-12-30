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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace PersonalFinanceManager.View
{
    public partial class addTransactionForm : Form
    {
        // For setting placeholder text into combo box
        private const int CB_SETCUEBANNER = 0x1703;
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);


        public addTransactionForm()
        {
            InitializeComponent();
        }

        private void addTransactionForm_Load(object sender, EventArgs e)
        {
            CategoriesController controller = new CategoriesController();

            // Bind categories data from database to category combo box
            comboBoxCategory.DataSource = controller.GetCategories();
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "CategoryID";
            comboBoxCategory.SelectedItem = null;

            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;

            SendMessage(this.comboBoxCategory.Handle, CB_SETCUEBANNER, 0, "Please select an item...");
            SendMessage(this.comboBoxType.Handle, CB_SETCUEBANNER, 0, "Please select an item...");
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
            TransactionsController controller = new TransactionsController();

            Transactions transactions = new Transactions();

            DateTime dateTime = datePicker.Value.Date + timePicker.Value.TimeOfDay;

            transactions.UserID = CurrentUser.UserID;
            transactions.Date = dateTime;

            // TODO: make sure value not null
            transactions.Amount = float.Parse(textBoxAmount.Text);
            transactions.Type = comboBoxType.SelectedItem.ToString();
            transactions.CategoryID = (int)comboBoxCategory.SelectedValue;
            transactions.Description = richTextBoxDescription.Text;

            controller.Create(transactions);
            ResetForm();
        }

        // Reset column value
        private void ResetForm()
        {
            SendMessage(this.comboBoxType.Handle, CB_SETCUEBANNER, 0, "Please select an item...");
            textBoxAmount.Text = string.Empty;
            SendMessage(this.comboBoxCategory.Handle, CB_SETCUEBANNER, 0, "Please select an item...");
            richTextBoxDescription.Text = string.Empty;
        }
    }
}
