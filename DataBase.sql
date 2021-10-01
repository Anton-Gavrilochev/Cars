create database Cars
go
use Cars
go
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Customers]') AND type in (N'U'))
DROP TABLE [dbo].[Customers]
GO
CREATE TABLE [dbo].[Customers](
[Id] [int] IDENTITY(1,1) NOT NULL,
[Name] NVARCHAR(300) NOT NULL,
CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED (Id ASC),
);
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Orders]') AND type in (N'U'))
DROP TABLE [dbo].[Orders]
GO
CREATE TABLE [dbo].[Orders](
[Id] INT IDENTITY(1,1) NOT NULL,
[CustomerId] INT NOT NULL,
CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED (Id ASC)
);
GO