--drop database prnSQL
create database prnSQL
USE prnSQL

CREATE TABLE [dbo].[Account](
	[Username] nvarchar(50) PRIMARY KEY,
	[Password] nvarchar(max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Role] int NOT NULL,
	[Phone] [nvarchar](max) NOT NULL
);
CREATE TABLE [dbo].[Bill](
	[BillID] [int] IDENTITY PRIMARY KEY,
	[Username] [nvarchar](50) NOT NULL,
	[Date] date,
	[Status] bit NOT NULL,
	foreign key ([Username]) references [Account]([Username])
);
CREATE TABLE [dbo].[Original](
	[OriginalID] [int] IDENTITY PRIMARY KEY,
	[OriginalName] [nvarchar](max) NULL,
);
CREATE TABLE [dbo].[Category](
	[CateID] [int] IDENTITY PRIMARY KEY,
	[OriginalID] [int] NOT NULL,
	[CateName] [nvarchar](max) NULL,
	foreign key ([OriginalID]) references [Original]([OriginalID])
);
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY PRIMARY KEY,
	[ProductName] [nvarchar](max) NOT NULL,
	CateID [int] NOT NULL,
	[QuantityInStock] [int] NOT NULL,		
	foreign key (CateID) references [Category](CateID)
);
CREATE TABLE [dbo].[BillDetail](
	[BDID] [int] IDENTITY NOT NULL,
	[ProductID] [int] NOT NULL,
	[BillID] [int] NOT NULL,
	[QuantityUnit] [int] NOT NULL,
	[Tax] [int] NULL
	CONSTRAINT bill_pk PRIMARY KEY ([BDID]),
	foreign key ([ProductID]) references [Product]([ProductID]),
	foreign key ([BillID]) references [Bill]([BillID])
);
insert into Account values('admin','123','AnthoNy',1,'0389132141');
insert into Account values('admin1','123','Emily',0,'0389132141');
insert into Account values('admin2','123','David',0,'0982346182');
insert into Account values('admin3','123','Kevin',0,'0311920012');
insert into Account values('admin4','123','Maria',0,'0974124855');

insert into Original values(N'Trung Quốc');
insert into Original values(N'Việt Nam');
insert into Original values(N'Hàn Quốc');
insert into Original values(N'Thái Lan');
insert into Original values(N'Nhật Bản');
insert into Original values(N'Mỹ');

insert into Category values(1,N'Vật Dụng Phòng Bếp');
insert into Category values(2,N'Vật Liệu Xây Dựng');
insert into Category values(3,N'Máy Móc');
insert into Category values(4,N'Thực Phẩm');
insert into Category values(2,N'Quần Áo');
insert into Category values(1,N'Đồ Gia Dụng');
insert into Category values(4,N'Giầy Dép');
insert into Category values(6,N'Mỹ Phẩm');
insert into Category values(5,N'Hoa Quả');
insert into Category values(3,N'Hải Sản');
insert into Category values(2,N'Đồ Du Lịch');
insert into Category values(2,N'Đồ Phòng Ngủ');
insert into Category values(1,N'Đồ Ăn vặt');
insert into Category values(1,N'Nước uống');
insert into Category values(4,N'Đồ Điện Tử');
insert into Category values(6,N'Đồ Công Nghệ');

insert into Product values(N'Máy Rửa Chén',1,12);
insert into Product values(N'Nồi Luộc Size 30CM',1,52);
insert into Product values(N'Bát ăn cơm',1,1200);
insert into Product values(N'Máy cắt kính',2,6);
insert into Product values(N'Máy hàn',2,15);
insert into Product values(N'Đùi heo size 30Kg',4,62);
insert into Product values(N'Thịt bò(Kg)',4,400);
insert into Product values(N'Áo sơ mi',5,123);
insert into Product values(N'Quần bò',5,224);
insert into Product values(N'Quạt hộp()',6,52);
insert into Product values(N'giầy tây',7,12);
insert into Product values(N'kem dưỡng da',8,322);
insert into Product values(N'Táo(Kg)',9,120);
insert into Product values(N'Cua hoàng đế(con)',10,22);
insert into Product values(N'Vali',11,12);
insert into Product values(N'Đệm kim đan',12,65);
insert into Product values(N'Chân gà(Kg)',13,62);
insert into Product values(N'CocaCola(thùng)',14,82);

insert into Bill values('admin1','2022-07-20',1);
insert into Bill values('admin1','2022-07-19',1);
insert into Bill values('admin1','2022-07-18',0);
insert into Bill values('admin2','2022-07-12',1);
insert into Bill values('admin2','2022-07-11',0);
insert into Bill values('admin3','2022-07-10',1);
insert into Bill values('admin4','2022-07-09',0);

insert into BillDetail values(1,1,5,1);
insert into BillDetail values(2,2,4,1);
insert into BillDetail values(4,3,5,1);
insert into BillDetail values(5,4,1,1);
insert into BillDetail values(6,6,8,1);
insert into BillDetail values(4,7,9,1);

select * from Product
select * from Bill
select * from Account
select * from Category
select * from Original
select * from BillDetail




