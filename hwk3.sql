use Northwind

--3
select dt.ProductName, sum(dt.quantity) as "TotalOrderQuantity"
from (
    select p.ProductID,p.ProductName, d.quantity  from Products p inner join [Order Details] d on p.ProductID = d.ProductID
) dt
group by dt.ProductID,dt.ProductName

--4
select dt.City, count(dt.OrderId) as "TotalProductOrder"
from (
    select o.OrderId, c.City
    from Customers c inner join Orders o on c.CustomerID = o.CustomerID
    ) dt
group by dt.City

--5a use union 
SELECT City FROM Customers
group by city
having count(customerID) > 2
UNION
SELECT shipcity FROM Orders
group by shipcity 
having count(customerID) > 2

--5b use subquery
select dt.city
from (select c.city, o.CustomerID from Customers c inner join Orders o on c.City = o.ShipCity) dt
group by dt.city 
having count(dt.CustomerID) > 2

--8 
select top 5 dt.ProductID,dt.avgprice,dt.popularity,dt.city
from (
    select d.ProductID, avg(d.UnitPrice*d.quantity) as "avgprice", sum(d.quantity) as 'popularity',c.city
    from Products p join [order Details] d on p.ProductID = d.ProductID 
    join Orders o on o.OrderID = d.OrderId
    join Customers c on c.customerID = o.CustomerID
    group by d.ProductID,c.city
)dt
order by dt.popularity desc

--9a.Use sub-query
select city
from employees
where city not in (select c.city
from Customers c left join orders o on c.CustomerID = o.customerID)

--9b.Do not use sub-query
select e.city
from employees e left join orders o on e.city = o.shipcity
where o.shipcity IS NULL

--10
select *
from (select top 1 e.employeeID, count(o.OrderId) as "NumberOfOrdersSold"
from employees e inner join orders o on e.EmployeeID = o.EmployeeID
group by e.employeeID
order by NumberOfOrdersSold desc) dt1
inner join
(select top 1 e.employeeID,count(o.OrderId) as "NumberOfOrdersSold",o.shipcity
from employees e inner join orders o on e.EmployeeID = o.EmployeeID
group by o.shipcity,e.employeeID
order by NumberOfOrdersSold desc) dt2
on dt1.employeeID = dt2.EmployeeID

--11 How do you remove the duplicates record of a table?
--we can use the CTE with ROWNUMBER() to remove duplicate
--the rownumber() with partitionby() allows to group the rows while giving row count to each record,
--therefore when we perform the above functions along with DELETE FROM WHERE rowcount > 1
--we can successfully delete the duplicated rows. 