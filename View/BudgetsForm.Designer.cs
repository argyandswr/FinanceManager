namespace PersonalFinanceManager.View
{
    partial class budgetsForm
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
            btnRefresh = new FontAwesome.Sharp.IconButton();
            dataGridViewCategories = new DataGridView();
            categoryLabel = new Label();
            comboBoxCategory = new ComboBox();
            amountLabel = new Label();
            textBoxAmount = new TextBox();
            startdateLabel = new Label();
            startDate = new DateTimePicker();
            endDate = new DateTimePicker();
            enddateLabel = new Label();
            btnDelete = new FontAwesome.Sharp.IconButton();
            comboBoxStatus = new ComboBox();
            statusLabel = new Label();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.AllowDrop = true;
            btnRefresh.BackColor = Color.FromArgb(76, 86, 106);
            btnRefresh.Dock = DockStyle.Left;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.FromArgb(236, 239, 244);
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.FromArgb(236, 239, 244);
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 32;
            btnRefresh.Location = new Point(375, 0);
            btnRefresh.Margin = new Padding(0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 44);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.BackgroundColor = Color.FromArgb(236, 239, 244);
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Location = new Point(1, 62);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.RowHeadersWidth = 51;
            dataGridViewCategories.Size = new Size(485, 230);
            dataGridViewCategories.TabIndex = 11;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            categoryLabel.Location = new Point(6, 300);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(73, 20);
            categoryLabel.TabIndex = 12;
            categoryLabel.Text = "Category";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(9, 323);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(150, 28);
            comboBoxCategory.TabIndex = 13;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            amountLabel.Location = new Point(6, 364);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(67, 20);
            amountLabel.TabIndex = 14;
            amountLabel.Text = "Amount";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(9, 392);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(150, 27);
            textBoxAmount.TabIndex = 15;
            // 
            // startdateLabel
            // 
            startdateLabel.AutoSize = true;
            startdateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            startdateLabel.Location = new Point(165, 300);
            startdateLabel.Name = "startdateLabel";
            startdateLabel.Size = new Size(80, 20);
            startdateLabel.TabIndex = 16;
            startdateLabel.Text = "Start Date";
            // 
            // startDate
            // 
            startDate.Location = new Point(171, 324);
            startDate.Name = "startDate";
            startDate.Size = new Size(139, 27);
            startDate.TabIndex = 17;
            // 
            // endDate
            // 
            endDate.Location = new Point(171, 392);
            endDate.Name = "endDate";
            endDate.Size = new Size(139, 27);
            endDate.TabIndex = 19;
            // 
            // enddateLabel
            // 
            enddateLabel.AutoSize = true;
            enddateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            enddateLabel.Location = new Point(165, 368);
            enddateLabel.Name = "enddateLabel";
            enddateLabel.Size = new Size(72, 20);
            enddateLabel.TabIndex = 18;
            enddateLabel.Text = "End Date";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(76, 86, 106);
            btnDelete.Dock = DockStyle.Right;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(236, 239, 244);
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnDelete.IconColor = Color.FromArgb(236, 239, 244);
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 32;
            btnDelete.Location = new Point(0, 0);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 44);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(327, 323);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(150, 28);
            comboBoxStatus.TabIndex = 24;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            statusLabel.Location = new Point(324, 300);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(53, 20);
            statusLabel.TabIndex = 23;
            statusLabel.Text = "Status";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(76, 86, 106);
            btnUpdate.Dock = DockStyle.Top;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.FromArgb(236, 239, 244);
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnUpdate.IconColor = Color.FromArgb(236, 239, 244);
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.IconSize = 32;
            btnUpdate.Location = new Point(0, 50);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(159, 36);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(76, 86, 106);
            btnAdd.Dock = DockStyle.Top;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(236, 239, 244);
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAdd.IconColor = Color.FromArgb(236, 239, 244);
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 32;
            btnAdd.Location = new Point(0, 0);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(159, 36);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AllowDrop = true;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Center;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnRefresh, 0, 0);
            tableLayoutPanel1.Controls.Add(btnDelete, 1, 0);
            tableLayoutPanel1.Location = new Point(1, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(485, 44);
            tableLayoutPanel1.TabIndex = 27;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AllowDrop = true;
            tableLayoutPanel2.BackgroundImageLayout = ImageLayout.Center;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(iconButton1, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.AllowDrop = true;
            iconButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            iconButton1.BackColor = Color.FromArgb(76, 86, 106);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            iconButton1.ForeColor = Color.FromArgb(236, 239, 244);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            iconButton1.IconColor = Color.FromArgb(236, 239, 244);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(100, 64);
            iconButton1.Margin = new Padding(0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(100, 36);
            iconButton1.TabIndex = 10;
            iconButton1.Text = "Refresh";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            iconButton2.BackColor = Color.FromArgb(76, 86, 106);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            iconButton2.ForeColor = Color.FromArgb(236, 239, 244);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconButton2.IconColor = Color.FromArgb(236, 239, 244);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.Location = new Point(0, 64);
            iconButton2.Margin = new Padding(0);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(100, 36);
            iconButton2.TabIndex = 22;
            iconButton2.Text = "Delete";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AccessibleRole = AccessibleRole.None;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel3.Controls.Add(btnUpdate, 0, 1);
            tableLayoutPanel3.Location = new Point(327, 364);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(159, 100);
            tableLayoutPanel3.TabIndex = 28;
            // 
            // budgetsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 239, 244);
            ClientSize = new Size(489, 468);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(comboBoxStatus);
            Controls.Add(statusLabel);
            Controls.Add(endDate);
            Controls.Add(enddateLabel);
            Controls.Add(startDate);
            Controls.Add(startdateLabel);
            Controls.Add(textBoxAmount);
            Controls.Add(amountLabel);
            Controls.Add(comboBoxCategory);
            Controls.Add(categoryLabel);
            Controls.Add(dataGridViewCategories);
            Margin = new Padding(2);
            Name = "budgetsForm";
            Text = "BudgetsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRefresh;
        private DataGridView dataGridViewCategories;
        private Label categoryLabel;
        private ComboBox comboBoxCategory;
        private Label amountLabel;
        private TextBox textBoxAmount;
        private Label startdateLabel;
        private DateTimePicker startDate;
        private DateTimePicker endDate;
        private Label enddateLabel;
        private FontAwesome.Sharp.IconButton btnDelete;
        private ComboBox comboBoxStatus;
        private Label statusLabel;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnAdd;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}