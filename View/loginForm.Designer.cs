namespace PersonalFinanceManager
{
    partial class loginForm
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
            panelLeft = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            reg_Btn = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            usernameLogin_Txt = new TextBox();
            label4 = new Label();
            passLogin_Txt = new TextBox();
            login_Btn = new Button();
            showPass = new CheckBox();
            button1 = new Button();
            tableLayoutPanelMain = new TableLayoutPanel();
            panelRight = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panelTopBar = new Panel();
            iconMinimize = new FontAwesome.Sharp.IconButton();
            iconExit = new FontAwesome.Sharp.IconButton();
            panelLeft.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            panelRight.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panelTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(76, 86, 106);
            panelLeft.Controls.Add(label1);
            panelLeft.Controls.Add(tableLayoutPanel1);
            panelLeft.Controls.Add(label5);
            panelLeft.Dock = DockStyle.Fill;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(410, 553);
            panelLeft.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(236, 239, 244);
            label1.Location = new Point(0, 228);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(410, 78);
            label1.TabIndex = 10;
            label1.Text = "Personal Finance Manager ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(reg_Btn, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 416);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(410, 62);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // reg_Btn
            // 
            reg_Btn.BackColor = Color.FromArgb(236, 239, 244);
            reg_Btn.BackgroundImageLayout = ImageLayout.None;
            reg_Btn.FlatAppearance.BorderSize = 0;
            reg_Btn.FlatStyle = FlatStyle.Flat;
            reg_Btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            reg_Btn.ForeColor = Color.FromArgb(76, 86, 106);
            reg_Btn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            reg_Btn.IconColor = Color.FromArgb(76, 86, 106);
            reg_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            reg_Btn.Location = new Point(115, 0);
            reg_Btn.Margin = new Padding(0);
            reg_Btn.Name = "reg_Btn";
            reg_Btn.Size = new Size(180, 60);
            reg_Btn.TabIndex = 5;
            reg_Btn.Text = "Register";
            reg_Btn.TextAlign = ContentAlignment.MiddleRight;
            reg_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            reg_Btn.UseVisualStyleBackColor = false;
            reg_Btn.Click += reg_Btn_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.Font = new Font("Lucida Sans Typewriter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(236, 239, 244);
            label5.Location = new Point(0, 366);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(410, 30);
            label5.TabIndex = 7;
            label5.Text = "Do not have account?";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Typewriter", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(46, 52, 64);
            label2.Location = new Point(137, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(133, 32);
            label2.TabIndex = 1;
            label2.Text = "Sign In";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Typewriter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(46, 52, 64);
            label3.Location = new Point(21, 176);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // usernameLogin_Txt
            // 
            usernameLogin_Txt.Location = new Point(22, 220);
            usernameLogin_Txt.Margin = new Padding(4);
            usernameLogin_Txt.Name = "usernameLogin_Txt";
            usernameLogin_Txt.Size = new Size(360, 31);
            usernameLogin_Txt.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Typewriter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(46, 52, 64);
            label4.Location = new Point(21, 281);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 4;
            label4.Text = "Password ";
            // 
            // passLogin_Txt
            // 
            passLogin_Txt.Location = new Point(22, 325);
            passLogin_Txt.Margin = new Padding(4);
            passLogin_Txt.Name = "passLogin_Txt";
            passLogin_Txt.PasswordChar = '*';
            passLogin_Txt.Size = new Size(360, 31);
            passLogin_Txt.TabIndex = 2;
            // 
            // login_Btn
            // 
            login_Btn.BackColor = Color.FromArgb(76, 86, 106);
            login_Btn.FlatStyle = FlatStyle.Flat;
            login_Btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_Btn.ForeColor = Color.FromArgb(236, 239, 244);
            login_Btn.Location = new Point(43, 417);
            login_Btn.Margin = new Padding(4);
            login_Btn.Name = "login_Btn";
            login_Btn.Size = new Size(148, 55);
            login_Btn.TabIndex = 3;
            login_Btn.Text = "Login";
            login_Btn.UseVisualStyleBackColor = false;
            login_Btn.Click += login_Btn_Click;
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.ForeColor = Color.FromArgb(46, 52, 64);
            showPass.Location = new Point(220, 367);
            showPass.Margin = new Padding(4);
            showPass.Name = "showPass";
            showPass.Size = new Size(162, 29);
            showPass.TabIndex = 4;
            showPass.Text = "Show Password";
            showPass.UseVisualStyleBackColor = true;
            showPass.CheckedChanged += showPass_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(275, 20);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "skip";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Controls.Add(panelLeft, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelRight, 1, 0);
            tableLayoutPanelMain.Location = new Point(0, 50);
            tableLayoutPanelMain.Margin = new Padding(0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Size = new Size(820, 553);
            tableLayoutPanelMain.TabIndex = 7;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(tableLayoutPanel2);
            panelRight.Controls.Add(button1);
            panelRight.Controls.Add(showPass);
            panelRight.Controls.Add(login_Btn);
            panelRight.Controls.Add(label3);
            panelRight.Controls.Add(passLogin_Txt);
            panelRight.Controls.Add(usernameLogin_Txt);
            panelRight.Controls.Add(label4);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(413, 3);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(404, 547);
            panelRight.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 133F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Location = new Point(0, 109);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(407, 44);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(67, 76, 94);
            panelTopBar.Controls.Add(iconMinimize);
            panelTopBar.Controls.Add(iconExit);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(820, 50);
            panelTopBar.TabIndex = 8;
            panelTopBar.MouseDown += panelTopBar_MouseDown;
            // 
            // iconMinimize
            // 
            iconMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMinimize.BackColor = Color.FromArgb(67, 76, 94);
            iconMinimize.FlatAppearance.BorderSize = 0;
            iconMinimize.FlatStyle = FlatStyle.Flat;
            iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconMinimize.IconColor = Color.FromArgb(236, 239, 244);
            iconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMinimize.IconSize = 28;
            iconMinimize.ImeMode = ImeMode.NoControl;
            iconMinimize.Location = new Point(731, 9);
            iconMinimize.Margin = new Padding(0);
            iconMinimize.Name = "iconMinimize";
            iconMinimize.Size = new Size(40, 40);
            iconMinimize.TabIndex = 6;
            iconMinimize.UseVisualStyleBackColor = false;
            iconMinimize.Click += iconMinimize_Click;
            // 
            // iconExit
            // 
            iconExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconExit.BackColor = Color.FromArgb(67, 76, 94);
            iconExit.FlatAppearance.BorderSize = 0;
            iconExit.FlatStyle = FlatStyle.Flat;
            iconExit.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconExit.IconColor = Color.FromArgb(236, 239, 244);
            iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconExit.IconSize = 28;
            iconExit.ImeMode = ImeMode.NoControl;
            iconExit.Location = new Point(771, 9);
            iconExit.Margin = new Padding(0);
            iconExit.Name = "iconExit";
            iconExit.Size = new Size(40, 40);
            iconExit.TabIndex = 7;
            iconExit.UseVisualStyleBackColor = false;
            iconExit.Click += iconExit_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 222, 233);
            ClientSize = new Size(820, 600);
            Controls.Add(tableLayoutPanelMain);
            Controls.Add(panelTopBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "loginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            panelLeft.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panelTopBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Label label2;
        private Label label3;
        private TextBox usernameLogin_Txt;
        private Label label4;
        private TextBox passLogin_Txt;
        private Button login_Btn;
        private Label label5;
        private CheckBox showPass;
        private Button button1;
        private FontAwesome.Sharp.IconButton reg_Btn;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelRight;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panelTopBar;
        private FontAwesome.Sharp.IconButton iconExit;
        private FontAwesome.Sharp.IconButton iconMinimize;
        private Label label1;
    }
}