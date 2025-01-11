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
using PersonalFinanceManager.Controller;
using PersonalFinanceManager.Model.Entity;

namespace PersonalFinanceManager
{
    public partial class registerForm : Form
    {

        public registerForm()
        {
            InitializeComponent();
        }

        private void signup_Btn_Click(object sender, EventArgs e)
        {
            UsersController controller = new UsersController();

            bool isUsernameAvailable = controller.IsUsernameAvailable(usernameReg_Txt.Text, passReg_Txt.Text, confirmPass_Txt.Text);
            if (isUsernameAvailable)
            {
                Users user = new Users();
                user.Username = usernameReg_Txt.Text;
                user.Password = passReg_Txt.Text;
                controller.Create(user);

                this.DialogResult = DialogResult.OK;
                loginForm logForm = new loginForm();
                logForm.Show();
                this.Close();
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            passReg_Txt.PasswordChar = showPass.Checked ? '\0' : '*';
            confirmPass_Txt.PasswordChar = showPass.Checked ? '\0' : '*';
        }

        private void signIn_Btn_Click(object sender, EventArgs e)
        {
            loginForm logForm = new loginForm();
            logForm.Show();

            this.Close();
        }
    }
}
