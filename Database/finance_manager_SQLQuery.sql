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
