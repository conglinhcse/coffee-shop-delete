use CoffeeShop
GO

-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.USP_Login
    @username NVARCHAR(100),
    @password NVARCHAR(100)
AS
    SELECT * FROM dbo.Account WHERE Username = @username AND UserPassword = @password
GO
EXECUTE dbo.USP_Login N'cat', N'cat'
GO

----------------------------------------------------------------------------------------
-- Create a new stored procedure called 'StoredProcedureName' in schema 'SchemaName'
CREATE PROCEDURE USP_InsertBill
    @TableID INT
AS
BEGIN
    INSERT INTO Bill
    ( [TableID], [DateCheckIn], [BillStatus] )
    VALUES
    ( @TableID, GETDATE(), 0)
END
GO

-- Create a new stored procedure called 'StoredProcedureName' in schema 'SchemaName'
CREATE PROCEDURE USP_InsertBillInfo
@BillID INT, @FoodID INT, @CountBill INT
AS
BEGIN
    DECLARE @isExistBillInfo INT = 0
    DECLARE @foodCount INT = 1

    SELECT @isExistBillInfo = ID, @foodCount = CountBill
    FROM dbo.BillInfo
    WHERE BillID = @BillID AND FoodID = @FoodID

    IF(@isExistBillInfo > 0)
    BEGIN
        DECLARE @newCount INT = @foodCount + @CountBill
        if(@newCount > 0)
            UPDATE dbo.BillInfo SET CountBill = @foodCount + @CountBill
            WHERE FoodID = @FoodID 
        ELSE
            DELETE dbo.BillInfo WHERE BillID = @BillID AND FoodID = @FoodID 
    END
    ELSE
    BEGIN
        INSERT INTO BillInfo
        ( [BillID], [FoodID], [CountBill] )
        VALUES
        ( @BillID, @FoodID, @CountBill)
    END
END
GO
----------------------------------------------------------------------------------------

-- Create the stored procedure in the specified schema
CREATE PROCEDURE USP_GetListBillByDate
    @start DATE, @end DATE
AS
BEGIN
    SELECT T.TableName AS [Tên bàn], B.TotalPrice AS [Tổng tiền], 
           B.DateCheckIn AS [Ngày mua], B.Discount AS [Giảm giá]
    FROM dbo.Bill AS B, dbo.FoodTable AS T
    WHERE B.DateCheckIn >= @start AND B.DateCheckIn <= @end 
    AND B.BillStatus = 1 AND T.ID = B.TableID
END
GO
