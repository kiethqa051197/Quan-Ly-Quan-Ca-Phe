CREATE DATABASE QUANCAFE;

use QUANCAFE;

CREATE TABLE POSITIONS
(
	id int identity(1,1) primary key,
	name nvarchar(max) not null
)

CREATE TABLE STAFFS
(
	 id int identity(1,1) primary key,
	 fullname nvarchar(max) not null,
	 dateofbirth date not null,
	 sex int not null,
	 idCard varchar(max), 
	 address nvarchar(max) not null,
	 phone nvarchar(11) null,
	 idPosition int,

	 foreign key (idPosition) references POSITIONS(id)
)

CREATE TABLE ACCOUNTS
(
	id int identity(1,1) primary key,
	username varchar(max) not null,
	password varchar(max) not null,
	idStaff int, 

	foreign key (idStaff) references STAFFS(id)
)

CREATE TABLE CATEGORYS
(
	id int identity(1,1) primary key,
	name nvarchar(max) not null
)

CREATE TABLE MENUITEMS
(
	id int identity(1,1) primary key,
	name nvarchar(max) not null,
	price float not null,
	idCategory int,

	foreign key (idCategory) references CATEGORYS(id)
)

CREATE TABLE TABLES
(
	id int identity(1,1) primary key,
	name nvarchar(max) not null,
	status int not null
)

CREATE TABLE CUSTOMERS
(
	id int identity(1,1) primary key,
	sex int,
	displayName nvarchar(max),
	idCard varchar(max),
	dateofbirth date,
	address nvarchar(max),
	phone nvarchar(20),
	contractDate dateTime
)

CREATE TABLE BILLS
(
	id int identity(1,1) primary key,
	idTable int,
	idCustomer int,
	dateCheckIn date, 
	dateCheckOut date,
	status int,
	discount int,
	idStaff int,

	foreign key (idCustomer) references CUSTOMERS(id),
	foreign key (idTable) references TABLES(id),
	foreign key (idStaff) references STAFFS(id)
)

CREATE TABLE BILLINFOS
(
	id int identity(1,1) primary key,
	idBill int,
	idMenuItems int,
	count int,

	foreign key (idBill) references BILLS(id),
	foreign key (idMenuItems) references MENUITEMS(id),
)

CREATE TABLE UNITS
(
	id int identity(1,1) primary key,
	displayName nvarchar(max)
)

CREATE TABLE SUPLIERS
(
	id int identity(1,1) primary key,
	displayName nvarchar(max),
	address nvarchar(max),
	phone nvarchar(20),
	email nvarchar(200)
)

CREATE TABLE OBJECTS
(
	id nvarchar(128) primary key,
	displayName nvarchar(max),
	idUnit int not null,
	idSuplier int not null,

	foreign key(idUnit) references UNITS(id),
	foreign key(idSuplier) references SUPLIERS(id),
)

CREATE TABLE INPUTS
(
	id nvarchar(128) primary key,
	dateInput DateTime
)

CREATE TABLE INPUTINFOS
(
	id nvarchar(128) primary key,
	idObject nvarchar(128) not null,
	idInput nvarchar(128) not null,
	count int,
	inputPrice float default 0,
	status nvarchar(max),

	foreign key (idObject) references OBJECTS(id),
	foreign key (idInput) references INPUTS(id)
)

CREATE TABLE OUTPUTS
(
	id nvarchar(128) primary key,
	dateOutput DateTime
)

CREATE TABLE OUTPUTINFOS
(
	id nvarchar(128) primary key,
	idObject nvarchar(128) not null,
	idOutput nvarchar(128) not null,
	count int,	
	status nvarchar(max),

	foreign key (idObject) references OBJECTS(id),
	foreign key (idOutput) references OUTPUTS(id)
)