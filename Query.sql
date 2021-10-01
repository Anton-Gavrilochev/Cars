use [Cars]
go
select [customers].[name] as 'customers'
from [customers]
where not exists (
	select 1
	from [orders]
	where [orders].[customerid] = [customers].[id])