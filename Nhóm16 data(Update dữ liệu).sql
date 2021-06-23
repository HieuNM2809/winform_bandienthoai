-- Group 16: 
-- Nguyễn minh Hiếu 0306191022
--Đặng khánh Trình   0306191091
-- Nguyễn gia Hòa     0306181026

use master 
go 
create database CSDL_sellPhone_main
go 
use  CSDL_sellPhone_main
go
-- create table cung cap 
create table PROVIDED
(
		provID int not null unique IDENTITY(1, 1),
		provFullName nvarchar(50),
		provName nvarchar(20),
		provAddress nvarchar(250),
		provPostOfficeCode char(10),
		provCountry nvarchar(25),
		provPhone char(10),
		provDescription ntext,
	    provStatus int,

		constraint PK_provID primary key(provID)
)
-- create table phân loại
create table CATEGORY 
(
     catID int not null unique IDENTITY(1, 1),
	 catName nvarchar(50),
	 catDescription ntext,
	 catStatus int,


	 constraint PK_catID primary key(catID)
)

-- create table sanpham 
create table PRODUCT
(
     prodID int not null unique IDENTITY(1, 1),
	 prodName nvarchar(50),
	 prodPrice money check (prodPrice > 0 ),
	 prodSL int check(prodSL >0),
	 prodInit nvarchar(20),  -- đơn vị 
	 prodCamera nvarchar(50),
	 prodMenory int check( prodMenory > 0),
	 prodReleaseYear int check(prodReleaseYear >0),
     prodRAM int check(prodRAM > 0 ),
	 prodDescription ntext,
	 prodStatus int,
	 provID int,
	 catID int ,

	 constraint PK_prodID primary key(prodID)
)
go 
create table IMAGES
( 
	prodID int  not null,
	img1 nvarchar(50),
	img2 nvarchar(50),
	img3 nvarchar(50),
	img4 nvarchar(50)
)
create table COLOR
( 
   prodID int  not null,
   color1 nvarchar(50),
   color2 nvarchar(50),
   color3 nvarchar(50),
   color4 nvarchar(50),
   )
--create table  khach hang  
create table CLIENT 
(
	 cliID int not null unique IDENTITY(1, 1),
	 cliName nvarchar(30), 
     cliAddress  nvarchar(50),
	 cliCountry nvarchar(30),
	 cliPostOfficeCode  char(10) ,
	 cliPhone char(10),
	 cliStatus int,


	 constraint PK_cliID primary key(cliID)
)
--create table nhan vien 
create table STAFF_LOGIN
(
	 LoginID int not null unique IDENTITY(1, 1),
	 LoginUserName nvarchar(30) not null,
	 LoginPassword nvarchar(30) not null, 
	 LoginStatus int,

	   constraint PK_staffLoginID primary key(LoginID)
)
create table STAFF
(
	 staID int not null unique IDENTITY(1, 1),
	 staName nvarchar(30), 
     staBirthday  date,
     staAddress  nvarchar(50),
     staImg  image,
	 staPhone  char(10) ,
	 staSex bit ,
	 staDescription ntext,
	 staStatus int,
	 staSalary money,
	 staPosition nvarchar(20),
	 LoginID int 

	 constraint PK_staID primary key(staID)
)

--create table  don hang 
create table ORDERR
(
	 ordID int not null unique IDENTITY(1, 1),
     ordDate  date default getdate() check (ordDate >= getdate()),
	 ordDescription ntext,
	 ordBill bit ,
	 ordStatus int,
	 cliID int, 
     staID int ,

	 constraint PK_ordID primary key(ordID)
)


--create table chi tiet don don hang 
create table INFORMATION_ORDER
(
	 infoOrderID int not null unique IDENTITY(1, 1),
	 ordID int, 
     prodID int ,
     infoOrderSL  int check( infoOrderSL > 0),
     infoOrderPrice  money check( infoOrderPrice > 0),
	 infoStatus int,

	 constraint PK_infoOrderID primary key(infoOrderID)
)
go 


alter table IMAGES 
add constraint PK_prodID_img   PRIMARY  KEY (prodID)
go
alter table COLOR 
add constraint PK_prodID_color  PRIMARY  KEY (prodID)

-- =============tạo khóa ngoại 
-- nhân viên 
alter table STAFF  
add constraint FK_LoginID foreign key(LoginID)
 references STAFF_LOGIN(LoginID)

-- khoa ngoai bao san pham 
alter table PRODUCT 
add constraint FK_provID foreign key(provID)
 references PROVIDED(provID)

 alter table PRODUCT 
add constraint FK_catID foreign key(catID)
 references CATEGORY(catID)

 alter table IMAGES
 add constraint FK_prodID_img  foreign key (prodID)
 references PRODUCT(prodID)

  alter table COLOR
 add constraint FK_prodID_color  foreign key (prodID)
 references PRODUCT(prodID)
 

 -- khoa ngoai bao don hang 
alter table ORDERR
add constraint FK_cliID foreign key(cliID)
 references CLIENT(cliID)

 alter table ORDERR 
add constraint FK_staID foreign key(staID)
 references STAFF_LOGIN(LoginID)

  -- khoa ngoai bao chi tieets don hang 
alter table INFORMATION_ORDER
add constraint FK_ordID foreign key(ordID)
 references ORDERR(ordID)

 alter table INFORMATION_ORDER 
add constraint FK_prodID foreign key(prodID)
 references PRODUCT(prodID)


   alter table IMAGES
 add constraint FK_prodID_img  foreign key (prodID)
 references PRODUCT(prodID)

  alter table COLOR
 add constraint FK_prodID_color  foreign key (prodID)
 references PRODUCT(prodID)

go 

INSERT INTO staff_login (LoginUserName, LoginPassword, LoginStatus) VALUES
('user1', '123456789', '1'),
( 'user2', '123456781', '1'),
( 'user3', '123456773', '1'),
( 'user4', '123456765', '1'),
( 'user5', '123456757', '1'),
('user6', '123456749', '1'),
( 'user7', '123456741', '1'),
( 'user8', '123456733', '1'),
( 'user9', '123456725', '1'),
( 'user10', '123456717', '1'),
( 'user11', '123456709', '1'),
( 'user12', '123456701', '1'),
( 'user13', '123456693', '1'),
( 'user14', '123456685', '1'),
( 'user15', '123456677', '1'),
( 'user16', '123456709', '1'),
( 'user17', '123456701', '1'),
( 'user18', '123456693', '1'),
( 'user19', '123456685', '1'),
('user20', '123456677', '1')

go 
INSERT INTO staff ( staName, staBirthday, staAddress, staImg, staPhone, staSex, staDescription, staStatus, staSalary, staPosition, LoginID) VALUES
( N'Nguyễn Minh Hiếu', '09/28/2001', 'Kiên Giang', NULL, '374422286', 1, NULL, '1', 8000000, N'Giám đốc', 1),
(N'Trần Đức Hiếu', '09/29/2001', N'Kiên Gang', NULL, '374422287', 1, NULL, '1', 9000000, N'Nhân Viên', 2),
(N'Dương Nghĩa Hiệp', '2001-09-30', N'Kiên Giang', NULL, '374422288',1, NULL, '1', 10000000, N'Nhân Viên', 3),
(N'Nguyễn Công Chính', '2001-10-01', N'Gò Vấp', NULL, '374422289', 1, NULL, '1', 11000000, N'Nhân Viên', 4),
( N'Nguyễn Nhan Gia Bảo', '2001-10-02', N'Q5', NULL, '374422290', 1, NULL, '1', 12000000, N'Nhân Viên', 5),
(N'Trần Dương Trí Hiếu', '2001-10-03', N'Bình Chánh ', NULL, '374422291', 1, NULL, '1', 13000000, N'Nhân Viên', 6),
( N'Nguyễn Đình Thủ', '2001-10-04', N'Tân Phú', NULL, '374422292', 1, NULL, '1', 14000000, N'Nhân Viên', 7),
(N'Nguyễn Hiếu', '2001-10-05', N'Tân Bình', NULL, '374422293',1, NULL, '1', 15000000, N'Nhân Viên', 8),
(N'Trần Hiếu', '2001-10-06', N'Kiên Giang', NULL, '374422294', 1, NULL, '1', 16000000, N'Nhân Viên', 9),
( N'Dương Thu', '2001-10-07', N'Kiên Gang', NULL, '374422295', 0, NULL, '1', 17000000, N'Nhân Viên', 10),
( N'Nguyễn Hồng', '2001-10-08', N'Kiên Giang', NULL, '374422296', 0, NULL, '1', 18000000, N'Nhân Viên', 11),
(N'Nguyễn Thảo', '2001-10-09', N'Gò Vấp', NULL, '374422297', 0, NULL, '1', 19000000, N'Nhân Viên', 12),
( N'Trần Hạnh', '2001-10-10', N'Q5', NULL, '374422298', 0, NULL, '1', 20000000, N'Nhân Viên', 13),
( N'Nguyễn  Minh', '2001-10-11', N'Bình Chánh ', NULL, '374422299',0, NULL, '1', 21000000, N'Nhân Viên', 14),
(N'Nguyễn Trân', '2001-10-12',N'Tân Phú', NULL, '374422300', 0, NULL, '1', 22000000, N'Nhân Viên', 15)

GO
INSERT INTO client ( cliName, cliAddress, cliCountry, cliPostOfficeCode, cliPhone, cliStatus) VALUES
( N'Nguyễn Thị Hồng Hạnh', '', N'TH HCM', '12345', '0799501324', '1'),
(N'Nguyễn Gia Hòa', '', N'TH HCM', '12346', '0799501325', '1'),
( N'Nguyễn Nhan Gia Bảo', '', N'TH HCM', '12347', '0799501326', '1'),
( N'Nguyễn Công Chính', '', 'NTH HCM', '12348', '0799501327', '1'),
( N'Dương Nghĩa Hiệp', '', N'TH HCM', '12349', '0799501328', '1')

go 

INSERT INTO category ( catName, catDescription, catStatus) VALUES
(N'Điện thoại Phím', 'NULL', '1'),
(N'Điện thoại Cảm ứng', 'NULL', '1'),
(N'Điện thoại Gaming', 'NULL', '1')

go 



INSERT INTO provided ( provFullName, provName, provAddress,provPostOfficeCode, provCountry, provPhone, provDescription, provStatus) VALUES
( NULL, N'Xiaomi Inc', N'116 Nguyễn Du, Q.1, Tp. Hồ Chí Minh', '12345',N'TP HCM', '0799501324', NULL, '1'),
( NULL, N'Apple Inc', N'246 Nguyễn Hồng Đào, Q.Tân Bình, Tp. Hồ Chí Minh', '12346', 'TP HCM', '0799501325', NULL, '1'),
( NULL, N'Samsung Inc', N'718bis Kinh Dương Vương, Q.6, Tp. Hồ Chí Minh', '12347', 'TP HCM', '0799501326', NULL, '1'),
(NULL, N'Huawei Inc', N'Lầu 304A Quang Trung, P.11, Q. Gò Vấp, Tp. Hồ Chí Minh', '12348', 'TP HCM', '0799501327', NULL, '1'),
(NULL, N'Oppo Inc', N'Tầng 10, CT Plaza, 60A Trường Sơn, P.2, Q. Tân Bình, Tp. Hồ Chí Minh', '12349', 'TP HCM', '0799501328', NULL, '1'),
(NULL, N'Vivo Inc', N'Tầng 7, Hùng Vương Plaza, 126 Hùng Vương, Q.5, Tp. Hồ Chí Minh', '12350', 'TP HCM', '0799501329', NULL, '1'),
(NULL, N'Sony Inc', N'Lầu 3, Aeon Mall 30 Bờ Bao Tân Thắng, P. Sơn Kỳ, Q. Tân Phú, Tp. Hồ Chí Minh', '12351', 'TP HCM', '0799501330', NULL, '1'),
(NULL, N'Lenovo Inc', N'Tầng 2, Thảo Điền Mall, 12 Quốc Hương, P. Thảo Điền, Q.2, Tp. Hồ Chí Minh', '12352', 'TP HCM', '0799501331', NULL, '1'),
(NULL, N'Vismart Inc', N'Tầng 5, TTTM Vincom Thủ Đức, 216 Võ Văn Ngân, P. Bình Thọ, Q. Thủ Đức, Tp. Hồ Chí Minh', '12353', 'TP HCM', '0799501332', NULL, '1'),
(NULL, N'OnePlus Inc ', N'Tầng 5 TTTM Vincom Plaza Gò Vấp, 12 Phan Văn Trị, P.7, Q. Gò Vấp, Tp. Hồ Chí Minh', '12354', 'TP HCM', '0799501333', NULL, '1'),
(NULL, N'SmartPhone Inc', N'Lầu 3 & 4, TTTM ICON 68, 2 Hải Triều, Q.1, Tp. Hồ Chí Minh', '12355', 'TP HCM', '0799501334', NULL, '1'),
(NULL, N'Bphone Inc', N'52 Lê Văn Việt, Quận 9, Tp. Hồ Chí Minh', '12356', 'TP HCM', '0799501335', NULL, '1'),
(NULL, N'Tencent Inc', N'Tầng 3, Lotte Mart, 469 Nguyễn Hữu Thọ, P. Tân Hưng, Q.7, Tp. Hồ Chí Minh', '12357', 'TP HCM', '0799501336', NULL, '1'),
(NULL, N'SuperPhone Inc', N'Tầng 4, Pico Plaza, 20 Cộng Hòa, P.12, Q. Tân Bình, Tp. Hồ Chí Minh', '12358', 'TP HCM', '0799501337', NULL, '1'),
(NULL, N'Cphone', N'Tầng 4 Lotte Mart Phú Thọ, ngã tư 3/2 và Lê Đại Hành, Q.11, Tp. Hồ Chí Minh', '12359', 'TP HCM', '0799501338', NULL, '1')


go 


INSERT INTO product ( prodName, prodPrice, prodSL, prodInit, prodReleaseYear, prodDescription, prodStatus, provID, catID) VALUES
( N'Xiaomi 1280', 45000, 100, N'đ', 2001, NULL, '1', 1, 1),
( N'Apple 1280', 45000, NULL, N'đ', 2002, 'NULL', '1', 2, 1),
( N'Samsung 1280', 45000, NULL, N'đ', 2003, NULL, '1', 3, 1),
( N'Huawei 1280', 45000, NULL, N'đ', 2004, NULL, '1', 4, 1),
( N'Oppo Phone', 45000, NULL, N'đ', 2005, NULL, '1', 5, 2),
( N'Vivo Phone', 45000, NULL, N'đ', 2006, NULL, '1', 6, 2),
( N'Sony phone', 45000, NULL, N'đ', 2007, NULL, '1', 7, 2),
( N'Lenovo Gaming', 45000, NULL, N'đ', 2015,NULL, '1', 15, 3),
( N'Vismart Phone', 45000, NULL, N'đ', 2008, NULL, '1', 8, 2),
( N'OnePlus Phone', 45000, NULL, N'đ', 2009, NULL, '1', 9, 2),
(N'SmartPhone Gaming', 45000, NULL, N'đ', 2010, NULL, '1', 10, 3),
( N'Bphone gaming', 45000, NULL, N'đ', 2011, NULL, '1', 11, 3),
( N'Tencent ganing', 45000, NULL, N'đ', 2012,NULL, '1', 12, 3),
(N'Super Gaimg', 45000, NULL, N'đ', 2013,NULL, '1', 13, 3),
( N'CPhone Gaming', 45000, NULL, N'đ', 2014,NULL, '1', 14, 3)


go 

INSERT INTO images (prodID, img1, img2, img3, img4) VALUES
(1, 'hinh1.1', 'hinh1.2', 'hinh1.3', 'hinh1.4'),
(2, 'hinh2.1', 'hinh2.2', 'hinh2.3', 'hinh2.4'),
(3, 'hinh3.1', 'hinh3.2', 'hinh3.3', 'hinh3.4'),
(4, 'hinh4.1', 'hinh4.2', 'hinh4.3', 'hinh4.4'),
(5, 'hinh5.1', 'hinh5.2', 'hinh5.3', 'hinh5.4'),
(6, 'hinh6.1', 'hinh6.2', 'hinh6.3', 'hinh6.4'),
(7, 'hinh7.1', 'hinh7.2', 'hinh7.3', 'hinh7.4'),
(8, 'hinh8.1', 'hinh8.2', 'hinh8.3', 'hinh8.4'),
(9, 'hinh9.1', 'hinh9.2', 'hinh9.3', 'hinh9.4'),
(10, 'hinh10.1', 'hinh10.2', 'hinh10.3', 'hinh10.4'),
(11, 'hinh11.1', 'hinh11.2', 'hinh11.3', 'hinh11.4'),
(12, 'hinh12.1', 'hinh12.2', 'hinh12.3', 'hinh12.4'),
(13, 'hinh13.1', 'hinh13.2', 'hinh13.3', 'hinh13.4'),
(14, 'hinh14.1', 'hinh14.2', 'hinh14.3', 'hinh14.4'),
(15, 'hinh15.1', 'hinh15.2', 'hinh15.3', 'hinh15.4')


go 



INSERT INTO orderr ( ordDate, ordDescription, ordBill, ordStatus, cliID, staID) VALUES
( '2021-09-29', NULL, 1, '1', 1, 1),
( '2021-09-30', NULL, 1, '1', 2, 2),
( '2021-10-01', NULL, 1, '1', 3, 3),
( '2021-10-02', NULL, 1, '1', 4, 4),
( '2021-10-03', NULL, 1, '1', 5, 5),
( '2021-10-04', NULL,1, '1', 1, 6),
( '2021-10-05', NULL, 1, '1', 2, 7),
( '2021-10-06', NULL, 0, '1', 3, 8),
('2021-10-07', NULL, 0, '1', 4, 9),
( '2021-10-08', NULL, 0, '1', 5, 10),
( '2021-10-09', NULL, 0, '1', 1, 11),
( '2021-10-10', NULL, 0, '1', 2, 12),
('2021-10-11', NULL, 0, '1', 3, 13),
('2021-10-12', NULL, 0, '1', 4, 14),
('2021-10-13', NULL, 0, '1', 5, 15)

go 

INSERT INTO information_order (ordID, prodID, infoOrderSL, infoOrderPrice, infoStatus) VALUES
( 1, 1, 4, 180000, '1'),
( 2, 2, 5, 225000, '1'),
( 3, 3, 6, 270000, '1'),
( 4, 4, 7, 315000, '1'),
( 5, 5, 8, 360000, '1'),
( 6, 6, 9, 405000, '1'),
( 7, 7, 10, 450000, '1'),
( 8, 8, 11, 495000, '1'),
( 9, 9, 12, 540000, '1'),
( 10, 10, 13, 585000, '1'),
( 11, 11, 14, 630000, '1'),
(12, 12, 15, 675000, '1'),
( 13, 13, 16, 720000, '1'),
(14, 14, 17, 765000, '1'),
(15, 15, 20, 810000, '1')
 










