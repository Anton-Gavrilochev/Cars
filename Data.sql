use [Cars]
go
truncate table [dbo].[Customers]
go
insert into [dbo].[Customers] ([name]) values (N'Max')
insert into [dbo].[Customers] ([name]) values (N'Pavel')
insert into [dbo].[Customers] ([name]) values (N'Ivan')
insert into [dbo].[Customers] ([name]) values (N'Leonid')
go
truncate table [dbo].[Orders]
go
insert into [dbo].[Orders] ([CustomerId]) values (2)
insert into [dbo].[Orders] ([CustomerId]) values (4)
go