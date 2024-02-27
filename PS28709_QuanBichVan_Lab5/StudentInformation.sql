create database StudentInformation

use StudentInformation

create table StudentDetails
(
	Id int identity primary key,
	Name nvarchar(50),
	Age int,
	City nvarchar(50),
	Gender nvarchar(50)
)