namespace PersonalFinanceManager.View
{
    partial class TransactionForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            transactionType = new ComboBox();
            label6 = new Label();
            transactionTimePicker = new DateTimePicker();
            transaction_deleteBtn = new Button();
            transaction_updateBtn = new Button();
            transaction_addBtn = new Button();
            transactionAmount_txt = new TextBox();
            label4 = new Label();
            transactionDatePicker = new DateTimePicker();
            label3 = new Label();
            transactionName_txt = new TextBox();
            label2 = new Label();
            transactionCategory = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(transactionType);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(transactionTimePicker);
            panel1.Controls.Add(transaction_deleteBtn);
            panel1.Controls.Add(transaction_updateBtn);
            panel1.Controls.Add(transaction_addBtn);
            panel1.Controls.Add(transactionAmount_txt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(transactionDatePicker);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(transactionName_txt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(transactionCategory);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(21, 54);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 915);
            panel1.TabIndex = 0;
            // 
            // transactionType
            // 
            transactionType.FormattingEnabled = true;
            transactionType.Items.AddRange(new object[] { "Income", "Expense" });
            transactionType.Location = new Point(15, 179);
            transactionType.Margin = new Padding(4);
            transactionType.Name = "transactionType";
            transactionType.Size = new Size(355, 33);
            transactionType.TabIndex = 9;
            transactionType.TabStop = false;
            transactionType.SelectedIndexChanged += transactionType_SelectedIndexChanged;
            transactionType.SelectionChangeCommitted += transactionType_SelectionChangeCommitted;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AliceBlue;
            label6.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(15, 130);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 38);
            label6.TabIndex = 8;
            label6.Text = "Type";
            // 
            // transactionTimePicker
            // 
            transactionTimePicker.Location = new Point(15, 438);
            transactionTimePicker.Name = "transactionTimePicker";
            transactionTimePicker.Size = new Size(300, 31);
            transactionTimePicker.TabIndex = 2;
            // 
            // transaction_deleteBtn
            // 
            transaction_deleteBtn.BackColor = Color.Pink;
            transaction_deleteBtn.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transaction_deleteBtn.ForeColor = SystemColors.ActiveCaptionText;
            transaction_deleteBtn.Location = new Point(31, 734);
            transaction_deleteBtn.Margin = new Padding(4);
            transaction_deleteBtn.Name = "transaction_deleteBtn";
            transaction_deleteBtn.Size = new Size(328, 49);
            transaction_deleteBtn.TabIndex = 7;
            transaction_deleteBtn.Text = "Delete";
            transaction_deleteBtn.UseVisualStyleBackColor = false;
            // 
            // transaction_updateBtn
            // 
            transaction_updateBtn.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transaction_updateBtn.ForeColor = SystemColors.ActiveCaptionText;
            transaction_updateBtn.Location = new Point(214, 637);
            transaction_updateBtn.Margin = new Padding(4);
            transaction_updateBtn.Name = "transaction_updateBtn";
            transaction_updateBtn.Size = new Size(145, 49);
            transaction_updateBtn.TabIndex = 6;
            transaction_updateBtn.Text = "Update";
            transaction_updateBtn.UseVisualStyleBackColor = true;
            transaction_updateBtn.Click += transaction_updateBtn_Click;
            // 
            // transaction_addBtn
            // 
            transaction_addBtn.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transaction_addBtn.ForeColor = SystemColors.ActiveCaptionText;
            transaction_addBtn.Location = new Point(31, 637);
            transaction_addBtn.Margin = new Padding(4);
            transaction_addBtn.Name = "transaction_addBtn";
            transaction_addBtn.Size = new Size(145, 49);
            transaction_addBtn.TabIndex = 2;
            transaction_addBtn.Text = "Add";
            transaction_addBtn.UseVisualStyleBackColor = true;
            transaction_addBtn.Click += transaction_addBtn_Click;
            // 
            // transactionAmount_txt
            // 
            transactionAmount_txt.Location = new Point(15, 549);
            transactionAmount_txt.Margin = new Padding(4);
            transactionAmount_txt.Name = "transactionAmount_txt";
            transactionAmount_txt.Size = new Size(355, 31);
            transactionAmount_txt.TabIndex = 4;
            transactionAmount_txt.KeyPress += transactionAmount_txt_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AliceBlue;
            label4.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(15, 507);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 38);
            label4.TabIndex = 5;
            label4.Text = "Amount";
            // 
            // transactionDatePicker
            // 
            transactionDatePicker.Location = new Point(15, 395);
            transactionDatePicker.Margin = new Padding(4);
            transactionDatePicker.Name = "transactionDatePicker";
            transactionDatePicker.Size = new Size(355, 31);
            transactionDatePicker.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AliceBlue;
            label3.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(15, 353);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 38);
            label3.TabIndex = 3;
            label3.Text = "Date";
            // 
            // transactionName_txt
            // 
            transactionName_txt.Location = new Point(15, 76);
            transactionName_txt.Margin = new Padding(4);
            transactionName_txt.Name = "transactionName_txt";
            transactionName_txt.Size = new Size(355, 31);
            transactionName_txt.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(15, 34);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(244, 38);
            label2.TabIndex = 2;
            label2.Text = "Transaction Name";
            // 
            // transactionCategory
            // 
            transactionCategory.FormattingEnabled = true;
            transactionCategory.Location = new Point(15, 286);
            transactionCategory.Margin = new Padding(4);
            transactionCategory.Name = "transactionCategory";
            transactionCategory.Size = new Size(355, 33);
            transactionCategory.TabIndex = 1;
            transactionCategory.TabStop = false;
            transactionCategory.SelectedIndexChanged += transactionCategory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AliceBlue;
            label1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(15, 244);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 38);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label5);
            panel2.ForeColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(438, 54);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 915);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(20, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(550, 821);
            dataGridView1.TabIndex = 9;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AliceBlue;
            label5.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(29, 34);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(211, 38);
            label5.TabIndex = 8;
            label5.Text = "Transaction List";
            // 
            // TransactionForm
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "TransactionForm";
            Size = new Size(1034, 1038);
            Load += TransactionForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ComboBox transactionCategory;
        private TextBox transactionName_txt;
        private Label label2;
        private DateTimePicker transactionDatePicker;
        private Label label3;
        private Button transaction_deleteBtn;
        private Button transaction_updateBtn;
        private Button transaction_addBtn;
        private TextBox transactionAmount_txt;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker transactionTimePicker;
        private ComboBox transactionType;
        private DataGridView dataGridView1;
        private Label label7;
    }
}
