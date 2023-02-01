
SELECT p.name AS ProdName, c.name AS CatName FROM Products p
JOIN ProductCategory pc on p.prodid = pc.productid
LEFT JOIN Category c on pc.catid = c.catid;

