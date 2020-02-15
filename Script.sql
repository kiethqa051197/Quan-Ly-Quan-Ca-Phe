﻿-- Tạo CSDL
CREATE DATABASE QUANCAFE;

-- Sử dụng CSDL
USE QUANCAFE;

-- Bảng Nhân Viên
CREATE TABLE STAFFS
(
	 id int identity(1,1) primary key,
	 fullname nvarchar(max) not null,
	 dateofbirth date not null,
	 gender bit not null, -- 1 Là Nam, 0 là Nữ
	 idCard varchar(12) not null, 
	 address nvarchar(max) not null,
	 phone varchar(11) null
)

INSERT STAFFS(fullname, dateofbirth, gender, idCard, address, phone) 
				  values(N'Lee Hoàng Giang', '1997-01-25', 1, '2721564645', N'Mộ Đức, Đà Nẵng', '0938540130')

INSERT STAFFS(fullname, dateofbirth, gender, idCard, address, phone) 
				  values(N'Nguyễn An Bình', '1986-10-13', 1, '45615463221', N'An Giang', '0138562100')

INSERT STAFFS(fullname, dateofbirth, gender, idCard, address, phone) 
				  values(N'Lê Thị Kiều', '1999-08-19', 0, '785605321', N'Phú Yên', '0168552435')

INSERT STAFFS(fullname, dateofbirth, gender, idCard, address, phone) 
				  values(N'Hà Quốc Anh Kiệt', '1997-11-05', 1, '3121564645', N'Đồng Nai', '0378834457')

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
INSERT CATEGORIES (name) VALUES (N'Nước')

ALTER TABLE CATEGORIES
ADD CONSTRAINT df_StatusCategories
DEFAULT 1 FOR status;

ALTER TABLE CATEGORIES DROP CONSTRAINT df_status;  

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
INSERT ITEMS (name, idCategory, price) VALUES (N'7 Up', 4, 15000)
INSERT ITEMS (name, idCategory, price) VALUES (N'Cafe', 4, 12000)

-- Bảng Bàn Ăn
CREATE TABLE TABLES
(
	id int identity(1,1) primary key,
	name nvarchar(max) not null,
	status nvarchar(max) not null
)

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
INSERT TABLES (name, status) VALUES (N'Bàn 20', N'Trống')

ALTER TABLE TABLES
ADD CONSTRAINT df_status
DEFAULT N'Trống' FOR status;

ALTER TABLE TABLES DROP CONSTRAINT df_status;  

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
	dateCheckOut date null,
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
	   @idTable INT, 
       @idStaff INT
AS
BEGIN
	DECLARE @idCustomer INT

	SELECT @idCustomer = id FROM CUSTOMERS WHERE createDate = '1991-01-01' and NAME = N'Mặc định' and gender = 1

	INSERT BILLS (idTable, idCustomer, dateCheckIn, dateCheckOut, discount, status, idStaff)
	VALUES (@idTable, @idCustomer, GETDATE(), GETDATE(), 0, 0, @idStaff)
END
GO

-- Thêm chi tiết hoá đơn
CREATE PROC PC_InsertBillInfo
@idBill INT, @idItems INT, @price INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @itemCount INT = 1
	
	SELECT @isExitsBillInfo = id, @itemCount = b.count 
	FROM BILLINFOS AS b 
	WHERE idBill = @idBill AND idItems = @idItems

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @itemCount + @count
		IF (@newCount > 0)
			UPDATE BILLINFOS SET price = @price, count = @itemCount + @count WHERE idItems = @idItems
		ELSE
			DELETE BILLINFOS WHERE idBill = @idBill AND idItems = @idItems
	END
	ELSE
	BEGIN
		INSERT BILLINFOS (idBill, idItems, price, count )
		VALUES ( @idBill, @idItems, @price, @count)
	END
END
GO

-- Chuyển bàn
CREATE PROC PC_SwitchTable
	@idTable1 INT, @idTable2 INT, @idStaff INT
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	DECLARE @idCustomer INT

	SELECT @idCustomer = id FROM CUSTOMERS WHERE createDate = '1991-01-01' and NAME = N'Mặc định' and gender = 1
	SELECT @idSeconrdBill = id FROM BILLS WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM BILLS WHERE idTable = @idTable1 AND status = 0
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idFirstBill IS NULL)
	BEGIN
		PRINT '0000001'
		INSERT BILLS(idTable, idCustomer, dateCheckIn, dateCheckOut, status, discount, idStaff)
		VALUES (@idTable1, @idCustomer, GETDATE(), GETDATE(), 0, 0, @idStaff)
		        
		SELECT @idFirstBill = MAX(id) FROM BILLS WHERE idTable = @idTable1 AND status = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM BILLINFOS WHERE idBill = @idFirstBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idSeconrdBill IS NULL)
	BEGIN
		PRINT '0000002'

		INSERT BILLS(idTable, idCustomer, dateCheckIn, dateCheckOut, status, discount, idStaff)
		VALUES (@idTable2, @idCustomer, GETDATE(), GETDATE(), 0, 0, @idStaff)

		SELECT @idSeconrdBill = MAX(id) FROM BILLS WHERE idTable = @idTable2 AND status = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM BILLINFOS WHERE idBill = @idSeconrdBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'

	SELECT id INTO IDBillInfoTable FROM BILLINFOS WHERE idBill = @idSeconrdBill
	
	UPDATE BILLINFOS SET idBill = @idSeconrdBill WHERE idBill = @idFirstBill
	
	UPDATE BILLINFOS SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE TABLES SET status = N'Trống' WHERE id = @idTable2
	ELSE 
		UPDATE TABLES SET status = N'Có người' WHERE id = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE TABLES SET status = N'Trống' WHERE id = @idTable1
	ELSE 
		UPDATE TABLES SET status = N'Có người' WHERE id = @idTable1
END
GO

-- bỏ dấu chữ nhập vào
DROP FUNCTION dbo.fuConvertToUnsign1

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) 
	RETURNS NVARCHAR(4000) 
AS 
BEGIN 
	IF @strInput IS NULL RETURN @strInput 

	IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) 

	DECLARE @SIGN_CHARS NCHAR(136) 
	DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272) + NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
	DECLARE @COUNTER int 
	DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) 
	BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
		BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
			BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
			ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
				BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','') RETURN @strInput 
END

--- Thêm nhân viên mới đồng thời cũng tạo tài khoản mới cho nhân viên đó
DROP PROC PC_AddNewStaff

CREATE PROC PC_AddNewStaff
	@fullname NVARCHAR(MAX), 
	@dateofbirth DATE, 
	@gender BIT,
	@idCard VARCHAR(MAX) = NULL, 
	@address NVARCHAR(MAX) = NULL, 
	@phone VARCHAR(MAX) = NULL
AS
BEGIN	
	INSERT dbo.STAFFS 
	        ( fullname ,
	          dateofbirth ,
	          gender ,
	          idCard ,
	          address ,
	          phone
	        )
	VALUES  ( @fullname , -- fullname - nvarchar(max)
	          @dateofbirth, -- dateofbirth - date
	          @gender , -- gender - bit
	          @idCard , -- idCard - varchar(12)
	          @address , -- address - nvarchar(max)
	          @phone -- phone - varchar(11)
	        )

	DECLARE @idStaff INT = 0
	DECLARE @username VARCHAR(MAX) = ''
	
	SELECT @username = dbo.fuConvertToUnsign1(@fullname)
	SELECT @idStaff = id FROM dbo.STAFFS WHERE id=( SELECT max(id) FROM dbo.STAFFS)

	IF @idCard IS NOT NULL
		INSERT dbo.ACCOUNTS ( username, password, idStaff, type ) VALUES  ( @idCard, '123456', @idStaff, 0)
	ELSE 
	BEGIN
		IF @phone IS NOT NULL 
			INSERT dbo.ACCOUNTS ( username, password, idStaff, type ) VALUES  ( @phone, '123456', @idStaff, 0)
		ELSE
			INSERT dbo.ACCOUNTS ( username, password, idStaff, type ) VALUES  ( @username, '123456', @idStaff, 0)
	END
END
GO

-- Xóa Nhân viên 
DROP PROC PC_DeleteStaff

CREATE PROC PC_DeleteStaff
	@id INT
AS	
BEGIN
	DECLARE @idStaff INT

	SELECT @idStaff = id FROM STAFFS WHERE fullname = N'Mặc định' AND dateofbirth = '1997-01-01' AND gender = 1

	UPDATE dbo.BILLS SET idStaff = @idStaff WHERE id = @id
	
	DELETE dbo.ACCOUNTS WHERE idStaff = @id
	UPDATE dbo.STAFFS SET status = 0 WHERE id = @id
END	
GO

SELECT * FROM dbo.STAFFS EXCEPT SELECT * FROM dbo.STAFFS WHERE id = 1

/* 
2020 tháng 1 - món x :  (Tồn đầu kỳ ; Tồn cuối kỳ) :  100 ly cafe (20k/1)
- Nhập vô 100, Bán được 80 (cafe) : 7k/1 (còn 20)
- Nhập vô 100, Bán được 70 (đường) : 8k/1 (còn 30)
.................  
- Tồn đầu kỳ = 0 + 0 = 0
- tồn cuối kỳ : (100 + 100 + 0) - (80 + 70) => tồn tháng 1 = 50
Giá trị Trung bình (all món) = (0 * 7 + 0 * 8 + 100 * 7 + 100 * 8 ) / (100 + 100 + 0 + 0)  = 7.5
 
1 ly cafe = ? cafe + ? đường
Lợi Nhuận = (20 * 100) - (7.5 * 80 + 7.5 * 70) = 875k

tháng 2 - món x :  100 ly cafe (20k/1)
- Nhập vô 90, Bán được 90 (cafe) : 8k/1 (0)
- Nhập vô 110, Bán được 60 (đường) : 6k/1 (còn 50)
- tồn đầu kỳ = tồn cuối tháng 1 (20 + 30 = 50)
- tồn cuối kỳ : 0 + 50 = 50
Giá trị Trung bình (all món) = (20 * 8 + 30 * 6 + 90 * 8 + 110 * 6 ) / (90 + 110 + 0 + 50)  = 6.88
Lợi Nhuận = (20 * 100) - (6.88 * 90 + 6.88 * 60) = 3032k

tháng 3 - món x :  (.......)
..........
- discount
- lương staff 
- .......
Bình quân gia quyền
Lợi Nhuận = Tổng Trị giá bán - (Tổng trị giá nhập + Trị giá tồn + discount + lượng + .....)

Lợi Nhuận = (20 * 100) - (6.88 * 90 + 6.88 * 60 + 20 * 8 + 30 * 6) = ....k
*/

SELECT * FROM CATEGORIES WHERE STATUS = 1 EXCEPT (SELECT * FROM CATEGORIES WHERE id = 1)