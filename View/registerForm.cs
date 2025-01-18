using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
