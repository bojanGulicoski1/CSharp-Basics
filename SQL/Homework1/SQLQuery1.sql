create database SEDCACADEMYDB

use SEDCACADEMYDB
create table dbo.Student(
Id int not null,
FirstName nvarchar(50) not null ,
LastName nvarchar (50) not null,
DateOfBirth date not null,
EnroledDate datetime not null,
Gender nchar(1) not null,
NationalIdNumber int null,
StudentCardNumber int null
)

select * 
from Student

create table dbo.Teacher(
Id int identity (1,1),
FirstName nvarchar(50),
LastName nvarchar (50) not null,
DateOfBirth date not null,
AcademicRank int null,
HireDate date null
)

select * 
from dbo.Teacher

create table dbo.Grade(
Id int identity (1 , 1),
StudentId int not null,
CourseId int not null,
TeacherId int not null,
Grade int not null,
Comment nvarchar (MAX) null,
CreateDate datetime null
)

select * 
from dbo.Grade

create table dbo.Course(
Id int identity (1 ,1 ),
[Name] nvarchar(100) not null,
[Credit] int not null,
AcademicYear int not null,
Semester smallint not null
)

select *
from dbo.Course

create table dbo.GradeDetails(
Id int identity(1,1),
GradeId int not null,
AchivementTypeId int not null,
AchivementPoints int not null,
AchivementMaxPoints int not null,
AchivementDate datetime null
)

select *
from dbo.GradeDetails

create table dbo.AchivementType(
Id int identity(1,1),
[Name] nvarchar(50) not null,
[Description] nvarchar(MAX) null,
PArticipationRate int null
)
