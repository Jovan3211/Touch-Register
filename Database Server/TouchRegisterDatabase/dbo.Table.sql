CREATE TABLE [dbo].[Table]
(
	[Barcode] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Manufacturer] NVARCHAR(50) NOT NULL, 
    [PriceNoTax] MONEY NOT NULL, 
    [Price] MONEY NOT NULL
)
