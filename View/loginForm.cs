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

namespace PersonalFinanceManager
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void login_Btn_Click(object sender, EventArgs e)
        {
            UsersController controller = new UsersController();

            bool isValidUser = controller.IsValidUser(usernameLogin_Txt.Text, passLogin_Txt.Text);
            if (isValidUser)
            {
                GlobalVariable.UserID = controller.GetUserID(usernameLogin_Txt.Text, passLogin_Txt.Text);
                mainForm mainForm = new mainForm();
                mainForm.Show();

                this.Hide();
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            passLogin_Txt.PasswordChar = showPass.Checked ? '\0' : '*';
        }

        private void reg_Btn_Click(object sender, EventArgs e)
        {
            registerForm regForm = new registerForm();
            regForm.Show();

            this.Hide();
        }
    }
}
