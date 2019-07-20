USE CoffeeShop
GO

CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @BillID INT
    SELECT @BillID = BillID FROM Inserted

    DECLARE @TableID INT
    SELECT @TableID = TableID FROM dbo.Bill 
    WHERE ID = @BillID AND BillStatus = 0

    UPDATE dbo.FoodTable SET TableStatus = N'Có người'
    WHERE ID = @TableID
END
GO

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
    DECLARE @BillID INT
    SELECT @BillID = ID FROM Inserted

    DECLARE @TableID INT
    SELECT @TableID = TableID FROM dbo.Bill 
    WHERE ID = @BillID

    DECLARE @count INT = 0
    SELECT @count = COUNT(*) FROM dbo.Bill 
    WHERE TableID = @TableID AND BillStatus = 0

    IF(@count = 0) 
        UPDATE dbo.FoodTable SET TableStatus = N'Trống'
        WHERE ID = @TableID
END
GO
