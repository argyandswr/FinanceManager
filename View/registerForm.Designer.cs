namespace PersonalFinanceManager
{
    partial class RegisterForm
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
            signup_Btn = new Button();
            passReg_Txt = new TextBox();
            label4 = new Label();
            usernameReg_Txt = new TextBox();
            label3 = new Label();
            panelLeft = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            signin_Btn = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            label1 = new Label();
            showPass = new CheckBox();
            confirmPass_Txt = new TextBox();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelRight = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label7 = new Label();
            panelTopBar = new Panel();
            iconMinimize = new FontAwesome.Sharp.IconButton();
            iconExit = new FontAwesome.Sharp.IconButton();
            panelLeft.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelRight.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panelTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // signup_Btn
            // 
            signup_Btn.BackColor = Color.FromArgb(76, 86, 106);
            signup_Btn.FlatAppearance.BorderSize = 0;
            signup_Btn.FlatStyle = FlatStyle.Flat;
            signup_Btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_Btn.ForeColor = Color.FromArgb(236, 239, 244);
            signup_Btn.Location = new Point(43, 417);
            signup_Btn.Margin = new Padding(4);
            signup_Btn.Name = "signup_Btn";
            signup_Btn.Size = new Size(148, 55);
            signup_Btn.TabIndex = 4;
            signup_Btn.Text = "Sign Up";
            signup_Btn.UseVisualStyleBackColor = false;
            signup_Btn.Click += signup_Btn_Click;
            // 
            // passReg_Txt
            // 
            passReg_Txt.Location = new Point(22, 241);
            passReg_Txt.Margin = new Padding(4);
            passReg_Txt.Name = "passReg_Txt";
            passReg_Txt.PasswordChar = '*';
            passReg_Txt.Size = new Size(360, 31);
            passReg_Txt.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Typewriter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(46, 52, 64);
            label4.Location = new Point(22, 208);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
            label4.TabIndex = 11;
            label4.Text = "Password";
            // 
            // usernameReg_Txt
            // 
            usernameReg_Txt.Location = new Point(22, 154);
            usernameReg_Txt.Margin = new Padding(4);
            usernameReg_Txt.Name = "usernameReg_Txt";
            usernameReg_Txt.Size = new Size(360, 31);
            usernameReg_Txt.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Typewriter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(46, 52, 64);
            label3.Location = new Point(22, 121);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 9;
            label3.Text = "Username";
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(76, 86, 106);
            panelLeft.Controls.Add(tableLayoutPanel2);
            panelLeft.Controls.Add(label5);
            panelLeft.Controls.Add(label1);
            panelLeft.Dock = DockStyle.Fill;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(410, 550);
            panelLeft.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(signin_Btn, 1, 0);
            tableLayoutPanel2.Location = new Point(0, 416);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(410, 62);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // signin_Btn
            // 
            signin_Btn.BackColor = Color.FromArgb(236, 239, 244);
            signin_Btn.BackgroundImageLayout = ImageLayout.None;
            signin_Btn.FlatAppearance.BorderSize = 0;
            signin_Btn.FlatStyle = FlatStyle.Flat;
            signin_Btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            signin_Btn.ForeColor = Color.FromArgb(76, 86, 106);
            signin_Btn.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            signin_Btn.IconColor = Color.FromArgb(76, 86, 106);
            signin_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            signin_Btn.IconSize = 40;
            signin_Btn.Location = new Point(115, 0);
            signin_Btn.Margin = new Padding(0);
            signin_Btn.Name = "signin_Btn";
            signin_Btn.Size = new Size(180, 60);
            signin_Btn.TabIndex = 6;
            signin_Btn.Text = "Sign In";
            signin_Btn.TextAlign = ContentAlignment.MiddleRight;
            signin_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            signin_Btn.UseVisualStyleBackColor = false;
            signin_Btn.Click += signIn_Btn_Click;
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
            label5.Text = "Already have an account?";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(236, 239, 244);
            label1.Location = new Point(0, 228);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(410, 78);
            label1.TabIndex = 0;
            label1.Text = "Personal Finance Manager ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.ForeColor = Color.FromArgb(46, 52, 64);
            showPass.Location = new Point(220, 367);
            showPass.Margin = new Padding(4);
            showPass.Name = "showPass";
            showPass.Size = new Size(162, 29);
            showPass.TabIndex = 5;
            showPass.Text = "Show Password";
            showPass.UseVisualStyleBackColor = true;
            showPass.CheckedChanged += showPass_CheckedChanged;
            // 
            // confirmPass_Txt
            // 
            confirmPass_Txt.Location = new Point(22, 325);
            confirmPass_Txt.Margin = new Padding(4);
            confirmPass_Txt.Name = "confirmPass_Txt";
            confirmPass_Txt.PasswordChar = '*';
            confirmPass_Txt.Size = new Size(360, 31);
            confirmPass_Txt.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Typewriter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(46, 52, 64);
            label6.Location = new Point(22, 293);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(220, 25);
            label6.TabIndex = 15;
            label6.Text = "Confirm Password";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelLeft, 0, 0);
            tableLayoutPanel1.Controls.Add(panelRight, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 50);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(820, 550);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(tableLayoutPanel3);
            panelRight.Controls.Add(showPass);
            panelRight.Controls.Add(confirmPass_Txt);
            panelRight.Controls.Add(signup_Btn);
            panelRight.Controls.Add(label6);
            panelRight.Controls.Add(label3);
            panelRight.Controls.Add(usernameReg_Txt);
            panelRight.Controls.Add(passReg_Txt);
            panelRight.Controls.Add(label4);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(413, 3);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(404, 544);
            panelRight.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label7, 1, 0);
            tableLayoutPanel3.Location = new Point(0, 58);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(407, 44);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans Typewriter", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(46, 52, 64);
            label7.Location = new Point(128, 0);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(150, 32);
            label7.TabIndex = 1;
            label7.Text = "Register";
            label7.TextAlign = ContentAlignment.MiddleCenter;
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
            panelTopBar.TabIndex = 18;
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
            iconMinimize.TabIndex = 7;
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
            iconExit.TabIndex = 8;
            iconExit.UseVisualStyleBackColor = false;
            iconExit.Click += iconExit_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 222, 233);
            ClientSize = new Size(820, 600);
            Controls.Add(panelTopBar);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "RegisterForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            panelLeft.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panelTopBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button signup_Btn;
        private TextBox passReg_Txt;
        private Label label4;
        private TextBox usernameReg_Txt;
        private Label label3;
        private Panel panelLeft;
        private Label label5;
        private Button signIn_Btn;
        private Label label1;
        private CheckBox showPass;
        private TextBox confirmPass_Txt;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton signin_Btn;
        private Panel panelRight;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label7;
        private Panel panelTopBar;
        private FontAwesome.Sharp.IconButton iconMinimize;
        private FontAwesome.Sharp.IconButton iconExit;
    }
}