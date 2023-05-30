SELECT Products.Name AS ProductName, Categories.Name as CategoryName
FROM Products
LEFT OUTER JOIN Categories
ON Products.CategoryId = Categories.Id