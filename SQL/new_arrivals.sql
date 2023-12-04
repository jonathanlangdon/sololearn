-- use UNION to combine a table of new books and books > 1900

SELECT name, year FROM Books
WHERE year > 1900
UNION
SELECT name, 2022 FROM New
ORDER BY name ASC