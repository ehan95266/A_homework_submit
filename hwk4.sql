USE Northwind
--1
create view view_product_order_han 
AS(
    select p.ProductName, sum(d.Quantity) as "totalquantityordered" 
    from Products p left join [Order Details] d on p.ProductID = d.ProductID
    group by ProductName, OrderID
)
select * from dbo.view_product_order_han
--2 
create PROC sp_product_order_quantity_han (@productid int, @totalquantityordered int output)
AS
begin
    select productid, sum(Quantity) as "totalquantityordered"
    from [order details]
    where productid = @productid
    group by productid
END

declare @totalquantityordered int
exec sp_product_order_quantity_han 23, @totalquantityordered out

--3 
create proc sp_product_order_city_han(@productname varchar(50),@top5qty int output,@top5city int output)
AS
BEGIN
    select top 5 p.ProductName, sum(d.Quantity) as "totalquantityordered", o.shipcity
    from [Order Details] d 
    join orders o on d.OrderID = o.orderID
    join products p on d.ProductID = p.productid
    where p.ProductName = @productname
    group by p.ProductName, o.shipcity
    order by totalquantityordered desc
END

DECLARE @top5qty int
declare @top5city int
exec sp_product_order_city_han 'Alice Mutton', @top5qty out, @top5city out

--4
create table city_han
(
    Id int,
    City varchar(30) 
)

insert city_han values (1, 'Seattle')
insert city_han values (2, 'Green Bay')

create table people_han
(
    id int,
    name varchar (30),
    city int,
)

insert people_han values(1, 'Aaron Rodgers',2)
insert people_han values(2, 'Russell Wilson',1)
insert people_han values(3, 'Jody Nelson',2)

UPDATE c
SET c.City = 'Madison'
FROM people_han p 
INNER JOIN city_han c 
ON c.Id = p.City
WHERE p.City = 1;


create view packers_han 
AS(
    select p.name
    from people_han p 
    inner join city_han c 
    ON c.Id = p.City
    where c.city = 'Green Bay'
)
select * from dbo.packers_han

drop table people_han
drop table city_han
drop view packers_han

5--
select * from employees

create proc sp_birthday_employees_han 
AS
(
    select lastname + ''+firstname as "EmployeeName", BirthDate
    into birthday_employees_han
    from employees
    where month(BirthDate) = 2

)

exec sp_birthday_employees_han

drop table birthday_employees_han

--6
--How do you make sure two tables have the same data?
/* we can use comparison method when we have smaller dataset. 
we can set comparison for both table in the WHERE clause, this way we can make sure each column and rows have exact match.
The other way is to use sql in-built function called CHECKSUM,
this function is useful when we have large datasets to comapre; 
the funtion will generate hashcode for each column of the tables we want to make sure have exact match, then when we join the two tables
we will set the WHERE clause to both table's hashcode equal to each other. The result will be the matches made by the identical hashcode. 