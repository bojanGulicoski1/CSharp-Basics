CREATE DATABASE TestDatabase

create table dbo.BusinessEntity
(
Id int not null,
[Name] nvarchar(30)  null,
Region nvarchar(1000)  null,
ZipCode nvarchar(10),
Size nvarchar(10)
)

select * 
from dbo.BusinessEntity

create table dbo.Employee
(
Id int not null,
FirstName nvarchar(100) not null,
LastName nvarchar(100) not null,
DateOfBirth date  null,
Gender nchar (1) null,
HireDate date null,
NationalNumber nvarchar (20) null
)


select * 
from dbo.Employee

create table dbo.Product
(
Id int not null,
Code nvarchar(50)  null,
[Name] nvarchar(100)  null,
[Description] nvarchar(MAX)  null,
[Weight] decimal (18 , 2) null,
Price decimal (18 , 2) null,
Cost  decimal (18 , 2) null
)

select * 
from dbo.Product

create table dbo.Customer
(
Id int not null,
[Name] nvarchar(100) not null,
AccountNumber nvarchar(50) null,
City nvarchar(100) null,
RegionName nvarchar(100) null,
CustomerSize nvarchar(10) null,
PhoneNumber nvarchar(20) null,
IsActive bit not null
)

select * 
from dbo.Customer

create table dbo.Orders
(
Id bigint not null,
OrderDate datetime   null,
[Status] smallint null,
BusinessEntityId int  null,
CustomerId int null,
EmployeeId int null,
TottalPrice decimal (18 ,2 ) null,
Comment nvarchar (MAX)  null
)

select * 
from dbo.Orders

create table dbo.OrderDetails
(
Id bigint not null,
OrderId bigint   null,
ProductId int null,
Quantity int  null,
Price decimal(18 , 2) null,
)

select * 
from dbo.Orders