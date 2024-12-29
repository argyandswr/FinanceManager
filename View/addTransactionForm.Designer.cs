namespace PersonalFinanceManager.View
{
    partial class addTransactionForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBoxType = new ComboBox();
            datePicker = new DateTimePicker();
            comboBoxCategory = new ComboBox();
            textBoxAmount = new TextBox();
            richTextBoxDescription = new RichTextBox();
            addBtn = new Button();
            timePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 25);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 0;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 78);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 1;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 133);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 183);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 3;
            label4.Text = "Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 237);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Income", "Expense" });
            comboBoxType.Location = new Point(303, 25);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(182, 33);
            comboBoxType.TabIndex = 5;
            // 
            // datePicker
            // 
            datePicker.CustomFormat = "yyyy-MM-dd";
            datePicker.Location = new Point(303, 78);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(300, 31);
            datePicker.TabIndex = 6;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(303, 133);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(182, 33);
            comboBoxCategory.TabIndex = 7;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(303, 183);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(300, 31);
            textBoxAmount.TabIndex = 8;
            textBoxAmount.KeyPress += textBoxAmount_KeyPress;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(303, 237);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(398, 144);
            richTextBoxDescription.TabIndex = 9;
            richTextBoxDescription.Text = "";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(303, 404);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(112, 34);
            addBtn.TabIndex = 10;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // timePicker
            // 
            timePicker.CustomFormat = "hh:mm:ss";
            timePicker.Location = new Point(609, 78);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(179, 31);
            timePicker.TabIndex = 11;
            // 
            // addTransactionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 450);
            Controls.Add(timePicker);
            Controls.Add(addBtn);
            Controls.Add(richTextBoxDescription);
            Controls.Add(textBoxAmount);
            Controls.Add(comboBoxCategory);
            Controls.Add(datePicker);
            Controls.Add(comboBoxType);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "addTransactionForm";
            Text = "Add Transaction";
            Load += addTransactionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxType;
        private DateTimePicker datePicker;
        private ComboBox comboBoxCategory;
        private TextBox textBoxAmount;
        private RichTextBox richTextBoxDescription;
        private Button addBtn;
        private DateTimePicker timePicker;
    }
}