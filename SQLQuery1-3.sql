USE SandingPos;

CREATE TABLE Users (
    UserID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    CashierID NVARCHAR(10) NOT NULL,
    CashierName NVARCHAR(100) NOT NULL,
    IsActive BIT NOT NULL DEFAULT 1
);

INSERT INTO Users (CashierID, CashierName) VALUES
('1001', 'Francisco Marcos'),
('1002', 'Nathan Bayola'),
('1003', 'Pio Dela rosa');