using System.Runtime.InteropServices;
using FontAwesome.Sharp;

namespace PersonalFinanceManager.View
{
    public partial class mainForm : Form
    {
        public static Color colorSnowWhite = Color.FromArgb(248, 249, 251);
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public mainForm()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // Maximized window won't cover the taskbar
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorSnowWhite);
            OpenChildForm(new dashboardForm());
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorSnowWhite);
            OpenChildForm(new transactionsForm());
        }

        private void btnBudgets_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorSnowWhite);
            OpenChildForm(new budgetsForm());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorSnowWhite);
            OpenChildForm(new categoriesForm());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorSnowWhite);
            OpenChildForm(new settingsForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorSnowWhite);
            if (MessageBox.Show("Are you sure want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loginForm logForm = new loginForm();
                logForm.Show();

                this.Close();
            }
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

        private void panelTopBarLeft_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Close maximize exit
        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
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
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            btnDashboard.PerformClick();
        }
    }
}
