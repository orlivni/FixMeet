CREATE TABLE [dbo].[Supplier]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NCHAR(50) NOT NULL, 
    [LastName] NCHAR(50) NOT NULL, 
    [Email] NCHAR(50) NOT NULL, --Primary Key, 
    [UserName] NCHAR(50) NOT NULL, 
    [Radius] INT NOT NULL, 
   -- [Category] NVARCHAR(50) references Category(CategoryName) NOT NULL,
   -- [Address] NVARCHAR(50) references Address(City) NOT NULL
)
