-- ================================
-- SandingPOS Setup Script
-- Run this on any new computer
-- ================================

-- Create Database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'SandingPos')
    CREATE DATABASE SandingPos;
GO

USE SandingPos;
GO

-- Create Products Table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Products')
CREATE TABLE Products (
    ProductID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    ProductCode NVARCHAR(50) NOT NULL,
    ProductName NVARCHAR(100) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Stock INT NOT NULL
);
GO

-- Create Transactions Table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Transactions')
CREATE TABLE Transactions (
    TransactionID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    ProductCode NVARCHAR(50) NOT NULL,
    ProductName NVARCHAR(100) NOT NULL,
    Quantity INT NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL,
    VAT DECIMAL(10,2) NOT NULL,
    Discount DECIMAL(10,2) NOT NULL,
    GrandTotal DECIMAL(10,2) NOT NULL,
    TransactionDate DATETIME NOT NULL
);
GO

-- Create Users Table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users')
CREATE TABLE Users (
    UserID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    CashierID NVARCHAR(10) NOT NULL,
    CashierName NVARCHAR(100) NOT NULL,
    IsActive BIT NOT NULL DEFAULT 1
);
GO

-- Insert Products
IF NOT EXISTS (SELECT * FROM Products)
BEGIN
    INSERT INTO Products (ProductCode, ProductName, Price, Stock) VALUES
    ('0001', 'Mineral Water', 15.00, 100),
    ('0002', 'White Rice (1kg)', 52.00, 80),
    ('0003', 'Instant Noodles', 12.00, 150),
    ('0004', 'Canned Sardines', 22.00, 120),
    ('0005', 'Cooking Oil (1L)', 85.00, 60),
    ('0006', 'Sugar (1kg)', 65.00, 75),
    ('0007', 'Eggs (per piece)', 8.00, 200),
    ('0008', 'Bread Loaf', 45.00, 50),
    ('0009', 'Coffee (3in1)', 8.00, 300),
    ('0010', 'Salt (250g)', 15.00, 100),
    ('0011', 'Pork Belly (1kg)', 280.00, 50),
    ('0012', 'Chicken Breast (1kg)', 220.00, 60),
    ('0013', 'Ground Beef (1kg)', 350.00, 40),
    ('0014', 'Chicken Thigh (1kg)', 180.00, 60),
    ('0015', 'Pork Ribs (1kg)', 260.00, 40),
    ('0016', 'Beef Sirloin (1kg)', 450.00, 30),
    ('0017', 'Pork Liempo (1kg)', 250.00, 50),
    ('0018', 'Chicken Wings (1kg)', 160.00, 70),
    ('0019', 'Ground Pork (1kg)', 220.00, 50),
    ('0020', 'Beef Brisket (1kg)', 380.00, 30);
END
GO

-- Insert Users
IF NOT EXISTS (SELECT * FROM Users)
BEGIN
    INSERT INTO Users (CashierID, CashierName) VALUES
    ('1001', 'Francisco Marcos'),
    ('1002', 'Pio Dela Rosa'),
    ('1003', 'Nathan Bayola');
END
GO