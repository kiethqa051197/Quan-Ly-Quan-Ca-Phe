CREATE DATABASE QUANCAFE;

CREATE TABLE POSITIONS
(
	id int identity(1,1) primary key,
	name nvarchar(max) not null
)
GO

CREATE TABLE STAFFS
(
	 id int identity(1,1) primary key,
	 fullname nvarchar(max) not null,
	 dateofbirth date not null,
	 sex int not null,
	 address nvarchar(max) not null,
	 phone nvarchar(11) null,
	 idPosition int,

	 foreign key (idPosition) references POSITIONS(id)
)
go

CREATE TABLE ACCOUNTS
(
	id int identity(1,1) primary key,
	username varchar(max) not null,
	password varchar(max) not null,
	idStaff int, 

	foreign key (idStaff) references STAFFS(id)
)
GO

CREATE TABLE CATEGORYS
(
	id int identity(1,1) primary key,
	name nvarchar(max) not null
)
GO

CREATE TABLE MENUITEMS
(
	id int identity(1,1) primary key,
	name nvarchar(max) not null,
	price float not null,
	idCategory int,

	foreign key (idCategory) references CATEGORYS(id)
)
GO

CREATE TABLE TABLES
(
	id int identity(1,1) primary key,
	name nvarchar(max) not null,
	status int not null
)
GO

CREATE TABLE BILLS
(
	id int identity(1,1) primary key,
	idTable int,
	dateCheckIn date, 
	dateCheckOut date,
	status int,
	discount int,

	foreign key (idTable) references TABLES(id)
)
GO

CREATE TABLE BILLINFOS
(
	id int identity(1,1) primary key,
	idBill int,
	idMenuItems int,
	count int,

	foreign key (idBill) references BILLS(id),
	foreign key (idMenuItems) references MENUITEMS(id),
)
GO

CREATE TABLE UNITS
(
	id int identity(1,1) primary key,
	displayName nvarchar(max)
)
GO

CREATE TABLE SUPLIERS
(
	id int identity(1,1) primary key,
	displayName nvarchar(max),
	address nvarchar(max),
	phone nvarchar(20),
	email nvarchar(200),
	moreInfo nvarchar(max),
	contractDate DateTime
)
GO

CREATE TABLE OBJECTS
(
	id nvarchar(128) primary key,
	displayName nvarchar(max),
	idUnit int not null,
	idSuplier int not null,

	foreign key(idUnit) references UNITS(id),
	foreign key(idSuplier) references SUPLIERS(id),
)
GO

CREATE TABLE INPUTS
(
	id nvarchar(128) primary key,
	dateInput DateTime
)
GO

CREATE TABLE INPUTINFOS
(
	id nvarchar(128) primary key,
	idObject nvarchar(128) not null,
	idInput nvarchar(128) not null,
	count int,
	inputPrice float default 0,
	outputPrice float default 0,
	status nvarchar(max)

	foreign key (IdObject) references OBJECTS(id),
	foreign key (IdInput) references INPUTS(id)
)
GO

CREATE TABLE OUTPUTS
(
	id nvarchar(128) primary key,
	dateOutput DateTime
)
GO

CREATE TABLE OUTPUTINFOS
(
	id nvarchar(128) primary key,
	idObject nvarchar(128) not null,
	idInputInfo nvarchar(128) not null,
	count int,	
	status nvarchar(max)

	foreign key (IdObject) references OBJECTS(id),
	foreign key (IdInputInfo) references INPUTINFOS(id)
)
GO