--------------------------------------------------------form Login---------------------------------------------------
-- kiem tra login
CREATE PROC KiemTraLoginMain( @user nvarchar(30) , @pass nvarchar(30))
as
begin
      select count(*) from STAFF_LOGIN where LoginUserName = @user  and  LoginPassword = @pass  and LoginStatus like N'1'
end
go 
------------------------------------------------------------------------------------------------------------------------------
create PROC CapNhatTaiKhoan( @user nvarchar(30) , @pass nvarchar(30),@userNew nvarchar(30) , @passNew nvarchar(30))
as
begin
     update STAFF_LOGIN set LoginUserName = @userNew ,  LoginPassword = @passNew 
	 where  LoginUserName =@user and LoginPassword = @pass and LoginStatus like N'1'
end
------------------------------------------------------------------------------------------------------------------------------
go 
create PROC ThemNhanVien( @staName nvarchar(30) , @staBirthday date,@staAddress nvarchar(50) , @staPhone char(10) ,@staSex bit ,@staDescription ntext , @staStatus ntext,  @staSalary money, @staPosition nvarchar(20), @LoginID int )
as
begin
     insert into STAFF( staName , staBirthday,staAddress ,staPhone, staSex, staDescription, staStatus, staSalary, staPosition, LoginID)
	 values (@staName, @staBirthday, @staAddress,  @staPhone, @staSex, @staDescription, @staStatus, @staSalary, @staPosition, @LoginID)
end

------------------------------------------------------------------------------------------------------------------------------
go 
create PROC ThemNhanVienLogin( @user nvarchar(30) , @pass nvarchar(30) )
as
begin
     insert into STAFF_LOGIN( LoginUserName ,LoginPassword ,LoginStatus)
	 values(@user,@pass ,'1')
end
------------------------------------------------------------------------------------------------------------------------------
go 
create PROC LayDanhSachNhanVien
as
begin
     select * from Staff  where cast(staStatus as nvarchar(max)) ='1'
end

------------------------------------------------------------------------------------------------------------------------------
go 
create PROC ThemNhaCungCap( @fullName nvarchar(50) , @ten nvarchar(20) ,@diaChi nvarchar(250) ,@maBuuDien char(10),@quocGia nvarchar(25), @sodienThoai char(10),@mieuTa ntext ,@trangThai int)
as
begin
    insert into PROVIDED (provFullName , provName, provAddress, provPostOfficeCode, provCountry, provPhone, provDescription, provStatus)
	values(@fullName, @ten, @diaChi, @maBuuDien,  @quocGia,@sodienThoai, @mieuTa, @trangThai)
end

------------------------------------------------------------------------------------------------------------------------------
go 
alter PROC ThemSanPham( @prodName nvarchar(50) , @prodPrice money ,@prodSL int, @prodCamera nvarchar(50),@prodMenory int ,@prodReleaseYear int ,@prodRAM int  , @prodDescription ntext ,@provID int ,@catID int  )
as
begin
    insert into PRODUCT ( prodName, prodPrice, prodSL,prodInit, prodCamera, prodMenory, prodReleaseYear, prodRAM, prodDescription, provID , catID, prodStatus)
	values(@prodName, @prodPrice, @prodSL,  N'ð',@prodCamera, @prodMenory, @prodReleaseYear, @prodRAM , @prodDescription, @provID, @catID,1)
end

------------------------------------------------------------------------------------------------------------------------------
go 
create  PROC ThemOrder( @ordDate date , @ordDescription ntext, @staID int)
as
begin
    insert into ORDERR( ordDate , ordDescription, ordBill, staID ,ordStatus, cliID)
	values (@ordDate, @ordDescription, 0 , @staID, 1,null)
end
------------------------------------------------------------------------------------------------------------------------------
go 
create  PROC ThemInfoOrder( @ordID int , @prodID int, @infoOrderSL int , @inforOrderPrice money)
as
begin
    insert into INFORMATION_ORDER(ordID , prodID, infoOrderSL, infoOrderPrice , infoStatus)
	values (@ordID, @prodID, @infoOrderSL,  @inforOrderPrice, 1)
end

------------------------------------------------------------------------------------------------------------------------------
create  PROC ThemOrderBan( @ordDate date , @ordDescription ntext, @staID int ,@cliID int)
as
begin
    insert into ORDERR( ordDate , ordDescription, ordBill, staID ,ordStatus, cliID)
	values (@ordDate, @ordDescription, 1 , @staID, 1,@cliID)
end
------------------------------------------------------------------------------------------------------------------------------
go 
create  PROC ThemInfoOrderBan( @ordID int , @prodID int, @infoOrderSL int , @inforOrderPrice money)
as
begin
    insert into INFORMATION_ORDER(ordID , prodID, infoOrderSL, infoOrderPrice , infoStatus)
	values (@ordID, @prodID, @infoOrderSL,  @inforOrderPrice, 1)
end

------------------------------------------------------------------------------------------------------------------------------
go 
create  PROC ThemKhachHang( @cliName nvarchar(30), @cliAddress nvarchar(50), @cliCountry nvarchar(30), @cliPostOfficeCode char(10), @cliPhone char(10))
as
begin
    insert into CLIENT(cliName, cliAddress, cliCountry, cliPostOfficeCode, cliPhone, cliStatus)
	values (@cliName, @cliAddress, @cliCountry,  @cliPostOfficeCode, @cliPhone,1)
end


select * from Staff 
select * from STAFF_LOGIN
select * from PRODUCT
select * from PROVIDED
select * from ORDERR
select * from INFORMATION_ORDER
select * from CATEGORY
select * from CLIENT

