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
using System.Runtime.InteropServices;

namespace PersonalFinanceManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
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
            RegisterForm regForm = new RegisterForm();
            regForm.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersController controller = new UsersController();

            GlobalVariable.UserID = controller.GetUserID("joe", "joe");
            mainForm mainForm = new mainForm();
            mainForm.Show();

            this.Hide();
        }




        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Close maximize exit
        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
