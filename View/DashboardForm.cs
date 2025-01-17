using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace PersonalFinanceManager.View
{
    public partial class dashboardForm : Form
    {
        GlobalVariable.SelectedFilter selectedFilter;
        IconButton currentBtn;
        IconChar currentIcon;

        public dashboardForm()
        {
            InitializeComponent();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            selectedFilter = GlobalVariable.SelectedFilter.today;
            ActivateButton(sender);
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            selectedFilter = GlobalVariable.SelectedFilter.last7days;
            ActivateButton(sender);
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            selectedFilter = GlobalVariable.SelectedFilter.last30days;
            ActivateButton(sender);
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

        
    }
}
