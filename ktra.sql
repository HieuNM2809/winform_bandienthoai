alter proc ThemCat (@NameCat nvarchar(max))
as
begin 
	insert into CATEGORY (CategoryName, Status )
	values(@NameCat,0)
end

alter proc SuaCat (@id int , @NameCat nvarchar(max) )
as
begin 
	update  CATEGORY
	set    CategoryName =  @NameCat 
	where Id= @id
end

select * from CATEGORY 
select * from PRODUCT 