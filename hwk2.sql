USE AdventureWorks2019

--1
select count(ProductID) as "numberofproducts"
from Production.Product
--3
select ProductSubcategoryID, count(ProductID) as "numberofproducts"
from Production.Product
group by ProductSubcategoryID
--4
select ProductSubcategoryID, count(ProductID) as "numberofproducts"
from Production.Product
where ProductSubcategoryID IS NULL
group by ProductSubcategoryID
--5
select sum(quantity) as "totalquantity"
from Production.ProductInventory
group by ProductID
--6
select ProductID, sum(quantity) as "TheSum"
from Production.ProductInventory
where LocationID = 40
group by ProductID
having sum(quantity) < 100
--10
select ProductID,Shelf, avg(Quantity) as "TheAvg"
from Production.ProductInventory
where Shelf <> 'N/A'
group by ProductID, Shelf
--11
select Color, Class, count("ProductID") as "TheCount", avg(ListPrice) as "AvgPrice"
from Production.Product
where Color IS NOT NULL AND Class IS NOT NULL
group by Class, Color
--12
select c.Name as 'Country', s.Name 'Province'
from person.CountryRegion c
inner join person.StateProvince s on c.CountryRegionCode = s.CountryRegionCode
--13
select c.Name as 'Country', s.Name 'Province'
from person.CountryRegion c
inner join person.StateProvince s on c.CountryRegionCode = s.CountryRegionCode
where c.Name in ('Germany','Canada')

--Northwind DB
USE Northwind

--15
select top 5 o.ShipPostalCode
from products p 
inner join [Order Details] d on p.ProductID = d.ProductID
inner join orders o on o.OrderID = d.OrderID
group by o.ShipPostalCode
order by count(p.ProductID) desc
--17
select o.ShipCity, count(c.CustomerID) as 'numberofcustomer'
from orders o 
inner JOIN customers c on o.CustomerID = c.CustomerID
group by o.ShipCity 
--18
select o.ShipCity, count(c.CustomerID) as 'numberofcustomer'
from orders o 
inner JOIN customers c on o.CustomerID = c.CustomerID
group by o.ShipCity
having count(c.CustomerID) > 2
--19
select c.ContactName
from orders o 
inner JOIN customers c on o.CustomerID = c.CustomerID
where o.OrderDate > '1998-01-01'
group by c.ContactName
--20 
select c.ContactName
from orders o 
inner JOIN customers c on o.CustomerID = c.CustomerID
where o.OrderDate in (
select max(o.OrderDate) 
from orders o)
--23
select s.CompanyName as 'SupplierCompanyName', h.CompanyName as 'ShippingCompanyName'
from Suppliers s
inner join Products p on s.SupplierID = p.SupplierID
inner join [Order Details] d on p.ProductID = d.ProductID
inner join Orders o on o.OrderID = d.OrderID
inner join Shippers h on h.ShipperID = o.ShipVia
group by s.CompanyName, h.CompanyName
--26
select e1.LastName + ' ' + e1.FirstName as "Manager Name"
from Employees e1 join Employees e2 on e1.EmployeeID = e2.ReportsTo
group by e1.LastName + ' ' + e1.FirstName
having count(e2.EmployeeID) > 2