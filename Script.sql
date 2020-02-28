-- Tạo CSDL
CREATE DATABASE QUANCAFE;

-- Sử dụng CSDL
USE QUANCAFE;

-- Bảng Nhân Viên
CREATE TABLE STAFFS
(
	 id int identity(1,1) primary key,
	 fullname nvarchar(max) not null,
	 dateofbirth date not null,
	 idCard varchar(12) null, 
	 address nvarchar(max) null,
	 phone varchar(11) NULL,
     status INT NOT NULL DEFAULT 0
)

INSERT STAFFS(fullname, dateofbirth, idCard, address, phone, status) 
				  values(N'Lee Hoàng Giang', '1997-01-25', '2721564645', N'Mộ Đức, Đà Nẵng', '0938540130', 0)

INSERT STAFFS(fullname, dateofbirth, idCard, address, phone, status) 
				  values(N'Nguyễn An Bình', '1986-10-13', '45615463221', N'An Giang', '0138562100', 0)

INSERT STAFFS(fullname, dateofbirth, idCard, address, phone, status) 
				  values(N'Lê Thị Kiều', '1999-08-19', '785605321', N'Phú Yên', '0168552435', 0)

INSERT STAFFS(fullname, dateofbirth, idCard, address, phone, status) 
				  values(N'Hà Quốc Anh Kiệt', '1997-11-05', '3121564645', N'Đồng Nai', '0378834457', 0)

-- Bảng Tài khoản nhân viên
DROP TABLE ACCOUNTS

CREATE TABLE ACCOUNTS
(
	id int identity(1,1) primary key,
	username varchar(max) not null,
	password varchar(max) not null,
	idStaff int not null,
	type INT NOT NULL DEFAULT 0

	foreign key (idStaff) references STAFFS(id)
)

INSERT INTO ACCOUNTS(username, password, idStaff, type) values ('785605321', '123456', 3, 0)
INSERT INTO ACCOUNTS(username, password, idStaff, type) values ('3121564645', '123456', 4, 1)

-- Bảng Danh Mục
CREATE TABLE CATEGORIES
(
	id int identity(1,1) primary key,
	name nvarchar(max) NOT NULL,
	status INT NOT NULL DEFAULT 0
)

INSERT CATEGORIES (name, status) VALUES (N'Khác', 0)
INSERT CATEGORIES (name, status) VALUES (N'Hải sản', 0)
INSERT CATEGORIES (name, status) VALUES (N'Nông sản', 0)
INSERT CATEGORIES (name, status) VALUES (N'Lâm sản', 0)
INSERT CATEGORIES (name, status) VALUES (N'Nước', 0)

-- Bảng Sản Phẩm (Mỗi danh mục có chứa nhiều sản phẩm)
CREATE TABLE ITEMS
(
	id int identity(1,1) primary key,
	name nvarchar(max) not null,
	price float not null,
	idCategory int not null,
	status INT NOT NULL DEFAULT 0

	foreign key (idCategory) references CATEGORIES(id)
)

INSERT ITEMS (name, idCategory, price, status) VALUES (N'Mực một nắng nước sa tế', 2, 120000, 0)
INSERT ITEMS (name, idCategory, price, status) VALUES (N'Nghêu hấp xả', 2, 50000, 0)
INSERT ITEMS (name, idCategory, price, status) VALUES (N'Dú dê nướng sữa', 3, 60000, 0)
INSERT ITEMS (name, idCategory, price, status) VALUES (N'Heo rừng nướng muối ớt', 4, 75000, 0)
INSERT ITEMS (name, idCategory, price, status) VALUES (N'7 Up', 5, 15000, 0)
INSERT ITEMS (name, idCategory, price, status) VALUES (N'Cafe', 5, 12000, 0)

-- Bảng Bàn Ăn
CREATE TABLE TABLES
(
	id int identity(1,1) primary key,
	name nvarchar(max) not null,
	status nvarchar(max) not NULL DEFAULT N'Trống',
	statusDel INT NOT NULL DEFAULT 0
)

INSERT TABLES (name, status, statusDel) VALUES (N'Bàn 1', N'Trống', 0)
INSERT TABLES (name, status, statusDel) VALUES (N'Bàn 2', N'Trống', 0)
INSERT TABLES (name, status, statusDel) VALUES (N'Bàn 3', N'Trống', 0)
INSERT TABLES (name, status, statusDel) VALUES (N'Bàn 4', N'Trống', 0)
INSERT TABLES (name, status, statusDel) VALUES (N'Bàn 5', N'Trống', 0)
INSERT TABLES (name, status, statusDel) VALUES (N'Bàn 6', N'Trống', 0)
INSERT TABLES (name, status, statusDel) VALUES (N'Bàn 7', N'Trống', 0)
INSERT TABLES (name, status, statusDel) VALUES (N'Bàn 8', N'Trống', 0)
INSERT TABLES (name, status, statusDel) VALUES (N'Bàn 9', N'Trống', 0)
INSERT TABLES (name, status, statusDel) VALUES (N'Bàn 10', N'Trống', 0)

-- Bảng Khách Hàng
CREATE TABLE CUSTOMERS
(
	id int identity(1,1) primary key,
	name nvarchar(max) not null,
	phone nvarchar(20) null,
	createDate dateTime not NULL DEFAULT GETDATE(),
	status INT NOT NULL DEFAULT 0
)

INSERT CUSTOMERS (name) VALUES (N'Mặc định')

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
	price FLOAT NOT NULL, 
	count int not null,

	foreign key (idBill) references BILLS(id),
	foreign key (idItems) references ITEMS(id),
)

-- Bảng Đơn vị (Đơn vị tính)
CREATE TABLE UNITS
(
	id int identity(1,1) primary key,
	name nvarchar(max) not NULL,
	status INT NOT NULL DEFAULT 0
)

Insert UNITS (name) values ('Kg')

-- Bảng Nhà cung cấp
CREATE TABLE SUPPLIERS
(
	id int identity(1,1) primary key,
	name nvarchar(max) not null,
	address nvarchar(max) not null,
	phone nvarchar(20) null,
	email nvarchar(200) NULL,
	status INT NOT NULL DEFAULT 0
)

insert SUPPLIERS (name, address, phone, email) values (N'Tạp Hoá ABC', N'Xuân Lộc', '025142112', 'abc@gmail.com')
insert SUPPLIERS (name, address, phone, email) values (N'Tạp Hoá XYZ', N'Long Khánh', '025142112', 'xyz@gmail.com')

-- Bảng đối tượng
CREATE TABLE OBJECTS
(
	id int identity(1,1) primary key not null,
	name nvarchar(max) not null,
	idUnit int not null,
	idSupplier int not null,
	status INT NOT NULL DEFAULT 0

	foreign key(idUnit) references UNITS(id),
	foreign key(idSupplier) references SUPPLIERS(id),
)

insert OBJECTS (name, idUnit, idSupplier) values (N'Cà phê', 1, 1)
insert OBJECTS (name, idUnit, idSupplier) values (N'Đường', 1, 1)

-- Bảng nhập kho
CREATE TABLE INPUTS
(
	id int identity(1,1) primary key,
	dateInput DateTime not null DEFAULT GETDATE()
)

INSERT INPUTS(dateInput) VALUES (GETDATE())

-- Bảng Chi Tiết Nhập kho
CREATE TABLE INPUTINFOS
(
	id int identity(1,1) primary key,
	idObject int not null,
	idInput int not null,
	count int not null,
	inputPrice float not null default 0,
	status nvarchar(max) not null,

	foreign key (idObject) references OBJECTS(id),
	foreign key (idInput) references INPUTS(id)
)

INSERT INPUTINFOS(idObject, idInput, count, inputPrice, status) VALUES (1, 1, 10, 35000, 'Đã thanh toán')
INSERT INPUTINFOS(idObject, idInput, count, inputPrice, status) VALUES (2, 1, 5, 15000, 'Đã thanh toán')

-- Bảng Xuất kho
CREATE TABLE OUTPUTS
(
	id int identity(1,1) primary key,
	dateOutput DateTime not null default GETDATE()
)

INSERT OUTPUTS(dateOutput) VALUES (GETDATE())

-- Bảng Chi Tiết xuất kho
CREATE TABLE OUTPUTINFOS
(
	id int identity(1,1) primary key,
	idObject nvarchar(128) not null,
	idOutput nvarchar(128) not null,
	count int not null,

	foreign key (idObject) references OBJECTS(id),
	foreign key (idOutput) references OUTPUTS(id)
)
GO

INSERT OUTPUTINFOS(idObject, idOutput, count) VALUES (1, 1, 5)
INSERT OUTPUTINFOS(idObject, idOutput, count) VALUES (2, 1, 3)

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
AS SELECT * FROM dbo.TABLES WHERE statusDel = 0
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

	SELECT @idCustomer = id FROM CUSTOMERS WHERE id = 1

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

	SELECT @idCustomer = id FROM CUSTOMERS WHERE id = 1
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
	@idCard VARCHAR(MAX) = NULL, 
	@address NVARCHAR(MAX) = NULL, 
	@phone VARCHAR(MAX) = NULL
AS
BEGIN	
	INSERT dbo.STAFFS 
	        ( fullname ,
	          dateofbirth ,
	          idCard ,
	          address ,
	          phone
	        )
	VALUES  ( @fullname , -- fullname - nvarchar(max)
	          @dateofbirth, -- dateofbirth - date
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
	DELETE dbo.ACCOUNTS WHERE idStaff = @id
	UPDATE dbo.STAFFS SET status = 1 WHERE id = @id
END	
GO

-- delete category 
CREATE PROC PC_DELETE_CATEGORY
	@idCategory int
AS
BEGIN
	declare @count int = 0

	Select @count = count(*) from ITEMS where idCategory = @idCategory
	if	@count > 0
		UPDATE ITEMS SET idCategory = 1 WHERE idCategory = @idCategory

	Delete CATEGORIES WHERE id = @idCategory
END
GO

create proc PC_AddInput
	@idObject int,
	@count int,
	@inputPrice float,
	@status nvarchar(max)
as
begin
	  Declare @idInput int
	  Select @idInput = MAX(id) from INPUTS
	  Insert INPUTINFOS (idObject, idInput, count, inputPrice, status) values (@idObject, @idInput, @count, @inputPrice, @status)
End
GO

CREATE PROC PC_BILL_REPORT
	@idbill int
AS
BEGIN
	SELECT b.id, i.name, bi.price, bi.count
	FROM BILLS as b 
	join BILLINFOS as bi on b.id = bi.idBill
	join ITEMS as i on bi.idItems = i.id
	where b.id = @idbill
END
GO

CREATE PROC PC_INVENTORY
	@thangnambatdau nvarchar(Max), @thangnamketthuc nvarchar(Max),
	@idSanPham int, --mã sản phẩm
	@inventory int output
AS
BEGIN
	DECLARE @nhapthangtruoc int, @xuatthangtruoc int

	select @nhapthangtruoc = SUM(ii.count)
	from INPUTINFOS as ii 
			join INPUTS i on ii.idInput = i .id 
			join OBJECTS o on o.id = ii.idObject
	where i.dateInput BETWEEN (select CONCAT(@thangnambatdau, ' ', '00:00:00')) and (select CONCAT(@thangnamketthuc, ' ', '23:59:59')) AND ii.idObject = @idSanPham

	select @xuatthangtruoc = SUM(oi.count)
	from OUTPUTINFOS as oi 
			join OUTPUTS op on oi.idOutput = op.id 
			join OBJECTS o on o.id = oi.idObject
	where op.dateOutput BETWEEN (select CONCAT(@thangnambatdau, ' ', '00:00:00')) and (select CONCAT(@thangnamketthuc, ' ', '23:59:59')) AND oi.idObject = @idSanPham

	Declare @toncuoithang int = @nhapthangtruoc - @xuatthangtruoc

	select @inventory = @toncuoithang
END

DECLARE @get VARCHAR(20); EXEC PC_INVENTORY '2020-01-01' , '2020-01-31' , 1, @get output; SELECT @get 
Go

CREATE PROC PC_GETPRICE_INPUT
	@thangnambatdau nvarchar(Max), @thangnamketthuc nvarchar(Max),
	@idSanPham int, --mã sản phẩm
	@inputPrice int output
AS
BEGIN
	select @inputPrice = ii.inputPrice
	from INPUTS as i join INPUTINFOS as ii on ii.idInput = i.id
	where i.dateInput between (select CONCAT(@thangnambatdau, ' ', '00:00:00')) and (select CONCAT(@thangnamketthuc, ' ', '23:59:59')) and ii.idObject = @idSanPham
end	

DECLARE @get VARCHAR(20); EXEC PC_GETPRICE_INPUT '2020-01-01' , '2020-01-31' , 1, @get output; SELECT @get 

select * from OBJECTS
where id In (select ii.idObject from INPUTS as i join INPUTINFOS as ii on ii.idInput = i.id
group by ii.idObject)
GO

CREATE PROC PC_GETCOUNT_INPUT
	@thangnambatdau nvarchar(Max), @thangnamketthuc nvarchar(Max),
	@idSanPham int, --mã sản phẩm
	@inputCount int output
AS
BEGIN
	select @inputCount = ii.count
	from INPUTS as i join INPUTINFOS as ii on ii.idInput = i.id
	where i.dateInput between (select CONCAT(@thangnambatdau, ' ', '00:00:00')) and (select CONCAT(@thangnamketthuc, ' ', '23:59:59')) and ii.idObject = @idSanPham
end	

DECLARE @get VARCHAR(20); EXEC PC_GETCOUNT_INPUT '2020-01-01' , '2020-01-31' , 1, @get output; SELECT @get
Go

CREATE PROC PC_Bill_byDate
	@thangnambatdau nvarchar(Max), @thangnamketthuc nvarchar(Max),
	@totalPrice int output
AS
BEGIN
	Select @totalPrice = SUM(bi.count * bi.price)
	from BILLS b join BILLINFOS bi on b.id = bi.idBill
	where b.dateCheckOut between @thangnambatdau and @thangnamketthuc
end

DECLARE @get VARCHAR(20); EXEC PC_Bill_byDate '2020-01-01' , '2020-01-31' , @get output; SELECT @get
Go

CREATE PROC PC_GETCOUNT_OUTPUT
	@thangnambatdau nvarchar(Max), @thangnamketthuc nvarchar(Max),
	@idSanPham int, --mã sản phẩm
	@outputCount int output
AS
BEGIN
	select @outputCount = oi.count
	from OUTPUTS as o join OUTPUTINFOS as oi on oi.idOutput = o.id
	where o.dateOutput between (select CONCAT(@thangnambatdau, ' ', '00:00:00')) and (select CONCAT(@thangnamketthuc, ' ', '23:59:59')) and oi.idObject = @idSanPham
end	

DECLARE @get VARCHAR(20); EXEC PC_GETCOUNT_OUTPUT '2020-02-01' , '2020-02-29' , 2, @get output; SELECT @get
Go