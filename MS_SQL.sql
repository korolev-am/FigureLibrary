-- Пусть есть две таблицы, Product_Category и Category_Product
-- содержащие соответствия продукт-категория и категория-продукт соответственно
-- CREATE TABLE Category_Product (
--     Category varchar(255),
--     Product varchar(255)
-- ); 
-- CREATE TABLE Product_Category (
--     Product varchar(255),
--     Category varchar(255)
-- ); 

SELECT product, category FROM Product_Category
UNION
SELECT product, category from Category_Product
ORDER BY category DESC