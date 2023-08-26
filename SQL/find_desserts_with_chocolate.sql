-- use LIKE to find entries containing a keyword

SELECT * FROM Desserts
WHERE name LIKE '%Chocolate%'
ORDER BY price ASC