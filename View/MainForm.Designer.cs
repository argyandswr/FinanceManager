namespace PersonalFinanceManager.View
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            panelMenu = new Panel();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnSettings = new FontAwesome.Sharp.IconButton();
            btnCategories = new FontAwesome.Sharp.IconButton();
            btnBudgets = new FontAwesome.Sharp.IconButton();
            btnTransactions = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            spacer1 = new Panel();
            spacer = new Panel();
            spacer2 = new Panel();
            panelTopBar = new Panel();
            iconExit = new FontAwesome.Sharp.IconButton();
            iconMinimize = new FontAwesome.Sharp.IconButton();
            iconMaximize = new FontAwesome.Sharp.IconButton();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(76, 86, 106);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnCategories);
            panelMenu.Controls.Add(btnBudgets);
            panelMenu.Controls.Add(btnTransactions);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(spacer1);
            panelMenu.Controls.Add(spacer);
            panelMenu.Controls.Add(spacer2);
            resources.ApplyResources(panelMenu, "panelMenu");
            panelMenu.ForeColor = SystemColors.ControlText;
            panelMenu.Name = "panelMenu";
            // 
            // btnLogout
            // 
            resources.ApplyResources(btnLogout, "btnLogout");
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.ForeColor = Color.FromArgb(236, 239, 244);
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnLogout.IconColor = Color.FromArgb(236, 239, 244);
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.IconSize = 32;
            btnLogout.Name = "btnLogout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSettings
            // 
            resources.ApplyResources(btnSettings, "btnSettings");
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.ForeColor = Color.FromArgb(236, 239, 244);
            btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cog;
            btnSettings.IconColor = Color.FromArgb(236, 239, 244);
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSettings.IconSize = 32;
            btnSettings.Name = "btnSettings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnCategories
            // 
            resources.ApplyResources(btnCategories, "btnCategories");
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.ForeColor = Color.FromArgb(236, 239, 244);
            btnCategories.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            btnCategories.IconColor = Color.FromArgb(236, 239, 244);
            btnCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCategories.IconSize = 32;
            btnCategories.Name = "btnCategories";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnBudgets
            // 
            resources.ApplyResources(btnBudgets, "btnBudgets");
            btnBudgets.FlatAppearance.BorderSize = 0;
            btnBudgets.ForeColor = Color.FromArgb(236, 239, 244);
            btnBudgets.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            btnBudgets.IconColor = Color.FromArgb(236, 239, 244);
            btnBudgets.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBudgets.IconSize = 32;
            btnBudgets.Name = "btnBudgets";
            btnBudgets.UseVisualStyleBackColor = true;
            btnBudgets.Click += btnBudgets_Click;
            // 
            // btnTransactions
            // 
            resources.ApplyResources(btnTransactions, "btnTransactions");
            btnTransactions.FlatAppearance.BorderSize = 0;
            btnTransactions.ForeColor = Color.FromArgb(236, 239, 244);
            btnTransactions.IconChar = FontAwesome.Sharp.IconChar.Usd;
            btnTransactions.IconColor = Color.FromArgb(236, 239, 244);
            btnTransactions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTransactions.IconSize = 32;
            btnTransactions.Name = "btnTransactions";
            btnTransactions.UseVisualStyleBackColor = true;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnDashboard
            // 
            resources.ApplyResources(btnDashboard, "btnDashboard");
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.ForeColor = Color.FromArgb(236, 239, 244);
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btnDashboard.IconColor = Color.FromArgb(236, 239, 244);
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 32;
            btnDashboard.Name = "btnDashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // spacer1
            // 
            spacer1.BackColor = Color.FromArgb(76, 86, 106);
            resources.ApplyResources(spacer1, "spacer1");
            spacer1.Name = "spacer1";
            // 
            // spacer
            // 
            spacer.BackColor = Color.FromArgb(67, 76, 94);
            resources.ApplyResources(spacer, "spacer");
            spacer.Name = "spacer";
            // 
            // spacer2
            // 
            resources.ApplyResources(spacer2, "spacer2");
            spacer2.Name = "spacer2";
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(59, 66, 82);
            panelTopBar.Controls.Add(iconExit);
            panelTopBar.Controls.Add(iconMinimize);
            panelTopBar.Controls.Add(iconMaximize);
            resources.ApplyResources(panelTopBar, "panelTopBar");
            panelTopBar.Name = "panelTopBar";
            panelTopBar.MouseDown += panelTopBar_MouseDown;
            // 
            // iconExit
            // 
            resources.ApplyResources(iconExit, "iconExit");
            iconExit.BackColor = Color.FromArgb(59, 66, 82);
            iconExit.FlatAppearance.BorderSize = 0;
            iconExit.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconExit.IconColor = Color.FromArgb(236, 239, 244);
            iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconExit.IconSize = 28;
            iconExit.Name = "iconExit";
            iconExit.UseVisualStyleBackColor = false;
            iconExit.Click += iconExit_Click;
            // 
            // iconMinimize
            // 
            resources.ApplyResources(iconMinimize, "iconMinimize");
            iconMinimize.BackColor = Color.FromArgb(59, 66, 82);
            iconMinimize.FlatAppearance.BorderSize = 0;
            iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconMinimize.IconColor = Color.FromArgb(236, 239, 244);
            iconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMinimize.IconSize = 28;
            iconMinimize.Name = "iconMinimize";
            iconMinimize.UseVisualStyleBackColor = false;
            iconMinimize.Click += iconMinimize_Click;
            // 
            // iconMaximize
            // 
            resources.ApplyResources(iconMaximize, "iconMaximize");
            iconMaximize.BackColor = Color.FromArgb(59, 66, 82);
            iconMaximize.FlatAppearance.BorderSize = 0;
            iconMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            iconMaximize.IconColor = Color.FromArgb(236, 239, 244);
            iconMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMaximize.IconSize = 28;
            iconMaximize.Name = "iconMaximize";
            iconMaximize.UseVisualStyleBackColor = false;
            iconMaximize.Click += iconMaximize_Click;
            // 
            // panelDesktop
            // 
            resources.ApplyResources(panelDesktop, "panelDesktop");
            panelDesktop.Name = "panelDesktop";
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 222, 233);
            Controls.Add(panelDesktop);
            Controls.Add(panelTopBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mainForm";
            Load += mainForm_Load;
            panelMenu.ResumeLayout(false);
            panelTopBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnCategories;
        private FontAwesome.Sharp.IconButton btnBudgets;
        private FontAwesome.Sharp.IconButton btnTransactions;
        private Panel panelTopBar;
        private FontAwesome.Sharp.IconButton iconMaximize;
        private FontAwesome.Sharp.IconButton iconExit;
        private FontAwesome.Sharp.IconButton iconMinimize;
        private Panel spacer;
        private Panel spacer1;
        private Panel panelDesktop;
        private Panel spacer2;
    }
}