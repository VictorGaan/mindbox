SELECT CASE WHEN Categories.Name IS NOT NULL THEN CONCAT(Products.Name,' - ', Categories.Name) ELSE Products.Name END AS ProductName
FROM Products 
LEFT OUTER JOIN Categories 
ON Products.CategoryId = Categories.Id;