CREATE TABLE Products (
	prodID int NOT NULL PRIMARY KEY,
	name varchar(50) NOT NULL UNIQUE
);

CREATE TABLE Category (
	catID int NOT NULL PRIMARY KEY,
	name varchar(50) NOT NULL
);

CREATE TABLE ProductCategory(
	productID int NOT NULL,
	catID int	
);

INSERT INTO Products VALUES(1,'Хлеб'),(2,'Кокос'),(3,'Молоко'),(4,'Кефир'),(5,'Творог'),(6,'Плюшка'),(7,'Колбаса');
INSERT INTO Category VALUES(1,'Хлебные изделия'),(2,'Молочные изделия'),(3,'Кисло-молочные изделия'),
(4,'Кондитерские изделия'),(5,'Творог');

INSERT INTO ProductCategory VALUES (1,1),(3,2),(4,2),(4,3),(5,2),(5,3),(5,4),(6,1),(6,4);

INSERT INTO ProductCategory(productID) VALUES (2),(7);

