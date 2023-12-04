-- use a RIGHT JOIN to count number of books written by authors

SELECT A.name, COUNT(B.id) AS books
FROM Books AS B RIGHT JOIN Authors AS A
ON B.author_id = A.id
GROUP BY A.name
ORDER BY books DESC