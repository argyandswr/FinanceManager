namespace PersonalFinanceManager.View
{
    partial class settingsForm
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
            tableLayoutPanelMain = new TableLayoutPanel();
            panelMenu = new Panel();
            btnAccount = new FontAwesome.Sharp.IconButton();
            btnBudgets = new FontAwesome.Sharp.IconButton();
            btnCategories = new FontAwesome.Sharp.IconButton();
            spacerPanel1 = new Panel();
            panelDesktop = new Panel();
            tableLayoutPanelMain.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(panelMenu, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelDesktop, 1, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.Padding = new Padding(10);
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(860, 670);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(216, 222, 233);
            panelMenu.Controls.Add(btnAccount);
            panelMenu.Controls.Add(btnBudgets);
            panelMenu.Controls.Add(btnCategories);
            panelMenu.Controls.Add(spacerPanel1);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(13, 13);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(194, 644);
            panelMenu.TabIndex = 1;
            // 
            // btnAccount
            // 
            btnAccount.Dock = DockStyle.Top;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAccount.ForeColor = Color.FromArgb(59, 66, 82);
            btnAccount.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            btnAccount.IconColor = Color.FromArgb(59, 66, 82);
            btnAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAccount.IconSize = 38;
            btnAccount.ImageAlign = ContentAlignment.MiddleRight;
            btnAccount.Location = new Point(0, 140);
            btnAccount.Margin = new Padding(0, 10, 0, 15);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(194, 60);
            btnAccount.TabIndex = 14;
            btnAccount.Text = "Account";
            btnAccount.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnBudgets
            // 
            btnBudgets.Dock = DockStyle.Top;
            btnBudgets.FlatAppearance.BorderSize = 0;
            btnBudgets.FlatStyle = FlatStyle.Flat;
            btnBudgets.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBudgets.ForeColor = Color.FromArgb(59, 66, 82);
            btnBudgets.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnBudgets.IconColor = Color.FromArgb(59, 66, 82);
            btnBudgets.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBudgets.IconSize = 38;
            btnBudgets.ImageAlign = ContentAlignment.MiddleRight;
            btnBudgets.Location = new Point(0, 80);
            btnBudgets.Margin = new Padding(0, 10, 0, 15);
            btnBudgets.Name = "btnBudgets";
            btnBudgets.Size = new Size(194, 60);
            btnBudgets.TabIndex = 10;
            btnBudgets.Text = "Budgets";
            btnBudgets.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBudgets.UseVisualStyleBackColor = false;
            btnBudgets.Click += btnBudgets_Click;
            // 
            // btnCategories
            // 
            btnCategories.Dock = DockStyle.Top;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCategories.ForeColor = Color.FromArgb(59, 66, 82);
            btnCategories.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnCategories.IconColor = Color.FromArgb(59, 66, 82);
            btnCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCategories.IconSize = 38;
            btnCategories.ImageAlign = ContentAlignment.MiddleRight;
            btnCategories.Location = new Point(0, 20);
            btnCategories.Margin = new Padding(0, 10, 0, 15);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(194, 60);
            btnCategories.TabIndex = 10;
            btnCategories.Text = "Categories";
            btnCategories.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // spacerPanel1
            // 
            spacerPanel1.Dock = DockStyle.Top;
            spacerPanel1.Location = new Point(0, 0);
            spacerPanel1.Name = "spacerPanel1";
            spacerPanel1.Size = new Size(194, 20);
            spacerPanel1.TabIndex = 0;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(213, 13);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(634, 644);
            panelDesktop.TabIndex = 2;
            // 
            // settingsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 239, 244);
            ClientSize = new Size(860, 670);
            Controls.Add(tableLayoutPanelMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "settingsForm";
            ShowIcon = false;
            Text = "SettingsForm";
            tableLayoutPanelMain.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelMenu;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnCategories;
        private Panel spacerPanel1;
        private FontAwesome.Sharp.IconButton btnBudgets;
        private FontAwesome.Sharp.IconButton btnAccount;
    }
}