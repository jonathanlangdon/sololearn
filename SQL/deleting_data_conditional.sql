-- delete data based on a condition

DELETE FROM Products
WHERE expiredate < 1;
SELECT * FROM Products;