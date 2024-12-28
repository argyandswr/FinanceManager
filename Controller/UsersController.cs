using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceManager.Model.Context;
using PersonalFinanceManager.Model.Entity;
using PersonalFinanceManager.Model.Repository;

namespace PersonalFinanceManager.Controller
{
    public class UsersController
    {
        private UsersRepository _repository;

        // Check if user is in the database
        public bool IsValidUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            bool isValidUser = false;

            using (DbContext context = new DbContext())
            {
                _repository = new UsersRepository(context);

                isValidUser = _repository.IsValidUser(username, password);
            }

            if (!isValidUser)
            {
                MessageBox.Show("Username or Password Incorrect!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public int GetUserID(string username, string password)
        {
            int current_user_id = -1;
            using (DbContext context = new DbContext())
            {
                _repository = new UsersRepository(context);

                return current_user_id = _repository.GetUserID(username, password);
            }
        }

        // Check if username is already exist in the database
        public bool IsUsernameAvailable(string username, string password, string confirmPassword)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Confirmation Password cannot be empty!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password doesn't match!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            bool isUsernameAvailable = false;

            using (DbContext context = new DbContext())
            {
                _repository = new UsersRepository(context);

                isUsernameAvailable = _repository.IsUsernameAvailable(username);
            }

            if (isUsernameAvailable)
            {
                MessageBox.Show("Username or Password Incorrect!", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public int Create(Users users)
        {
            int result = 0;

            if (string.IsNullOrEmpty(users.Username))
            {
                MessageBox.Show("Username cannot be empty!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(users.Password))
            {
                MessageBox.Show("Password cannot be empty!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new UsersRepository(context);

                result = _repository.Create(users);
            }

            if (result > 0)
            {
                MessageBox.Show("Successfully Registered", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Register Process Failed!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
    }
}
