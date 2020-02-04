-- Tạo CSDL
CREATE DATABASE QUANCAFE;

-- Sử dụng CSDL
USE QUANCAFE;

-- Bảng Chức Vụ
CREATE TABLE POSITIONS
(
	id int identity(1,1) primary key,
	name nvarchar(max) not null,
	salary int null
)

INSERT POSITIONS(name, salary) values (N'Nhân viên', 3000000)
INSERT POSITIONS(name, salary) values(N'Giữ xe', 2000000)
INSERT POSITIONS(name, salary) values( N'Thử việc', 1500000)
INSERT POSITIONS(name, salary) values( N'Admin', null)

-- Bảng Nhân Viên
CREATE TABLE STAFFS
(
	 id int identity(1,1) primary key,
	 fullname nvarchar(max) not null,
	 dateofbirth date not null,
	 gender bit not null, -- 1 LÀ Nam, 0 là nữ
	 idCard varchar(12) not null, 
	 address nvarchar(max) not null,
	 phone varchar(11) null,
	 idPosition int not null,

	 foreign key (idPosition) references POSITIONS(id)
)

INSERT STAFFS(fullname, dateofbirth, gender, idCard, address, phone, idPosition) 
				  values(N'Lee Hoàng Giang', '1997-01-25', 1, '2721564645', N'Mộ Đức, Đà Nẵng', '0938540130', 1)

INSERT STAFFS(fullname, dateofbirth, gender, idCard, address, phone, idPosition) 
				  values(N'Nguyễn An Bình', '1986-10-13', 1, '45615463221', N'An Giang', '0138562100', 2)

INSERT STAFFS(fullname, dateofbirth, gender, idCard, address, phone, idPosition) 
				  values(N'Lê Thị Kiều', '1999-08-19', 0, '785605321', N'Phú Yên', '0168552435', 3)

INSERT STAFFS(fullname, dateofbirth, gender, idCard, address, phone, idPosition) 
				  values(N'Hà Quốc Anh Kiệt', '1997-11-05', 1, '3121564645', N'Đồng Nai', '0378834457', 4)

-- Bảng Tài khoản nhân viên
CREATE TABLE ACCOUNTS
(
	id int identity(1,1) primary key,
	username varchar(max) not null,
	password varchar(max) not null,
	idStaff int not null, 

	foreign key (idStaff) references STAFFS(id)
)

INSERT INTO ACCOUNTS(username, password, idStaff) values ('785605321', '123456', 4)
INSERT INTO ACCOUNTS(username, password, idStaff) values ('3121564645', '123456', 3)

-- Bảng Danh Mục
CREATE TABLE CATEGORIES
(
	id int identity(1,1) primary key,
	name nvarchar(max) not null
)

INSERT CATEGORIES (name) VALUES (N'Hải sản')
INSERT CATEGORIES (name) VALUES (N'Nông sản')
INSERT CATEGORIES (name) VALUES (N'Lâm sản')
INSERT CATEGORIES (name) VALUES (N'Sản sản')
INSERT CATEGORIES (name) VALUES (N'Nước')

SELECT * FROM CATEGORIES

-- Bảng Sản Phẩm (Mỗi danh mục có chứa nhiều sản phẩm)
CREATE TABLE ITEMS
(
	id int identity(1,1) primary key,
	name nvarchar(max) not null,
	price float not null,
	idCategory int not null,

	foreign key (idCategory) references CATEGORIES(id)
)

INSERT ITEMS (name, idCategory, price) VALUES (N'Mực một nắng nước sa tế', 1, 120000)
INSERT ITEMS (name, idCategory, price) VALUES (N'Nghêu hấp xả', 1, 50000)
INSERT ITEMS (name, idCategory, price) VALUES (N'Dú dê nướng sữa', 2, 60000)
INSERT ITEMS (name, idCategory, price) VALUES (N'Heo rừng nướng muối ớt', 3, 75000)
INSERT ITEMS (name, idCategory, price) VALUES (N'Cơm chiên mushi', 4, 999999)
INSERT ITEMS (name, idCategory, price) VALUES (N'7Up', 5, 15000)
INSERT ITEMS (name, idCategory, price) VALUES (N'Cafe', 5, 12000)

-- Bảng Bàn Ăn
CREATE TABLE TABLES
(
	id int identity(1,1) primary key,
	name nvarchar(max) not null,
	status nvarchar(max) not null
)

INSERT TABLES (name, status) VALUES (N'Bàn 0', N'Trống')
INSERT TABLES (name, status) VALUES (N'Bàn 1', N'Trống')
INSERT TABLES (name, status) VALUES (N'Bàn 2', N'Trống')
INSERT TABLES (name, status) VALUES (N'Bàn 3', N'Trống')
INSERT TABLES (name, status) VALUES (N'Bàn 4', N'Trống')
INSERT TABLES (name, status) VALUES (N'Bàn 5', N'Trống')
INSERT TABLES (name, status) VALUES (N'Bàn 6', N'Trống')
INSERT TABLES (name, status) VALUES (N'Bàn 7', N'Trống')
INSERT TABLES (name, status) VALUES (N'Bàn 8', N'Trống')
INSERT TABLES (name, status) VALUES (N'Bàn 9', N'Trống')
INSERT TABLES (name, status) VALUES (N'Bàn 10', N'Trống')
INSERT TABLES (name, status) VALUES (N'Bàn 11', N'Trống')
INSERT TABLES (name, status) VALUES (N'Bàn 12', N'Trống')
INSERT TABLES (name, status) VALUES (N'Bàn 13', N'Trống')
INSERT TABLES (name, status) VALUES (N'Bàn 14', N'Trống')
INSERT TABLES (name, status) VALUES (N'Bàn 15', N'Trống')
INSERT TABLES (name, status) VALUES (N'Bàn 16', N'Trống')
INSERT TABLES (name, status) VALUES (N'Bàn 17', N'Trống')
INSERT TABLES (name, status) VALUES (N'Bàn 18', N'Trống')
INSERT TABLES (name, status) VALUES (N'Bàn 19', N'Trống')

-- Bảng Khách Hàng
CREATE TABLE CUSTOMERS
(
	id int identity(1,1) primary key,
	sex int not null,
	name nvarchar(max) not null,
	idCard varchar(max) not null,
	dateofbirth date not null,
	address nvarchar(max) not null,
	phone nvarchar(20) null,
	createDate dateTime not null
)

-- Bảng Hoá đơn
CREATE TABLE BILLS
(
	id int identity(1,1) primary key,
	idTable int not null,
	idCustomer int null,
	dateCheckIn date not null, 
	dateCheckOut date not null,
	status int not null,
	discount int null default 0,
	idStaff int not null,

	foreign key (idCustomer) references CUSTOMERS(id),
	foreign key (idTable) references TABLES(id),
	foreign key (idStaff) references STAFFS(id)
)

-- Bảng Chi Tiết Hoá Đơn
CREATE TABLE BILLINFOS
(
	id int identity(1,1) primary key,
	idBill int not null,
	idItems int not null,
	count int not null,

	foreign key (idBill) references BILLS(id),
	foreign key (idItems) references ITEMS(id),
)

-- Bảng Đơn vị (Đơn vị tính)
CREATE TABLE UNITS
(
	id int identity(1,1) primary key,
	name nvarchar(max) not null
)

-- Bảng Nhà cung cấp
CREATE TABLE SUPPLIERS
(
	id int identity(1,1) primary key,
	name nvarchar(max) not null,
	address nvarchar(max) not null,
	phone nvarchar(20) null,
	email nvarchar(200) null
)

-- Bảng đối tượng
CREATE TABLE OBJECTS
(
	id nvarchar(128) primary key,
	name nvarchar(max) not null,
	idUnit int not null,
	idSupplier int not null,

	foreign key(idUnit) references UNITS(id),
	foreign key(idSupplier) references SUPPLIERS(id),
)

-- Bảng nhập kho
CREATE TABLE INPUTS
(
	id nvarchar(128) primary key,
	dateInput DateTime not null
)

-- Bảng Chi Tiết Nhập kho
CREATE TABLE INPUTINFOS
(
	id nvarchar(128) primary key,
	idObject nvarchar(128) not null,
	idInput nvarchar(128) not null,
	count int not null,
	inputPrice float not null default 0,
	status nvarchar(max) not null,

	foreign key (idObject) references OBJECTS(id),
	foreign key (idInput) references INPUTS(id)
)

-- Bảng Xuất kho
CREATE TABLE OUTPUTS
(
	id nvarchar(128) primary key,
	dateOutput DateTime not null
)

-- Bảng Chi Tiết xuất kho
CREATE TABLE OUTPUTINFOS
(
	id nvarchar(128) primary key,
	idObject nvarchar(128) not null,
	idOutput nvarchar(128) not null,
	count int not null,	
	status nvarchar(max) not null,

	foreign key (idObject) references OBJECTS(id),
	foreign key (idOutput) references OUTPUTS(id)
)
GO

-- Đăng nhập
CREATE PROCEDURE PC_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM ACCOUNTS WHERE username = @userName AND password = @passWord
END
GO

-- Lấy tài khoản từ username
CREATE PROC PC_GetAccountByUserName
@userName nvarchar(100)
AS 
BEGIN
	SELECT * FROM ACCOUNTS WHERE username = @userName
END
GO

-- Lấy danh sách bàn
CREATE PROC PC_GetTableList
AS SELECT * FROM TABLES
GO

-- Lấy tổng số hoá đơn theo ngày
CREATE PROC PC_GetNumBillByDate
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT COUNT(*)
	FROM BILLS AS b, TABLES AS t
	WHERE dateCheckIn >= @checkIn AND dateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO

-- Lấy danh sách hoá đơn theo ngày cho report
CREATE PROC PC_GetListBillByDateForReport
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT t.name, dateCheckIn, dateCheckOut, discount
	FROM BILLS AS b, TABLES AS t
	WHERE dateCheckIn >= @checkIn AND dateCheckOut <= @checkOut AND b.status = 1 AND t.id = b.idTable
END
GO

-- Phân trang
CREATE PROC PC_GetListBillByDateAndPage
@checkIn date, @checkOut date, @page int
AS 
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1) * @pageRows;
	
	WITH BillShow AS( SELECT b.ID, t.name AS [Tên bàn], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá]
						FROM dbo.Bill AS b,dbo.TableFood AS t
						WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1 AND t.id = b.idTable)
	SELECT TOP (@selectRows) * FROM BillShow WHERE id NOT IN (SELECT TOP (@exceptRows) id FROM BillShow)
END
GO

-- Lấy danh sách hoá đơn theo ngày
CREATE PROC PC_GetListBillByDate
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT t.name AS [Tên bàn], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá]
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1 AND t.id = b.idTable
END
GO

-- Thêm Hoá đơn
CREATE PROC PC_InsertBill
@idTable INT
AS
BEGIN
	INSERT dbo.Bill 
	        ( DateCheckIn ,
	          DateCheckOut ,
	          idTable ,
	          status,
	          discount
	        )
	VALUES  ( GETDATE() , -- DateCheckIn - date
	          NULL , -- DateCheckOut - date
	          @idTable , -- idTable - int
	          0,  -- status - int
	          0
	        )
END
GO

-- Thêm chi tiết hoá đơn
CREATE PROC PC_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @isExitsBillInfo = id, @foodCount = b.count 
	FROM dbo.BillInfo AS b 
	WHERE idBill = @idBill AND idFood = @idFood

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.BillInfo	SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT	dbo.BillInfo
        ( idBill, idFood, count )
		VALUES  ( @idBill, -- idBill - int
          @idFood, -- idFood - int
          @count  -- count - int
          )
	END
END
GO

-- Chuyển bàn
CREATE PROC PC_SwitchTabel
@idTable1 INT, @idTable2 int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idFirstBill IS NULL)
	BEGIN
		PRINT '0000001'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable1 , -- idTable - int
		          0  -- status - int
		        )
		        
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idSeconrdBill IS NULL)
	BEGIN
		PRINT '0000002'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable2 , -- idTable - int
		          0  -- status - int
		        )
		SELECT @idSeconrdBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	UPDATE dbo.BillInfo SET idBill = @idSeconrdBill WHERE idBill = @idFirstBill
	
	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
END
GO

select p.name
from POSITIONS as p