-- Connect to the 'master' database to run this snippet
-- Restaurant
USE CoffeeShop
GO
-----------------------------------------------------------------------------------
-- Insert rows into table 'Account'
INSERT INTO Account
( [UserName], [UserPassword], [DisplayName], [UserType] )
VALUES
( N'cat',       N'cat',      N'Đỗ Đăng Khôi',           1 ),
( N'dog',       N'dog',      N'Nguyễn Hữu Thắng',       1 ),
( N'bird',      N'bird',     N'Võ Trung Thiên Tường',   1 ),
( N'monkey',    N'monkey',   N'Lê Văn Nam',             0 ),
( N'elephant',  N'elephant', N'Nguyễn Tiến Phát',       0 ),
( N'mouse',     N'mouse',    N'Hồ Bảo Khang',           0 )
GO
-----------------------------------------------------------------------------------
-- Insert rows into table 'FoodTable'
DECLARE @i INT = 1
WHILE @i <= 30
BEGIN
    INSERT dbo.FoodTable (TableName) VALUES (N'Bàn ' + CAST(@i AS nvarchar(100)))
    SET @i = @i + 1
END
GO
-----------------------------------------------------------------------------------
-- Insert rows into table 'FoodCategory'
INSERT INTO FoodCategory (FoodCatagoryName)
VALUES
( N'ESPRESSO & COFFEE' ),
( N'ICE BLENDED COFFEE' ),
( N'CHOCOLATE'),
( N'SPECIAL TEA'),
( N'SMOOTHIES'),
( N'Cake')
GO
-----------------------------------------------------------------------------------
-- Insert rows into table 'Food'
INSERT INTO Food
( [FoodName], [FoodPrice], [CategoryID] )
VALUES
( N'AMERICANO',                     35000, 1 ),
( N'CAPPUCCINO',                    45000, 1 ),
( N'CARAMEL MACHIATO',              55000, 1 ),
( N'ESPRESSO',                      35000, 1 ),
( N'ESPRESSO MILK',                 35000, 1 ),
( N'LATTE',                         45000, 1 ),
( N'MOCHA',                         49000, 1 ),
( N'VIETNAMESE COFFEE',             29000, 1 ),
( N'VIETNAMESE WHITE COFFE',        29000, 1 ),
----------------------------------------------
( N'CARAMEL ICE BLENDED',           35000, 2 ),
( N'COOKIE ICE BLEND',              45000, 2 ),
( N'HAZELNUT ICE BLENDED',          55000, 2 ),
( N'ICE CHOCOLATE MOCHA ALMOND',    35000, 2 ),
( N'MOCHA ICE BLENDED',             35000, 2 ),
----------------------------------------------
( N'CHOCOLATE ICE BLENDED',         59000, 3 ),
( N'HOT CHOCOLATE TOFFEE ALMOND',   59000, 3 ),
----------------------------------------------
( N'BLACK TEA MACCHIATO',           38000, 4 ),
( N'FLAVOURED TEA',                 35000, 4 ),
( N'HOT BLACK TEA',                 35000, 4 ),
( N'MATCHA ICE BLENDED',            59000, 4 ),
( N'MATCHA LATTE',                  55000, 4 ),
( N'PEACH TEA MANIA',               42000, 4 ),
( N'RASPBERRY MACCHIATO',           42000, 4 ),
----------------------------------------------
( N'BLUBERRY SMOOTHIE',             59000, 5 ),
( N'BLUEBERRY SODA',                45000, 5 ),
( N'GREEN APPLE',                   45000, 5 ),
( N'MANGO ORANGE COOKIE SMOOTHIE',  59000, 5 ),
( N'MOJITO LEMON',                  45000, 5 ),
( N'MOJITO PASSION FRUIT',          45000, 5 ),
( N'RASPBERRY SODA',                59000, 5 ),
----------------------------------------------
( N'DULCE DE LECHE',                59000, 6 ),
( N'RASPBERRY LEMON',               69000, 6 ),
( N'GERMAN CHOCOLATE',              59000, 6 ),
( N'COOKIES & CREAM',               59000, 6 ),
( N'PISTACHIO PRALINE',             45000, 6 ),
( N'CHOCOLATE MALT',                45000, 6 ),
( N'COCONUT CLOUD',                 69000, 6 )
GO