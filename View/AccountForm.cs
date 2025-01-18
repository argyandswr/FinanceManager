using PersonalFinanceManager.Controller;
using PersonalFinanceManager.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace PersonalFinanceManager.View
{
    public partial class accountForm : Form
    {
        public accountForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Please fill all blank fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UsersController controller = new UsersController();
                Users user = new Users()
                {
                    Username = usernameTextBox.Text,
                    Password = passwordTextBox.Text,
                };

                controller.Update(user);
            }
        }   
    }
}
