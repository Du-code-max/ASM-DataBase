CREATE DATABASE ASMDATA;
GO
USE ASMDATA
GO

CREATE TABLE Customers (
    CustomersID INT PRIMARY KEY,
    CustomersName NVARCHAR(100),
    CustomersPhone NVARCHAR(15),
    CustomersEmail NVARCHAR(100),
    CustomersAddress NVARCHAR(200),
	UserName NVARCHAR(20),
	PassWord NVARCHAR(20)
);

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(100),
    ProductImportPrice DECIMAL(18, 2),
    ProductSellingPrice DECIMAL(18, 2),
    ProductSize NVARCHAR(50),
    ProductQuantity INT,
    ProductStock INT,
	ProductPhoto NVARCHAR(MAX)
	
);

CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY,
    EmployeeName NVARCHAR(100),
    EmployeePhone NVARCHAR(15),
    EmployeeEmail NVARCHAR(100),
    EmployeeAddress NVARCHAR(200),
    EmployeePosition NVARCHAR(50),
	UserName NVARCHAR(20),
	PassWord NVARCHAR(20)
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomersID INT FOREIGN KEY REFERENCES Customers(CustomersID),
    EmployeeID INT FOREIGN KEY REFERENCES Employee(EmployeeID),
    OrderDate DATE,
    OrderTotal DECIMAL(18, 2)
);

CREATE TABLE OrderDetails (
    OrderID INT,
    ProductID INT,
    Quantity INT,
    Price DECIMAL(18, 2),
    PRIMARY KEY (OrderID, ProductID),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

