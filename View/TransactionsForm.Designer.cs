namespace PersonalFinanceManager.View
{
    partial class transactionsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            dataGridViewTransactions = new DataGridView();
            tableLayoutMain = new TableLayoutPanel();
            panelMainRight = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel3 = new Panel();
            comboBoxCategory = new ComboBox();
            labelCategory = new Label();
            panel4 = new Panel();
            textBoxName = new TextBox();
            labelName = new Label();
            panel5 = new Panel();
            timePicker = new DateTimePicker();
            datePicker = new DateTimePicker();
            labelDate = new Label();
            panel6 = new Panel();
            textBoxAmount = new TextBox();
            labelAmount = new Label();
            panel7 = new Panel();
            comboBoxType = new ComboBox();
            labelType = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            panelMainLeft = new Panel();
            panelGridView = new Panel();
            panelBtnCustom = new Panel();
            btnOk = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            btnCustom = new FontAwesome.Sharp.IconButton();
            btnToday = new FontAwesome.Sharp.IconButton();
            btnLast7Days = new FontAwesome.Sharp.IconButton();
            tableLayoutPanelTopButton = new TableLayoutPanel();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).BeginInit();
            tableLayoutMain.SuspendLayout();
            panelMainRight.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelMainLeft.SuspendLayout();
            panelGridView.SuspendLayout();
            panelBtnCustom.SuspendLayout();
            tableLayoutPanelTopButton.SuspendLayout();
            SuspendLayout();
            // 
            // iconSplitButton1
            // 
            iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSplitButton1.IconColor = Color.Black;
            iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSplitButton1.IconSize = 48;
            iconSplitButton1.Name = "iconSplitButton1";
            iconSplitButton1.Rotation = 0D;
            iconSplitButton1.Size = new Size(23, 23);
            iconSplitButton1.Text = "iconSplitButton1";
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
            btnDelete.Location = new Point(419, 558);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 45);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewTransactions
            // 
            dataGridViewTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTransactions.BackgroundColor = Color.FromArgb(236, 239, 244);
            dataGridViewTransactions.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(236, 242, 253);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(46, 52, 64);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(94, 129, 172);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(248, 249, 251);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(216, 222, 233);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(46, 52, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(94, 129, 172);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(248, 249, 251);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewTransactions.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTransactions.GridColor = Color.Black;
            dataGridViewTransactions.Location = new Point(0, 68);
            dataGridViewTransactions.Margin = new Padding(0);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(236, 242, 253);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(94, 129, 172);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(248, 249, 251);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTransactions.RowHeadersWidth = 62;
            dataGridViewTransactions.Size = new Size(582, 576);
            dataGridViewTransactions.TabIndex = 4;
            dataGridViewTransactions.RowHeaderMouseClick += dataGridViewTransactions_RowHeaderMouseClick;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 2;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutMain.Controls.Add(panelMainRight, 1, 0);
            tableLayoutMain.Controls.Add(panelMainLeft, 0, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.Padding = new Padding(10);
            tableLayoutMain.RowCount = 1;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.Size = new Size(860, 670);
            tableLayoutMain.TabIndex = 9;
            // 
            // panelMainRight
            // 
            panelMainRight.BackColor = Color.FromArgb(206, 212, 223);
            panelMainRight.Controls.Add(tableLayoutPanel3);
            panelMainRight.Controls.Add(tableLayoutPanel2);
            panelMainRight.Dock = DockStyle.Fill;
            panelMainRight.Location = new Point(603, 15);
            panelMainRight.Margin = new Padding(5);
            panelMainRight.Name = "panelMainRight";
            panelMainRight.Size = new Size(242, 640);
            panelMainRight.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(216, 222, 233);
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel3, 0, 3);
            tableLayoutPanel3.Controls.Add(panel4, 0, 1);
            tableLayoutPanel3.Controls.Add(panel5, 0, 4);
            tableLayoutPanel3.Controls.Add(panel6, 0, 5);
            tableLayoutPanel3.Controls.Add(panel7, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 7;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 2.96331358F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6037178F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6037178F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.60463F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 27.6575928F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6037178F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 2.96331358F));
            tableLayoutPanel3.Size = new Size(242, 498);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(comboBoxCategory);
            panel3.Controls.Add(labelCategory);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 181);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 76);
            panel3.TabIndex = 1;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCategory.BackColor = SystemColors.Window;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(15, 38);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(206, 33);
            comboBoxCategory.TabIndex = 3;
            // 
            // labelCategory
            // 
            labelCategory.Dock = DockStyle.Top;
            labelCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCategory.ForeColor = Color.FromArgb(59, 66, 82);
            labelCategory.Location = new Point(0, 0);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(236, 25);
            labelCategory.TabIndex = 2;
            labelCategory.Text = "Category";
            labelCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBoxName);
            panel4.Controls.Add(labelName);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 17);
            panel4.Name = "panel4";
            panel4.Size = new Size(236, 76);
            panel4.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.BackColor = SystemColors.Window;
            textBoxName.Location = new Point(15, 40);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(206, 31);
            textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.Dock = DockStyle.Top;
            labelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelName.ForeColor = Color.FromArgb(59, 66, 82);
            labelName.Location = new Point(0, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(236, 25);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(timePicker);
            panel5.Controls.Add(datePicker);
            panel5.Controls.Add(labelDate);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 263);
            panel5.Name = "panel5";
            panel5.Size = new Size(236, 131);
            panel5.TabIndex = 3;
            // 
            // timePicker
            // 
            timePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            timePicker.CalendarTrailingForeColor = Color.FromArgb(59, 66, 82);
            timePicker.Location = new Point(15, 88);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(206, 31);
            timePicker.TabIndex = 5;
            // 
            // datePicker
            // 
            datePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datePicker.CalendarTrailingForeColor = Color.FromArgb(59, 66, 82);
            datePicker.Location = new Point(15, 40);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(206, 31);
            datePicker.TabIndex = 4;
            // 
            // labelDate
            // 
            labelDate.Dock = DockStyle.Top;
            labelDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelDate.ForeColor = Color.FromArgb(59, 66, 82);
            labelDate.Location = new Point(0, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(236, 25);
            labelDate.TabIndex = 3;
            labelDate.Text = "Date";
            labelDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.Controls.Add(textBoxAmount);
            panel6.Controls.Add(labelAmount);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 400);
            panel6.Name = "panel6";
            panel6.Size = new Size(236, 76);
            panel6.TabIndex = 4;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAmount.BackColor = SystemColors.Window;
            textBoxAmount.Location = new Point(15, 40);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(206, 31);
            textBoxAmount.TabIndex = 2;
            textBoxAmount.KeyPress += textBoxAmount_KeyPress;
            // 
            // labelAmount
            // 
            labelAmount.Dock = DockStyle.Top;
            labelAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAmount.ForeColor = Color.FromArgb(59, 66, 82);
            labelAmount.Location = new Point(0, 0);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(236, 25);
            labelAmount.TabIndex = 4;
            labelAmount.Text = "Amount";
            labelAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.Controls.Add(comboBoxType);
            panel7.Controls.Add(labelType);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 99);
            panel7.Name = "panel7";
            panel7.Size = new Size(236, 76);
            panel7.TabIndex = 5;
            // 
            // comboBoxType
            // 
            comboBoxType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxType.BackColor = SystemColors.Window;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Expense", "Income" });
            comboBoxType.Location = new Point(15, 38);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(206, 33);
            comboBoxType.TabIndex = 2;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // labelType
            // 
            labelType.Dock = DockStyle.Top;
            labelType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelType.ForeColor = Color.FromArgb(59, 66, 82);
            labelType.Location = new Point(0, 0);
            labelType.Name = "labelType";
            labelType.Size = new Size(236, 25);
            labelType.TabIndex = 1;
            labelType.Text = "Type";
            labelType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(216, 222, 233);
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 498);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(242, 142);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnUpdate);
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(51, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(139, 136);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(76, 86, 106);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.FromArgb(236, 239, 244);
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnUpdate.IconColor = Color.FromArgb(236, 239, 244);
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.IconSize = 32;
            btnUpdate.Location = new Point(5, 5);
            btnUpdate.Margin = new Padding(5, 5, 5, 10);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 45);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(76, 86, 106);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(236, 239, 244);
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAdd.IconColor = Color.FromArgb(236, 239, 244);
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 32;
            btnAdd.Location = new Point(5, 65);
            btnAdd.Margin = new Padding(5, 5, 5, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 45);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panelMainLeft
            // 
            panelMainLeft.Controls.Add(panelGridView);
            panelMainLeft.Dock = DockStyle.Fill;
            panelMainLeft.Location = new Point(13, 13);
            panelMainLeft.Name = "panelMainLeft";
            panelMainLeft.Size = new Size(582, 644);
            panelMainLeft.TabIndex = 6;
            // 
            // panelGridView
            // 
            panelGridView.Controls.Add(panelBtnCustom);
            panelGridView.Controls.Add(btnToday);
            panelGridView.Controls.Add(btnLast7Days);
            panelGridView.Controls.Add(tableLayoutPanelTopButton);
            panelGridView.Controls.Add(dataGridViewTransactions);
            panelGridView.Controls.Add(btnDelete);
            panelGridView.Dock = DockStyle.Fill;
            panelGridView.Location = new Point(0, 0);
            panelGridView.Name = "panelGridView";
            panelGridView.Size = new Size(582, 644);
            panelGridView.TabIndex = 11;
            // 
            // panelBtnCustom
            // 
            panelBtnCustom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelBtnCustom.Controls.Add(btnOk);
            panelBtnCustom.Controls.Add(label2);
            panelBtnCustom.Controls.Add(label1);
            panelBtnCustom.Controls.Add(dateTimePickerEnd);
            panelBtnCustom.Controls.Add(dateTimePickerStart);
            panelBtnCustom.Controls.Add(btnCustom);
            panelBtnCustom.Location = new Point(453, 0);
            panelBtnCustom.Margin = new Padding(0);
            panelBtnCustom.MaximumSize = new Size(120, 290);
            panelBtnCustom.MinimumSize = new Size(120, 50);
            panelBtnCustom.Name = "panelBtnCustom";
            panelBtnCustom.Size = new Size(120, 52);
            panelBtnCustom.TabIndex = 12;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(76, 86, 106);
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOk.ForeColor = Color.FromArgb(236, 239, 244);
            btnOk.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            btnOk.IconColor = Color.FromArgb(236, 239, 244);
            btnOk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOk.IconSize = 32;
            btnOk.Location = new Point(0, 232);
            btnOk.Margin = new Padding(0, 10, 0, 15);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(120, 40);
            btnOk.TabIndex = 17;
            btnOk.Text = "Ok";
            btnOk.TextAlign = ContentAlignment.MiddleRight;
            btnOk.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(0, 143);
            label2.Name = "label2";
            label2.Size = new Size(120, 31);
            label2.TabIndex = 16;
            label2.Text = "End Date";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(0, 63);
            label1.Name = "label1";
            label1.Size = new Size(120, 31);
            label1.TabIndex = 15;
            label1.Text = "Start Date";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(3, 180);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(114, 31);
            dateTimePickerEnd.TabIndex = 14;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(3, 102);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(114, 31);
            dateTimePickerStart.TabIndex = 13;
            // 
            // btnCustom
            // 
            btnCustom.BackColor = Color.FromArgb(76, 86, 106);
            btnCustom.FlatAppearance.BorderSize = 0;
            btnCustom.FlatStyle = FlatStyle.Flat;
            btnCustom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCustom.ForeColor = Color.FromArgb(236, 239, 244);
            btnCustom.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            btnCustom.IconColor = Color.FromArgb(236, 239, 244);
            btnCustom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCustom.IconSize = 32;
            btnCustom.Location = new Point(0, 10);
            btnCustom.Margin = new Padding(0, 10, 0, 15);
            btnCustom.Name = "btnCustom";
            btnCustom.Size = new Size(120, 40);
            btnCustom.TabIndex = 12;
            btnCustom.Text = "Custom";
            btnCustom.TextAlign = ContentAlignment.MiddleRight;
            btnCustom.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustom.UseVisualStyleBackColor = false;
            btnCustom.Click += btnCustom_Click;
            // 
            // btnToday
            // 
            btnToday.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnToday.BackColor = Color.FromArgb(76, 86, 106);
            btnToday.FlatAppearance.BorderSize = 0;
            btnToday.FlatStyle = FlatStyle.Flat;
            btnToday.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnToday.ForeColor = Color.FromArgb(236, 239, 244);
            btnToday.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            btnToday.IconColor = Color.FromArgb(236, 239, 244);
            btnToday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnToday.IconSize = 32;
            btnToday.Location = new Point(172, 10);
            btnToday.Margin = new Padding(0, 10, 0, 15);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(105, 40);
            btnToday.TabIndex = 10;
            btnToday.Text = "Today";
            btnToday.TextAlign = ContentAlignment.MiddleRight;
            btnToday.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnToday.UseVisualStyleBackColor = false;
            btnToday.Click += btnToday_Click;
            // 
            // btnLast7Days
            // 
            btnLast7Days.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLast7Days.BackColor = Color.FromArgb(76, 86, 106);
            btnLast7Days.FlatAppearance.BorderSize = 0;
            btnLast7Days.FlatStyle = FlatStyle.Flat;
            btnLast7Days.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLast7Days.ForeColor = Color.FromArgb(236, 239, 244);
            btnLast7Days.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            btnLast7Days.IconColor = Color.FromArgb(236, 239, 244);
            btnLast7Days.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLast7Days.IconSize = 32;
            btnLast7Days.Location = new Point(290, 10);
            btnLast7Days.Margin = new Padding(0, 10, 0, 15);
            btnLast7Days.Name = "btnLast7Days";
            btnLast7Days.Size = new Size(150, 40);
            btnLast7Days.TabIndex = 11;
            btnLast7Days.Text = "Last 7 Days";
            btnLast7Days.TextAlign = ContentAlignment.MiddleRight;
            btnLast7Days.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLast7Days.UseVisualStyleBackColor = false;
            btnLast7Days.Click += btnLast7Days_Click;
            // 
            // tableLayoutPanelTopButton
            // 
            tableLayoutPanelTopButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelTopButton.BackColor = Color.FromArgb(236, 239, 244);
            tableLayoutPanelTopButton.ColumnCount = 3;
            tableLayoutPanelTopButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTopButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanelTopButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTopButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelTopButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelTopButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelTopButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelTopButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelTopButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelTopButton.Controls.Add(btnRefresh, 1, 0);
            tableLayoutPanelTopButton.Location = new Point(0, 0);
            tableLayoutPanelTopButton.Name = "tableLayoutPanelTopButton";
            tableLayoutPanelTopButton.RowCount = 1;
            tableLayoutPanelTopButton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelTopButton.Size = new Size(169, 65);
            tableLayoutPanelTopButton.TabIndex = 10;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(76, 86, 106);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.FromArgb(236, 239, 244);
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.FromArgb(236, 239, 244);
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 32;
            btnRefresh.Location = new Point(24, 10);
            btnRefresh.Margin = new Padding(0, 10, 0, 15);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 40);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // transactionsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 239, 244);
            ClientSize = new Size(860, 670);
            Controls.Add(tableLayoutMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "transactionsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TransactionsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).EndInit();
            tableLayoutMain.ResumeLayout(false);
            panelMainRight.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panelMainLeft.ResumeLayout(false);
            panelGridView.ResumeLayout(false);
            panelBtnCustom.ResumeLayout(false);
            tableLayoutPanelTopButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private FontAwesome.Sharp.IconButton btnDelete;
        private DataGridView dataGridViewTransactions;
        private TableLayoutPanel tableLayoutMain;
        private Panel panelMainRight;
        private Panel panelMainLeft;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelName;
        private Panel panel3;
        private Label labelCategory;
        private Panel panel4;
        private TextBox textBoxName;
        private Panel panel5;
        private Label labelDate;
        private Panel panel6;
        private TextBox textBoxAmount;
        private Label labelAmount;
        private Panel panel7;
        private Label labelType;
        private ComboBox comboBoxCategory;
        private DateTimePicker timePicker;
        private DateTimePicker datePicker;
        private ComboBox comboBoxType;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private TableLayoutPanel tableLayoutPanelTopButton;
        private Panel panelGridView;
        private FontAwesome.Sharp.IconButton btnLast7Days;
        private FontAwesome.Sharp.IconButton btnToday;
        private FontAwesome.Sharp.IconButton btnCustom;
        private Panel panelBtnCustom;
        private Label label1;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnOk;
    }
}