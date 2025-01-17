using PersonalFinanceManager.Controller;
using PersonalFinanceManager.Model.Entity;

namespace PersonalFinanceManager.View
{
    public partial class categoriesForm : Form
    {
        int headerRowCatID = 0;

        public categoriesForm()
        {
            InitializeComponent();
            DisplayData();
        }

        private void dataGridViewCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ResetInput();
            comboBoxType.SelectedItem = dataGridViewCategories.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewCategories.Rows[e.RowIndex].Cells[1].Value.ToString();
            richTextBoxDescription.Text = dataGridViewCategories.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (int.TryParse(dataGridViewCategories.Rows[e.RowIndex].Cells[3].Value.ToString(), out headerRowCatID))
            {
                headerRowCatID = int.Parse(dataGridViewCategories.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
        }





        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxType.Text == "" || textBoxName.Text == "" || richTextBoxDescription.Text == "")
            {
                MessageBox.Show("Please fill all blank fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CategoriesController controller = new CategoriesController();
                Categories categories = new Categories()
                {
                    Type = (string)comboBoxType.SelectedItem,
                    Name = textBoxName.Text,
                    Description = richTextBoxDescription.Text,
                    UserID = GlobalVariable.UserID,
                    CategoryID = headerRowCatID
                };

                controller.Update(categories);
                ResetInput();
                DisplayData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxType.Text == "" || textBoxName.Text == "" || richTextBoxDescription.Text == "")
            {
                MessageBox.Show("Please fill all blank fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CategoriesController controller = new CategoriesController();
                Categories categories = new Categories()
                {
                    Type = (string)comboBoxType.SelectedItem,
                    Name = textBoxName.Text,
                    Description = richTextBoxDescription.Text,
                    UserID = GlobalVariable.UserID,
                };

                controller.Create(categories);
                ResetInput();
                DisplayData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxType.Text == "" || textBoxName.Text == "" || richTextBoxDescription.Text == "")
            {
                MessageBox.Show("Please fill all blank fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CategoriesController controller = new CategoriesController();
                Categories categories = new Categories()
                {
                    CategoryID = headerRowCatID
                };

                controller.Delete(categories);
                ResetInput();
                DisplayData();
            }
        }





        private void DisplayData()
        {
            CategoriesController controller = new();
            dataGridViewCategories.DataSource = controller.DisplayData();

            // Autosize column in datagrid view
            dataGridViewCategories.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCategories.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCategories.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCategories.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            for (int i = 0; i <= dataGridViewCategories.Columns.Count - 1; i++)
            {
                int colw = dataGridViewCategories.Columns[i].Width;

                dataGridViewCategories.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dataGridViewCategories.Columns[i].Width = colw;
            }
        }

        private void ResetInput()
        {
            comboBoxType.SelectedIndex = -1;
            textBoxName.Clear();
            richTextBoxDescription.Clear();
        }
    }
}
