namespace PersonalFinanceManager.View
{
    partial class categoriesForm
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
            panelDesktop = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            panelDataGridView = new Panel();
            btnDelete = new FontAwesome.Sharp.IconButton();
            dataGridViewCategories = new DataGridView();
            panelMenu = new Panel();
            tableLayoutPanelMenu = new TableLayoutPanel();
            panelMenuDescription = new Panel();
            labelDescription = new Label();
            richTextBoxDescription = new RichTextBox();
            panelMenuName = new Panel();
            panel2 = new Panel();
            addButtonSpacer = new TableLayoutPanel();
            btnAdd = new FontAwesome.Sharp.IconButton();
            menuNameSpacer = new Panel();
            textBoxName = new TextBox();
            labelName = new Label();
            panelMenuType = new Panel();
            panel1 = new Panel();
            typeBtnSpacer = new TableLayoutPanel();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            menuTypeSpacer = new Panel();
            comboBoxType = new ComboBox();
            labelType = new Label();
            tableLayoutPanelMain.SuspendLayout();
            panelDesktop.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            panelMenu.SuspendLayout();
            tableLayoutPanelMenu.SuspendLayout();
            panelMenuDescription.SuspendLayout();
            panelMenuName.SuspendLayout();
            panel2.SuspendLayout();
            addButtonSpacer.SuspendLayout();
            menuNameSpacer.SuspendLayout();
            panelMenuType.SuspendLayout();
            panel1.SuspendLayout();
            typeBtnSpacer.SuspendLayout();
            menuTypeSpacer.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(panelDesktop, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelMenu, 0, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.Padding = new Padding(10);
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanelMain.Size = new Size(634, 644);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelDesktop
            // 
            panelDesktop.Controls.Add(tableLayoutPanel1);
            panelDesktop.Controls.Add(panelDataGridView);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(13, 13);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(608, 430);
            panelDesktop.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnRefresh, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.Size = new Size(608, 45);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(76, 86, 106);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.FromArgb(236, 239, 244);
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.FromArgb(236, 239, 244);
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 32;
            btnRefresh.Location = new Point(235, 0);
            btnRefresh.Margin = new Padding(0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(137, 45);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panelDataGridView
            // 
            panelDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDataGridView.Controls.Add(btnDelete);
            panelDataGridView.Controls.Add(dataGridViewCategories);
            panelDataGridView.Location = new Point(0, 63);
            panelDataGridView.Name = "panelDataGridView";
            panelDataGridView.Size = new Size(608, 367);
            panelDataGridView.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(76, 86, 106);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(236, 239, 244);
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnDelete.IconColor = Color.FromArgb(236, 239, 244);
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 32;
            btnDelete.Location = new Point(454, 275);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 45);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.BackgroundColor = Color.FromArgb(236, 239, 244);
            dataGridViewCategories.BorderStyle = BorderStyle.None;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Dock = DockStyle.Fill;
            dataGridViewCategories.Location = new Point(0, 0);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.RowHeadersWidth = 62;
            dataGridViewCategories.Size = new Size(608, 367);
            dataGridViewCategories.TabIndex = 1;
            dataGridViewCategories.RowHeaderMouseClick += dataGridViewCategories_RowHeaderMouseClick;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(tableLayoutPanelMenu);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(13, 449);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(608, 182);
            panelMenu.TabIndex = 1;
            // 
            // tableLayoutPanelMenu
            // 
            tableLayoutPanelMenu.BackColor = Color.FromArgb(216, 222, 233);
            tableLayoutPanelMenu.ColumnCount = 3;
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanelMenu.Controls.Add(panelMenuDescription, 2, 0);
            tableLayoutPanelMenu.Controls.Add(panelMenuName, 1, 0);
            tableLayoutPanelMenu.Controls.Add(panelMenuType, 0, 0);
            tableLayoutPanelMenu.Dock = DockStyle.Fill;
            tableLayoutPanelMenu.Location = new Point(0, 0);
            tableLayoutPanelMenu.Margin = new Padding(0);
            tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            tableLayoutPanelMenu.RowCount = 1;
            tableLayoutPanelMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMenu.Size = new Size(608, 182);
            tableLayoutPanelMenu.TabIndex = 0;
            // 
            // panelMenuDescription
            // 
            panelMenuDescription.Controls.Add(labelDescription);
            panelMenuDescription.Controls.Add(richTextBoxDescription);
            panelMenuDescription.Dock = DockStyle.Fill;
            panelMenuDescription.Location = new Point(367, 3);
            panelMenuDescription.Name = "panelMenuDescription";
            panelMenuDescription.Size = new Size(238, 176);
            panelMenuDescription.TabIndex = 0;
            // 
            // labelDescription
            // 
            labelDescription.Dock = DockStyle.Top;
            labelDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelDescription.Location = new Point(0, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(238, 50);
            labelDescription.TabIndex = 5;
            labelDescription.Text = "Description";
            labelDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxDescription.Location = new Point(13, 53);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(211, 95);
            richTextBoxDescription.TabIndex = 1;
            richTextBoxDescription.Text = "";
            // 
            // panelMenuName
            // 
            panelMenuName.Controls.Add(panel2);
            panelMenuName.Controls.Add(menuNameSpacer);
            panelMenuName.Controls.Add(labelName);
            panelMenuName.Dock = DockStyle.Fill;
            panelMenuName.Location = new Point(185, 3);
            panelMenuName.Name = "panelMenuName";
            panelMenuName.Size = new Size(176, 176);
            panelMenuName.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(addButtonSpacer);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 95);
            panel2.TabIndex = 4;
            // 
            // addButtonSpacer
            // 
            addButtonSpacer.ColumnCount = 3;
            addButtonSpacer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            addButtonSpacer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            addButtonSpacer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            addButtonSpacer.Controls.Add(btnAdd, 1, 1);
            addButtonSpacer.Dock = DockStyle.Fill;
            addButtonSpacer.Location = new Point(0, 0);
            addButtonSpacer.Name = "addButtonSpacer";
            addButtonSpacer.RowCount = 3;
            addButtonSpacer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            addButtonSpacer.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            addButtonSpacer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            addButtonSpacer.Size = new Size(176, 95);
            addButtonSpacer.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.BackColor = Color.FromArgb(76, 86, 106);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(236, 239, 244);
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAdd.IconColor = Color.FromArgb(236, 239, 244);
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 32;
            btnAdd.Location = new Point(15, 25);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 45);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // menuNameSpacer
            // 
            menuNameSpacer.Controls.Add(textBoxName);
            menuNameSpacer.Dock = DockStyle.Top;
            menuNameSpacer.Location = new Point(0, 50);
            menuNameSpacer.Name = "menuNameSpacer";
            menuNameSpacer.Size = new Size(176, 31);
            menuNameSpacer.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.Location = new Point(11, 0);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(155, 31);
            textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.Dock = DockStyle.Top;
            labelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelName.Location = new Point(0, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(176, 50);
            labelName.TabIndex = 4;
            labelName.Text = "Name";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMenuType
            // 
            panelMenuType.Controls.Add(panel1);
            panelMenuType.Controls.Add(menuTypeSpacer);
            panelMenuType.Controls.Add(labelType);
            panelMenuType.Dock = DockStyle.Fill;
            panelMenuType.Location = new Point(3, 3);
            panelMenuType.Name = "panelMenuType";
            panelMenuType.Size = new Size(176, 176);
            panelMenuType.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(typeBtnSpacer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 93);
            panel1.TabIndex = 4;
            // 
            // typeBtnSpacer
            // 
            typeBtnSpacer.ColumnCount = 3;
            typeBtnSpacer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            typeBtnSpacer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            typeBtnSpacer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            typeBtnSpacer.Controls.Add(btnUpdate, 1, 1);
            typeBtnSpacer.Dock = DockStyle.Fill;
            typeBtnSpacer.Location = new Point(0, 0);
            typeBtnSpacer.Name = "typeBtnSpacer";
            typeBtnSpacer.RowCount = 3;
            typeBtnSpacer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            typeBtnSpacer.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            typeBtnSpacer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            typeBtnSpacer.Size = new Size(176, 93);
            typeBtnSpacer.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(76, 86, 106);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.FromArgb(236, 239, 244);
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnUpdate.IconColor = Color.FromArgb(236, 239, 244);
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.IconSize = 32;
            btnUpdate.Location = new Point(24, 24);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 45);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // menuTypeSpacer
            // 
            menuTypeSpacer.Controls.Add(comboBoxType);
            menuTypeSpacer.Dock = DockStyle.Top;
            menuTypeSpacer.Location = new Point(0, 50);
            menuTypeSpacer.Name = "menuTypeSpacer";
            menuTypeSpacer.Size = new Size(176, 33);
            menuTypeSpacer.TabIndex = 3;
            // 
            // comboBoxType
            // 
            comboBoxType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Expense", "Income" });
            comboBoxType.Location = new Point(11, 0);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(155, 33);
            comboBoxType.TabIndex = 2;
            // 
            // labelType
            // 
            labelType.Dock = DockStyle.Top;
            labelType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelType.Location = new Point(0, 0);
            labelType.Name = "labelType";
            labelType.Size = new Size(176, 50);
            labelType.TabIndex = 3;
            labelType.Text = "Type";
            labelType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // categoriesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 239, 244);
            ClientSize = new Size(634, 644);
            Controls.Add(tableLayoutPanelMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "categoriesForm";
            Text = "CategoriesForm";
            tableLayoutPanelMain.ResumeLayout(false);
            panelDesktop.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            panelMenu.ResumeLayout(false);
            tableLayoutPanelMenu.ResumeLayout(false);
            panelMenuDescription.ResumeLayout(false);
            panelMenuName.ResumeLayout(false);
            panel2.ResumeLayout(false);
            addButtonSpacer.ResumeLayout(false);
            menuNameSpacer.ResumeLayout(false);
            menuNameSpacer.PerformLayout();
            panelMenuType.ResumeLayout(false);
            panel1.ResumeLayout(false);
            typeBtnSpacer.ResumeLayout(false);
            menuTypeSpacer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelDesktop;
        private Panel panelMenu;
        private Label labelDescription;
        private Label labelName;
        private Label labelType;
        private ComboBox comboBoxType;
        private RichTextBox richTextBoxDescription;
        private TextBox textBoxName;
        private FontAwesome.Sharp.IconButton btnDelete;
        private TableLayoutPanel tableLayoutPanelMenu;
        private Panel panelMenuDescription;
        private Panel panelMenuName;
        private Panel panelMenuType;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private TableLayoutPanel addButtonSpacer;
        private TableLayoutPanel typeBtnSpacer;
        private Panel menuNameSpacer;
        private Panel menuTypeSpacer;
        private Panel panel2;
        private Panel panel1;
        private DataGridView dataGridViewCategories;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private Panel panelDataGridView;
    }
}