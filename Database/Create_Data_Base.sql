-- Create a new database called 'CoffeeShop'
CREATE DATABASE CoffeeShop
GO

USE CoffeeShop
GO

-- Create a new table called 'FoodTable' in schema 'dbo'
CREATE TABLE dbo.FoodTable
(
    ID INT IDENTITY PRIMARY KEY, -- primary key column
    TableName [NVARCHAR](50) NOT NULL DEFAULT N'Bàn chưa đặt tên',
    TableStatus [NVARCHAR](50) NOT NULL DEFAULT N'Trống' -- Trống or Có người
);
GO

-- Create a new table called 'Account' in schema 'dbo'
CREATE TABLE dbo.Account
(
    Username [NVARCHAR](50) PRIMARY KEY, -- primary key column
    UserPassword [NVARCHAR](50) NOT NULL DEFAULT 0,
    DisplayName [NVARCHAR](50) NOT NULL DEFAULT N'Username',
    UserType INT NOT NULL DEFAULT 0 -- 0 is staff, 1 is admin
);
GO

-- Create a new table called 'FoodCategory' in schema 'dbo'
CREATE TABLE dbo.FoodCategory
(
    ID INT IDENTITY PRIMARY KEY, -- primary key column
    FoodCatagoryName [NVARCHAR](50) NOT NULL DEFAULT N'Danh mục món ăn chưa đặt tên'
);
GO

-- Create a new table called 'Food' in schema 'dbo'
CREATE TABLE dbo.Food
(
    ID INT IDENTITY PRIMARY KEY, -- primary key column
    CategoryID INT NOT NULL,
    FoodName [NVARCHAR](50) NOT NULL DEFAULT N'Món ăn chưa đặt tên',
    FoodPrice INT NOT NULL DEFAULT 0

    FOREIGN KEY (CategoryID) REFERENCES dbo.FoodCategory(ID)
);
GO

-- Create a new table called 'Bill' in schema 'dbo'
CREATE TABLE dbo.Bill
(
    ID INT IDENTITY PRIMARY KEY, -- primary key column
    TableID INT NOT NULL,
    DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
    Discount INT NOT NULL DEFAULT 0,
    BillStatus INT NOT NULL DEFAULT 0, -- 0 Chưa thanh toán, 1 Đã thanh toán
    TotalPrice INT NOT NULL DEFAULT 0
    
    FOREIGN KEY (TableID) REFERENCES dbo.FoodTable(ID)
);
GO

-- Create a new table called 'BillInfo' in schema 'dbo'
CREATE TABLE dbo.BillInfo
(
    ID INT IDENTITY PRIMARY KEY, -- primary key column
    FoodID INT NOT NULL,
    BillID INT NOT NULL,
    CountBill INT NOT NULL DEFAULT 0
   
    FOREIGN KEY (FoodID) REFERENCES dbo.Food(ID),
    FOREIGN KEY (BillID) REFERENCES dbo.Bill(ID)
);
GO
