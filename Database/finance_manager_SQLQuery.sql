USE master;
GO

CREATE DATABASE finance_manager ON
(NAME = finance_manager_dat,
    FILENAME = 'D:\dev\FinanceManager\Database\finance_manager_dat.mdf',
    SIZE = 10,
    MAXSIZE = 50,
    FILEGROWTH = 5)
LOG ON
(NAME = finance_manager_log,
    FILENAME = 'D:\dev\FinanceManager\Database\finance_manager_log.ldf',
    SIZE = 5 MB,
    MAXSIZE = 25 MB,
    FILEGROWTH = 5 MB);
GO

USE finance_manager;
GO

CREATE TABLE users (
	user_id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	username NVARCHAR(32) NOT NULL,
	password NVARCHAR(32) NOT NULL,
	CONSTRAINT AK_username UNIQUE(username)
)
GO

CREATE TABLE categories (
	category_id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	user_id INT FOREIGN KEY REFERENCES users(user_id),
	type VARCHAR(7) NOT NULL CHECK(type = 'Income' OR type = 'Expense'),
	category_name NVARCHAR(32) NOT NULL,
	description NVARCHAR(100)
)
GO

CREATE TABLE budgets (
	budget_id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	user_id INT FOREIGN KEY REFERENCES users(user_id),
	budget_name NVARCHAR (32) NOT NULL,
	category_id INT FOREIGN KEY REFERENCES categories(category_id),
	amount FLOAT NOT NULL,
	start_date DATE NOT NULL,
	end_date DATE NOT NULL,
	is_active CHAR(1) NOT NULL CHECK(is_active = 'y' OR is_active = 'n')
)

GO

CREATE TABLE transactions (
	transaction_id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	user_id INT FOREIGN KEY REFERENCES users(user_id),
	transaction_name NVARCHAR (32) NOT NULL,
	type VARCHAR(7) NOT NULL CHECK(type = 'Income' OR type = 'Expense'),
	date DATETIME NOT NULL,
	amount FLOAT NOT NULL,
	category_id INT FOREIGN KEY REFERENCES categories(category_id),
)
GO

-- Default Value
INSERT INTO users(username, password) VALUES ('joe', 'joe')
INSERT INTO categories(user_id, type, category_name, description) VALUES (1, 'Expense', 'Education', 'Tuition, books, etc.')
INSERT INTO categories(user_id, type, category_name, description) VALUES (1, 'Expense',  'Food', 'Daily food, weekly/monthly stocks, etc.')
INSERT INTO categories(user_id, type, category_name, description) VALUES (1, 'Expense',  'Housing/supplies', 'Rent, toiletries, kitchen stuff, etc.')
INSERT INTO categories(user_id, type, category_name, description) VALUES (1, 'Expense',  'Transportation', 'Services, gas, etc.')
INSERT INTO categories(user_id, type, category_name, description) VALUES (1, 'Expense',  'Utilities', 'Electricity, WiFi, Water, etc.')
INSERT INTO categories(user_id, type, category_name, description) VALUES (1, 'Expense',  'Clothing', 'Tops, shoes, pants, etc.')
INSERT INTO categories(user_id, type, category_name, description) VALUES (1, 'Expense',  'Health', 'Hospital, medicine, etc.')
INSERT INTO categories(user_id, type, category_name, description) VALUES (1, 'Expense',  'Finance', 'Savings, investment, etc.')
INSERT INTO categories(user_id, type, category_name, description) VALUES (1, 'Income',  'Salary', 'Monthly work salary')
INSERT INTO categories(user_id, type, category_name, description) VALUES (1, 'Income',  'Divident', 'Investment return')
INSERT INTO categories(user_id, type, category_name, description) VALUES (1, 'Income',  'Bonus', 'Work bonus')

INSERT INTO transactions (user_id, transaction_name, type, date, amount, category_id)
                         VALUES (1, 'Tuition', 'Expense', '2024-12-29', 5500000, 1)



