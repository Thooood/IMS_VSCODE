CREATE TABLE Transactions(
TransactionID  INT PRIMARY KEY IDENTITY(1,1),
ProductID INT,
Quantity INT,
TransactionType VARCHAR(10),
TransactionDate DATETIME DEFAULT GETDATE(),

FOREIGN KEY (ProductID) REFERENCES
Products(ProductID)
);