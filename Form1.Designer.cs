namespace PersonalFinanceManager
{
    partial class dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuPanel = new Panel();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BackColor = SystemColors.ButtonShadow;
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(322, 718);
            menuPanel.TabIndex = 0;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 718);
            Controls.Add(menuPanel);
            Name = "dashboard";
            Text = "Personal Finance Manager";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel menuPanel;
    }
}
