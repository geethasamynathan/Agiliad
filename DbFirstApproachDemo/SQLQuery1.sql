create table tbl_Department 
(
departmentid int primary key identity,
departmentName varchar(20),
Location varchar(20)
)

create procedure sp_InsertNewDepartment
(@name varchar(20),
@Location varchar(20)
)
as
begin
insert into tbl_DEpartment values (@name, @Location)
end

sp_InsertNewDepartment 'IT1','DElhi1'

select * from tbl_Department

create procedure sp_GetAllDepartments
as
begin 
select * from tbl_Department 
End
sp_GetAllDepartments


create table Department
(
Id int primary key identity,
Name varchar(20),
Location varchar(20)
)


select * from Department

create proc sp_GetAllDepartments
as
begin
select * from Department
End

sp_GetAllDepartments

create proc sp_InsertNewEmployee
(@name varchar(20),
@location varchar(20))
as
begin
insert into department values (@name,@location)
End

sp_InsertNewEmployee1 'IT1','Coimbatore'
drop proc sp_GetAllDepartments1
drop proc sp_InsertNewEmployee1
