USE SandingPos;

CREATE TABLE Products (
    ProductID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    ProductCode NVARCHAR(50) NOT NULL,
    ProductName NVARCHAR(100) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Stock INT NOT NULL
);

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
('0010', 'Salt (250g)', 15.00, 100);