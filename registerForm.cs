using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace PersonalFinanceManager
{
    public partial class registerForm : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\argya\OneDrive\Documents\FinanceManager.mdf;Integrated Security=True;Connect Timeout=30");
        public registerForm()
        {
            InitializeComponent();
        }

        public bool checkConnection()
        {
            return (connect.State == ConnectionState.Closed) ? true : false;
        }

        private void signup_Btn_Click(object sender, EventArgs e)
        {
            if(usernameReg_Txt.Text == "" || passReg_Txt.Text == "" || confirmPass_Txt.Text == "")
            {
                MessageBox.Show("Please fill the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                if(checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string selectUsername = "SELECT * FROM users WHERE username = @usern"; 

                        using(SqlCommand checkUser = new SqlCommand(selectUsername, connect)) 
                        { 
                            checkUser.Parameters.AddWithValue ("@usern", usernameReg_Txt.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table =  new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count != 0)
                            {
                                string tempUsern = usernameReg_Txt.Text.Substring(0,1).ToUpper() + usernameReg_Txt.Text.Substring(1);
                                MessageBox.Show(tempUsern + " is already exist","Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error );
                            }else if (passReg_Txt.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid password! at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); 

                            } else if (passReg_Txt.Text != confirmPass_Txt.Text)
                            {
                                MessageBox.Show("Password doesn't match!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, date_create) VALUES (@usern, @pass, @date)";

                                using (SqlCommand insertUser = new SqlCommand(insertData, connect))
                                {
                                    insertUser.Parameters.AddWithValue("@usern", usernameReg_Txt.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@pass", passReg_Txt.Text.Trim());

                                    DateTime dateToday = DateTime.Today;
                                    insertUser.Parameters.AddWithValue("@date", dateToday);

                                    insertUser.ExecuteNonQuery();

                                    MessageBox.Show("Succesfully Registered!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    loginForm logForm = new loginForm();
                                    logForm.Show();

                                    this.Hide();
                                }
                            }
                        }
                    } catch (Exception ex)
                    {

                        MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            passReg_Txt.PasswordChar = showPass.Checked ? '\0' : '*';
            confirmPass_Txt.PasswordChar = showPass.Checked ? '\0' : '*';
        }

        private void signIn_Btn_Click(object sender, EventArgs e)
        {
            loginForm logForm = new loginForm();
            logForm.Show();

            this.Hide();
        }
    }
}
