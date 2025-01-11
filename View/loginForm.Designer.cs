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
            panel1 = new Panel();
            label5 = new Label();
            reg_Btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            usernameLogin_Txt = new TextBox();
            label4 = new Label();
            passLogin_Txt = new TextBox();
            login_Btn = new Button();
            showPass = new CheckBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(76, 86, 106);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(reg_Btn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 561);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Typewriter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(236, 239, 244);
            label5.Location = new Point(55, 366);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(272, 25);
            label5.TabIndex = 7;
            label5.Text = "Do not have account?";
            // 
            // reg_Btn
            // 
            reg_Btn.BackColor = Color.FromArgb(236, 239, 244);
            reg_Btn.FlatStyle = FlatStyle.Flat;
            reg_Btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reg_Btn.ForeColor = Color.FromArgb(46, 52, 64);
            reg_Btn.Location = new Point(69, 410);
            reg_Btn.Margin = new Padding(4);
            reg_Btn.Name = "reg_Btn";
            reg_Btn.Size = new Size(249, 84);
            reg_Btn.TabIndex = 5;
            reg_Btn.Text = "Register";
            reg_Btn.UseVisualStyleBackColor = false;
            reg_Btn.Click += reg_Btn_Click;
            // 
            // label1
            // 
            label1.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(236, 239, 244);
            label1.Location = new Point(15, 228);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(361, 78);
            label1.TabIndex = 0;
            label1.Text = "Personal Finance Manager ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Typewriter", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(46, 52, 64);
            label2.Location = new Point(411, 115);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 32);
            label2.TabIndex = 1;
            label2.Text = "Sign In";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Typewriter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(46, 52, 64);
            label3.Location = new Point(411, 187);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // usernameLogin_Txt
            // 
            usernameLogin_Txt.Location = new Point(411, 217);
            usernameLogin_Txt.Margin = new Padding(4);
            usernameLogin_Txt.Name = "usernameLogin_Txt";
            usernameLogin_Txt.Size = new Size(386, 31);
            usernameLogin_Txt.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Typewriter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(46, 52, 64);
            label4.Location = new Point(411, 279);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 4;
            label4.Text = "Password ";
            // 
            // passLogin_Txt
            // 
            passLogin_Txt.Location = new Point(411, 309);
            passLogin_Txt.Margin = new Padding(4);
            passLogin_Txt.Name = "passLogin_Txt";
            passLogin_Txt.PasswordChar = '*';
            passLogin_Txt.Size = new Size(386, 31);
            passLogin_Txt.TabIndex = 2;
            // 
            // login_Btn
            // 
            login_Btn.BackColor = Color.FromArgb(76, 86, 106);
            login_Btn.FlatStyle = FlatStyle.Flat;
            login_Btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_Btn.ForeColor = Color.FromArgb(236, 239, 244);
            login_Btn.Location = new Point(429, 394);
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
            showPass.Location = new Point(635, 350);
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
            button1.Location = new Point(657, 67);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "skip";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 222, 233);
            ClientSize = new Size(811, 561);
            Controls.Add(button1);
            Controls.Add(showPass);
            Controls.Add(login_Btn);
            Controls.Add(passLogin_Txt);
            Controls.Add(label4);
            Controls.Add(usernameLogin_Txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "loginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox usernameLogin_Txt;
        private Label label4;
        private TextBox passLogin_Txt;
        private Button login_Btn;
        private Button reg_Btn;
        private Label label5;
        private CheckBox showPass;
        private Button button1;
    }
}