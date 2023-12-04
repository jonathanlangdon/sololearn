-- query a table from multiple tables

SELECT Books.name, Books.year, Authors.name AS author
FROM Authors, Books
WHERE Books.author_id = Authors.id
ORDER BY Authors.name ASC, year ASC