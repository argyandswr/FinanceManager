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
    public partial class categoriesForm : Form
    {
        public categoriesForm()
        {
            InitializeComponent();
            DisplayData();
        }

        private void categoriesForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }





        private void DisplayData()
        {
            CategoriesController controller = new();
            dataGridViewCategories.DataSource = controller.DisplayData();
            dataGridViewCategories.MaximumSize = panelDataGridView.Size;

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
