--Create database Treining1

USE Treining1

--Create Table Adresses(
	--idAdres int IDentity(1,1) Primary key not null,
	--Adress varchar(255)
--)

--Create table USers(
	--id int identity(1,1) Primary key not null,
	--Role varchar(255) not null,
	--FIO varchar(255) not null,
	--Login varchar(255) not null,
	--Password varchar(255) not null,
--)

--Create table Tovar(
	--id int identity(1,1) primary key not null,
	--Article varchar(255) not null,
	--Nameing varchar(255) not null,
	--EdIzm varchar(255) not null,
	--Price int not null,
	--Supplier varchar(255) not null,
	--ProductCreater varchar (255) not null,
	--Category varchar (255) not null,
	--Discount int not null,
	--Count int not null,
	--Note varchar(255) not null,
	--Photo varchar(255),
--)

--Create Table Orders(
	--idOrder int identity(1,1) primary key not null,
	--articleId int not null,
	--DateOrder datetime not null,
	--DateDilivery datetime not null,
	--Adress int not null
		--Foreign key references Adresses(idAdres),
	--Users int not null
		--Foreign key references USers(id),
	--Code int not null,
	--Statuses varchar(255) not null,
--)

--create table Details(
	--IDdetails int identity(1,1) Primary key not null,
	--idOrder int not null
		--Foreign Key references Orders(idOrder),
	--idProduct int not null
		--Foreign Key references Tovar(id),
	--Count int not null,
--)