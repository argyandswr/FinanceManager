﻿namespace PersonalFinanceManager.View
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
            panel1 = new Panel();
            transaction_deleteBtn = new Button();
            transaction_updateBtn = new Button();
            transaction_addBtn = new Button();
            transactionAmount_txt = new TextBox();
            label4 = new Label();
            transactionDate = new DateTimePicker();
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
            panel1.Controls.Add(transaction_deleteBtn);
            panel1.Controls.Add(transaction_updateBtn);
            panel1.Controls.Add(transaction_addBtn);
            panel1.Controls.Add(transactionAmount_txt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(transactionDate);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(transactionName_txt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(transactionCategory);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(17, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 732);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // transaction_deleteBtn
            // 
            transaction_deleteBtn.BackColor = Color.Pink;
            transaction_deleteBtn.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transaction_deleteBtn.ForeColor = SystemColors.ActiveCaptionText;
            transaction_deleteBtn.Location = new Point(25, 477);
            transaction_deleteBtn.Name = "transaction_deleteBtn";
            transaction_deleteBtn.Size = new Size(262, 39);
            transaction_deleteBtn.TabIndex = 7;
            transaction_deleteBtn.Text = "Delete";
            transaction_deleteBtn.UseVisualStyleBackColor = false;
            // 
            // transaction_updateBtn
            // 
            transaction_updateBtn.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transaction_updateBtn.ForeColor = SystemColors.ActiveCaptionText;
            transaction_updateBtn.Location = new Point(171, 399);
            transaction_updateBtn.Name = "transaction_updateBtn";
            transaction_updateBtn.Size = new Size(116, 39);
            transaction_updateBtn.TabIndex = 6;
            transaction_updateBtn.Text = "Update";
            transaction_updateBtn.UseVisualStyleBackColor = true;
            // 
            // transaction_addBtn
            // 
            transaction_addBtn.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transaction_addBtn.ForeColor = SystemColors.ActiveCaptionText;
            transaction_addBtn.Location = new Point(25, 399);
            transaction_addBtn.Name = "transaction_addBtn";
            transaction_addBtn.Size = new Size(116, 39);
            transaction_addBtn.TabIndex = 2;
            transaction_addBtn.Text = "Add";
            transaction_addBtn.UseVisualStyleBackColor = true;
            transaction_addBtn.Click += transaction_addBtn_Click;
            // 
            // transactionAmount_txt
            // 
            transactionAmount_txt.Location = new Point(12, 329);
            transactionAmount_txt.Name = "transactionAmount_txt";
            transactionAmount_txt.Size = new Size(285, 27);
            transactionAmount_txt.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AliceBlue;
            label4.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(12, 295);
            label4.Name = "label4";
            label4.Size = new Size(97, 31);
            label4.TabIndex = 5;
            label4.Text = "Amount";
            // 
            // transactionDate
            // 
            transactionDate.Location = new Point(12, 234);
            transactionDate.Name = "transactionDate";
            transactionDate.Size = new Size(285, 27);
            transactionDate.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AliceBlue;
            label3.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 200);
            label3.Name = "label3";
            label3.Size = new Size(63, 31);
            label3.TabIndex = 3;
            label3.Text = "Date";
            // 
            // transactionName_txt
            // 
            transactionName_txt.Location = new Point(12, 61);
            transactionName_txt.Name = "transactionName_txt";
            transactionName_txt.Size = new Size(285, 27);
            transactionName_txt.TabIndex = 0;
            transactionName_txt.TextChanged += transactionName_txt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(201, 31);
            label2.TabIndex = 2;
            label2.Text = "Transaction Name";
            label2.Click += label2_Click;
            // 
            // transactionCategory
            // 
            transactionCategory.FormattingEnabled = true;
            transactionCategory.Items.AddRange(new object[] { "Income", "Expense" });
            transactionCategory.Location = new Point(12, 146);
            transactionCategory.Name = "transactionCategory";
            transactionCategory.Size = new Size(285, 28);
            transactionCategory.TabIndex = 1;
            transactionCategory.TabStop = false;
            transactionCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AliceBlue;
            label1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 112);
            label1.Name = "label1";
            label1.Size = new Size(109, 31);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label5);
            panel2.ForeColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(350, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(492, 732);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Location = new Point(14, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(463, 630);
            dataGridView1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AliceBlue;
            label5.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(23, 27);
            label5.Name = "label5";
            label5.Size = new Size(174, 31);
            label5.TabIndex = 8;
            label5.Text = "Transaction List";
            // 
            // TransactionForm
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TransactionForm";
            Size = new Size(861, 830);
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
        private DateTimePicker transactionDate;
        private Label label3;
        private Button transaction_deleteBtn;
        private Button transaction_updateBtn;
        private Button transaction_addBtn;
        private TextBox transactionAmount_txt;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label5;
    }
}
