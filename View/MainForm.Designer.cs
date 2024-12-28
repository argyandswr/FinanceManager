namespace PersonalFinanceManager
{
    partial class MainForm
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
            button1 = new Button();
            addTransactionBtn = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(403, 78);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // addTransactionBtn
            // 
            addTransactionBtn.Location = new Point(403, 146);
            addTransactionBtn.Name = "addTransactionBtn";
            addTransactionBtn.Size = new Size(160, 34);
            addTransactionBtn.TabIndex = 1;
            addTransactionBtn.Text = "Add Transaction";
            addTransactionBtn.UseVisualStyleBackColor = true;
            addTransactionBtn.Click += addTransactionBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(403, 221);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(403, 293);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1606, 908);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(addTransactionBtn);
            Controls.Add(button1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button addTransactionBtn;
        private Button button3;
        private Button button4;
    }
}