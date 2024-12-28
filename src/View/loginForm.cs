﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using PersonalFinanceManager.src.Controller;

namespace PersonalFinanceManager
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Btn_Click(object sender, EventArgs e)
        {
            UsersController controller = new UsersController();

            bool isValidUser = controller.IsValidUser(usernameLogin_Txt.Text, passLogin_Txt.Text);
            if (isValidUser)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            /*using(SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters .AddWithValue("@usern", usernameLogin_Txt.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", passLogin_Txt.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); 
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("Wrong username/password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registerForm regForm = new registerForm();
            regForm.Show();

            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            passLogin_Txt.PasswordChar = showPass.Checked ? '\0' : '*';
        }
    }
}