namespace PersonalFinanceManager
{
    partial class registerForm
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
            label2 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            signIn_Btn = new Button();
            label1 = new Label();
            showPass = new CheckBox();
            confirmPass_Txt = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // signup_Btn
            // 
            signup_Btn.BackColor = Color.SkyBlue;
            signup_Btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_Btn.Location = new Point(335, 347);
            signup_Btn.Name = "signup_Btn";
            signup_Btn.Size = new Size(118, 44);
            signup_Btn.TabIndex = 13;
            signup_Btn.Text = "SignUp";
            signup_Btn.UseVisualStyleBackColor = false;
            signup_Btn.Click += signup_Btn_Click;
            // 
            // passReg_Txt
            // 
            passReg_Txt.Location = new Point(323, 198);
            passReg_Txt.Name = "passReg_Txt";
            passReg_Txt.PasswordChar = '*';
            passReg_Txt.Size = new Size(316, 27);
            passReg_Txt.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Typewriter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(323, 174);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 11;
            label4.Text = "Password";
            // 
            // usernameReg_Txt
            // 
            usernameReg_Txt.Location = new Point(323, 116);
            usernameReg_Txt.Name = "usernameReg_Txt";
            usernameReg_Txt.Size = new Size(316, 27);
            usernameReg_Txt.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Typewriter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(323, 92);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 9;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Typewriter", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(323, 43);
            label2.Name = "label2";
            label2.Size = new Size(124, 26);
            label2.TabIndex = 8;
            label2.Text = "Register";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(signIn_Btn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 450);
            panel1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Typewriter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 294);
            label5.Name = "label5";
            label5.Size = new Size(274, 21);
            label5.TabIndex = 7;
            label5.Text = "Already have an account?";
            // 
            // signIn_Btn
            // 
            signIn_Btn.BackColor = Color.White;
            signIn_Btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signIn_Btn.Location = new Point(55, 328);
            signIn_Btn.Name = "signIn_Btn";
            signIn_Btn.Size = new Size(199, 67);
            signIn_Btn.TabIndex = 7;
            signIn_Btn.Text = "Sign In";
            signIn_Btn.UseVisualStyleBackColor = false;
            signIn_Btn.Click += signIn_Btn_Click;
            // 
            // label1
            // 
            label1.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 182);
            label1.Name = "label1";
            label1.Size = new Size(289, 62);
            label1.TabIndex = 0;
            label1.Text = "Personal Finance Manager ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.Location = new Point(502, 312);
            showPass.Name = "showPass";
            showPass.Size = new Size(132, 24);
            showPass.TabIndex = 14;
            showPass.Text = "Show Password";
            showPass.UseVisualStyleBackColor = true;
            showPass.CheckedChanged += showPass_CheckedChanged;
            // 
            // confirmPass_Txt
            // 
            confirmPass_Txt.Location = new Point(323, 268);
            confirmPass_Txt.Name = "confirmPass_Txt";
            confirmPass_Txt.PasswordChar = '*';
            confirmPass_Txt.Size = new Size(316, 27);
            confirmPass_Txt.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Typewriter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(323, 244);
            label6.Name = "label6";
            label6.Size = new Size(186, 21);
            label6.TabIndex = 15;
            label6.Text = "Confirm Password";
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 450);
            Controls.Add(confirmPass_Txt);
            Controls.Add(label6);
            Controls.Add(showPass);
            Controls.Add(signup_Btn);
            Controls.Add(passReg_Txt);
            Controls.Add(label4);
            Controls.Add(usernameReg_Txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "registerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signup_Btn;
        private TextBox passReg_Txt;
        private Label label4;
        private TextBox usernameReg_Txt;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label5;
        private Button signIn_Btn;
        private Label label1;
        private CheckBox showPass;
        private TextBox confirmPass_Txt;
        private Label label6;
    }
}