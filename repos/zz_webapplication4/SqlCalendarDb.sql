
-- sql script


-- db data source : (localdb)\MSSQLLocalDB

-- create database CalendarDb
go

use CalendarDb
go

-- drop table TblOmer
go

create table TblOmer
(
	Yom	int primary key , -- unique + not null + index
	Sod1 nvarchar(10) ,
	Sod2 nvarchar(10) ,
	Teur nvarchar(200) ,
	ModifiedDate smalldatetime not null ,
	ModifiedBy nvarchar(20) not null ,
	Picture nvarchar(100) ,
)
go

-- drop view VwOmer
go

create view VwOmer as
select
	Yom,
	(yom / 7 ) as Weeks ,
	(yom % 7 ) as Yamim ,
	Sod1,
	Sod2,
	Teur,
	ModifiedDate ,
	ModifiedBy ,
	Picture 
from
	TblOmer
go



-- :)


