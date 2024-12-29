namespace PersonalFinanceManager.View
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
            panel1 = new Panel();
            panel2 = new Panel();
            LogOut_Btn = new Button();
            Report_Btn = new Button();
            Budgeting_Btn = new Button();
            Transaction_Btn = new Button();
            Dashboard_Btn = new Button();
            panel3 = new Panel();
            reportForm1 = new ReportForm();
            budgetingForm1 = new BudgetingForm();
            dashboardForm1 = new DashboardForm();
            transactionForm1 = new TransactionForm();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 830);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(LogOut_Btn);
            panel2.Controls.Add(Report_Btn);
            panel2.Controls.Add(Budgeting_Btn);
            panel2.Controls.Add(Transaction_Btn);
            panel2.Controls.Add(Dashboard_Btn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 830);
            panel2.TabIndex = 1;
            // 
            // LogOut_Btn
            // 
            LogOut_Btn.BackColor = Color.AliceBlue;
            LogOut_Btn.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOut_Btn.Location = new Point(3, 710);
            LogOut_Btn.Name = "LogOut_Btn";
            LogOut_Btn.Size = new Size(269, 55);
            LogOut_Btn.TabIndex = 2;
            LogOut_Btn.Text = "Log Out";
            LogOut_Btn.UseVisualStyleBackColor = false;
            LogOut_Btn.Click += LogOut_Btn_Click;
            // 
            // Report_Btn
            // 
            Report_Btn.BackColor = Color.LightBlue;
            Report_Btn.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Report_Btn.Location = new Point(0, 466);
            Report_Btn.Name = "Report_Btn";
            Report_Btn.Size = new Size(275, 106);
            Report_Btn.TabIndex = 5;
            Report_Btn.Text = "Report Page";
            Report_Btn.UseVisualStyleBackColor = false;
            Report_Btn.Click += Report_Btn_Click;
            // 
            // Budgeting_Btn
            // 
            Budgeting_Btn.BackColor = Color.LightBlue;
            Budgeting_Btn.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Budgeting_Btn.Location = new Point(0, 312);
            Budgeting_Btn.Name = "Budgeting_Btn";
            Budgeting_Btn.Size = new Size(275, 106);
            Budgeting_Btn.TabIndex = 4;
            Budgeting_Btn.Text = "Budgeting Page";
            Budgeting_Btn.UseVisualStyleBackColor = false;
            Budgeting_Btn.Click += button1_Click_1;
            // 
            // Transaction_Btn
            // 
            Transaction_Btn.BackColor = Color.LightBlue;
            Transaction_Btn.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Transaction_Btn.Location = new Point(0, 154);
            Transaction_Btn.Name = "Transaction_Btn";
            Transaction_Btn.Size = new Size(275, 106);
            Transaction_Btn.TabIndex = 3;
            Transaction_Btn.Text = "Transaction";
            Transaction_Btn.UseVisualStyleBackColor = false;
            Transaction_Btn.Click += Transaction_Btn_Click;
            // 
            // Dashboard_Btn
            // 
            Dashboard_Btn.BackColor = Color.LightBlue;
            Dashboard_Btn.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboard_Btn.Location = new Point(0, 0);
            Dashboard_Btn.Name = "Dashboard_Btn";
            Dashboard_Btn.Size = new Size(275, 106);
            Dashboard_Btn.TabIndex = 2;
            Dashboard_Btn.Text = "Dashboard ";
            Dashboard_Btn.UseVisualStyleBackColor = false;
            Dashboard_Btn.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(reportForm1);
            panel3.Controls.Add(budgetingForm1);
            panel3.Controls.Add(dashboardForm1);
            panel3.Controls.Add(transactionForm1);
            panel3.Location = new Point(278, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(861, 830);
            panel3.TabIndex = 2;
            // 
            // reportForm1
            // 
            reportForm1.BackColor = SystemColors.ControlLightLight;
            reportForm1.Location = new Point(0, 3);
            reportForm1.Name = "reportForm1";
            reportForm1.Size = new Size(865, 1038);
            reportForm1.TabIndex = 3;
            // 
            // budgetingForm1
            // 
            budgetingForm1.BackColor = SystemColors.ControlLightLight;
            budgetingForm1.Location = new Point(0, 0);
            budgetingForm1.Name = "budgetingForm1";
            budgetingForm1.Size = new Size(865, 1038);
            budgetingForm1.TabIndex = 3;
            // 
            // dashboardForm1
            // 
            dashboardForm1.BackColor = Color.AliceBlue;
            dashboardForm1.Location = new Point(0, 3);
            dashboardForm1.Name = "dashboardForm1";
            dashboardForm1.Size = new Size(865, 1038);
            dashboardForm1.TabIndex = 1;
            // 
            // transactionForm1
            // 
            transactionForm1.AccessibleName = "";
            transactionForm1.BackColor = Color.White;
            transactionForm1.Location = new Point(0, 3);
            transactionForm1.Name = "transactionForm1";
            transactionForm1.Size = new Size(865, 1038);
            transactionForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 830);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button Dashboard_Btn;
        private Button Budgeting_Btn;
        private Button Transaction_Btn;
        private Button LogOut_Btn;
        private Button Report_Btn;
        private Panel panel3;
        private TransactionForm transactionForm1;
        private DashboardForm dashboardForm1;
        private ReportForm reportForm1;
        private BudgetingForm budgetingForm1;
    }
}