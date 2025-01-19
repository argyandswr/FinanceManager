namespace PersonalFinanceManager.View
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chartExpense = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            labelTotalExpense = new Label();
            label5 = new Label();
            panel2 = new Panel();
            labelTransactionsRecorded = new Label();
            label1 = new Label();
            panel3 = new Panel();
            labelTotalIncome = new Label();
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
            tableLayoutPanelPieChart = new TableLayoutPanel();
            panelChartLeft = new Panel();
            chartIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelChartRight = new Panel();
            tableLayoutPanelChartComposition = new TableLayoutPanel();
            chartBudget = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartExpense).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanelTop.SuspendLayout();
            tableLayoutPanelBtnRefresh.SuspendLayout();
            panelBtnCustom.SuspendLayout();
            tableLayoutPanelPieChart.SuspendLayout();
            panelChartLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartIncome).BeginInit();
            panelChartRight.SuspendLayout();
            tableLayoutPanelChartComposition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartBudget).BeginInit();
            SuspendLayout();
            // 
            // chartExpense
            // 
            chartExpense.AccessibleRole = AccessibleRole.None;
            chartArea1.Name = "ChartArea1";
            chartExpense.ChartAreas.Add(chartArea1);
            chartExpense.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartExpense.Legends.Add(legend1);
            chartExpense.Location = new Point(0, 0);
            chartExpense.Name = "chartExpense";
            chartExpense.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Label = "#VALY{Rp#,#} (#PERCENT)";
            series1.Legend = "Legend1";
            series1.LegendText = "#AXISLABEL";
            series1.Name = "Series1";
            chartExpense.Series.Add(series1);
            chartExpense.Size = new Size(410, 283);
            chartExpense.TabIndex = 0;
            chartExpense.Text = "Expense Category";
            title1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Expenses Percentage";
            chartExpense.Titles.Add(title1);
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(labelTotalExpense);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(559, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 77);
            panel1.TabIndex = 1;
            // 
            // labelTotalExpense
            // 
            labelTotalExpense.Dock = DockStyle.Fill;
            labelTotalExpense.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTotalExpense.Location = new Point(0, 34);
            labelTotalExpense.Name = "labelTotalExpense";
            labelTotalExpense.Size = new Size(274, 43);
            labelTotalExpense.TabIndex = 5;
            labelTotalExpense.Text = "0";
            labelTotalExpense.TextAlign = ContentAlignment.MiddleCenter;
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
            panel2.Controls.Add(labelTransactionsRecorded);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 77);
            panel2.TabIndex = 2;
            // 
            // labelTransactionsRecorded
            // 
            labelTransactionsRecorded.Dock = DockStyle.Fill;
            labelTransactionsRecorded.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTransactionsRecorded.Location = new Point(0, 34);
            labelTransactionsRecorded.Name = "labelTransactionsRecorded";
            labelTransactionsRecorded.Size = new Size(272, 43);
            labelTransactionsRecorded.TabIndex = 1;
            labelTransactionsRecorded.Text = "0";
            labelTransactionsRecorded.TextAlign = ContentAlignment.MiddleCenter;
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
            panel3.Controls.Add(labelTotalIncome);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(281, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(272, 77);
            panel3.TabIndex = 3;
            // 
            // labelTotalIncome
            // 
            labelTotalIncome.Dock = DockStyle.Fill;
            labelTotalIncome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTotalIncome.Location = new Point(0, 34);
            labelTotalIncome.Name = "labelTotalIncome";
            labelTotalIncome.Size = new Size(272, 43);
            labelTotalIncome.TabIndex = 3;
            labelTotalIncome.Text = "0";
            labelTotalIncome.TextAlign = ContentAlignment.MiddleCenter;
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
            // tableLayoutPanelPieChart
            // 
            tableLayoutPanelPieChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelPieChart.ColumnCount = 3;
            tableLayoutPanelPieChart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelPieChart.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanelPieChart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelPieChart.Controls.Add(panelChartLeft, 0, 0);
            tableLayoutPanelPieChart.Controls.Add(panelChartRight, 2, 0);
            tableLayoutPanelPieChart.Location = new Point(3, 3);
            tableLayoutPanelPieChart.Name = "tableLayoutPanelPieChart";
            tableLayoutPanelPieChart.RowCount = 1;
            tableLayoutPanelPieChart.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelPieChart.Size = new Size(830, 283);
            tableLayoutPanelPieChart.TabIndex = 20;
            // 
            // panelChartLeft
            // 
            panelChartLeft.Controls.Add(chartIncome);
            panelChartLeft.Dock = DockStyle.Fill;
            panelChartLeft.Location = new Point(0, 0);
            panelChartLeft.Margin = new Padding(0);
            panelChartLeft.Name = "panelChartLeft";
            panelChartLeft.Size = new Size(410, 283);
            panelChartLeft.TabIndex = 3;
            // 
            // chartIncome
            // 
            chartIncome.AccessibleRole = AccessibleRole.None;
            chartArea2.Name = "ChartArea1";
            chartIncome.ChartAreas.Add(chartArea2);
            chartIncome.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartIncome.Legends.Add(legend2);
            chartIncome.Location = new Point(0, 0);
            chartIncome.Name = "chartIncome";
            chartIncome.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Label = "#VALY{Rp#,#} (#PERCENT)";
            series2.Legend = "Legend1";
            series2.LegendText = "#AXISLABEL";
            series2.Name = "Series1";
            chartIncome.Series.Add(series2);
            chartIncome.Size = new Size(410, 283);
            chartIncome.TabIndex = 2;
            chartIncome.Text = "Expense Category";
            title2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "Incomes Percentage";
            chartIncome.Titles.Add(title2);
            // 
            // panelChartRight
            // 
            panelChartRight.Controls.Add(chartExpense);
            panelChartRight.Dock = DockStyle.Fill;
            panelChartRight.Location = new Point(420, 0);
            panelChartRight.Margin = new Padding(0);
            panelChartRight.Name = "panelChartRight";
            panelChartRight.Size = new Size(410, 283);
            panelChartRight.TabIndex = 21;
            // 
            // tableLayoutPanelChartComposition
            // 
            tableLayoutPanelChartComposition.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelChartComposition.ColumnCount = 1;
            tableLayoutPanelChartComposition.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelChartComposition.Controls.Add(chartBudget, 0, 1);
            tableLayoutPanelChartComposition.Controls.Add(tableLayoutPanelPieChart, 0, 0);
            tableLayoutPanelChartComposition.Location = new Point(12, 175);
            tableLayoutPanelChartComposition.Name = "tableLayoutPanelChartComposition";
            tableLayoutPanelChartComposition.RowCount = 2;
            tableLayoutPanelChartComposition.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanelChartComposition.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanelChartComposition.Size = new Size(836, 483);
            tableLayoutPanelChartComposition.TabIndex = 22;
            // 
            // chartBudget
            // 
            chartBudget.AccessibleRole = AccessibleRole.None;
            chartArea3.Name = "ChartArea1";
            chartBudget.ChartAreas.Add(chartArea3);
            chartBudget.Dock = DockStyle.Fill;
            legend3.Name = "Legend1";
            chartBudget.Legends.Add(legend3);
            chartBudget.Location = new Point(3, 292);
            chartBudget.Name = "chartBudget";
            chartBudget.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartBudget.Series.Add(series3);
            chartBudget.Size = new Size(830, 188);
            chartBudget.TabIndex = 1;
            chartBudget.Text = "Expense Category";
            title3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            title3.Name = "Title1";
            title3.Text = "Expenses Percentage";
            chartBudget.Titles.Add(title3);
            // 
            // dashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 239, 244);
            ClientSize = new Size(860, 670);
            Controls.Add(panelBtnCustom);
            Controls.Add(tableLayoutPanelChartComposition);
            Controls.Add(btnLast30Days);
            Controls.Add(tableLayoutPanelBtnRefresh);
            Controls.Add(btnToday);
            Controls.Add(btnLast7Days);
            Controls.Add(tableLayoutPanelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashboardForm";
            Text = "DashboardForm";
            ((System.ComponentModel.ISupportInitialize)chartExpense).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanelTop.ResumeLayout(false);
            tableLayoutPanelBtnRefresh.ResumeLayout(false);
            panelBtnCustom.ResumeLayout(false);
            tableLayoutPanelPieChart.ResumeLayout(false);
            panelChartLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartIncome).EndInit();
            panelChartRight.ResumeLayout(false);
            tableLayoutPanelChartComposition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartBudget).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpense;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanelTop;
        private Label labelTotalExpense;
        private Label label5;
        private Label labelTransactionsRecorded;
        private Label labelTotalIncome;
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
        private TableLayoutPanel tableLayoutPanelPieChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncome;
        private Panel panelChartLeft;
        private Panel panelChartRight;
        private TableLayoutPanel tableLayoutPanelChartComposition;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBudget;
    }
}