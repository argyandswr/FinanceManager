using System.Data;
using FontAwesome.Sharp;
using PersonalFinanceManager.Controller;
using PersonalFinanceManager.Model.Entity;

namespace PersonalFinanceManager.View
{
    public partial class transactionsForm : Form
    {
        // Keep track of DataGridView selected filter and selected item
        enum SelectedFilter
        {
            today,
            last7days,
            custom
        }

        private IconButton currentBtn;
        private IconChar currentIcon;
        private static Color selectColor = Color.FromArgb(248, 249, 251);

        private SelectedFilter selectedFilter = SelectedFilter.today;
        private string selectedRowCategory;
        private int headerRowTransID = 0;
        private DataTable categoryData = new DataTable(); // Save the current categories

        public transactionsForm()
        {
            InitializeComponent();
            btnToday.PerformClick();

            // Bind categories data from database to category combo box
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "CategoryID";
            comboBoxCategory.SelectedItem = null;

            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;

            GlobalVariable.SendMessage(this.comboBoxType.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Select an item...");
            GlobalVariable.SendMessage(this.comboBoxCategory.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Please select type first...");
        }

        // Get category value after selecting comboBoxType
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoriesController controller = new CategoriesController();

            if (comboBoxType.SelectedIndex == 0)
            {
                categoryData = controller.GetIndexCategories("Expense");
                comboBoxCategory.DataSource = categoryData;
                comboBoxCategory.SelectedItem = null;
                GlobalVariable.SendMessage(this.comboBoxCategory.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Select an item...");
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                categoryData = controller.GetIndexCategories("Income");
                comboBoxCategory.DataSource = categoryData;
                comboBoxCategory.SelectedItem = null;
                GlobalVariable.SendMessage(this.comboBoxCategory.Handle, GlobalVariable.CB_SETCUEBANNER, 0, "Select an item...");
            }
        }

        private void dataGridViewTransactions_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ResetInput();
            comboBoxType.SelectedItem = dataGridViewTransactions.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewTransactions.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxAmount.Text = dataGridViewTransactions.Rows[e.RowIndex].Cells[2].Value.ToString();
            string categoryName = dataGridViewTransactions.Rows[e.RowIndex].Cells[3].Value.ToString();
            for (int i = 0; i < categoryData.Rows.Count; i++)
            {
                if (categoryData.Rows[i]["Name"].Equals(categoryName))
                {
                    comboBoxCategory.SelectedIndex = i;
                }
            }

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
                clickSelectedFilter();
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
                clickSelectedFilter();
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
                clickSelectedFilter();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clickSelectedFilter();
        }

        private bool btnCustomState = false;
        private void btnCustom_Click(object sender, EventArgs e)
        {
            selectedFilter = SelectedFilter.custom;
            ActivateButton(sender, selectColor);

            btnCustomState = !btnCustomState;
            if (btnCustomState)
            {
                panelBtnCustom.Size = panelBtnCustom.MaximumSize;
            }
            else
            {
                panelBtnCustom.Size = panelBtnCustom.MinimumSize;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DisplayData(dateTimePickerStart.Value, dateTimePickerEnd.Value);
            panelBtnCustom.Size = panelBtnCustom.MinimumSize;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            selectedFilter = SelectedFilter.today;
            ActivateButton(sender, selectColor);

            DateTime start = DateTime.Today;
            DateTime end = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
            DisplayData(start, end);
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            selectedFilter = SelectedFilter.last7days;
            ActivateButton(sender, selectColor);

            DisplayData(DateTime.Today.AddDays(-7), DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59));
        }





        private void DisplayData(DateTime startDate, DateTime endDate)
        {
            TransactionsController controller = new TransactionsController();
            dataGridViewTransactions.DataSource = controller.DisplayData(startDate, endDate);

            // Autosize column in datagrid view
            dataGridViewTransactions.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTransactions.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTransactions.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTransactions.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTransactions.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTransactions.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

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

        private void clickSelectedFilter()
        {
            if (selectedFilter == SelectedFilter.today)
            {
                btnToday.PerformClick();
            }
            else if(selectedFilter == SelectedFilter.last7days)
            {
                btnLast7Days.PerformClick();
            }
            else
            {
                btnOk.PerformClick();
            }
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(91, 103, 127);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                currentIcon = currentBtn.IconChar;
                currentBtn.IconChar = IconChar.CheckSquare;
            }

            // Close custom filter (if still expanded) if other filter is selected
            if (btnCustomState == true && selectedFilter != SelectedFilter.custom)
            {
                btnCustomState = false;
                panelBtnCustom.Size = panelBtnCustom.MinimumSize;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(76, 86, 106);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconChar = currentIcon;
            }
        }

    }
}
