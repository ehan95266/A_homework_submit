use AdventureWorks2019
--1
Select ProductId, Name, Color, ListPrice
From Production.Product
--2
Select ProductId, Name, Color, ListPrice
From Production.Product
Where ListPrice <> 0
--3
Select ProductId, Name, Color, ListPrice
From Production.Product
Where Color IS NOT NULL
--4
Select ProductId, Name, Color, ListPrice
From Production.Product
Where Color IS NOT NULL AND ListPrice > 0
--5
Select Name + ' ' + color AS 'name and color'
From Production.Product
Where Color IS NOT NULL
--6
Select Name, color
From Production.Product
Where color in ('Black','Silver')

Select 'Name' + ':' + Name + '--' + 'color'+':' + Color AS 'name and color'
From Production.Product
Where color in ('Black','Silver')
--8
Select ProductId, Name
From Production.Product
Where ProductID BETWEEN 400 AND 500
--9
Select productId, Name, color
From Production.Product
Where color in ('Black','Blue')
--10
Select Name,ListPrice
FROM Production.Product
WHERE Name LIKE 'S%'
Order By Name
--12
Select Name,ListPrice
FROM Production.Product
WHERE Name LIKE 'A%' OR Name LIKE 'S%'
Order By Name
--13
Select Name
FROM Production.Product
WHERE Name LIKE '[SPO]%' AND Name NOT LIKE '%K%' 
Order By Name
--14
Select Distinct Color
From Production.Product
Order By Color Desc
