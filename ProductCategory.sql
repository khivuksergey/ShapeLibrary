/*
  Данные о продуктах и категориях хранятся в соответствующих таблицах
*/
CREATE TABLE Category(
  Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  Name NVARCHAR(MAX) NOT NULL
)

CREATE TABLE Product(
  Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  Name NVARCHAR(MAX) NOT NULL
)
/*
  Для реализации связи многие ко многим существует промежуточная таблица,
  в которой хранятся все связи продуктов с категориями
*/
CREATE TABLE ProductCategory(
  ProductId INT NOT NULL,
  CategoryId INT,
  PRIMARY KEY (ProductId, CategoryId),
  CONSTRAINT FK_ProductId FOREIGN KEY (ProductId) REFERENCES Product(Id),
  CONSTRAINT FK_CategoryId FOREIGN KEY (CategoryId) REFERENCES Category(Id)
)
/*
  Чтобы выбрать все пары продукт-категория, даже если продукту никакая категория
  не соответствует, будем изначально выбирать именно из таблицы Product
*/
SELECT
  P.Name AS [Product],
  C.Name AS [Category]
FROM Product P
  LEFT JOIN ProductCategory PC ON PC.ProductId = P.Id
  LEFT JOIN Category C ON C.Id = PC.CategoryId
