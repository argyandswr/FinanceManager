﻿namespace PersonalFinanceManager.View
{
    partial class dashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chartExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            tableLayoutPanelTop = new TableLayoutPanel();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnToday = new FontAwesome.Sharp.IconButton();
            btnLast7Days = new FontAwesome.Sharp.IconButton();
            tableLayoutPanelBtnRefresh = new TableLayoutPanel();
            btnLast30Days = new FontAwesome.Sharp.IconButton();
            panelBtnCustom = new Panel();
            btnCustom = new FontAwesome.Sharp.IconButton();
            btnOk = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            label8 = new Label();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)chartExpenses).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanelTop.SuspendLayout();
            tableLayoutPanelBtnRefresh.SuspendLayout();
            panelBtnCustom.SuspendLayout();
            SuspendLayout();
            // 
            // chartExpenses
            // 
            chartExpenses.AccessibleRole = AccessibleRole.None;
            chartExpenses.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartExpenses.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartExpenses.Legends.Add(legend1);
            chartExpenses.Location = new Point(12, 175);
            chartExpenses.Name = "chartExpenses";
            chartExpenses.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartExpenses.Series.Add(series1);
            chartExpenses.Size = new Size(413, 272);
            chartExpenses.TabIndex = 0;
            chartExpenses.Text = "chart1";
            title1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Expenses Percentage";
            chartExpenses.Titles.Add(title1);
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(559, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 77);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(0, 34);
            label6.Name = "label6";
            label6.Size = new Size(274, 43);
            label6.TabIndex = 5;
            label6.Text = "0";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(274, 34);
            label5.TabIndex = 4;
            label5.Text = "Total Expenses";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 77);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(0, 34);
            label2.Name = "label2";
            label2.Size = new Size(272, 43);
            label2.TabIndex = 1;
            label2.Text = "0";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(272, 34);
            label1.TabIndex = 0;
            label1.Text = "Total Transactions Recorded";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(281, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(272, 77);
            panel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(0, 34);
            label4.Name = "label4";
            label4.Size = new Size(272, 43);
            label4.TabIndex = 3;
            label4.Text = "0";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(272, 34);
            label3.TabIndex = 2;
            label3.Text = "Total Incomes";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelTop
            // 
            tableLayoutPanelTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelTop.ColumnCount = 3;
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelTop.Controls.Add(panel2, 0, 0);
            tableLayoutPanelTop.Controls.Add(panel1, 2, 0);
            tableLayoutPanelTop.Controls.Add(panel3, 1, 0);
            tableLayoutPanelTop.Location = new Point(12, 86);
            tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            tableLayoutPanelTop.RowCount = 1;
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelTop.Size = new Size(836, 83);
            tableLayoutPanelTop.TabIndex = 4;
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
            btnRefresh.Location = new Point(41, 10);
            btnRefresh.Margin = new Padding(0, 10, 0, 15);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 40);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
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
            btnToday.Location = new Point(218, 22);
            btnToday.Margin = new Padding(0, 10, 0, 15);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(105, 40);
            btnToday.TabIndex = 13;
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
            btnLast7Days.Location = new Point(337, 22);
            btnLast7Days.Margin = new Padding(0, 10, 0, 15);
            btnLast7Days.Name = "btnLast7Days";
            btnLast7Days.Size = new Size(150, 40);
            btnLast7Days.TabIndex = 14;
            btnLast7Days.Text = "Last 7 Days";
            btnLast7Days.TextAlign = ContentAlignment.MiddleRight;
            btnLast7Days.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLast7Days.UseVisualStyleBackColor = false;
            btnLast7Days.Click += btnLast7Days_Click;
            // 
            // tableLayoutPanelBtnRefresh
            // 
            tableLayoutPanelBtnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelBtnRefresh.ColumnCount = 3;
            tableLayoutPanelBtnRefresh.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelBtnRefresh.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanelBtnRefresh.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelBtnRefresh.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelBtnRefresh.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelBtnRefresh.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelBtnRefresh.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelBtnRefresh.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelBtnRefresh.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelBtnRefresh.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelBtnRefresh.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelBtnRefresh.Controls.Add(btnRefresh, 1, 0);
            tableLayoutPanelBtnRefresh.Location = new Point(12, 12);
            tableLayoutPanelBtnRefresh.Name = "tableLayoutPanelBtnRefresh";
            tableLayoutPanelBtnRefresh.RowCount = 1;
            tableLayoutPanelBtnRefresh.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelBtnRefresh.Size = new Size(203, 68);
            tableLayoutPanelBtnRefresh.TabIndex = 16;
            // 
            // btnLast30Days
            // 
            btnLast30Days.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLast30Days.BackColor = Color.FromArgb(76, 86, 106);
            btnLast30Days.FlatAppearance.BorderSize = 0;
            btnLast30Days.FlatStyle = FlatStyle.Flat;
            btnLast30Days.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLast30Days.ForeColor = Color.FromArgb(236, 239, 244);
            btnLast30Days.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            btnLast30Days.IconColor = Color.FromArgb(236, 239, 244);
            btnLast30Days.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLast30Days.IconSize = 32;
            btnLast30Days.Location = new Point(501, 22);
            btnLast30Days.Margin = new Padding(0, 10, 0, 15);
            btnLast30Days.Name = "btnLast30Days";
            btnLast30Days.Size = new Size(160, 40);
            btnLast30Days.TabIndex = 17;
            btnLast30Days.Text = "Last 30 Days";
            btnLast30Days.TextAlign = ContentAlignment.MiddleRight;
            btnLast30Days.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLast30Days.UseVisualStyleBackColor = false;
            btnLast30Days.Click += btnLast30Days_Click;
            // 
            // panelBtnCustom
            // 
            panelBtnCustom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelBtnCustom.Controls.Add(btnCustom);
            panelBtnCustom.Controls.Add(btnOk);
            panelBtnCustom.Controls.Add(label7);
            panelBtnCustom.Controls.Add(label8);
            panelBtnCustom.Controls.Add(dateTimePickerEnd);
            panelBtnCustom.Controls.Add(dateTimePickerStart);
            panelBtnCustom.Location = new Point(676, 12);
            panelBtnCustom.Margin = new Padding(0);
            panelBtnCustom.MaximumSize = new Size(160, 290);
            panelBtnCustom.MinimumSize = new Size(160, 68);
            panelBtnCustom.Name = "panelBtnCustom";
            panelBtnCustom.Size = new Size(160, 68);
            panelBtnCustom.TabIndex = 19;
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
            btnCustom.Size = new Size(160, 40);
            btnCustom.TabIndex = 12;
            btnCustom.Text = "Custom";
            btnCustom.TextAlign = ContentAlignment.MiddleRight;
            btnCustom.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustom.UseVisualStyleBackColor = false;
            btnCustom.Click += btnCustom_Click;
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
            btnOk.Location = new Point(10, 232);
            btnOk.Margin = new Padding(0, 10, 0, 15);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(140, 40);
            btnOk.TabIndex = 17;
            btnOk.Text = "Ok";
            btnOk.TextAlign = ContentAlignment.MiddleRight;
            btnOk.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.Location = new Point(0, 143);
            label7.Name = "label7";
            label7.Size = new Size(160, 31);
            label7.TabIndex = 16;
            label7.Text = "End Date";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.Location = new Point(0, 63);
            label8.Name = "label8";
            label8.Size = new Size(160, 31);
            label8.TabIndex = 15;
            label8.Text = "Start Date";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Format = DateTimePickerFormat.Short;
            dateTimePickerEnd.Location = new Point(5, 180);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(150, 31);
            dateTimePickerEnd.TabIndex = 14;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Format = DateTimePickerFormat.Short;
            dateTimePickerStart.Location = new Point(5, 102);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(150, 31);
            dateTimePickerStart.TabIndex = 13;
            // 
            // dashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 239, 244);
            ClientSize = new Size(860, 670);
            Controls.Add(panelBtnCustom);
            Controls.Add(btnLast30Days);
            Controls.Add(tableLayoutPanelBtnRefresh);
            Controls.Add(btnToday);
            Controls.Add(btnLast7Days);
            Controls.Add(tableLayoutPanelTop);
            Controls.Add(chartExpenses);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashboardForm";
            Text = "DashboardForm";
            ((System.ComponentModel.ISupportInitialize)chartExpenses).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanelTop.ResumeLayout(false);
            tableLayoutPanelBtnRefresh.ResumeLayout(false);
            panelBtnCustom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpenses;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanelTop;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnToday;
        private FontAwesome.Sharp.IconButton btnLast7Days;
        private TableLayoutPanel tableLayoutPanelBtnRefresh;
        private FontAwesome.Sharp.IconButton btnLast30Days;
        private Panel panelBtnCustom;
        private FontAwesome.Sharp.IconButton btnCustom;
        private FontAwesome.Sharp.IconButton btnOk;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
    }
}