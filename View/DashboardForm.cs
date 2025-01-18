using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using PersonalFinanceManager.Controller;
using PersonalFinanceManager.Model.Context;
using PersonalFinanceManager.Model.Entity;

namespace PersonalFinanceManager.View
{
    public partial class dashboardForm : Form
    {
        GlobalVariable.SelectedFilter selectedFilter;
        IconButton currentBtn;
        IconChar currentIcon;

        DashboardController controller;
        Dashboard dashboardData;



        public dashboardForm()
        {
            InitializeComponent();
            btnToday.PerformClick();

            controller = new();
            dashboardData = new();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            selectedFilter = GlobalVariable.SelectedFilter.today;
            ActivateButton(sender);
            dashboardData = controller.GetDashboardData(DateTime.Today, DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59));
            LoadData();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            selectedFilter = GlobalVariable.SelectedFilter.last7days;
            ActivateButton(sender);
            dashboardData = controller.GetDashboardData(DateTime.Today.AddDays(-7), DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59));
            LoadData();
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            selectedFilter = GlobalVariable.SelectedFilter.last30days;
            ActivateButton(sender);
            dashboardData = controller.GetDashboardData(DateTime.Today.AddDays(-30), DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59));
            LoadData();
        }

        private bool btnCustomState = false;
        private void btnCustom_Click(object sender, EventArgs e)
        {
            selectedFilter = GlobalVariable.SelectedFilter.custom;
            ActivateButton(sender);

            btnCustomState = !btnCustomState;
            if (btnCustomState)
            {
                panelBtnCustom.Size = panelBtnCustom.MaximumSize;
            }
            else
            {
                panelBtnCustom.Size = panelBtnCustom.MinimumSize;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            panelBtnCustom.Size = panelBtnCustom.MinimumSize;
            btnCustomState = false;

            dashboardData = controller.GetDashboardData(dateTimePickerStart.Value, dateTimePickerEnd.Value);
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }




        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(91, 103, 127);
                currentBtn.ForeColor = Color.FromArgb(248, 249, 251);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.FromArgb(248, 249, 251);
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                currentIcon = currentBtn.IconChar;
                currentBtn.IconChar = IconChar.CheckSquare;
            }

            // Close custom filter (if still expanded) if other filter is selected
            if (btnCustomState == true && selectedFilter != GlobalVariable.SelectedFilter.custom)
            {
                btnCustomState = false;
                panelBtnCustom.Size = panelBtnCustom.MinimumSize;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(76, 86, 106);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconChar = currentIcon;
            }
        }

        private void LoadData()
        {
            labelTransactionsRecorded.Text = dashboardData.TransactionsRecorded.ToString();
            labelTotalIncome.Text = dashboardData.TotalIncomes.ToString("C0", CultureInfo.CreateSpecificCulture("id-ID"));
            labelTotalExpense.Text = dashboardData.TotalExpenses.ToString("C0", CultureInfo.CreateSpecificCulture("id-ID"));
            
            chartExpense.DataSource = dashboardData.ExpenseCategory;
            chartExpense.Series[0].XValueMember = "Key";
            chartExpense.Series[0].YValueMembers = "Value";
            chartExpense.DataBind();

            chartExpenseLegend.DataSource = dashboardData.ExpenseCategory;
            chartExpenseLegend.Series[0].XValueMember = "Key";
            chartExpenseLegend.Series[0].YValueMembers = "Value";
            chartExpenseLegend.DataBind();

            chartIncome.DataSource = dashboardData.IncomeCategory;
            chartIncome.Series[0].XValueMember = "Key";
            chartIncome.Series[0].YValueMembers = "Value";
            chartIncome.DataBind();

            chartIncomeLegend.DataSource = dashboardData.IncomeCategory;
            chartIncomeLegend.Series[0].XValueMember = "Key";
            chartIncomeLegend.Series[0].YValueMembers = "Value";
            chartIncomeLegend.DataBind();

        }
    }
}
